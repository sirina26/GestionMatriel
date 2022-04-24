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

        private void matérielToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Decolor();
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
            this.Decolor();
            clientToolStripMenuItem.BackColor = SystemColors.ControlDark;
            ClientDt c = new ClientDt();
            this.IsMdiContainer = true;
            c.MdiParent = this;
            c.Dock = DockStyle.Fill;
            c.Show();
        }

        private void typeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Decolor();
            typeToolStripMenuItem1.BackColor = SystemColors.ControlDark;
            Type t = new Type();

            this.IsMdiContainer = true;
            t.MdiParent = this;
            t.Dock = DockStyle.Fill;
            t.Show();
        }

        private void matérielToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Decolor();
            matérielToolStripMenuItem1.BackColor = SystemColors.ControlDark;
            
            Materiel m = new Materiel();
            this.IsMdiContainer = true;
            m.MdiParent = this;
            m.Dock = DockStyle.Fill;
            m.Show();
        }

        private void Principale_Load(object sender, EventArgs e)
        {
            this.Decolor();
            ClientDt c = new ClientDt();
            this.IsMdiContainer = true;
            c.MdiParent = this;
            c.Dock = DockStyle.Fill;
            c.Show();
        }

        private void siteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Decolor();
            siteToolStripMenuItem.BackColor = SystemColors.ControlDark;

            Site c = new Site();
            this.IsMdiContainer = true;
            c.MdiParent = this;
            c.Dock = DockStyle.Fill;
            c.Show();
        }
        private void Decolor()
        {
            interventionToolStripMenuItem1.BackColor = SystemColors.Control;
            clientToolStripMenuItem.BackColor = SystemColors.Control;
            typeToolStripMenuItem1.BackColor = SystemColors.Control;
            siteToolStripMenuItem.BackColor = SystemColors.Control;
            matérielToolStripMenuItem1.BackColor = SystemColors.Control;
            marqueToolStripMenuItem.BackColor = SystemColors.Control;
        }
        private void Principale_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void interventionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Decolor();
            interventionToolStripMenuItem1.BackColor = SystemColors.ControlDark;
            Intervention intr = new Intervention();
            this.IsMdiContainer = true;
            intr.MdiParent = this;
            intr.Dock = DockStyle.Fill;
            intr.Show();
        }
        public class TestColorTable : ProfessionalColorTable
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
        }

        private void marqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Decolor();
            marqueToolStripMenuItem.BackColor = SystemColors.ControlDark;
            Marque intr = new Marque();
            this.IsMdiContainer = true;
            intr.MdiParent = this;
            intr.Dock = DockStyle.Fill;
            intr.Show();

        }
    }
}
