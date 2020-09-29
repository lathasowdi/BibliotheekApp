namespace BibliotheekApp
{
    partial class Form1
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
            this.lbBoeken = new System.Windows.Forms.ListBox();
            this.btndetail = new System.Windows.Forms.Button();
            this.btnaddboek = new System.Windows.Forms.Button();
            this.btnaddauthor = new System.Windows.Forms.Button();
            this.btnaddpub = new System.Windows.Forms.Button();
            this.btnaddgenre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBoeken
            // 
            this.lbBoeken.FormattingEnabled = true;
            this.lbBoeken.Location = new System.Drawing.Point(12, 34);
            this.lbBoeken.Name = "lbBoeken";
            this.lbBoeken.Size = new System.Drawing.Size(120, 134);
            this.lbBoeken.TabIndex = 0;
            // 
            // btndetail
            // 
            this.btndetail.Location = new System.Drawing.Point(191, 34);
            this.btndetail.Name = "btndetail";
            this.btndetail.Size = new System.Drawing.Size(96, 23);
            this.btndetail.TabIndex = 1;
            this.btndetail.Text = "BEKIJKDETAIL";
            this.btndetail.UseVisualStyleBackColor = true;
            this.btndetail.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnaddboek
            // 
            this.btnaddboek.Location = new System.Drawing.Point(180, 63);
            this.btnaddboek.Name = "btnaddboek";
            this.btnaddboek.Size = new System.Drawing.Size(116, 23);
            this.btnaddboek.TabIndex = 2;
            this.btnaddboek.Text = "BOEKTOEVOEGEN";
            this.btnaddboek.UseVisualStyleBackColor = true;
            this.btnaddboek.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnaddauthor
            // 
            this.btnaddauthor.Location = new System.Drawing.Point(168, 92);
            this.btnaddauthor.Name = "btnaddauthor";
            this.btnaddauthor.Size = new System.Drawing.Size(136, 23);
            this.btnaddauthor.TabIndex = 3;
            this.btnaddauthor.Text = "AUTEURSTOEVOEGEN";
            this.btnaddauthor.UseVisualStyleBackColor = true;
            this.btnaddauthor.Click += new System.EventHandler(this.btnaddauthor_Click);
            // 
            // btnaddpub
            // 
            this.btnaddpub.Location = new System.Drawing.Point(152, 121);
            this.btnaddpub.Name = "btnaddpub";
            this.btnaddpub.Size = new System.Drawing.Size(164, 23);
            this.btnaddpub.TabIndex = 4;
            this.btnaddpub.Text = "UITGEVERIJENTOEVOEGEN";
            this.btnaddpub.UseVisualStyleBackColor = true;
            this.btnaddpub.Click += new System.EventHandler(this.btnaddpub_Click);
            // 
            // btnaddgenre
            // 
            this.btnaddgenre.Location = new System.Drawing.Point(168, 150);
            this.btnaddgenre.Name = "btnaddgenre";
            this.btnaddgenre.Size = new System.Drawing.Size(128, 23);
            this.btnaddgenre.TabIndex = 5;
            this.btnaddgenre.Text = "GENRETOEVOEGEN";
            this.btnaddgenre.UseVisualStyleBackColor = true;
            this.btnaddgenre.Click += new System.EventHandler(this.btnaddgenre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 204);
            this.Controls.Add(this.btnaddgenre);
            this.Controls.Add(this.btnaddpub);
            this.Controls.Add(this.btnaddauthor);
            this.Controls.Add(this.btnaddboek);
            this.Controls.Add(this.btndetail);
            this.Controls.Add(this.lbBoeken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBoeken;
        private System.Windows.Forms.Button btndetail;
        private System.Windows.Forms.Button btnaddboek;
        private System.Windows.Forms.Button btnaddauthor;
        private System.Windows.Forms.Button btnaddpub;
        private System.Windows.Forms.Button btnaddgenre;
    }
}

