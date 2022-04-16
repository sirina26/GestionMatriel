
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
            this.textBoxnSerie = new System.Windows.Forms.TextBox();
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
            this.mat = new System.Windows.Forms.RadioButton();
            this.serie = new System.Windows.Forms.RadioButton();
            this.fab = new System.Windows.Forms.RadioButton();
            this.chercher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_TProd = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Nbr_label = new System.Windows.Forms.Label();
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
            this.button1.Location = new System.Drawing.Point(585, 411);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_NomMat
            // 
            this.textBox_NomMat.Location = new System.Drawing.Point(585, 136);
            this.textBox_NomMat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_NomMat.Name = "textBox_NomMat";
            this.textBox_NomMat.Size = new System.Drawing.Size(313, 20);
            this.textBox_NomMat.TabIndex = 1;
            this.textBox_NomMat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxnSerie
            // 
            this.textBoxnSerie.Location = new System.Drawing.Point(585, 195);
            this.textBoxnSerie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxnSerie.Name = "textBoxnSerie";
            this.textBoxnSerie.Size = new System.Drawing.Size(313, 20);
            this.textBoxnSerie.TabIndex = 2;
            this.textBoxnSerie.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(582, 103);
            this.l.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(68, 13);
            this.l.TabIndex = 4;
            this.l.Text = "Nom matériel";
            this.l.Click += new System.EventHandler(this.l_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "N° série";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type de produit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 347);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date d\'installation";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(585, 371);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(313, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(698, 411);
            this.Modifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(90, 21);
            this.Modifier.TabIndex = 18;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(808, 411);
            this.Supprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(90, 20);
            this.Supprimer.TabIndex = 19;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 283);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(19, 20);
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
            this.textBoxChercher.Location = new System.Drawing.Point(756, 24);
            this.textBoxChercher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxChercher.Name = "textBoxChercher";
            this.textBoxChercher.Size = new System.Drawing.Size(142, 20);
            this.textBoxChercher.TabIndex = 21;
            this.textBoxChercher.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // mat
            // 
            this.mat.AutoSize = true;
            this.mat.Location = new System.Drawing.Point(649, 15);
            this.mat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mat.Name = "mat";
            this.mat.Size = new System.Drawing.Size(103, 17);
            this.mat.TabIndex = 22;
            this.mat.TabStop = true;
            this.mat.Text = "Type de materiel";
            this.mat.UseVisualStyleBackColor = true;
            this.mat.CheckedChanged += new System.EventHandler(this.mat_CheckedChanged);
            // 
            // serie
            // 
            this.serie.AutoSize = true;
            this.serie.Location = new System.Drawing.Point(649, 41);
            this.serie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serie.Name = "serie";
            this.serie.Size = new System.Drawing.Size(102, 17);
            this.serie.TabIndex = 23;
            this.serie.TabStop = true;
            this.serie.Text = "Numéro de série";
            this.serie.UseVisualStyleBackColor = true;
            this.serie.CheckedChanged += new System.EventHandler(this.serie_CheckedChanged);
            // 
            // fab
            // 
            this.fab.AutoSize = true;
            this.fab.Location = new System.Drawing.Point(650, 72);
            this.fab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fab.Name = "fab";
            this.fab.Size = new System.Drawing.Size(101, 17);
            this.fab.TabIndex = 24;
            this.fab.TabStop = true;
            this.fab.Text = "Nom de materiél";
            this.fab.UseVisualStyleBackColor = true;
            this.fab.CheckedChanged += new System.EventHandler(this.fab_CheckedChanged);
            // 
            // chercher
            // 
            this.chercher.Location = new System.Drawing.Point(922, 21);
            this.chercher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chercher.Name = "chercher";
            this.chercher.Size = new System.Drawing.Size(67, 21);
            this.chercher.TabIndex = 25;
            this.chercher.Text = "Chercher";
            this.chercher.UseVisualStyleBackColor = true;
            this.chercher.Click += new System.EventHandler(this.chercher_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(582, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chercher par";
            // 
            // comboBox_TProd
            // 
            this.comboBox_TProd.FormattingEnabled = true;
            this.comboBox_TProd.Location = new System.Drawing.Point(585, 257);
            this.comboBox_TProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_TProd.Name = "comboBox_TProd";
            this.comboBox_TProd.Size = new System.Drawing.Size(313, 21);
            this.comboBox_TProd.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(557, 444);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 293);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nombre de materiel en stock";
            // 
            // Nbr_label
            // 
            this.Nbr_label.AutoSize = true;
            this.Nbr_label.Location = new System.Drawing.Point(728, 293);
            this.Nbr_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nbr_label.Name = "Nbr_label";
            this.Nbr_label.Size = new System.Drawing.Size(13, 13);
            this.Nbr_label.TabIndex = 29;
            this.Nbr_label.Text = "0";
            // 
            // Materiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1153, 571);
            this.Controls.Add(this.Nbr_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_TProd);
            this.Controls.Add(this.fab);
            this.Controls.Add(this.serie);
            this.Controls.Add(this.mat);
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
            this.Controls.Add(this.textBoxnSerie);
            this.Controls.Add(this.textBox_NomMat);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox textBoxnSerie;
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
        private System.Windows.Forms.RadioButton fab;
        private System.Windows.Forms.RadioButton serie;
        private System.Windows.Forms.RadioButton mat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_TProd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Nbr_label;
        private System.Windows.Forms.Label label5;
    }
}