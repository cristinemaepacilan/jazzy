using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jazzydior
{
    public partial class SR_Discount : Form
    {
        private readonly SR_NewTransaction transactionForm;

        public SR_Discount(SR_NewTransaction transactionForm)
        {
            InitializeComponent();
            this.transactionForm = transactionForm;
        }

        private void btnExitForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            dynamic discount = Convert.ToDecimal(txtBoxDiscount.Text.Trim());
           if ( !checkBoxDiscount.Checked )
            {
                this.transactionForm.transaction.Discount = discount;
                this.transactionForm.transaction.AmountDue = this.transactionForm.transaction.AmountDue - this.transactionForm.transaction.Discount;
            }
            else
            {
                var percenttoDecimal = discount / 100 ;
                this.transactionForm.transaction.Discount =  Convert.ToDecimal(transactionForm.transaction.AmountDue * percenttoDecimal) ;
                this.transactionForm.transaction.AmountDue = Math.Round(this.transactionForm.transaction.AmountDue - this.transactionForm.transaction.Discount,2,MidpointRounding.AwayFromZero);
            }
            this.transactionForm.ProcessUI();
            this.Dispose();
        }

        private void btnRemoveDiscount_Click(object sender, EventArgs e)
        {
            transactionForm.transaction.AmountDue += transactionForm.transaction.Discount;
            transactionForm.transaction.Discount = 0M;
            transactionForm.ProcessUI();
            this.Dispose();
        }
    }
}
