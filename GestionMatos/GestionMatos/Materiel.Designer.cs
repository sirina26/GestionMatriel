
namespace GestionMatos
{
    partial class Materiel
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_NomMat = new System.Windows.Forms.TextBox();
            this.textBox_nSerie = new System.Windows.Forms.TextBox();
            this.l = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.gestionMatosDBDataSet = new GestionMatos.GestionMatosDBDataSet();
            this.gestionMatosDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxChercher = new System.Windows.Forms.TextBox();
            this.Stock = new System.Windows.Forms.RadioButton();
            this.serie = new System.Windows.Forms.RadioButton();
            this.nommat = new System.Windows.Forms.RadioButton();
            this.chercher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_Type = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_Site = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboClient = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combo_Marque = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_nbrmat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1001, 725);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_NomMat
            // 
            this.textBox_NomMat.Location = new System.Drawing.Point(998, 198);
            this.textBox_NomMat.Name = "textBox_NomMat";
            this.textBox_NomMat.Size = new System.Drawing.Size(468, 26);
            this.textBox_NomMat.TabIndex = 1;
            this.textBox_NomMat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_nSerie
            // 
            this.textBox_nSerie.Location = new System.Drawing.Point(1000, 262);
            this.textBox_nSerie.Name = "textBox_nSerie";
            this.textBox_nSerie.Size = new System.Drawing.Size(468, 26);
            this.textBox_nSerie.TabIndex = 2;
            this.textBox_nSerie.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(995, 173);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(102, 20);
            this.l.TabIndex = 4;
            this.l.Text = "Nom matériel";
            this.l.Click += new System.EventHandler(this.l_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(997, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "N° série";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(997, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type de produit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(996, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date d\'achat";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1002, 472);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(468, 26);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(1170, 725);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(135, 32);
            this.Modifier.TabIndex = 18;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(1335, 725);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(135, 31);
            this.Supprimer.TabIndex = 19;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(18, 435);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(26, 26);
            this.textBox4.TabIndex = 20;
            this.textBox4.Visible = false;
            // 
            // gestionMatosDBDataSet
            // 
            this.gestionMatosDBDataSet.DataSetName = "GestionMatosDBDataSet";
            this.gestionMatosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionMatosDBDataSetBindingSource
            // 
            this.gestionMatosDBDataSetBindingSource.DataSource = this.gestionMatosDBDataSet;
            this.gestionMatosDBDataSetBindingSource.Position = 0;
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
            // textBoxChercher
            // 
            this.textBoxChercher.Location = new System.Drawing.Point(1256, 52);
            this.textBoxChercher.Name = "textBoxChercher";
            this.textBoxChercher.Size = new System.Drawing.Size(211, 26);
            this.textBoxChercher.TabIndex = 21;
            this.textBoxChercher.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Location = new System.Drawing.Point(1096, 38);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(75, 24);
            this.Stock.TabIndex = 22;
            this.Stock.TabStop = true;
            this.Stock.Text = "Stock";
            this.Stock.UseVisualStyleBackColor = true;
            this.Stock.CheckedChanged += new System.EventHandler(this.mat_CheckedChanged);
            // 
            // serie
            // 
            this.serie.AutoSize = true;
            this.serie.Location = new System.Drawing.Point(1096, 76);
            this.serie.Name = "serie";
            this.serie.Size = new System.Drawing.Size(150, 24);
            this.serie.TabIndex = 23;
            this.serie.TabStop = true;
            this.serie.Text = "Numéro de série";
            this.serie.UseVisualStyleBackColor = true;
            this.serie.CheckedChanged += new System.EventHandler(this.serie_CheckedChanged);
            // 
            // nommat
            // 
            this.nommat.AutoSize = true;
            this.nommat.Location = new System.Drawing.Point(1097, 115);
            this.nommat.Name = "nommat";
            this.nommat.Size = new System.Drawing.Size(149, 24);
            this.nommat.TabIndex = 24;
            this.nommat.TabStop = true;
            this.nommat.Text = "Nom de materiél";
            this.nommat.UseVisualStyleBackColor = true;
            this.nommat.CheckedChanged += new System.EventHandler(this.fab_CheckedChanged);
            // 
            // chercher
            // 
            this.chercher.Location = new System.Drawing.Point(1366, 109);
            this.chercher.Name = "chercher";
            this.chercher.Size = new System.Drawing.Size(100, 32);
            this.chercher.TabIndex = 25;
            this.chercher.Text = "Chercher";
            this.chercher.UseVisualStyleBackColor = true;
            this.chercher.Click += new System.EventHandler(this.chercher_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(995, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chercher par";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // combo_Type
            // 
            this.combo_Type.FormattingEnabled = true;
            this.combo_Type.Location = new System.Drawing.Point(998, 325);
            this.combo_Type.Name = "combo_Type";
            this.combo_Type.Size = new System.Drawing.Size(468, 28);
            this.combo_Type.TabIndex = 26;
            this.combo_Type.SelectedIndexChanged += new System.EventHandler(this.comboBox_TProd_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(945, 683);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(998, 639);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nombre de materiel en stock";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // combo_Site
            // 
            this.combo_Site.FormattingEnabled = true;
            this.combo_Site.Location = new System.Drawing.Point(1002, 598);
            this.combo_Site.Name = "combo_Site";
            this.combo_Site.Size = new System.Drawing.Size(468, 28);
            this.combo_Site.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(998, 575);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Site";
            // 
            // comboClient
            // 
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(1002, 535);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(468, 28);
            this.comboClient.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(998, 508);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Client";
            // 
            // combo_Marque
            // 
            this.combo_Marque.FormattingEnabled = true;
            this.combo_Marque.Location = new System.Drawing.Point(1001, 394);
            this.combo_Marque.Name = "combo_Marque";
            this.combo_Marque.Size = new System.Drawing.Size(468, 28);
            this.combo_Marque.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(997, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Marque";
            // 
            // textBox_nbrmat
            // 
            this.textBox_nbrmat.Location = new System.Drawing.Point(1002, 674);
            this.textBox_nbrmat.Name = "textBox_nbrmat";
            this.textBox_nbrmat.Size = new System.Drawing.Size(468, 26);
            this.textBox_nbrmat.TabIndex = 36;
            // 
            // Materiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1849, 878);
            this.Controls.Add(this.textBox_nbrmat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combo_Marque);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combo_Site);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.combo_Type);
            this.Controls.Add(this.nommat);
            this.Controls.Add(this.serie);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chercher);
            this.Controls.Add(this.textBoxChercher);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l);
            this.Controls.Add(this.textBox_nSerie);
            this.Controls.Add(this.textBox_NomMat);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Materiel";
            this.Text = "Materiel";
            this.Load += new System.EventHandler(this.Materiel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_NomMat;
        private System.Windows.Forms.TextBox textBox_nSerie;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.TextBox textBox4;
        private GestionMatosDBDataSet gestionMatosDBDataSet;
        private System.Windows.Forms.BindingSource gestionMatosDBDataSetBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.TextBox textBoxChercher;
        private System.Windows.Forms.Button chercher;
        private System.Windows.Forms.RadioButton nommat;
        private System.Windows.Forms.RadioButton serie;
        private System.Windows.Forms.RadioButton Stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_Type;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_Marque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_Site;
        private System.Windows.Forms.TextBox textBox_nbrmat;
    }
}