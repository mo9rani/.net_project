namespace mini_project
{
    partial class ajoutervet
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
            this.marq = new System.Windows.Forms.TextBox();
            this.typ = new System.Windows.Forms.ComboBox();
            this.refe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Marque = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.qte = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.RadioButton();
            this.xl = new System.Windows.Forms.RadioButton();
            this.s = new System.Windows.Forms.RadioButton();
            this.mm = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(182, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter Article";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // marq
            // 
            this.marq.Location = new System.Drawing.Point(116, 169);
            this.marq.Name = "marq";
            this.marq.Size = new System.Drawing.Size(121, 20);
            this.marq.TabIndex = 3;
            // 
            // typ
            // 
            this.typ.FormattingEnabled = true;
            this.typ.Location = new System.Drawing.Point(115, 108);
            this.typ.Name = "typ";
            this.typ.Size = new System.Drawing.Size(121, 21);
            this.typ.TabIndex = 4;
            // 
            // refe
            // 
            this.refe.Location = new System.Drawing.Point(116, 235);
            this.refe.Name = "refe";
            this.refe.Size = new System.Drawing.Size(121, 20);
            this.refe.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type";
            // 
            // Marque
            // 
            this.Marque.AutoSize = true;
            this.Marque.Font = new System.Drawing.Font("Stencil", 9F);
            this.Marque.Location = new System.Drawing.Point(22, 172);
            this.Marque.Name = "Marque";
            this.Marque.Size = new System.Drawing.Size(54, 14);
            this.Marque.TabIndex = 7;
            this.Marque.Text = "Marque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 9F);
            this.label4.Location = new System.Drawing.Point(22, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reference";
            // 
            // qte
            // 
            this.qte.Location = new System.Drawing.Point(115, 305);
            this.qte.Name = "qte";
            this.qte.Size = new System.Drawing.Size(121, 20);
            this.qte.TabIndex = 9;
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(448, 229);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(121, 20);
            this.desc.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 9F);
            this.label3.Location = new System.Drawing.Point(336, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Taille";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 9F);
            this.label5.Location = new System.Drawing.Point(22, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quantite";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 9F);
            this.label6.Location = new System.Drawing.Point(336, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "Description";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Stencil", 9F);
            this.l.Location = new System.Drawing.Point(436, 155);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(31, 18);
            this.l.TabIndex = 15;
            this.l.TabStop = true;
            this.l.Text = "L";
            this.l.UseVisualStyleBackColor = true;
            // 
            // xl
            // 
            this.xl.AutoSize = true;
            this.xl.Font = new System.Drawing.Font("Stencil", 9F);
            this.xl.Location = new System.Drawing.Point(519, 155);
            this.xl.Name = "xl";
            this.xl.Size = new System.Drawing.Size(38, 18);
            this.xl.TabIndex = 16;
            this.xl.TabStop = true;
            this.xl.Text = "XL";
            this.xl.UseVisualStyleBackColor = true;
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Font = new System.Drawing.Font("Stencil", 9F);
            this.s.Location = new System.Drawing.Point(435, 104);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(32, 18);
            this.s.TabIndex = 17;
            this.s.TabStop = true;
            this.s.Text = "S";
            this.s.UseVisualStyleBackColor = true;
            // 
            // mm
            // 
            this.mm.AutoSize = true;
            this.mm.Font = new System.Drawing.Font("Stencil", 9F);
            this.mm.Location = new System.Drawing.Point(523, 104);
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(34, 18);
            this.mm.TabIndex = 18;
            this.mm.TabStop = true;
            this.mm.Text = "M";
            this.mm.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 9F);
            this.button1.Location = new System.Drawing.Point(471, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Font = new System.Drawing.Font("Stencil", 9F);
            this.no.Location = new System.Drawing.Point(591, 104);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(34, 18);
            this.no.TabIndex = 20;
            this.no.TabStop = true;
            this.no.Text = "- -";
            this.no.UseVisualStyleBackColor = true;
            this.no.CheckedChanged += new System.EventHandler(this.no_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Stencil", 9F);
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "<--------";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ajoutervet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(634, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.no);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mm);
            this.Controls.Add(this.s);
            this.Controls.Add(this.xl);
            this.Controls.Add(this.l);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.qte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Marque);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refe);
            this.Controls.Add(this.typ);
            this.Controls.Add(this.marq);
            this.Controls.Add(this.label1);
            this.Name = "ajoutervet";
            this.Text = "ajoutervet";
            this.Load += new System.EventHandler(this.ajoutervet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox marq;
        private System.Windows.Forms.ComboBox typ;
        private System.Windows.Forms.TextBox refe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Marque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox qte;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton l;
        private System.Windows.Forms.RadioButton xl;
        private System.Windows.Forms.RadioButton s;
        private System.Windows.Forms.RadioButton mm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.Button button2;
    }
}