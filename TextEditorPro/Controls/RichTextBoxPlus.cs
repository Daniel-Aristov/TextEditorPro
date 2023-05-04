namespace TextEditorPro.Controls
{
    public partial class RichTextBoxPlus : RichTextBox
    {
        public RichTextBoxPlus()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnSelectionChanged(EventArgs e)
        {
            base.OnSelectionChanged(e);
            this.Invalidate();
        }

        int lineh = 15;
        const int wm_paint = 15;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == wm_paint)
            {
                var selectlength = this.SelectionLength;
                var selectstart = this.SelectionStart;
                this.Invalidate();
                base.WndProc(ref m);
                if (selectlength > 0)
                {
                    return;
                }
                using (Graphics g = Graphics.FromHwnd(this.Handle))
                {
                    Brush b = new SolidBrush(Color.FromArgb(50, Color.FromArgb(140, 220, 160)));
                    int fntsize = (int)this.Font.Size;
                    var line = this.GetLineFromCharIndex(selectstart);
                    var loc = this.GetPositionFromCharIndex(this.GetFirstCharIndexFromLine(line));
                    g.FillRectangle(b, new Rectangle(loc, new Size(this.Width, lineh + fntsize - 3)));
                }
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
}
