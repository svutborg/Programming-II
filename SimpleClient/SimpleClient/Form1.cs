using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SimpleClient
{
    public partial class Form1 : Form
    {
        Socket S;
        Thread ClientThread;
        delegate void ListboxAdderDelegate(string item);
        delegate void EnableControlsDelegate(bool state);

        bool KillThread = true;
        Encoding Enc = Encoding.ASCII;

        public Form1()
        {
            InitializeComponent();
            EnableControls(true);
            S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if(KillThread == true)
            {
                KillThread = false;
                ClientThread = new Thread(CThread);
                ClientThread.Name = "Client Thread";
                ClientThread.IsBackground = true;
                ClientThread.Start();
            }
            else
            {
                KillThread = true;
            }
        }

        private void ListboxAdd(string item)
        {
            listBoxReceive.Items.Add(item);
            listBoxReceive.TopIndex = listBoxReceive.Items.Count - 1;
        }

        private void CThread(object arg)
        {
            ListboxAdderDelegate LA = new ListboxAdderDelegate(ListboxAdd);
            EnableControlsDelegate EC = new EnableControlsDelegate(EnableControls);
            if ((textBoxIP.Text != "") && (textBoxPort.Text != ""))
            {
                try
                {
                    S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    S.Connect(textBoxIP.Text, int.Parse(textBoxPort.Text));
                    this.Invoke(EC, false);
                }
                catch (SocketException)
                {
                    KillThread = true;
                    MessageBox.Show("Could not connect");
                }
            }

            while (!KillThread)
            {
                byte[] RecieveBuffer = new byte[100];
                try
                {
                    if (S.Available > 0)
                    {
                        S.Receive(RecieveBuffer);
                        this.Invoke(LA, Enc.GetString(RecieveBuffer).TrimEnd('\0'));
                    }
                }
                catch(SocketException)
                {
                    KillThread = true;
                    MessageBox.Show("Host disconnected!");
                }

                Thread.Sleep(300);
            }

            if (S.Connected)
            {
                try
                {
                    S.Shutdown(SocketShutdown.Both);
                    S.Close();
                }
                catch (SocketException se)
                {
                    MessageBox.Show(se.Message);
                }
            }
            this.Invoke(EC, true);
        }

        private void EnableControls(bool state)
        {
            textBoxIP.Enabled = state;
            textBoxPort.Enabled = state;
            textBoxSend.Enabled = !state;
            listBoxReceive.Enabled = !state;
            buttonSend.Enabled = !state;
            if(state)
            {
                buttonConnect.Text = "Connect";
            }
            else
            {
                buttonConnect.Text = "Disconnect";
            }
        }

        private void SendMessage(string message)
        {
            if(S.Connected)
            {
                S.Send(Encoding.ASCII.GetBytes(message.TrimEnd('\0')));
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            SendMessage(textBoxSend.Text);
            textBoxSend.Clear();
        }

        private void textBoxSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                SendMessage(textBoxSend.Text);
                textBoxSend.Clear();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            KillThread = true;
        }
    }
}
