using System;
using System.Collections.Generic;
using System.Text;

namespace tweetFeed
{
    public abstract class Users
    {
        public string UserName { get; set; }

        public Users()
        {
        }
        public Users(string name)
        {
             this.UserName = name;
        }

    }
}
