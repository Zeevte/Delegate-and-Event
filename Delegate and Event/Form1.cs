using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_and_Event
{
    //הצערה על דליגהט
    public delegate int Calc(int x, int y);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //שימוש בפונקציה
            Fun1(Add);
        }

        //פונקציה שעונה על ההגדרה של דליגהט
        public int Add(int x, int y)
        {
            return x + y;
        }

        //פונקציה שמפנה לדליגהט
        public void Fun1(Calc calc)
        {
            calc(5, 4);
        }
    }
}
