using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMatos
{
    public partial class Type : Form
    {
        public Type()
        {
            InitializeComponent();
        }
        SqlConn Sql = new SqlConn();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Type_Load(object sender, EventArgs e)
        {
            Sql.Connect();
            string req = "SELECT idType, nomType 'Nom de type de materiel' , MTBFMat 'Nombre de produit' FROM typeMateriel LEFT JOIN Materiel ON typeMateriel.idType = Materiel.id_TypeMat";
            SqlDataAdapter sda = new SqlDataAdapter(req, Sql.Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
