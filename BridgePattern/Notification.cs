namespace BridgePattern
{
    public abstract class Notification(ISender sender)
    {
        protected readonly ISender _sender = sender;

        public abstract void Notifiy(string title, string body);
    }

    public class RegularNotification(ISender sender) : Notification(sender)
    {
        public override void Notifiy(string title, string body)
        {
            _sender.Send($"[Regular] {title}", body);
        }
    }

    public class UrgentNotification(ISender sender) : Notification(sender)
    {
        public override void Notifiy(string title, string body)
        {
            _sender.Send($"[Urgent] {title}", body);
        }
    }
}
