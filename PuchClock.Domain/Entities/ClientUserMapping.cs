using PuchClock.Domain.Entities;

namespace PunchClock.Database.Domain
{
    public class ClientUserMapping
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }

        public Guid ClientId { get; set; }

        public virtual Client Client { get; set; }

        public virtual AppUser User { get; set; }
    }
}
