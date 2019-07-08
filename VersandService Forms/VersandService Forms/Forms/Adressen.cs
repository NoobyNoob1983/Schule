using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VersandService_Forms.Model;
using VersandService_Forms.Forms;

namespace VersandService_Forms.Forms
{
    public partial class Adressen : Form
    {
        #region Konstruktor 

        public Adressen()
        {
            InitializeComponent();


            Adresse[] standard = new Adresse[3];
            standard[0] = new Adresse("Peter","Steiner","Peterstr 11","12345","Petersburg");
            standard[1] = new Adresse("Fred", "Fredsen", "Am Manni 11", "12345", "FredTown");
            standard[2] = new Adresse("Manfred", "Körner", "Körnerstr 11", "12345", "AM Korn 27");

            comboBox1.Items.Add(standard[0].Strasse);
            comboBox1.Items.Add(standard[1].Strasse);
            comboBox1.Items.Add(standard[2].Strasse);
            comboBox2.Items.Add(standard[0].Strasse);
            comboBox2.Items.Add(standard[1].Strasse);
            comboBox2.Items.Add(standard[2].Strasse);

            inhaltsverzeichniss.Visible = true;
            offeneSendungen.Visible = false;
            adressVerwaltung.Visible =true;
        }

        #endregion

        #region ClickEvents

        /// <summary>
        /// Diese Methode legt eine neue Adresse an
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            adressVerwaltung.Visible = true;

            Adresse adresse = new Adresse(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            if (adresse.IstGültig(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text))
            {
                MessageBox.Show("Die Adresse " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text + " " + textBox6.Text + " wurde erfolgreich angelegt");
                
                comboBox1.Items.Add(adresse);
                comboBox2.Items.Add(adresse);


            }
            else
            {
                MessageBox.Show("Sorry aber die eingegebene Adresse ist ungültig");

            }

            button4_Click(sender,e);
               
        }

        /// <summary>
        /// VersandCenter anzeigen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            adressVerwaltung.Visible = true;
            inhaltsverzeichniss.Visible = false;
            versandService.Visible = true;
            offeneSendungen.Visible = true;

        }

        /// <summary>
        /// AdressVerwaltung anzeigen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            adressVerwaltung.Visible = false;
            inhaltsverzeichniss.Visible = true;
            versandService.Visible = true;
            offeneSendungen.Visible = false;
        }

        /// <summary>
        /// Hauptmenu anzeigen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            adressVerwaltung.Visible = true;
            inhaltsverzeichniss.Visible = true;
            versandService.Visible = true;
            offeneSendungen.Visible = false;
        }

        /// <summary>
        /// Hover effekt für Buttons im Startmenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inhaltsverzeichniss_MouseHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            b.BackColor = Color.Orange;
        }

        /// <summary>
        /// Hover effekt für Buttons im Startmenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            b.BackColor = Color.DarkOrange;
        }

       

        /// <summary>
        /// Offene Sendungen anzeigen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            offeneSendungen.Visible = true;
        }

        /// <summary>
        /// Sendung speichern
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {

        }





        #endregion
    }
}
