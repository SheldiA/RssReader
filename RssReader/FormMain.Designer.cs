namespace RssReader
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_go = new System.Windows.Forms.Button();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_go
            // 
            this.bt_go.Location = new System.Drawing.Point(712, 12);
            this.bt_go.Name = "bt_go";
            this.bt_go.Size = new System.Drawing.Size(121, 28);
            this.bt_go.TabIndex = 1;
            this.bt_go.Text = "Load";
            this.bt_go.UseVisualStyleBackColor = true;
            this.bt_go.Click += new System.EventHandler(this.bt_go_Click);
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(532, 17);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(161, 20);
            this.tb_url.TabIndex = 2;
            this.tb_url.Text = "http://tech.onliner.by/feed";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Browser);
            this.panel1.Location = new System.Drawing.Point(7, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 327);
            this.panel1.TabIndex = 3;
            // 
            // Browser
            // 
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.Location = new System.Drawing.Point(0, 0);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(845, 327);
            this.Browser.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 384);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.bt_go);
            this.Name = "FormMain";
            this.Text = "RssReader";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_go;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser Browser;
    }
}

