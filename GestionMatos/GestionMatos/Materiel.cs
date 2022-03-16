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
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Materiel", Sql.Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

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

        }

    }
}

