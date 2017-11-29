namespace PacMan
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hochbtn = new System.Windows.Forms.Button();
            this.runterbtn = new System.Windows.Forms.Button();
            this.linksbtn = new System.Windows.Forms.Button();
            this.rechtsbtn = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.Panel();
            this.playGround = new System.Windows.Forms.Panel();
            this.player2 = new System.Windows.Forms.Panel();
            this.target = new System.Windows.Forms.Panel();
            this.hochbtn2 = new System.Windows.Forms.Button();
            this.runterbtn2 = new System.Windows.Forms.Button();
            this.linksbtn2 = new System.Windows.Forms.Button();
            this.rechtsbtn2 = new System.Windows.Forms.Button();
            this.playGround.SuspendLayout();
            this.SuspendLayout();
            // 
            // hochbtn
            // 
            this.hochbtn.BackColor = System.Drawing.Color.Yellow;
            this.hochbtn.Location = new System.Drawing.Point(80, 397);
            this.hochbtn.Name = "hochbtn";
            this.hochbtn.Size = new System.Drawing.Size(75, 23);
            this.hochbtn.TabIndex = 0;
            this.hochbtn.TabStop = false;
            this.hochbtn.Text = "hoch";
            this.hochbtn.UseVisualStyleBackColor = false;
            this.hochbtn.Click += new System.EventHandler(this.hochbtn_Click);
            // 
            // runterbtn
            // 
            this.runterbtn.BackColor = System.Drawing.Color.Yellow;
            this.runterbtn.Location = new System.Drawing.Point(80, 455);
            this.runterbtn.Name = "runterbtn";
            this.runterbtn.Size = new System.Drawing.Size(75, 23);
            this.runterbtn.TabIndex = 1;
            this.runterbtn.TabStop = false;
            this.runterbtn.Text = "runter";
            this.runterbtn.UseVisualStyleBackColor = false;
            this.runterbtn.Click += new System.EventHandler(this.runterbtn_Click);
            // 
            // linksbtn
            // 
            this.linksbtn.BackColor = System.Drawing.Color.Yellow;
            this.linksbtn.Location = new System.Drawing.Point(5, 426);
            this.linksbtn.Name = "linksbtn";
            this.linksbtn.Size = new System.Drawing.Size(75, 23);
            this.linksbtn.TabIndex = 2;
            this.linksbtn.TabStop = false;
            this.linksbtn.Text = "links";
            this.linksbtn.UseVisualStyleBackColor = false;
            this.linksbtn.Click += new System.EventHandler(this.linksbtn_Click);
            // 
            // rechtsbtn
            // 
            this.rechtsbtn.BackColor = System.Drawing.Color.Yellow;
            this.rechtsbtn.Location = new System.Drawing.Point(155, 426);
            this.rechtsbtn.Name = "rechtsbtn";
            this.rechtsbtn.Size = new System.Drawing.Size(75, 23);
            this.rechtsbtn.TabIndex = 3;
            this.rechtsbtn.TabStop = false;
            this.rechtsbtn.Text = "rechts";
            this.rechtsbtn.UseVisualStyleBackColor = false;
            this.rechtsbtn.Click += new System.EventHandler(this.rechtsbtn_Click);
            // 
            // player
            // 
            this.player.AccessibleName = "Player1";
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(30, 30);
            this.player.TabIndex = 2;
            // 
            // playGround
            // 
            this.playGround.BackColor = System.Drawing.Color.Transparent;
            this.playGround.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playGround.BackgroundImage")));
            this.playGround.Controls.Add(this.player2);
            this.playGround.Controls.Add(this.target);
            this.playGround.Controls.Add(this.player);
            this.playGround.Location = new System.Drawing.Point(202, 120);
            this.playGround.Name = "playGround";
            this.playGround.Size = new System.Drawing.Size(300, 300);
            this.playGround.TabIndex = 4;
            this.playGround.Paint += new System.Windows.Forms.PaintEventHandler(this.playGround_Paint);
            // 
            // player2
            // 
            this.player2.AccessibleName = "Player2";
            this.player2.BackColor = System.Drawing.Color.Transparent;
            this.player2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player2.BackgroundImage")));
            this.player2.Location = new System.Drawing.Point(270, 0);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(30, 30);
            this.player2.TabIndex = 22;
            this.player2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel21_Paint);
            // 
            // target
            // 
            this.target.AccessibleName = "EnemyTarget";
            this.target.BackColor = System.Drawing.Color.Transparent;
            this.target.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("target.BackgroundImage")));
            this.target.Location = new System.Drawing.Point(120, 120);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(30, 30);
            this.target.TabIndex = 1;
            this.target.Paint += new System.Windows.Forms.PaintEventHandler(this.target_Paint);
            // 
            // hochbtn2
            // 
            this.hochbtn2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.hochbtn2.Location = new System.Drawing.Point(534, 397);
            this.hochbtn2.Name = "hochbtn2";
            this.hochbtn2.Size = new System.Drawing.Size(75, 23);
            this.hochbtn2.TabIndex = 5;
            this.hochbtn2.TabStop = false;
            this.hochbtn2.Text = "hoch";
            this.hochbtn2.UseVisualStyleBackColor = false;
            this.hochbtn2.Click += new System.EventHandler(this.hochbtn2_Click);
            // 
            // runterbtn2
            // 
            this.runterbtn2.BackColor = System.Drawing.SystemColors.Highlight;
            this.runterbtn2.Location = new System.Drawing.Point(534, 455);
            this.runterbtn2.Name = "runterbtn2";
            this.runterbtn2.Size = new System.Drawing.Size(75, 23);
            this.runterbtn2.TabIndex = 6;
            this.runterbtn2.TabStop = false;
            this.runterbtn2.Text = "runter";
            this.runterbtn2.UseVisualStyleBackColor = false;
            this.runterbtn2.Click += new System.EventHandler(this.runterbtn2_Click);
            // 
            // linksbtn2
            // 
            this.linksbtn2.BackColor = System.Drawing.SystemColors.Highlight;
            this.linksbtn2.Location = new System.Drawing.Point(461, 426);
            this.linksbtn2.Name = "linksbtn2";
            this.linksbtn2.Size = new System.Drawing.Size(75, 23);
            this.linksbtn2.TabIndex = 7;
            this.linksbtn2.TabStop = false;
            this.linksbtn2.Text = "links";
            this.linksbtn2.UseVisualStyleBackColor = false;
            this.linksbtn2.Click += new System.EventHandler(this.linksbtn2_Click);
            // 
            // rechtsbtn2
            // 
            this.rechtsbtn2.BackColor = System.Drawing.SystemColors.Highlight;
            this.rechtsbtn2.Location = new System.Drawing.Point(607, 426);
            this.rechtsbtn2.Name = "rechtsbtn2";
            this.rechtsbtn2.Size = new System.Drawing.Size(75, 23);
            this.rechtsbtn2.TabIndex = 8;
            this.rechtsbtn2.TabStop = false;
            this.rechtsbtn2.Text = "rechts";
            this.rechtsbtn2.UseVisualStyleBackColor = false;
            this.rechtsbtn2.Click += new System.EventHandler(this.rechtsbtn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 523);
            this.Controls.Add(this.rechtsbtn2);
            this.Controls.Add(this.linksbtn2);
            this.Controls.Add(this.runterbtn2);
            this.Controls.Add(this.hochbtn2);
            this.Controls.Add(this.playGround);
            this.Controls.Add(this.linksbtn);
            this.Controls.Add(this.runterbtn);
            this.Controls.Add(this.hochbtn);
            this.Controls.Add(this.rechtsbtn);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.playGround.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button hochbtn;
        private System.Windows.Forms.Button runterbtn;
        private System.Windows.Forms.Button linksbtn;
        private System.Windows.Forms.Button rechtsbtn;
        private System.Windows.Forms.Panel player;
        private System.Windows.Forms.Panel playGround;
        private System.Windows.Forms.Panel target;
        private System.Windows.Forms.Button hochbtn2;
        private System.Windows.Forms.Button runterbtn2;
        private System.Windows.Forms.Button linksbtn2;
        private System.Windows.Forms.Button rechtsbtn2;
        private System.Windows.Forms.Panel player2;
    }
}

