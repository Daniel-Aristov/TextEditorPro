using TextEditorPro.Controls;

namespace TextEditorPro
{
    public static class TextEdit
    {
        public static void CutSelectText(TabControl tabControl)
        {
            if (tabControl.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControl.TabPages[tabControl.SelectedIndex].Controls[0];
                if (_myRichTextBox.richTextBoxPlus.SelectedText != "")
                {
                    if (Clipboard.ContainsText())
                    {
                        Clipboard.Clear();
                        Clipboard.SetText(_myRichTextBox.richTextBoxPlus.SelectedText);
                        _myRichTextBox.richTextBoxPlus.SelectedText = "";
                    }
                    else
                    {
                        Clipboard.SetText(_myRichTextBox.richTextBoxPlus.SelectedText);
                        _myRichTextBox.richTextBoxPlus.SelectedText = "";
                    }
                }
            }
        }

        public static void CopySelectText(TabControl tabControl)
        {
            if (tabControl.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControl.TabPages[tabControl.SelectedIndex].Controls[0];
                if (_myRichTextBox.richTextBoxPlus.SelectedText != "")
                {
                    if (Clipboard.ContainsText())
                    {
                        Clipboard.Clear();
                        Clipboard.SetText(_myRichTextBox.richTextBoxPlus.SelectedText);
                    }
                    else
                    {
                        Clipboard.SetText(_myRichTextBox.richTextBoxPlus.SelectedText);
                    }
                }
            }
        }

        public static void PasteSelectText(TabControl tabControl)
        {
            if (tabControl.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)tabControl.TabPages[tabControl.SelectedIndex].Controls[0];

                if (Clipboard.ContainsText())
                {
                    _myRichTextBox.richTextBoxPlus.Paste();
                }
            }
        }
    }
}
