
namespace GestionMatos
{
    partial class Principale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.siteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matérielToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.interventionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.typeToolStripMenuItem1,
            this.siteToolStripMenuItem,
            this.matérielToolStripMenuItem1,
            this.interventionToolStripMenuItem1,
            this.marqueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1061, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.BackColorChanged += new System.EventHandler(this.Parametre_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.clientToolStripMenuItem.Text = "client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // typeToolStripMenuItem1
            // 
            this.typeToolStripMenuItem1.Name = "typeToolStripMenuItem1";
            this.typeToolStripMenuItem1.Size = new System.Drawing.Size(65, 29);
            this.typeToolStripMenuItem1.Text = "Type";
            this.typeToolStripMenuItem1.Click += new System.EventHandler(this.typeToolStripMenuItem1_Click);
            // 
            // siteToolStripMenuItem
            // 
            this.siteToolStripMenuItem.Name = "siteToolStripMenuItem";
            this.siteToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
            this.siteToolStripMenuItem.Text = "Site";
            this.siteToolStripMenuItem.Click += new System.EventHandler(this.siteToolStripMenuItem_Click);
            // 
            // matérielToolStripMenuItem1
            // 
            this.matérielToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.matérielToolStripMenuItem1.Name = "matérielToolStripMenuItem1";
            this.matérielToolStripMenuItem1.Size = new System.Drawing.Size(91, 29);
            this.matérielToolStripMenuItem1.Text = "Matériel";
            this.matérielToolStripMenuItem1.Click += new System.EventHandler(this.matérielToolStripMenuItem1_Click);
            // 
            // interventionToolStripMenuItem1
            // 
            this.interventionToolStripMenuItem1.Name = "interventionToolStripMenuItem1";
            this.interventionToolStripMenuItem1.Size = new System.Drawing.Size(123, 29);
            this.interventionToolStripMenuItem1.Text = "Intervention";
            this.interventionToolStripMenuItem1.Click += new System.EventHandler(this.interventionToolStripMenuItem1_Click);
            // 
            // marqueToolStripMenuItem
            // 
            this.marqueToolStripMenuItem.Name = "marqueToolStripMenuItem";
            this.marqueToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.marqueToolStripMenuItem.Text = "Marque";
            this.marqueToolStripMenuItem.Click += new System.EventHandler(this.marqueToolStripMenuItem_Click);
            // 
            // Principale
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1061, 590);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principale";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "GestionMatos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principale_FormClosed);
            this.Load += new System.EventHandler(this.Principale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem siteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matérielToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem interventionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem marqueToolStripMenuItem;
    }
}