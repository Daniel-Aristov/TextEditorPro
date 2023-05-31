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
            ToolStrip = new ToolStrip();
            NewFile_toolStrip = new ToolStripButton();
            OpenFile_toolStrip = new ToolStripButton();
            SaveFile_toolStrip = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            RegularStrip = new ToolStripButton();
            BoldStrip = new ToolStripButton();
            UnderlineStrip = new ToolStripButton();
            CoursiveStrip = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            Copy_toolStrip = new ToolStripButton();
            Cut_toolStrip = new ToolStripButton();
            Paste_toolStrip = new ToolStripButton();
            TopMenu.SuspendLayout();
            StatusStrip.SuspendLayout();
            panel1.SuspendLayout();
            ToolStrip.SuspendLayout();
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
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewFile_MenuItem, toolStripSeparator1, OpenFile_MenuItem, toolStripSeparator2, SaveFile_MenuItem, SaveAsFile_MenuItem, SaveAll_MenuItem, toolStripSeparator3, CloseFile_MenuItem });
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
            tabControlPlus.Size = new Size(885, 497);
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
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(tabControlPlus);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 497);
            panel1.TabIndex = 4;
            // 
            // ToolStrip
            // 
            ToolStrip.BackColor = Color.FromArgb(110, 110, 110);
            ToolStrip.Items.AddRange(new ToolStripItem[] { NewFile_toolStrip, OpenFile_toolStrip, SaveFile_toolStrip, toolStripSeparator4, RegularStrip, BoldStrip, UnderlineStrip, CoursiveStrip, toolStripSeparator8, Copy_toolStrip, Cut_toolStrip, Paste_toolStrip });
            ToolStrip.Location = new Point(0, 25);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.Size = new Size(885, 39);
            ToolStrip.TabIndex = 5;
            ToolStrip.Text = "Быстрое меню";
            // 
            // NewFile_toolStrip
            // 
            NewFile_toolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            NewFile_toolStrip.Image = Properties.Resources._001_add_folder;
            NewFile_toolStrip.ImageScaling = ToolStripItemImageScaling.None;
            NewFile_toolStrip.ImageTransparentColor = Color.Magenta;
            NewFile_toolStrip.Name = "NewFile_toolStrip";
            NewFile_toolStrip.Size = new Size(36, 36);
            NewFile_toolStrip.Text = "toolStripButton1";
            NewFile_toolStrip.Click += NewFile_toolStrip_Click;
            // 
            // OpenFile_toolStrip
            // 
            OpenFile_toolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            OpenFile_toolStrip.Image = Properties.Resources._003_open_folder;
            OpenFile_toolStrip.ImageScaling = ToolStripItemImageScaling.None;
            OpenFile_toolStrip.ImageTransparentColor = Color.Magenta;
            OpenFile_toolStrip.Name = "OpenFile_toolStrip";
            OpenFile_toolStrip.Size = new Size(36, 36);
            OpenFile_toolStrip.Text = "toolStripButton2";
            OpenFile_toolStrip.Click += OpenFile_toolStrip_Click;
            // 
            // SaveFile_toolStrip
            // 
            SaveFile_toolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SaveFile_toolStrip.Image = Properties.Resources._002_diskette;
            SaveFile_toolStrip.ImageScaling = ToolStripItemImageScaling.None;
            SaveFile_toolStrip.ImageTransparentColor = Color.Magenta;
            SaveFile_toolStrip.Name = "SaveFile_toolStrip";
            SaveFile_toolStrip.Size = new Size(36, 36);
            SaveFile_toolStrip.Text = "toolStripButton3";
            SaveFile_toolStrip.Click += SaveFile_toolStrip_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 39);
            // 
            // RegularStrip
            // 
            RegularStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            RegularStrip.Image = Properties.Resources.regular;
            RegularStrip.ImageScaling = ToolStripItemImageScaling.None;
            RegularStrip.ImageTransparentColor = Color.Magenta;
            RegularStrip.Name = "RegularStrip";
            RegularStrip.Size = new Size(36, 36);
            RegularStrip.Text = "toolStripButton4";
            RegularStrip.Click += RegularStrip_Click;
            // 
            // BoldStrip
            // 
            BoldStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BoldStrip.Image = Properties.Resources._009_bold_text;
            BoldStrip.ImageScaling = ToolStripItemImageScaling.None;
            BoldStrip.ImageTransparentColor = Color.Magenta;
            BoldStrip.Name = "BoldStrip";
            BoldStrip.Size = new Size(36, 36);
            BoldStrip.Text = "toolStripButton5";
            BoldStrip.Click += BoldStrip_Click;
            // 
            // UnderlineStrip
            // 
            UnderlineStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            UnderlineStrip.Image = Properties.Resources._008_underline;
            UnderlineStrip.ImageScaling = ToolStripItemImageScaling.None;
            UnderlineStrip.ImageTransparentColor = Color.Magenta;
            UnderlineStrip.Name = "UnderlineStrip";
            UnderlineStrip.Size = new Size(36, 36);
            UnderlineStrip.Text = "toolStripButton6";
            UnderlineStrip.Click += UnderlineStrip_Click;
            // 
            // CoursiveStrip
            // 
            CoursiveStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            CoursiveStrip.Image = Properties.Resources._010_;
            CoursiveStrip.ImageScaling = ToolStripItemImageScaling.None;
            CoursiveStrip.ImageTransparentColor = Color.Magenta;
            CoursiveStrip.Name = "CoursiveStrip";
            CoursiveStrip.Size = new Size(36, 36);
            CoursiveStrip.Text = "toolStripButton7";
            CoursiveStrip.Click += CoursiveStrip_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 39);
            // 
            // Copy_toolStrip
            // 
            Copy_toolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Copy_toolStrip.Image = Properties.Resources._005_copy_1;
            Copy_toolStrip.ImageScaling = ToolStripItemImageScaling.None;
            Copy_toolStrip.ImageTransparentColor = Color.Magenta;
            Copy_toolStrip.Name = "Copy_toolStrip";
            Copy_toolStrip.Size = new Size(36, 36);
            Copy_toolStrip.Text = "toolStripButton8";
            Copy_toolStrip.Click += Copy_toolStrip_Click;
            // 
            // Cut_toolStrip
            // 
            Cut_toolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Cut_toolStrip.Image = Properties.Resources._006_scissors;
            Cut_toolStrip.ImageScaling = ToolStripItemImageScaling.None;
            Cut_toolStrip.ImageTransparentColor = Color.Magenta;
            Cut_toolStrip.Name = "Cut_toolStrip";
            Cut_toolStrip.Size = new Size(36, 36);
            Cut_toolStrip.Text = "toolStripButton9";
            Cut_toolStrip.Click += Cut_toolStrip_Click;
            // 
            // Paste_toolStrip
            // 
            Paste_toolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Paste_toolStrip.Image = Properties.Resources._007_paste;
            Paste_toolStrip.ImageScaling = ToolStripItemImageScaling.None;
            Paste_toolStrip.ImageTransparentColor = Color.Magenta;
            Paste_toolStrip.Name = "Paste_toolStrip";
            Paste_toolStrip.Size = new Size(36, 36);
            Paste_toolStrip.Text = "toolStripButton10";
            Paste_toolStrip.Click += Paste_toolStrip_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 591);
            Controls.Add(panel1);
            Controls.Add(StatusStrip);
            Controls.Add(ToolStrip);
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
            panel1.ResumeLayout(false);
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
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
        private StatusStrip StatusStrip;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        public ToolStripStatusLabel FilenameStatusLabel;
        public ToolStripStatusLabel LineToolStripLabel;
        public ToolStripStatusLabel ColumnToolStripLabel;
        public Controls.TabControlPlus tabControlPlus;
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
        private ToolStrip ToolStrip;
        private ToolStripButton NewFile_toolStrip;
        private ToolStripButton OpenFile_toolStrip;
        private ToolStripButton SaveFile_toolStrip;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton RegularStrip;
        private ToolStripButton BoldStrip;
        private ToolStripButton UnderlineStrip;
        private ToolStripButton CoursiveStrip;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton Copy_toolStrip;
        private ToolStripButton Cut_toolStrip;
        private ToolStripButton Paste_toolStrip;
    }
}