using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CrudAdoDis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("initial catalog= ClientManage; data source= DESKTOP-TLLL2MM; integrated security= true;");
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        BindingSource bs = new BindingSource();



        private void Form1_Load(object sender, EventArgs e)
        {

            da.SelectCommand = new SqlCommand("Select * From Client", cn);
            da.Fill(ds, "Client");

            bs.DataSource = ds.Tables["Client"];


            inp_Nom.DataBindings.Add("text", bs, "nom", true);
            inp_Prenom.DataBindings.Add("text", bs, "prenom", true);
            inp_Adresse.DataBindings.Add("text", bs, "adresse", true);
            inp_ville.DataBindings.Add("text", bs, "ville", true);

            //cb_ville.DisplayMember = "ville";
            //cb_ville.ValueMember = "ville";
            //cb_ville.DataSource = ds.Tables[0];


            dataGridView1.DataSource = bs;


        }


        private void button1_Click(object sender, EventArgs e)
        {
            bs.AddNew();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
                    
            bs.EndEdit();

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            bs.RemoveCurrent();
        }

        private void btn_maj_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scmb = new SqlCommandBuilder(da);
            da.SelectCommand = new SqlCommand("Select * From Client", cn);
            da.Update(ds.Tables[0]);
            MessageBox.Show("Confirmer la sauvegarde");
        }

        private void btn_filtre_Click(object sender, EventArgs e)
        {
            btn_filtre.Hide();
            btn_filtre2.Show();
            inp_ville.Hide();
            inp_filtre.Clear();
            inp_filtre.Show();
            inp_filtre.Focus();

        }

        private void btn_filtre2_Click(object sender, EventArgs e)
        {
            DataTable cl;
            cl = ds.Tables["Client"];
            
            btn_back.Show();
 
            DataView v = cl.DefaultView;
            v.RowFilter = $"ville='{inp_filtre.Text}'";
            dataGridView1.DataSource = v.ToTable();
            v.RowFilter = String.Empty;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
                    
            dataGridView1.DataSource = bs;            
            btn_back.Hide();
            inp_ville.Show();
            inp_filtre.Hide();
            btn_filtre.Show();
            btn_filtre2.Hide();
        }





        private void inp_id_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_ville_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




    }
}
