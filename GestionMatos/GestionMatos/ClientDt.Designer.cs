
namespace GestionMatos
{
    partial class ClientDt
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
            this.components = new System.ComponentModel.Container();
            this.btn_supp = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButton_mail = new System.Windows.Forms.RadioButton();
            this.radioButton_nom = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.text_chercher = new System.Windows.Forms.TextBox();
            this.chercher_btn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.radioButton_nbrtel = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_supp
            // 
            this.btn_supp.Location = new System.Drawing.Point(1066, 324);
            this.btn_supp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_supp.Name = "btn_supp";
            this.btn_supp.Size = new System.Drawing.Size(112, 35);
            this.btn_supp.TabIndex = 19;
            this.btn_supp.Text = "Supprimer";
            this.btn_supp.UseVisualStyleBackColor = true;
            this.btn_supp.Click += new System.EventHandler(this.btn_supp_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(1066, 258);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(112, 35);
            this.btnModifier.TabIndex = 18;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(1066, 192);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(112, 35);
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = " Tel :";
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(713, 333);
            this.textBox_tel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(328, 26);
            this.textBox_tel.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(623, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mail :";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(713, 267);
            this.textBox_mail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(328, 26);
            this.textBox_mail.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nom :";
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(713, 206);
            this.textBox_nom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(328, 26);
            this.textBox_nom.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(543, 526);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // radioButton_mail
            // 
            this.radioButton_mail.AutoSize = true;
            this.radioButton_mail.Location = new System.Drawing.Point(735, 128);
            this.radioButton_mail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_mail.Name = "radioButton_mail";
            this.radioButton_mail.Size = new System.Drawing.Size(62, 24);
            this.radioButton_mail.TabIndex = 31;
            this.radioButton_mail.TabStop = true;
            this.radioButton_mail.Text = "Mail";
            this.radioButton_mail.UseVisualStyleBackColor = true;
            // 
            // radioButton_nom
            // 
            this.radioButton_nom.AutoSize = true;
            this.radioButton_nom.Location = new System.Drawing.Point(735, 92);
            this.radioButton_nom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_nom.Name = "radioButton_nom";
            this.radioButton_nom.Size = new System.Drawing.Size(67, 24);
            this.radioButton_nom.TabIndex = 30;
            this.radioButton_nom.TabStop = true;
            this.radioButton_nom.Text = "Nom";
            this.radioButton_nom.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Chercher par";
            // 
            // text_chercher
            // 
            this.text_chercher.Location = new System.Drawing.Point(831, 91);
            this.text_chercher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_chercher.Name = "text_chercher";
            this.text_chercher.Size = new System.Drawing.Size(203, 26);
            this.text_chercher.TabIndex = 28;
            // 
            // chercher_btn
            // 
            this.chercher_btn.Location = new System.Drawing.Point(1066, 92);
            this.chercher_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chercher_btn.Name = "chercher_btn";
            this.chercher_btn.Size = new System.Drawing.Size(112, 35);
            this.chercher_btn.TabIndex = 32;
            this.chercher_btn.Text = "Chercher";
            this.chercher_btn.UseVisualStyleBackColor = true;
            this.chercher_btn.Click += new System.EventHandler(this.chercher_btn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // radioButton_nbrtel
            // 
            this.radioButton_nbrtel.AutoSize = true;
            this.radioButton_nbrtel.Location = new System.Drawing.Point(735, 162);
            this.radioButton_nbrtel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_nbrtel.Name = "radioButton_nbrtel";
            this.radioButton_nbrtel.Size = new System.Drawing.Size(187, 24);
            this.radioButton_nbrtel.TabIndex = 33;
            this.radioButton_nbrtel.TabStop = true;
            this.radioButton_nbrtel.Text = "Numéro de téléphone";
            this.radioButton_nbrtel.UseVisualStyleBackColor = true;
            // 
            // ClientDt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1245, 583);
            this.Controls.Add(this.radioButton_nbrtel);
            this.Controls.Add(this.chercher_btn);
            this.Controls.Add(this.radioButton_mail);
            this.Controls.Add(this.radioButton_nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_chercher);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_supp);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_tel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientDt";
            this.Text = "ClientDt";
            this.Load += new System.EventHandler(this.ClientDt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_supp;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton_mail;
        private System.Windows.Forms.RadioButton radioButton_nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_chercher;
        private System.Windows.Forms.Button chercher_btn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.RadioButton radioButton_nbrtel;
    }
}