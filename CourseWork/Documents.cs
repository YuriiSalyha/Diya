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
            fetchDocsAsync();
        }

        private async void createButtonAsync(Bitmap image, string title)
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


            if (DocPanel.InvokeRequired)
            {
                DocPanel.Invoke((MethodInvoker)delegate
                {
                    DocPanel.Controls.Add(docpage);
                });
            }
            else
            {
                DocPanel.Controls.Add(docpage);
            }
        }


        private async void fetchDocsAsync() 
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

                var documents = db.Documents
                    .Where(
                        documenet => documenet.Person.TaxPayerCard.FirstOrDefault().Number
                            == CurrentUserTaxPayerNumber.TaxPayerNumber
                    );

                if (documents.Any())
                {


                    Parallel.ForEach(documents, async document =>
                    {
                        Bitmap image = null;
                        BlobClient blobClient = containerClient.GetBlobClient(document.DocumentLink);

                        using (var stream = new MemoryStream())
                        {
                            await blobClient.DownloadToAsync(stream);
                            image = new Bitmap(stream);
                        }

                        createButtonAsync(image, documentTypes[document.DocumentType]);

                    });
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
