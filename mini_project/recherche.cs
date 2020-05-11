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
    public partial class recherche : Form
    {
        SqlConnection cn = new SqlConnection();
        public recherche()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void recherche_Load(object sender, EventArgs e)
        {
            typee.Items.Add("Pull");
            typee.Items.Add("Chemise");
            typee.Items.Add("T-shirt");
            typee.Items.Add("veste");
            typee.Items.Add("jeans");
            typee.Items.Add("pantalon");
            typee.Items.Add("jupe");
            typee.Items.Add("robe");
            typee.Items.Add("chapeau");
            typee.Items.Add("cravate");
            cn.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\project_\\mini_project\\mini_project\\DB.mdf\";Integrated Security=True;User Instance=True";

            try
            {
                cn.Open();


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            rechpar.Items.Add("Type");
            rechpar.Items.Add("Marque");
            rechpar.Items.Add("Reference");
            
            
        }

        private void rechpar_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (rechpar.SelectedItem == "Type")
            {
                Typeee.Visible = true;
                typee.Visible = true;
                other.Visible = false;



                Marque.Visible = false;
                reference.Visible = false;
                



                
            }

            else if (rechpar.SelectedItem == "Marque")
            {
                Marque.Visible = true;
                other.Visible = true;
                
                Typeee.Visible = false;
                typee.Visible = false;

                reference.Visible = false;
                

            
            
            }

            else if (rechpar.SelectedItem == "Reference")
            {
                reference.Visible = true;
                other.Visible = true;


                Marque.Visible = false;
                Typeee.Visible = false;
                typee.Visible = false;

                

            }
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            


            if (rechpar.SelectedItem == "Type") {

                string ty = typee.SelectedItem.ToString();
               String req = "select * from vetement where type = '"+ty+"';";
               SqlDataAdapter a = new SqlDataAdapter(req, cn);
               DataSet b = new DataSet();
               a.Fill(b, "vetement");
               resaff.DataSource = b.Tables["vetement"];
            
            }



            else if (rechpar.SelectedItem == "Marque") {

                string ma = other.Text;
                String req = "select * from vetement where marque = '" + ma + "';";
                SqlDataAdapter a = new SqlDataAdapter(req, cn);
                DataSet b = new DataSet();
                a.Fill(b, "vetement");
                resaff.DataSource = b.Tables["vetement"];
             }

            else if (rechpar.SelectedItem == "Reference")
            {

                string refer = other.Text;
                String req = "select * from vetement where reference = '" + refer+ "';";
                SqlDataAdapter a = new SqlDataAdapter(req, cn);
                DataSet b = new DataSet();
                a.Fill(b, "vetement");
                resaff.DataSource = b.Tables["vetement"];
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
