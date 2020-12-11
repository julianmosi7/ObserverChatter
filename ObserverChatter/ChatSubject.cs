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

        public string GetState()
        {
            return name + " " + msg;
        }

        public void SetState(string clientName, string clientMsg)
        {
            name = clientName;
            msg = clientMsg;
            Notify(name, msg);
        }
    }
}
