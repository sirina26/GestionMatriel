
namespace GestionMatos
{
    partial class Intervention
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
            this.date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateIntr = new System.Windows.Forms.DateTimePicker();
            this.textComment = new System.Windows.Forms.TextBox();
            this.comboMateriel = new System.Windows.Forms.ComboBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supp = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboClient = new System.Windows.Forms.ComboBox();
            this.Client = new System.Windows.Forms.Label();
            this.etat = new System.Windows.Forms.RadioButton();
            this.clie = new System.Windows.Forms.RadioButton();
            this.mat = new System.Windows.Forms.RadioButton();
            this.textCher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chercher_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboEtat = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(864, 243);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(142, 20);
            this.date.TabIndex = 0;
            this.date.Text = "Date intervention : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(864, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Commentaire : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(864, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Materiel :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateIntr
            // 
            this.dateIntr.Location = new System.Drawing.Point(1011, 240);
            this.dateIntr.Name = "dateIntr";
            this.dateIntr.Size = new System.Drawing.Size(332, 26);
            this.dateIntr.TabIndex = 4;
            // 
            // textComment
            // 
            this.textComment.Location = new System.Drawing.Point(1011, 303);
            this.textComment.Multiline = true;
            this.textComment.Name = "textComment";
            this.textComment.Size = new System.Drawing.Size(492, 166);
            this.textComment.TabIndex = 6;
            this.textComment.TextChanged += new System.EventHandler(this.textComment_TextChanged);
            // 
            // comboMateriel
            // 
            this.comboMateriel.FormattingEnabled = true;
            this.comboMateriel.Location = new System.Drawing.Point(1011, 495);
            this.comboMateriel.Name = "comboMateriel";
            this.comboMateriel.Size = new System.Drawing.Size(492, 28);
            this.comboMateriel.TabIndex = 7;
            this.comboMateriel.SelectedIndexChanged += new System.EventHandler(this.comboMateriel_SelectedIndexChanged);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(1011, 612);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(102, 42);
            this.btn_ajouter.TabIndex = 8;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(1128, 612);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(102, 42);
            this.btn_modifier.TabIndex = 9;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supp
            // 
            this.btn_supp.Location = new System.Drawing.Point(1242, 612);
            this.btn_supp.Name = "btn_supp";
            this.btn_supp.Size = new System.Drawing.Size(102, 43);
            this.btn_supp.TabIndex = 10;
            this.btn_supp.Text = "Supprimer";
            this.btn_supp.UseVisualStyleBackColor = true;
            this.btn_supp.Click += new System.EventHandler(this.btn_supp_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(836, 683);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // comboClient
            // 
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(1011, 562);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(492, 28);
            this.comboClient.TabIndex = 13;
            // 
            // Client
            // 
            this.Client.AutoSize = true;
            this.Client.Location = new System.Drawing.Point(864, 565);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(57, 20);
            this.Client.TabIndex = 15;
            this.Client.Text = "Client :";
            // 
            // etat
            // 
            this.etat.AutoSize = true;
            this.etat.Location = new System.Drawing.Point(1203, 118);
            this.etat.Name = "etat";
            this.etat.Size = new System.Drawing.Size(64, 24);
            this.etat.TabIndex = 29;
            this.etat.Text = "Etat";
            this.etat.UseVisualStyleBackColor = true;
            // 
            // clie
            // 
            this.clie.AutoSize = true;
            this.clie.Location = new System.Drawing.Point(1203, 72);
            this.clie.Name = "clie";
            this.clie.Size = new System.Drawing.Size(130, 24);
            this.clie.TabIndex = 28;
            this.clie.Text = "Nom de client";
            this.clie.UseVisualStyleBackColor = true;
            // 
            // mat
            // 
            this.mat.AutoSize = true;
            this.mat.Checked = true;
            this.mat.Location = new System.Drawing.Point(1203, 28);
            this.mat.Name = "mat";
            this.mat.Size = new System.Drawing.Size(127, 24);
            this.mat.TabIndex = 27;
            this.mat.TabStop = true;
            this.mat.Text = "Nom materiel";
            this.mat.UseVisualStyleBackColor = true;
            this.mat.CheckedChanged += new System.EventHandler(this.mat_CheckedChanged);
            // 
            // textCher
            // 
            this.textCher.Location = new System.Drawing.Point(1000, 25);
            this.textCher.Name = "textCher";
            this.textCher.Size = new System.Drawing.Size(181, 26);
            this.textCher.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(864, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Chercher : ";
            // 
            // chercher_btn
            // 
            this.chercher_btn.Location = new System.Drawing.Point(1401, 28);
            this.chercher_btn.Name = "chercher_btn";
            this.chercher_btn.Size = new System.Drawing.Size(102, 43);
            this.chercher_btn.TabIndex = 32;
            this.chercher_btn.Text = "Chercher";
            this.chercher_btn.UseVisualStyleBackColor = true;
            this.chercher_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(864, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Etat";
            // 
            // comboEtat
            // 
            this.comboEtat.FormattingEnabled = true;
            this.comboEtat.Items.AddRange(new object[] {
            "En cours",
            "A faire",
            "Terminé"});
            this.comboEtat.Location = new System.Drawing.Point(1011, 182);
            this.comboEtat.Name = "comboEtat";
            this.comboEtat.Size = new System.Drawing.Size(332, 28);
            this.comboEtat.TabIndex = 35;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // Intervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1754, 740);
            this.Controls.Add(this.comboEtat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chercher_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.etat);
            this.Controls.Add(this.clie);
            this.Controls.Add(this.mat);
            this.Controls.Add(this.textCher);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.comboClient);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_supp);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.comboMateriel);
            this.Controls.Add(this.textComment);
            this.Controls.Add(this.dateIntr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Intervention";
            this.Text = "Intervention";
            this.Load += new System.EventHandler(this.Intervention_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateIntr;
        private System.Windows.Forms.TextBox textComment;
        private System.Windows.Forms.ComboBox comboMateriel;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supp;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboClient;
        private System.Windows.Forms.Label Client;
        private System.Windows.Forms.RadioButton etat;
        private System.Windows.Forms.RadioButton clie;
        private System.Windows.Forms.RadioButton mat;
        private System.Windows.Forms.TextBox textCher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chercher_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboEtat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}