﻿namespace mini_project
{
    partial class recherche
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rechpar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typee = new System.Windows.Forms.ComboBox();
            this.Typeee = new System.Windows.Forms.Label();
            this.other = new System.Windows.Forms.TextBox();
            this.Marque = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reference = new System.Windows.Forms.Label();
            this.resaff = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resaff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(264, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherche Article";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rechpar
            // 
            this.rechpar.FormattingEnabled = true;
            this.rechpar.Location = new System.Drawing.Point(152, 162);
            this.rechpar.Name = "rechpar";
            this.rechpar.Size = new System.Drawing.Size(143, 21);
            this.rechpar.TabIndex = 1;
            this.rechpar.SelectedIndexChanged += new System.EventHandler(this.rechpar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 9F);
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rechercher par";
            // 
            // typee
            // 
            this.typee.FormattingEnabled = true;
            this.typee.Location = new System.Drawing.Point(596, 162);
            this.typee.Name = "typee";
            this.typee.Size = new System.Drawing.Size(159, 21);
            this.typee.TabIndex = 3;
            this.typee.Visible = false;
            // 
            // Typeee
            // 
            this.Typeee.AutoSize = true;
            this.Typeee.Font = new System.Drawing.Font("Stencil", 9F);
            this.Typeee.Location = new System.Drawing.Point(517, 164);
            this.Typeee.Name = "Typeee";
            this.Typeee.Size = new System.Drawing.Size(36, 14);
            this.Typeee.TabIndex = 4;
            this.Typeee.Text = "type";
            this.Typeee.Visible = false;
            // 
            // other
            // 
            this.other.Location = new System.Drawing.Point(596, 163);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(159, 20);
            this.other.TabIndex = 5;
            this.other.Visible = false;
            // 
            // Marque
            // 
            this.Marque.AutoSize = true;
            this.Marque.Font = new System.Drawing.Font("Stencil", 9F);
            this.Marque.Location = new System.Drawing.Point(517, 165);
            this.Marque.Name = "Marque";
            this.Marque.Size = new System.Drawing.Size(54, 14);
            this.Marque.TabIndex = 6;
            this.Marque.Text = "Marque";
            this.Marque.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 9F);
            this.button1.Location = new System.Drawing.Point(360, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Appliquer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reference
            // 
            this.reference.AutoSize = true;
            this.reference.Font = new System.Drawing.Font("Stencil", 9F);
            this.reference.Location = new System.Drawing.Point(498, 166);
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(73, 14);
            this.reference.TabIndex = 8;
            this.reference.Text = "Reference";
            this.reference.Visible = false;
            // 
            // resaff
            // 
            this.resaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resaff.Location = new System.Drawing.Point(25, 289);
            this.resaff.Name = "resaff";
            this.resaff.Size = new System.Drawing.Size(756, 171);
            this.resaff.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Stencil", 9F);
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 25);
            this.button2.TabIndex = 11;
            this.button2.Text = "<-------";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // recherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(807, 489);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resaff);
            this.Controls.Add(this.reference);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Marque);
            this.Controls.Add(this.other);
            this.Controls.Add(this.Typeee);
            this.Controls.Add(this.typee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rechpar);
            this.Controls.Add(this.label1);
            this.Name = "recherche";
            this.Text = "recherche";
            this.Load += new System.EventHandler(this.recherche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rechpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typee;
        private System.Windows.Forms.Label Typeee;
        private System.Windows.Forms.TextBox other;
        private System.Windows.Forms.Label Marque;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label reference;
        private System.Windows.Forms.DataGridView resaff;
        private System.Windows.Forms.Button button2;
    }
}