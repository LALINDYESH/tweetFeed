using System;
using System.Collections.Generic;
using System.Text;

namespace tweetFeed
{
  public class Tweets : Users
    {
        public Tweets()
        { }
        public Tweets(string name) : base(name)
        { }
        public string Messsage { get; set; }

    }
}
