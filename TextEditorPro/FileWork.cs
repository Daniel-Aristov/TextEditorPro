﻿using TextEditorPro.Controls;

namespace TextEditorPro
{
    public class FileWork
    {
        private static List<string> OpenedFilesList = new List<string> { };
        private static int count = 1;

        public static void FileNew(TabControl tabControl, TabPage tabPage, ToolStripStatusLabel filenameStatusLabel)
        {
            tabPage.Text = "Безымянный - " + count;
            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedTab = tabPage;

            var _myRichTextBox = (MyRichTextBox)tabControl.TabPages[tabControl.SelectedIndex].Controls[0];
            _myRichTextBox.richTextBoxPlus.Select();

            filenameStatusLabel.Text = tabPage.Text;
            count++;
        }

        public static void FileOpen(TabControl tabControl, TabPage tabPage, RichTextBox rtb, ToolStripStatusLabel filenameStatusLabel)
        {
            OpenFileDialog openFileDialog  = new OpenFileDialog();
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

        public static void FileSave(TabControl tabControl, TabPage tabPage, ToolStripStatusLabel filenameStatusLabel)
        {
            if (tabPage.Text.Contains("*"))
            {
                string filename = filenameStatusLabel.Text;
                if (File.Exists(filename))
                {
                    var _myRichTextBox = (MyRichTextBox)tabControl.TabPages[tabControl.SelectedIndex].Controls[0];
                    if (Path.GetExtension(filename) == ".rtf")
                    {
                        _myRichTextBox.richTextBoxPlus.SaveFile(filename, RichTextBoxStreamType.RichText);
                    }
                    else if (Path.GetExtension(filename) == ".txt")
                    {
                        _myRichTextBox.richTextBoxPlus.SaveFile(filename, RichTextBoxStreamType.PlainText);
                    }
                    tabPage.Text = tabPage.Text.Remove(tabPage.Text.Length - 1);
                }
            }
        }

        public static void FileSaveAs(TabControl tabControl, TabPage tabPage, ToolStripStatusLabel filenameStatusLabel)
        {
            if (tabControl.TabCount > 0)
            {
                if (tabPage != null)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text Files(*.txt)|*.txt|RichText Files(*.rtf)|*.rtf";
                    saveFileDialog.FileName = "";

                    var _myRichTextBox = (MyRichTextBox)tabControl.TabPages[tabControl.SelectedIndex].Controls[0];
                    _myRichTextBox.richTextBoxPlus.SelectAll();
                    _myRichTextBox.richTextBoxPlus.SelectionBackColor = _myRichTextBox.richTextBoxPlus.BackColor;
                    _myRichTextBox.richTextBoxPlus.DeselectAll();

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filename = saveFileDialog.FileName;
                        if (filename != "")
                        {
                            if (Path.GetExtension(filename) == ".rtf")
                            {
                                _myRichTextBox.richTextBoxPlus.SaveFile(filename, RichTextBoxStreamType.RichText);
                            }
                            else if (Path.GetExtension(filename) == ".txt")
                            {
                                _myRichTextBox.richTextBoxPlus.SaveFile(filename, RichTextBoxStreamType.PlainText);
                            }

                            string fname = filename.Substring(filename.LastIndexOf("\\") + 1);
                            tabPage.Text = fname;
                            filenameStatusLabel.Text = filename;
                            OpenedFilesList.Add(filename);
                        }
                    }
                }
            }
        }

        public static void FileSaveAll(TabControl tabControl, ToolStripStatusLabel filenameStatusLabel)
        {
            if (tabControl.TabCount > 0)
            {
                TabControl.TabPageCollection tabcoll = tabControl.TabPages;

                foreach (TabPage tabpage in tabcoll)
                {
                    tabControl.SelectedTab = tabpage;
                    TabControlSelectedIndexChanged(tabControl, filenameStatusLabel);

                    if (!tabpage.Text.Contains("Безымянный"))
                    {
                        try
                        {
                            FileSave(tabControl, tabpage, filenameStatusLabel);

                            string str = tabpage.Text;
                            if (str.Contains("*"))
                            {
                                str = str.Remove(str.Length - 1);
                            }
                            tabpage.Text = str;
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка! Сохранение не удалось!");
                        }
                    } else
                    {
                        try
                        {
                            SaveFileDialog saveFileDialog = new SaveFileDialog();
                            saveFileDialog.Filter = "All files (*.*)|*.*|Text Files(*.txt)|*.txt|RichText Files(*.rtf)|*.rtf";
                            saveFileDialog.FileName = "";
                            FileSaveAs(tabControl, tabpage, filenameStatusLabel);
                            
                            string str = tabpage.Text;
                            if (str.Contains("*"))
                            {
                                str = str.Remove(str.Length - 1);
                            }
                            tabpage.Text = str;
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка! Сохранение не удалось!");
                        }
                    }
                }
            }
        }

        public static void FileClose(TabControl tabControl, TabPage tabpage, ToolStripStatusLabel filenameStatusLabel)
        {
            if (tabControl.TabCount > 0)
            {
                if (tabpage.Text.Contains("*"))
                {
                    DialogResult dg = MessageBox.Show("Вы хотите сохранить файл " + tabpage.Text + " перед закрытием?", "Сохранение файла", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                    {
                        FileSave(tabControl, tabpage, filenameStatusLabel);
                        tabControl.TabPages.Remove(tabpage);
                        TabControlSelectedIndexChanged(tabControl, filenameStatusLabel);

                        if (tabControl.TabCount == 0)
                        {
                            filenameStatusLabel.Text = "";
                            count = 1;
                        }
                    }
                    else
                    {
                        tabControl.TabPages.Remove(tabpage);
                        TabControlSelectedIndexChanged(tabControl, filenameStatusLabel);

                        if (tabControl.TabCount == 0)
                        {
                            filenameStatusLabel.Text = "";
                            count = 1;
                        }
                    }
                }
                else
                {
                    tabControl.TabPages.Remove(tabpage);
                    TabControlSelectedIndexChanged(tabControl, filenameStatusLabel);

                    if (tabControl.TabCount == 0)
                    {
                        count = 1;
                        filenameStatusLabel.Text = "";
                    }
                }

                tabControl.SelectedIndex = tabControl.TabPages.Count - 1;
            }
            else
            {
                count = 1;
                filenameStatusLabel.Text = "";
            }
        }

        public static void FileCloseAll(TabControl tabControl, ToolStripStatusLabel filenameStatusLabel)
        {
            if (tabControl.TabCount > 0)
            {
                TabControl.TabPageCollection tabcoll = tabControl.TabPages;
                foreach (TabPage tabpage in tabcoll)
                {
                    tabControl.SelectedTab = tabpage;
                    if (tabpage.Text.Contains("*"))
                    {
                        DialogResult dg = MessageBox.Show("Вы хотите сохранить файл " + tabpage.Text + " перед закрытием?", "Сохранение файла", MessageBoxButtons.YesNoCancel);
                        if (dg == DialogResult.Yes)
                        {
                            FileSave(tabControl, tabpage, filenameStatusLabel);
                            tabControl.TabPages.Remove(tabpage);
                            TabControlSelectedIndexChanged(tabControl, filenameStatusLabel);
                        }
                    }
                    else
                    {
                        tabControl.TabPages.Remove(tabpage);
                        TabControlSelectedIndexChanged(tabControl, filenameStatusLabel);
                    }
                }
            }
        }

        public static void TabControlSelectedIndexChanged(TabControl tabControl, ToolStripStatusLabel filenameStatusLabel)
        {
            if (tabControl.TabCount > 0)
            {
                TabPage tabpage = tabControl.SelectedTab;
                if (tabpage.Text.Contains("Безымянный"))
                {
                    filenameStatusLabel.Text = tabpage.Text;
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
                                    filenameStatusLabel.Text = filename;
                                }
                            }
                            else
                            {
                                if (str == tabpage.Text)
                                {
                                    filenameStatusLabel.Text = filename;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                filenameStatusLabel.Text = "";
            }
        }
    }
}
