using Mission1AP3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission1AP3
{
    public partial class FormConnexion : Form
    {
        BaseDeDonnees maBase;

        public FormConnexion()
        {
            InitializeComponent();
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            //à partir des champs identifiant et mot de passe, on se connecte sur la base gsb_praticien en local 
            //vous pouvez paramétrer la chaine de connexion ici. 
            //appel du construction de la classe BaseDeDonnees.
            if (textMotDePasse.Text is null)
            {
                textMotDePasse.Text = "";
            }
            maBase = new BaseDeDonnees("localhost", "gsb", "3306", "root", "");
            MessageBox.Show("connexion établie");


            //ajouter les connexion utilisateur et administrateur à partir des champs textes


            FormVille maFeuille = new FormVille(maBase);
            maFeuille.Show();

        }
    }
}
