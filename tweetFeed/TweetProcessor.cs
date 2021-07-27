using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tweetFeed
{
    public class TweetProcessor : ITweeTProccessor
    { 
        PrintFormator  _printTweet = new PrintFormator();
        public void ProcessTweets(List<string> userOrFollower, List<Tweets> tweets,List<follower> followers)
        {
            foreach (var user in userOrFollower)
            {

                Console.WriteLine(user);
                var findtweets = tweets.Where(t => t.UserName == user);
                //var findFollowertweets = ;
                if (findtweets.Count() > 0)
                {
                    foreach (var ItemTweet in findtweets)
                    {
                        //prit tweets for the user.
                        _printTweet.formator(ItemTweet.UserName, ItemTweet.Messsage);
                    }
                }
                var _getfollowerTweets = new List<Tweets>();
                //find tweets of the user they follow
                foreach (var followerItem in followers)
                {
                    var findfollower = followerItem.Followers.Where(t => t.Contains(user));              
                   //var findfolloweTweets = 
                    if (findfollower.Count() > 0)
                    {
                       //vargetfollowerTweets = List
                        foreach (var followItem in findfollower)
                        {
                            var ftweets = tweets.Where(t => t.UserName == followItem);
                            if (ftweets.Count() > 0)
                            {
                                foreach (var ftweetsIterm in ftweets)
                                {
                                    _getfollowerTweets.Add(ftweetsIterm);
                                }
                            }
                        }
                       //find 
                    }
                }

                foreach (var FollowerTweets in _getfollowerTweets)
                {
                    _printTweet.formator(FollowerTweets.UserName, FollowerTweets.Messsage);
                }

            }
        }
    }
}
