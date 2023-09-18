using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Spotify_Premium_Lite
{
    public partial class AuthorizationWindow : Window
    {
        SpotifyLiteDbContext db = new();
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void SingInButton(object sender, RoutedEventArgs e)
        {
            if(loginTbx.Text == "")
            {
                MessageBox.Show("Field login must be not empty!");

                loginTbx.Text = "";
                passwordTbx.Text = "";

                return;
            }

            foreach (var user in db.Users)
            {    
                if(user.Login == loginTbx.Text)
                {
                    MessageBox.Show("Login is already used");

                    loginTbx.Text = "";
                    passwordTbx.Text = "";

                    return;
                }
            }

            if(passwordTbx.Text == "")
            {
                MessageBox.Show("Field password must be not empty!");

                loginTbx.Text = "";
                passwordTbx.Text = "";

                return;
            }

            db.Users.Add(new User { Login = loginTbx.Text, Password = passwordTbx.Text });
            db.SaveChanges();
            MessageBox.Show("Succesfully created account!");

            loginTbx.Text = "";
            passwordTbx.Text = "";
        }

        private void LogInButton(object sender, RoutedEventArgs e)
        {
            bool isFinded = false;

            foreach (var user in db.Users)
            {
                if(user.Login == loginTbx.Text)
                {
                    if(user.Password == passwordTbx.Text)
                    {
                        isFinded = true;
                        Hide();

                        MainWindow mw = new(db, user);
                        mw.ShowDialog();

                        loginTbx.Text = "";
                        passwordTbx.Text = "";

                        Show();
                    }
                }
            }

            if(isFinded == false) MessageBox.Show("Login or password is incorrect!");
        }
    }
}