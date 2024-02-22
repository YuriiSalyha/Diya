using Diia.CustomComponents;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using DAL;


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

        private void createButton(Bitmap image, string title, string link) 
        {
            CustomImageButton newspage = new CustomImageButton();
            newspage.Tag = link;
            newspage.BorderRadius = 40;
            newspage.BorderSize = 1;
            newspage.BorderColor = Color.Black;
            newspage.ForeColor = Color.Black;
            newspage.Height = 300; // two panels per row
            //newspage.Height = 250; // single panel per row
            newspage.Width = NewsPanel.Width / 2; // two panels per row
            //newspage.Width = NewsPanel.Width - 30; // single panel per row
            newspage.Text = title;
            newspage.TextAlign = ContentAlignment.TopCenter; // two panels per row
            //newspage.TextAlign = ContentAlignment.MiddleRight; // single panel per row
            newspage.Image = image;
            newspage.ImageAlign = ContentAlignment.BottomCenter; // two panels per row
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

            //add multi thread
            //
            //

            string connectionString = "DefaultEndpointsProtocol=" +
                "https;AccountName=diiastorage;" +
                "AccountKey=d9jfXllVwNDqvzWNBr0c2lOKKN3tnkSf3o1ES" +
                "HH9FhT3Qh/+birYqTO/YHqlqqTsAa77B3TtP5oy+AStWtNKUg==;" +
                "EndpointSuffix=core.windows.net";
            //conection string to Azure blob

            var blobServiceClient = new BlobServiceClient(connectionString);
            BlobContainerClient containerClient = 
                blobServiceClient.GetBlobContainerClient("news-photos");

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var news = db.News.ToList();

                foreach (var article in news)
                {
                    Bitmap image = null;

                    /*foreach (BlobItem blobItem in containerClient.GetBlobs())
                    {
                        if (blobItem.Name.ToString() == article.PhotoName)
                        {
                            BlobClient blobClient = containerClient.GetBlobClient(blobItem.Name);
                            using (var stream = new MemoryStream())
                            {
                                blobClient.DownloadTo(stream);
                                image = new Bitmap(stream);
                            }
                            break;
                        }
                    }*/

                    //get current photo from blob
                    /*BlobItem blobItem = 
                        containerClient.GetBlobs()
                        .Where(b => b.Name.ToString() == article.PhotoName)
                        .FirstOrDefault();*/
                    
                    
                    BlobClient blobClient = containerClient.GetBlobClient(article.PhotoName);
                    using (var stream = new MemoryStream())
                    {
                        blobClient.DownloadTo(stream);
                        image = new Bitmap(stream);
                    }

                    createButton(image, article.NewsTitle, article.NewsLink);

                }

            }
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
