using _2StepAuthentificationChainOfResp.Models;
using _2StepAuthentificationChainOfResp.Services.Abstract;
using _2StepAuthentificationChainOfResp.Services.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace _2StepAuthentificationChainOfResp.View
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (FieldsAreOk())
            {
                Close();
            }
        }
     
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }



        void RaiseError(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        void AllIsCompleted(List<User> users, IUserFileService fileService)
        {
            users.Add(new User(usname.Text, pbox.Password, mbox.Text));
            fileService.Save("users.json", users);
            MessageBox.Show("User is Created!", "Completed", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        bool FieldsAreOk()
        {
            List<User> users = new List<User>();
            IUserFileService fileService = new UserFileService();
            if (usname.Text.Length >= 4 && pbox.Password.Length >= 8 && mbox.Text.Contains("@"))
            {
                if (FileExists("users.json"))
                {
                    users = (List<User>)fileService.Open("users.json");
                    foreach (var item in users)
                    {
                        if (item.Username == usname.Text)
                        {
                            RaiseError("Such user already exists");
                            return false;
                        }
                    }
                    AllIsCompleted(users, fileService);
                }
                else
                {
                    AllIsCompleted(users, fileService);
                }
            }
            else
            {
                RaiseError("Incorrect values!\n P.S. Password should have at least 8 characters.\n Username should have at least 4 chars.\n Mail should contain @.");
                return false;
            }
            return true;
        }

        bool FileExists(string filename)
        {

            DirectoryInfo directoryInfo = new DirectoryInfo(AppContext.BaseDirectory);
            foreach (var item in directoryInfo.GetFiles())
            {

                if (item.Name == filename)
                {
                    return true;
                }

            }
            return false;
        }

    }
}
