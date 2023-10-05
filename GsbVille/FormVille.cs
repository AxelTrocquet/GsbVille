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
    public partial class FormVille : Form
    {
        BaseDeDonnees maBase;
        public FormVille(BaseDeDonnees uneBase)
        {
            InitializeComponent();
            this.maBase = uneBase;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //événement déclenché lors du chargement du formulaire principal. 
        }

        private void BtnAfficher_Click(object sender, EventArgs e)
        {
            //on vérifie si le champ text limite de ville n'est pas vide
            if (String.IsNullOrEmpty(TextNBVille.Text) == false)
            {
                //convertion sous forme numérique du champ NBVille
                int nbVilleMax = Convert.ToInt32(TextNBVille.Text);
                //envois de la requête dans la base de données à l'aide de la classe : MaBase
                //Chargment de la listView
                maBase.chargerVille(listVilles, nbVilleMax);
            }
        }
    }
}
