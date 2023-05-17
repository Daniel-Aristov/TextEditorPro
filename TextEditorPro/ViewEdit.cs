using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEditorPro.Controls;

namespace TextEditorPro
{
    public static class ViewEdit
    {
        public static void FontEdit(TabControl tabControlPlus)
        {
            if (tabControlPlus.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlPlus.TabPages[tabControlPlus.SelectedIndex].Controls[0];
                FontDialog fd = new FontDialog();

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    _myRichTextBox.richTextBoxPlus.Font = fd.Font;
                }
            }
        }

        public static void FontColorEdit(TabControl tabControlPlus)
        {
            if (tabControlPlus.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlPlus.TabPages[tabControlPlus.SelectedIndex].Controls[0];
                ColorDialog cd = new ColorDialog();

                if (cd.ShowDialog() == DialogResult.OK)
                {
                    _myRichTextBox.richTextBoxPlus.ForeColor = cd.Color;
                }
            }
        }

        public static void BackColorEdit(TabControl tabControlPlus)
        {
            if (tabControlPlus.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControlPlus.TabPages[tabControlPlus.SelectedIndex].Controls[0];
                ColorDialog cd = new ColorDialog();

                if (cd.ShowDialog() == DialogResult.OK)
                {
                    _myRichTextBox.richTextBoxPlus.BackColor = cd.Color;
                }
            }
        }

        public static void FontStyleEdit(TabControl tabControlPlus, FontStyle fontStyle)
        {
            var _myRichTextBox = (MyRichTextBox)tabControlPlus.TabPages[tabControlPlus.SelectedIndex].Controls[0];
            _myRichTextBox.richTextBoxPlus.SelectionFont = new Font(_myRichTextBox.richTextBoxPlus.Font, _myRichTextBox.richTextBoxPlus.SelectionFont.Style | fontStyle);
        }

        public static void FontStyleDefault(TabControl tabControlPlus)
        {
            var _myRichTextBox = (MyRichTextBox)tabControlPlus.TabPages[tabControlPlus.SelectedIndex].Controls[0];
            _myRichTextBox.richTextBoxPlus.SelectionFont = new Font(_myRichTextBox.richTextBoxPlus.Font, FontStyle.Regular);
        }
    }
}
