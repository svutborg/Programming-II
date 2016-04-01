using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace SocketTest
{
    public partial class FormMain : Form
    {
        Socket ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        byte[] Buffer = new byte[48];

        public FormMain()
        {
            InitializeComponent();
            
        }

        private void checkBoxConnect_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxConnect.Checked)
            {
                checkBoxConnect.Text = "Connecting...";
                EstablishConnection();
                UpdateButton();
            }
            else
            {
                checkBoxConnect.Text = "Connect";
                UpdateButton();
            }
        }

        private void EstablishConnection()
        {
            IPAddress[] addresses = Dns.GetHostEntry(textBoxServerAddress.Text).AddressList;
            ServerSocket.Connect(new IPEndPoint(addresses[0], 123)); 
        }

        private void UpdateButton()
        {
            if (ServerSocket.Connected)
            {
                checkBoxConnect.Text = "Connected";
                richTextBoxReply.AppendText(string.Format("Connection to {0} established\n", textBoxServerAddress.Text));
                textBoxServerAddress.Enabled = false;
                Buffer[0] = 0x1B;
                ServerSocket.Send(Buffer);
                ServerSocket.ReceiveTimeout = 5000;
                int bytes = ServerSocket.Receive(Buffer);

                richTextBoxReply.AppendText(Encoding.UTF8.GetChars(Buffer).ToString());
            }
            else
            {
                checkBoxConnect.Checked = false;
                textBoxServerAddress.Enabled = true;
            }
        }

    }
}
