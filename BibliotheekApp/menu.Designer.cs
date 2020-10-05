namespace BibliotheekApp
{
    partial class menu
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
            this.btndelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
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
            this.btndetail.Location = new System.Drawing.Point(152, 12);
            this.btndetail.Name = "btndetail";
            this.btndetail.Size = new System.Drawing.Size(164, 23);
            this.btndetail.TabIndex = 1;
            this.btndetail.Text = "BEKIJKDETAIL";
            this.btndetail.UseVisualStyleBackColor = true;
            this.btndetail.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnaddboek
            // 
            this.btnaddboek.Location = new System.Drawing.Point(152, 41);
            this.btnaddboek.Name = "btnaddboek";
            this.btnaddboek.Size = new System.Drawing.Size(164, 23);
            this.btnaddboek.TabIndex = 2;
            this.btnaddboek.Text = "BOEKTOEVOEGEN";
            this.btnaddboek.UseVisualStyleBackColor = true;
            this.btnaddboek.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnaddauthor
            // 
            this.btnaddauthor.Location = new System.Drawing.Point(152, 96);
            this.btnaddauthor.Name = "btnaddauthor";
            this.btnaddauthor.Size = new System.Drawing.Size(164, 23);
            this.btnaddauthor.TabIndex = 3;
            this.btnaddauthor.Text = "AUTEURSTOEVOEGEN";
            this.btnaddauthor.UseVisualStyleBackColor = true;
            this.btnaddauthor.Click += new System.EventHandler(this.btnaddauthor_Click);
            // 
            // btnaddpub
            // 
            this.btnaddpub.Location = new System.Drawing.Point(152, 125);
            this.btnaddpub.Name = "btnaddpub";
            this.btnaddpub.Size = new System.Drawing.Size(164, 23);
            this.btnaddpub.TabIndex = 4;
            this.btnaddpub.Text = "UITGEVERIJENTOEVOEGEN";
            this.btnaddpub.UseVisualStyleBackColor = true;
            this.btnaddpub.Click += new System.EventHandler(this.btnaddpub_Click);
            // 
            // btnaddgenre
            // 
            this.btnaddgenre.Location = new System.Drawing.Point(152, 154);
            this.btnaddgenre.Name = "btnaddgenre";
            this.btnaddgenre.Size = new System.Drawing.Size(164, 23);
            this.btnaddgenre.TabIndex = 5;
            this.btnaddgenre.Text = "GENRETOEVOEGEN";
            this.btnaddgenre.UseVisualStyleBackColor = true;
            this.btnaddgenre.Click += new System.EventHandler(this.btnaddgenre_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(152, 183);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(164, 23);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "BOEKVERWIJDEREN";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "FILTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(152, 67);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(164, 23);
            this.btnedit.TabIndex = 8;
            this.btnedit.Text = "BOEKBEWERKEN";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 238);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnaddgenre);
            this.Controls.Add(this.btnaddpub);
            this.Controls.Add(this.btnaddauthor);
            this.Controls.Add(this.btnaddboek);
            this.Controls.Add(this.btndetail);
            this.Controls.Add(this.lbBoeken);
            this.Name = "menu";
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
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnedit;
    }
}

