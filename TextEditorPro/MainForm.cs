using System.Windows.Forms;
using TextEditorPro.Controls;

namespace TextEditorPro
{
    public partial class MainForm : Form
    {
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
            FileWork.FileCloseAll(tabControlPlus, FilenameStatusLabel);
        }

        // MenuStrip
        private void NewFile_MenuItem_Click(object sender, EventArgs e)
        {
            TabPagePlus tabpage = new TabPagePlus(this);
            FileWork.FileNew(tabControlPlus, tabpage, FilenameStatusLabel);
        }

        private void OpenFile_MenuItem_Click(object sender, EventArgs e)
        {
            TabPagePlus tabpage = new TabPagePlus(this);
            RichTextBox rtb = tabpage._myRichTextBox.richTextBoxPlus;
            FileWork.FileOpen(tabControlPlus, tabpage, rtb, FilenameStatusLabel);
        }

        private void SaveFile_MenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabpage = tabControlPlus.SelectedTab;
            if (FilenameStatusLabel.Text.Contains("\\"))
            {
                FileWork.FileSave(tabControlPlus, tabpage, FilenameStatusLabel);
            }
            else
            {
                FileWork.FileSaveAs(tabControlPlus, tabpage, FilenameStatusLabel);
            }
        }

        private void SaveAsFile_MenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabpage = tabControlPlus.SelectedTab;
            FileWork.FileSaveAs(tabControlPlus, tabpage, FilenameStatusLabel);
        }

        private void SaveAll_MenuItem_Click(object sender, EventArgs e)
        {
            FileWork.FileSaveAll(tabControlPlus, FilenameStatusLabel);
        }

        private void CloseFile_MenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabpage = tabControlPlus.SelectedTab;
            FileWork.FileClose(tabControlPlus, tabpage, FilenameStatusLabel);

            LineToolStripLabel.Text = "Строка: 1";
            ColumnToolStripLabel.Text = "Колонка: 1";
        }

        private void tabControlPlus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileWork.TabControlSelectedIndexChanged(tabControlPlus, FilenameStatusLabel);
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

        // ToolStrip
        private void NewFile_toolStrip_Click(object sender, EventArgs e)
        {
            NewFile_MenuItem_Click(sender, e);
        }

        private void OpenFile_toolStrip_Click(object sender, EventArgs e)
        {
            OpenFile_MenuItem_Click(sender, e);
        }

        private void SaveFile_toolStrip_Click(object sender, EventArgs e)
        {
            SaveFile_MenuItem_Click(sender, e);
        }

        private void RegularStrip_Click(object sender, EventArgs e)
        {
            ViewEdit.FontStyleDefault(tabControlPlus);
        }

        private void BoldStrip_Click(object sender, EventArgs e)
        {
            ViewEdit.FontStyleEdit(tabControlPlus, FontStyle.Bold);
        }

        private void UnderlineStrip_Click(object sender, EventArgs e)
        {
            ViewEdit.FontStyleEdit(tabControlPlus, FontStyle.Underline);
        }

        private void CoursiveStrip_Click(object sender, EventArgs e)
        {
            ViewEdit.FontStyleEdit(tabControlPlus, FontStyle.Italic);
        }

        private void Copy_toolStrip_Click(object sender, EventArgs e)
        {
            Copy_MenuItem_Click(sender, e);
        }

        private void Cut_toolStrip_Click(object sender, EventArgs e)
        {
            Cut_MenuItem_Click(sender, e);
        }

        private void Paste_toolStrip_Click(object sender, EventArgs e)
        {
            Paste_MenuItem_Click(sender, e);
        }

        // About window
        private void About_MenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramBox aboutProgramBox = new AboutProgramBox();
            aboutProgramBox.Show();
        }
    }
}