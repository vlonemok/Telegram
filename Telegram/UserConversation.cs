using System;
using System.Collections.Generic;
using System.Text;

namespace Telegram.Domain
{
    public class UserConversation
    {
        public UserConversation()
        {
            Messages = new HashSet<Message>();
        }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ConversationId { get; set; }
        public Conversation Conversation { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
