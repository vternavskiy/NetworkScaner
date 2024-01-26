using System.Data;
using System.Web;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using static WindowsFormPing.Form1;
using System.Diagnostics.Metrics;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormPing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.AllowUserToAddRows = false; //doesn't show bottom empty line
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            { textBox2.Text = textBox1.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.AllowUserToAddRows = false; //doesn't show bottom empty line

            dataGridView.Rows.Clear();


            if (textBox1.Text != null)
            {

                string IPAddress1 = textBox1.Text;
                string IPAddress2 = textBox2.Text;

                string IPAddressForPing = IPAddress1;

                string[] IPAddress2_Octets = IPAddress2.Split('.');
                string IPAddress2Next = $"{IPAddress2_Octets[0]}.{IPAddress2_Octets[1]}.{IPAddress2_Octets[2]}.{Convert.ToInt32(IPAddress2_Octets[3]) + 1}";

                while (IPAddressForPing != IPAddress2Next)
                {
                    Ping PingClient = new Ping();
                    var PingResult = PingClient.Send(IPAddressForPing);

                    string HostnameResult;

                    try
                    {
                        var Hostname = Dns.GetHostEntry(IPAddressForPing);
                        HostnameResult = Hostname.HostName;
                    }
                    catch (SocketException ex)
                    {
                        HostnameResult = "Unknown";
                    }

                    dataGridView.Rows.Add(Convert.ToString(PingResult.Address), HostnameResult);

                    string[] IPAddressForPing_Octets = IPAddressForPing.Split('.');
                    if (Convert.ToInt32(IPAddressForPing_Octets[3]) < 255)
                    {
                        IPAddressForPing = $"{IPAddressForPing_Octets[0]}.{IPAddressForPing_Octets[1]}.{IPAddressForPing_Octets[2]}.{Convert.ToInt32(IPAddressForPing_Octets[3]) + 1}";
                    }

                    if (Convert.ToInt32(IPAddressForPing_Octets[3]) == 254)
                    {
                        IPAddressForPing = $"{IPAddressForPing_Octets[0]}.{IPAddressForPing_Octets[1]}.{Convert.ToInt32(IPAddressForPing_Octets[2]) + 1}.{IPAddressForPing_Octets[3]}";
                    }

                }
            }
        }
    }
}
