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
using System.IO.Ports;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(ConnectionString.connectionString);
        String inputdata = String.Empty;
        delegate void SetTextCallback(string text);
        public Form1()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(dataReceived);
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
            connection.Close();
            dataGridView1.DataSource = dt;
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
            textBox6.Text = tm.ToString("yyyy/MM/dd hh:mm:ss tt");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames(); // tạo 1 chuỗi ports chứa tất cả các cổng COM đang hoạt động.
            cbPort.Items.AddRange(ports); // đổ hết chuỗi ports vào combobox Port.
        }
        private void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            inputdata = serialPort1.ReadExisting();
            if (inputdata !=String.Empty)
            {
                SetText(inputdata);
            }
        }
        private void SetText(string text)
        {
            if (this.textBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else
            {
                String trueID = Regex.Match(text, @"\d+").Value;
                if (Int64.Parse(trueID) > 100000000 && Int64.Parse(trueID) <= 999999999)
                    {
                        textBox4.Text += text;
                        textBox1.Text = trueID;
                    }
                    else if (Int64.Parse(trueID) > 1000000000 && Int64.Parse(trueID) < 99999999999)
                    {
                        textBox4.Text += text;
                        textBox5.Text = trueID;
                    }
                    else
                    {
                        textBox4.Text += text;
                    }
            }
        }
        private void btncon_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cbPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbBaud.Text);
                serialPort1.Open();
                if(serialPort1.IsOpen)
                {
                    StartTimer();
                    thongtin();
                }
                progressBar1.Value = 100;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void btnDis_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                tmr.Stop();
                progressBar1.Value = 0;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
                textBox4.SelectionStart = textBox4.TextLength;
                textBox4.ScrollToCaret();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DateTime to = new DateTime(1900, 01, 01, 00, 00, 00);
            string tout = to.ToString("yyyy/MM/dd hh:mm:ss");
            if (textBox1.Text == String.Empty || textBox5.Text == String.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
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
                    cmd.Parameters.AddWithValue("ID", textBox1.Text);
                    cmd.Parameters.AddWithValue("Plank", textBox5.Text);
                    cmd.Parameters.AddWithValue("Name", textBox2.Text);
                    cmd.Parameters.AddWithValue("Quantity", textBox3.Text);
                    cmd.Parameters.AddWithValue("Company", cbCompany.Text);
                    cmd.Parameters.AddWithValue("TimeIN", textBox6.Text);
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
    }
}
