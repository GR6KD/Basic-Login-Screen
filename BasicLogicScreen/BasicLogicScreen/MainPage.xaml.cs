namespace BasicLoginScreen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            if (userName == "Ackerman" && password == "Password1")
            {
                lblMessage.Text = "Login successful - " + userName;
            }
            else
            {
                lblMessage.Text = "Login failed - " + userName;
            }
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }
    }
}
