using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroDemo
{
    public partial class newFormPage : Form
    {
        private string avatarName;
        private string avatarImageBox;
        private Form1 form1;

        public newFormPage(Form1 f1, string name, string pBox)
        {
            InitializeComponent();
            form1 = f1;
            avatarName = name;
            avatarImageBox = pBox;

  
        }

        private void closeNewFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void newFormPage_Load(object sender, EventArgs e)
        {
            avatarNameLabel.Text = avatarName;
            switch (avatarImageBox)
            {
                case "One":
                    newFormAvatarImage.BackgroundImage = Properties.Resources.cloud;
                    break;
                case "Two":
                    newFormAvatarImage.BackgroundImage = Properties.Resources.tifa;
                    break;
                case "Three":
                    newFormAvatarImage.BackgroundImage = Properties.Resources.cid;
                    break;
                default:
                    break;
            }
          
        }
    }
}
