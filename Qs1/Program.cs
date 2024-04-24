namespace Qs1
{
    public class Program
    {
        static void Main(string[] args)
        {           
            EventPublisher publisher = new EventPublisher();
            EventHandler handler = new EventHandler();           
            publisher.MyEvnt += handler.HandleEvent;            
            publisher.RaiseEvent("Finally Excecuted!!!!!");
            Console.ReadLine();
        }
    }
}
