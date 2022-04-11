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
            Clients c = new Clients();
            this.IsMdiContainer = true;
            c.MdiParent = this;
            c.Dock = DockStyle.Fill;
            c.Show();
        }

        private void typeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Decolor();
            typeToolStripMenuItem1.BackColor = SystemColors.ControlDark;

            Login l = new Login();
            this.IsMdiContainer = true;
            l.MdiParent = this;
            l.Dock = DockStyle.Fill;
            l.Show();
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
            Clients c = new Clients();
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
            public override Color MenuItemSelected
            {
                get { return Color.Red; }
            }

            public override Color MenuBorder  //added for changing the menu border
            {
                get { return Color.Green; }
            }

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
        }
    }
}
