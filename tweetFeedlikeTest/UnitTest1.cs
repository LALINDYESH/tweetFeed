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
            var ExpectedList = new List<String>() {"Alan","Martin","Ward"
            };
            //    // Act
          var AlluserList =  userprocess.ProcessUser(TestList);
            //    // Assert
            Assert.Equal(ExpectedList, AlluserList);
        }

        [Fact]
        public void ReadTweetsFileTest()
        {
            //arrange
            ReadTweetsFile _readTweets = new ReadTweetsFile();
            var expectedTweets = new List<Tweets>()
            { new Tweets {UserName ="Alan",Messsage ="If you have a procedure with 10 parameters, you probably missed some." },
              new Tweets {UserName ="Ward",Messsage ="There are only two hard things in Computer Science: cache invalidation, naming things and off-by-1 errors."},
              new Tweets {UserName ="Alan",Messsage ="Random numbers should not be generated with a method chosen at random." } };
            //Act
            var testTweets = _readTweets.ReadTextFile("tweet.txt");
            //Assert
            Assert.Equal(expectedTweets, testTweets);
        }

        [Fact]
        public void formatorTest()
        {
            //Arrange
            var UserName = "Alan";
            var Message = "If you have a procedure with 10 parameters, you probably missed some.";
            PrintFormator printTweet = new PrintFormator();
            var ExpectedString = "@Alan: If you have a procedure with 10 parameters, you probably missed some.";
            //Act
             var outstring = printTweet.formator(UserName, Message);

            //Assert
            Assert.Equal(ExpectedString, outstring);
        }

        [Fact]
        public void TweetProcess()
        {
            //Arrange
            TweetProcessor processTweets = new TweetProcessor();
            var ExpetedOut = new List<string>() {"Alan","@Alan: If you have a procedure with 10 parameters, you probably missed some.",
                "@Alan: Random numbers should not be generated with a method chosen at random.",
                "Martin","Ward","@Alan: If you have a procedure with 10 parameters, you probably missed some.",
                "@Ward: There are only two hard things in Computer Science: cache invalidation, naming things and off-by-1 errors.",
                "@Alan: Random numbers should not be generated with a method chosen at random."
            };
            var Tweets = new List<Tweets>()
            { new Tweets {UserName ="Alan",Messsage ="If you have a procedure with 10 parameters, you probably missed some." },
              new Tweets {UserName ="Ward",Messsage ="There are only two hard things in Computer Science: cache invalidation, naming things and off-by-1 errors."},
              new Tweets {UserName ="Alan",Messsage ="Random numbers should not be generated with a method chosen at random." } };

            var follower1 = new List<string>(){ "Alan" };
            var follower2 = new List<string>() { "Martin" };
            var follower3 = new List<string>() { "Martin,", "Alan" };
            var followerList = new List<follower>
            {
               new follower{UserName = "Ward",Followers = follower1},
               new follower{UserName = "Alan",Followers = follower2},
               new follower{UserName ="Ward",Followers =follower3}
            };
            var UserList = new List<String>() {"Alan","Martin","Ward"
            };
            //Act
            var outputTest = processTweets.ProcessTweets(UserList, Tweets, followerList);
            //Assert
            Assert.Equal(ExpetedOut.ToString(), outputTest.ToString());

        }



    }
}
