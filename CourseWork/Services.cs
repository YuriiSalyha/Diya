
using Diia;

namespace CourseWork
{
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm();

            addCarForm.Show();
        }

        private void seeRealEstate_Click(object sender, EventArgs e)
        {
            SeeRealEstateForm seeRealEstateForm = new SeeRealEstateForm();

            seeRealEstateForm.Show();
        }
    }
}
