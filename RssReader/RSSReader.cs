using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader
{
    class RSSReader
    {
        private RssChannel rssChannel;
        private RssItem[] rssitems;
        public RSSReader()
        {
            rssChannel = new RssChannel();

        }
    }
}
