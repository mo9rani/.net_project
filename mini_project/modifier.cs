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
    public partial class modifier : Form
    {
        SqlConnection cn = new SqlConnection();
        public modifier()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modifier_Load(object sender, EventArgs e)
        {
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

            taille.Items.Add("S");
            taille.Items.Add("M");
            taille.Items.Add("L");
            taille.Items.Add("XL");
            taille.Items.Add("--");
            


            cn.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\project_\\mini_project\\mini_project\\DB.mdf\";Integrated Security=True;User Instance=True";

            try
            {
                cn.Open();


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            String req = "select * from vetement";
            SqlDataAdapter a = new SqlDataAdapter(req, cn);
            DataSet b = new DataSet();
            a.Fill(b, "vetement");
            gredupdate.DataSource = b.Tables["vetement"];
        }

        private void gredupdate_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = gredupdate.CurrentCell.RowIndex;

            type.Text = (string)gredupdate.Rows[i].Cells[0].Value;
            marque.Text = (string)gredupdate.Rows[i].Cells[1].Value;
            reference.Text = (string)gredupdate.Rows[i].Cells[2].Value;
            quantite.Text = gredupdate.Rows[i].Cells[3].Value.ToString();
            taille.Text = (string)gredupdate.Rows[i].Cells[4].Value;
            description.Text = (string)gredupdate.Rows[i].Cells[5].Value;
            id.Text = gredupdate.Rows[i].Cells[6].Value.ToString();
            
        }

        private void Appliquer_Click(object sender, EventArgs e)
        {
            string t = type.Text;
            string m = marque.Text;
            string r = reference.Text;
            int q = int.Parse(quantite.Text);
            string tal = taille.Text;
            string d = description.Text;
            int iddd = int.Parse(id.Text);


           
           string req = "update vetement set type = '" + t + "',marque ='" + m + "',reference ='" + r + "',quantite =" + q + ",taille = '" + tal + "',description ='" + d + "' where id = " +iddd+ ";";
           SqlCommand cmd = new SqlCommand(req, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Modification realisee");
            admin dmin = new admin();
            this.Close();
            dmin.Show();
        }

        private void oui_Click(object sender, EventArgs e)
        {
            Appliquer.Visible = true;
            arj3.Visible = true;
            oui.Visible = false;
            gredupdate.Visible = false;
            modifi.Visible = true;
            button1.Visible = false;

        }

        private void arj3_Click(object sender, EventArgs e)
        {
            Appliquer.Visible = false;
            arj3.Visible = false;
            oui.Visible = true;
            gredupdate.Visible = true;
            modifi.Visible = false;
            button1.Visible = true;

        }

        private void modifi_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin bn = new admin();
            this.Close();
            bn.Show();
        }

        private void gredupdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
