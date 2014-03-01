using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader
{
    class RssItem
    {
        public string title;
        public string link;
        public string description;
        public string pubData;
        public RssItem()
        {
            title = "";
            link = "";
            description = "";
            pubData = "";
        }
    }
}
