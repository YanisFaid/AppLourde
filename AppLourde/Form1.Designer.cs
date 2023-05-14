namespace AppLourde
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connexionBTN = new System.Windows.Forms.Button();
            this.identifiantTXT = new System.Windows.Forms.TextBox();
            this.mdpTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connexionBTN
            // 
            this.connexionBTN.Location = new System.Drawing.Point(139, 169);
            this.connexionBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connexionBTN.Name = "connexionBTN";
            this.connexionBTN.Size = new System.Drawing.Size(123, 31);
            this.connexionBTN.TabIndex = 0;
            this.connexionBTN.Text = "Connexion";
            this.connexionBTN.UseVisualStyleBackColor = true;
            this.connexionBTN.Click += new System.EventHandler(this.connexionBTN_Click);
            // 
            // identifiantTXT
            // 
            this.identifiantTXT.Location = new System.Drawing.Point(129, 51);
            this.identifiantTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.identifiantTXT.Name = "identifiantTXT";
            this.identifiantTXT.Size = new System.Drawing.Size(144, 20);
            this.identifiantTXT.TabIndex = 1;
            this.identifiantTXT.TextChanged += new System.EventHandler(this.identifiantTXT_TextChanged);
            // 
            // mdpTXT
            // 
            this.mdpTXT.Location = new System.Drawing.Point(129, 110);
            this.mdpTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mdpTXT.Name = "mdpTXT";
            this.mdpTXT.Size = new System.Drawing.Size(144, 20);
            this.mdpTXT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Identifiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot de passe";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mdpTXT);
            this.Controls.Add(this.identifiantTXT);
            this.Controls.Add(this.connexionBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connexionBTN;
        private System.Windows.Forms.TextBox identifiantTXT;
        private System.Windows.Forms.TextBox mdpTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

