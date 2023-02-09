namespace User.API.Entities
{
    public class Subscription
    {
        public int Id { get; set; }
        public string SubscriptionType { get; set; }
        public bool IsDeactivated { get; set; }
        public string Period { get; set; }
        public AppUser AppUserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
