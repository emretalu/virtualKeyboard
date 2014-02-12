using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace virtualKeyboard
{
    public partial class Form1 : Form
    {
        Button[] harfler;
        Button[] sayilar;
        public Form1()
        {
            InitializeComponent();
            harfler = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button27, button28, button29, button30, button31, button32, button33, button34, button35, };
            sayilar = new Button[] { button40, button41, button42, button43, button46, button47, btn_arrow, button1, button12 };
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btn_Backspace_Click(object sender, EventArgs e)
        {
            int length = textBox1.Text.Length;
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "";
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(length - 1, 1);
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ";
        }

        private void btn_Shift_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Button button in harfler)
            {
                if (btn_Shift.Checked)
                {
                    button.Text = button.Text.ToUpper();
                    btn_Shift.BackColor = Color.DimGray;
                    btn_dot.Text = ":";
                    btn_comma.Text = ";";                                       
                    btn_arrow.Text = ">";
                    btn_e.Text = "é";
                    button49.Text = "!";
                    button48.Text = "'";
                    button47.Text = "^";
                    button46.Text = "+";
                    button45.Text = "%";
                    button43.Text = "/";
                    button42.Text = "(";
                    button41.Text = ")";
                    button40.Text = "=";
                    btn_star.Text = "?";
                    btn_dash.Text = "_";
                }
                else
                {
                    button.Text = button.Text.ToLower();
                    btn_Shift.BackColor = SystemColors.Control;
                    btn_dot.Text = ".";
                    btn_comma.Text = ",";
                    btn_dash.Text = "-";
                    btn_star.Text = "*";
                    btn_arrow.Text = "<";
                    btn_e.Text = "''";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_AltGr_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Button button in sayilar)
            {
                if (btn_AltGr.Checked)
                {
                    btn_AltGr.BackColor = Color.DimGray;
                    button40.Text = "}";
                    button41.Text = "]";
                    button42.Text = "[";
                    button43.Text = "{";
                    button46.Text = "$";
                    button47.Text = "#";
                    btn_arrow.Text = "|";
                    button1.Text = "@";
                    button12.Text = "~";
                    
                }
                else
                {
                    btn_AltGr.BackColor = SystemColors.Control;
                    button40.Text = "0";
                    button41.Text = "9";
                    button42.Text = "8";
                    button43.Text = "7";
                    button46.Text = "4";
                    button47.Text = "3";
                    btn_arrow.Text = "<";
                    if (btn_Shift.Checked)
                    {
                        button1.Text = "Q";
                        button12.Text = "Ü";
                    }
                    else
                    {
                        button1.Text = "q";
                        button12.Text = "ü";
                    }
                }
            }
        }
    }
}
