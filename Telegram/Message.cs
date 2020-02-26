using System;
using System.Collections.Generic;
using System.Text;

namespace Telegram.Domain
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime MessageTime { get; set; }

        public int UserId { get; set; }
        public int ConversationId { get; set; }


        public UserConversation UserConversation { get; set; }
    }
}
