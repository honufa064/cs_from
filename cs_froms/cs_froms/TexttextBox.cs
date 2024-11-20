using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_froms
{
    internal class TexttextBox : TextBox
    {
        public TexttextBox(string str, int x, int y, int width, int height)
        {
            // ラベル内に文字を
            Text = str;
            //ボタンの
            Location = new Point(x, y);
            //ボタンの大きさを
            Size = new Size(width, height);



        }
        public string TextReplacement(string str)
        {
            string temp = Text;
            Text = str;
            return temp;
        }





    }
}
