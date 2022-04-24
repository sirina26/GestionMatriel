
namespace GestionMatos
{
    partial class Marque
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chercherbtn = new System.Windows.Forms.Button();
            this.suppbtn = new System.Windows.Forms.Button();
            this.modifierbtn = new System.Windows.Forms.Button();
            this.ajouterbtn = new System.Windows.Forms.Button();
            this.textBoxchercher = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(282, 527);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(395, 242);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(315, 26);
            this.textBoxNom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chercher par nom de marque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom :";
            // 
            // chercherbtn
            // 
            this.chercherbtn.Location = new System.Drawing.Point(775, 51);
            this.chercherbtn.Name = "chercherbtn";
            this.chercherbtn.Size = new System.Drawing.Size(113, 36);
            this.chercherbtn.TabIndex = 5;
            this.chercherbtn.Text = "Chercher";
            this.chercherbtn.UseVisualStyleBackColor = true;
            this.chercherbtn.Click += new System.EventHandler(this.chercherbtn_Click);
            // 
            // suppbtn
            // 
            this.suppbtn.Location = new System.Drawing.Point(775, 430);
            this.suppbtn.Name = "suppbtn";
            this.suppbtn.Size = new System.Drawing.Size(113, 36);
            this.suppbtn.TabIndex = 6;
            this.suppbtn.Text = "Supprimer";
            this.suppbtn.UseVisualStyleBackColor = true;
            this.suppbtn.Click += new System.EventHandler(this.suppbtn_Click);
            // 
            // modifierbtn
            // 
            this.modifierbtn.Location = new System.Drawing.Point(775, 337);
            this.modifierbtn.Name = "modifierbtn";
            this.modifierbtn.Size = new System.Drawing.Size(113, 36);
            this.modifierbtn.TabIndex = 7;
            this.modifierbtn.Text = "Modifier";
            this.modifierbtn.UseVisualStyleBackColor = true;
            this.modifierbtn.Click += new System.EventHandler(this.modifierbtn_Click);
            // 
            // ajouterbtn
            // 
            this.ajouterbtn.Location = new System.Drawing.Point(775, 248);
            this.ajouterbtn.Name = "ajouterbtn";
            this.ajouterbtn.Size = new System.Drawing.Size(113, 36);
            this.ajouterbtn.TabIndex = 8;
            this.ajouterbtn.Text = "Ajouter";
            this.ajouterbtn.UseVisualStyleBackColor = true;
            this.ajouterbtn.Click += new System.EventHandler(this.ajouterbtn_Click);
            // 
            // textBoxchercher
            // 
            this.textBoxchercher.Location = new System.Drawing.Point(523, 56);
            this.textBoxchercher.Name = "textBoxchercher";
            this.textBoxchercher.Size = new System.Drawing.Size(187, 26);
            this.textBoxchercher.TabIndex = 9;
            // 
            // Marque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 669);
            this.Controls.Add(this.textBoxchercher);
            this.Controls.Add(this.ajouterbtn);
            this.Controls.Add(this.modifierbtn);
            this.Controls.Add(this.suppbtn);
            this.Controls.Add(this.chercherbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Marque";
            this.Text = "Marque";
            this.Load += new System.EventHandler(this.Marque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button chercherbtn;
        private System.Windows.Forms.Button suppbtn;
        private System.Windows.Forms.Button modifierbtn;
        private System.Windows.Forms.Button ajouterbtn;
        private System.Windows.Forms.TextBox textBoxchercher;
    }
}