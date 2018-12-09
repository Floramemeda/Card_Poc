using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Model
{
    class UserModel
    {
        private int userId;
        public int UserId {
            get { return userId; }
            set { userId = value; }
        }
        private string userName;
        public string UserName {
            get { return userName; }
            set { userName = value; }
        }
        private Dictionary<int, int> userCards;
        public Dictionary<int, int> UserCards {
            get { return userCards; }
            set { userCards = value; }
        }
    }
}
