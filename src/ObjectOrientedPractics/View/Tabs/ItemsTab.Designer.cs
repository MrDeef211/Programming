namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
			this.ItemsListBox = new System.Windows.Forms.ListBox();
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.ItemLable1 = new System.Windows.Forms.Label();
			this.ItemsSplitContainer = new System.Windows.Forms.SplitContainer();
			this.CategoryComboBox = new System.Windows.Forms.ComboBox();
			this.CategoryLabel = new System.Windows.Forms.Label();
			this.DescriptionTextBox = new System.Windows.Forms.TextBox();
			this.DescriptionLabel = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.NameLabel = new System.Windows.Forms.Label();
			this.CostLabel = new System.Windows.Forms.Label();
			this.IDLabel = new System.Windows.Forms.Label();
			this.CostTextBox = new System.Windows.Forms.TextBox();
			this.IDTextBox = new System.Windows.Forms.TextBox();
			this.ItemLable2 = new System.Windows.Forms.Label();
			this.FindLabel = new System.Windows.Forms.Label();
			this.FindTextBox = new System.Windows.Forms.TextBox();
			this.SortLabel = new System.Windows.Forms.Label();
			this.SortComboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.ButtonsTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ItemsSplitContainer)).BeginInit();
			this.ItemsSplitContainer.Panel1.SuspendLayout();
			this.ItemsSplitContainer.Panel2.SuspendLayout();
			this.ItemsSplitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// ItemsListBox
			// 
			this.ItemsListBox.AccessibleName = "";
			this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ItemsListBox.FormattingEnabled = true;
			this.ItemsListBox.ItemHeight = 16;
			this.ItemsListBox.Location = new System.Drawing.Point(3, 57);
			this.ItemsListBox.Name = "ItemsListBox";
			this.ItemsListBox.Size = new System.Drawing.Size(423, 436);
			this.ItemsListBox.TabIndex = 0;
			this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
			this.ItemsListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemsListBox_KeyPress);
			this.ItemsListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ItemsListBox_MouseDown);
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// RemoveButton
			// 
			this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveButton.Location = new System.Drawing.Point(144, 3);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(135, 56);
			this.RemoveButton.TabIndex = 1;
			this.RemoveButton.Text = "Remove";
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
			// 
			// AddButton
			// 
			this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddButton.Location = new System.Drawing.Point(3, 3);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(135, 56);
			this.AddButton.TabIndex = 0;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// ButtonsTableLayoutPanel
			// 
			this.ButtonsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonsTableLayoutPanel.ColumnCount = 3;
			this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ButtonsTableLayoutPanel.Controls.Add(this.RemoveButton, 1, 0);
			this.ButtonsTableLayoutPanel.Controls.Add(this.AddButton, 0, 0);
			this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 527);
			this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
			this.ButtonsTableLayoutPanel.RowCount = 1;
			this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(423, 66);
			this.ButtonsTableLayoutPanel.TabIndex = 2;
			// 
			// ItemLable1
			// 
			this.ItemLable1.AutoSize = true;
			this.ItemLable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ItemLable1.Location = new System.Drawing.Point(3, 6);
			this.ItemLable1.Name = "ItemLable1";
			this.ItemLable1.Size = new System.Drawing.Size(44, 16);
			this.ItemLable1.TabIndex = 0;
			this.ItemLable1.Text = "Items";
			// 
			// ItemsSplitContainer
			// 
			this.ItemsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ItemsSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.ItemsSplitContainer.MinimumSize = new System.Drawing.Size(600, 450);
			this.ItemsSplitContainer.Name = "ItemsSplitContainer";
			// 
			// ItemsSplitContainer.Panel1
			// 
			this.ItemsSplitContainer.Panel1.Controls.Add(this.SortComboBox);
			this.ItemsSplitContainer.Panel1.Controls.Add(this.SortLabel);
			this.ItemsSplitContainer.Panel1.Controls.Add(this.FindTextBox);
			this.ItemsSplitContainer.Panel1.Controls.Add(this.FindLabel);
			this.ItemsSplitContainer.Panel1.Controls.Add(this.ButtonsTableLayoutPanel);
			this.ItemsSplitContainer.Panel1.Controls.Add(this.ItemLable1);
			this.ItemsSplitContainer.Panel1.Controls.Add(this.ItemsListBox);
			// 
			// ItemsSplitContainer.Panel2
			// 
			this.ItemsSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ItemsSplitContainer.Panel2.Controls.Add(this.CategoryComboBox);
			this.ItemsSplitContainer.Panel2.Controls.Add(this.CategoryLabel);
			this.ItemsSplitContainer.Panel2.Controls.Add(this.DescriptionTextBox);
			this.ItemsSplitContainer.Panel2.Controls.Add(this.DescriptionLabel);
			this.ItemsSplitContainer.Panel2.Controls.Add(this.NameTextBox);
			this.ItemsSplitContainer.Panel2.Controls.Add(this.NameLabel);
			this.ItemsSplitContainer.Panel2.Controls.Add(this.CostLabel);
			this.ItemsSplitContainer.Panel2.Controls.Add(this.IDLabel);
			this.ItemsSplitContainer.Panel2.Controls.Add(this.CostTextBox);
			this.ItemsSplitContainer.Panel2.Controls.Add(this.IDTextBox);
			this.ItemsSplitContainer.Panel2.Controls.Add(this.ItemLable2);
			this.ItemsSplitContainer.Size = new System.Drawing.Size(957, 596);
			this.ItemsSplitContainer.SplitterDistance = 429;
			this.ItemsSplitContainer.TabIndex = 2;
			// 
			// CategoryComboBox
			// 
			this.CategoryComboBox.FormattingEnabled = true;
			this.CategoryComboBox.Location = new System.Drawing.Point(76, 99);
			this.CategoryComboBox.Name = "CategoryComboBox";
			this.CategoryComboBox.Size = new System.Drawing.Size(148, 24);
			this.CategoryComboBox.TabIndex = 20;
			// 
			// CategoryLabel
			// 
			this.CategoryLabel.AutoSize = true;
			this.CategoryLabel.Location = new System.Drawing.Point(6, 101);
			this.CategoryLabel.Name = "CategoryLabel";
			this.CategoryLabel.Size = new System.Drawing.Size(65, 16);
			this.CategoryLabel.TabIndex = 19;
			this.CategoryLabel.Text = "Category:";
			// 
			// DescriptionTextBox
			// 
			this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DescriptionTextBox.Location = new System.Drawing.Point(7, 297);
			this.DescriptionTextBox.Multiline = true;
			this.DescriptionTextBox.Name = "DescriptionTextBox";
			this.DescriptionTextBox.Size = new System.Drawing.Size(439, 137);
			this.DescriptionTextBox.TabIndex = 18;
			this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_Change);
			// 
			// DescriptionLabel
			// 
			this.DescriptionLabel.AutoSize = true;
			this.DescriptionLabel.Location = new System.Drawing.Point(6, 278);
			this.DescriptionLabel.Name = "DescriptionLabel";
			this.DescriptionLabel.Size = new System.Drawing.Size(78, 16);
			this.DescriptionLabel.TabIndex = 17;
			this.DescriptionLabel.Text = "Description:";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NameTextBox.Location = new System.Drawing.Point(7, 154);
			this.NameTextBox.Multiline = true;
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(439, 93);
			this.NameTextBox.TabIndex = 16;
			this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_Change);
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(6, 135);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(47, 16);
			this.NameLabel.TabIndex = 15;
			this.NameLabel.Text = "Name:";
			// 
			// CostLabel
			// 
			this.CostLabel.AutoSize = true;
			this.CostLabel.Location = new System.Drawing.Point(6, 74);
			this.CostLabel.Name = "CostLabel";
			this.CostLabel.Size = new System.Drawing.Size(37, 16);
			this.CostLabel.TabIndex = 14;
			this.CostLabel.Text = "Cost:";
			// 
			// IDLabel
			// 
			this.IDLabel.AutoSize = true;
			this.IDLabel.Location = new System.Drawing.Point(6, 46);
			this.IDLabel.Name = "IDLabel";
			this.IDLabel.Size = new System.Drawing.Size(23, 16);
			this.IDLabel.TabIndex = 13;
			this.IDLabel.Text = "ID:";
			// 
			// CostTextBox
			// 
			this.CostTextBox.ForeColor = System.Drawing.Color.Black;
			this.CostTextBox.Location = new System.Drawing.Point(76, 71);
			this.CostTextBox.Name = "CostTextBox";
			this.CostTextBox.Size = new System.Drawing.Size(148, 22);
			this.CostTextBox.TabIndex = 12;
			this.CostTextBox.TextChanged += new System.EventHandler(this.CostTexBox_Change);
			// 
			// IDTextBox
			// 
			this.IDTextBox.Enabled = false;
			this.IDTextBox.Location = new System.Drawing.Point(76, 43);
			this.IDTextBox.Name = "IDTextBox";
			this.IDTextBox.Size = new System.Drawing.Size(148, 22);
			this.IDTextBox.TabIndex = 11;
			// 
			// ItemLable2
			// 
			this.ItemLable2.AutoSize = true;
			this.ItemLable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ItemLable2.Location = new System.Drawing.Point(4, 6);
			this.ItemLable2.Name = "ItemLable2";
			this.ItemLable2.Size = new System.Drawing.Size(84, 16);
			this.ItemLable2.TabIndex = 10;
			this.ItemLable2.Text = "Select Item";
			// 
			// FindLabel
			// 
			this.FindLabel.AutoSize = true;
			this.FindLabel.Location = new System.Drawing.Point(3, 29);
			this.FindLabel.Name = "FindLabel";
			this.FindLabel.Size = new System.Drawing.Size(36, 16);
			this.FindLabel.TabIndex = 3;
			this.FindLabel.Text = "Find:";
			// 
			// FindTextBox
			// 
			this.FindTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FindTextBox.Location = new System.Drawing.Point(45, 26);
			this.FindTextBox.Name = "FindTextBox";
			this.FindTextBox.Size = new System.Drawing.Size(381, 22);
			this.FindTextBox.TabIndex = 4;
			this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
			// 
			// SortLabel
			// 
			this.SortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SortLabel.AutoSize = true;
			this.SortLabel.Location = new System.Drawing.Point(3, 500);
			this.SortLabel.Name = "SortLabel";
			this.SortLabel.Size = new System.Drawing.Size(53, 16);
			this.SortLabel.TabIndex = 5;
			this.SortLabel.Text = "Sort By:";
			// 
			// SortComboBox
			// 
			this.SortComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SortComboBox.FormattingEnabled = true;
			this.SortComboBox.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Cost(Ascending)",
            "Cost(Descending)"});
			this.SortComboBox.Location = new System.Drawing.Point(62, 497);
			this.SortComboBox.Name = "SortComboBox";
			this.SortComboBox.Size = new System.Drawing.Size(364, 24);
			this.SortComboBox.TabIndex = 6;
			this.SortComboBox.SelectedIndexChanged += new System.EventHandler(this.SortComboBox_SelectedIndexChanged);
			// 
			// ItemsTab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ItemsSplitContainer);
			this.Name = "ItemsTab";
			this.Size = new System.Drawing.Size(957, 596);
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.ButtonsTableLayoutPanel.ResumeLayout(false);
			this.ItemsSplitContainer.Panel1.ResumeLayout(false);
			this.ItemsSplitContainer.Panel1.PerformLayout();
			this.ItemsSplitContainer.Panel2.ResumeLayout(false);
			this.ItemsSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ItemsSplitContainer)).EndInit();
			this.ItemsSplitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ItemsListBox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.SplitContainer ItemsSplitContainer;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label ItemLable1;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label ItemLable2;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
		private System.Windows.Forms.TextBox FindTextBox;
		private System.Windows.Forms.Label FindLabel;
		private System.Windows.Forms.ComboBox SortComboBox;
		private System.Windows.Forms.Label SortLabel;
	}
}
