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
    public partial class Intervention : Form
    {
        public Intervention()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlConn sql = new SqlConn();
        private void Intervention_Load(object sender, EventArgs e)
        {
            sql.Connect();
            string drop = "select idMat, nomMat from Materiel";
            SqlCommand cmd = new SqlCommand(drop, sql.Conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                comboMateriel.Items.Add(dr["nomMat"].ToString());
            }

            dr.Close();

            string query = "Select * from Intervention";

            SqlCommand command = new SqlCommand(query, sql.Conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                listIntr.Items.Add(reader["datePlanifie"].ToString());
                listIntr.Items.Add(reader["idInter"].ToString());
            }
            sql.disconnect();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {

        }
    }
}
