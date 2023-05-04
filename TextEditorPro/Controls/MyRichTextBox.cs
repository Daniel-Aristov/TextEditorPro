using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditorPro.Controls
{
    public partial class MyRichTextBox : UserControl
    {
        public MyRichTextBox()
        {
            InitializeComponent();
        }

        public int getWidth()
        {
            int w = 25;
            int line = richTextBoxPlus.Lines.Length;

            if (line <= 99)
            {
                w = 20 + (int)richTextBoxPlus.Font.Size;
            }
            else if (line <= 999)
            {
                w = 30 + (int)richTextBoxPlus.Font.Size;
            }
            else
            {
                w = 50 + (int)richTextBoxPlus.Font.Size;
            }

            return w;
        }

        public void AddLineNumbers()
        {
            richTextBoxPlus.Select();
            LineNumberTextBox.DeselectAll();

            Point pt = new Point(0, 0);

            int First_Index = richTextBoxPlus.GetCharIndexFromPosition(pt);
            int First_Line = richTextBoxPlus.GetLineFromCharIndex(First_Index);

            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;

            int Last_Index = richTextBoxPlus.GetCharIndexFromPosition(pt);
            int Last_Line = richTextBoxPlus.GetLineFromCharIndex(Last_Index);

            LineNumberTextBox.SelectionAlignment = HorizontalAlignment.Center;
            LineNumberTextBox.Text = "";
            LineNumberTextBox.Width = getWidth();
            LineNumberTextBox.Font = richTextBoxPlus.Font;

            for (int i = First_Line; i <= Last_Line + 1; i++)
            {
                LineNumberTextBox.Text += i + 1 + "\n";
            }
        }

        private void MyRichTextBox_Load(object sender, EventArgs e)
        {
            LineNumberTextBox.Font = richTextBoxPlus.Font;
            AddLineNumbers();
        }

        private void MyRichTextBox_Resize(object sender, EventArgs e)
        {
            AddLineNumbers();
        }

        private void richTextBoxPlus_SelectionChanged(object sender, EventArgs e)
        {
            this.Invalidate();
            Point pt = richTextBoxPlus.GetPositionFromCharIndex(richTextBoxPlus.SelectionStart);
            if (pt.X == 1)
            {
                AddLineNumbers();
            }
        }

        private void richTextBoxPlus_VScroll(object sender, EventArgs e)
        {
            LineNumberTextBox.Text = "";
            AddLineNumbers();
            LineNumberTextBox.Invalidate();
        }

        private void richTextBoxPlus_TextChanged(object sender, EventArgs e)
        {
            if (richTextBoxPlus.Text == "")
            {
                AddLineNumbers();
            }
        }

        private void richTextBoxPlus_FontChanged(object sender, EventArgs e)
        {
            LineNumberTextBox.Font = richTextBoxPlus.Font;
            AddLineNumbers();
        }

        private void LineNumberTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBoxPlus.Select();
            LineNumberTextBox.DeselectAll();
        }
    }
}
