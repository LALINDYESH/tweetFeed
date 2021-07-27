using System;
using System.Collections.Generic;
using System.Text;

namespace tweetFeed
{
   public interface IUserProcess
    {
        List<string> ProcessUser( List<follower> UserList);
    }
}
