using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mini_project
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ajoutervet a = new ajoutervet();
            a.Show();
            this.Hide();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimer sup = new supprimer();
            sup.Show();
            this.Close();
        }

        

        private void tousLeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficher af = new afficher();
            af.Show();
            this.Close();
        }

        private void consulterToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void rechercheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recherche rech = new recherche();
            this.Close();
            rech.Show();

        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ajouclient ajc = new ajouclient();
            this.Close();
            ajc.Show();
            
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifier mf = new modifier();
            this.Close();
            mf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acceuil gg = new acceuil();
            this.Close();
            gg.Show();
        }
    }
}
