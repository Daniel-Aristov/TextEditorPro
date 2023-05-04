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
            tabControlPlus.TabPages.Add(tabpage);
            tabControlPlus.SelectedTab = tabpage;

            var _myRichTextBox = (MyRichTextBox)tabControlPlus.TabPages[tabControlPlus.SelectedIndex].Controls[0];
            _myRichTextBox.richTextBoxPlus.Select();
            FilenameStatusLabel.Text = tabpage.Text;
            count++;
        }

        private void OpenFile_MenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "Text Files(*.txt)|*.txt|RichText Files(*.rtf)|*.rtf|All files (*.*)|*.*";
            OpenFileDialog.FileName = "";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = OpenFileDialog.FileName;

                TabPagePlus tabpage = new TabPagePlus(this);

                StreamReader strReader = new StreamReader(filename);
                tabpage._myRichTextBox.richTextBoxPlus.Text = strReader.ReadToEnd();
                strReader.Close();

                string fname = filename.Substring(filename.LastIndexOf("\\") + 1);
                tabpage.Text = fname;

                tabControlPlus.TabPages.Add(tabpage);
                tabControlPlus.SelectedTab = tabpage;

                fname = tabpage.Text;
                if (fname.Contains("*"))
                {
                    fname = fname.Remove(fname.Length - 1);
                }
                tabpage.Text = fname;

                OpenedFilesList.Add(filename);
                FilenameStatusLabel.Text = filename;

                if (tabControlPlus.SelectedIndex >= 0)
                {
                    var _myRichTextBox = (MyRichTextBox)tabControlPlus.TabPages[tabControlPlus.SelectedIndex].Controls[0];
                    _myRichTextBox.richTextBoxPlus.Select();
                }
            }
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
                        StreamWriter strwriter = File.AppendText(filename);
                        strwriter.Write(_myRichTextBox.richTextBoxPlus.Text);
                        strwriter.Close();
                        strwriter.Dispose();
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
                    SaveFileDialog.Filter = "Text Files(*.txt)|*.txt|RichText Files(*.rtf)|*.rtf|All files (*.*)|*.*";
                    SaveFileDialog.FileName = "";

                    var _myRichTextBox = (MyRichTextBox)tabControlPlus.TabPages[tabControlPlus.SelectedIndex].Controls[0];
                    
                    if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filename = SaveFileDialog.FileName;
                        if (filename != "")
                        {
                            File.WriteAllText(filename, "");
                            StreamWriter strw = new StreamWriter(filename);
                            strw.Write(_myRichTextBox.richTextBoxPlus.Text);
                            strw.Close();
                            strw.Dispose();

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

        private void SaveAsFile_toolStripButton_Click(object sender, EventArgs e)
        {
            SaveAsFile_MenuItem_Click(sender, e);
        }
    }
}