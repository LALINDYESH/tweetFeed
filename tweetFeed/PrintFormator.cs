using System;
using System.Collections.Generic;
using System.Text;

namespace tweetFeed
{
    public class PrintFormator : IPrintFormater
    {
        public string formator(string User, string message)
        {
          var newString = String.Format("\t{0}{1}{2}{3}", "@", User, ": ", message);
            return newString; 
        }
    }
}
