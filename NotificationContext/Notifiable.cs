

namespace Balta.NotificationContext {
    public abstract class Notifiable {
        public List<Notification> Notifications { get; set; }
        

        public Notifiable()
        {
            Notifications = new List<Notification>();
        }

        public void Add(Notification notification)
        {
            Notifications.Add(notification);
        }
        public void AddRange(IEnumerable<Notification> notification)
        {
            Notifications.AddRange(notification);
        }

        public bool IsInvalid => Notifications.Any();
    }
}