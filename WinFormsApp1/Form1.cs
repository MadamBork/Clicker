using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int score = 0;
        int clickUpgrade = 1;
        int clickUpgradeCost = 10;
        int cpsUpgrade1 = 0;
        int cpsUpgrade1Cost = 3;
        int vipUpgrade = 0;
        int vipUpgradeCost = 50;
        double vipCritChance = 0;
        double CPS1FPS = 0;
        string scoreText = "Fades Cut: ";
        Random random = new Random();
        int currentMarkGif = 1;




        public Form1()
        {
            InitializeComponent();
            label4.Text = scoreText;
            giveCPS1.Start();
            updateUpgradeButtonsTimer.Start();
            tabPage2.Text = "Upg Click";
            tabPage1.Text = "Locked!";  //idk why but tabPage2 is the leftmost tab and tabPage1 is the second, so uh, that's fun ig
            tabPage3.Text = "Locked!";
            tabPage4.Text = "Locked!";
            markiplierCamPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;



        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            int tempNumber = random.Next(1, 100);
            if (tempNumber < vipCritChance)
            {
                score = score + (clickUpgrade * 2);
                label4.Text = scoreText + score.ToString();
            }
            else
            {
                score = score + clickUpgrade;
                label4.Text = scoreText + score.ToString();
            }


            label4.Text = scoreText + score.ToString();
            upgradeClickPower.Text = "Multiplier: " + clickUpgrade + ", Cost to upgrade: " + clickUpgradeCost;
            upgradeCPS1Button.Text = "Barbers: " + cpsUpgrade1 + ", Cost to upgrade: " + cpsUpgrade1Cost;
            button4.Text = "Advertising effect chance: " + vipUpgrade + "%, Cost to upgrade: " + vipUpgradeCost;



        }

        private void scoreLabel_Click(object sender, EventArgs e)
        {

        }

        public void newMarkImage()
        {
            double markGifLength = 1;
            currentMarkGif++;
            if (currentMarkGif > 5)
            {
                currentMarkGif = 1;
            }

            switch (currentMarkGif)
            {
                case 1:
                    markGifLength = 13.5; //sets to length of gif in seconds
                    markiplierCamPictureBox.Image = Properties.Resources.markGif1;
                    break;
                case 2:
                    markGifLength = 2.24;
                    markiplierCamPictureBox.Image = Properties.Resources.markGif2;
                    break;
                case 3:
                    markGifLength = 4.6;
                    markiplierCamPictureBox.Image = Properties.Resources.markGif3;
                    break;
                case 4:
                    markGifLength = 7.2;
                    markiplierCamPictureBox.Image = Properties.Resources.markGif4;
                    break;
                case 5:
                    markGifLength = 4.34;
                    markiplierCamPictureBox.Image = Properties.Resources.markGif5;
                    break;
                default:
                    markGifLength = 13.5;
                    markiplierCamPictureBox.Image = Properties.Resources.markGif1;
                    break;
            }

            markiplierCamPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            markiplierImageResetTimer.Interval = (int)(markGifLength * 1000); //converts to milliseconds

            markiplierImageResetTimer.Stop();
            markiplierImageResetTimer.Start();
        }
        private void upgradeClickPower_Click(object sender, EventArgs e)
        {
            if (score > (clickUpgradeCost - 1))
            {
                newMarkImage();
                clickUpgrade = clickUpgrade + 1;
                score = score - clickUpgradeCost;

                clickUpgradeCost = ((10 * clickUpgrade) + ((int)((2 * clickUpgrade) / 3) + 1));
                upgradeClickPower.Text = "Multiplier: " + clickUpgrade + ", Cost to upgrade: " + clickUpgradeCost;
                label4.Text = scoreText + score.ToString();

                if (clickUpgrade > 9)
                {
                    tabPage1.Text = "TT Barber";
                }

            }
            else
            {
                upgradeClickPower.Text = "too broke :3";

            }
        }

        private void upgradeCPS1Button_Click(object sender, EventArgs e)
        {
            if (score > (cpsUpgrade1Cost - 1))
            {
                newMarkImage();
                score = score - cpsUpgrade1Cost;
                cpsUpgrade1 = cpsUpgrade1 + 1;
                cpsUpgrade1Cost = (((cpsUpgrade1 * 5) + (int)(cpsUpgrade1 / 2)) + 1);

                label4.Text = "Low Taper Fades: " + score.ToString();
                upgradeCPS1Button.Text = "Barbers: " + cpsUpgrade1 + ", Cost to upgrade: " + cpsUpgrade1Cost;
                if (cpsUpgrade1 > 19)
                {
                    tabPage3.Text = "Upg Advrt";
                }

            }
            else
            {
                upgradeCPS1Button.Text = "too broke :3";
            }
        }


        private void giveCPS1_Tick(object sender, EventArgs e)
        {
            if (cpsUpgrade1 > 0)
            {
                int tempNumber = random.Next(1, 100);
                if (tempNumber < vipCritChance)
                {
                    score = score + (cpsUpgrade1 * 2);
                    label4.Text = scoreText + score.ToString();
                }
                else
                {
                    score = score + cpsUpgrade1;
                    label4.Text = scoreText + score.ToString();
                }

            }

        }
        private void updateUpgradeButtonsTimer_Tick(object sender, EventArgs e)
        {
            upgradeClickPower.Text = "Multiplier: " + clickUpgrade + ", Cost to upgrade: " + clickUpgradeCost;
            upgradeCPS1Button.Text = "Barbers: " + cpsUpgrade1 + ", Cost to upgrade: " + cpsUpgrade1Cost;
            button4.Text = "Advertising effect chance: " + vipUpgrade + "%, Cost to upgrade: " + vipUpgradeCost;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //VIP advertising upgrade
            if ((vipCritChance + 5) > 84)
            {
                button4.Text = "Upgrade Maxed!";
            }
            else
            {
                if (score > (vipUpgradeCost - 1))
                {
                    newMarkImage();
                    score = score - vipUpgradeCost;
                    vipUpgrade = vipUpgrade + 5;
                    vipCritChance = vipUpgrade;
                    vipUpgradeCost = (((vipUpgrade * 5) + (int)(vipUpgrade / 2)) + 1);

                    label4.Text = "Low Taper Fades: " + score.ToString();
                    button4.Text = "Advertising effect chance: " + vipUpgrade + "%, Cost to upgrade: " + vipUpgradeCost;


                }
                else
                {
                    button4.Text = "too broke :3";
                }
            }

        }

        private void markiplierCamPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void markNextImageButton_Click(object sender, EventArgs e)
        {
            newMarkImage();
        }

        private void markiplierImageResetTimer_Tick(object sender, EventArgs e)
        {
            //default runs 1000 times a second :fire::fire::100:
            markiplierCamPictureBox.Image = Properties.Resources.markStatic;
            markiplierImageResetTimer.Stop();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
