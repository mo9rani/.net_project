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
    public partial class acceuil : Form
    {    SqlConnection cn = new SqlConnection();


    string nm;
    string pm;
    static int i = 0;
     int cnh;
        public acceuil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
            cn.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Users\\alaa\\Desktop\\c#\\project_\\mini_project\\DB.mdf\";Integrated Security=True;User Instance=True";

            try
            {
                cn.Open();


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
           

       /* private void button2_Click(object sender, EventArgs e)
        {

             
        



            String psedo = textBox3.Text;
            String pass = textBox4.Text;

            SqlCommand cmd = new SqlCommand("insert into clients values( '" + psedo + "','" + pass + "');",cn);
            cmd.ExecuteNonQuery();
           
            
        }*/

        private void button1_Click(object sender, EventArgs e)
        {

            
            String psedo = pseudo.Text;
            String pas = pass.Text;


            SqlCommand cmd = new SqlCommand("select id from clients where pseudo = '" + psedo + "' and pass ='" +pas + "' ;", cn);
           
            
            try
            {
                i = (int)cmd.ExecuteScalar();


                if (i == 1)
                {
                    MessageBox.Show("Welcome " + psedo.ToString());
                    admin ad = new admin();
                    this.Hide();
                    ad.Show();
                    
                }

                else
                {



                    clientt c = new clientt();
                    this.Hide();
                    c.Show();

                    SqlCommand csm = new SqlCommand("select nom from clients where id = "+i+";", cn);
                    nm = (string)csm.ExecuteScalar();


                    SqlCommand csp = new SqlCommand("select prenom from clients where id = " + i + ";", cn);
                    pm = (string)csp.ExecuteScalar();



                     cnh = i;


                    
                    MessageBox.Show("Welcome "+nm+ ","+pm); 


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("mot de passe ou pseudo faux");
            }

        }


        public int functt()
        {
            return i;
        }
        



    }
}
