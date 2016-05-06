using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

namespace IntroDemo
{
    public partial class Form1 : Form , IMessageFilter
    {

#region Constructor and sound player
        private SoundPlayer player;

        public Form1()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);

            controlsToMove.Add(this);
            controlsToMove.Add(this.formPanel);

            menuPanel.Size = menuPanel.MinimumSize;
            tabControl1.SelectedTab = dashBoardTab;
            //menuPanel.Visible = false;

        }
#endregion

#region Mouse Move and Drag

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private HashSet<Control> controlsToMove = new HashSet<Control>();

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN &&
                 controlsToMove.Contains(Control.FromHandle(m.HWnd)))
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                return true;
            }
            return false;
        }

        #endregion
#region Menu
        #region MenuSlideControl
        private bool MenuOpened;
        private void hMenuButton_Click(object sender, EventArgs e)
        {
            if (MenuOpened)
            {
                menuCloseTimer.Enabled = true;
            }
            else
            {
                menuTimer.Enabled = true;
            }
        }

        private void menuTimer_Tick(object sender, EventArgs e)
        {
            if (menuPanel.Width >= menuPanel.MaximumSize.Width)
            {
                menuTimer.Enabled = false;
            }
            else
            {
                menuPanel.Width += 12;
                MenuOpened = true;
            }
        }
        private void menuCloseTimer_Tick(object sender, EventArgs e)
        {
            if (menuPanel.Width <= menuPanel.MinimumSize.Width)
            {
                menuCloseTimer.Enabled = false;
            }
            else
            {
                menuPanel.Width -= 12;
                MenuOpened = false;
            }
        }
        #endregion
        #region MenuButtons

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = dashBoardTab;
            hMenuButton_Click(sender, e);
        }
        private void PianoButton_Click(object sender, EventArgs e)
        {
            //pianoPanel.Visible = true;
            tabControl1.SelectedTab = pianoTab;
           
            hMenuButton_Click(sender, e);
        }
        #endregion
        #endregion
#region Exit
        private void closeBox_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion
#region PianoPanel
        private void CPianoKey_Click(object sender, EventArgs e)
        {
            
            player = new SoundPlayer(Properties.Resources.C);
            player.Play();
        }

        private void CSharpPianoKey_Click(object sender, EventArgs e)
        {
           
            player = new SoundPlayer(Properties.Resources.CSharp);
            player.Play();
        }

        private void DPianoKey_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.D);
            player.Play();
        }

        private void DSharpPianoKey_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.DSharp);
            player.Play();
        }

        private void EPianoKey_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.E);
            player.Play();
        }

        private void FPianoKey_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.F);
            player.Play();
        }

        private void FSharpPianoKey_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.FSharp);
            player.Play();
        }

        private void GPianoKey_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.G);
            player.Play();
        }

        private void GSharpPianoKey_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.GSharp);
            player.Play();
        }

        private void APianoKey_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.A);
            player.Play();
        }

        private void BbPianoKey_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.Bb);
            player.Play();
        }

        private void BPianoKey_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.B);
            player.Play();
        }

        private void C1PianoKey_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.C1);
            player.Play();
        }

        private void CSharp1PianoKey_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.CSharp1);
            player.Play();
        }

        private void D1PianoKey_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.D1);
            player.Play();
        }

        private void DSharp1PianoKey_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.DSharp1);
            player.Play();
        }

        private void E1PianoKey_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.E1);
            player.Play();
        }

        private void F1PianoKey_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.F1);
            player.Play();
        }

        #endregion
#region newForm
        private string avatarName;
        private string avatarImage;
        private void newFormMenuButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = newFormTab;
            hMenuButton_Click(sender, e);
        }

        private void openFormButton_Click(object sender, EventArgs e)
        {
            avatarName = nameBox.Text;
            newFormPage nfPage = new newFormPage(this,avatarName,avatarImage);
             this.Hide();
            nfPage.Show();
        }

        private void avatarImageOne_Click(object sender, EventArgs e)
        {
            avatarImageOne.BorderStyle = BorderStyle.Fixed3D;
            avatarImageTwo.BorderStyle = BorderStyle.None;
            avatarImageThree.BorderStyle = BorderStyle.None;
            avatarImage = "One";
        }

        private void avatarImageTwo_Click(object sender, EventArgs e)
        {
            avatarImageOne.BorderStyle = BorderStyle.None;
            avatarImageTwo.BorderStyle = BorderStyle.Fixed3D;
            avatarImageThree.BorderStyle = BorderStyle.None;
            avatarImage = "Two";
        }

        private void avatarImageThree_Click(object sender, EventArgs e)
        {
            avatarImageOne.BorderStyle = BorderStyle.None;
            avatarImageTwo.BorderStyle = BorderStyle.None;
            avatarImageThree.BorderStyle = BorderStyle.Fixed3D;
            avatarImage = "Three";
        }
        #endregion
#region HealthBar
        private int _coins;
        private int _potions;

        private void healthBarMenuButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = healthBarTab;
            if (MenuOpened)
                hMenuButton_Click(sender, e);

            _coins = 0;
            _potions = 2;

            coinLabel.Text = _coins.ToString();
            potionLabel.Text = _potions.ToString();

            healthBar.Value = 100;
        }

        private void takeDamageButton_Click(object sender, EventArgs e)
        {
            if (healthBar.Value >= 10)
                healthBar.Value = healthBar.Value - 10;
            else
                healthBar.Value = 0;
        }

        private void HealButton_Click(object sender, EventArgs e)
        {
            if (_potions > 0)
            {
                _potions--;
                potionLabel.Text = _potions.ToString();

                if (healthBar.Value > 80)
                {
                    healthBar.Value = 100;
                }
                else
                {
                    healthBar.Value = healthBar.Value + 20;
                }
            }
        }

        private void addCoinButton_Click(object sender, EventArgs e)
        {
            _coins++;
            coinLabel.Text = _coins.ToString();
        }

        private void buyPotionButton_Click(object sender, EventArgs e)
        {
            if (_coins >= 5)
            {
                _coins = _coins - 5;
                coinLabel.Text = _coins.ToString();

                _potions++;
                potionLabel.Text = _potions.ToString();
            }
        }
        #endregion
#region Audio
        private void audioMenuButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = audioTab;
            hMenuButton_Click(sender, e);

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //player = new SoundPlayer(Properties.Resources.);
            //player.Play();
        }
        #endregion
#region Hide and Show Panels
        private void hideShowMenuButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = hideShowTab;
            hMenuButton_Click(sender, e);
        }

        private void hideShowButton_Click(object sender, EventArgs e)
        {
            if (greenPanel.Visible)
            {
                greenPanel.Visible = false;
                redPanel.Visible = true;
                hideShowButton.Text = "Show Green Panel";
            }
            else if (redPanel.Visible)
            {
                greenPanel.Visible = true;
                redPanel.Visible = false;
                hideShowButton.Text = "Show Red Panel";
            }
        }
        #endregion
#region Calculator
        private void mathMenuButton_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator(this);
            if (MenuOpened)
                hMenuButton_Click(sender, e);

            this.Hide();
            calc.Show();
        }
        #endregion
#region Dice
        private int counter;
        private Random rnd;
        private int randomNumber;
        private int randomNumber2;
        private int increasedInterval;
        private void diceTimer_Tick(object sender, EventArgs e)
        {   
            if (counter < 100)
            {
                randomDice();
                diceTimer.Enabled = false;
                diceTimer.Interval = increasedInterval++;
                diceTimer.Enabled = true;
                counter++;
            }
            diceValueOne.Text = randomNumber.ToString();
            diceValueTwo.Text = randomNumber2.ToString();

            int total = randomNumber + randomNumber2;

            diceTotalValue.Text = total.ToString();
        }

        private void randomDice()
        {
            rnd = new Random();
            randomNumber = rnd.Next(1, 6);
            randomNumber2 = rnd.Next(1, 6);


            switch (randomNumber)
            {
                case 1:
                    diceBox1.BackgroundImage = Properties.Resources.dice1;
                    break;
                case 2:
                    diceBox1.BackgroundImage = Properties.Resources.dice2;
                    break;
                case 3:
                    diceBox1.BackgroundImage = Properties.Resources.dice3;
                    break;
                case 4:
                    diceBox1.BackgroundImage = Properties.Resources.dice4;
                    break;
                case 5:
                    diceBox1.BackgroundImage = Properties.Resources.dice5;
                    break;
                case 6:
                    diceBox1.BackgroundImage = Properties.Resources.dice6;
                    break;
            }
            switch (randomNumber2)
            {
                case 1:
                    diceBox2.BackgroundImage = Properties.Resources.dice1;
                    break;
                case 2:
                    diceBox2.BackgroundImage = Properties.Resources.dice2;
                    break;
                case 3:
                    diceBox2.BackgroundImage = Properties.Resources.dice3;
                    break;
                case 4:
                    diceBox2.BackgroundImage = Properties.Resources.dice4;
                    break;
                case 5:
                    diceBox2.BackgroundImage = Properties.Resources.dice5;
                    break;
                case 6:
                    diceBox2.BackgroundImage = Properties.Resources.dice6;
                    break;
            }
        }
        private void diceRollButton_Click(object sender, EventArgs e)
        {
            diceTimer.Enabled = true;
            increasedInterval = 20;
            counter = 0;
        }

        private void diceButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = diceTab;
            hMenuButton_Click(sender, e);
        }
        #endregion
#region Dashboard Click Events
        private void hideShowDashPanel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = hideShowTab;
            if (MenuOpened)
                hMenuButton_Click(sender, e);
        }

        private void newFormDashPanel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = newFormTab;
            if (MenuOpened)
                hMenuButton_Click(sender, e);
        }

        private void audioDashPanel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = audioTab;
            if (MenuOpened)
                hMenuButton_Click(sender, e);
        }

        private void healthbarDashPanel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = healthBarTab;
            if (MenuOpened)
                hMenuButton_Click(sender, e);
        }

        private void diceDashPanel_Click(object sender, EventArgs e)
        {
           tabControl1.SelectedTab = diceTab;
            if (MenuOpened)
                hMenuButton_Click(sender, e);
        }

        private void pianoDashPanel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = pianoTab;
            if (MenuOpened)
                hMenuButton_Click(sender, e);
        }
        #endregion
    }
}
