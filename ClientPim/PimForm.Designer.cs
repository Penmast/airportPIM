namespace ClientPim
{
    partial class PimForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PimForm));
            this.groupBoxRecherche = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCodeIata = new System.Windows.Forms.TextBox();
            this.labelCodeIata = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réinitialiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.etatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnectéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sélectionBagageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créationBagageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageBagageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMessages = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelEtat = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxResultat = new System.Windows.Forms.GroupBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.groupBoxBagage = new System.Windows.Forms.GroupBox();
            this.checkBoxPrioritaire = new System.Windows.Forms.CheckBox();
            this.checkBoxRush = new System.Windows.Forms.CheckBox();
            this.checkBoxContinuation = new System.Windows.Forms.CheckBox();
            this.textBoxItineraire = new System.Windows.Forms.TextBox();
            this.labelItineraire = new System.Windows.Forms.Label();
            this.groupBoxVol = new System.Windows.Forms.GroupBox();
            this.textBoxJourExploitation = new System.Windows.Forms.TextBox();
            this.textBoxLigne = new System.Windows.Forms.TextBox();
            this.textBoxCompagnie = new System.Windows.Forms.TextBox();
            this.labelExpl = new System.Windows.Forms.Label();
            this.labelLigne = new System.Windows.Forms.Label();
            this.labelCompagnie = new System.Windows.Forms.Label();
            this.groupBoxRecherche.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBoxResultat.SuspendLayout();
            this.groupBoxBagage.SuspendLayout();
            this.groupBoxVol.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRecherche
            // 
            this.groupBoxRecherche.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxRecherche.Controls.Add(this.button1);
            this.groupBoxRecherche.Controls.Add(this.textBoxCodeIata);
            this.groupBoxRecherche.Controls.Add(this.labelCodeIata);
            this.groupBoxRecherche.Location = new System.Drawing.Point(13, 45);
            this.groupBoxRecherche.Name = "groupBoxRecherche";
            this.groupBoxRecherche.Size = new System.Drawing.Size(700, 54);
            this.groupBoxRecherche.TabIndex = 0;
            this.groupBoxRecherche.TabStop = false;
            this.groupBoxRecherche.Text = "Recherche";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCodeIata
            // 
            this.textBoxCodeIata.Location = new System.Drawing.Point(75, 19);
            this.textBoxCodeIata.Name = "textBoxCodeIata";
            this.textBoxCodeIata.Size = new System.Drawing.Size(514, 20);
            this.textBoxCodeIata.TabIndex = 2;
            this.textBoxCodeIata.Text = "005725273000";
            this.textBoxCodeIata.TextChanged += new System.EventHandler(this.textBoxCodeIata_TextChanged);
            // 
            // labelCodeIata
            // 
            this.labelCodeIata.AutoSize = true;
            this.labelCodeIata.Location = new System.Drawing.Point(10, 22);
            this.labelCodeIata.Name = "labelCodeIata";
            this.labelCodeIata.Size = new System.Drawing.Size(59, 13);
            this.labelCodeIata.TabIndex = 1;
            this.labelCodeIata.Text = "Code Iata :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandesToolStripMenuItem,
            this.etatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // commandesToolStripMenuItem
            // 
            this.commandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réinitialiserToolStripMenuItem,
            this.toolStripMenuItem1});
            this.commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            this.commandesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.commandesToolStripMenuItem.Text = "Commandes";
            // 
            // réinitialiserToolStripMenuItem
            // 
            this.réinitialiserToolStripMenuItem.Name = "réinitialiserToolStripMenuItem";
            this.réinitialiserToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.réinitialiserToolStripMenuItem.Text = "Réinitialiser";
            this.réinitialiserToolStripMenuItem.Click += new System.EventHandler(this.réinitialiserToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            // 
            // etatToolStripMenuItem
            // 
            this.etatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.déconnectéToolStripMenuItem,
            this.initialToolStripMenuItem,
            this.sélectionBagageToolStripMenuItem,
            this.créationBagageToolStripMenuItem,
            this.affichageBagageToolStripMenuItem});
            this.etatToolStripMenuItem.Name = "etatToolStripMenuItem";
            this.etatToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.etatToolStripMenuItem.Text = "Etat";
            // 
            // déconnectéToolStripMenuItem
            // 
            this.déconnectéToolStripMenuItem.Name = "déconnectéToolStripMenuItem";
            this.déconnectéToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.déconnectéToolStripMenuItem.Text = "Déconnecté";
            this.déconnectéToolStripMenuItem.Click += new System.EventHandler(this.déconnectéToolStripMenuItem_Click);
            // 
            // initialToolStripMenuItem
            // 
            this.initialToolStripMenuItem.Name = "initialToolStripMenuItem";
            this.initialToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.initialToolStripMenuItem.Text = "Initial";
            this.initialToolStripMenuItem.Click += new System.EventHandler(this.initialToolStripMenuItem_Click);
            // 
            // sélectionBagageToolStripMenuItem
            // 
            this.sélectionBagageToolStripMenuItem.Name = "sélectionBagageToolStripMenuItem";
            this.sélectionBagageToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.sélectionBagageToolStripMenuItem.Text = "Sélection bagage";
            this.sélectionBagageToolStripMenuItem.Click += new System.EventHandler(this.sélectionBagageToolStripMenuItem_Click);
            // 
            // créationBagageToolStripMenuItem
            // 
            this.créationBagageToolStripMenuItem.Name = "créationBagageToolStripMenuItem";
            this.créationBagageToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.créationBagageToolStripMenuItem.Text = "Création bagage";
            this.créationBagageToolStripMenuItem.Click += new System.EventHandler(this.créationBagageToolStripMenuItem_Click);
            // 
            // affichageBagageToolStripMenuItem
            // 
            this.affichageBagageToolStripMenuItem.Name = "affichageBagageToolStripMenuItem";
            this.affichageBagageToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.affichageBagageToolStripMenuItem.Text = "Affichage bagage";
            this.affichageBagageToolStripMenuItem.Click += new System.EventHandler(this.affichageBagageToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMessages,
            this.toolStripStatusLabelEtat,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 405);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(720, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMessages
            // 
            this.toolStripStatusLabelMessages.AutoSize = false;
            this.toolStripStatusLabelMessages.Name = "toolStripStatusLabelMessages";
            this.toolStripStatusLabelMessages.Size = new System.Drawing.Size(400, 17);
            this.toolStripStatusLabelMessages.Text = "Messages";
            // 
            // toolStripStatusLabelEtat
            // 
            this.toolStripStatusLabelEtat.AutoSize = false;
            this.toolStripStatusLabelEtat.Name = "toolStripStatusLabelEtat";
            this.toolStripStatusLabelEtat.Size = new System.Drawing.Size(200, 17);
            this.toolStripStatusLabelEtat.Text = "Etat";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 15);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // groupBoxResultat
            // 
            this.groupBoxResultat.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxResultat.Controls.Add(this.buttonNext);
            this.groupBoxResultat.Controls.Add(this.buttonCreer);
            this.groupBoxResultat.Controls.Add(this.groupBoxBagage);
            this.groupBoxResultat.Controls.Add(this.groupBoxVol);
            this.groupBoxResultat.Location = new System.Drawing.Point(13, 116);
            this.groupBoxResultat.Name = "groupBoxResultat";
            this.groupBoxResultat.Size = new System.Drawing.Size(681, 286);
            this.groupBoxResultat.TabIndex = 5;
            this.groupBoxResultat.TabStop = false;
            this.groupBoxResultat.Text = "Résultat";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(561, 244);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(108, 36);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Nouvelle recherche";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonCreer
            // 
            this.buttonCreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonCreer.Location = new System.Drawing.Point(263, 244);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(158, 36);
            this.buttonCreer.TabIndex = 2;
            this.buttonCreer.Text = "Creer";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_Click);
            // 
            // groupBoxBagage
            // 
            this.groupBoxBagage.Controls.Add(this.checkBoxPrioritaire);
            this.groupBoxBagage.Controls.Add(this.checkBoxRush);
            this.groupBoxBagage.Controls.Add(this.checkBoxContinuation);
            this.groupBoxBagage.Controls.Add(this.textBoxItineraire);
            this.groupBoxBagage.Controls.Add(this.labelItineraire);
            this.groupBoxBagage.Location = new System.Drawing.Point(344, 20);
            this.groupBoxBagage.Name = "groupBoxBagage";
            this.groupBoxBagage.Size = new System.Drawing.Size(331, 218);
            this.groupBoxBagage.TabIndex = 1;
            this.groupBoxBagage.TabStop = false;
            this.groupBoxBagage.Text = "Bagage";
            // 
            // checkBoxPrioritaire
            // 
            this.checkBoxPrioritaire.AutoSize = true;
            this.checkBoxPrioritaire.Location = new System.Drawing.Point(103, 158);
            this.checkBoxPrioritaire.Name = "checkBoxPrioritaire";
            this.checkBoxPrioritaire.Size = new System.Drawing.Size(69, 17);
            this.checkBoxPrioritaire.TabIndex = 8;
            this.checkBoxPrioritaire.Text = "Prioritaire";
            this.checkBoxPrioritaire.UseVisualStyleBackColor = true;
            // 
            // checkBoxRush
            // 
            this.checkBoxRush.AutoSize = true;
            this.checkBoxRush.Location = new System.Drawing.Point(103, 124);
            this.checkBoxRush.Name = "checkBoxRush";
            this.checkBoxRush.Size = new System.Drawing.Size(51, 17);
            this.checkBoxRush.TabIndex = 7;
            this.checkBoxRush.Text = "Rush";
            this.checkBoxRush.UseVisualStyleBackColor = true;
            // 
            // checkBoxContinuation
            // 
            this.checkBoxContinuation.AutoSize = true;
            this.checkBoxContinuation.Location = new System.Drawing.Point(103, 91);
            this.checkBoxContinuation.Name = "checkBoxContinuation";
            this.checkBoxContinuation.Size = new System.Drawing.Size(85, 17);
            this.checkBoxContinuation.TabIndex = 6;
            this.checkBoxContinuation.Text = "Continuation";
            this.checkBoxContinuation.UseVisualStyleBackColor = true;
            // 
            // textBoxItineraire
            // 
            this.textBoxItineraire.Location = new System.Drawing.Point(103, 41);
            this.textBoxItineraire.Name = "textBoxItineraire";
            this.textBoxItineraire.Size = new System.Drawing.Size(100, 20);
            this.textBoxItineraire.TabIndex = 2;
            // 
            // labelItineraire
            // 
            this.labelItineraire.AutoSize = true;
            this.labelItineraire.Location = new System.Drawing.Point(18, 41);
            this.labelItineraire.Name = "labelItineraire";
            this.labelItineraire.Size = new System.Drawing.Size(47, 13);
            this.labelItineraire.TabIndex = 0;
            this.labelItineraire.Text = "Itinéraire";
            // 
            // groupBoxVol
            // 
            this.groupBoxVol.Controls.Add(this.textBoxJourExploitation);
            this.groupBoxVol.Controls.Add(this.textBoxLigne);
            this.groupBoxVol.Controls.Add(this.textBoxCompagnie);
            this.groupBoxVol.Controls.Add(this.labelExpl);
            this.groupBoxVol.Controls.Add(this.labelLigne);
            this.groupBoxVol.Controls.Add(this.labelCompagnie);
            this.groupBoxVol.Location = new System.Drawing.Point(10, 20);
            this.groupBoxVol.Name = "groupBoxVol";
            this.groupBoxVol.Size = new System.Drawing.Size(328, 218);
            this.groupBoxVol.TabIndex = 0;
            this.groupBoxVol.TabStop = false;
            this.groupBoxVol.Text = "Vol";
            // 
            // textBoxJourExploitation
            // 
            this.textBoxJourExploitation.Location = new System.Drawing.Point(122, 131);
            this.textBoxJourExploitation.Name = "textBoxJourExploitation";
            this.textBoxJourExploitation.Size = new System.Drawing.Size(169, 20);
            this.textBoxJourExploitation.TabIndex = 5;
            // 
            // textBoxLigne
            // 
            this.textBoxLigne.Location = new System.Drawing.Point(122, 85);
            this.textBoxLigne.Name = "textBoxLigne";
            this.textBoxLigne.Size = new System.Drawing.Size(169, 20);
            this.textBoxLigne.TabIndex = 4;
            // 
            // textBoxCompagnie
            // 
            this.textBoxCompagnie.Location = new System.Drawing.Point(122, 38);
            this.textBoxCompagnie.Name = "textBoxCompagnie";
            this.textBoxCompagnie.Size = new System.Drawing.Size(169, 20);
            this.textBoxCompagnie.TabIndex = 3;
            // 
            // labelExpl
            // 
            this.labelExpl.AutoSize = true;
            this.labelExpl.Location = new System.Drawing.Point(17, 135);
            this.labelExpl.Name = "labelExpl";
            this.labelExpl.Size = new System.Drawing.Size(91, 13);
            this.labelExpl.TabIndex = 2;
            this.labelExpl.Text = "Jour d\'exploitation";
            // 
            // labelLigne
            // 
            this.labelLigne.AutoSize = true;
            this.labelLigne.Location = new System.Drawing.Point(17, 92);
            this.labelLigne.Name = "labelLigne";
            this.labelLigne.Size = new System.Drawing.Size(33, 13);
            this.labelLigne.TabIndex = 1;
            this.labelLigne.Text = "Ligne";
            // 
            // labelCompagnie
            // 
            this.labelCompagnie.AutoSize = true;
            this.labelCompagnie.Location = new System.Drawing.Point(17, 42);
            this.labelCompagnie.Name = "labelCompagnie";
            this.labelCompagnie.Size = new System.Drawing.Size(60, 13);
            this.labelCompagnie.TabIndex = 0;
            this.labelCompagnie.Text = "Compagnie";
            // 
            // PimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(720, 427);
            this.Controls.Add(this.groupBoxResultat);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxRecherche);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PimForm";
            this.Text = "PimForm";
            this.groupBoxRecherche.ResumeLayout(false);
            this.groupBoxRecherche.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxResultat.ResumeLayout(false);
            this.groupBoxBagage.ResumeLayout(false);
            this.groupBoxBagage.PerformLayout();
            this.groupBoxVol.ResumeLayout(false);
            this.groupBoxVol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRecherche;
        private System.Windows.Forms.TextBox textBoxCodeIata;
        private System.Windows.Forms.Label labelCodeIata;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réinitialiserToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBoxResultat;
        private System.Windows.Forms.GroupBox groupBoxBagage;
        private System.Windows.Forms.Label labelItineraire;
        private System.Windows.Forms.GroupBox groupBoxVol;
        private System.Windows.Forms.Label labelExpl;
        private System.Windows.Forms.Label labelLigne;
        private System.Windows.Forms.Label labelCompagnie;
        private System.Windows.Forms.CheckBox checkBoxRush;
        private System.Windows.Forms.CheckBox checkBoxContinuation;
        private System.Windows.Forms.TextBox textBoxItineraire;
        private System.Windows.Forms.TextBox textBoxJourExploitation;
        private System.Windows.Forms.TextBox textBoxLigne;
        private System.Windows.Forms.TextBox textBoxCompagnie;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessages;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelEtat;
        private System.Windows.Forms.CheckBox checkBoxPrioritaire;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem etatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnectéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sélectionBagageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créationBagageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageBagageToolStripMenuItem;
    }
}

