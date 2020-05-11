namespace mini_project
{
    partial class modifier
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
            this.gredupdate = new System.Windows.Forms.DataGridView();
            this.marque = new System.Windows.Forms.TextBox();
            this.reference = new System.Windows.Forms.TextBox();
            this.quantite = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Appliquer = new System.Windows.Forms.Button();
            this.oui = new System.Windows.Forms.Button();
            this.arj3 = new System.Windows.Forms.Button();
            this.modifi = new System.Windows.Forms.GroupBox();
            this.taille = new System.Windows.Forms.ComboBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gredupdate)).BeginInit();
            this.modifi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gredupdate
            // 
            this.gredupdate.BackgroundColor = System.Drawing.Color.Silver;
            this.gredupdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gredupdate.Location = new System.Drawing.Point(12, 143);
            this.gredupdate.Name = "gredupdate";
            this.gredupdate.Size = new System.Drawing.Size(653, 169);
            this.gredupdate.TabIndex = 0;
            this.gredupdate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gredupdate_CellContentClick);
            this.gredupdate.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gredupdate_CellEnter);
            // 
            // marque
            // 
            this.marque.Location = new System.Drawing.Point(89, 88);
            this.marque.Name = "marque";
            this.marque.Size = new System.Drawing.Size(129, 22);
            this.marque.TabIndex = 2;
            // 
            // reference
            // 
            this.reference.Location = new System.Drawing.Point(89, 150);
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(129, 22);
            this.reference.TabIndex = 3;
            // 
            // quantite
            // 
            this.quantite.Location = new System.Drawing.Point(471, 32);
            this.quantite.Name = "quantite";
            this.quantite.Size = new System.Drawing.Size(129, 22);
            this.quantite.TabIndex = 4;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(471, 147);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(129, 22);
            this.description.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(202, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modifier article";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "marque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "reference";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "quantite";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "taille";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "description";
            // 
            // Appliquer
            // 
            this.Appliquer.Font = new System.Drawing.Font("Stencil", 9F);
            this.Appliquer.Location = new System.Drawing.Point(284, 365);
            this.Appliquer.Name = "Appliquer";
            this.Appliquer.Size = new System.Drawing.Size(87, 40);
            this.Appliquer.TabIndex = 15;
            this.Appliquer.Text = "Appliquer";
            this.Appliquer.UseVisualStyleBackColor = true;
            this.Appliquer.Visible = false;
            this.Appliquer.Click += new System.EventHandler(this.Appliquer_Click);
            // 
            // oui
            // 
            this.oui.Font = new System.Drawing.Font("Stencil", 9F);
            this.oui.Location = new System.Drawing.Point(284, 365);
            this.oui.Name = "oui";
            this.oui.Size = new System.Drawing.Size(86, 40);
            this.oui.TabIndex = 16;
            this.oui.Text = "Modifier cet article";
            this.oui.UseVisualStyleBackColor = true;
            this.oui.Click += new System.EventHandler(this.oui_Click);
            // 
            // arj3
            // 
            this.arj3.Font = new System.Drawing.Font("Stencil", 9F);
            this.arj3.Location = new System.Drawing.Point(-2, 1);
            this.arj3.Name = "arj3";
            this.arj3.Size = new System.Drawing.Size(74, 23);
            this.arj3.TabIndex = 17;
            this.arj3.Text = "<-------";
            this.arj3.UseVisualStyleBackColor = true;
            this.arj3.Visible = false;
            this.arj3.Click += new System.EventHandler(this.arj3_Click);
            // 
            // modifi
            // 
            this.modifi.Controls.Add(this.taille);
            this.modifi.Controls.Add(this.type);
            this.modifi.Controls.Add(this.label7);
            this.modifi.Controls.Add(this.label6);
            this.modifi.Controls.Add(this.label5);
            this.modifi.Controls.Add(this.label4);
            this.modifi.Controls.Add(this.label3);
            this.modifi.Controls.Add(this.label2);
            this.modifi.Controls.Add(this.description);
            this.modifi.Controls.Add(this.quantite);
            this.modifi.Controls.Add(this.reference);
            this.modifi.Controls.Add(this.marque);
            this.modifi.Font = new System.Drawing.Font("Stencil", 9F);
            this.modifi.Location = new System.Drawing.Point(12, 143);
            this.modifi.Name = "modifi";
            this.modifi.Size = new System.Drawing.Size(622, 200);
            this.modifi.TabIndex = 18;
            this.modifi.TabStop = false;
            this.modifi.Text = "Modifier article";
            this.modifi.Visible = false;
            this.modifi.Enter += new System.EventHandler(this.modifi_Enter);
            // 
            // taille
            // 
            this.taille.FormattingEnabled = true;
            this.taille.Location = new System.Drawing.Point(471, 85);
            this.taille.Name = "taille";
            this.taille.Size = new System.Drawing.Size(129, 22);
            this.taille.TabIndex = 16;
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(89, 32);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(124, 22);
            this.type.TabIndex = 15;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(73, 2);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(74, 20);
            this.id.TabIndex = 19;
            this.id.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 9F);
            this.button1.Location = new System.Drawing.Point(-2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 22);
            this.button1.TabIndex = 20;
            this.button1.Text = "<-------";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(679, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.modifi);
            this.Controls.Add(this.arj3);
            this.Controls.Add(this.oui);
            this.Controls.Add(this.Appliquer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gredupdate);
            this.Name = "modifier";
            this.Text = "modifier";
            this.Load += new System.EventHandler(this.modifier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gredupdate)).EndInit();
            this.modifi.ResumeLayout(false);
            this.modifi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gredupdate;
        private System.Windows.Forms.TextBox marque;
        private System.Windows.Forms.TextBox reference;
        private System.Windows.Forms.TextBox quantite;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Appliquer;
        private System.Windows.Forms.Button oui;
        private System.Windows.Forms.Button arj3;
        private System.Windows.Forms.GroupBox modifi;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.ComboBox taille;
        private System.Windows.Forms.Button button1;
    }
}