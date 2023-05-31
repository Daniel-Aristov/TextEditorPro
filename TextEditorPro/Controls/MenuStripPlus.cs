namespace TextEditorPro.Controls
{
    public partial class MenuStripPlus : MenuStrip
    {
        public MenuStripPlus()
        {
            this.Renderer = new CustomMenuRenderer();
        }
    }

    public class CustomMenuRenderer : ToolStripRenderer
    {   
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            base.OnRenderMenuItemBackground(e);

            if (e.Item.Enabled)
            {
                if (e.Item.IsOnDropDown == false && e.Item.Selected)
                {
                    var rect = new Rectangle(2, 2, e.Item.Width - 5, e.Item.Height);
                    Brush brushBg = new System.Drawing.Drawing2D.LinearGradientBrush(e.Item.ContentRectangle, Color.FromArgb(255, 255, 255, 255), Color.FromArgb(255, 120, 200, 255), 90);
                    e.Graphics.FillRectangle(brushBg, rect);
                    e.Item.ForeColor = Color.Black;
                }
                else if (e.Item.IsOnDropDown && e.Item.Selected)
                {
                    var rect = new Rectangle(3, 1, e.Item.Width - 4, e.Item.Height - 2);
                    Brush brushBg = new System.Drawing.Drawing2D.LinearGradientBrush(e.Item.ContentRectangle, Color.FromArgb(255, 255, 255, 255), Color.FromArgb(255, 120, 200, 255), 90);
                    e.Graphics.FillRectangle(brushBg, rect);
                    e.Item.ForeColor = Color.Black;
                }
                else e.Item.ForeColor = Color.White;
            }
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            base.OnRenderSeparator(e);

            var WhiteLine = new SolidBrush(Color.FromArgb(200, 200, 200));
            var rect = new Rectangle(30, 3, e.Item.Width - 32, 1);
            e.Graphics.FillRectangle(WhiteLine, rect);
        }

        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            base.OnRenderImageMargin(e);

            var rect = new Rectangle(0, 0, e.ToolStrip.Width, e.ToolStrip.Height);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(64, 64, 64)), rect); ;

            var DarkLine = new SolidBrush(Color.FromArgb(163, 163, 163));
            var rect2 = new Rectangle(1, 2, 24, e.AffectedBounds.Height);
            e.Graphics.FillRectangle(DarkLine, rect2);

            var rect3 = new Rectangle(0, 0, e.ToolStrip.Width - 1, e.ToolStrip.Height - 1);
            e.Graphics.DrawRectangle(new Pen(Brushes.DarkGray), rect3);
        }
    }
}
