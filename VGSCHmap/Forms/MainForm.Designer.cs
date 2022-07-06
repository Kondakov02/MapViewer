namespace VGSCHmap
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MapControl = new GMap.NET.WindowsForms.GMapControl();
            this.BottomBar = new System.Windows.Forms.Panel();
            this.RightHBox = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.LeftHBox = new System.Windows.Forms.FlowLayoutPanel();
            this.ZoomOutButton = new System.Windows.Forms.Button();
            this.ZoomInButton = new System.Windows.Forms.Button();
            this.ToolBar = new System.Windows.Forms.MenuStrip();
            this.MarkersButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadMarkersButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMarkersButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMarkersButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RoutesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowMarkersButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowRoutesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AppHelpButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMarkersDialog = new System.Windows.Forms.SaveFileDialog();
            this.LoadMarkersDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MarkerInfoPanel = new System.Windows.Forms.Panel();
            this.MarkerDescBox = new System.Windows.Forms.RichTextBox();
            this.MarkerNameBox = new System.Windows.Forms.TextBox();
            this.DeleteInfoButton = new System.Windows.Forms.Button();
            this.CancelRouteButton = new System.Windows.Forms.Button();
            this.AddRouteButton = new System.Windows.Forms.Button();
            this.RouteAddModeLabel = new System.Windows.Forms.Label();
            this.BottomBar.SuspendLayout();
            this.RightHBox.SuspendLayout();
            this.LeftHBox.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MarkerInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MapControl
            // 
            this.MapControl.Bearing = 0F;
            this.MapControl.CanDragMap = true;
            this.MapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.MapControl.GrayScaleMode = false;
            this.MapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MapControl.LevelsKeepInMemory = 5;
            this.MapControl.Location = new System.Drawing.Point(0, 0);
            this.MapControl.MarkersEnabled = true;
            this.MapControl.MaxZoom = 2;
            this.MapControl.MinZoom = 2;
            this.MapControl.MouseWheelZoomEnabled = true;
            this.MapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.MapControl.Name = "MapControl";
            this.MapControl.NegativeMode = false;
            this.MapControl.PolygonsEnabled = true;
            this.MapControl.RetryLoadTile = 0;
            this.MapControl.RoutesEnabled = true;
            this.MapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MapControl.ShowTileGridLines = false;
            this.MapControl.Size = new System.Drawing.Size(782, 463);
            this.MapControl.TabIndex = 0;
            this.MapControl.Zoom = 0D;
            this.MapControl.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.MapControl_OnMarkerClick);
            this.MapControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MapControl_MouseClick);
            // 
            // BottomBar
            // 
            this.BottomBar.Controls.Add(this.RightHBox);
            this.BottomBar.Controls.Add(this.LeftHBox);
            this.BottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBar.Location = new System.Drawing.Point(0, 493);
            this.BottomBar.Name = "BottomBar";
            this.BottomBar.Size = new System.Drawing.Size(782, 60);
            this.BottomBar.TabIndex = 2;
            // 
            // RightHBox
            // 
            this.RightHBox.Controls.Add(this.SearchBox);
            this.RightHBox.Controls.Add(this.SearchLabel);
            this.RightHBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightHBox.Location = new System.Drawing.Point(482, 0);
            this.RightHBox.Name = "RightHBox";
            this.RightHBox.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.RightHBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightHBox.Size = new System.Drawing.Size(300, 60);
            this.RightHBox.TabIndex = 4;
            // 
            // SearchBox
            // 
            this.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchBox.CausesValidation = false;
            this.SearchBox.Location = new System.Drawing.Point(104, 13);
            this.SearchBox.MaxLength = 100;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SearchBox.Size = new System.Drawing.Size(183, 22);
            this.SearchBox.TabIndex = 5;
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // SearchLabel
            // 
            this.SearchLabel.Location = new System.Drawing.Point(23, 10);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SearchLabel.Size = new System.Drawing.Size(75, 30);
            this.SearchLabel.TabIndex = 4;
            this.SearchLabel.Text = "Поиск:";
            this.SearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftHBox
            // 
            this.LeftHBox.Controls.Add(this.ZoomOutButton);
            this.LeftHBox.Controls.Add(this.ZoomInButton);
            this.LeftHBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftHBox.Location = new System.Drawing.Point(0, 0);
            this.LeftHBox.Name = "LeftHBox";
            this.LeftHBox.Padding = new System.Windows.Forms.Padding(10, 3, 0, 0);
            this.LeftHBox.Size = new System.Drawing.Size(150, 60);
            this.LeftHBox.TabIndex = 0;
            // 
            // ZoomOutButton
            // 
            this.ZoomOutButton.FlatAppearance.BorderSize = 0;
            this.ZoomOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ZoomOutButton.Location = new System.Drawing.Point(13, 6);
            this.ZoomOutButton.Name = "ZoomOutButton";
            this.ZoomOutButton.Size = new System.Drawing.Size(48, 48);
            this.ZoomOutButton.TabIndex = 0;
            this.ZoomOutButton.Text = "-";
            this.ZoomOutButton.UseVisualStyleBackColor = true;
            this.ZoomOutButton.Click += new System.EventHandler(this.ZoomOutButton_Click);
            // 
            // ZoomInButton
            // 
            this.ZoomInButton.FlatAppearance.BorderSize = 0;
            this.ZoomInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ZoomInButton.Location = new System.Drawing.Point(67, 6);
            this.ZoomInButton.Name = "ZoomInButton";
            this.ZoomInButton.Size = new System.Drawing.Size(48, 48);
            this.ZoomInButton.TabIndex = 2;
            this.ZoomInButton.Text = "+";
            this.ZoomInButton.UseVisualStyleBackColor = true;
            this.ZoomInButton.Click += new System.EventHandler(this.ZoomInButton_Click);
            // 
            // ToolBar
            // 
            this.ToolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MarkersButton,
            this.RoutesButton,
            this.ViewMenu,
            this.PrintButton,
            this.AppHelpButton,
            this.ExitButton});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(782, 30);
            this.ToolBar.TabIndex = 3;
            this.ToolBar.Text = "menuStrip1";
            // 
            // MarkersButton
            // 
            this.MarkersButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadMarkersButton,
            this.SaveMarkersButton,
            this.DeleteMarkersButton});
            this.MarkersButton.Name = "MarkersButton";
            this.MarkersButton.Size = new System.Drawing.Size(88, 26);
            this.MarkersButton.Text = "Маркеры";
            // 
            // LoadMarkersButton
            // 
            this.LoadMarkersButton.Name = "LoadMarkersButton";
            this.LoadMarkersButton.Size = new System.Drawing.Size(175, 26);
            this.LoadMarkersButton.Text = "Загрузить";
            this.LoadMarkersButton.Click += new System.EventHandler(this.LoadMarkersButton_Click);
            // 
            // SaveMarkersButton
            // 
            this.SaveMarkersButton.Name = "SaveMarkersButton";
            this.SaveMarkersButton.Size = new System.Drawing.Size(175, 26);
            this.SaveMarkersButton.Text = "Сохранить";
            this.SaveMarkersButton.Click += new System.EventHandler(this.SaveMarkersButton_Click);
            // 
            // DeleteMarkersButton
            // 
            this.DeleteMarkersButton.Name = "DeleteMarkersButton";
            this.DeleteMarkersButton.Size = new System.Drawing.Size(175, 26);
            this.DeleteMarkersButton.Text = "Удалить все";
            this.DeleteMarkersButton.Click += new System.EventHandler(this.DeleteMarkersButton_Click);
            // 
            // RoutesButton
            // 
            this.RoutesButton.Name = "RoutesButton";
            this.RoutesButton.Size = new System.Drawing.Size(98, 26);
            this.RoutesButton.Text = "Маршруты";
            this.RoutesButton.Click += new System.EventHandler(this.RoutesButton_Click);
            // 
            // ViewMenu
            // 
            this.ViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowMarkersButton,
            this.ShowRoutesButton});
            this.ViewMenu.Name = "ViewMenu";
            this.ViewMenu.Size = new System.Drawing.Size(49, 26);
            this.ViewMenu.Text = "Вид";
            // 
            // ShowMarkersButton
            // 
            this.ShowMarkersButton.Checked = true;
            this.ShowMarkersButton.CheckOnClick = true;
            this.ShowMarkersButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowMarkersButton.Name = "ShowMarkersButton";
            this.ShowMarkersButton.Size = new System.Drawing.Size(252, 26);
            this.ShowMarkersButton.Text = "Показывать маркеры";
            this.ShowMarkersButton.Click += new System.EventHandler(this.ShowMarkersButton_Click);
            // 
            // ShowRoutesButton
            // 
            this.ShowRoutesButton.Checked = true;
            this.ShowRoutesButton.CheckOnClick = true;
            this.ShowRoutesButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowRoutesButton.Name = "ShowRoutesButton";
            this.ShowRoutesButton.Size = new System.Drawing.Size(252, 26);
            this.ShowRoutesButton.Text = "Показывать маршруты";
            this.ShowRoutesButton.Click += new System.EventHandler(this.ShowRoutesButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(122, 26);
            this.PrintButton.Text = "Снимок карты";
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // AppHelpButton
            // 
            this.AppHelpButton.Name = "AppHelpButton";
            this.AppHelpButton.Size = new System.Drawing.Size(83, 26);
            this.AppHelpButton.Text = "Помощь";
            this.AppHelpButton.Click += new System.EventHandler(this.AppHelpButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(67, 26);
            this.ExitButton.Text = "Выход";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SaveMarkersDialog
            // 
            this.SaveMarkersDialog.DefaultExt = "json";
            this.SaveMarkersDialog.Filter = "Файлы формата JSON|*.json|Все файлы|*.*";
            this.SaveMarkersDialog.Title = "Сохранение";
            // 
            // LoadMarkersDialog
            // 
            this.LoadMarkersDialog.DefaultExt = "json";
            this.LoadMarkersDialog.Filter = "Файлы формата JSON|*.json|Все файлы|*.*";
            this.LoadMarkersDialog.Title = "Загрузка";
            // 
            // SaveImageDialog
            // 
            this.SaveImageDialog.DefaultExt = "png";
            this.SaveImageDialog.Filter = "PNG|*.png|JPEG|*.jpg|Все файлы|*.*";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MarkerInfoPanel);
            this.panel1.Controls.Add(this.CancelRouteButton);
            this.panel1.Controls.Add(this.AddRouteButton);
            this.panel1.Controls.Add(this.RouteAddModeLabel);
            this.panel1.Controls.Add(this.MapControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 463);
            this.panel1.TabIndex = 4;
            // 
            // MarkerInfoPanel
            // 
            this.MarkerInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MarkerInfoPanel.Controls.Add(this.MarkerDescBox);
            this.MarkerInfoPanel.Controls.Add(this.MarkerNameBox);
            this.MarkerInfoPanel.Controls.Add(this.DeleteInfoButton);
            this.MarkerInfoPanel.Enabled = false;
            this.MarkerInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.MarkerInfoPanel.Name = "MarkerInfoPanel";
            this.MarkerInfoPanel.Size = new System.Drawing.Size(224, 463);
            this.MarkerInfoPanel.TabIndex = 4;
            this.MarkerInfoPanel.Visible = false;
            // 
            // MarkerDescBox
            // 
            this.MarkerDescBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MarkerDescBox.Location = new System.Drawing.Point(13, 70);
            this.MarkerDescBox.Name = "MarkerDescBox";
            this.MarkerDescBox.Size = new System.Drawing.Size(191, 337);
            this.MarkerDescBox.TabIndex = 3;
            this.MarkerDescBox.Text = "";
            // 
            // MarkerNameBox
            // 
            this.MarkerNameBox.Location = new System.Drawing.Point(13, 20);
            this.MarkerNameBox.Name = "MarkerNameBox";
            this.MarkerNameBox.Size = new System.Drawing.Size(191, 22);
            this.MarkerNameBox.TabIndex = 2;
            // 
            // DeleteInfoButton
            // 
            this.DeleteInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteInfoButton.Location = new System.Drawing.Point(13, 429);
            this.DeleteInfoButton.Name = "DeleteInfoButton";
            this.DeleteInfoButton.Size = new System.Drawing.Size(191, 23);
            this.DeleteInfoButton.TabIndex = 1;
            this.DeleteInfoButton.Text = "Удалить";
            this.DeleteInfoButton.UseVisualStyleBackColor = true;
            this.DeleteInfoButton.Click += new System.EventHandler(this.DeleteInfoButton_Click);
            // 
            // CancelRouteButton
            // 
            this.CancelRouteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelRouteButton.Enabled = false;
            this.CancelRouteButton.Location = new System.Drawing.Point(707, 444);
            this.CancelRouteButton.Name = "CancelRouteButton";
            this.CancelRouteButton.Size = new System.Drawing.Size(75, 23);
            this.CancelRouteButton.TabIndex = 3;
            this.CancelRouteButton.Text = "Отмена";
            this.CancelRouteButton.UseVisualStyleBackColor = true;
            this.CancelRouteButton.Visible = false;
            this.CancelRouteButton.Click += new System.EventHandler(this.CancelRouteButton_Click);
            // 
            // AddRouteButton
            // 
            this.AddRouteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRouteButton.Enabled = false;
            this.AddRouteButton.Location = new System.Drawing.Point(626, 444);
            this.AddRouteButton.Name = "AddRouteButton";
            this.AddRouteButton.Size = new System.Drawing.Size(75, 23);
            this.AddRouteButton.TabIndex = 2;
            this.AddRouteButton.Text = "Далее";
            this.AddRouteButton.UseVisualStyleBackColor = true;
            this.AddRouteButton.Visible = false;
            this.AddRouteButton.Click += new System.EventHandler(this.AddRouteButton_Click);
            // 
            // RouteAddModeLabel
            // 
            this.RouteAddModeLabel.AutoSize = true;
            this.RouteAddModeLabel.Enabled = false;
            this.RouteAddModeLabel.ForeColor = System.Drawing.Color.Red;
            this.RouteAddModeLabel.Location = new System.Drawing.Point(4, 4);
            this.RouteAddModeLabel.Name = "RouteAddModeLabel";
            this.RouteAddModeLabel.Size = new System.Drawing.Size(200, 16);
            this.RouteAddModeLabel.TabIndex = 1;
            this.RouteAddModeLabel.Text = "Режим добавления маршрута";
            this.RouteAddModeLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.BottomBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ToolBar;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Просмотр карты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BottomBar.ResumeLayout(false);
            this.RightHBox.ResumeLayout(false);
            this.RightHBox.PerformLayout();
            this.LeftHBox.ResumeLayout(false);
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MarkerInfoPanel.ResumeLayout(false);
            this.MarkerInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl MapControl;
        private System.Windows.Forms.Panel BottomBar;
        private System.Windows.Forms.FlowLayoutPanel LeftHBox;
        private System.Windows.Forms.Button ZoomOutButton;
        private System.Windows.Forms.Button ZoomInButton;
        private System.Windows.Forms.FlowLayoutPanel RightHBox;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.MenuStrip ToolBar;
        private System.Windows.Forms.ToolStripMenuItem MarkersButton;
        private System.Windows.Forms.ToolStripMenuItem ViewMenu;
        private System.Windows.Forms.ToolStripMenuItem PrintButton;
        private System.Windows.Forms.ToolStripMenuItem AppHelpButton;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.SaveFileDialog SaveMarkersDialog;
        private System.Windows.Forms.OpenFileDialog LoadMarkersDialog;
        private System.Windows.Forms.SaveFileDialog SaveImageDialog;
        private System.Windows.Forms.ToolStripMenuItem RoutesButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RouteAddModeLabel;
        private System.Windows.Forms.Button CancelRouteButton;
        private System.Windows.Forms.Button AddRouteButton;
        private System.Windows.Forms.ToolStripMenuItem ShowRoutesButton;
        private System.Windows.Forms.ToolStripMenuItem ShowMarkersButton;
        private System.Windows.Forms.ToolStripMenuItem LoadMarkersButton;
        private System.Windows.Forms.ToolStripMenuItem SaveMarkersButton;
        private System.Windows.Forms.ToolStripMenuItem DeleteMarkersButton;
        private System.Windows.Forms.Panel MarkerInfoPanel;
        private System.Windows.Forms.Button DeleteInfoButton;
        private System.Windows.Forms.RichTextBox MarkerDescBox;
        private System.Windows.Forms.TextBox MarkerNameBox;
    }
}

