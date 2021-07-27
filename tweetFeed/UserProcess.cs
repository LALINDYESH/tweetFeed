using System;
using System.Collections.Generic;
using System.Text;

namespace tweetFeed
{
    public class UserProcess : IUserProcess
    {
        public List<string> ProcessUser(List<follower> UserList)
        {
            var followersAndUser = new List<string>();
            foreach (var item in UserList)
            {
                if (!followersAndUser.Contains(item.UserName))
                {
                    followersAndUser.Add(item.UserName);
                }

                if (item.Followers.Count > 0)
                {
                    foreach (var followerItem in item.Followers)
                    {
                        if (!followersAndUser.Contains(followerItem))
                        {
                            followersAndUser.Add(followerItem);
                        }
                        
                    }
                }                          
            }
              followersAndUser.Sort();
            return followersAndUser;
        }
    }
}
