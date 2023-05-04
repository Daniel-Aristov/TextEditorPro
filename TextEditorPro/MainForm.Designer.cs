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
            CloseAll_MenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            Close_MenuItem = new ToolStripMenuItem();
            правкаToolStripMenuItem = new ToolStripMenuItem();
            ForeColor_MenuItem = new ToolStripMenuItem();
            FontChange_MenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            FontColor_MenuItem = new ToolStripMenuItem();
            BackColor_MenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
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
            SaveAsFile_toolStripButton = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            panel1 = new Panel();
            TopMenu.SuspendLayout();
            StatusStrip.SuspendLayout();
            ToolStripPlus.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TopMenu
            // 
            TopMenu.BackColor = SystemColors.WindowFrame;
            TopMenu.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TopMenu.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, правкаToolStripMenuItem, ForeColor_MenuItem, справкаToolStripMenuItem });
            TopMenu.Location = new Point(0, 0);
            TopMenu.Name = "TopMenu";
            TopMenu.Size = new Size(885, 25);
            TopMenu.TabIndex = 0;
            TopMenu.Text = "Основное меню";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewFile_MenuItem, toolStripSeparator1, OpenFile_MenuItem, toolStripSeparator2, SaveFile_MenuItem, SaveAsFile_MenuItem, SaveAll_MenuItem, toolStripSeparator3, CloseFile_MenuItem, CloseAll_MenuItem, toolStripSeparator4, Close_MenuItem });
            файлToolStripMenuItem.ForeColor = Color.Black;
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(55, 21);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // NewFile_MenuItem
            // 
            NewFile_MenuItem.ForeColor = Color.Black;
            NewFile_MenuItem.Image = Properties.Resources._new;
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
            OpenFile_MenuItem.ForeColor = Color.Black;
            OpenFile_MenuItem.Image = Properties.Resources.open;
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
            SaveFile_MenuItem.ForeColor = Color.Black;
            SaveFile_MenuItem.Image = Properties.Resources.save;
            SaveFile_MenuItem.Name = "SaveFile_MenuItem";
            SaveFile_MenuItem.ShortcutKeys = Keys.Control | Keys.S;
            SaveFile_MenuItem.Size = new Size(262, 22);
            SaveFile_MenuItem.Text = "Сохранить";
            SaveFile_MenuItem.Click += SaveFile_MenuItem_Click;
            // 
            // SaveAsFile_MenuItem
            // 
            SaveAsFile_MenuItem.ForeColor = Color.Black;
            SaveAsFile_MenuItem.Image = Properties.Resources.saveas;
            SaveAsFile_MenuItem.Name = "SaveAsFile_MenuItem";
            SaveAsFile_MenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.S;
            SaveAsFile_MenuItem.Size = new Size(262, 22);
            SaveAsFile_MenuItem.Text = "Сохранить как...";
            SaveAsFile_MenuItem.Click += SaveAsFile_MenuItem_Click;
            // 
            // SaveAll_MenuItem
            // 
            SaveAll_MenuItem.ForeColor = Color.Black;
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
            CloseFile_MenuItem.ForeColor = Color.Black;
            CloseFile_MenuItem.Name = "CloseFile_MenuItem";
            CloseFile_MenuItem.ShortcutKeys = Keys.Control | Keys.W;
            CloseFile_MenuItem.Size = new Size(262, 22);
            CloseFile_MenuItem.Text = "Закрыть файл";
            CloseFile_MenuItem.Click += CloseFile_MenuItem_Click;
            // 
            // CloseAll_MenuItem
            // 
            CloseAll_MenuItem.ForeColor = Color.Black;
            CloseAll_MenuItem.Name = "CloseAll_MenuItem";
            CloseAll_MenuItem.Size = new Size(262, 22);
            CloseAll_MenuItem.Text = "Закрыть все";
            CloseAll_MenuItem.Click += CloseAll_MenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(259, 6);
            // 
            // Close_MenuItem
            // 
            Close_MenuItem.ForeColor = Color.Black;
            Close_MenuItem.Image = Properties.Resources.exit;
            Close_MenuItem.Name = "Close_MenuItem";
            Close_MenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            Close_MenuItem.Size = new Size(262, 22);
            Close_MenuItem.Text = "Выход";
            Close_MenuItem.Click += Exit_MenuItem_Click;
            // 
            // правкаToolStripMenuItem
            // 
            правкаToolStripMenuItem.ForeColor = Color.Black;
            правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            правкаToolStripMenuItem.Size = new Size(69, 21);
            правкаToolStripMenuItem.Text = "Правка";
            // 
            // ForeColor_MenuItem
            // 
            ForeColor_MenuItem.DropDownItems.AddRange(new ToolStripItem[] { FontChange_MenuItem, toolStripSeparator5, FontColor_MenuItem, BackColor_MenuItem });
            ForeColor_MenuItem.ForeColor = Color.Black;
            ForeColor_MenuItem.Name = "ForeColor_MenuItem";
            ForeColor_MenuItem.Size = new Size(47, 21);
            ForeColor_MenuItem.Text = "Вид";
            // 
            // FontChange_MenuItem
            // 
            FontChange_MenuItem.ForeColor = Color.Black;
            FontChange_MenuItem.Image = Properties.Resources.font;
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
            FontColor_MenuItem.ForeColor = Color.Black;
            FontColor_MenuItem.Name = "FontColor_MenuItem";
            FontColor_MenuItem.Size = new Size(179, 22);
            FontColor_MenuItem.Text = "Цвет шрифта...";
            FontColor_MenuItem.Click += FontColor_MenuItem_Click;
            // 
            // BackColor_MenuItem
            // 
            BackColor_MenuItem.ForeColor = Color.Black;
            BackColor_MenuItem.Name = "BackColor_MenuItem";
            BackColor_MenuItem.Size = new Size(179, 22);
            BackColor_MenuItem.Text = "Цвет фона...";
            BackColor_MenuItem.Click += BackColor_MenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.ForeColor = Color.Black;
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(78, 21);
            справкаToolStripMenuItem.Text = "Справка";
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
            tabControlPlus.Size = new Size(885, 511);
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
            StatusStrip.BackColor = SystemColors.WindowFrame;
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
            FilenameStatusLabel.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FilenameStatusLabel.Name = "FilenameStatusLabel";
            FilenameStatusLabel.Size = new Size(43, 25);
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
            LineToolStripLabel.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LineToolStripLabel.Name = "LineToolStripLabel";
            LineToolStripLabel.Size = new Size(73, 25);
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
            ColumnToolStripLabel.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ColumnToolStripLabel.Name = "ColumnToolStripLabel";
            ColumnToolStripLabel.Size = new Size(80, 25);
            ColumnToolStripLabel.Text = "Колонка: 1";
            // 
            // ToolStripPlus
            // 
            ToolStripPlus.BackColor = Color.Silver;
            ToolStripPlus.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ToolStripPlus.Items.AddRange(new ToolStripItem[] { NewFile_toolStripButton, OpenFile_toolStripButton, SaveFile_toolStripButton, SaveAsFile_toolStripButton, toolStripSeparator6 });
            ToolStripPlus.Location = new Point(0, 25);
            ToolStripPlus.Name = "ToolStripPlus";
            ToolStripPlus.Size = new Size(885, 25);
            ToolStripPlus.TabIndex = 3;
            ToolStripPlus.Text = "Быстрое меню";
            // 
            // NewFile_toolStripButton
            // 
            NewFile_toolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            NewFile_toolStripButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NewFile_toolStripButton.Image = Properties.Resources._new;
            NewFile_toolStripButton.ImageTransparentColor = Color.Magenta;
            NewFile_toolStripButton.Name = "NewFile_toolStripButton";
            NewFile_toolStripButton.Size = new Size(23, 22);
            NewFile_toolStripButton.Text = "toolStripButton1";
            NewFile_toolStripButton.Click += NewFile_toolStripButton_Click_1;
            // 
            // OpenFile_toolStripButton
            // 
            OpenFile_toolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            OpenFile_toolStripButton.Image = Properties.Resources.open;
            OpenFile_toolStripButton.ImageTransparentColor = Color.Magenta;
            OpenFile_toolStripButton.Name = "OpenFile_toolStripButton";
            OpenFile_toolStripButton.Size = new Size(23, 22);
            OpenFile_toolStripButton.Text = "toolStripButton1";
            OpenFile_toolStripButton.Click += OpenFile_toolStripButton_Click;
            // 
            // SaveFile_toolStripButton
            // 
            SaveFile_toolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SaveFile_toolStripButton.Image = Properties.Resources.save;
            SaveFile_toolStripButton.ImageTransparentColor = Color.Magenta;
            SaveFile_toolStripButton.Name = "SaveFile_toolStripButton";
            SaveFile_toolStripButton.Size = new Size(23, 22);
            SaveFile_toolStripButton.Text = "toolStripButton2";
            SaveFile_toolStripButton.Click += SaveFile_toolStripButton_Click;
            // 
            // SaveAsFile_toolStripButton
            // 
            SaveAsFile_toolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SaveAsFile_toolStripButton.Image = Properties.Resources.saveas;
            SaveAsFile_toolStripButton.ImageTransparentColor = Color.Magenta;
            SaveAsFile_toolStripButton.Name = "SaveAsFile_toolStripButton";
            SaveAsFile_toolStripButton.Size = new Size(23, 22);
            SaveAsFile_toolStripButton.Text = "toolStripButton3";
            SaveAsFile_toolStripButton.Click += SaveAsFile_toolStripButton_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 25);
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControlPlus);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 511);
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
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem FontChange_MenuItem;
        private ToolStripMenuItem FontColor_MenuItem;
        private ToolStripMenuItem BackColor_MenuItem;
        private OpenFileDialog OpenFileDialog;
        private ToolStripMenuItem SaveAll_MenuItem;
        private ToolStripMenuItem CloseAll_MenuItem;
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
        private ToolStripButton SaveAsFile_toolStripButton;
        private ToolStripSeparator toolStripSeparator6;
        public Controls.MenuStripPlus TopMenu;
    }
}