using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverChatter
{
    public class ChatSubject : Subject
    {
        private string name;
        private string msg;
        private string theme;

        public string GetState()
        {
            return name + " " + msg;
        }

        public void SetState(string clientName, string clientMsg, string clientTheme)
        {
            name = clientName;
            msg = clientMsg;
            theme = clientTheme;
            Notify(name, msg, theme);
        }
    }
}
