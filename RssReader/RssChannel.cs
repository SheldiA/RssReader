﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader
{
    class RssChannel
    {
        public string title;
        public string description;
        public string link;
        public string copyright;
        public RssChannel()
        {
            title = "";
            description = "";
            link = "";
            copyright = "";
        }
    }
}
