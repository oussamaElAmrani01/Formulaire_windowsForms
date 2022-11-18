using System.Data.SqlClient;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            labelErreurPhoto.Visible = false;
            buttonProfile.Visible = false;
            labelErreur.Visible = false;   
            buttonAnnuler.Visible = false; 
            buttonEnvoyer.Visible = false; 
            buttonModifier.Visible = false; 
            buttonSupprimer.Visible = false; 
            comboBoxUtilisateurs.Visible = false; 
            textBoxNom.Visible = false; 
            textBoxPrenom.Visible = false;
            photo_profile.Visible = false;
            labelNom.Visible = false; 
            labelPrenom.Visible = false;
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void photo_profile_Click(object sender, EventArgs e)
        {


        }


        private void comboBoxUtilisateurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT nom,prenom FROM utilisateur;";
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    this.comboBoxUtilisateurs.Items.Add($" {rd["nom"]}  {rd["prenom"]}");
                }
            }
            cnx.Close();

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            textBoxNom.Text = null;
            textBoxPrenom.Text = null;
            photo_profile.ImageLocation = null;
            buttonSupprimer.Visible = false;
            buttonModifier.Visible = false;
            buttonAjouter.Visible = true;
            buttonAnnuler.Visible = false;
            buttonEnvoyer.Visible= false;
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            buttonAjouter.Visible=false;
            buttonEnvoyer.Visible = true;
            buttonAnnuler.Visible = true;
            buttonProfile.Visible = true;
            textBoxNom.Visible = true;
            textBoxPrenom.Visible = true;
            photo_profile.Visible = true;
            labelNom.Visible = true;
            labelPrenom.Visible = true;

            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            

        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            Image  image = photo_profile.Image;

            if (nom != "" && prenom != "" && photo_profile.ImageLocation != null)
            {
                labelErreurPhoto.Visible = false;
                labelErreur.Visible = false;
                cnx.Open();
                cmd.CommandText = "INSERT INTO utilisateur(nom,prenom,photo_profile) VALUES('" + nom + "','" + prenom + "','"+ image +"'); ";
                cmd.ExecuteNonQuery();
                cnx.Close();
                //MessageBox.Show(nom);
                //MessageBox.Show(prenom);
                buttonModifier.Visible = true;
                buttonSupprimer.Visible = true;
                buttonEnvoyer.Visible = false;
               
            }
            if (photo_profile.ImageLocation == null)
            {
                labelErreurPhoto.Visible = true;
            }
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