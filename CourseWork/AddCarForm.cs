using DAL;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diia
{
    public partial class AddCarForm : Form
    {
        List<string> transportTypes = new List<string>()
        {
            "Cars",
            "Trucks",
            "Buses",
            "Motorcycles",
            "Vans"
        };

        public AddCarForm()
        {
            InitializeComponent();
        }

        private void AddCarForm_Load(object sender, EventArgs e)
        {
            foreach (var transportType in transportTypes)
            {
                transportTypeBox.Items.Add(transportType);
            }
        }

        private void buttonTransportAddConfirmation_Click(object sender, EventArgs e)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {

                Random random = new Random();

                char firstLetter = (char)('A' + random.Next(0, 26)); // Generates a random letter from A to Z
                char secondLetter = (char)('A' + random.Next(0, 26));


                char firstMiddleDigit = (char)('0' + random.Next(0, 10));
                char secondMiddleDigit = (char)('0' + random.Next(0, 10));
                char thirdMiddleDigit = (char)('0' + random.Next(0, 10));
                char fourthMiddleDigit = (char)('0' + random.Next(0, 10));


                char secondLastLetter = (char)('A' + random.Next(0, 26));
                char LastLetter = (char)('A' + random.Next(0, 26));


                string registrationPlate = $"{firstLetter}{secondLetter} " +
                    $"{firstMiddleDigit}{secondMiddleDigit}{thirdMiddleDigit}{fourthMiddleDigit} " +
                    $"{secondLastLetter}{LastLetter}";

                Transport newRecord = new Transport
                {
                    TransportType = transportTypes.IndexOf(transportTypeBox.Text),
                    Brand = brandBox.Text,
                    Model = modelBox.Text,
                    ManufactureDate = Convert.ToDateTime(dateTimePicker.Text),
                    Color = colorBox.Text,
                    TransportId = new Guid(),
                    Person = db.TaxPayerCards
                        .Where(card => card.Number == CurrentUserTaxPayerNumber.TaxPayerNumber)
                        .FirstOrDefault().Person,

                    RegistrationPlate = registrationPlate

                };
                db.Transports.Add(newRecord);
                db.SaveChanges();
                MessageBox.Show($"Your registration plate is: {registrationPlate}");
            }
            this.Close();
        }
    }
}
