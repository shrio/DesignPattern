namespace BridgePattern
{
    public interface ISender
    {
        void Send(string title, string body);
    }

    public class EmailSender : ISender
    {
        public void Send(string title, string body)
        {
            Console.WriteLine($"Email Send :{title} {body}");
        }
    }

    public class SmsSender : ISender
    {
        public void Send(string title, string body)
        {
            Console.WriteLine($"Sms Send :{title} {body}");
        }
    }
}
