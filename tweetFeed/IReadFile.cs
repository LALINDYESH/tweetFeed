using System;
using System.Collections.Generic;
using System.Text;

namespace tweetFeed
{
   public interface IReadFile
    {
        List<follower> ReadTextFile(string file);

    }
}
