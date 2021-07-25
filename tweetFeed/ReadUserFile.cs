using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace tweetFeed
{
    public class ReadUserFile : IReadFile
    {
 
        public List<follower> ReadTextFile(string path)
        {
            var allLines = File.ReadAllLines(path);
            var listOfUser = new List<follower>();
            foreach (var line in allLines)
            {
                //Assuming that the users textfile has no spaces between the words.
                var splittedLines = line.Split(new[] {' '});
           
                if (splittedLines != null && splittedLines.Any())
                {
                    string[] followerList = splittedLines[2].Split(",");

                    listOfUser.Add(new follower
                    {
                        UserName = splittedLines[0],
                        Followers = followerList.ToList()
                    }); 
                }              
            }
            return listOfUser;
        }
    }
}
