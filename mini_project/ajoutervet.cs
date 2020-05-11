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
    public partial class ajoutervet : Form
    {
        SqlConnection cn = new SqlConnection();
        string tal;

        public ajoutervet()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ajoutervet_Load(object sender, EventArgs e)
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

            typ.Items.Add("Pull");
            typ.Items.Add("Chemise");
            typ.Items.Add("T-shirt");
            typ.Items.Add("veste");
            typ.Items.Add("jeans");
            typ.Items.Add("pantalon");
            typ.Items.Add("jupe");
            typ.Items.Add("robe");
            typ.Items.Add("chapeau");
            typ.Items.Add("cravate");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string t = typ.SelectedItem.ToString();
            string m = marq.Text;
            string r = refe.Text;
            int q = int.Parse(qte.Text);
            string d = desc.Text;
            
            if (s.Checked == true)
                tal = "S";

            else if (mm.Checked == true)
                tal = "M";
            else if (l.Checked == true)
                tal = "L";
            else if (xl.Checked == true)
                tal = "XL";
            else if (no.Checked == true)
                tal = "--";





            SqlDataReader dr;

            string rel = "select id from vetement where type = '" + t + "' and marque = '" + m + "' and reference  = '" + r + "' and taille  = '" + tal + "' ;";
           SqlCommand com = new SqlCommand(rel, cn);
            dr = com.ExecuteReader(); //Envoie CommandText (propriété de l'objet com) à Connection et génère SqlDataReader.
            if (dr.Read())
            {
                int idd = (int)dr[0];
                dr.Close();
                
                SqlCommand bbn = new SqlCommand(" select quantite from vetement where id =" + idd + ";", cn);
                int w = (int)bbn.ExecuteScalar();
                w = w + q;


                SqlCommand cmmd = new SqlCommand("update vetement set quantite = " + w + " where id = " + idd + ";", cn);
                cmmd.ExecuteNonQuery();
                MessageBox.Show("ajout reussi");
                admin dminn = new admin();
                this.Close();
                dminn.Show();

            }
            else
            {




                dr.Close();




                SqlCommand cmd = new SqlCommand("insert into vetement values( '" + t + "','" + m + "','" + r + "'," + q + ",'" + tal + "','" + d + "');", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ajout reussi");
                admin dmin = new admin();
                this.Close();
                dmin.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            admin bn = new admin();
            this.Close();
            bn.Show();

        
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void no_CheckedChanged(object sender, EventArgs e)
        {

        }

        

       

       
    }
}
