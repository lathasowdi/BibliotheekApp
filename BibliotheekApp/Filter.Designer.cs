namespace BibliotheekApp
{
    partial class Filter
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
            this.btnauteur = new System.Windows.Forms.Button();
            this.btnpub = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnauteur
            // 
            this.btnauteur.Location = new System.Drawing.Point(12, 12);
            this.btnauteur.Name = "btnauteur";
            this.btnauteur.Size = new System.Drawing.Size(150, 23);
            this.btnauteur.TabIndex = 0;
            this.btnauteur.Text = "FILTER OP AUTEUR";
            this.btnauteur.UseVisualStyleBackColor = true;
            this.btnauteur.Click += new System.EventHandler(this.btnauteur_Click);
            // 
            // btnpub
            // 
            this.btnpub.Location = new System.Drawing.Point(12, 41);
            this.btnpub.Name = "btnpub";
            this.btnpub.Size = new System.Drawing.Size(147, 23);
            this.btnpub.TabIndex = 1;
            this.btnpub.Text = "FILTER OP UITGEVERIJ";
            this.btnpub.UseVisualStyleBackColor = true;
            this.btnpub.Click += new System.EventHandler(this.btnpub_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "FILTER OP GENRES";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 157);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnpub);
            this.Controls.Add(this.btnauteur);
            this.Name = "Filter";
            this.Text = "Filter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnauteur;
        private System.Windows.Forms.Button btnpub;
        private System.Windows.Forms.Button button3;
    }
}