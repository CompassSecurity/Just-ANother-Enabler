
namespace Jane
{
    partial class MainForm
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
            this.btnListWindows = new System.Windows.Forms.Button();
            this.btnListMenus = new System.Windows.Forms.Button();
            this.WindowTitleTextBox = new System.Windows.Forms.TextBox();
            this.btnEnableWins = new System.Windows.Forms.Button();
            this.btnEnableMenu = new System.Windows.Forms.Button();
            this.WindowListBox = new System.Windows.Forms.ListBox();
            this.DragLabel = new System.Windows.Forms.Label();
            this.HwndTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnListWindows
            // 
            this.btnListWindows.Location = new System.Drawing.Point(12, 59);
            this.btnListWindows.Name = "btnListWindows";
            this.btnListWindows.Size = new System.Drawing.Size(132, 23);
            this.btnListWindows.TabIndex = 1;
            this.btnListWindows.Text = "List Windows";
            this.btnListWindows.UseVisualStyleBackColor = true;
            this.btnListWindows.Click += new System.EventHandler(this.BtnListWindows_Click);
            // 
            // btnListMenus
            // 
            this.btnListMenus.Location = new System.Drawing.Point(150, 59);
            this.btnListMenus.Name = "btnListMenus";
            this.btnListMenus.Size = new System.Drawing.Size(132, 23);
            this.btnListMenus.TabIndex = 2;
            this.btnListMenus.Text = "List Menus";
            this.btnListMenus.UseVisualStyleBackColor = true;
            this.btnListMenus.Click += new System.EventHandler(this.BtnListMenus_Click);
            // 
            // WindowTitleTextBox
            // 
            this.WindowTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowTitleTextBox.Location = new System.Drawing.Point(12, 7);
            this.WindowTitleTextBox.Name = "WindowTitleTextBox";
            this.WindowTitleTextBox.Size = new System.Drawing.Size(270, 20);
            this.WindowTitleTextBox.TabIndex = 3;
            this.WindowTitleTextBox.Text = "WindowTitleHere";
            this.WindowTitleTextBox.Leave += new System.EventHandler(this.WindowTitleTextBox_Leave);
            // 
            // btnEnableWins
            // 
            this.btnEnableWins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEnableWins.Location = new System.Drawing.Point(12, 293);
            this.btnEnableWins.Name = "btnEnableWins";
            this.btnEnableWins.Size = new System.Drawing.Size(132, 23);
            this.btnEnableWins.TabIndex = 7;
            this.btnEnableWins.Text = "Enable Windows";
            this.btnEnableWins.UseVisualStyleBackColor = true;
            this.btnEnableWins.Click += new System.EventHandler(this.BtnEnableWindows_Click);
            // 
            // btnEnableMenu
            // 
            this.btnEnableMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEnableMenu.Location = new System.Drawing.Point(150, 293);
            this.btnEnableMenu.Name = "btnEnableMenu";
            this.btnEnableMenu.Size = new System.Drawing.Size(132, 23);
            this.btnEnableMenu.TabIndex = 8;
            this.btnEnableMenu.Text = "Enable Menus";
            this.btnEnableMenu.UseVisualStyleBackColor = true;
            this.btnEnableMenu.Click += new System.EventHandler(this.BtnEnableMenu_Click);
            // 
            // WindowListBox
            // 
            this.WindowListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowListBox.FormattingEnabled = true;
            this.WindowListBox.Location = new System.Drawing.Point(12, 88);
            this.WindowListBox.Name = "WindowListBox";
            this.WindowListBox.Size = new System.Drawing.Size(270, 199);
            this.WindowListBox.TabIndex = 9;
            this.WindowListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // DragLabel
            // 
            this.DragLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DragLabel.AutoSize = true;
            this.DragLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DragLabel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DragLabel.Location = new System.Drawing.Point(263, 36);
            this.DragLabel.Name = "DragLabel";
            this.DragLabel.Size = new System.Drawing.Size(17, 13);
            this.DragLabel.TabIndex = 11;
            this.DragLabel.Text = "✠";
            this.DragLabel.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.DragLabel_GiveFeedback);
            this.DragLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragLabel_MouseDown);
            // 
            // HwndTextBox
            // 
            this.HwndTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HwndTextBox.Location = new System.Drawing.Point(12, 33);
            this.HwndTextBox.Name = "HwndTextBox";
            this.HwndTextBox.ReadOnly = true;
            this.HwndTextBox.Size = new System.Drawing.Size(245, 20);
            this.HwndTextBox.TabIndex = 12;
            this.HwndTextBox.Text = "Hwnd";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(294, 318);
            this.Controls.Add(this.HwndTextBox);
            this.Controls.Add(this.DragLabel);
            this.Controls.Add(this.WindowListBox);
            this.Controls.Add(this.btnEnableMenu);
            this.Controls.Add(this.btnEnableWins);
            this.Controls.Add(this.WindowTitleTextBox);
            this.Controls.Add(this.btnListMenus);
            this.Controls.Add(this.btnListWindows);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Jane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListWindows;
        private System.Windows.Forms.Button btnListMenus;
        private System.Windows.Forms.TextBox WindowTitleTextBox;
        private System.Windows.Forms.Button btnEnableWins;
        private System.Windows.Forms.Button btnEnableMenu;
        private System.Windows.Forms.Label DragLabel;
        private System.Windows.Forms.TextBox HwndTextBox;
        private System.Windows.Forms.ListBox WindowListBox;
    }
}

