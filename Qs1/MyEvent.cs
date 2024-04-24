using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Qs1.MyEvent;

namespace Qs1
{
    public class MyEvent : EventArgs
    {
        public string Msg { get; set; }

        public MyEvent(string answer)
        {
            Msg = answer;
        }

        public delegate void EventHandler(object sender, MyEvent e);
    }

    public class EventPublisher
    {
        public event MyEvent.EventHandler MyEvnt;

        public void RaiseEvent(string message)
        {            
            OnEvent(new MyEvent(message));
        }

        protected virtual void OnEvent(MyEvent e)
        {
            MyEvent.EventHandler handler = MyEvnt;
            handler?.Invoke(this, e);
        }
    }

    public class EventHandler
    {
        public void HandleEvent(object sender, MyEvent e)
        {
            Console.WriteLine("Show The line : " + e.Msg);
        }
    }
}
