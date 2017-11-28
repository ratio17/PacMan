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
            this.panel37 = new System.Windows.Forms.Panel();
            this.panel39 = new System.Windows.Forms.Panel();
            this.panel38 = new System.Windows.Forms.Panel();
            this.panel36 = new System.Windows.Forms.Panel();
            this.panel35 = new System.Windows.Forms.Panel();
            this.panel34 = new System.Windows.Forms.Panel();
            this.panel33 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.player2 = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.item1 = new System.Windows.Forms.Panel();
            this.item3 = new System.Windows.Forms.Panel();
            this.item2 = new System.Windows.Forms.Panel();
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
            this.playGround.Controls.Add(this.panel37);
            this.playGround.Controls.Add(this.panel39);
            this.playGround.Controls.Add(this.panel38);
            this.playGround.Controls.Add(this.panel36);
            this.playGround.Controls.Add(this.panel35);
            this.playGround.Controls.Add(this.panel34);
            this.playGround.Controls.Add(this.panel33);
            this.playGround.Controls.Add(this.panel32);
            this.playGround.Controls.Add(this.panel31);
            this.playGround.Controls.Add(this.panel30);
            this.playGround.Controls.Add(this.player2);
            this.playGround.Controls.Add(this.panel29);
            this.playGround.Controls.Add(this.panel28);
            this.playGround.Controls.Add(this.panel27);
            this.playGround.Controls.Add(this.panel26);
            this.playGround.Controls.Add(this.panel25);
            this.playGround.Controls.Add(this.panel24);
            this.playGround.Controls.Add(this.panel23);
            this.playGround.Controls.Add(this.panel22);
            this.playGround.Controls.Add(this.panel21);
            this.playGround.Controls.Add(this.item1);
            this.playGround.Controls.Add(this.item3);
            this.playGround.Controls.Add(this.item2);
            this.playGround.Controls.Add(this.target);
            this.playGround.Controls.Add(this.player);
            this.playGround.Location = new System.Drawing.Point(12, 12);
            this.playGround.Name = "playGround";
            this.playGround.Size = new System.Drawing.Size(600, 300);
            this.playGround.TabIndex = 4;
            this.playGround.Paint += new System.Windows.Forms.PaintEventHandler(this.playGround_Paint);
            // 
            // panel37
            // 
            this.panel37.BackColor = System.Drawing.Color.Transparent;
            this.panel37.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel37.BackgroundImage")));
            this.panel37.Location = new System.Drawing.Point(570, 60);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(30, 30);
            this.panel37.TabIndex = 41;
            // 
            // panel39
            // 
            this.panel39.BackColor = System.Drawing.Color.Lime;
            this.panel39.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel39.BackgroundImage")));
            this.panel39.Location = new System.Drawing.Point(540, 30);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(30, 30);
            this.panel39.TabIndex = 43;
            // 
            // panel38
            // 
            this.panel38.BackColor = System.Drawing.Color.Transparent;
            this.panel38.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel38.BackgroundImage")));
            this.panel38.Location = new System.Drawing.Point(570, 30);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(30, 30);
            this.panel38.TabIndex = 42;
            // 
            // panel36
            // 
            this.panel36.BackColor = System.Drawing.Color.Transparent;
            this.panel36.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel36.BackgroundImage")));
            this.panel36.Location = new System.Drawing.Point(570, 90);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(30, 30);
            this.panel36.TabIndex = 40;
            // 
            // panel35
            // 
            this.panel35.BackColor = System.Drawing.Color.Transparent;
            this.panel35.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel35.BackgroundImage")));
            this.panel35.Location = new System.Drawing.Point(570, 120);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(30, 30);
            this.panel35.TabIndex = 39;
            // 
            // panel34
            // 
            this.panel34.BackColor = System.Drawing.Color.Lime;
            this.panel34.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel34.BackgroundImage")));
            this.panel34.Location = new System.Drawing.Point(330, 60);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(30, 30);
            this.panel34.TabIndex = 38;
            // 
            // panel33
            // 
            this.panel33.BackColor = System.Drawing.Color.Lime;
            this.panel33.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel33.BackgroundImage")));
            this.panel33.Location = new System.Drawing.Point(300, 60);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(30, 30);
            this.panel33.TabIndex = 37;
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.Color.Lime;
            this.panel32.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel32.BackgroundImage")));
            this.panel32.Location = new System.Drawing.Point(390, 270);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(30, 30);
            this.panel32.TabIndex = 36;
            // 
            // panel31
            // 
            this.panel31.BackColor = System.Drawing.Color.Transparent;
            this.panel31.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel31.BackgroundImage")));
            this.panel31.Location = new System.Drawing.Point(360, 270);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(30, 30);
            this.panel31.TabIndex = 35;
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.Color.Transparent;
            this.panel30.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel30.BackgroundImage")));
            this.panel30.Location = new System.Drawing.Point(420, 270);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(30, 30);
            this.panel30.TabIndex = 30;
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
            // panel29
            // 
            this.panel29.BackColor = System.Drawing.Color.Transparent;
            this.panel29.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel29.BackgroundImage")));
            this.panel29.Location = new System.Drawing.Point(510, 270);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(30, 30);
            this.panel29.TabIndex = 34;
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.Transparent;
            this.panel28.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel28.BackgroundImage")));
            this.panel28.Location = new System.Drawing.Point(450, 270);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(30, 30);
            this.panel28.TabIndex = 33;
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.Transparent;
            this.panel27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel27.BackgroundImage")));
            this.panel27.Location = new System.Drawing.Point(480, 240);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(30, 30);
            this.panel27.TabIndex = 32;
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.Transparent;
            this.panel26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel26.BackgroundImage")));
            this.panel26.Location = new System.Drawing.Point(330, 210);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(30, 30);
            this.panel26.TabIndex = 31;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.Lime;
            this.panel25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel25.BackgroundImage")));
            this.panel25.Location = new System.Drawing.Point(480, 270);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(30, 30);
            this.panel25.TabIndex = 30;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.Lime;
            this.panel24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel24.BackgroundImage")));
            this.panel24.Location = new System.Drawing.Point(330, 270);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(30, 30);
            this.panel24.TabIndex = 20;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.Transparent;
            this.panel23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel23.BackgroundImage")));
            this.panel23.Location = new System.Drawing.Point(570, 240);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(30, 30);
            this.panel23.TabIndex = 29;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.Lime;
            this.panel22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel22.BackgroundImage")));
            this.panel22.Location = new System.Drawing.Point(570, 270);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(30, 30);
            this.panel22.TabIndex = 28;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.Lime;
            this.panel21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel21.BackgroundImage")));
            this.panel21.Location = new System.Drawing.Point(330, 240);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(30, 30);
            this.panel21.TabIndex = 27;
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
            this.ClientSize = new System.Drawing.Size(771, 472);
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
        private System.Windows.Forms.Panel player2;
        private System.Windows.Forms.Button hochbtn2;
        private System.Windows.Forms.Button runterbtn2;
        private System.Windows.Forms.Button linksbtn2;
        private System.Windows.Forms.Button rechtsbtn2;
        protected System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel item1;
        private System.Windows.Forms.Panel item3;
        private System.Windows.Forms.Panel item2;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.Panel panel37;
        private System.Windows.Forms.Panel panel36;
        private System.Windows.Forms.Panel panel35;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Panel panel31;
    }
}

