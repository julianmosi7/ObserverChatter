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

namespace ObserverChatter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ChatSubject chatSubject;

        public MainWindow()
        {
            InitializeComponent();
            chatSubject = new ChatSubject();
        }

        private void StartClient(object sender, RoutedEventArgs e)
        {
            string name = clientNameTextBox.Text;
            new ChatClient(chatSubject, name).Show();
        }
    }
}
