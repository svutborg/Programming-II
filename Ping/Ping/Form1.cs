using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;

namespace Ping
{
    public partial class MainForm : Form
    {
        System.Net.NetworkInformation.Ping Pinger = null; // Including the namespace for Ping is only nessesary because the local namespace is also called Ping

        public MainForm()
        {
            InitializeComponent();
        }

        private void textBoxAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxAddress.Enabled = false;
                Pinger = new System.Net.NetworkInformation.Ping();
                Thread SenderThread = new Thread(SenderMethod);
                SenderThread.Start(textBoxAddress.Text);
            }
        }

        private void SenderMethod(object param)
        {
            string address = param as string;
            PingReply Reply = null;

            this.Invoke((MethodInvoker)delegate {
                richTextBoxReply.AppendText(string.Format(
                    "{0} Pinging: {1} with 32 bytes of data {2}\n", 
                    new string('=', 18 - address.Length/2), 
                    address, 
                    new string('=', 18 - address.Length/2 - address.Length % 2))
                );
            });
            try
            {
                Reply = Pinger.Send(address);
                if (Reply.Status == IPStatus.Success)
                {
                    this.Invoke((MethodInvoker) delegate { richTextBoxReply.AppendText(string.Format("Recieved reply from: {0}\n", address)); });
                    this.Invoke((MethodInvoker)delegate { richTextBoxReply.AppendText(string.Format("Roundtrip time: {0}\n", Reply.RoundtripTime)); });
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate { richTextBoxReply.AppendText(Reply.Status.ToString() + "\n"); });
                }
            }
            catch(ArgumentNullException)
            {
                this.Invoke((MethodInvoker)delegate { richTextBoxReply.AppendText("You have to enter something...\n"); });
            }
            catch(PingException pe)
            {
                this.Invoke((MethodInvoker)delegate { richTextBoxReply.AppendText(pe.InnerException.Message+"\n"); });
            }
            finally
            {
                this.Invoke((MethodInvoker)delegate { textBoxAddress.Enabled = true; textBoxAddress.Focus(); });
            }
        }
    }
}
