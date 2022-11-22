
namespace Formulaire_windowsForms
{
    partial class Formulaire
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.photo_profile = new System.Windows.Forms.PictureBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonEnvoyer = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.comboBoxUtilisateurs = new System.Windows.Forms.ComboBox();
            this.labelErreur = new System.Windows.Forms.Label();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.labelErreurPhoto = new System.Windows.Forms.Label();
            this.textBoxPseudo = new System.Windows.Forms.TextBox();
            this.labelPseudo = new System.Windows.Forms.Label();
            this.labelErreurPseudo = new System.Windows.Forms.Label();
            this.labelListeUtilisateurs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photo_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // photo_profile
            // 
            this.photo_profile.Location = new System.Drawing.Point(182, 22);
            this.photo_profile.Name = "photo_profile";
            this.photo_profile.Size = new System.Drawing.Size(186, 171);
            this.photo_profile.TabIndex = 0;
            this.photo_profile.TabStop = false;
            this.photo_profile.Click += new System.EventHandler(this.photo_profile_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(253, 366);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(260, 31);
            this.textBoxNom.TabIndex = 1;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(253, 438);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(260, 31);
            this.textBoxPrenom.TabIndex = 2;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(77, 372);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(52, 25);
            this.labelNom.TabIndex = 3;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(77, 438);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(74, 25);
            this.labelPrenom.TabIndex = 4;
            this.labelPrenom.Text = "Prenom";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(12, 652);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(131, 47);
            this.buttonAjouter.TabIndex = 5;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(165, 652);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(120, 47);
            this.buttonModifier.TabIndex = 6;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonEnvoyer
            // 
            this.buttonEnvoyer.BackColor = System.Drawing.Color.Green;
            this.buttonEnvoyer.ForeColor = System.Drawing.Color.White;
            this.buttonEnvoyer.Location = new System.Drawing.Point(454, 652);
            this.buttonEnvoyer.Name = "buttonEnvoyer";
            this.buttonEnvoyer.Size = new System.Drawing.Size(112, 47);
            this.buttonEnvoyer.TabIndex = 7;
            this.buttonEnvoyer.Text = "Envoyer";
            this.buttonEnvoyer.UseVisualStyleBackColor = false;
            this.buttonEnvoyer.Click += new System.EventHandler(this.buttonEnvoyer_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.Red;
            this.buttonSupprimer.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimer.Location = new System.Drawing.Point(307, 652);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(119, 47);
            this.buttonSupprimer.TabIndex = 8;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(12, 652);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(131, 47);
            this.buttonAnnuler.TabIndex = 9;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // comboBoxUtilisateurs
            // 
            this.comboBoxUtilisateurs.FormattingEnabled = true;
            this.comboBoxUtilisateurs.Items.AddRange(new object[] {
            "item1"});
            this.comboBoxUtilisateurs.Location = new System.Drawing.Point(384, 49);
            this.comboBoxUtilisateurs.Name = "comboBoxUtilisateurs";
            this.comboBoxUtilisateurs.Size = new System.Drawing.Size(182, 33);
            this.comboBoxUtilisateurs.TabIndex = 10;
            this.comboBoxUtilisateurs.SelectedIndexChanged += new System.EventHandler(this.comboBoxUtilisateurs_SelectedIndexChanged);
            // 
            // labelErreur
            // 
            this.labelErreur.AutoSize = true;
            this.labelErreur.BackColor = System.Drawing.Color.Red;
            this.labelErreur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelErreur.ForeColor = System.Drawing.Color.White;
            this.labelErreur.Location = new System.Drawing.Point(77, 329);
            this.labelErreur.Margin = new System.Windows.Forms.Padding(3);
            this.labelErreur.MaximumSize = new System.Drawing.Size(500, 500);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Padding = new System.Windows.Forms.Padding(3);
            this.labelErreur.Size = new System.Drawing.Size(319, 33);
            this.labelErreur.TabIndex = 11;
            this.labelErreur.Text = "le nom ou bien le prénom est invalide";
            // 
            // buttonProfile
            // 
            this.buttonProfile.Location = new System.Drawing.Point(182, 199);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(186, 34);
            this.buttonProfile.TabIndex = 12;
            this.buttonProfile.Text = "photo de profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // labelErreurPhoto
            // 
            this.labelErreurPhoto.AutoSize = true;
            this.labelErreurPhoto.BackColor = System.Drawing.Color.Red;
            this.labelErreurPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelErreurPhoto.ForeColor = System.Drawing.Color.White;
            this.labelErreurPhoto.Location = new System.Drawing.Point(165, 250);
            this.labelErreurPhoto.Margin = new System.Windows.Forms.Padding(3);
            this.labelErreurPhoto.MaximumSize = new System.Drawing.Size(500, 500);
            this.labelErreurPhoto.Name = "labelErreurPhoto";
            this.labelErreurPhoto.Padding = new System.Windows.Forms.Padding(3);
            this.labelErreurPhoto.Size = new System.Drawing.Size(222, 33);
            this.labelErreurPhoto.TabIndex = 13;
            this.labelErreurPhoto.Text = "Veuillez choisir une photo";
            // 
            // textBoxPseudo
            // 
            this.textBoxPseudo.Location = new System.Drawing.Point(253, 496);
            this.textBoxPseudo.Name = "textBoxPseudo";
            this.textBoxPseudo.Size = new System.Drawing.Size(260, 31);
            this.textBoxPseudo.TabIndex = 14;
            // 
            // labelPseudo
            // 
            this.labelPseudo.AutoSize = true;
            this.labelPseudo.Location = new System.Drawing.Point(77, 496);
            this.labelPseudo.Name = "labelPseudo";
            this.labelPseudo.Size = new System.Drawing.Size(71, 25);
            this.labelPseudo.TabIndex = 15;
            this.labelPseudo.Text = "Pseudo";
            // 
            // labelErreurPseudo
            // 
            this.labelErreurPseudo.AutoSize = true;
            this.labelErreurPseudo.BackColor = System.Drawing.Color.Red;
            this.labelErreurPseudo.ForeColor = System.Drawing.Color.White;
            this.labelErreurPseudo.Location = new System.Drawing.Point(77, 540);
            this.labelErreurPseudo.Name = "labelErreurPseudo";
            this.labelErreurPseudo.Size = new System.Drawing.Size(451, 25);
            this.labelErreurPseudo.TabIndex = 16;
            this.labelErreurPseudo.Text = "Ce pseudo déja utilisé euillez réinsérer un pseudo valide";
            // 
            // labelListeUtilisateurs
            // 
            this.labelListeUtilisateurs.AutoSize = true;
            this.labelListeUtilisateurs.Location = new System.Drawing.Point(384, 21);
            this.labelListeUtilisateurs.Name = "labelListeUtilisateurs";
            this.labelListeUtilisateurs.Size = new System.Drawing.Size(169, 25);
            this.labelListeUtilisateurs.TabIndex = 17;
            this.labelListeUtilisateurs.Text = "Liste des utilisateurs";
            // 
            // Formulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(578, 778);
            this.Controls.Add(this.labelListeUtilisateurs);
            this.Controls.Add(this.labelErreurPseudo);
            this.Controls.Add(this.labelPseudo);
            this.Controls.Add(this.textBoxPseudo);
            this.Controls.Add(this.labelErreurPhoto);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.labelErreur);
            this.Controls.Add(this.comboBoxUtilisateurs);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonEnvoyer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.photo_profile);
            this.Name = "Formulaire";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Formaulaire";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photo_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox photo_profile;
        private TextBox textBoxNom;
        private TextBox textBoxPrenom;
        private Label labelNom;
        private Label labelPrenom;
        private OpenFileDialog openFileDialog1;
        private Button buttonAjouter;
        private Button buttonModifier;
        private Button buttonEnvoyer;
        private Button buttonSupprimer;
        private Button buttonAnnuler;
        private ComboBox comboBoxUtilisateurs;
        private Label labelErreur;
        private Button buttonProfile;
        private Label labelErreurPhoto;
        private TextBox textBoxPseudo;
        private Label labelPseudo;
        private Label labelErreurPseudo;
        private Label labelListeUtilisateurs;
    }
}