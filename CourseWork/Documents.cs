using Diya.CustomComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace CourseWork
{
    public partial class Documents : Form
    {
        public Documents()
        {
            InitializeComponent();
            AdjustItems();
            DocPanel.AutoScroll = true;
            fetchDocs();
        }

        private void createButton(Bitmap image, string title)
        {
            CustomImageButton docpage = new CustomImageButton();
            
            docpage.BorderRadius = 40;
            docpage.BorderSize = 1;
            docpage.BorderColor = Color.Black;
            docpage.ForeColor = Color.Black;
            docpage.Height = DocPanel.Height-30; 
            docpage.Width = DocPanel.Width / 2; 
            docpage.Text = title;
            docpage.TextAlign = ContentAlignment.BottomCenter; 
            docpage.Image = image;
            docpage.ImageAlign = ContentAlignment.TopCenter; 
            docpage.Name = title;
            DocPanel.Controls.Add(docpage);
            docpage.Click += new EventHandler(ClickHandler);
        }

        private void ClickHandler(object? sender, EventArgs e)
        {
            Button btn = sender as Button;            
        }



private void fetchDocs() 
        {
            // get docs from DB
            // .....
            // .....
            // .....


            // create a button out of fetched data
            Bitmap image = new Bitmap(Diya.Properties.Resources.Sample);
            createButton(image, "Doc");
            createButton(image, "Doc");
            createButton(image, "Doc");
            createButton(image, "Doc");
        }

        private void Documents_Resize(object sender, EventArgs e)
        {
            AdjustItems();
        }

        private void AdjustItems() 
        {
            DocPanel.Height = Convert.ToInt32(this.Height * 0.8);
            foreach (System.Windows.Forms.Button docButton in DocPanel.Controls.OfType<System.Windows.Forms.Button>())
            {
                docButton.Height = DocPanel.Height - 30;
                docButton.Width = DocPanel.Width / 2 - 5;
            }
        }

    }
}
