using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace RssReader
{
    class RSSReader
    {
        private RssChannel rssChannel;
        private ImageOfChanel imageChanel;
        private RssItem[] articles;
        public RSSReader()
        {
            rssChannel = new RssChannel();
            imageChanel = new ImageOfChanel();

        }

        public bool GetItems(string sourceName)
        {
            try
            {
                XmlDocument doc = new XmlDocument(); 
                doc.Load(new XmlTextReader(sourceName));

                
                XmlNode root = doc.DocumentElement;
                articles = new RssItem[root.SelectNodes("channel/item").Count];
                XmlNodeList nodeList = root.ChildNodes;
                int count = 0;
                foreach(XmlNode channel in nodeList)
                {
                    foreach(XmlNode channel_item in channel)
                    {
                        switch(channel_item.Name)
                        {
                            case "title":
                                rssChannel.title = channel_item.InnerText;
                                break;
                            case "description":
                                rssChannel.description = channel_item.InnerText;
                                break;
                            case "link":
                                rssChannel.link = channel_item.InnerText;
                                break;
                            case "copyright":
                                rssChannel.copyright = channel_item.InnerText;
                                break;
                            case "image":
                                XmlNodeList imgList = channel_item.ChildNodes;
                                foreach(XmlNode imgItem in imgList)
                                {
                                    switch(imgItem.Name)
                                    {
                                        case "url":
                                            imageChanel.imgURL = imgItem.InnerText;
                                            break;
                                        case "link":
                                            imageChanel.imgLink = imgItem.InnerText;
                                            break;
                                        case "title":
                                            imageChanel.imgTitle = imgItem.InnerText;
                                            break;
                                    }
                                }
                                break;
                            case "item":
                                XmlNodeList itemsList = channel_item.ChildNodes;                                
                                articles[count] = new RssItem();
                                foreach(XmlNode item in itemsList)
                                    switch(item.Name)
                                    {
                                        case "title":
                                            articles[count].title = item.InnerText;
                                            break;
                                        case "link":
                                            articles[count].link = item.InnerText;
                                            break;
                                        case "description":
                                            articles[count].description = item.InnerText;
                                            break;
                                        case "pubDate":
                                            articles[count].pubData = item.InnerText;
                                            break;
                                    }
                                ++count;
                                break;
                        }
                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool GenerateHtml()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("last_articles.html"))
                {
                    writer.WriteLine("<html>");
                    writer.WriteLine("<head>");
                    writer.WriteLine("<meta http-equiv=\"content-type\" content=\"text/html; charset=utf-8\">");
                    writer.WriteLine("<title>");
                    writer.WriteLine(rssChannel.title);
                    writer.WriteLine("</title>");
                    writer.WriteLine("<style type='text/css'>");
                    writer.WriteLine("A{color:#483D8B; text-decoration:none; font:Verdana;}");
                    writer.WriteLine("pre{font-family:courier;color:#000000;");
	                writer.WriteLine("background-color:#dfe2e5;padding-top:5pt;padding-left:5pt;");
                    writer.WriteLine("padding-bottom:5pt;border-top:1pt solid #87A5C3;");
                    writer.WriteLine("border-bottom:1pt solid #87A5C3;border-left:1pt solid #87A5C3;");
                    writer.WriteLine("border-right : 1pt solid #87A5C3;	text-align : left;}");
                    writer.WriteLine("</style>");
                    writer.WriteLine("</head>");
                    writer.WriteLine("<body>");

                    writer.WriteLine("<font size=\"2\" face=\"Verdana\">");
                    writer.WriteLine("<a href=\"" + imageChanel.imgLink + "\">");
                    writer.WriteLine("<img src=\"" + imageChanel.imgURL + "\" border=0></a>  ");
                    writer.WriteLine("<h3>" + rssChannel.title + "</h3></a>");

                    writer.WriteLine("<table width=\"80%\" align=\"center\" border=1>");
                    foreach (RssItem article in articles)
                    {
                        writer.WriteLine("<tr>");
                        writer.WriteLine("<td>");
                        writer.WriteLine("<br>  <a href=\"" + article.link + "\"><b>" + article.title + "</b></a>");
                        writer.WriteLine("(" + article.pubData + ")<br><br>");
                        writer.WriteLine("<table width=\"95%\" align=\"center\" border=0>");
                        writer.WriteLine("<tr><td>");
                        writer.WriteLine(article.description);
                        writer.WriteLine("</td></tr></table>");
                        writer.WriteLine("<br>  <a href=" + article.link + "\">");
                        writer.WriteLine("<font size=\"1\">читать дальше</font></a><br><br>");
                        writer.WriteLine("</td>");
                        writer.WriteLine("</tr>");
                    }
                    writer.WriteLine("</table><br>");

                    writer.WriteLine("<p align=\"center\">");
                    writer.WriteLine("<a href=" + rssChannel.link + "\">" + rssChannel.copyright + "</a></p>");

                    writer.WriteLine("</font>");
                    writer.WriteLine("</body>");
                    writer.WriteLine("</html>");
                    return true;
             }
        }
        catch (Exception ex)
        {
            return false;
        }
       }
    }

    

}
