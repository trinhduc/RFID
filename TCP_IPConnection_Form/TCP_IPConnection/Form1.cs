using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Threading;
using System.Data.SqlClient;

namespace TCP_IPConnection
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(ConnectionString.connectionString);
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTCP.SimpleTcpServer server;
        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTCP.SimpleTcpServer();
            server.Delimiter = 0x13; // Enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtstatus.Invoke((MethodInvoker)delegate ()
            {
                String trueID = Regex.Match(e.MessageString, @"\d+").Value;
                txtstatus.Text += Environment.NewLine;
                if(Int64.Parse(trueID) > 100000000 && Int64.Parse(trueID) < 1000000000)
                {
                    txtID.Text = trueID;
                    txtstatus.Text += "Product ID: " + trueID + Environment.NewLine;
                }
                else if(Int64.Parse(trueID) > 1000000000 && Int64.Parse(trueID) < 10000000000)
                {
                    txtPlank.Text = trueID;
                    txtstatus.Text += "Plank ID: " + trueID + Environment.NewLine;
                }
                else
                {
                    txtstatus.Text += "Invalid ID: " + trueID + Environment.NewLine;
                }
            });
        }
        public void thongtin()
        {
            string query = "select * from HangHoa";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtGV.DataSource = dt;
            dtGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            connection.Close();
        }
        System.Windows.Forms.Timer tmr = null;
        private void StartTimer()
        {
            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            DateTime tm = DateTime.Now;
            txtTIn.Text = tm.ToString("yyyy/MM/dd hh:mm:ss tt");
        }
        private void btncon_Click(object sender, EventArgs e)
        {
            if(server.IsStarted)
            {

            }
            else
            {
                thongtin();
                txtstatus.Text += "Server starts...." + Environment.NewLine;
                txtstatus.Text += "Ready to read ID !" + Environment.NewLine;
                System.Net.IPAddress ip = System.Net.IPAddress.Parse(txthost.Text);
                server.Start(ip, Convert.ToInt32(txtport.Text));
                StartTimer();
                progressBar1.Value = 100;
            }
        }

        private void btndis_Click(object sender, EventArgs e)
        {
            if(server.IsStarted)
            {
                txtstatus.Text += "Server stops..." + Environment.NewLine;
                server.Stop();
                progressBar1.Value = 0;
            }
        }

        private void txtstatus_TextChanged(object sender, EventArgs e)
        {
            txtstatus.SelectionStart = txtstatus.TextLength;
            txtstatus.ScrollToCaret();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DateTime to = new DateTime(1900, 01, 01, 00, 00, 00);
            string tout = to.ToString("yyyy/MM/dd hh:mm:ss");
            if (txtID.Text == String.Empty || txtPlank.Text == String.Empty || txtName.Text == string.Empty || txtQtt.Text == string.Empty || cbCompany.Text == string.Empty)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string sqlinsert = "INSERT INTO HangHoa VALUES(@ID, @Plank, @Name, @Quantity, @Company, @TimeIN, @TimeOUT)";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlinsert, connection);
                    cmd.Parameters.AddWithValue("ID", txtID.Text);
                    cmd.Parameters.AddWithValue("Plank", txtPlank.Text);
                    cmd.Parameters.AddWithValue("Name", txtName.Text);
                    cmd.Parameters.AddWithValue("Quantity", txtQtt.Text);
                    cmd.Parameters.AddWithValue("Company", cbCompany.Text);
                    cmd.Parameters.AddWithValue("TimeIN", txtTIn.Text);
                    cmd.Parameters.AddWithValue("TimeOUT", tout);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    thongtin();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Duplicated ID");
                }
            }

        }

        private void dtGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            server.Stop();
            Application.Exit();
        }
    }
}
