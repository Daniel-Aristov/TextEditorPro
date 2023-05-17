namespace TextEditorPro.Controls
{
    public partial class TabPagePlus : TabPage
    {
        public MainForm mainform;
        public MyRichTextBox _myRichTextBox = new MyRichTextBox();

        public TabPagePlus(MainForm mf)
        {
            mainform = mf;

            this._myRichTextBox.Dock = DockStyle.Fill;
            this._myRichTextBox.richTextBoxPlus.Text = "";
            _myRichTextBox.richTextBoxPlus.Font = new Font("Arial", 14, FontStyle.Regular);
            this._myRichTextBox.richTextBoxPlus.Select();

            _myRichTextBox.richTextBoxPlus.TextChanged += new EventHandler(this.richTextBoxPlus_TextChanged);
            _myRichTextBox.richTextBoxPlus.SelectionChanged += new EventHandler(this.richTextBoxPlus_SelectionChanged);

            this.Controls.Add(_myRichTextBox);
        }

        private void richTextBoxPlus_TextChanged(object sender, EventArgs e)
        {
            string str = this.Text;
            if (str.Contains("*")) {}
            else this.Text = str + "*";
        }

        private void richTextBoxPlus_SelectionChanged(object sender, EventArgs e)
        {
            int sel = _myRichTextBox.richTextBoxPlus.SelectionStart;
            int line = _myRichTextBox.richTextBoxPlus.GetLineFromCharIndex(sel) + 1;
            int col = sel - _myRichTextBox.richTextBoxPlus.GetFirstCharIndexFromLine(line - 1) + 1;

            mainform.LineToolStripLabel.Text = "Строка: " + line.ToString();
            mainform.ColumnToolStripLabel.Text = "Колонка: " + col.ToString();
        }
    }
}
