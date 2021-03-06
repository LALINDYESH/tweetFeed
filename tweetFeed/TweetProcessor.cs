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
        public List<string> ProcessTweets(List<string> userOrFollower, List<Tweets> tweets,List<follower> followers)
        {
            var output = new List<string>();

            foreach (var user in userOrFollower)
            {

                output.Add(user);
                var findtweets = tweets.Where(t => t.UserName == user);            
                if (findtweets.Count() > 0)
                {
                    foreach (var ItemTweet in findtweets)
                    {
                        //add tweets for the user.
                       output.Add( _printTweet.formator(ItemTweet.UserName, ItemTweet.Messsage));
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
                   output.Add( _printTweet.formator(FollowerTweets.UserName, FollowerTweets.Messsage));
                }

            }

            return output;
        }
    }
}
