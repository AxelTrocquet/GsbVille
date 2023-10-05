
namespace Mission1AP3
{
    partial class FormVille
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextNBVille = new System.Windows.Forms.TextBox();
            this.BtnAfficher = new System.Windows.Forms.Button();
            this.listVilles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des Villes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Limite de Villes à Afficher";
            // 
            // TextNBVille
            // 
            this.TextNBVille.Location = new System.Drawing.Point(588, 39);
            this.TextNBVille.Name = "TextNBVille";
            this.TextNBVille.Size = new System.Drawing.Size(86, 20);
            this.TextNBVille.TabIndex = 8;
            this.TextNBVille.Text = "50";
            // 
            // BtnAfficher
            // 
            this.BtnAfficher.Location = new System.Drawing.Point(610, 65);
            this.BtnAfficher.Name = "BtnAfficher";
            this.BtnAfficher.Size = new System.Drawing.Size(64, 20);
            this.BtnAfficher.TabIndex = 9;
            this.BtnAfficher.Text = "Afficher";
            this.BtnAfficher.UseVisualStyleBackColor = true;
            this.BtnAfficher.Click += new System.EventHandler(this.BtnAfficher_Click);
            // 
            // listVilles
            // 
            this.listVilles.FormattingEnabled = true;
            this.listVilles.Location = new System.Drawing.Point(11, 39);
            this.listVilles.Name = "listVilles";
            this.listVilles.Size = new System.Drawing.Size(571, 342);
            this.listVilles.TabIndex = 10;
            // 
            // FormVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.listVilles);
            this.Controls.Add(this.BtnAfficher);
            this.Controls.Add(this.TextNBVille);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormVille";
            this.Text = "Liste Des Villes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextNBVille;
        private System.Windows.Forms.Button BtnAfficher;
        private System.Windows.Forms.ListBox listVilles;
    }
}

