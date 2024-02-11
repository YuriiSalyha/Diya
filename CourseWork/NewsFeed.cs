using Diya.CustomComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class NewsFeed : Form
    {
        public NewsFeed()
        {
            InitializeComponent();
            AdjustItems();
            NewsPanel.AutoScroll = true;
            fetchNews();
        }

        private void createButton(Bitmap image, string title) 
        {
            CustomImageButton newspage = new CustomImageButton();
            newspage.Tag = "https://diia.gov.ua/";
            newspage.BorderRadius = 40;
            newspage.BorderSize = 1;
            newspage.BorderColor = Color.Black;
            newspage.ForeColor = Color.Black;
            newspage.Height = 300; // two panels per row
            //newspage.Height = 250; // single panel per row
            newspage.Width = NewsPanel.Width / 2; // two panels per row
            //newspage.Width = NewsPanel.Width - 30; // single panel per row
            newspage.Text = title;
            newspage.TextAlign = ContentAlignment.BottomCenter; // two panels per row
            //newspage.TextAlign = ContentAlignment.MiddleRight; // single panel per row
            newspage.Image = image;
            newspage.ImageAlign = ContentAlignment.TopCenter; // two panels per row
            //newspage.ImageAlign = ContentAlignment.MiddleLeft; // single panel per row
            newspage.Name = title;
            NewsPanel.Controls.Add(newspage);
            newspage.Click += new EventHandler(ClickHandler);
        }

        private void ClickHandler(object? sender, EventArgs e) 
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            Uri uri = new Uri(btn.Tag.ToString());
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri.ToString();
            System.Diagnostics.Process.Start(psi);
        }

        private void fetchNews()
        {
            // get news from DB
            // .....
            // .....
            // .....


            // create a button out of fetched data
            Bitmap image = new Bitmap(Diya.Properties.Resources.Sample);
            createButton(image, "News");
            createButton(image, "News");
            createButton(image, "News");
            createButton(image, "News");
            createButton(image, "News");
            createButton(image, "News");
            createButton(image, "News");
            createButton(image, "News");
        }

        private void NewsFeed_Resize(object sender, EventArgs e)
        {
            AdjustItems();
        }

        private void AdjustItems() 
        {
            NewsPanel.Height = Convert.ToInt32(this.Height * 0.9);
            NewsPanel.Location = new Point(0, 80);
            foreach (System.Windows.Forms.Button newsButton in NewsPanel.Controls.OfType<System.Windows.Forms.Button>())
            {
                newsButton.Height = NewsPanel.Height / 2 - 20;
                newsButton.Width = NewsPanel.Width / 2 - 20;
            }
        }
    }
}
