
namespace vjezbaZavrsniRad
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkRegistrirajSe = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.prijaviSe = new System.Windows.Forms.Button();
            this.korisnickoIme = new System.Windows.Forms.TextBox();
            this.lozinkaa = new System.Windows.Forms.TextBox();
            this.prikazi = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(435, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prijava";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(335, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "korisničko ime:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(335, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "lozinka:";
            // 
            // linkRegistrirajSe
            // 
            this.linkRegistrirajSe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkRegistrirajSe.AutoSize = true;
            this.linkRegistrirajSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkRegistrirajSe.Location = new System.Drawing.Point(497, 332);
            this.linkRegistrirajSe.Name = "linkRegistrirajSe";
            this.linkRegistrirajSe.Size = new System.Drawing.Size(123, 20);
            this.linkRegistrirajSe.TabIndex = 5;
            this.linkRegistrirajSe.TabStop = true;
            this.linkRegistrirajSe.Text = "Registrirajte se";
            this.linkRegistrirajSe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistrirajSe_LinkClicked);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(355, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nemate račun?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // prijaviSe
            // 
            this.prijaviSe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prijaviSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prijaviSe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.prijaviSe.Location = new System.Drawing.Point(411, 422);
            this.prijaviSe.Name = "prijaviSe";
            this.prijaviSe.Size = new System.Drawing.Size(161, 43);
            this.prijaviSe.TabIndex = 7;
            this.prijaviSe.Text = "Prijavi se";
            this.prijaviSe.UseVisualStyleBackColor = true;
            this.prijaviSe.Click += new System.EventHandler(this.button1_Click);
            // 
            // korisnickoIme
            // 
            this.korisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.korisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.korisnickoIme.Location = new System.Drawing.Point(339, 185);
            this.korisnickoIme.Multiline = true;
            this.korisnickoIme.Name = "korisnickoIme";
            this.korisnickoIme.Size = new System.Drawing.Size(334, 38);
            this.korisnickoIme.TabIndex = 8;
            // 
            // lozinkaa
            // 
            this.lozinkaa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lozinkaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lozinkaa.Location = new System.Drawing.Point(339, 270);
            this.lozinkaa.Multiline = true;
            this.lozinkaa.Name = "lozinkaa";
            this.lozinkaa.PasswordChar = '*';
            this.lozinkaa.Size = new System.Drawing.Size(334, 38);
            this.lozinkaa.TabIndex = 9;
            this.lozinkaa.UseSystemPasswordChar = true;
            // 
            // prikazi
            // 
            this.prikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prikazi.AutoSize = true;
            this.prikazi.Location = new System.Drawing.Point(704, 279);
            this.prikazi.Name = "prikazi";
            this.prikazi.Size = new System.Drawing.Size(72, 21);
            this.prikazi.TabIndex = 10;
            this.prikazi.Text = "Prikaži";
            this.prikazi.UseVisualStyleBackColor = true;
            this.prikazi.CheckedChanged += new System.EventHandler(this.prikazi_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 653);
            this.Controls.Add(this.prikazi);
            this.Controls.Add(this.lozinkaa);
            this.Controls.Add(this.korisnickoIme);
            this.Controls.Add(this.prijaviSe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkRegistrirajSe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkRegistrirajSe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button prijaviSe;
        private System.Windows.Forms.TextBox korisnickoIme;
        private System.Windows.Forms.TextBox lozinkaa;
        private System.Windows.Forms.CheckBox prikazi;
    }
}