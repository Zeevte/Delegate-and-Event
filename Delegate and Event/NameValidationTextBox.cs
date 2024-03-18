using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_and_Event
{
    public class NameValidationTextBox: TextBox
    {
        public EventHandler InvalidKeyPressed;
        // Constructor
        public NameValidationTextBox()
        {
            KeyPress += ValidationTextBox_KeyPress;

        }
        private void ValidationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }



    }
}
