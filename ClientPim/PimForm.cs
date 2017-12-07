using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.ServiceModel;

namespace ClientPim
{
    public partial class PimForm : Form
    {
        private PimState state = PimState.Deconnecter;
        private PimState State
        {
            get { return this.state; }
            set { OnPimStateChanged(value); }
        }

        public event PimStateEventHandler PimStateChanged;
        public delegate void PimStateEventHandler(object sender, PimState state);

        ServiceReferencePim.ServicePimClient proxy = null;

        private void OnPimStateChanged(PimState newState)
        {
            if (newState != this.state)
            {
                this.state = newState;
                if (this.PimStateChanged != null)
                {
                    PimStateChanged(this, this.state);
                }
            }
        }


        public PimForm()
        {
            InitializeComponent();
            proxy = new ServiceReferencePim.ServicePimClient();
            this.PimStateChanged += PIM_PimStateChanged;
            State = PimState.AttenteBagage;
        }

        void PIM_PimStateChanged(object sender, PimState state)
        {
            switch (state)
            {
                case PimState.Deconnecter:
                    deconnecter();
                    break;

                case PimState.AttenteBagage:
                    attenteBagage();
                    break;

                case PimState.AffichageBagage:
                    affichageBagage();
                    break;

                case PimState.CreationBagage:
                    creationBagage();
                    break;

                case PimState.SelectionBagage:
                    selectionBagage();
                    break;

            }
        }

        private void clearText()
        {
            textBoxCodeIata.Text = "";
            textBoxCompagnie.Text = "";
            textBoxLigne.Text = "";
            textBoxJourExploitation.Text = "";
            textBoxItineraire.Text = "";
            checkBoxContinuation.Checked = false;
            checkBoxPrioritaire.Checked = false;
            checkBoxRush.Checked = false;
            toolStripStatusLabelMessages.Text = "";
        }

        private void deconnecter()
        {
            clearText();
            button1.Enabled = false;
            groupBoxRecherche.Enabled = false;
            groupBoxResultat.Enabled = false;
        }

        private void attenteBagage()
        {
            clearText();
            button1.Enabled = false;
            groupBoxRecherche.Enabled = true;
            groupBoxResultat.Enabled = false;
            buttonCreer.Enabled = false;
            buttonNext.Enabled = false;
            toolStripStatusLabelEtat.Text = "Attente Bagage";
        }

        private void affichageBagage()
        {
            button1.Enabled = false;
            groupBoxRecherche.Enabled = false;
            groupBoxResultat.Enabled = true;
            buttonCreer.Enabled = false;
            buttonNext.Enabled = true;
            textBoxCompagnie.Enabled = false;
            textBoxLigne.Enabled = false;
            textBoxJourExploitation.Enabled = false;
            textBoxItineraire.Enabled = false;
            checkBoxContinuation.Enabled = false;
            checkBoxPrioritaire.Enabled = false;
            checkBoxRush.Enabled = false;
            toolStripStatusLabelEtat.Text = "Affichage Bagage";
        }

        private void creationBagage()
        {
            button1.Enabled = false;
            groupBoxRecherche.Enabled = false;
            groupBoxResultat.Enabled = true;
            groupBoxVol.Enabled = true;
            groupBoxBagage.Enabled = true;
            buttonCreer.Enabled = true;
            buttonNext.Enabled = false;
            textBoxCompagnie.Enabled = true;
            textBoxLigne.Enabled = true;
            textBoxJourExploitation.Enabled = true;
            textBoxItineraire.Enabled = true;
            checkBoxContinuation.Enabled = true;
            checkBoxPrioritaire.Enabled = true;
            checkBoxRush.Enabled = true;
            toolStripStatusLabelEtat.Text = "Creation Bagage";
        }

        private void selectionBagage()
        {
            clearText();
            State = PimState.AffichageBagage;
        }



        private void réinitialiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            State = PimState.AttenteBagage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReferencePim.BagageDefinition[] bagsArray = proxy.GetBagageByCodeIata(this.textBoxCodeIata.Text);


                List<ServiceReferencePim.BagageDefinition> bags = (bagsArray != null) ? bagsArray.ToList() : null;

                if (bags != null)
                {

                    State = PimState.AffichageBagage;

                    textBoxCompagnie.Text = bags[0].Compagnie;
                    textBoxLigne.Text = bags[0].Ligne;
                    textBoxJourExploitation.Text = bags[0].DateVol.ToString();
                    textBoxItineraire.Text = bags[0].Itineraire;
                    checkBoxContinuation.Checked = bags[0].EnContinuation;
                    checkBoxPrioritaire.Checked = bags[0].Prioritaire;
                    checkBoxRush.Checked = bags[0].Rush;
                    toolStripStatusLabelMessages.Text = bags[0].EnContinuation.ToString();
                }
                else
                {
                    State = PimState.CreationBagage;
                }
            }
            catch (AggregateException ex)
            {
                MessageBox.Show("Serveur non atteint");
            }
            catch (FaultException<ServiceReferencePim.MultipleBagagesFault> ex)
            {
                var pop = new PopUp(ex.Detail.ListBagages.ToList());
                if (pop.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    int id = pop.bagageSelected();

                    foreach (ServiceReferencePim.BagageDefinition bagage in ex.Detail.ListBagages)
                    {
                        if (bagage.IdBagage == id)
                        {
                            textBoxCompagnie.Text = bagage.Compagnie;
                            textBoxLigne.Text = bagage.Ligne;
                            textBoxJourExploitation.Text = bagage.DateVol.ToString();
                            textBoxItineraire.Text = bagage.Itineraire;
                            checkBoxContinuation.Checked = bagage.EnContinuation;
                            checkBoxPrioritaire.Checked = bagage.Prioritaire;
                            checkBoxRush.Checked = bagage.Rush;
                            toolStripStatusLabelMessages.Text = bagage.EnContinuation.ToString();
                        }
                    }
                }
                State = PimState.AffichageBagage;
            }
            catch (FaultException excp)
            {
                MessageBox.Show("Une erreur s'est produite dans le traitement de votre demande\nType: " + excp.GetType().ToString()
                    + "\nMessage: " + excp.Message);

            }
            catch (CommunicationException excp)
            {
                MessageBox.Show("Une erreur de communication c'est produite dans le traitement de votre demande\nType: " + excp.GetType().ToString()
                    + "\nMessage: " + excp.Message);
            }
            catch (Exception excp)
            {
                MessageBox.Show("Une erreur s'est produite dans le traitement de votre demande\nType: " + excp.GetType().ToString()
                    + "\nMessage: " + excp.Message);
            }

        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            ServiceReferencePim.BagageDefinition bag = new ServiceReferencePim.BagageDefinition();
            bag.CodeIata = textBoxCodeIata.Text;

            try
            {
                bag.DateVol = DateTime.Parse(textBoxJourExploitation.Text);
            }
            catch(System.FormatException ex)
            {
                MessageBox.Show("Erreur saisie date\n" + ex.Message);
            }
            
            bag.Prioritaire = checkBoxPrioritaire.Checked;
            bag.Itineraire = textBoxItineraire.Text;
            bag.Compagnie = textBoxCompagnie.Text;
            bag.Ligne = textBoxLigne.Text;
            bag.EnContinuation = checkBoxContinuation.Checked;
            bag.Rush = checkBoxRush.Checked;

            try
            {
                proxy.CreateBagage(bag);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Input error\n" + ex.Message);
            }

            State = PimState.AttenteBagage;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            State = PimState.AttenteBagage;
        }

        private void textBoxCodeIata_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = (textBoxCodeIata.Text != "") ? true : false;
        }

        private void déconnectéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            State = PimState.Deconnecter;
        }

        private void initialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            State = PimState.AttenteBagage;
        }

        private void sélectionBagageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            State = PimState.SelectionBagage;
        }

        private void créationBagageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            State = PimState.CreationBagage;
        }

        private void affichageBagageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            State = PimState.AffichageBagage;
        }
    }
}