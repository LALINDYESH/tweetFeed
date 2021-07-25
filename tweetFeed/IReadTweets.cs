using System;
using System.Collections.Generic;
using System.Text;

namespace tweetFeed
{
  public interface IReadTweets
    {
        List<Tweets> ReadTextFile(string path);
    }
}
