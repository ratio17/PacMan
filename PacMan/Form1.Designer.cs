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
            this.item1 = new System.Windows.Forms.Panel();
            this.item3 = new System.Windows.Forms.Panel();
            this.item2 = new System.Windows.Forms.Panel();
            this.player2 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.target = new System.Windows.Forms.Panel();
            this.hochbtn2 = new System.Windows.Forms.Button();
            this.runterbtn2 = new System.Windows.Forms.Button();
            this.linksbtn2 = new System.Windows.Forms.Button();
            this.rechtsbtn2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.playGround.SuspendLayout();
            this.SuspendLayout();
            // 
            // hochbtn
            // 
            this.hochbtn.BackColor = System.Drawing.Color.Yellow;
            this.hochbtn.Location = new System.Drawing.Point(75, 340);
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
            this.runterbtn.Location = new System.Drawing.Point(75, 398);
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
            this.linksbtn.Location = new System.Drawing.Point(0, 369);
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
            this.rechtsbtn.Location = new System.Drawing.Point(150, 369);
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
            this.playGround.Controls.Add(this.item1);
            this.playGround.Controls.Add(this.item3);
            this.playGround.Controls.Add(this.item2);
            this.playGround.Controls.Add(this.player2);
            this.playGround.Controls.Add(this.panel20);
            this.playGround.Controls.Add(this.panel19);
            this.playGround.Controls.Add(this.panel18);
            this.playGround.Controls.Add(this.panel17);
            this.playGround.Controls.Add(this.panel16);
            this.playGround.Controls.Add(this.panel15);
            this.playGround.Controls.Add(this.panel14);
            this.playGround.Controls.Add(this.panel13);
            this.playGround.Controls.Add(this.panel12);
            this.playGround.Controls.Add(this.panel11);
            this.playGround.Controls.Add(this.panel10);
            this.playGround.Controls.Add(this.panel9);
            this.playGround.Controls.Add(this.panel8);
            this.playGround.Controls.Add(this.panel7);
            this.playGround.Controls.Add(this.panel6);
            this.playGround.Controls.Add(this.panel5);
            this.playGround.Controls.Add(this.panel4);
            this.playGround.Controls.Add(this.panel2);
            this.playGround.Controls.Add(this.panel3);
            this.playGround.Controls.Add(this.panel1);
            this.playGround.Controls.Add(this.target);
            this.playGround.Controls.Add(this.player);
            this.playGround.Location = new System.Drawing.Point(12, 12);
            this.playGround.Name = "playGround";
            this.playGround.Size = new System.Drawing.Size(600, 300);
            this.playGround.TabIndex = 4;
            this.playGround.Paint += new System.Windows.Forms.PaintEventHandler(this.playGround_Paint);
            // 
            // item1
            // 
            this.item1.BackColor = System.Drawing.Color.Transparent;
            this.item1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("item1.BackgroundImage")));
            this.item1.Location = new System.Drawing.Point(60, 90);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(30, 30);
            this.item1.TabIndex = 24;
            this.item1.Paint += new System.Windows.Forms.PaintEventHandler(this.item1_Paint);
            // 
            // item3
            // 
            this.item3.BackColor = System.Drawing.Color.Transparent;
            this.item3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("item3.BackgroundImage")));
            this.item3.Location = new System.Drawing.Point(0, 270);
            this.item3.Name = "item3";
            this.item3.Size = new System.Drawing.Size(30, 30);
            this.item3.TabIndex = 26;
            // 
            // item2
            // 
            this.item2.BackColor = System.Drawing.Color.Transparent;
            this.item2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("item2.BackgroundImage")));
            this.item2.Location = new System.Drawing.Point(240, 90);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(30, 30);
            this.item2.TabIndex = 25;
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
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.Lime;
            this.panel20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel20.BackgroundImage")));
            this.panel20.Location = new System.Drawing.Point(90, 60);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(30, 30);
            this.panel20.TabIndex = 21;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Lime;
            this.panel19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel19.BackgroundImage")));
            this.panel19.Location = new System.Drawing.Point(60, 60);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(30, 30);
            this.panel19.TabIndex = 20;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Lime;
            this.panel18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel18.BackgroundImage")));
            this.panel18.Location = new System.Drawing.Point(210, 90);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(30, 30);
            this.panel18.TabIndex = 19;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Transparent;
            this.panel17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel17.BackgroundImage")));
            this.panel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel17.Location = new System.Drawing.Point(210, 60);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(30, 30);
            this.panel17.TabIndex = 18;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Lime;
            this.panel16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel16.BackgroundImage")));
            this.panel16.Location = new System.Drawing.Point(240, 60);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(30, 30);
            this.panel16.TabIndex = 17;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Lime;
            this.panel15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel15.BackgroundImage")));
            this.panel15.Location = new System.Drawing.Point(270, 60);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(30, 30);
            this.panel15.TabIndex = 16;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Lime;
            this.panel14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel14.BackgroundImage")));
            this.panel14.Location = new System.Drawing.Point(120, 180);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(30, 30);
            this.panel14.TabIndex = 15;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Lime;
            this.panel13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel13.BackgroundImage")));
            this.panel13.Location = new System.Drawing.Point(120, 210);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(30, 30);
            this.panel13.TabIndex = 14;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Lime;
            this.panel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel12.BackgroundImage")));
            this.panel12.Location = new System.Drawing.Point(150, 270);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(30, 30);
            this.panel12.TabIndex = 13;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Lime;
            this.panel11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel11.BackgroundImage")));
            this.panel11.Location = new System.Drawing.Point(210, 240);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(30, 30);
            this.panel11.TabIndex = 12;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.Location = new System.Drawing.Point(30, 60);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(30, 30);
            this.panel10.TabIndex = 11;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.Location = new System.Drawing.Point(30, 90);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(30, 30);
            this.panel9.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Lime;
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.Location = new System.Drawing.Point(30, 120);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(30, 30);
            this.panel8.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Lime;
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.Location = new System.Drawing.Point(210, 120);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(30, 30);
            this.panel7.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Lime;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Location = new System.Drawing.Point(150, 240);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(30, 30);
            this.panel6.TabIndex = 7;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Location = new System.Drawing.Point(120, 240);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 30);
            this.panel5.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lime;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Location = new System.Drawing.Point(180, 240);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 30);
            this.panel4.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(30, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 30);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(30, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 30);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(30, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.hochbtn2.Location = new System.Drawing.Point(448, 340);
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
            this.runterbtn2.Location = new System.Drawing.Point(448, 398);
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
            this.linksbtn2.Location = new System.Drawing.Point(375, 369);
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
            this.rechtsbtn2.Location = new System.Drawing.Point(521, 369);
            this.rechtsbtn2.Name = "rechtsbtn2";
            this.rechtsbtn2.Size = new System.Drawing.Size(75, 23);
            this.rechtsbtn2.TabIndex = 8;
            this.rechtsbtn2.TabStop = false;
            this.rechtsbtn2.Text = "rechts";
            this.rechtsbtn2.UseVisualStyleBackColor = false;
            this.rechtsbtn2.Click += new System.EventHandler(this.rechtsbtn2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(231, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "    <-Player1   |   Player2->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 603);
            this.Controls.Add(this.textBox1);
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
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button hochbtn;
        private System.Windows.Forms.Button runterbtn;
        private System.Windows.Forms.Button linksbtn;
        private System.Windows.Forms.Button rechtsbtn;
        private System.Windows.Forms.Panel player;
        private System.Windows.Forms.Panel playGround;
        private System.Windows.Forms.Panel target;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel player2;
        private System.Windows.Forms.Button hochbtn2;
        private System.Windows.Forms.Button runterbtn2;
        private System.Windows.Forms.Button linksbtn2;
        private System.Windows.Forms.Button rechtsbtn2;
        protected System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel item1;
        private System.Windows.Forms.Panel item3;
        private System.Windows.Forms.Panel item2;
    }
}

