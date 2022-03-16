
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
            this.date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateIntr = new System.Windows.Forms.DateTimePicker();
            this.listIntr = new System.Windows.Forms.ListBox();
            this.textComment = new System.Windows.Forms.TextBox();
            this.comboMateriel = new System.Windows.Forms.ComboBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(237, 62);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(142, 20);
            this.date.TabIndex = 0;
            this.date.Text = "Date intervention : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Commentaire : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Materiel :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateIntr
            // 
            this.dateIntr.Location = new System.Drawing.Point(388, 62);
            this.dateIntr.Name = "dateIntr";
            this.dateIntr.Size = new System.Drawing.Size(333, 26);
            this.dateIntr.TabIndex = 4;
            // 
            // listIntr
            // 
            this.listIntr.FormattingEnabled = true;
            this.listIntr.ItemHeight = 20;
            this.listIntr.Location = new System.Drawing.Point(26, 61);
            this.listIntr.Name = "listIntr";
            this.listIntr.Size = new System.Drawing.Size(205, 284);
            this.listIntr.TabIndex = 5;
            // 
            // textComment
            // 
            this.textComment.Location = new System.Drawing.Point(388, 125);
            this.textComment.Multiline = true;
            this.textComment.Name = "textComment";
            this.textComment.Size = new System.Drawing.Size(333, 162);
            this.textComment.TabIndex = 6;
            // 
            // comboMateriel
            // 
            this.comboMateriel.FormattingEnabled = true;
            this.comboMateriel.Location = new System.Drawing.Point(388, 317);
            this.comboMateriel.Name = "comboMateriel";
            this.comboMateriel.Size = new System.Drawing.Size(333, 28);
            this.comboMateriel.TabIndex = 7;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(388, 364);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(102, 42);
            this.btn_ajouter.TabIndex = 8;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(505, 364);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(102, 42);
            this.btn_modifier.TabIndex = 9;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            // 
            // btn_supp
            // 
            this.btn_supp.Location = new System.Drawing.Point(619, 363);
            this.btn_supp.Name = "btn_supp";
            this.btn_supp.Size = new System.Drawing.Size(102, 43);
            this.btn_supp.TabIndex = 10;
            this.btn_supp.Text = "Supprimer";
            this.btn_supp.UseVisualStyleBackColor = true;
            // 
            // Intervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_supp);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.comboMateriel);
            this.Controls.Add(this.textComment);
            this.Controls.Add(this.listIntr);
            this.Controls.Add(this.dateIntr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date);
            this.Name = "Intervention";
            this.Text = "Intervention";
            this.Load += new System.EventHandler(this.Intervention_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateIntr;
        private System.Windows.Forms.ListBox listIntr;
        private System.Windows.Forms.TextBox textComment;
        private System.Windows.Forms.ComboBox comboMateriel;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supp;
    }
}