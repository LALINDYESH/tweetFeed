using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tweetFeed
{
  public interface ITweeTProccessor
    {
        List<string> ProcessTweets(List<string> userOrFollower, List<Tweets> tweets, List<follower> followers);
    }
}
