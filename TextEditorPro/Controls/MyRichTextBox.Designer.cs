namespace TextEditorPro.Controls
{
    partial class MyRichTextBox
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            LineNumberTextBox = new RichTextBox();
            richTextBoxPlus = new RichTextBoxPlus();
            SuspendLayout();
            // 
            // LineNumberTextBox
            // 
            LineNumberTextBox.BackColor = Color.FromArgb(64, 64, 64);
            LineNumberTextBox.BorderStyle = BorderStyle.None;
            LineNumberTextBox.Dock = DockStyle.Left;
            LineNumberTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LineNumberTextBox.ForeColor = SystemColors.Window;
            LineNumberTextBox.Location = new Point(0, 0);
            LineNumberTextBox.Name = "LineNumberTextBox";
            LineNumberTextBox.ReadOnly = true;
            LineNumberTextBox.ScrollBars = RichTextBoxScrollBars.None;
            LineNumberTextBox.Size = new Size(30, 237);
            LineNumberTextBox.TabIndex = 0;
            LineNumberTextBox.Text = "";
            LineNumberTextBox.MouseDown += LineNumberTextBox_MouseDown;
            // 
            // richTextBoxPlus
            // 
            richTextBoxPlus.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxPlus.Dock = DockStyle.Fill;
            richTextBoxPlus.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxPlus.ForeColor = SystemColors.Window;
            richTextBoxPlus.Location = new Point(30, 0);
            richTextBoxPlus.Name = "richTextBoxPlus";
            richTextBoxPlus.Size = new Size(267, 237);
            richTextBoxPlus.TabIndex = 1;
            richTextBoxPlus.Text = "";
            richTextBoxPlus.SelectionChanged += richTextBoxPlus_SelectionChanged;
            richTextBoxPlus.VScroll += richTextBoxPlus_VScroll;
            richTextBoxPlus.FontChanged += richTextBoxPlus_FontChanged;
            richTextBoxPlus.TextChanged += richTextBoxPlus_TextChanged;
            // 
            // MyRichTextBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(richTextBoxPlus);
            Controls.Add(LineNumberTextBox);
            Name = "MyRichTextBox";
            Size = new Size(297, 237);
            Load += MyRichTextBox_Load;
            Resize += MyRichTextBox_Resize;
            ResumeLayout(false);
        }

        #endregion
        public RichTextBox LineNumberTextBox;
        public RichTextBoxPlus richTextBoxPlus;
    }
}
