using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_froms
{
    public partial class Form1 : Form
    {
        TestLabel _testLabel;

        TexttextBox _textBox;
        public Form1()
        {
            InitializeComponent();
            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                TestButton testButton = new TestButton(this, i, (i % 5) * 100, (i / 5) * 100, 100, 100);
                Controls.Add(testButton);

            }
            _testLabel = new TestLabel("ラベルです。", 100, 330, 100, 100);
            Controls.Add(_testLabel);

            _textBox = new TexttextBox( "10,300,500,1000",100,300,100,100);
            Controls.Add(_textBox);
            //label.Text = new Point(30, 400);
            //label.Text="ラベルです。";
            //controls.Add(label);

        }
        /// <summary>
        /// ラベルの文字を更新する
        /// </summary>
        /// <param name="str"></param>
        public void LabelTextUpdate(String str)
        {
            _testLabel.TextUpdate(str);
        }
        public string ButtonLabelReplacement(String str)
        {
            string s = _textBox.TextReplacement(str);
            return s;
        }


    }
}
