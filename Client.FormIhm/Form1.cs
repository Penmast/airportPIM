using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAirport.Pim.Entities;

namespace Client.FormIhm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //InitializeComponent();
            //button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*BagageDefinition bagage = MyAirport.Pim.Models.Factory.Model.GetBagage(414);
            if (bagage != null) bagageLabel.Text = bagage.IdBagage + " \n" + bagage.Ligne;
            else bagageLabel.Text = "bagage not found";*/

            List<BagageDefinition> blist = new List<BagageDefinition>();
            blist = MyAirport.Pim.Models.Factory.Model.GetBagage(textBoxIata.Text);
            bagageLabel.Text = "";


            foreach ( BagageDefinition b in blist )
            {
                bagageLabel.Text += b.IdBagage + "\nCodeIata: " + b.CodeIata + "\nCompagnie: " + b.Compagnie + "\nLigne: " + b.Ligne + "\nDateVol: " + b.DateVol + "\nItineraire: " + b.Itineraire + "\nPrioritaire: " + b.Prioritaire + "\nEnContinuation " + b.EnContinuation + "\nRush: " + b.Rush + "\n\n";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if( Int32.TryParse(textBox1.Text, out var n) )
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BagageDefinition b = null;
            b = MyAirport.Pim.Models.Factory.Model.GetBagage(Int32.Parse(textBox1.Text));

            label2.Text = b.IdBagage + "\nCodeIata: " + b.CodeIata + "\nCompagnie: " + b.Compagnie + "\nLigne: " + b.Ligne + "\nDateVol: " + b.DateVol + "\nItineraire: " + b.Itineraire + "\nPrioritaire: " + b.Prioritaire + "\nEnContinuation " + b.EnContinuation + "\nRush: " + b.Rush;

        }
    }
}
