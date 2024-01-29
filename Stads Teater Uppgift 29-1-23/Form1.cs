using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stads_Teater_Uppgift_29_1_23
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void BeräknaKnapp_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            sum += AntalVuxna.Value * decimal.Parse(VuxnaKostnad.Text);
            TotaltVuxna.Text = "TOTALT: " + AntalVuxna.Value * decimal.Parse(VuxnaKostnad.Text);

            sum += AntalBarn.Value * decimal.Parse(BarnKostnad.Text);
            TotaltBarn.Text = "TOTALT: " + AntalBarn.Value * decimal.Parse(BarnKostnad.Text);


            sum += AntalPensionär.Value * decimal.Parse(PensionärKostnad.Text);
            TotaltPensionär.Text = "TOTALT: " + AntalPensionär.Value * decimal.Parse(PensionärKostnad.Text);


            TotaltKostnad.Text = "TOTALT: " + sum.ToString();
        }


    }
    }
