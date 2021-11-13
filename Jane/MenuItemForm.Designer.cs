
namespace Jane
{
    partial class MenuItemForm
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
            this.MenuStatusTextBox = new System.Windows.Forms.TextBox();
            this.MenuTextTextBox = new System.Windows.Forms.TextBox();
            this.HMenuTextBox = new System.Windows.Forms.TextBox();
            this.MenuIndexTextBox = new System.Windows.Forms.TextBox();
            this.WindowButton = new System.Windows.Forms.Button();
            this.HiliteButton = new System.Windows.Forms.Button();
            this.EnableButton = new System.Windows.Forms.Button();
            this.DisableButton = new System.Windows.Forms.Button();
            this.GrayOutButton = new System.Windows.Forms.Button();
            this.EnableMenuGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ActionDelay = new System.Windows.Forms.NumericUpDown();
            this.UnHiliteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LpNewItemTextBox = new System.Windows.Forms.TextBox();
            this.UIDNewItemUpDown = new System.Windows.Forms.NumericUpDown();
            this.ModifyMenuButton = new System.Windows.Forms.Button();
            this.MenuFlagsComboBox = new System.Windows.Forms.ComboBox();
            this.EnableMenuGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActionDelay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UIDNewItemUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStatusTextBox
            // 
            this.MenuStatusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuStatusTextBox.Location = new System.Drawing.Point(12, 64);
            this.MenuStatusTextBox.Name = "MenuStatusTextBox";
            this.MenuStatusTextBox.ReadOnly = true;
            this.MenuStatusTextBox.Size = new System.Drawing.Size(287, 20);
            this.MenuStatusTextBox.TabIndex = 5;
            this.MenuStatusTextBox.Text = "Menu Status";
            // 
            // MenuTextTextBox
            // 
            this.MenuTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuTextTextBox.Location = new System.Drawing.Point(12, 38);
            this.MenuTextTextBox.Name = "MenuTextTextBox";
            this.MenuTextTextBox.Size = new System.Drawing.Size(287, 20);
            this.MenuTextTextBox.TabIndex = 4;
            this.MenuTextTextBox.Text = "Menu Text";
            // 
            // HMenuTextBox
            // 
            this.HMenuTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HMenuTextBox.Location = new System.Drawing.Point(12, 12);
            this.HMenuTextBox.Name = "HMenuTextBox";
            this.HMenuTextBox.ReadOnly = true;
            this.HMenuTextBox.Size = new System.Drawing.Size(141, 20);
            this.HMenuTextBox.TabIndex = 3;
            this.HMenuTextBox.Text = "HMenu";
            // 
            // MenuIndexTextBox
            // 
            this.MenuIndexTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuIndexTextBox.Location = new System.Drawing.Point(159, 12);
            this.MenuIndexTextBox.Name = "MenuIndexTextBox";
            this.MenuIndexTextBox.ReadOnly = true;
            this.MenuIndexTextBox.Size = new System.Drawing.Size(59, 20);
            this.MenuIndexTextBox.TabIndex = 6;
            this.MenuIndexTextBox.Text = "Index";
            // 
            // WindowButton
            // 
            this.WindowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowButton.Location = new System.Drawing.Point(224, 10);
            this.WindowButton.Name = "WindowButton";
            this.WindowButton.Size = new System.Drawing.Size(75, 23);
            this.WindowButton.TabIndex = 8;
            this.WindowButton.Text = "Window";
            this.WindowButton.UseVisualStyleBackColor = true;
            this.WindowButton.Click += new System.EventHandler(this.WindowButton_Click);
            // 
            // HiliteButton
            // 
            this.HiliteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HiliteButton.Location = new System.Drawing.Point(206, 14);
            this.HiliteButton.Name = "HiliteButton";
            this.HiliteButton.Size = new System.Drawing.Size(75, 23);
            this.HiliteButton.TabIndex = 9;
            this.HiliteButton.Text = "Hilite";
            this.HiliteButton.UseVisualStyleBackColor = true;
            this.HiliteButton.Click += new System.EventHandler(this.HiliteButton_Click);
            // 
            // EnableButton
            // 
            this.EnableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EnableButton.Location = new System.Drawing.Point(125, 13);
            this.EnableButton.Name = "EnableButton";
            this.EnableButton.Size = new System.Drawing.Size(75, 23);
            this.EnableButton.TabIndex = 10;
            this.EnableButton.Text = "Enable";
            this.EnableButton.UseVisualStyleBackColor = true;
            this.EnableButton.Click += new System.EventHandler(this.EnableButton_Click);
            // 
            // DisableButton
            // 
            this.DisableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DisableButton.Location = new System.Drawing.Point(206, 13);
            this.DisableButton.Name = "DisableButton";
            this.DisableButton.Size = new System.Drawing.Size(75, 23);
            this.DisableButton.TabIndex = 11;
            this.DisableButton.Text = "Disable";
            this.DisableButton.UseVisualStyleBackColor = true;
            this.DisableButton.Click += new System.EventHandler(this.DisableButton_Click);
            // 
            // GrayOutButton
            // 
            this.GrayOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrayOutButton.Location = new System.Drawing.Point(206, 42);
            this.GrayOutButton.Name = "GrayOutButton";
            this.GrayOutButton.Size = new System.Drawing.Size(75, 23);
            this.GrayOutButton.TabIndex = 12;
            this.GrayOutButton.Text = "Gray Out";
            this.GrayOutButton.UseVisualStyleBackColor = true;
            this.GrayOutButton.Click += new System.EventHandler(this.GrayOutButton_Click);
            // 
            // EnableMenuGroupBox
            // 
            this.EnableMenuGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnableMenuGroupBox.Controls.Add(this.label1);
            this.EnableMenuGroupBox.Controls.Add(this.GrayOutButton);
            this.EnableMenuGroupBox.Controls.Add(this.ActionDelay);
            this.EnableMenuGroupBox.Controls.Add(this.DisableButton);
            this.EnableMenuGroupBox.Controls.Add(this.EnableButton);
            this.EnableMenuGroupBox.Location = new System.Drawing.Point(12, 90);
            this.EnableMenuGroupBox.Name = "EnableMenuGroupBox";
            this.EnableMenuGroupBox.Size = new System.Drawing.Size(287, 75);
            this.EnableMenuGroupBox.TabIndex = 13;
            this.EnableMenuGroupBox.TabStop = false;
            this.EnableMenuGroupBox.Text = "EnableMenu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ms Delay";
            // 
            // ActionDelay
            // 
            this.ActionDelay.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ActionDelay.Location = new System.Drawing.Point(6, 16);
            this.ActionDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ActionDelay.Name = "ActionDelay";
            this.ActionDelay.Size = new System.Drawing.Size(60, 20);
            this.ActionDelay.TabIndex = 10;
            this.ActionDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ActionDelay.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // UnHiliteButton
            // 
            this.UnHiliteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnHiliteButton.Location = new System.Drawing.Point(206, 43);
            this.UnHiliteButton.Name = "UnHiliteButton";
            this.UnHiliteButton.Size = new System.Drawing.Size(75, 23);
            this.UnHiliteButton.TabIndex = 14;
            this.UnHiliteButton.Text = "UnHilite";
            this.UnHiliteButton.UseVisualStyleBackColor = true;
            this.UnHiliteButton.Click += new System.EventHandler(this.UnHiliteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.HiliteButton);
            this.groupBox1.Controls.Add(this.UnHiliteButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 71);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HiliteMenuItem";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.LpNewItemTextBox);
            this.groupBox2.Controls.Add(this.UIDNewItemUpDown);
            this.groupBox2.Controls.Add(this.ModifyMenuButton);
            this.groupBox2.Controls.Add(this.MenuFlagsComboBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 98);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ModifyMenu";
            // 
            // LpNewItemTextBox
            // 
            this.LpNewItemTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LpNewItemTextBox.Location = new System.Drawing.Point(6, 68);
            this.LpNewItemTextBox.Name = "LpNewItemTextBox";
            this.LpNewItemTextBox.Size = new System.Drawing.Size(194, 20);
            this.LpNewItemTextBox.TabIndex = 17;
            this.LpNewItemTextBox.Text = "lpNewItem";
            // 
            // UIDNewItemUpDown
            // 
            this.UIDNewItemUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UIDNewItemUpDown.Location = new System.Drawing.Point(6, 42);
            this.UIDNewItemUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UIDNewItemUpDown.Name = "UIDNewItemUpDown";
            this.UIDNewItemUpDown.Size = new System.Drawing.Size(194, 20);
            this.UIDNewItemUpDown.TabIndex = 13;
            this.UIDNewItemUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UIDNewItemUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // ModifyMenuButton
            // 
            this.ModifyMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyMenuButton.Location = new System.Drawing.Point(206, 42);
            this.ModifyMenuButton.Name = "ModifyMenuButton";
            this.ModifyMenuButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyMenuButton.TabIndex = 12;
            this.ModifyMenuButton.Text = "Modify";
            this.ModifyMenuButton.UseVisualStyleBackColor = true;
            this.ModifyMenuButton.Click += new System.EventHandler(this.ModifyMenuButton_Click);
            // 
            // MenuFlagsComboBox
            // 
            this.MenuFlagsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuFlagsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MenuFlagsComboBox.Items.AddRange(new object[] {
            "MF_BITMAP",
            "MF_CHECKED",
            "MF_DISABLED",
            "MF_ENABLED",
            "MF_GRAYED",
            "MF_MENUBARBREAK",
            "MF_MENUBREAK",
            "MF_OWNERDRAW",
            "MF_POPUP",
            "MF_SEPARATOR",
            "MF_STRING",
            "MF_UNCHECKED"});
            this.MenuFlagsComboBox.Location = new System.Drawing.Point(6, 15);
            this.MenuFlagsComboBox.Name = "MenuFlagsComboBox";
            this.MenuFlagsComboBox.Size = new System.Drawing.Size(194, 21);
            this.MenuFlagsComboBox.TabIndex = 11;
            // 
            // MenuItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 342);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EnableMenuGroupBox);
            this.Controls.Add(this.WindowButton);
            this.Controls.Add(this.MenuIndexTextBox);
            this.Controls.Add(this.MenuStatusTextBox);
            this.Controls.Add(this.MenuTextTextBox);
            this.Controls.Add(this.HMenuTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuItemForm";
            this.ShowIcon = false;
            this.Text = "Jane - Menu";
            this.EnableMenuGroupBox.ResumeLayout(false);
            this.EnableMenuGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActionDelay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UIDNewItemUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MenuStatusTextBox;
        private System.Windows.Forms.TextBox MenuTextTextBox;
        private System.Windows.Forms.TextBox HMenuTextBox;
        private System.Windows.Forms.TextBox MenuIndexTextBox;
        private System.Windows.Forms.Button WindowButton;
        private System.Windows.Forms.Button HiliteButton;
        private System.Windows.Forms.Button EnableButton;
        private System.Windows.Forms.Button DisableButton;
        private System.Windows.Forms.Button GrayOutButton;
        private System.Windows.Forms.GroupBox EnableMenuGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ActionDelay;
        private System.Windows.Forms.Button UnHiliteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox MenuFlagsComboBox;
        private System.Windows.Forms.Button ModifyMenuButton;
        private System.Windows.Forms.TextBox LpNewItemTextBox;
        private System.Windows.Forms.NumericUpDown UIDNewItemUpDown;
    }
}