using System.Diagnostics.Tracing;

namespace log_in_acc
{
    public partial class fb : Form
    {
        public fb()
        {
            InitializeComponent();
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLbl_Click(object sender, EventArgs e)
        {


        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = "lorin", pass = "malopit";

            if (emailTxt.Text == email && passwordTxt.Text == pass)
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("There is something wrong with your email or password.");
            }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void forgotAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void signUpLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up_design login = new Sign_Up_design();
            login.ShowDialog();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                passwordTxt.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTxt.UseSystemPasswordChar = true;
            }
        }
    }
}
