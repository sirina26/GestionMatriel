using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMatos
{
    public partial class Materiel : Form
    {
        public Materiel()
        {
            InitializeComponent();
        }
        SqlConn Sql = new SqlConn();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Materiel_Load(object sender, EventArgs e)
        {
            Sql.Connect();
            string req = "SELECT idMat, nomType 'Type de materiel', nomMat 'Nom de materiel', nSerieMat 'Numéro de série', Date_Installation 'Date installation', MTBFMat 'Nombre de produit en stock' FROM Materiel LEFT JOIN typeMateriel ON Materiel.id_TypeMat = typeMateriel.idType;";
            SqlDataAdapter sda = new SqlDataAdapter(req, Sql.Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            
            
            Sql.disconnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void Modifier_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chercher_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void fab_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void serie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void l_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                comboBox_TProd.Text = row.Cells[1].Value.ToString();
                textBox_NomMat.Text = row.Cells[2].Value.ToString();
                textBoxnSerie.Text = row.Cells[3].Value.ToString();
                dateTimePicker1.Text = row.Cells[4].Value.ToString();                
                Nbr_label.Text = row.Cells[5].Value.ToString();                

            }
        }
    }
}

