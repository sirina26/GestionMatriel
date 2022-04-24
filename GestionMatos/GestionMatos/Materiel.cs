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

        IDictionary<int, string> idcldic = new Dictionary<int, string>();
        IDictionary<int, string> idsitedic = new Dictionary<int, string>();
        IDictionary<int, string> idMrqdic = new Dictionary<int, string>();
        IDictionary<int, string> idTypedic = new Dictionary<int, string>();
        List<DataRow> mater = new List<DataRow>();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Materiel_Load(object sender, EventArgs e)
        {
            combo_Marque.Items.Clear();
            comboClient.Items.Clear();
            combo_Site.Items.Clear();
            combo_Type.Items.Clear();
            Stock.Checked = true;
            Sql.Connect();
            string req = "SELECT idMat,  nomMat 'Nom de materiel',nomType 'Type', nomMrq 'Marque', nSerieMat 'Numéro de série', Date_Installation 'Date ''achat', MTBFMat 'Nombre de produit en stock' FROM Materiel LEFT JOIN typeMateriel ON Materiel.id_TypeMat = typeMateriel.idType Left join Marque On Materiel.id_Marque = Marque.idMrq;";
            SqlDataAdapter sda = new SqlDataAdapter(req, Sql.Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                mater.Add(dr);
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;

            Sql.disconnect();

            //comboclient
            Sql.Connect();
            string queryc = "Select idClient, nomClient From Client";
            SqlCommand cmdc = new SqlCommand(queryc, Sql.Conn);
            cmdc.CommandText = queryc;
            SqlDataReader drdc = cmdc.ExecuteReader();

            while (drdc.Read())
            {
                comboClient.Items.Add(drdc["nomClient"]).ToString();
                var mykc = idcldic.FirstOrDefault(x => x.Value == drdc["nomClient"].ToString()).Key;

                if (!(idcldic.ContainsKey(mykc)))
                {
                    idcldic.Add((int)drdc["idClient"], drdc["nomClient"].ToString());
                }
            }
            comboClient.SelectedIndex = 1;
            Sql.disconnect();

            //comboSite
            Sql.Connect();
            string queryS = "Select idSite, nomSite From Site";
            SqlCommand cmds = new SqlCommand(queryS, Sql.Conn);
            cmdc.CommandText = queryS;
            SqlDataReader drds = cmds.ExecuteReader();

            while (drds.Read())
            {
                combo_Site.Items.Add(drds["nomSite"]).ToString();
                var myks = idsitedic.FirstOrDefault(x => x.Value == drds["nomSite"].ToString()).Key;

                if (!(idsitedic.ContainsKey(myks)))
                {
                    idsitedic.Add((int)drds["idSite"], drds["nomSite"].ToString());
                }
            }
            combo_Site.SelectedIndex = 1;
            Sql.disconnect();

            /////Marque
            
            Sql.Connect();
            string queryM = "Select idMrq, nomMrq From Marque";
            SqlCommand cmdm = new SqlCommand(queryM, Sql.Conn);
            cmdm.CommandText = queryM;
            SqlDataReader drdm = cmdm.ExecuteReader();

            while (drdm.Read())
            {
                combo_Marque.Items.Add(drdm["nomMrq"]).ToString();
                var mykm = idMrqdic.FirstOrDefault(x => x.Value == drdm["nomMrq"].ToString()).Key;

                if (!(idMrqdic.ContainsKey(mykm)))
                {
                    idMrqdic.Add((int)drdm["idMrq"], drdm["nomMrq"].ToString());
                }
            }
            combo_Marque.SelectedIndex = 1;
            Sql.disconnect();

            //Type de produit
            Sql.Connect();
            string queryt = "Select idType, nomType From typeMateriel";
            SqlCommand cmdt = new SqlCommand(queryt, Sql.Conn);
            cmdc.CommandText = queryt;
            SqlDataReader drdt = cmdt.ExecuteReader();

            while (drdt.Read())
            {
                combo_Type.Items.Add(drdt["nomType"]).ToString();
                var mykt = idTypedic.FirstOrDefault(x => x.Value == drdt["nomType"].ToString()).Key;

                if (!(idTypedic.ContainsKey(mykt)))
                {
                    idTypedic.Add((int)drdt["idType"], drdt["nomType"].ToString());
                }
            }
            combo_Type.SelectedIndex = 1;
            Sql.disconnect();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //recuperer id mater
            string dictype = combo_Type.Text;
            string diccli = comboClient.Text;
            string dicsite = combo_Site.Text;
            string dicmarq = combo_Marque.Text;

            var mykm = (int)idMrqdic.FirstOrDefault(x => x.Value == dicmarq).Key;
            var mykc = (int)idcldic.FirstOrDefault(x => x.Value == diccli).Key;
            var myks = (int)idsitedic.FirstOrDefault(x => x.Value == dicsite).Key;
            var mykt = (int)idTypedic.FirstOrDefault(x => x.Value == dictype).Key;


            string query = $"INSERT INTO Materiel VALUES ('{textBox_NomMat.Text}','{textBox_nSerie.Text}',{textBox_nbrmat.Text},'{dateTimePicker1.Value}',{mykt},{myks},{mykc},{mykm});";
            Sql.Connect();
            SqlCommand cmd = new SqlCommand(query, Sql.Conn);
            cmd.ExecuteNonQuery();
            Sql.disconnect();
            Materiel_Load(sender, e);
            MessageBox.Show("Materiel a été bien ajouté !");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void Modifier_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            //idmateriel
            var t = mater[rowindex][0];

            string dicsit = combo_Site.Text;
            string dicClie = comboClient.Text;
            string dicMarq = combo_Marque.Text;
            string dicType = combo_Type.Text;

            int myk = (int)idsitedic.FirstOrDefault(x => x.Value == dicsit).Key;
            var mykc = (int)idcldic.FirstOrDefault(x => x.Value == dicClie).Key;
            var mykm = (int)idMrqdic.FirstOrDefault(x => x.Value == dicMarq).Key;
            var mykt = (int)idTypedic.FirstOrDefault(x => x.Value == dicType).Key;


            string query = $"update Materiel set nomMat = '{textBox_NomMat.Text}', nSerieMat = '{textBox_nSerie.Text}', Date_Installation = '{dateTimePicker1.Value}', MTBFMat = '{textBox_nbrmat.Text}', id_TypeMat = {mykt}, id_Site = {myk}, id_Client = {mykc}, id_Marque = {mykm} where idMat = {t}";
            Sql.Connect();
            SqlCommand cmd = new SqlCommand(query, Sql.Conn);
            cmd.ExecuteNonQuery();
            Sql.disconnect();
            MessageBox.Show("Materiel est bien Modifier !");
            Materiel_Load(sender, e);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chercher_Click(object sender, EventArgs e)
        {

            if (textBoxChercher.Text == "")
            {
                Materiel_Load(sender, e);
                return;
            }
            Sql.Connect();

            //var type = (int)idTypedic.FirstOrDefault(x => x.Value == textBoxChercher.Text).Key;

            string check = "nomMat";

            if (Stock.Checked)
            {
                check = "MTBFMat";
            }
            else if (serie.Checked)
            {
                check = "nSerieMat";
            } 
            else if (nommat.Checked)
            {
                check = "nomMat";
            }
            string st = textBoxChercher.Text;
            string req = "SELECT idMat,  nomMat 'Nom de materiel', nomType 'Type', nomMrq 'Marque', nSerieMat 'Numéro de série', Date_Installation 'Date ''achat', MTBFMat 'Nombre de produit en stock' FROM Materiel LEFT JOIN typeMateriel ON Materiel.id_TypeMat = typeMateriel.idType Left join Marque On Materiel.id_Marque = Marque.idMrq where " + check + " like('" + st + "%');";
            SqlDataAdapter sda = new SqlDataAdapter(req, Sql.Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.DataSource = dt;
            Sql.disconnect();
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
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            //idIntervention
            var t = mater[rowindex][0];
            string query = $"Delete from Materiel where idMat={t};";
            Sql.Connect();
            SqlCommand cmd = new SqlCommand(query, Sql.Conn);
            cmd.ExecuteNonQuery();
            Sql.disconnect();
            MessageBox.Show("Materil supprimer");
            Materiel_Load(sender, e);
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
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                combo_Type.Text = row.Cells[2].Value.ToString();
                combo_Marque.Text = row.Cells[3].Value.ToString();
                textBox_NomMat.Text = row.Cells[1].Value.ToString();
                textBox_nSerie.Text = row.Cells[4].Value.ToString();
                textBox_nbrmat.Text = row.Cells[6].Value.ToString();

                dateTimePicker1.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception uue)
            { }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_TProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nbr_label_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellContentClick_1(sender, e);
        }
    }
}

