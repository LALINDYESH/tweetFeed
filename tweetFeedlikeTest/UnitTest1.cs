using System;
using Xunit;
using tweetFeed;
using System.Collections.Generic;

namespace tweetFeedlikeTest
{
    public class UnitTest1
    {
        [Fact]
        public void ReadUserFileTest()
        {
            //    // Arrange
            ReadUserFile _readUsertestObj = new ReadUserFile();
            var follower1 = new List<string>(
              ) { "Alan" };
            var follower2 = new List<string>(
               ) { "Martin" };
            var follower3 = new List<string>(
               ) { "Martin,", "Alan" };
            var TestList = new List<follower>
            { 
               new follower{UserName = "Ward",Followers = follower1},
               new follower{UserName = "Alan",Followers = follower2},
               new follower{UserName ="Ward",Followers =follower3}
            };
          
            //    // Act
            var Users = _readUsertestObj.ReadTextFile(@"c:\Dev\user.txt");
            //    // Assert
            Assert.Equal(TestList, Users);
        }

        [Fact]
        public void UserProcessTest()
        {
               // Arrange
            UserProcess userprocess = new UserProcess();
            //    // Act

            //    // Assert
        }

        [Fact]
        public void ReadTweetsFileTest()
        {



        }

        [Fact]
        public void formatorTest()
        {

        }

        [Fact]
        public void UserProcess()
        {
            
        }


        [Fact]
        public void TweetProcess()
        {

        }



    }
}
