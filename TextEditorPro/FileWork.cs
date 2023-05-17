using TextEditorPro.Controls;

namespace TextEditorPro
{
    public class FileWork
    {
        public static List<string> OpenedFilesList = new List<string> { };

        public static void FileNew(TabControl tabControl, TabPage tabPage)
        {
            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedTab = tabPage;

            var _myRichTextBox = (MyRichTextBox)tabControl.TabPages[tabControl.SelectedIndex].Controls[0];
            _myRichTextBox.richTextBoxPlus.Select();
        }

        public static void FileOpen(TabControl tabControl, TabPage tabPage, OpenFileDialog openFileDialog, RichTextBox rtb, ToolStripStatusLabel filenameStatusLabel)
        {
            openFileDialog.Filter = "All files (*.*)|*.*|Text Files(*.txt)|*.txt|RichText Files(*.rtf)|*.rtf";
            openFileDialog.FileName = "";

            rtb.SelectAll();
            rtb.SelectionBackColor = rtb.BackColor;
            rtb.DeselectAll();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;

                if (Path.GetExtension(filename) == ".rtf")
                {
                    rtb.LoadFile(filename, RichTextBoxStreamType.RichText);
                }
                else if (Path.GetExtension(filename) == ".txt")
                {
                    rtb.LoadFile(filename, RichTextBoxStreamType.PlainText);
                }

                string fname = filename.Substring(filename.LastIndexOf("\\") + 1);
                tabPage.Text = fname;

                tabControl.TabPages.Add(tabPage);
                tabControl.SelectedTab = tabPage;

                fname = tabPage.Text;
                if (fname.Contains("*"))
                {
                    fname = fname.Remove(fname.Length - 1);
                }
                tabPage.Text = fname;

                OpenedFilesList.Add(filename);
                filenameStatusLabel.Text = filename;

                if (tabControl.SelectedIndex >= 0)
                {
                    var _myRichTextBox = (MyRichTextBox)tabControl.TabPages[tabControl.SelectedIndex].Controls[0];
                    _myRichTextBox.richTextBoxPlus.Select();
                }
            }
        }

        public static void FileSave()
        {

        }

        public static void FileSaveAs()
        {

        }

        public static void FileSaveAll()
        {

        }

        public static void FileClose()
        {

        }

        public static void FileCloseAll()
        {

        }
    }
}
