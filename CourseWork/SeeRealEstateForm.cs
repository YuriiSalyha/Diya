using DAL;
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
    public partial class SeeRealEstateForm : Form
    {
        public SeeRealEstateForm()
        {
            InitializeComponent();
        }

        private void SeeRealEstateForm_Load(object sender, EventArgs e)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                try {
                    var Person = db.TaxPayerCards
                        .Where(card => card.Number
                                    == CurrentUserTaxPayerNumber.TaxPayerNumber).FirstOrDefault().Person.PersonId;

                    var realEstate = db.RealEstates.Where(p => p.People.FirstOrDefault().PersonId == Person).ToList();

                    dataGridView1.DataSource = realEstate;
                }
                catch(NullReferenceException)
                {
                    
                }
            }

        }
    }
}
