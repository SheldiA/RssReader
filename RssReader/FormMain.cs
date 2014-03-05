using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RssReader
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void bt_go_Click(object sender, EventArgs e)
        {
            RSSReader reader = new RSSReader();
            if (reader.GetItems(tb_url.Text) && reader.GenerateHtml())
                Browser.Navigate(Environment.CurrentDirectory + "\\last_articles.html");
        }
    }
}
