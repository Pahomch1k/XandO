using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XandO
{
    public partial class Form1 : Form
    {
        int C = 0;
        int[] count = new int[9] { 0,0,0,0,0,0,0,0,0 };
        public Form1()
        {
            InitializeComponent();
        }

        public int Pobeda()
        { 
            if (count[0] == 1 && count[1] == 1 && count[2] == 1 ||
                 count[3] == 1 && count[4] == 1 && count[5] == 1 ||
                 count[6] == 1 && count[7] == 1 && count[8] == 1 ||
                 count[0] == 1 && count[3] == 1 && count[6] == 1 ||
                 count[1] == 1 && count[4] == 1 && count[7] == 1 ||
                 count[2] == 1 && count[5] == 1 && count[8] == 1 ||
                 count[0] == 1 && count[4] == 1 && count[8] == 1 ||
                 count[2] == 1 && count[4] == 1 && count[6] == 1)
            {
                MessageBox.Show("pobeda X");
                return 1;
            }
            else if (count[0] == 2 && count[1] == 2 && count[2] == 2 ||
                 count[3] == 2 && count[4] == 2 && count[5] == 2 ||
                 count[6] == 2 && count[7] == 2 && count[8] == 2 ||
                 count[0] == 2 && count[3] == 2 && count[6] == 2 ||
                 count[1] == 2 && count[4] == 2 && count[7] == 2 ||
                 count[2] == 2 && count[5] == 2 && count[8] == 2 ||
                 count[0] == 2 && count[4] == 2 && count[8] == 2 ||
                 count[2] == 2 && count[4] == 2 && count[6] == 2)
            {
                MessageBox.Show("pobeda O");
                return 1;
            }
            return 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button[] B = new Button[9] { button1, button2, button3, button4, button5, button6, button7, button8, button9};
            Button b = (Button)sender;

            if (C % 2 == 0)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (b == B[j])
                    {
                        B[j].Image = Image.FromFile("x.png");
                        B[j].Enabled = false;
                        count[j] = 1;
                    }
                }
            }
            else
            {
                for (int j1 = 0; j1 < B.Length; j1++)
                {
                    if (b == B[j1])
                    {
                        B[j1].Image = Image.FromFile("o.png");
                        B[j1].Enabled = false;
                        count[j1] = 2;
                    }
                }
            }
            C++;
            int f = Pobeda();
            if (f != 0) for (int i = 0; i < B.Length; i++) B[i].Enabled = false;  
        }

        private void стартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button[] B = new Button[9] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            for (int i = 0; i < B.Length; i++) B[i].Enabled = true;
            for (int i = 0; i < B.Length; i++) B[i].Image = null; 
            C = 0;
            for (int i = 0; i < 9; i++) count[i] = 0; 
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
} 