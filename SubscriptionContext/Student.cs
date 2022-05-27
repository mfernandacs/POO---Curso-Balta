using Balta.NotificationContext;
using Balta.SharedContext;
using Balta.SubscriptionContext;

namespace Balta.SubscriptionContext
{
    public class Student : Base 
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public User? User { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription)
        {
            if(IsPremium)
            {
                AddNotification(new Notification("Premium","O aluno ja tem um assinatura ativa"));
                return;
            }
            Subscriptions.Add(subscription);
        }
        public bool IsPremium => Subscription.Any(x => x.IsInactive);

    }
}