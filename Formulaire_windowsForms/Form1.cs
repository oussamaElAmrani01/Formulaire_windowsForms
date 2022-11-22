using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace Formulaire_windowsForms
{
    public partial class Formulaire : Form
    {
        private static string chaine =
            @"Data Source=DESKTOP-TDEF4LS;Initial Catalog=formulaire_teste;Integrated Security=True";

        private static SqlConnection cnx = new SqlConnection(chaine);
        private static SqlCommand cmd = new SqlCommand(); 
        private static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        public Formulaire()
        {
            InitializeComponent();
        }

        private void comboBoxUtilisateurs_load()
        {
            comboBoxUtilisateurs.Visible = true;
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT pseudo FROM utilisateur;";
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    this.comboBoxUtilisateurs.Items.Add($" {rd["pseudo"]}");
                }
            }
            cnx.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxUtilisateurs_load();

            // Modification de la visibilité des boutons
            buttonAjouter.Visible = true;
            buttonProfile.Visible = false;
            buttonAnnuler.Visible = false; 
            buttonEnvoyer.Visible = false; 
            buttonModifier.Visible = false; 
            buttonSupprimer.Visible = false;

            // Modification de la visibilité des labels
            labelPseudo.Visible = false;
            labelPrenom.Visible = false;
            labelNom.Visible = false;
            labelErreurPhoto.Visible = false;
            labelErreur.Visible = false;
            labelErreurPseudo.Visible = false;

            // Modification de la visibilité des textBox
            textBoxPseudo.Visible = false;
            textBoxNom.Visible = false;
            textBoxPrenom.Visible = false;
            photo_profile.Visible = false;
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hjffffffff");
        }

        private void photo_profile_Click(object sender, EventArgs e)
        {

        }


        private void comboBoxUtilisateurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Modification de la visibilité des boutons
            buttonAjouter.Visible = false;
            buttonEnvoyer.Visible = false;
            buttonAnnuler.Visible = true;
            buttonProfile.Visible = true;

            // Modification de la visibilité des textBox
            textBoxNom.Visible = true;
            textBoxPseudo.Visible = true;
            textBoxPrenom.Visible = true;
            photo_profile.Visible = true;

            // Modification de la visibilité des labels
            labelNom.Visible = true;
            labelPrenom.Visible = true;
            labelPseudo.Visible = true;


            //string[] values = comboBoxUtilisateurs.SelectedItem.ToString().Split("|");
            //string nom = values[0];
            //string prenom = values[1];
            //MessageBox.Show($"nom = {nom}  prenom = {prenom}");
            //textBoxNom.Text = nom;
            //textBoxPrenom.Text = prenom;

            string pseudo = comboBoxUtilisateurs.SelectedItem.ToString().Trim();

            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = $"SELECT nom,prenom,pseudo FROM utilisateur WHERE pseudo = '{pseudo}';";
            textBoxPseudo.Modified = false;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    textBoxNom.Text = rd["nom"].ToString();
                    textBoxPrenom.Text = rd["prenom"].ToString();
                    textBoxPseudo.Text = rd["pseudo"].ToString();
                }
            }
            cnx.Close();

            buttonSupprimer.Visible = true;
            buttonModifier.Visible = true;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            // Modification de la visibilité des boutons
            buttonSupprimer.Visible = false;
            buttonModifier.Visible = false;
            buttonAjouter.Visible = true;
            buttonAnnuler.Visible = false;
            buttonEnvoyer.Visible = false;

            // Modification de la visibilité des textBox
            textBoxNom.Text = null;
            textBoxPrenom.Text = null;

            photo_profile.ImageLocation = null;
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            // Modification de la visibilité des boutons
            buttonAjouter.Visible = false;
            buttonEnvoyer.Visible = true;
            buttonAnnuler.Visible = true;
            buttonProfile.Visible = true;

            // Modification de la visibilité des labels
            labelNom.Visible = true;
            labelPrenom.Visible = true;
            labelPseudo.Visible = true;

            // Modification de la visibilité des textBox
            textBoxNom.Visible = true;
            textBoxPrenom.Visible = true;
            textBoxPseudo.Visible = true;

            photo_profile.Visible = true;

        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            string pseudo = textBoxPseudo.Text;
            string pseudoUnique =
                $"SELECT count(*) FROM utilisateur  WHERE pseudo = '{pseudo}'  GROUP BY pseudo ;";

            cnx.Open();
            cmd.Connection = cnx;
            //cmd.CommandText = "INSERT INTO utilisateur(nom,prenom,photo_profile) VALUES('" + nom + "','" + prenom + "','" + image + "'); ";
            //cmd.CommandText = "INSERT INTO utilisateur(nom,prenom) VALUES('" + nom + "','" + prenom + "');";
            cmd.CommandText = pseudoUnique;
            SqlDataReader rd = cmd.ExecuteReader();
            if ((rd.HasRows == false))
            {
                cnx.Close();

                cnx.Open();
                cmd.CommandText = $"UPDATE utilisateur SET nom = '{nom}', prenom = '{prenom}' WHERE pseudo = '{pseudo}';";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Votre enregistrement a été Modifier");
                buttonModifier.Visible = false;
                buttonSupprimer.Visible = true;
                buttonEnvoyer.Visible = false;

            }
            else
            {
                labelPseudo.Visible = true;
            }
            cnx.Close();
            //Update the list of users
            comboBoxUtilisateurs_load();

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            string pseudo = textBoxPseudo.Text;

            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = $"DELETE utilisateur WHERE pseudo = '{pseudo}';";
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Votre enregistrement a été supprimer");

            //Update the list of users
            comboBoxUtilisateurs_load();

            // Modification de la visibilité des boutons
            buttonSupprimer.Visible = false;
            buttonModifier.Visible = false;
            buttonAjouter.Visible = true;
            buttonAnnuler.Visible = false;
            buttonEnvoyer.Visible = false;
            buttonProfile.Visible = false;

            // Modification de la visibilité des textBox
            textBoxNom.Text = null;
            textBoxPrenom.Text = null;
            textBoxNom.Visible = false;
            textBoxPrenom.Visible = false;

            // Modification de la visibilité des labels
            labelListeUtilisateurs.Visible = true;
            labelErreurPseudo.Visible = false;
            labelErreurPhoto.Visible = false;
            labelErreur.Visible = false;
            labelNom.Visible = false;
            labelPrenom.Visible = false;
            labelPseudo.Visible = false;
            textBoxPseudo.Visible = false;

            // Modification de la visibilité des comboBox
            comboBoxUtilisateurs.Visible = true;

            // Modification de la visibilité des photos
            photo_profile.Visible = false;
        }

        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            string pseudo = textBoxPseudo.Text;
            //Image  image = photo_profile.Image;
            //&& photo_profile.ImageLocation != null
          
            if (nom != "" && prenom != ""  && pseudo != "")
            {
                labelErreurPhoto.Visible = false;
                labelErreur.Visible = false;
                labelErreurPseudo.Visible = false;
                string pseudoUnique =
                    $"SELECT count(*) FROM utilisateur  WHERE pseudo = '{pseudo}'  GROUP BY pseudo ;";

                cnx.Open();
                cmd.Connection = cnx;
                //cmd.CommandText = "INSERT INTO utilisateur(nom,prenom,photo_profile) VALUES('" + nom + "','" + prenom + "','" + image + "'); ";
                //cmd.CommandText = "INSERT INTO utilisateur(nom,prenom) VALUES('" + nom + "','" + prenom + "');";
                cmd.CommandText = pseudoUnique;
                SqlDataReader rd = cmd.ExecuteReader();
                if ((rd.HasRows == false))
                {
                    cnx.Close();

                    cnx.Open();
                    cmd.CommandText = $"INSERT INTO utilisateur(nom,prenom,pseudo) VALUES('{nom}','{prenom}', '{pseudo}');";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Votre enregistrement a été envoyé");
                    buttonModifier.Visible = true;
                    buttonSupprimer.Visible = true;
                    buttonEnvoyer.Visible = false;
                    
                }
                else
                {
                    labelErreurPseudo.Visible = true;
                }
                cnx.Close();
                //Update the list of users
                comboBoxUtilisateurs_load();

                //cnx.Open();
                //cmd.Connection = cnx;
                ////cmd.CommandText = "INSERT INTO utilisateur(nom,prenom,photo_profile) VALUES('" + nom + "','" + prenom + "','" + image + "'); ";
                ////cmd.CommandText = "INSERT INTO utilisateur(nom,prenom) VALUES('" + nom + "','" + prenom + "');";
                //cmd.CommandText = $"INSERT INTO utilisateur(nom,prenom,pseudo) VALUES('{nom}','{prenom}', '{pseudo}');";
                //cmd.ExecuteNonQuery();
                //cnx.Close();

                //MessageBox.Show(nom);
                //MessageBox.Show(prenom);


            }
            //if (photo_profile.ImageLocation == null)
            //{
            //    labelErreurPhoto.Visible = true;
            //}
            if(nom == "" && prenom == "")
            {
                labelErreur.Visible = true;
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)*.jpg| PNG files(*.png)*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    photo_profile.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("","",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}