namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            scoreButton = new Button();
            scoreLabel = new Label();
            upgradeClickPower = new Button();
            giveCPS1 = new System.Windows.Forms.Timer(components);
            upgradeCPS1Button = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            updateUpgradeButtonsTimer = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            label1 = new Label();
            tabPage1 = new TabPage();
            label2 = new Label();
            tabPage3 = new TabPage();
            label3 = new Label();
            button5 = new Button();
            button4 = new Button();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // scoreButton
            // 
            scoreButton.BackColor = SystemColors.Control;
            scoreButton.BackgroundImageLayout = ImageLayout.Stretch;
            scoreButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreButton.ForeColor = SystemColors.ControlText;
            scoreButton.Location = new Point(12, 160);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(237, 56);
            scoreButton.TabIndex = 0;
            scoreButton.Text = "Cut a Low Taper Fade";
            scoreButton.UseVisualStyleBackColor = true;
            scoreButton.Click += scoreButton_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreLabel.Location = new Point(38, 351);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(77, 31);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "Fades:";
            scoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            scoreLabel.Click += scoreLabel_Click;
            // 
            // upgradeClickPower
            // 
            upgradeClickPower.Location = new Point(6, 120);
            upgradeClickPower.Name = "upgradeClickPower";
            upgradeClickPower.Size = new Size(164, 69);
            upgradeClickPower.TabIndex = 2;
            upgradeClickPower.Text = "Upgrade Click";
            upgradeClickPower.UseVisualStyleBackColor = true;
            upgradeClickPower.Click += upgradeClickPower_Click;
            // 
            // giveCPS1
            // 
            giveCPS1.Interval = 1000;
            giveCPS1.Tick += giveCPS1_Tick;
            // 
            // upgradeCPS1Button
            // 
            upgradeCPS1Button.BackgroundImageLayout = ImageLayout.Stretch;
            upgradeCPS1Button.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            upgradeCPS1Button.ForeColor = SystemColors.InactiveCaptionText;
            upgradeCPS1Button.Location = new Point(6, 120);
            upgradeCPS1Button.Name = "upgradeCPS1Button";
            upgradeCPS1Button.Size = new Size(176, 76);
            upgradeCPS1Button.TabIndex = 3;
            upgradeCPS1Button.Text = "Buy Tralalero Tralala Barber";
            upgradeCPS1Button.UseVisualStyleBackColor = true;
            upgradeCPS1Button.Click += upgradeCPS1Button_Click;
            // 
            // updateUpgradeButtonsTimer
            // 
            updateUpgradeButtonsTimer.Interval = 1000;
            updateUpgradeButtonsTimer.Tick += updateUpgradeButtonsTimer_Tick;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.bg_f8f8f8_flat_750x_075_f_pad_750x1000_f8f8f8;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(56, 65);
            button1.Name = "button1";
            button1.Size = new Size(154, 89);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources._61_1HFujrqL__AC_UF894_1000_QL80_;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(18, 15);
            button2.Name = "button2";
            button2.Size = new Size(143, 101);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(18, 15);
            button3.Name = "button3";
            button3.Size = new Size(143, 102);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(447, 237);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(387, 235);
            tabControl1.TabIndex = 7;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(upgradeClickPower);
            tabPage2.Controls.Add(button3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(379, 202);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Upg Click";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 42);
            label1.Name = "label1";
            label1.Size = new Size(201, 20);
            label1.TabIndex = 7;
            label1.Text = "Upgrade your fade efficiency";
            label1.Click += label1_Click_1;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImageLayout = ImageLayout.Center;
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(upgradeCPS1Button);
            tabPage1.Controls.Add(button2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(379, 202);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "TT Barber";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Location = new Point(182, 36);
            label2.Name = "label2";
            label2.Size = new Size(155, 55);
            label2.TabIndex = 6;
            label2.Text = "Hire a Tralalero Tralala to cut fades for you";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(button4);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(379, 202);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Upg VIP";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Location = new Point(182, 36);
            label3.Name = "label3";
            label3.Size = new Size(155, 64);
            label3.TabIndex = 8;
            label3.Text = "Buy advertising to attract VIPs to your Barber Shop";
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(18, 15);
            button5.Name = "button5";
            button5.Size = new Size(143, 101);
            button5.TabIndex = 6;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.InactiveCaptionText;
            button4.Location = new Point(6, 120);
            button4.Name = "button4";
            button4.Size = new Size(176, 76);
            button4.TabIndex = 4;
            button4.Text = "Buy Advertising";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(846, 484);
            Controls.Add(scoreLabel);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(scoreButton);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button scoreButton;
        private Label scoreLabel;
        private Button upgradeClickPower;
        private System.Windows.Forms.Timer giveCPS1;
        private Button upgradeCPS1Button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer updateUpgradeButtonsTimer;
        private Button button1;
        private Button button2;
        private Button button3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Label label2;
        private TabPage tabPage3;
        private Button button4;
        private Label label3;
        private Button button5;
    }
}
