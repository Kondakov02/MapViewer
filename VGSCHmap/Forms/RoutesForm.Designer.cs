namespace VGSCHmap
{
    partial class RoutesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RoutesListBox = new System.Windows.Forms.ListBox();
            this.AddRouteButton = new System.Windows.Forms.Button();
            this.ShowRouteButton = new System.Windows.Forms.Button();
            this.ChangeColorButton = new System.Windows.Forms.Button();
            this.DeleteRouteButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LoadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoutesListBox
            // 
            this.RoutesListBox.FormattingEnabled = true;
            this.RoutesListBox.ItemHeight = 16;
            this.RoutesListBox.Location = new System.Drawing.Point(3, 3);
            this.RoutesListBox.Name = "RoutesListBox";
            this.RoutesListBox.Size = new System.Drawing.Size(223, 244);
            this.RoutesListBox.Sorted = true;
            this.RoutesListBox.TabIndex = 0;
            // 
            // AddRouteButton
            // 
            this.AddRouteButton.Location = new System.Drawing.Point(3, 5);
            this.AddRouteButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AddRouteButton.Name = "AddRouteButton";
            this.AddRouteButton.Size = new System.Drawing.Size(143, 23);
            this.AddRouteButton.TabIndex = 0;
            this.AddRouteButton.Text = "Добавить";
            this.AddRouteButton.UseVisualStyleBackColor = true;
            this.AddRouteButton.Click += new System.EventHandler(this.AddRouteButton_Click);
            // 
            // ShowRouteButton
            // 
            this.ShowRouteButton.Location = new System.Drawing.Point(3, 38);
            this.ShowRouteButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ShowRouteButton.Name = "ShowRouteButton";
            this.ShowRouteButton.Size = new System.Drawing.Size(143, 23);
            this.ShowRouteButton.TabIndex = 1;
            this.ShowRouteButton.Text = "Показать";
            this.ShowRouteButton.UseVisualStyleBackColor = true;
            this.ShowRouteButton.Click += new System.EventHandler(this.ShowRouteButton_Click);
            // 
            // ChangeColorButton
            // 
            this.ChangeColorButton.Location = new System.Drawing.Point(3, 71);
            this.ChangeColorButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ChangeColorButton.Name = "ChangeColorButton";
            this.ChangeColorButton.Size = new System.Drawing.Size(143, 23);
            this.ChangeColorButton.TabIndex = 2;
            this.ChangeColorButton.Text = "Изменить";
            this.ChangeColorButton.UseVisualStyleBackColor = true;
            this.ChangeColorButton.Click += new System.EventHandler(this.ChangeColorButton_Click);
            // 
            // DeleteRouteButton
            // 
            this.DeleteRouteButton.Location = new System.Drawing.Point(3, 104);
            this.DeleteRouteButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DeleteRouteButton.Name = "DeleteRouteButton";
            this.DeleteRouteButton.Size = new System.Drawing.Size(143, 23);
            this.DeleteRouteButton.TabIndex = 3;
            this.DeleteRouteButton.Text = "Удалить";
            this.DeleteRouteButton.UseVisualStyleBackColor = true;
            this.DeleteRouteButton.Click += new System.EventHandler(this.DeleteRouteButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.RoutesListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(382, 253);
            this.splitContainer1.SplitterDistance = 229;
            this.splitContainer1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.AddRouteButton);
            this.flowLayoutPanel1.Controls.Add(this.ShowRouteButton);
            this.flowLayoutPanel1.Controls.Add(this.ChangeColorButton);
            this.flowLayoutPanel1.Controls.Add(this.DeleteRouteButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(149, 253);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // LoadFileDialog
            // 
            this.LoadFileDialog.DefaultExt = "json";
            this.LoadFileDialog.Filter = "Файлы формата JSON|*.json|Все файлы|*.*";
            this.LoadFileDialog.Title = "Загрузка";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "json";
            this.SaveFileDialog.Filter = "Файлы формата JSON|*.json|Все файлы|*.*";
            this.SaveFileDialog.Title = "Сохранение";
            // 
            // RoutesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoutesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Маршруты";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox RoutesListBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button DeleteRouteButton;
        private System.Windows.Forms.Button ChangeColorButton;
        private System.Windows.Forms.Button ShowRouteButton;
        private System.Windows.Forms.Button AddRouteButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog LoadFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}