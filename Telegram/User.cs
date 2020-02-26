using System;
using System.Collections.Generic;
using System.Text;

namespace Telegram.Domain
{
    public class User
    {
        public User()
        {
            Conversations = new HashSet<UserConversation>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string LogIn { get; set; }
        public string Password { get; set; }

        public ICollection<UserConversation> Conversations { get; set; }
    }
}
