namespace progFinal
{
    partial class gameWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.quitGameButton = new System.Windows.Forms.Button();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.gameTitleTextbox = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.backgroundPannel = new System.Windows.Forms.Panel();
            this.shopGB = new System.Windows.Forms.GroupBox();
            this.increaseSellMulti = new System.Windows.Forms.Button();
            this.mineMoreOresUpgradeButton = new System.Windows.Forms.Button();
            this.increaseLuckButton = new System.Windows.Forms.Button();
            this.mineOreButton = new System.Windows.Forms.Button();
            this.cashGB = new System.Windows.Forms.GroupBox();
            this.sellAllButton = new System.Windows.Forms.Button();
            this.cashLabel = new System.Windows.Forms.Label();
            this.sellSelectedButton = new System.Windows.Forms.Button();
            this.invGB = new System.Windows.Forms.GroupBox();
            this.invSlot5 = new System.Windows.Forms.Button();
            this.invSlot4 = new System.Windows.Forms.Button();
            this.invSlot3 = new System.Windows.Forms.Button();
            this.invSlot7 = new System.Windows.Forms.Button();
            this.invSlot8 = new System.Windows.Forms.Button();
            this.invSlot6 = new System.Windows.Forms.Button();
            this.invSlot1 = new System.Windows.Forms.Button();
            this.invSlot2 = new System.Windows.Forms.Button();
            this.invSlot0 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.backgroundPannel.SuspendLayout();
            this.shopGB.SuspendLayout();
            this.cashGB.SuspendLayout();
            this.invGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 428);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.quitGameButton);
            this.panel1.Controls.Add(this.createAccountButton);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.gameTitleTextbox);
            this.panel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(-24, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 410);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(85, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Doesn\'t work yet, \r\njust click login >>>\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // quitGameButton
            // 
            this.quitGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitGameButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quitGameButton.Location = new System.Drawing.Point(290, 304);
            this.quitGameButton.Name = "quitGameButton";
            this.quitGameButton.Size = new System.Drawing.Size(268, 49);
            this.quitGameButton.TabIndex = 3;
            this.quitGameButton.Text = "Quit";
            this.quitGameButton.UseVisualStyleBackColor = true;
            this.quitGameButton.Click += new System.EventHandler(this.quitGameButton_Click);
            // 
            // createAccountButton
            // 
            this.createAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createAccountButton.Location = new System.Drawing.Point(290, 226);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(268, 49);
            this.createAccountButton.TabIndex = 2;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginButton.Location = new System.Drawing.Point(290, 151);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(268, 49);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // gameTitleTextbox
            // 
            this.gameTitleTextbox.AutoSize = true;
            this.gameTitleTextbox.Font = new System.Drawing.Font("Noto Mono", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitleTextbox.ForeColor = System.Drawing.Color.White;
            this.gameTitleTextbox.Location = new System.Drawing.Point(243, 41);
            this.gameTitleTextbox.Name = "gameTitleTextbox";
            this.gameTitleTextbox.Size = new System.Drawing.Size(364, 43);
            this.gameTitleTextbox.TabIndex = 0;
            this.gameTitleTextbox.Text = "Cool Game Title";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.backgroundPannel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // backgroundPannel
            // 
            this.backgroundPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.backgroundPannel.Controls.Add(this.shopGB);
            this.backgroundPannel.Controls.Add(this.mineOreButton);
            this.backgroundPannel.Controls.Add(this.cashGB);
            this.backgroundPannel.Controls.Add(this.invGB);
            this.backgroundPannel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.backgroundPannel.Location = new System.Drawing.Point(-14, -18);
            this.backgroundPannel.Name = "backgroundPannel";
            this.backgroundPannel.Size = new System.Drawing.Size(815, 460);
            this.backgroundPannel.TabIndex = 1;
            // 
            // shopGB
            // 
            this.shopGB.BackColor = System.Drawing.Color.Silver;
            this.shopGB.Controls.Add(this.increaseSellMulti);
            this.shopGB.Controls.Add(this.mineMoreOresUpgradeButton);
            this.shopGB.Controls.Add(this.increaseLuckButton);
            this.shopGB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.shopGB.Location = new System.Drawing.Point(590, 51);
            this.shopGB.Name = "shopGB";
            this.shopGB.Size = new System.Drawing.Size(177, 245);
            this.shopGB.TabIndex = 11;
            this.shopGB.TabStop = false;
            this.shopGB.Text = "Shop";
            // 
            // increaseSellMulti
            // 
            this.increaseSellMulti.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.increaseSellMulti.ForeColor = System.Drawing.Color.Black;
            this.increaseSellMulti.Location = new System.Drawing.Point(8, 99);
            this.increaseSellMulti.Name = "increaseSellMulti";
            this.increaseSellMulti.Size = new System.Drawing.Size(160, 65);
            this.increaseSellMulti.TabIndex = 10;
            this.increaseSellMulti.Text = "Increase Sell Values - $";
            this.increaseSellMulti.UseVisualStyleBackColor = true;
            this.increaseSellMulti.Click += new System.EventHandler(this.increaseSellMulti_Click);
            // 
            // mineMoreOresUpgradeButton
            // 
            this.mineMoreOresUpgradeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.mineMoreOresUpgradeButton.ForeColor = System.Drawing.Color.Black;
            this.mineMoreOresUpgradeButton.Location = new System.Drawing.Point(8, 170);
            this.mineMoreOresUpgradeButton.Name = "mineMoreOresUpgradeButton";
            this.mineMoreOresUpgradeButton.Size = new System.Drawing.Size(160, 65);
            this.mineMoreOresUpgradeButton.TabIndex = 8;
            this.mineMoreOresUpgradeButton.Text = "Mine More Ores - $";
            this.mineMoreOresUpgradeButton.UseVisualStyleBackColor = true;
            this.mineMoreOresUpgradeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // increaseLuckButton
            // 
            this.increaseLuckButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increaseLuckButton.ForeColor = System.Drawing.Color.Black;
            this.increaseLuckButton.Location = new System.Drawing.Point(8, 28);
            this.increaseLuckButton.Name = "increaseLuckButton";
            this.increaseLuckButton.Size = new System.Drawing.Size(160, 65);
            this.increaseLuckButton.TabIndex = 7;
            this.increaseLuckButton.Text = "Get Rarer Ores - $";
            this.increaseLuckButton.UseVisualStyleBackColor = true;
            this.increaseLuckButton.Click += new System.EventHandler(this.increaseLuckButton_Click);
            // 
            // mineOreButton
            // 
            this.mineOreButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mineOreButton.ForeColor = System.Drawing.Color.Black;
            this.mineOreButton.Location = new System.Drawing.Point(398, 322);
            this.mineOreButton.Name = "mineOreButton";
            this.mineOreButton.Size = new System.Drawing.Size(369, 75);
            this.mineOreButton.TabIndex = 11;
            this.mineOreButton.Text = "Mine A Random Ore";
            this.mineOreButton.UseVisualStyleBackColor = true;
            this.mineOreButton.Click += new System.EventHandler(this.mineOreButton_Click);
            // 
            // cashGB
            // 
            this.cashGB.BackColor = System.Drawing.Color.Silver;
            this.cashGB.Controls.Add(this.sellAllButton);
            this.cashGB.Controls.Add(this.cashLabel);
            this.cashGB.Controls.Add(this.sellSelectedButton);
            this.cashGB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.cashGB.Location = new System.Drawing.Point(390, 51);
            this.cashGB.Name = "cashGB";
            this.cashGB.Size = new System.Drawing.Size(177, 224);
            this.cashGB.TabIndex = 10;
            this.cashGB.TabStop = false;
            this.cashGB.Text = "Cash";
            // 
            // sellAllButton
            // 
            this.sellAllButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.sellAllButton.ForeColor = System.Drawing.Color.Black;
            this.sellAllButton.Location = new System.Drawing.Point(8, 152);
            this.sellAllButton.Name = "sellAllButton";
            this.sellAllButton.Size = new System.Drawing.Size(160, 60);
            this.sellAllButton.TabIndex = 6;
            this.sellAllButton.Text = "Sell All Ores (Locked)";
            this.sellAllButton.UseVisualStyleBackColor = true;
            this.sellAllButton.Click += new System.EventHandler(this.sellAllButton_Click);
            // 
            // cashLabel
            // 
            this.cashLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cashLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cashLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.cashLabel.ForeColor = System.Drawing.Color.Black;
            this.cashLabel.Location = new System.Drawing.Point(8, 28);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(160, 41);
            this.cashLabel.TabIndex = 5;
            this.cashLabel.Text = "$0";
            this.cashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cashLabel.Click += new System.EventHandler(this.cashLabel_Click);
            // 
            // sellSelectedButton
            // 
            this.sellSelectedButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.sellSelectedButton.ForeColor = System.Drawing.Color.Black;
            this.sellSelectedButton.Location = new System.Drawing.Point(8, 81);
            this.sellSelectedButton.Name = "sellSelectedButton";
            this.sellSelectedButton.Size = new System.Drawing.Size(160, 65);
            this.sellSelectedButton.TabIndex = 4;
            this.sellSelectedButton.Text = "Sell Selected Ore";
            this.sellSelectedButton.UseVisualStyleBackColor = true;
            this.sellSelectedButton.Click += new System.EventHandler(this.sellSelectedButton_Click);
            // 
            // invGB
            // 
            this.invGB.BackColor = System.Drawing.Color.Silver;
            this.invGB.Controls.Add(this.invSlot5);
            this.invGB.Controls.Add(this.invSlot4);
            this.invGB.Controls.Add(this.invSlot3);
            this.invGB.Controls.Add(this.invSlot7);
            this.invGB.Controls.Add(this.invSlot8);
            this.invGB.Controls.Add(this.invSlot6);
            this.invGB.Controls.Add(this.invSlot1);
            this.invGB.Controls.Add(this.invSlot2);
            this.invGB.Controls.Add(this.invSlot0);
            this.invGB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.invGB.Location = new System.Drawing.Point(48, 51);
            this.invGB.Name = "invGB";
            this.invGB.Size = new System.Drawing.Size(324, 346);
            this.invGB.TabIndex = 0;
            this.invGB.TabStop = false;
            this.invGB.Text = "Inventory";
            this.invGB.Enter += new System.EventHandler(this.invGB_Enter);
            // 
            // invSlot5
            // 
            this.invSlot5.ForeColor = System.Drawing.Color.Black;
            this.invSlot5.Location = new System.Drawing.Point(218, 134);
            this.invSlot5.Name = "invSlot5";
            this.invSlot5.Size = new System.Drawing.Size(100, 100);
            this.invSlot5.TabIndex = 9;
            this.invSlot5.UseVisualStyleBackColor = true;
            this.invSlot5.Click += new System.EventHandler(this.invSlot5_Click);
            // 
            // invSlot4
            // 
            this.invSlot4.ForeColor = System.Drawing.Color.Black;
            this.invSlot4.Location = new System.Drawing.Point(112, 134);
            this.invSlot4.Name = "invSlot4";
            this.invSlot4.Size = new System.Drawing.Size(100, 100);
            this.invSlot4.TabIndex = 8;
            this.invSlot4.UseVisualStyleBackColor = true;
            this.invSlot4.Click += new System.EventHandler(this.invSlot4_Click);
            // 
            // invSlot3
            // 
            this.invSlot3.ForeColor = System.Drawing.Color.Black;
            this.invSlot3.Location = new System.Drawing.Point(6, 134);
            this.invSlot3.Name = "invSlot3";
            this.invSlot3.Size = new System.Drawing.Size(100, 100);
            this.invSlot3.TabIndex = 7;
            this.invSlot3.UseVisualStyleBackColor = true;
            this.invSlot3.Click += new System.EventHandler(this.invSlot3_Click);
            // 
            // invSlot7
            // 
            this.invSlot7.ForeColor = System.Drawing.Color.Black;
            this.invSlot7.Location = new System.Drawing.Point(112, 240);
            this.invSlot7.Name = "invSlot7";
            this.invSlot7.Size = new System.Drawing.Size(100, 100);
            this.invSlot7.TabIndex = 6;
            this.invSlot7.UseVisualStyleBackColor = true;
            this.invSlot7.Click += new System.EventHandler(this.invSlot7_Click);
            // 
            // invSlot8
            // 
            this.invSlot8.ForeColor = System.Drawing.Color.Black;
            this.invSlot8.Location = new System.Drawing.Point(218, 240);
            this.invSlot8.Name = "invSlot8";
            this.invSlot8.Size = new System.Drawing.Size(100, 100);
            this.invSlot8.TabIndex = 5;
            this.invSlot8.UseVisualStyleBackColor = true;
            this.invSlot8.Click += new System.EventHandler(this.button4_Click);
            // 
            // invSlot6
            // 
            this.invSlot6.ForeColor = System.Drawing.Color.Black;
            this.invSlot6.Location = new System.Drawing.Point(6, 240);
            this.invSlot6.Name = "invSlot6";
            this.invSlot6.Size = new System.Drawing.Size(100, 100);
            this.invSlot6.TabIndex = 4;
            this.invSlot6.UseVisualStyleBackColor = true;
            this.invSlot6.Click += new System.EventHandler(this.invSlot6_Click);
            // 
            // invSlot1
            // 
            this.invSlot1.ForeColor = System.Drawing.Color.Black;
            this.invSlot1.Location = new System.Drawing.Point(112, 28);
            this.invSlot1.Name = "invSlot1";
            this.invSlot1.Size = new System.Drawing.Size(100, 100);
            this.invSlot1.TabIndex = 3;
            this.invSlot1.UseVisualStyleBackColor = true;
            this.invSlot1.Click += new System.EventHandler(this.invSlot1_Click);
            // 
            // invSlot2
            // 
            this.invSlot2.ForeColor = System.Drawing.Color.Black;
            this.invSlot2.Location = new System.Drawing.Point(218, 28);
            this.invSlot2.Name = "invSlot2";
            this.invSlot2.Size = new System.Drawing.Size(100, 100);
            this.invSlot2.TabIndex = 2;
            this.invSlot2.UseVisualStyleBackColor = true;
            this.invSlot2.Click += new System.EventHandler(this.invSlot2_Click);
            // 
            // invSlot0
            // 
            this.invSlot0.ForeColor = System.Drawing.Color.Black;
            this.invSlot0.Location = new System.Drawing.Point(6, 28);
            this.invSlot0.Name = "invSlot0";
            this.invSlot0.Size = new System.Drawing.Size(100, 100);
            this.invSlot0.TabIndex = 1;
            this.invSlot0.UseVisualStyleBackColor = true;
            this.invSlot0.Click += new System.EventHandler(this.invSlot0_Click);
            // 
            // gameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.tabControl1);
            this.Name = "gameWindow";
            this.Text = "Game Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.backgroundPannel.ResumeLayout(false);
            this.shopGB.ResumeLayout(false);
            this.cashGB.ResumeLayout(false);
            this.invGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label gameTitleTextbox;
        private System.Windows.Forms.Button quitGameButton;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel backgroundPannel;
        private System.Windows.Forms.GroupBox invGB;
        private System.Windows.Forms.Button invSlot0;
        private System.Windows.Forms.Button invSlot3;
        private System.Windows.Forms.Button invSlot7;
        private System.Windows.Forms.Button invSlot8;
        private System.Windows.Forms.Button invSlot6;
        private System.Windows.Forms.Button invSlot1;
        private System.Windows.Forms.Button invSlot2;
        private System.Windows.Forms.Button invSlot4;
        private System.Windows.Forms.Button invSlot5;
        private System.Windows.Forms.GroupBox cashGB;
        private System.Windows.Forms.Button sellSelectedButton;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.Button sellAllButton;
        private System.Windows.Forms.Button mineOreButton;
        private System.Windows.Forms.GroupBox shopGB;
        private System.Windows.Forms.Button increaseLuckButton;
        private System.Windows.Forms.Button mineMoreOresUpgradeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button increaseSellMulti;
    }
}

