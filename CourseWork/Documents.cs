using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using DAL;
using Diia;
using Diia.CustomComponents;
using System.Drawing.Text;

namespace CourseWork
{
    public partial class Documents : Form
    {
        List<string> documentTypes = new List<string>
        {
            "Id Card",
            "Passport",
            "Birth certificate",
            "Student card",
            "Driver license",
            "Pension certificate"
        };

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
            string connectionString = "DefaultEndpointsProtocol=https;" +
                "AccountName=diiastorage;" +
                "AccountKey=d9jfXllVwNDqvzWNBr0c2lOKKN3tnkSf3o1E" +
                "SHH9FhT3Qh/+birYqTO/YHqlqqTsAa77B3TtP5oy+AStWtNKUg==;" +
                "EndpointSuffix=core.windows.net";
            //conection string to Azure blob

            var blobServiceClient = new BlobServiceClient(connectionString);
            BlobContainerClient containerClient =
                blobServiceClient.GetBlobContainerClient("documents");

            using (ApplicationDbContext db = new ApplicationDbContext())
            {


                // temporary
                var currentUser = db.TaxPayerCards.Where(d => d.Number == CurrentUserTaxPayerNumber.TaxPayerNumber).FirstOrDefault().Person;

                var documents = db.Documents
                    .Where(
                        documenet => documenet.Person.TaxPayerCard.FirstOrDefault().Number
                            == CurrentUserTaxPayerNumber.TaxPayerNumber
                    );


                /*Guid currentUserId;
                if (currentUser != null)
                {
                    currentUser = currentUser.PersonId;
                }
                var documents2 = db.Documents.Where(d => d.Person.PersonId == currentUserId);*/
                if (documents.Any())
                {


                    foreach (var document in documents)
                    {
                        Bitmap image = null;

                        //documentLink it is name of document photo
                        /*BlobItem blobItem = containerClient.GetBlobs()
                            .Where(d => d.Name.ToString() == document.DocumentLink).FirstOrDefault();*/

                        //BlobClient blobClient = containerClient.GetBlobClient(document.DocumentLink);

                        //MessageBox.Show(document.DocumentLink);
                        BlobClient blobClient = containerClient.GetBlobClient(document.DocumentLink);

                        

                        using (var stream = new MemoryStream())
                        {
                            blobClient.DownloadTo(stream);
                            image = new Bitmap(stream);
                        }

                        createButton(image, documentTypes[document.DocumentType]);


                    }
                }

            }


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
