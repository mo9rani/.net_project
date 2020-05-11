using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace mini_project
{
    public partial class supprimer : Form
    {
        SqlConnection cn = new SqlConnection();
        public supprimer()
        {
            InitializeComponent();
        }

        private void supprimer_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\project_\\mini_project\\mini_project\\DB.mdf\";Integrated Security=True;User Instance=True";

            try
            {
                cn.Open();


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            type.Items.Add("Pull");
            type.Items.Add("Chemise");
            type.Items.Add("T-shirt");
            type.Items.Add("veste");
            type.Items.Add("jeans");
            type.Items.Add("pantalon");
            type.Items.Add("jupe");
            type.Items.Add("robe");
            type.Items.Add("chapeau");
            type.Items.Add("cravate");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String t = type.Text;
            String r = refer.Text;
            int q = int.Parse(qte.Text);



             SqlCommand cmd = new SqlCommand("select quantite from vetement where type = '" +t+ "' and reference ='" +r+ "' ;", cn);


             try
             {
                 int i = (int)cmd.ExecuteScalar();

                 if (q == i)
                 {

                     SqlCommand cd = new SqlCommand(" delete from vetement where type = '" + t + "' and reference ='" + r + "' ;", cn);
                     cd.ExecuteNonQuery();
                     MessageBox.Show("Article supprime");
                     admin adm = new admin();
                     this.Close();
                     adm.Show();
                 }

                 else if (q < i)
                 {


                     int resultq = i - q;

                     SqlCommand cmmd = new SqlCommand("update vetement set quantite = " + resultq + " where type = '" + t + "' and reference ='" + r + "' ;", cn);
                     cmmd.ExecuteNonQuery();
                     MessageBox.Show("Quantite supprime");
                     admin adm = new admin();
                     this.Close();
                     adm.Show();
                 }


                 else if (q > i)
                 {
                     MessageBox.Show("Quantite a supprimer est supperieur au quantite dans le stock");
                 }
             }
                 
             catch (Exception ex)
             {
                 MessageBox.Show("Article introuvable");
             }

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            admin bn = new admin();
            this.Close();
            bn.Show();

       
        }

        
    }
}
