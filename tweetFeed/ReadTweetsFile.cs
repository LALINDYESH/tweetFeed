using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace tweetFeed
{
    class ReadTweetsFile : IReadTweets
    {
        public List<Tweets> ReadTextFile(string path)
        {
            var listOfTweets = new List<Tweets>();
            try
            {
                var allLines = File.ReadAllLines(path);
                foreach (var line in allLines)
                {
                    //Assuming that the User and Message only separated by >.
                    var splittedLines = line.Split(new[] { '>' });

                    if (splittedLines != null && splittedLines.Any())
                    {
                        listOfTweets.Add(new Tweets
                        {
                            UserName = splittedLines[0],
                            Messsage = splittedLines[1]
                        });
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("there has been an error that occured : {0}", e);
            }
            return listOfTweets;
        }
    }
}
