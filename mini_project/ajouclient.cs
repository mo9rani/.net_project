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
    public partial class ajouclient : Form
    {


        SqlConnection cn = new SqlConnection();


        public ajouclient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string pse = pseudo.Text;
            string pas = pass.Text;
            string n = nom.Text;
            string p = prenom.Text;
            int s = int.Parse(solde.Text);
            SqlCommand cmd = new SqlCommand("insert into clients values( '" +pse+ "','" +pas+ "','" +n+ "','" +p+ "'," +s+ ");", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("ajout reussi");
            admin dmin = new admin();
            this.Close();
            dmin.Show();









        }

        private void ajouclient_Load(object sender, EventArgs e)
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin bn = new admin();
            this.Close();
            bn.Show();
        }

      

       
    }
}
