using System;
using System.Collections.Generic;
using System.Text;

namespace tweetFeed
{
    public class follower : Users
    {

          public follower()
           { }
          public follower(string name) : base(name)
          { }
        public List<string> Followers { get; set; }

    }
}
