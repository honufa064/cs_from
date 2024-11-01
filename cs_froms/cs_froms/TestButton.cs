using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace cs_froms
{

    internal class TestButton : Button
    {
        public TestButton()
        {
            Click += Onclick;
        }
        public void Onclick(object sender, EventArgs s)
        {
            MessageBox.Show("Blue");
        }


    }   
}
    

