using System;
using System.Collections.Generic;
using System.Text;

namespace tweetFeed
{
    public class PrintFormator : IPrintFormater
    {
        public void formator(string User, string message)
        {
            Console.WriteLine("\t{0}{1}{2}{3}", "@", User, ": ", message);
        }
    }
}
