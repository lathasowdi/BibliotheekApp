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
            this.btnscore = new System.Windows.Forms.Button();
            this.btnpagina = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnauteur
            // 
            this.btnauteur.Location = new System.Drawing.Point(12, 12);
            this.btnauteur.Name = "btnauteur";
            this.btnauteur.Size = new System.Drawing.Size(177, 23);
            this.btnauteur.TabIndex = 0;
            this.btnauteur.Text = "FILTER OP AUTEUR";
            this.btnauteur.UseVisualStyleBackColor = true;
            this.btnauteur.Click += new System.EventHandler(this.btnauteur_Click);
            // 
            // btnpub
            // 
            this.btnpub.Location = new System.Drawing.Point(12, 41);
            this.btnpub.Name = "btnpub";
            this.btnpub.Size = new System.Drawing.Size(177, 23);
            this.btnpub.TabIndex = 1;
            this.btnpub.Text = "FILTER OP UITGEVERIJ";
            this.btnpub.UseVisualStyleBackColor = true;
            this.btnpub.Click += new System.EventHandler(this.btnpub_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "FILTER OP GENRES";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnscore
            // 
            this.btnscore.Location = new System.Drawing.Point(12, 99);
            this.btnscore.Name = "btnscore";
            this.btnscore.Size = new System.Drawing.Size(177, 30);
            this.btnscore.TabIndex = 3;
            this.btnscore.Text = "SORTEREN OP SCORE";
            this.btnscore.UseVisualStyleBackColor = true;
            this.btnscore.Click += new System.EventHandler(this.btnscore_Click);
            // 
            // btnpagina
            // 
            this.btnpagina.Location = new System.Drawing.Point(12, 135);
            this.btnpagina.Name = "btnpagina";
            this.btnpagina.Size = new System.Drawing.Size(177, 30);
            this.btnpagina.TabIndex = 4;
            this.btnpagina.Text = "SORTEREN OP PAGINA";
            this.btnpagina.UseVisualStyleBackColor = true;
            this.btnpagina.Click += new System.EventHandler(this.btnpagina_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "SORTEREN OP PUBLICATIE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 233);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnpagina);
            this.Controls.Add(this.btnscore);
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
        private System.Windows.Forms.Button btnscore;
        private System.Windows.Forms.Button btnpagina;
        private System.Windows.Forms.Button button4;
    }
}