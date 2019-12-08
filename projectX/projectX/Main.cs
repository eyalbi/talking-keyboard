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
//using Microsoft.speech.synthesis;
// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace projectX
{
    public partial class Main: Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        
        void button2_Click(object sender, EventArgs e)
        {
            
            SpeechSynthesizer sd = new SpeechSynthesizer();
            String ogu = textBox2.Text;
            sd.Rate = 0;
            if (radioButton1.Checked)
            {
                sd.SelectVoiceByHints(VoiceGender.Male);
                sd.Volume = trackBar1.Value;
                sd.Speak(ogu);
            }
            if (radioButton2.Checked)
            {
                sd.SelectVoiceByHints(VoiceGender.Female,VoiceAge.Teen);
                sd.Volume = trackBar1.Value;
                sd.Speak(ogu);
            }

        }

        
        void textBox2_TextChanged(object sender1, EventArgs e1)
        {
                      
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label3.Text = DateTime.Now.ToLongTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
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
    }
}
