using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cacti
{
    public partial class WelcomePage : Form
    {


        public WelcomePage()
        {
            InitializeComponent();
        }



        private void signInBtn_Click(object sender, EventArgs e)
        {
            SignIn SI = new SignIn();
            //this.Hide();
            // SI.ShowDialog();
            SI.Show();
            this.Hide();
        }


        #region close bnt
        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }
        #endregion close btn


        #region sign in btn
        private void signInBtn_Click_1(object sender, EventArgs e)
        {
            SignIn SI = new SignIn();
            this.Hide();
            SI.ShowDialog();
        }
        #endregion sign in btn


        #region sign up btn
        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SignUp SU = new SignUp();
            this.Hide();
            SU.ShowDialog();
        }
        #endregion sign up btn



    }
}
