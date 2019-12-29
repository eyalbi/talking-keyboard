using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
using System.Data.SqlClient;
//using Microsoft.speech.synthesis;
// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace projectX
{
    public partial class Main : Form
    {
        private String user;

        public Main(String user1)
        {
            InitializeComponent();
            user = user1;
            
        }


        void button2_Click(object sender, EventArgs e)
        {

            SpeechSynthesizer sd = new SpeechSynthesizer();
            String ogu = textBox2.Text;
            sd.Rate = -2;
            sd.SelectVoiceByHints(VoiceGender.Male);
            sd.Volume = trackBar1.Value;
            if (ogu.StartsWith("'") && ogu.EndsWith("'"))
            {
                sd.Speak("quote:");
            }
            sd.Speak(ogu);
            if (ogu.Length < 1)
            {
                ogu = comboBox2.Text;
                sd.Speak(ogu);
            }


        }


        void textBox2_TextChanged(object sender1, EventArgs e1)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Sentences' table. You can move, or remove it, as needed.
            this.sentencesTableAdapter.Fill(this.database1DataSet.Sentences);
            timer1.Start();
            timer2.Start();
            label3.Text = DateTime.Now.ToLongTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
            label6.Text = DateTime.MinValue.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Sandy brown")
            {
                BackColor = Color.SandyBrown;
            }
            if (comboBox1.Text == "Salmon orange")
            {
                BackColor = Color.LightSalmon;
            }
            if (comboBox1.Text == "Navajo white")
            {
                BackColor = Color.NavajoWhite;
            }
            if (comboBox1.Text == "Burly wood")
            {
                BackColor = Color.BurlyWood;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\project talking keyboard\projectX\projectX\Database1.mdf""; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from login where username ='" + user + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //Form2 form2 = new Form2();
            if (dt.Rows[0][2].ToString()=="visual impairment")
            {
                exit form1 = new exit(user);
                form1.Owner = this;
                form1.Show();
                SpeechSynthesizer sd = new SpeechSynthesizer();
                sd.Rate = -2;
                sd.Speak("if you want to log out press 'yes' else press 'no'");
            }
            else
            {
                this.Owner.Show();
                this.Close();
                //form2.Show();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            keyboard onscreen_keyboard = new keyboard();
            onscreen_keyboard.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            label6.Text = DateTime.MinValue.ToLongTimeString();
            timer2.Start();
        }
    }
} 
