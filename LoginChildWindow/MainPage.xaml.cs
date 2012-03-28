using System;
using System.Net;
using System.Windows;
using System.Windows.Input;
using Microsoft.Phone.Controls;

namespace LoginChildWindow
{
    public partial class MainPage : PhoneApplicationPage
    {
        public string Username { get; set; }
        public string Password { get; set; }

        // Constructor
        public MainPage()
        {
            Username = "OldUserName";
            InitializeComponent();
            this.txtBlockUsername.Text = Username;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            LoginChildWindow loginWindow = new LoginChildWindow();
            loginWindow.Login = Username;
            loginWindow.Closed += new EventHandler(OnLoginChildWindowShow);
            
            loginWindow.Show();
        }
        private void OnLoginChildWindowShow(object sender, EventArgs e)
        {
            LoginChildWindow loginChildWindow = sender as LoginChildWindow;

            if (loginChildWindow.DialogResult == true)
            {
                this.txtBlockUsername.Text = loginChildWindow.Login;
                this.txtBlockPassword.Text = loginChildWindow.Password;
                //;
            }
        }
    }
}