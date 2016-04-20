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
using System.Net.NetworkInformation;
using System.Threading;

namespace p2p_messenger
{
    public partial class FormMain : Form
    {
        Socket HostSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Thread Listener;
        Encoding TransmissionEncoder = Encoding.ASCII;

        public FormMain()
        {
            InitializeComponent();
            Listener = new Thread(ListenerThread);
            Listener.IsBackground = true;
            Listener.Start();
        }

        private void toolStripButtonConnect_Click(object sender, EventArgs ea)
        {
            try
            {
                HostSocket.Connect(IPAddress.Parse(toolStripTextBoxIP.Text), int.Parse(toolStripTextBoxPort.Text));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void ListenerThread(object param)
        {
            try
            {
                TcpListener List = new TcpListener(IPAddress.Parse("127.0.0.1"), int.Parse(toolStripTextBoxPort.Text));
                this.Invoke((MethodInvoker)delegate { toolStripStatusLabelListener.Text = "Waiting for incomming connection..."; });
                List.Start();

                ClientSocket = List.AcceptSocket();
                this.Invoke((MethodInvoker)delegate { toolStripStatusLabelListener.Text = "Remote connection accepted"; });
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (HostSocket.Connected)
                {
                    HostSocket.Send(TransmissionEncoder.GetBytes(textBoxSend.Text));
                    textBoxSend.Text = "";
                }
            }
        }

        private void richTextBoxRecieve_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
