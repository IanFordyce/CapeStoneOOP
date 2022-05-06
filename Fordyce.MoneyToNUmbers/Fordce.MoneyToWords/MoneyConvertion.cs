using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fordce.MoneyToWords
{
    public partial class MoneyConvertion : Form
    {
        public MoneyConvertion()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            createANewNumber(txtInputBox.Text,"U.S. Dollars");

        }
       
        private void txtInputBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void createANewNumber(String theNumber, String currenceyType)
        {
           MoneyToEnglish newNumber = new MoneyToEnglish(theNumber, currenceyType);

            if (newNumber.get_convertedNumber().Length == 0)
            {
                lblConvertedDisplay.Text = newNumber.get_convertedNumber();
            }
            else
            {
                lblConvertedDisplay.Text = newNumber.get_convertedNumber();
            }
        }

        private void lblConvertedDisplay_Click(object sender, EventArgs e)
        {

        }

        private void MoneyConvertion_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInputBox.Text = String.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '$' || e.KeyChar == '\b' || e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else if (restrictNUmberAfterDecimal())
            {
                e.Handled = true;
            }
            else if (e.KeyChar > '9' || e.KeyChar < '0')
            {
                e.Handled = true;
            }
            if (txtInputBox.Text.Length > 16 )
            {
                e.Handled=true;
            }
            
        }
        
        public bool restrictNUmberAfterDecimal()
        {
            if (txtInputBox.Text.Contains ('.'))
            {
                if ((txtInputBox.Text.Substring(txtInputBox.Text.LastIndexOf('.' )).Length >= 3))
                    return true;
            }
            return false;
        }


    }
}
