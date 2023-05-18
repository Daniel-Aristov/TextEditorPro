namespace TextEditorPro
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            TopMenu = new Controls.MenuStripPlus();
            файлToolStripMenuItem = new ToolStripMenuItem();
            NewFile_MenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            OpenFile_MenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            SaveFile_MenuItem = new ToolStripMenuItem();
            SaveAsFile_MenuItem = new ToolStripMenuItem();
            SaveAll_MenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            CloseFile_MenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            Close_MenuItem = new ToolStripMenuItem();
            правкаToolStripMenuItem = new ToolStripMenuItem();
            Copy_MenuItem = new ToolStripMenuItem();
            Cut_MenuItem = new ToolStripMenuItem();
            Paste_MenuItem = new ToolStripMenuItem();
            ForeColor_MenuItem = new ToolStripMenuItem();
            FontChange_MenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            FontColor_MenuItem = new ToolStripMenuItem();
            BackColor_MenuItem = new ToolStripMenuItem();
            About_MenuItem = new ToolStripMenuItem();
            tabControlPlus = new Controls.TabControlPlus();
            OpenFileDialog = new OpenFileDialog();
            SaveFileDialog = new SaveFileDialog();
            StatusStrip = new StatusStrip();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            FilenameStatusLabel = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            LineToolStripLabel = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            ColumnToolStripLabel = new ToolStripStatusLabel();
            ToolStripPlus = new Controls.ToolStripPlus();
            NewFile_toolStripButton = new ToolStripButton();
            OpenFile_toolStripButton = new ToolStripButton();
            SaveFile_toolStripButton = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            RegularStripButton = new ToolStripButton();
            BoldStripButton = new ToolStripButton();
            UnderlineStripButton = new ToolStripButton();
            CoursiveStripButton = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            Copy_toolStripButton = new ToolStripButton();
            Cut_toolStripButton = new ToolStripButton();
            Paste_toolStripButton = new ToolStripButton();
            panel1 = new Panel();
            TopMenu.SuspendLayout();
            StatusStrip.SuspendLayout();
            ToolStripPlus.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TopMenu
            // 
            TopMenu.BackColor = Color.FromArgb(64, 64, 64);
            TopMenu.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TopMenu.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, правкаToolStripMenuItem, ForeColor_MenuItem, About_MenuItem });
            TopMenu.Location = new Point(0, 0);
            TopMenu.Name = "TopMenu";
            TopMenu.Size = new Size(885, 25);
            TopMenu.TabIndex = 0;
            TopMenu.Text = "Основное меню";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewFile_MenuItem, toolStripSeparator1, OpenFile_MenuItem, toolStripSeparator2, SaveFile_MenuItem, SaveAsFile_MenuItem, SaveAll_MenuItem, toolStripSeparator3, CloseFile_MenuItem, toolStripSeparator4, Close_MenuItem });
            файлToolStripMenuItem.ForeColor = Color.White;
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(55, 21);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // NewFile_MenuItem
            // 
            NewFile_MenuItem.ForeColor = Color.White;
            NewFile_MenuItem.Image = Properties.Resources._001_add_folder;
            NewFile_MenuItem.Name = "NewFile_MenuItem";
            NewFile_MenuItem.ShortcutKeys = Keys.Control | Keys.N;
            NewFile_MenuItem.Size = new Size(262, 22);
            NewFile_MenuItem.Text = "Новый";
            NewFile_MenuItem.Click += NewFile_MenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(259, 6);
            // 
            // OpenFile_MenuItem
            // 
            OpenFile_MenuItem.ForeColor = Color.White;
            OpenFile_MenuItem.Image = Properties.Resources._003_open_folder;
            OpenFile_MenuItem.Name = "OpenFile_MenuItem";
            OpenFile_MenuItem.ShortcutKeys = Keys.Control | Keys.O;
            OpenFile_MenuItem.Size = new Size(262, 22);
            OpenFile_MenuItem.Text = "Открыть файл...";
            OpenFile_MenuItem.Click += OpenFile_MenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(259, 6);
            // 
            // SaveFile_MenuItem
            // 
            SaveFile_MenuItem.ForeColor = Color.White;
            SaveFile_MenuItem.Image = Properties.Resources._002_diskette;
            SaveFile_MenuItem.Name = "SaveFile_MenuItem";
            SaveFile_MenuItem.ShortcutKeys = Keys.Control | Keys.S;
            SaveFile_MenuItem.Size = new Size(262, 22);
            SaveFile_MenuItem.Text = "Сохранить";
            SaveFile_MenuItem.Click += SaveFile_MenuItem_Click;
            // 
            // SaveAsFile_MenuItem
            // 
            SaveAsFile_MenuItem.ForeColor = Color.White;
            SaveAsFile_MenuItem.Name = "SaveAsFile_MenuItem";
            SaveAsFile_MenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.S;
            SaveAsFile_MenuItem.Size = new Size(262, 22);
            SaveAsFile_MenuItem.Text = "Сохранить как...";
            SaveAsFile_MenuItem.Click += SaveAsFile_MenuItem_Click;
            // 
            // SaveAll_MenuItem
            // 
            SaveAll_MenuItem.ForeColor = Color.White;
            SaveAll_MenuItem.Name = "SaveAll_MenuItem";
            SaveAll_MenuItem.Size = new Size(262, 22);
            SaveAll_MenuItem.Text = "Сохранить все";
            SaveAll_MenuItem.Click += SaveAll_MenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(259, 6);
            // 
            // CloseFile_MenuItem
            // 
            CloseFile_MenuItem.ForeColor = Color.White;
            CloseFile_MenuItem.Name = "CloseFile_MenuItem";
            CloseFile_MenuItem.ShortcutKeys = Keys.Control | Keys.W;
            CloseFile_MenuItem.Size = new Size(262, 22);
            CloseFile_MenuItem.Text = "Закрыть файл";
            CloseFile_MenuItem.Click += CloseFile_MenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(259, 6);
            // 
            // Close_MenuItem
            // 
            Close_MenuItem.ForeColor = Color.White;
            Close_MenuItem.Name = "Close_MenuItem";
            Close_MenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            Close_MenuItem.Size = new Size(262, 22);
            Close_MenuItem.Text = "Выход";
            Close_MenuItem.Click += Exit_MenuItem_Click;
            // 
            // правкаToolStripMenuItem
            // 
            правкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Copy_MenuItem, Cut_MenuItem, Paste_MenuItem });
            правкаToolStripMenuItem.ForeColor = Color.White;
            правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            правкаToolStripMenuItem.Size = new Size(69, 21);
            правкаToolStripMenuItem.Text = "Правка";
            // 
            // Copy_MenuItem
            // 
            Copy_MenuItem.ForeColor = Color.White;
            Copy_MenuItem.Image = Properties.Resources._005_copy_1;
            Copy_MenuItem.Name = "Copy_MenuItem";
            Copy_MenuItem.ShortcutKeys = Keys.Control | Keys.C;
            Copy_MenuItem.Size = new Size(207, 22);
            Copy_MenuItem.Text = "Копировать";
            Copy_MenuItem.Click += Copy_MenuItem_Click;
            // 
            // Cut_MenuItem
            // 
            Cut_MenuItem.ForeColor = Color.White;
            Cut_MenuItem.Image = Properties.Resources._006_scissors;
            Cut_MenuItem.Name = "Cut_MenuItem";
            Cut_MenuItem.ShortcutKeys = Keys.Control | Keys.X;
            Cut_MenuItem.Size = new Size(207, 22);
            Cut_MenuItem.Text = "Вырезать";
            Cut_MenuItem.Click += Cut_MenuItem_Click;
            // 
            // Paste_MenuItem
            // 
            Paste_MenuItem.ForeColor = Color.White;
            Paste_MenuItem.Image = Properties.Resources._007_paste;
            Paste_MenuItem.Name = "Paste_MenuItem";
            Paste_MenuItem.ShortcutKeys = Keys.Control | Keys.V;
            Paste_MenuItem.Size = new Size(207, 22);
            Paste_MenuItem.Text = "Вставить";
            Paste_MenuItem.Click += Paste_MenuItem_Click;
            // 
            // ForeColor_MenuItem
            // 
            ForeColor_MenuItem.DropDownItems.AddRange(new ToolStripItem[] { FontChange_MenuItem, toolStripSeparator5, FontColor_MenuItem, BackColor_MenuItem });
            ForeColor_MenuItem.ForeColor = Color.White;
            ForeColor_MenuItem.Name = "ForeColor_MenuItem";
            ForeColor_MenuItem.Size = new Size(47, 21);
            ForeColor_MenuItem.Text = "Вид";
            // 
            // FontChange_MenuItem
            // 
            FontChange_MenuItem.ForeColor = Color.White;
            FontChange_MenuItem.Name = "FontChange_MenuItem";
            FontChange_MenuItem.ShortcutKeys = Keys.Alt | Keys.F;
            FontChange_MenuItem.Size = new Size(179, 22);
            FontChange_MenuItem.Text = "Шрифт...";
            FontChange_MenuItem.Click += FontChange_MenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(176, 6);
            // 
            // FontColor_MenuItem
            // 
            FontColor_MenuItem.ForeColor = Color.White;
            FontColor_MenuItem.Name = "FontColor_MenuItem";
            FontColor_MenuItem.Size = new Size(179, 22);
            FontColor_MenuItem.Text = "Цвет шрифта...";
            FontColor_MenuItem.Click += FontColor_MenuItem_Click;
            // 
            // BackColor_MenuItem
            // 
            BackColor_MenuItem.ForeColor = Color.White;
            BackColor_MenuItem.Name = "BackColor_MenuItem";
            BackColor_MenuItem.Size = new Size(179, 22);
            BackColor_MenuItem.Text = "Цвет фона...";
            BackColor_MenuItem.Click += BackColor_MenuItem_Click;
            // 
            // About_MenuItem
            // 
            About_MenuItem.ForeColor = Color.White;
            About_MenuItem.Name = "About_MenuItem";
            About_MenuItem.Size = new Size(78, 21);
            About_MenuItem.Text = "Справка";
            About_MenuItem.Click += About_MenuItem_Click;
            // 
            // tabControlPlus
            // 
            tabControlPlus.ActiveTabEndColor = Color.FromArgb(140, 160, 200);
            tabControlPlus.ActiveTabStartColor = Color.FromArgb(210, 250, 220);
            tabControlPlus.Dock = DockStyle.Fill;
            tabControlPlus.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControlPlus.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlPlus.GradientAngle = 90;
            tabControlPlus.Location = new Point(0, 0);
            tabControlPlus.Name = "tabControlPlus";
            tabControlPlus.NonActiveTabEndColor = Color.DarkBlue;
            tabControlPlus.NonActiveTabStartColor = Color.LightGreen;
            tabControlPlus.Padding = new Point(30, 4);
            tabControlPlus.SelectedIndex = 0;
            tabControlPlus.Size = new Size(885, 498);
            tabControlPlus.TabIndex = 1;
            tabControlPlus.TextColor = Color.Navy;
            tabControlPlus.Transparent1 = 150;
            tabControlPlus.Transparent2 = 150;
            tabControlPlus.SelectedIndexChanged += tabControlPlus_SelectedIndexChanged;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "openFileDialog1";
            // 
            // StatusStrip
            // 
            StatusStrip.BackColor = Color.FromArgb(64, 64, 64);
            StatusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel3, FilenameStatusLabel, toolStripStatusLabel1, LineToolStripLabel, toolStripStatusLabel2, ColumnToolStripLabel });
            StatusStrip.Location = new Point(0, 561);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(885, 30);
            StatusStrip.TabIndex = 2;
            StatusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.AutoSize = false;
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(50, 25);
            // 
            // FilenameStatusLabel
            // 
            FilenameStatusLabel.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            FilenameStatusLabel.ForeColor = SystemColors.ControlLight;
            FilenameStatusLabel.Name = "FilenameStatusLabel";
            FilenameStatusLabel.Size = new Size(49, 25);
            FilenameStatusLabel.Text = "Файл";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.AutoSize = false;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(260, 25);
            // 
            // LineToolStripLabel
            // 
            LineToolStripLabel.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LineToolStripLabel.ForeColor = SystemColors.ControlLight;
            LineToolStripLabel.Name = "LineToolStripLabel";
            LineToolStripLabel.Size = new Size(75, 25);
            LineToolStripLabel.Text = "Строка: 1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.AutoSize = false;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(46, 25);
            // 
            // ColumnToolStripLabel
            // 
            ColumnToolStripLabel.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnToolStripLabel.ForeColor = SystemColors.ControlLight;
            ColumnToolStripLabel.Name = "ColumnToolStripLabel";
            ColumnToolStripLabel.Size = new Size(86, 25);
            ColumnToolStripLabel.Text = "Колонка: 1";
            // 
            // ToolStripPlus
            // 
            ToolStripPlus.AutoSize = false;
            ToolStripPlus.BackColor = Color.FromArgb(163, 163, 163);
            ToolStripPlus.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ToolStripPlus.Items.AddRange(new ToolStripItem[] { NewFile_toolStripButton, OpenFile_toolStripButton, SaveFile_toolStripButton, toolStripSeparator6, RegularStripButton, BoldStripButton, UnderlineStripButton, CoursiveStripButton, toolStripSeparator7, Copy_toolStripButton, Cut_toolStripButton, Paste_toolStripButton });
            ToolStripPlus.Location = new Point(0, 25);
            ToolStripPlus.Name = "ToolStripPlus";
            ToolStripPlus.Size = new Size(885, 38);
            ToolStripPlus.TabIndex = 3;
            ToolStripPlus.Text = "Быстрое меню";
            // 
            // NewFile_toolStripButton
            // 
            NewFile_toolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            NewFile_toolStripButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NewFile_toolStripButton.Image = Properties.Resources._001_add_folder;
            NewFile_toolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            NewFile_toolStripButton.ImageTransparentColor = Color.Magenta;
            NewFile_toolStripButton.Name = "NewFile_toolStripButton";
            NewFile_toolStripButton.Size = new Size(36, 35);
            NewFile_toolStripButton.Text = "Создать";
            NewFile_toolStripButton.Click += NewFile_toolStripButton_Click_1;
            // 
            // OpenFile_toolStripButton
            // 
            OpenFile_toolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            OpenFile_toolStripButton.Image = Properties.Resources._003_open_folder;
            OpenFile_toolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            OpenFile_toolStripButton.ImageTransparentColor = Color.Magenta;
            OpenFile_toolStripButton.Name = "OpenFile_toolStripButton";
            OpenFile_toolStripButton.Size = new Size(36, 35);
            OpenFile_toolStripButton.Text = "Открыть";
            OpenFile_toolStripButton.Click += OpenFile_toolStripButton_Click;
            // 
            // SaveFile_toolStripButton
            // 
            SaveFile_toolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SaveFile_toolStripButton.Image = Properties.Resources._002_diskette;
            SaveFile_toolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            SaveFile_toolStripButton.ImageTransparentColor = Color.Magenta;
            SaveFile_toolStripButton.Name = "SaveFile_toolStripButton";
            SaveFile_toolStripButton.Size = new Size(36, 35);
            SaveFile_toolStripButton.Text = "Сохранить";
            SaveFile_toolStripButton.Click += SaveFile_toolStripButton_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 38);
            // 
            // RegularStripButton
            // 
            RegularStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            RegularStripButton.Image = Properties.Resources.regular;
            RegularStripButton.ImageScaling = ToolStripItemImageScaling.None;
            RegularStripButton.ImageTransparentColor = Color.Magenta;
            RegularStripButton.Name = "RegularStripButton";
            RegularStripButton.Size = new Size(36, 35);
            RegularStripButton.Text = "toolStripButton1";
            RegularStripButton.Click += RegularStripButton_Click;
            // 
            // BoldStripButton
            // 
            BoldStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BoldStripButton.Image = Properties.Resources._009_bold_text;
            BoldStripButton.ImageScaling = ToolStripItemImageScaling.None;
            BoldStripButton.ImageTransparentColor = Color.Magenta;
            BoldStripButton.Name = "BoldStripButton";
            BoldStripButton.Size = new Size(36, 35);
            BoldStripButton.Text = "toolStripButton1";
            BoldStripButton.Click += BoldStripButton_Click;
            // 
            // UnderlineStripButton
            // 
            UnderlineStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            UnderlineStripButton.Image = Properties.Resources._008_underline;
            UnderlineStripButton.ImageScaling = ToolStripItemImageScaling.None;
            UnderlineStripButton.ImageTransparentColor = Color.Magenta;
            UnderlineStripButton.Name = "UnderlineStripButton";
            UnderlineStripButton.Size = new Size(36, 35);
            UnderlineStripButton.Text = "toolStripButton1";
            UnderlineStripButton.Click += UnderlineStripButton_Click;
            // 
            // CoursiveStripButton
            // 
            CoursiveStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            CoursiveStripButton.Image = Properties.Resources._010_;
            CoursiveStripButton.ImageScaling = ToolStripItemImageScaling.None;
            CoursiveStripButton.ImageTransparentColor = Color.Magenta;
            CoursiveStripButton.Name = "CoursiveStripButton";
            CoursiveStripButton.Size = new Size(36, 35);
            CoursiveStripButton.Text = "toolStripButton1";
            CoursiveStripButton.Click += CoursiveStripButton_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 38);
            // 
            // Copy_toolStripButton
            // 
            Copy_toolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Copy_toolStripButton.Image = Properties.Resources._005_copy_1;
            Copy_toolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            Copy_toolStripButton.ImageTransparentColor = Color.Magenta;
            Copy_toolStripButton.Name = "Copy_toolStripButton";
            Copy_toolStripButton.Size = new Size(36, 35);
            Copy_toolStripButton.Text = "Копировать";
            Copy_toolStripButton.Click += Copy_toolStripButton_Click;
            // 
            // Cut_toolStripButton
            // 
            Cut_toolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Cut_toolStripButton.Image = Properties.Resources._006_scissors;
            Cut_toolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            Cut_toolStripButton.ImageTransparentColor = Color.Magenta;
            Cut_toolStripButton.Name = "Cut_toolStripButton";
            Cut_toolStripButton.Size = new Size(36, 35);
            Cut_toolStripButton.Text = "Вырезать";
            Cut_toolStripButton.Click += Cut_toolStripButton_Click;
            // 
            // Paste_toolStripButton
            // 
            Paste_toolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Paste_toolStripButton.Image = Properties.Resources._007_paste;
            Paste_toolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            Paste_toolStripButton.ImageTransparentColor = Color.Magenta;
            Paste_toolStripButton.Name = "Paste_toolStripButton";
            Paste_toolStripButton.Size = new Size(36, 35);
            Paste_toolStripButton.Text = "toolStripButton1";
            Paste_toolStripButton.Click += Paste_toolStripButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(tabControlPlus);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 498);
            panel1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 591);
            Controls.Add(panel1);
            Controls.Add(ToolStripPlus);
            Controls.Add(StatusStrip);
            Controls.Add(TopMenu);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = TopMenu;
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Текстовый редактор";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_Closing;
            Load += MainForm_Load;
            TopMenu.ResumeLayout(false);
            TopMenu.PerformLayout();
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            ToolStripPlus.ResumeLayout(false);
            ToolStripPlus.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem NewFile_MenuItem;
        private ToolStripMenuItem OpenFile_MenuItem;
        private ToolStripMenuItem SaveFile_MenuItem;
        private ToolStripMenuItem SaveAsFile_MenuItem;
        private ToolStripMenuItem CloseFile_MenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem ForeColor_MenuItem;
        private ToolStripMenuItem About_MenuItem;
        private ToolStripMenuItem FontChange_MenuItem;
        private ToolStripMenuItem FontColor_MenuItem;
        private ToolStripMenuItem BackColor_MenuItem;
        private OpenFileDialog OpenFileDialog;
        private ToolStripMenuItem SaveAll_MenuItem;
        private SaveFileDialog SaveFileDialog;
        private ToolStripMenuItem Close_MenuItem;
        private StatusStrip StatusStrip;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        public ToolStripStatusLabel FilenameStatusLabel;
        public ToolStripStatusLabel LineToolStripLabel;
        public ToolStripStatusLabel ColumnToolStripLabel;
        public Controls.TabControlPlus tabControlPlus;
        private Controls.ToolStripPlus ToolStripPlus;
        private ToolStripButton NewFile_toolStripButton;
        private Panel panel1;
        private ToolStripButton OpenFile_toolStripButton;
        private ToolStripButton SaveFile_toolStripButton;
        private ToolStripSeparator toolStripSeparator6;
        public Controls.MenuStripPlus TopMenu;
        private ToolStripMenuItem Copy_MenuItem;
        private ToolStripMenuItem Cut_MenuItem;
        private ToolStripMenuItem Paste_MenuItem;
        private ToolStripButton Copy_toolStripButton;
        private ToolStripButton Cut_toolStripButton;
        private ToolStripButton Paste_toolStripButton;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton BoldStripButton;
        private ToolStripButton UnderlineStripButton;
        private ToolStripButton CoursiveStripButton;
        private ToolStripButton RegularStripButton;
    }
}