namespace TextEditorPro.Controls
{
    public partial class TabPagePlus : TabPage
    {
        public MainForm mainform;
        public MyRichTextBox _myRichTextBox = new MyRichTextBox();

        public TabPagePlus(MainForm mf)
        {
            mainform = mf;
            _myRichTextBox.Dock = DockStyle.Fill;
            _myRichTextBox.richTextBoxPlus.Text = "";
            _myRichTextBox.richTextBoxPlus.Font = new Font("Arial", 14, FontStyle.Regular);
            _myRichTextBox.richTextBoxPlus.Select();
            _myRichTextBox.richTextBoxPlus.TextChanged += new EventHandler(richTextBoxPlus_TextChanged);
            _myRichTextBox.richTextBoxPlus.SelectionChanged += new EventHandler(richTextBoxPlus_SelectionChanged);
            Controls.Add(_myRichTextBox);
        }

        private void richTextBoxPlus_TextChanged(object sender, EventArgs e)
        {
            string str = Text;
            if (str.Contains("*")) {}
            else Text = str + "*";
        }

        private void richTextBoxPlus_SelectionChanged(object sender, EventArgs e)
        {
            int selection = _myRichTextBox.richTextBoxPlus.SelectionStart;
            int line = _myRichTextBox.richTextBoxPlus.GetLineFromCharIndex(selection) + 1;
            int col = selection - _myRichTextBox.richTextBoxPlus.GetFirstCharIndexFromLine(line - 1) + 1;

            mainform.LineToolStripLabel.Text = "Строка: " + line.ToString();
            mainform.ColumnToolStripLabel.Text = "Колонка: " + col.ToString();
        }
    }
}
