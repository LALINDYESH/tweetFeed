using System;
using System.Configuration;
using System.Text;

namespace tweetFeed
{
  public  class Program
    {
  
        static void Main(string[] args)
        {
            ReadTweetsFile _readTweets = new ReadTweetsFile();
            ReadUserFile _readUser = new ReadUserFile();
            UserProcess _processUser = new UserProcess();
            TweetProcessor _tweetProcessor = new TweetProcessor();

            var UserAndFollowerObjList = _readUser.ReadTextFile(@"c:\Dev\user.txt");
            var TweetsList = _readTweets.ReadTextFile(@"c:\Dev\tweet.txt");
            var Allusers = _processUser.ProcessUser(UserAndFollowerObjList);
            var output = _tweetProcessor.ProcessTweets(Allusers, TweetsList, UserAndFollowerObjList);

            foreach(var item in output)
            {
                Console.WriteLine(item);
            }

        }
    }
}
