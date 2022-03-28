using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMatos
{
    public partial class Principale : Form
    {
        public Principale()
        {
            InitializeComponent();
            Console.WriteLine(this.Size.Width);
            Console.WriteLine(this.Size.Height);
            Console.WriteLine(Screen.PrimaryScreen.Bounds.Width);

        }

       
        private void matérielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Materiel m = new Materiel();
            //m.MdiParent = this;
            //m.Dock = DockStyle.Fill;
            //m.Show();
        }

        private void matérielToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Materiel m = new Materiel();
            m.MdiParent = this;
            m.Dock = DockStyle.Fill;
            m.Show();
        }

        private void Parametre_Click(object sender, EventArgs e)
        {

        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients c = new Clients();
            this.IsMdiContainer = true;
            c.MdiParent = this;
            c.Dock = DockStyle.Fill;
            c.Show();
        }

        private void typeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.IsMdiContainer = true;
            l.MdiParent = this;
            l.Dock = DockStyle.Fill;
            l.Show();
        }

        private void matérielToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Materiel m = new Materiel();
            this.IsMdiContainer = true;
            m.MdiParent = this;
            m.Dock = DockStyle.Fill;
            m.Show();
        }

        private void Principale_Load(object sender, EventArgs e)
        {
            Clients c = new Clients();
            this.IsMdiContainer = true;
            c.MdiParent = this;
            c.Dock = DockStyle.Fill;
            c.Show();
        }

        private void siteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Site c = new Site();
            this.IsMdiContainer = true;
            c.MdiParent = this;
            c.Dock = DockStyle.Fill;
            c.Show();
        }
    }
}
