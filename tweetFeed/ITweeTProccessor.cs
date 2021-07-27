using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tweetFeed
{
  public interface ITweeTProccessor
    {
        void ProcessTweets(List<string> userOrFollower);
    }
}
