using System;
using System.Collections.Generic;
using System.Text;

namespace Telegram.Domain
{
    public class Conversation
    {
        public Conversation()
        {
            Users = new HashSet<UserConversation>();
        }
        public int Id { get; set; }
        public string ConversationName { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<UserConversation> Users { get; set; }
    }
}
