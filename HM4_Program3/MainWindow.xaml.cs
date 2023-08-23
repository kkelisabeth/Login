/*
* Creator:      Kozlova Elizabeth Paula
*
* Title:        Login Page
*
* Description:
*               This program asks you for the login and a password.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HM4_Program3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Function that:
        //             1) Initializes 3 users 
        //             2) Checks the Input 
        private bool UserInputCheck()
        {
            //Initialization of three users 
            List<User> users = new List<User>();

            users.Add(new User("RightHere", "Miko"));
            users.Add(new User("1234", "Michael"));
            users.Add(new User("1111_llll", "Ei"));

            //Reads user input and stores it into two strings 
            string userInputPassword = userPassword.Password.ToString();
            string userInputUsername = usernameTextBox.Text;
            bool mainCheck = false;

            //Checks user input
            foreach (User user in users)
            {
                if (userInputPassword == user.Password && userInputUsername == user.Username)
                {
                    mainCheck = true;
                    break;
                }
            }

            usernameTextBox.Text = "";
            userPassword.Password = ""; 

            return mainCheck;
        }
        //Even handler for clicking on login button 
        private void LoginButton_IsClicked(object sender, RoutedEventArgs e)
        {
            //if user's input was correct -> success
            if (UserInputCheck())
            {
                MessageBox.Show("You were successfully logged in", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            //if user's input wasn't correct -> fail 
            else if (!UserInputCheck())
            {
                MessageBox.Show("Wrong Login Details", "Fail", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }


}

