using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onscreen_keyboard
{
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("1");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            SendKeys.Send("2");
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            SendKeys.Send("q");
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            SendKeys.Send("w");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SendKeys.Send("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SendKeys.Send("5");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SendKeys.Send("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SendKeys.Send("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SendKeys.Send("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            SendKeys.Send("0");
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            SendKeys.Send("e");
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            SendKeys.Send("r");
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            SendKeys.Send("t");
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            SendKeys.Send("y");
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            SendKeys.Send("u");
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            SendKeys.Send("i");
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            SendKeys.Send("o");
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            SendKeys.Send("p");
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            SendKeys.Send("a");
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            SendKeys.Send("s");
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            SendKeys.Send("d");
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            SendKeys.Send("f");
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            SendKeys.Send("g");
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            SendKeys.Send("h");
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            SendKeys.Send("j");
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            SendKeys.Send("k");
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            SendKeys.Send("l");
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            SendKeys.Send("z");
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            SendKeys.Send("x");
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            SendKeys.Send("c");
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            SendKeys.Send("v");
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            SendKeys.Send("b");
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            SendKeys.Send("n");
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            SendKeys.Send("m");
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void buttonSPACE_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }
    }
}
