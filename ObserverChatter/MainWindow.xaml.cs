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
    public partial class MainWindow : Window, IObserver
    {
        ChatSubject chatSubject;

        public string name;
        public string msg;
        public int id;

        public MainWindow()
        {
            InitializeComponent();
        }

        public string ClientName => name;

        public void ClientAttached(string name)
        {
            id++;
            numberClients.Content = id;
            attachListView.Items.Add($"[{DateTime.Now}] {name}: attached");
        }

        public void ClientDetached(string name)
        {
            id--;
            numberClients.Content = id;
            attachListView.Items.Add($"[{DateTime.Now}] {name}: detached");
        }

        public void Update(string name, string msg)
        {
            messagesListView.Items.Add($"[{DateTime.Now}] {name}: {msg}");
        }

        private void StartClient(object sender, RoutedEventArgs e)
        {
            string name = clientNameTextBox.Text;
            clientNameTextBox.Text = "";
            new ChatClient(chatSubject, name).Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            chatSubject = new ChatSubject();
            name = "Server";
            id = 0;
            chatSubject.Attach(this);
        }
    }
}
