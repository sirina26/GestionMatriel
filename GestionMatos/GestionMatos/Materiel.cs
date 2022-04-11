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
            SqlDataAdapter sda = new SqlDataAdapter("Select idMat Id, nomMat 'nom de materiél', nSerieMat 'numéro de série', MTBFMat 'matiére de fabrication',Date_Installation 'Date de installation' From Materiel", Sql.Conn);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                ///textBox4.Text = row.Cells[5].Value.ToString();
                dateTimePicker1.Text = row.Cells[4].Value.ToString();
            }
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

