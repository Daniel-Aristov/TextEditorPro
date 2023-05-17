using System.Windows.Forms;
using TextEditorPro.Controls;

namespace TextEditorPro
{
    public partial class MainForm : Form
    {
        public static List<string> OpenedFilesList = new List<string> { };

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NewFile_MenuItem_Click(sender, e);
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (tabControlPlus.TabCount > 0)
            {
                TabControl.TabPageCollection tabcoll = tabControlPlus.TabPages;
                foreach (TabPage tabpage in tabcoll)
                {
                    tabControlPlus.SelectedTab = tabpage;
                    if (tabpage.Text.Contains("*"))
                    {
                        DialogResult dg = MessageBox.Show("Вы хотите сохранить файл " + tabpage.Text + " перед закрытием?", "Сохранение файла", MessageBoxButtons.YesNoCancel);
                        if (dg == DialogResult.Yes)
                        {
                            SaveFile_MenuItem_Click(sender, e);
                            tabControlPlus.TabPages.Remove(tabpage);
                            tabControlPlus_SelectedIndexChanged(sender, e);
                        }
                        else if (dg == DialogResult.Cancel)
                        {
                            e.Cancel = true;
                            tabControlPlus.Select();
                            break;
                        }
                    }
                    else
                    {
                        tabControlPlus.TabPages.Remove(tabpage);
                        tabControlPlus_SelectedIndexChanged(sender, e);
                    }
                }
            }
        }

        public static int count = 1;
        private void NewFile_MenuItem_Click(object sender, EventArgs e)
        {
            TabPagePlus tabpage = new TabPagePlus(this);
            tabpage.Text = "Безымянный - " + count;
            FileWork.FileNew(tabControlPlus, tabpage);
            FilenameStatusLabel.Text = tabpage.Text;
            count++;
        }

        private void OpenFile_MenuItem_Click(object sender, EventArgs e)
        {
            TabPagePlus tabpage = new TabPagePlus(this);
            RichTextBox rtb = tabpage._myRichTextBox.richTextBoxPlus;
            FileWork.FileOpen(tabControlPlus, tabpage, OpenFileDialog, rtb, FilenameStatusLabel);
            //OpenFileDialog.Filter = "All files (*.*)|*.*|Text Files(*.txt)|*.txt|RichText Files(*.rtf)|*.rtf";
            //OpenFileDialog.FileName = "";

            //TabPagePlus tabpage = new TabPagePlus(this);
            //tabpage._myRichTextBox.richTextBoxPlus.SelectAll();
            //tabpage._myRichTextBox.richTextBoxPlus.SelectionBackColor = tabpage._myRichTextBox.richTextBoxPlus.BackColor;
            //tabpage._myRichTextBox.richTextBoxPlus.DeselectAll();

            //if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string filename = OpenFileDialog.FileName;

            //    if (Path.GetExtension(filename) == ".rtf")
            //    {
            //        tabpage._myRichTextBox.richTextBoxPlus.LoadFile(filename, RichTextBoxStreamType.RichText);
            //    }
            //    else if (Path.GetExtension(filename) == ".txt")
            //    {
            //        tabpage._myRichTextBox.richTextBoxPlus.LoadFile(filename, RichTextBoxStreamType.PlainText);
            //    }

            //    string fname = filename.Substring(filename.LastIndexOf("\\") + 1);
            //    tabpage.Text = fname;

            //    tabControlPlus.TabPages.Add(tabpage);
            //    tabControlPlus.SelectedTab = tabpage;

            //    fname = tabpage.Text;
            //    if (fname.Contains("*"))
            //    {
            //        fname = fname.Remove(fname.Length - 1);
            //    }
            //    tabpage.Text = fname;

            //    OpenedFilesList.Add(filename);
            //    FilenameStatusLabel.Text = filename;

            //    if (tabControlPlus.SelectedIndex >= 0)
            //    {
            //        var _myRichTextBox = (MyRichTextBox)tabControlPlus.TabPages[tabControlPlus.SelectedIndex].Controls[0];
            //        _myRichTextBox.richTextBoxPlus.Select();
            //    }
            //}
        }

        private void SaveFile_MenuItem_Click(object sender, EventArgs e)
        {
            if (FilenameStatusLabel.Text.Contains("\\"))
            {
                TabPage tabpage = tabControlPlus.SelectedTab;
                if (tabpage.Text.Contains("*"))
                {
                    string filename = FilenameStatusLabel.Text;
                    if (File.Exists(filename))
                    {
                        var _myRichTextBox = (MyRichTextBox)tabControlPlus.TabPages[tabControlPlus.SelectedIndex].Controls[0];
                        File.WriteAllText(filename, "");
                        
                        if (Path.GetExtension(filename) == ".rtf")
                        {
                            _myRichTextBox.richTextBoxPlus.SaveFile(filename, RichTextBoxStreamType.RichText);
                        }
                        else if (Path.GetExtension(filename) == ".txt")
                        {
                            _myRichTextBox.richTextBoxPlus.SaveFile(filename, RichTextBoxStreamType.PlainText);
                        }

                        tabpage.Text = tabpage.Text.Remove(tabpage.Text.Length - 1);
                    }
                }
            }
            else
            {
                SaveAsFile_MenuItem_Click(sender, e);
            }
        }

        private void SaveAsFile_MenuItem_Click(object sender, EventArgs e)
        {
            if (tabControlPlus.TabCount > 0)
            {
                TabPage tabpage = tabControlPlus.SelectedTab;
                if (tabpage != null)
                {
                    SaveFileDialog.Filter = "All files (*.*)|*.*|Text Files(*.txt)|*.txt|RichText Files(*.rtf)|*.rtf";
                    SaveFileDialog.FileName = "";

                    var _myRichTextBox = (MyRichTextBox)tabControlPlus.TabPages[tabControlPlus.SelectedIndex].Controls[0];
                    _myRichTextBox.richTextBoxPlus.SelectAll();
                    _myRichTextBox.richTextBoxPlus.SelectionBackColor = _myRichTextBox.richTextBoxPlus.BackColor;
                    _myRichTextBox.richTextBoxPlus.DeselectAll();

                    if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filename = SaveFileDialog.FileName;
                        if (filename != "")
                        {
                            File.WriteAllText(filename, "");

                            if (Path.GetExtension(filename) == ".rtf")
                            {
                                _myRichTextBox.richTextBoxPlus.SaveFile(filename, RichTextBoxStreamType.RichText);
                            }
                            else if (Path.GetExtension(filename) == ".txt")
                            {
                                _myRichTextBox.richTextBoxPlus.SaveFile(filename, RichTextBoxStreamType.PlainText);
                            }

                            string fname = filename.Substring(filename.LastIndexOf("\\") + 1);
                            tabpage.Text = fname;
                            FilenameStatusLabel.Text = filename;

                            OpenedFilesList.Add(filename);
                        }
                    }
                }
            }
        }

        private void SaveAll_MenuItem_Click(object sender, EventArgs e)
        {
            if (tabControlPlus.TabCount > 0)
            {
                OpenedFilesList.Reverse();
                TabControl.TabPageCollection tabcoll = tabControlPlus.TabPages;

                foreach (TabPage tabpage in tabcoll)
                {
                    tabControlPlus.SelectedTab = tabpage;
                    tabControlPlus_SelectedIndexChanged(sender, e);

                    if (!tabpage.Text.Contains("Безымянный"))
                    {
                        try
                        {
                            var _myRichTextBox = (MyRichTextBox)tabControlPlus.TabPages[tabControlPlus.SelectedIndex].Controls[0];
                            File.WriteAllText(FilenameStatusLabel.Text, "");
                            StreamWriter strwriter = File.AppendText(FilenameStatusLabel.Text);
                            strwriter.Write(_myRichTextBox.richTextBoxPlus.Text);
                            strwriter.Close();
                            strwriter.Dispose();
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка! Сохранение не удалось!");
                        }
                    }
                }

                TabControl.TabPageCollection tabcollection = tabControlPlus.TabPages;
                foreach (TabPage tabpage in tabcollection)
                {
                    string str = tabpage.Text;
                    if (str.Contains("*") && !str.Contains("Безымянный"))
                    {
                        str = str.Remove(str.Length - 1);
                    }
                    tabpage.Text = str;
                }
            }
        }

        private void CloseFile_MenuItem_Click(object sender, EventArgs e)
        {
            if (tabControlPlus.TabCount > 0)
            {
                TabPage tabpage = tabControlPlus.SelectedTab;
                if (tabpage.Text.Contains("*"))
                {
                    DialogResult dg = MessageBox.Show("Вы хотите сохранить файл " + tabpage.Text + " перед закрытием?", "Сохранение файла", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                    {
                        SaveFile_MenuItem_Click(sender, e);
                        tabControlPlus.TabPages.Remove(tabpage);

                        tabControlPlus_SelectedIndexChanged(sender, e);

                        LineToolStripLabel.Text = "Строка: 1";
                        ColumnToolStripLabel.Text = "Колонка: 1";

                        if (tabControlPlus.TabCount == 0)
                        {
                            FilenameStatusLabel.Text = "";
                            count = 1;
                        }
                    }
                    else
                    {
                        tabControlPlus.TabPages.Remove(tabpage);
                        tabControlPlus_SelectedIndexChanged(sender, e);

                        LineToolStripLabel.Text = "Строка: 1";
                        ColumnToolStripLabel.Text = "Колонка: 1";

                        if (tabControlPlus.TabCount == 0)
                        {
                            FilenameStatusLabel.Text = "";
                            count = 1;
                        }
                    }
                }
                else
                {
                    tabControlPlus.TabPages.Remove(tabpage);
                    tabControlPlus_SelectedIndexChanged(sender, e);

                    LineToolStripLabel.Text = "Строка: 1";
                    ColumnToolStripLabel.Text = "Колонка: 1";

                    if (tabControlPlus.TabCount == 0)
                    {
                        FilenameStatusLabel.Text = "";
                        count = 1;
                    }
                }

                if (tabControlPlus.SelectedIndex >= 0)
                {
                    var _myRichTextBox = (MyRichTextBox)tabControlPlus.TabPages[tabControlPlus.SelectedIndex].Controls[0];
                    _myRichTextBox.richTextBoxPlus.Select();
                }

            }
            else
            {
                count = 1;
                FilenameStatusLabel.Text = "";

                LineToolStripLabel.Text = "Строка: 1";
                ColumnToolStripLabel.Text = "Колонка: 1";
            }
        }

        private void CloseAll_MenuItem_Click(object sender, EventArgs e)
        {
            if (tabControlPlus.TabCount > 0)
            {
                TabControl.TabPageCollection tabcoll = tabControlPlus.TabPages;
                foreach (TabPage tabpage in tabcoll)
                {
                    tabControlPlus.SelectedTab = tabpage;

                    if (tabpage.Text.Contains("*"))
                    {
                        DialogResult dg = MessageBox.Show("Вы хотите сохранить файл " + tabpage.Text + " перед закрытием?", "Сохранение файла", MessageBoxButtons.YesNo);
                        if (dg == DialogResult.Yes)
                        {
                            SaveFile_MenuItem_Click(sender, e);
                            tabControlPlus.TabPages.Remove(tabpage);
                            tabControlPlus_SelectedIndexChanged(sender, e);

                            LineToolStripLabel.Text = "Строка: 1";
                            ColumnToolStripLabel.Text = "Колонка: 1";

                            if (tabControlPlus.TabCount == 0)
                            {
                                count = 1;
                            }
                        }
                        else
                        {
                            tabControlPlus.TabPages.Remove(tabpage);
                            tabControlPlus_SelectedIndexChanged(sender, e);

                            LineToolStripLabel.Text = "Строка: 1";
                            ColumnToolStripLabel.Text = "Колонка: 1";

                            if (tabControlPlus.TabCount == 0)
                            {
                                count = 1;
                            }
                        }
                    }
                    else
                    {
                        tabControlPlus.TabPages.Remove(tabpage);
                        tabControlPlus_SelectedIndexChanged(sender, e);

                        LineToolStripLabel.Text = "Строка: 1";
                        ColumnToolStripLabel.Text = "Колонка: 1";

                        if (tabControlPlus.TabCount == 0)
                        {
                            count = 1;
                        }
                    }
                }
            }
            else
            {
                count = 1;
                FilenameStatusLabel.Text = "";

                LineToolStripLabel.Text = "Строка: 1";
                ColumnToolStripLabel.Text = "Колонка: 1";
            }
        }

        private void Exit_MenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FontChange_MenuItem_Click(object sender, EventArgs e)
        {
            ViewEdit.FontEdit(tabControlPlus);
        }

        private void FontColor_MenuItem_Click(object sender, EventArgs e)
        {
            ViewEdit.FontColorEdit(tabControlPlus);
        }

        private void BackColor_MenuItem_Click(object sender, EventArgs e)
        {
            ViewEdit.BackColorEdit(tabControlPlus);
        }

        private void BoldStripButton_Click(object sender, EventArgs e)
        {
            ViewEdit.FontStyleEdit(tabControlPlus, FontStyle.Bold);
        }

        private void UnderlineStripButton_Click(object sender, EventArgs e)
        {
            ViewEdit.FontStyleEdit(tabControlPlus, FontStyle.Underline);
        }

        private void CoursiveStripButton_Click(object sender, EventArgs e)
        {
            ViewEdit.FontStyleEdit(tabControlPlus, FontStyle.Italic);
        }

        private void RegularStripButton_Click(object sender, EventArgs e)
        {
            ViewEdit.FontStyleDefault(tabControlPlus);
        }

        private void tabControlPlus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPlus.TabCount > 0)
            {
                TabPage tabpage = tabControlPlus.SelectedTab;
                if (tabpage.Text.Contains("Безымянный"))
                {
                    FilenameStatusLabel.Text = tabpage.Text;
                }
                else
                {
                    foreach (string filename in OpenedFilesList)
                    {
                        if (tabpage != null)
                        {
                            string str = filename.Substring(filename.LastIndexOf("\\") + 1);
                            if (tabpage.Text.Contains("*"))
                            {
                                string str2 = tabpage.Text.Remove(tabpage.Text.Length - 1);
                                if (str == str2)
                                {
                                    FilenameStatusLabel.Text = filename;
                                }
                            }

                            else
                            {
                                if (str == tabpage.Text)
                                {
                                    FilenameStatusLabel.Text = filename;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                FilenameStatusLabel.Text = "";
            }
        }

        private void Copy_MenuItem_Click(object sender, EventArgs e)
        {
            TextEdit.CopySelectText(tabControlPlus);
        }

        private void Cut_MenuItem_Click(object sender, EventArgs e)
        {
            TextEdit.CutSelectText(tabControlPlus);
        }

        private void Paste_MenuItem_Click(object sender, EventArgs e)
        {
            TextEdit.PasteSelectText(tabControlPlus);
        }

        private void NewFile_toolStripButton_Click_1(object sender, EventArgs e)
        {
            NewFile_MenuItem_Click(sender, e);
        }

        private void OpenFile_toolStripButton_Click(object sender, EventArgs e)
        {
            OpenFile_MenuItem_Click(sender, e);
        }

        private void SaveFile_toolStripButton_Click(object sender, EventArgs e)
        {
            SaveFile_MenuItem_Click(sender, e);
        }

        private void Copy_toolStripButton_Click(object sender, EventArgs e)
        {
            Copy_MenuItem_Click(sender, e);
        }

        private void Cut_toolStripButton_Click(object sender, EventArgs e)
        {
            Cut_MenuItem_Click(sender, e);
        }

        private void Paste_toolStripButton_Click(object sender, EventArgs e)
        {
            Paste_MenuItem_Click(sender, e);
        }

        private void About_MenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramBox aboutProgramBox = new AboutProgramBox();
            aboutProgramBox.Show();
        }
    }
}