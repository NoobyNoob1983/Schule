using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    
    public partial class Form1 : Form
    {

        static Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Spieler X ist dran";
            
        }
        

        string lastKey = "";
        string key = "";
        string text = "";
        bool win = false;
        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void textBox1_click(object sender, EventArgs e)
        {
            TextBox textBoxen = (TextBox)sender;

            label1.Text = "Spieler " + key + " ist dran";

            // RealPLayer
            if (lastKey == "" || lastKey == "O")
            {
                if (textBoxen.Text == "")
                {
                    textBoxen.Text = "X";
                    lastKey = "X";
                    key = "O";
                }

            }
            textBoxen.Enabled = false;
            progressBar1.Increment(12);


            win = false;

            CheckWin(ref lastKey);

            textBox1_TextChanged(sender, e);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            System.Threading.Thread.Sleep(20);


            TextBox[] boxen = new TextBox[9];
            boxen[0] = textBox1;
            boxen[1] = textBox2;
            boxen[2] = textBox3;
            boxen[3] = textBox4;
            boxen[4] = textBox5;
            boxen[5] = textBox6;
            boxen[6] = textBox7;
            boxen[7] = textBox8;
            boxen[8] = textBox9;

            int zufall = random.Next(0, 9);


            if (lastKey == "X")
            {
                CheckWin(ref lastKey);

                
                if (boxen[8].Text == "X" && boxen[4].Text == "X" || boxen[8].Text == "O" && boxen[4].Text == "O" && boxen[0].Enabled == true)
                {
                    zufall = 0;
                }
                else if (boxen[1].Text == "X" && boxen[2].Text == "X" || boxen[1].Text == "O" && boxen[2].Text == "O"  && boxen[0].Enabled == true)
                {
                    zufall = 0;
                }


                if (boxen[0].Text == "X" && boxen[2].Text == "X" || boxen[0].Text == "O" && boxen[2].Text == "O"  && boxen[1].Enabled == true)
                {
                    zufall = 1;
                }
                else if(boxen[7].Text == "X" && boxen[4].Text == "X" || boxen[7].Text == "O" && boxen[4].Text == "O" && boxen[1].Enabled == true)
                {
                    zufall = 1;
                }


                if (boxen[0].Text == "X" && boxen[1].Text == "X" || boxen[0].Text == "O" && boxen[1].Text == "O" && boxen[2].Enabled == true)
                {
                    zufall = 2;
                }
                else if(boxen[8].Text == "X" && boxen[5].Text == "X" || boxen[8].Text == "O" && boxen[5].Text == "O" && boxen[2].Enabled == true)
                {
                    zufall = 2;
                }


                if (boxen[0].Text == "X" && boxen[6].Text == "X" || boxen[0].Text == "O" && boxen[6].Text == "O" && boxen[3].Enabled == true)
                {
                    zufall = 3;
                }
                else if(boxen[4].Text == "X" && boxen[5].Text == "X" || boxen[4].Text == "O" && boxen[5].Text == "O" && boxen[3].Enabled == true)
                {
                    zufall = 3;
                }


                if (boxen[2].Text == "X" && boxen[6].Text == "X" || boxen[2].Text == "O" && boxen[6].Text == "O" && boxen[4].Enabled == true)
                {
                    zufall = 4;
                }
                else if(boxen[0].Text == "X" && boxen[8].Text == "X" || boxen[0].Text == "O" && boxen[8].Text == "O" && boxen[4].Enabled == true)
                {
                    zufall = 4;
                }
                else if(boxen[3].Text == "X" && boxen[5].Text == "X" || boxen[3].Text == "O" && boxen[5].Text == "O" && boxen[4].Enabled == true)
                {
                    zufall = 4;
                }
                else if(boxen[1].Text == "X" && boxen[7].Text == "X" || boxen[1].Text == "O" && boxen[7].Text == "O" && boxen[4].Enabled == true)
                {
                    zufall = 4;
                }


                if(boxen[3].Text == "X" && boxen[4].Text == "X" || boxen[3].Text == "O" && boxen[4].Text == "O" && boxen[5].Enabled == true)
                {
                    zufall = 5;
                }
                else if(boxen[2].Text == "X" && boxen[3].Text == "X" || boxen[2].Text == "O" && boxen[3].Text == "O" && boxen[5].Enabled == true)
                {
                    zufall = 5;
                }

                // geändert 0 : 3 in 0 : 4
                if (boxen[0].Text == "X" && boxen[3].Text == "X" || boxen[0].Text == "O" && boxen[3].Text == "O" && boxen[6].Enabled == true)
                {
                    zufall = 6;
                }
                else if(boxen[7].Text == "X" && boxen[8].Text == "X" || boxen[7].Text == "O" && boxen[8].Text == "O" && boxen[6].Enabled == true)
                {
                    zufall = 6;
                }


                if(boxen[6].Text == "X" && boxen[8].Text == "X" || boxen[6].Text == "O" && boxen[8].Text == "O" && boxen[7].Enabled == true)
                {
                    zufall = 7;
                }
                else if(boxen[1].Text == "X" && boxen[4].Text == "X" || boxen[1].Text == "O" && boxen[4].Text == "O" && boxen[7].Enabled == true)
                {
                    zufall = 7;
                }

                if (boxen[2].Text == "X" && boxen[5].Text == "X"  || boxen[2].Text == "O" && boxen[5].Text == "O" && boxen[8].Enabled == true)
                {
                    zufall = 8;
                }
                else if(boxen[6].Text == "X" && boxen[7].Text == "X" || boxen[6].Text == "O" && boxen[7].Text == "O" && boxen[8].Enabled == true )
                {
                    zufall = 8;
                }
                else if(boxen[6].Text == "X" && boxen[7].Text == "X" || boxen[6].Text == "O" && boxen[7].Text == "O"  && boxen[8].Enabled == true)
                {
                    zufall = 8;
                }
                else if(boxen[0].Text == "X" && boxen[4].Text == "X" || boxen[0].Text == "O" && boxen[4].Text == "O"  && boxen[8].Enabled == true)
                {
                    zufall = 8;
                }


                while (boxen[zufall].Enabled == false)
                {
                    zufall = random.Next(0, 9);
                }


                System.Threading.Thread.Sleep(250);

                boxen[zufall].Text = "O";
                boxen[zufall].Enabled = false;

                
                lastKey = "O";
                key = "X";

               

                textBox1_click(sender, e);
            }
        }


        public void CheckWin(ref string lastKey)
        {
            text = " " + lastKey + " hat gewonnen";

            if (textBox1.Text == "X" && textBox2.Text == "X" && textBox3.Text == "X" || textBox1.Text == "O" && textBox2.Text == "O" && textBox3.Text == "O")
            {
                var result = MessageBox.Show(text, "Text", MessageBoxButtons.RetryCancel);

                if (result == DialogResult.Cancel) { System.Environment.Exit(-1); } else { win = false; lastKey = ""; key = ""; }
                win = true;
            }
            else if (textBox4.Text == "X" && textBox5.Text == "X" && textBox6.Text == "X" || textBox4.Text == "O" && textBox5.Text == "O" && textBox6.Text == "O")
            {
                var result = MessageBox.Show(text, "Text", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Cancel) { System.Environment.Exit(-1); }
                win = true;

            }
            else if (textBox7.Text == "X" && textBox8.Text == "X" && textBox9.Text == "X" || textBox7.Text == "O" && textBox8.Text == "O" && textBox9.Text == "O")
            {
                var result = MessageBox.Show(text, "Text", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Cancel) { System.Environment.Exit(-1); }
                win = true;
            }
            else if (textBox1.Text == "X" && textBox4.Text == "X" && textBox7.Text == "X" || textBox1.Text == "O" && textBox4.Text == "O" && textBox7.Text == "O")
            {
                var result = MessageBox.Show(text, "Text", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Cancel) { System.Environment.Exit(-1); }
                win = true;
            }
            else if (textBox2.Text == "X" && textBox5.Text == "X" && textBox8.Text == "X" || textBox2.Text == "O" && textBox5.Text == "O" && textBox8.Text == "O")
            {
                var result = MessageBox.Show(text, "Text", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Cancel) { System.Environment.Exit(-1); }
                win = true;
            }
            else if (textBox3.Text == "X" && textBox6.Text == "X" && textBox9.Text == "X" || textBox3.Text == "O" && textBox6.Text == "O" && textBox9.Text == "O")
            {
                var result = MessageBox.Show(text, "Text", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Cancel) { System.Environment.Exit(-1); }
                win = true;
            }
            else if (textBox1.Text == "X" && textBox5.Text == "X" && textBox9.Text == "X" || textBox1.Text == "O" && textBox5.Text == "O" && textBox9.Text == "O")
            {
                var result = MessageBox.Show(text, "Text", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Cancel) { System.Environment.Exit(-1); }
                win = true;
            }
            else if (textBox3.Text == "X" && textBox5.Text == "X" && textBox7.Text == "X" || textBox3.Text == "O" && textBox5.Text == "O" && textBox7.Text == "O")
            {
                var result = MessageBox.Show(text, "Gewonnen", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Cancel) { System.Environment.Exit(-1); }
                win = true;
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
            {
                var result = MessageBox.Show("Keiner hat Gewonnen", "Text", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Cancel) { System.Environment.Exit(-1); }
                win = true;
            }



            if (win == true)
            {
                textBox1.Text = "";
                textBox1.Enabled = true;
                textBox2.Text = "";
                textBox2.Enabled = true;
                textBox3.Text = "";
                textBox3.Enabled = true;
                textBox4.Text = "";
                textBox4.Enabled = true;
                textBox5.Text = "";
                textBox5.Enabled = true;
                textBox6.Text = "";
                textBox6.Enabled = true;
                textBox7.Text = "";
                textBox7.Enabled = true;
                textBox8.Text = "";
                textBox8.Enabled = true;
                textBox9.Text = "";
                textBox9.Enabled = true;

                lastKey = "";

            }
        }


    }
}
