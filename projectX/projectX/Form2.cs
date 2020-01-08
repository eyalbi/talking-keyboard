using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace projectX
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\project talking keyboard\projectX\projectX\Database1.mdf""; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from login where username ='" + textBox2.Text + "'and password= '" + textBox1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                Main main = new Main(textBox2.Text);
                main.Owner = this;
                main.Show();
                this.Hide();
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("incorrect username or password");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label3.Text = DateTime.Now.ToLongTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\project talking keyboard\projectX\projectX\Database1.mdf"";Integrated Security=True";
            using(SqlConnection sqlcon = new SqlConnection(conn))
            {

                string query = "insert into login (username, password, user_type) values ('" + textBox2.Text + "','" + textBox1.Text + "','" + comboBox1.SelectedText + "') ;";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                SqlDataReader reader;
                try
                {
                    sqlcon.Open();
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("saved succesfully");
                    while (reader.Read())
                    {

                    }

                }
                catch (Exception ex){
                    MessageBox.Show("user name already exist");
                
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\WinSxS\amd64_microsoft-windows-osk_31bf3856ad364e35_10.0.18362.449_none_0098d787eb84df09\osk.exe");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}
