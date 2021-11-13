
namespace Jane
{
    partial class WindowForm
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
            this.HwndTextBox = new System.Windows.Forms.TextBox();
            this.WindowNameTextBox = new System.Windows.Forms.TextBox();
            this.WindowClassTextBox = new System.Windows.Forms.TextBox();
            this.SetWindowTitleButton = new System.Windows.Forms.Button();
            this.ProcessNameTextBox = new System.Windows.Forms.TextBox();
            this.WindowStylesTextBox = new System.Windows.Forms.TextBox();
            this.WindowRectTextBox = new System.Windows.Forms.TextBox();
            this.ParentWindowButton = new System.Windows.Forms.Button();
            this.EnableButton = new System.Windows.Forms.Button();
            this.DisableButton = new System.Windows.Forms.Button();
            this.EnableWindowGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnableWindowDelayUpDown = new System.Windows.Forms.NumericUpDown();
            this.ShowWindowGroupBox = new System.Windows.Forms.GroupBox();
            this.CmdShowWindowComboBox = new System.Windows.Forms.ComboBox();
            this.ShowWindowButton = new System.Windows.Forms.Button();
            this.PostMessageGroupBox = new System.Windows.Forms.GroupBox();
            this.LparamUpDown = new System.Windows.Forms.NumericUpDown();
            this.WparamUpDown = new System.Windows.Forms.NumericUpDown();
            this.WindowMessageComboBox = new System.Windows.Forms.ComboBox();
            this.PostMessageButton = new System.Windows.Forms.Button();
            this.SetForegroundWindowButton = new System.Windows.Forms.Button();
            this.RealGetWindowClassTextBox = new System.Windows.Forms.TextBox();
            this.EnableWindowGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnableWindowDelayUpDown)).BeginInit();
            this.ShowWindowGroupBox.SuspendLayout();
            this.PostMessageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LparamUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WparamUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // HwndTextBox
            // 
            this.HwndTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HwndTextBox.Location = new System.Drawing.Point(12, 12);
            this.HwndTextBox.Name = "HwndTextBox";
            this.HwndTextBox.ReadOnly = true;
            this.HwndTextBox.Size = new System.Drawing.Size(303, 20);
            this.HwndTextBox.TabIndex = 0;
            this.HwndTextBox.Text = "Hwnd";
            // 
            // WindowNameTextBox
            // 
            this.WindowNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowNameTextBox.Location = new System.Drawing.Point(12, 38);
            this.WindowNameTextBox.Name = "WindowNameTextBox";
            this.WindowNameTextBox.Size = new System.Drawing.Size(303, 20);
            this.WindowNameTextBox.TabIndex = 1;
            this.WindowNameTextBox.Text = "Window Title";
            // 
            // WindowClassTextBox
            // 
            this.WindowClassTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowClassTextBox.Location = new System.Drawing.Point(12, 64);
            this.WindowClassTextBox.Name = "WindowClassTextBox";
            this.WindowClassTextBox.ReadOnly = true;
            this.WindowClassTextBox.Size = new System.Drawing.Size(303, 20);
            this.WindowClassTextBox.TabIndex = 2;
            this.WindowClassTextBox.Text = "Window Class";
            // 
            // SetWindowTitleButton
            // 
            this.SetWindowTitleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetWindowTitleButton.Location = new System.Drawing.Point(321, 36);
            this.SetWindowTitleButton.Name = "SetWindowTitleButton";
            this.SetWindowTitleButton.Size = new System.Drawing.Size(75, 23);
            this.SetWindowTitleButton.TabIndex = 3;
            this.SetWindowTitleButton.Text = "Set";
            this.SetWindowTitleButton.UseVisualStyleBackColor = true;
            this.SetWindowTitleButton.Click += new System.EventHandler(this.SetWindowTitleButton_Click);
            // 
            // ProcessNameTextBox
            // 
            this.ProcessNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessNameTextBox.Location = new System.Drawing.Point(12, 326);
            this.ProcessNameTextBox.Name = "ProcessNameTextBox";
            this.ProcessNameTextBox.ReadOnly = true;
            this.ProcessNameTextBox.Size = new System.Drawing.Size(384, 20);
            this.ProcessNameTextBox.TabIndex = 4;
            this.ProcessNameTextBox.Text = "Main Executable";
            // 
            // WindowStylesTextBox
            // 
            this.WindowStylesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowStylesTextBox.Location = new System.Drawing.Point(12, 116);
            this.WindowStylesTextBox.Name = "WindowStylesTextBox";
            this.WindowStylesTextBox.ReadOnly = true;
            this.WindowStylesTextBox.Size = new System.Drawing.Size(384, 20);
            this.WindowStylesTextBox.TabIndex = 5;
            this.WindowStylesTextBox.Text = "Window Style";
            // 
            // WindowRectTextBox
            // 
            this.WindowRectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowRectTextBox.Location = new System.Drawing.Point(12, 142);
            this.WindowRectTextBox.Name = "WindowRectTextBox";
            this.WindowRectTextBox.ReadOnly = true;
            this.WindowRectTextBox.Size = new System.Drawing.Size(384, 20);
            this.WindowRectTextBox.TabIndex = 6;
            this.WindowRectTextBox.Text = "Window Rect";
            // 
            // ParentWindowButton
            // 
            this.ParentWindowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ParentWindowButton.Location = new System.Drawing.Point(321, 10);
            this.ParentWindowButton.Name = "ParentWindowButton";
            this.ParentWindowButton.Size = new System.Drawing.Size(75, 23);
            this.ParentWindowButton.TabIndex = 7;
            this.ParentWindowButton.Text = "Parent";
            this.ParentWindowButton.UseVisualStyleBackColor = true;
            this.ParentWindowButton.Click += new System.EventHandler(this.ParentWindowButton_Click);
            // 
            // EnableButton
            // 
            this.EnableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EnableButton.Location = new System.Drawing.Point(316, 14);
            this.EnableButton.Name = "EnableButton";
            this.EnableButton.Size = new System.Drawing.Size(75, 23);
            this.EnableButton.TabIndex = 8;
            this.EnableButton.Text = "Enable";
            this.EnableButton.UseVisualStyleBackColor = true;
            this.EnableButton.Click += new System.EventHandler(this.EnableButton_Click);
            // 
            // DisableButton
            // 
            this.DisableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DisableButton.Location = new System.Drawing.Point(235, 14);
            this.DisableButton.Name = "DisableButton";
            this.DisableButton.Size = new System.Drawing.Size(75, 23);
            this.DisableButton.TabIndex = 9;
            this.DisableButton.Text = "Disable";
            this.DisableButton.UseVisualStyleBackColor = true;
            this.DisableButton.Click += new System.EventHandler(this.DisableButton_Click);
            // 
            // EnableWindowGroupBox
            // 
            this.EnableWindowGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnableWindowGroupBox.Controls.Add(this.label1);
            this.EnableWindowGroupBox.Controls.Add(this.EnableWindowDelayUpDown);
            this.EnableWindowGroupBox.Controls.Add(this.DisableButton);
            this.EnableWindowGroupBox.Controls.Add(this.EnableButton);
            this.EnableWindowGroupBox.Location = new System.Drawing.Point(5, 171);
            this.EnableWindowGroupBox.Name = "EnableWindowGroupBox";
            this.EnableWindowGroupBox.Size = new System.Drawing.Size(397, 45);
            this.EnableWindowGroupBox.TabIndex = 11;
            this.EnableWindowGroupBox.TabStop = false;
            this.EnableWindowGroupBox.Text = "EnableWindow";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Milliseconds Delay";
            // 
            // EnableWindowDelayUpDown
            // 
            this.EnableWindowDelayUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnableWindowDelayUpDown.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.EnableWindowDelayUpDown.Location = new System.Drawing.Point(7, 17);
            this.EnableWindowDelayUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.EnableWindowDelayUpDown.Name = "EnableWindowDelayUpDown";
            this.EnableWindowDelayUpDown.Size = new System.Drawing.Size(122, 20);
            this.EnableWindowDelayUpDown.TabIndex = 10;
            this.EnableWindowDelayUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EnableWindowDelayUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // ShowWindowGroupBox
            // 
            this.ShowWindowGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowWindowGroupBox.Controls.Add(this.CmdShowWindowComboBox);
            this.ShowWindowGroupBox.Controls.Add(this.ShowWindowButton);
            this.ShowWindowGroupBox.Location = new System.Drawing.Point(5, 222);
            this.ShowWindowGroupBox.Name = "ShowWindowGroupBox";
            this.ShowWindowGroupBox.Size = new System.Drawing.Size(397, 45);
            this.ShowWindowGroupBox.TabIndex = 12;
            this.ShowWindowGroupBox.TabStop = false;
            this.ShowWindowGroupBox.Text = "ShowWindow";
            // 
            // CmdShowWindowComboBox
            // 
            this.CmdShowWindowComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdShowWindowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmdShowWindowComboBox.FormattingEnabled = true;
            this.CmdShowWindowComboBox.Location = new System.Drawing.Point(7, 14);
            this.CmdShowWindowComboBox.Name = "CmdShowWindowComboBox";
            this.CmdShowWindowComboBox.Size = new System.Drawing.Size(303, 21);
            this.CmdShowWindowComboBox.TabIndex = 10;
            // 
            // ShowWindowButton
            // 
            this.ShowWindowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowWindowButton.Location = new System.Drawing.Point(316, 14);
            this.ShowWindowButton.Name = "ShowWindowButton";
            this.ShowWindowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowWindowButton.TabIndex = 8;
            this.ShowWindowButton.Text = "Show";
            this.ShowWindowButton.UseVisualStyleBackColor = true;
            this.ShowWindowButton.Click += new System.EventHandler(this.ShowWindowButton_Click);
            // 
            // PostMessageGroupBox
            // 
            this.PostMessageGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostMessageGroupBox.Controls.Add(this.LparamUpDown);
            this.PostMessageGroupBox.Controls.Add(this.WparamUpDown);
            this.PostMessageGroupBox.Controls.Add(this.WindowMessageComboBox);
            this.PostMessageGroupBox.Controls.Add(this.PostMessageButton);
            this.PostMessageGroupBox.Location = new System.Drawing.Point(5, 273);
            this.PostMessageGroupBox.Name = "PostMessageGroupBox";
            this.PostMessageGroupBox.Size = new System.Drawing.Size(397, 45);
            this.PostMessageGroupBox.TabIndex = 13;
            this.PostMessageGroupBox.TabStop = false;
            this.PostMessageGroupBox.Text = "PostMessage";
            // 
            // LparamUpDown
            // 
            this.LparamUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LparamUpDown.Location = new System.Drawing.Point(242, 17);
            this.LparamUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.LparamUpDown.Name = "LparamUpDown";
            this.LparamUpDown.Size = new System.Drawing.Size(68, 20);
            this.LparamUpDown.TabIndex = 13;
            this.LparamUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LparamUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // WparamUpDown
            // 
            this.WparamUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WparamUpDown.Location = new System.Drawing.Point(168, 17);
            this.WparamUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.WparamUpDown.Name = "WparamUpDown";
            this.WparamUpDown.Size = new System.Drawing.Size(68, 20);
            this.WparamUpDown.TabIndex = 12;
            this.WparamUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WparamUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // WindowMessageComboBox
            // 
            this.WindowMessageComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowMessageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WindowMessageComboBox.FormattingEnabled = true;
            this.WindowMessageComboBox.Location = new System.Drawing.Point(7, 16);
            this.WindowMessageComboBox.Name = "WindowMessageComboBox";
            this.WindowMessageComboBox.Size = new System.Drawing.Size(155, 21);
            this.WindowMessageComboBox.TabIndex = 12;
            // 
            // PostMessageButton
            // 
            this.PostMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PostMessageButton.Location = new System.Drawing.Point(316, 16);
            this.PostMessageButton.Name = "PostMessageButton";
            this.PostMessageButton.Size = new System.Drawing.Size(75, 23);
            this.PostMessageButton.TabIndex = 8;
            this.PostMessageButton.Text = "Post";
            this.PostMessageButton.UseVisualStyleBackColor = true;
            this.PostMessageButton.Click += new System.EventHandler(this.PostMessageButton_Click);
            // 
            // SetForegroundWindowButton
            // 
            this.SetForegroundWindowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetForegroundWindowButton.Location = new System.Drawing.Point(321, 61);
            this.SetForegroundWindowButton.Name = "SetForegroundWindowButton";
            this.SetForegroundWindowButton.Size = new System.Drawing.Size(75, 23);
            this.SetForegroundWindowButton.TabIndex = 14;
            this.SetForegroundWindowButton.Text = "Foreground";
            this.SetForegroundWindowButton.UseVisualStyleBackColor = true;
            this.SetForegroundWindowButton.Click += new System.EventHandler(this.SetForegroundWindowButton_Click);
            // 
            // RealGetWindowClassTextBox
            // 
            this.RealGetWindowClassTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RealGetWindowClassTextBox.Location = new System.Drawing.Point(12, 90);
            this.RealGetWindowClassTextBox.Name = "RealGetWindowClassTextBox";
            this.RealGetWindowClassTextBox.ReadOnly = true;
            this.RealGetWindowClassTextBox.Size = new System.Drawing.Size(303, 20);
            this.RealGetWindowClassTextBox.TabIndex = 15;
            this.RealGetWindowClassTextBox.Text = "Real Window Class";
            // 
            // WindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 380);
            this.Controls.Add(this.RealGetWindowClassTextBox);
            this.Controls.Add(this.SetForegroundWindowButton);
            this.Controls.Add(this.PostMessageGroupBox);
            this.Controls.Add(this.ShowWindowGroupBox);
            this.Controls.Add(this.EnableWindowGroupBox);
            this.Controls.Add(this.ParentWindowButton);
            this.Controls.Add(this.WindowRectTextBox);
            this.Controls.Add(this.WindowStylesTextBox);
            this.Controls.Add(this.ProcessNameTextBox);
            this.Controls.Add(this.SetWindowTitleButton);
            this.Controls.Add(this.WindowClassTextBox);
            this.Controls.Add(this.WindowNameTextBox);
            this.Controls.Add(this.HwndTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowForm";
            this.ShowIcon = false;
            this.Text = "Jane - Window";
            this.EnableWindowGroupBox.ResumeLayout(false);
            this.EnableWindowGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnableWindowDelayUpDown)).EndInit();
            this.ShowWindowGroupBox.ResumeLayout(false);
            this.PostMessageGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LparamUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WparamUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HwndTextBox;
        private System.Windows.Forms.TextBox WindowNameTextBox;
        private System.Windows.Forms.TextBox WindowClassTextBox;
        private System.Windows.Forms.Button SetWindowTitleButton;
        private System.Windows.Forms.TextBox ProcessNameTextBox;
        private System.Windows.Forms.TextBox WindowStylesTextBox;
        private System.Windows.Forms.TextBox WindowRectTextBox;
        private System.Windows.Forms.Button ParentWindowButton;
        private System.Windows.Forms.Button EnableButton;
        private System.Windows.Forms.Button DisableButton;
        private System.Windows.Forms.GroupBox EnableWindowGroupBox;
        private System.Windows.Forms.NumericUpDown EnableWindowDelayUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ShowWindowGroupBox;
        private System.Windows.Forms.ComboBox CmdShowWindowComboBox;
        private System.Windows.Forms.Button ShowWindowButton;
        private System.Windows.Forms.GroupBox PostMessageGroupBox;
        private System.Windows.Forms.Button PostMessageButton;
        private System.Windows.Forms.Button SetForegroundWindowButton;
        private System.Windows.Forms.TextBox RealGetWindowClassTextBox;
        private System.Windows.Forms.ComboBox WindowMessageComboBox;
        private System.Windows.Forms.NumericUpDown LparamUpDown;
        private System.Windows.Forms.NumericUpDown WparamUpDown;
    }
}