﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tweetFeed
{
  public interface IPrintFormater
    {
        void formator(string User, string message);
    }
}