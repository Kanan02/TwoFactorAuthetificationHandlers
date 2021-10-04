using _2StepAuthentificationChainOfResp.Handlers.Concrete;
using _2StepAuthentificationChainOfResp.Models;
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
using System.Windows.Shapes;

namespace _2StepAuthentificationChainOfResp.View
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Receiver receiver = new Receiver(true, true);
            PassAuthHandler passAuthHandler = new PassAuthHandler();
            EmailAuthHandler emailAuthHandler = new EmailAuthHandler();
            passAuthHandler.Successor = emailAuthHandler;
            passAuthHandler.Handle(receiver,new User(usrbox.Text,pswbox.Password,""));
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }
    }
}
