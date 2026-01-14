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
            tabPage4 = new TabPage();
            label5 = new Label();
            markUpgradeButton = new Button();
            imageList1 = new ImageList(components);
            markiplierCamPictureBox = new PictureBox();
            label4 = new Label();
            markNextImageButton = new Button();
            markiplierImageResetTimer = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)markiplierCamPictureBox).BeginInit();
            SuspendLayout();
            // 
            // scoreButton
            // 
            scoreButton.BackColor = SystemColors.Control;
            scoreButton.BackgroundImageLayout = ImageLayout.Stretch;
            scoreButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreButton.ForeColor = SystemColors.ControlText;
            scoreButton.Location = new Point(111, 406);
            scoreButton.Margin = new Padding(4, 3, 4, 3);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(296, 70);
            scoreButton.TabIndex = 0;
            scoreButton.Text = "Cut a Low Taper Fade";
            scoreButton.UseVisualStyleBackColor = true;
            scoreButton.Click += scoreButton_Click;
            // 
            // upgradeClickPower
            // 
            upgradeClickPower.Location = new Point(7, 150);
            upgradeClickPower.Margin = new Padding(4, 3, 4, 3);
            upgradeClickPower.Name = "upgradeClickPower";
            upgradeClickPower.Size = new Size(206, 87);
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
            upgradeCPS1Button.Location = new Point(7, 150);
            upgradeCPS1Button.Margin = new Padding(4, 3, 4, 3);
            upgradeCPS1Button.Name = "upgradeCPS1Button";
            upgradeCPS1Button.Size = new Size(220, 95);
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
            button1.Location = new Point(153, 288);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(193, 112);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources._61_1HFujrqL__AC_UF894_1000_QL80_;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(23, 18);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(179, 127);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(23, 18);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(179, 127);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(559, 297);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(484, 293);
            tabControl1.TabIndex = 7;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(upgradeClickPower);
            tabPage2.Controls.Add(button3);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(476, 255);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Upg Click";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 25);
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
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(476, 255);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "TT Barber";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Location = new Point(227, 45);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 68);
            label2.TabIndex = 6;
            label2.Text = "Hire a Tralalero Tralala to cut fades for you";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(button4);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(4, 3, 4, 3);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4, 3, 4, 3);
            tabPage3.Size = new Size(476, 255);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Upg VIP";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Location = new Point(227, 45);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(194, 80);
            label3.TabIndex = 8;
            label3.Text = "Buy advertising to attract VIPs to your Barber Shop";
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(23, 18);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(179, 127);
            button5.TabIndex = 6;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.InactiveCaptionText;
            button4.Location = new Point(7, 150);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(220, 95);
            button4.TabIndex = 4;
            button4.Text = "Buy Advertising";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(markUpgradeButton);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Margin = new Padding(4, 5, 4, 5);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(4, 5, 4, 5);
            tabPage4.Size = new Size(476, 255);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Markiplier";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Location = new Point(227, 45);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(194, 80);
            label5.TabIndex = 9;
            label5.Text = "Activate Markiplier, the King of FNAF";
            label5.Click += label5_Click;
            // 
            // markUpgradeButton
            // 
            markUpgradeButton.BackgroundImageLayout = ImageLayout.Stretch;
            markUpgradeButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            markUpgradeButton.ForeColor = SystemColors.InactiveCaptionText;
            markUpgradeButton.Location = new Point(7, 150);
            markUpgradeButton.Margin = new Padding(4, 3, 4, 3);
            markUpgradeButton.Name = "markUpgradeButton";
            markUpgradeButton.Size = new Size(220, 95);
            markUpgradeButton.TabIndex = 5;
            markUpgradeButton.Text = "Activate Markiplier";
            markUpgradeButton.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // markiplierCamPictureBox
            // 
            markiplierCamPictureBox.BackgroundImage = (Image)resources.GetObject("markiplierCamPictureBox.BackgroundImage");
            markiplierCamPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            markiplierCamPictureBox.Image = Properties.Resources.markStatic;
            markiplierCamPictureBox.Location = new Point(-5, -10);
            markiplierCamPictureBox.Name = "markiplierCamPictureBox";
            markiplierCamPictureBox.Size = new Size(269, 199);
            markiplierCamPictureBox.TabIndex = 8;
            markiplierCamPictureBox.TabStop = false;
            markiplierCamPictureBox.Click += markiplierCamPictureBox_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(220, 481);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // markNextImageButton
            // 
            markNextImageButton.Location = new Point(336, 51);
            markNextImageButton.Name = "markNextImageButton";
            markNextImageButton.Size = new Size(112, 34);
            markNextImageButton.TabIndex = 10;
            markNextImageButton.Text = "button6";
            markNextImageButton.UseVisualStyleBackColor = true;
            markNextImageButton.Click += markNextImageButton_Click;
            // 
            // markiplierImageResetTimer
            // 
            markiplierImageResetTimer.Tick += markiplierImageResetTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1057, 605);
            Controls.Add(markNextImageButton);
            Controls.Add(label4);
            Controls.Add(markiplierCamPictureBox);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(scoreButton);
            DoubleBuffered = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)markiplierCamPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button scoreButton;
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
        private TabPage tabPage4;
        private ImageList imageList1;
        private PictureBox markiplierCamPictureBox;
        private Label label4;
        private Button markNextImageButton;
        private System.Windows.Forms.Timer markiplierImageResetTimer;
        private Button markUpgradeButton;
        private Label label5;
    }
}
