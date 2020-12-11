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

namespace ObserverChatter
{
    /// <summary>
    /// Interaction logic for ChatClient.xaml
    /// </summary>
    public partial class ChatClient : Window, IObserver
    {
        public ChatSubject subject;

        public string name;
        public string msg;

        public ChatClient(ChatSubject chatSubject, string clientName)
        {
            InitializeComponent();
            subject = chatSubject;
            name = clientName;
            clientNameLabel.Content = name;
            chatSubject.Attach(this);
        }

        public string ClientName => name;

        public void ClientAttached(string name)
        {
            messagesListView.Items.Add($"[{DateTime.Now}] {name}: hat sich angemeldet");
            Console.WriteLine($"{name} attached");
        }

        public void ClientDetached(string name)
        {
            messagesListView.Items.Add($"[{DateTime.Now}] {name}: hat sich abgemeldet");
            Console.WriteLine($"{name} detached");
        }

        public void Update(string name, string msg)
        {
            messagesListView.Items.Add($"[{DateTime.Now}] {name}: {msg}");
            Console.WriteLine($"Name: {name}, Message: {msg}");
        }

        private void SendMessage(object sender, RoutedEventArgs e)
        {
            msg = msgText.Text;
            msgText.Text = "";
            subject.SetState(name, msg);
        }

        private void Detach(object sender, EventArgs e)
        {
            subject.Detach(this);
        }
    }
}
