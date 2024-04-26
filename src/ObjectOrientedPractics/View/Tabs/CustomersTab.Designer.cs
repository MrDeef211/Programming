namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            ObjectOrientedPractics.Model.Address address1 = new ObjectOrientedPractics.Model.Address();
            this.ItemsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.IsPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.CustomersLable2 = new System.Windows.Forms.Label();
            this.DiscountsLabel = new System.Windows.Forms.Label();
            this.DiscountsListBox = new System.Windows.Forms.ListBox();
            this.AddDiscountButton = new System.Windows.Forms.Button();
            this.RemoveDiscountButton = new System.Windows.Forms.Button();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsSplitContainer)).BeginInit();
            this.ItemsSplitContainer.Panel1.SuspendLayout();
            this.ItemsSplitContainer.Panel2.SuspendLayout();
            this.ItemsSplitContainer.SuspendLayout();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsSplitContainer
            // 
            this.ItemsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ItemsSplitContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemsSplitContainer.MinimumSize = new System.Drawing.Size(600, 450);
            this.ItemsSplitContainer.Name = "ItemsSplitContainer";
            // 
            // ItemsSplitContainer.Panel1
            // 
            this.ItemsSplitContainer.Panel1.Controls.Add(this.ButtonsTableLayoutPanel);
            this.ItemsSplitContainer.Panel1.Controls.Add(this.CustomersLabel);
            this.ItemsSplitContainer.Panel1.Controls.Add(this.CustomersListBox);
            // 
            // ItemsSplitContainer.Panel2
            // 
            this.ItemsSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ItemsSplitContainer.Panel2.Controls.Add(this.RemoveDiscountButton);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.AddDiscountButton);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.DiscountsListBox);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.DiscountsLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.IsPriorityCheckBox);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.AddressControl);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.CostLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.IDLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.FullNameTextBox);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.IDTextBox);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.CustomersLable2);
            this.ItemsSplitContainer.Size = new System.Drawing.Size(852, 532);
            this.ItemsSplitContainer.SplitterDistance = 381;
            this.ItemsSplitContainer.TabIndex = 2;
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
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 464);
            this.ButtonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(374, 66);
            this.ButtonsTableLayoutPanel.TabIndex = 2;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Location = new System.Drawing.Point(127, 2);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(118, 57);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(3, 2);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(118, 57);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(3, 4);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(80, 16);
            this.CustomersLabel.TabIndex = 0;
            this.CustomersLabel.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 16;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 23);
            this.CustomersListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(376, 420);
            this.CustomersListBox.TabIndex = 0;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            this.CustomersListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemsListBox_KeyPress);
            this.CustomersListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ItemsListBox_MouseDown);
            // 
            // IsPriorityCheckBox
            // 
            this.IsPriorityCheckBox.AutoSize = true;
            this.IsPriorityCheckBox.Location = new System.Drawing.Point(83, 98);
            this.IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            this.IsPriorityCheckBox.Size = new System.Drawing.Size(83, 20);
            this.IsPriorityCheckBox.TabIndex = 16;
            this.IsPriorityCheckBox.Text = "Is Priority";
            this.IsPriorityCheckBox.UseVisualStyleBackColor = true;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(5, 74);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(71, 16);
            this.CostLabel.TabIndex = 14;
            this.CostLabel.Text = "Full Name:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(5, 46);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(23, 16);
            this.IDLabel.TabIndex = 13;
            this.IDLabel.Text = "ID:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(83, 71);
            this.FullNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(334, 22);
            this.FullNameTextBox.TabIndex = 12;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Location = new System.Drawing.Point(83, 43);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(148, 22);
            this.IDTextBox.TabIndex = 11;
            // 
            // CustomersLable2
            // 
            this.CustomersLable2.AutoSize = true;
            this.CustomersLable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLable2.Location = new System.Drawing.Point(4, 6);
            this.CustomersLable2.Name = "CustomersLable2";
            this.CustomersLable2.Size = new System.Drawing.Size(120, 16);
            this.CustomersLable2.TabIndex = 10;
            this.CustomersLable2.Text = "Select Customer";
            // 
            // DiscountsLabel
            // 
            this.DiscountsLabel.AutoSize = true;
            this.DiscountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountsLabel.Location = new System.Drawing.Point(9, 275);
            this.DiscountsLabel.Name = "DiscountsLabel";
            this.DiscountsLabel.Size = new System.Drawing.Size(75, 16);
            this.DiscountsLabel.TabIndex = 17;
            this.DiscountsLabel.Text = "Discounts";
            // 
            // DiscountsListBox
            // 
            this.DiscountsListBox.FormattingEnabled = true;
            this.DiscountsListBox.ItemHeight = 16;
            this.DiscountsListBox.Location = new System.Drawing.Point(8, 294);
            this.DiscountsListBox.Name = "DiscountsListBox";
            this.DiscountsListBox.Size = new System.Drawing.Size(345, 132);
            this.DiscountsListBox.TabIndex = 18;
            // 
            // AddDiscountButton
            // 
            this.AddDiscountButton.Location = new System.Drawing.Point(359, 294);
            this.AddDiscountButton.Name = "AddDiscountButton";
            this.AddDiscountButton.Size = new System.Drawing.Size(93, 48);
            this.AddDiscountButton.TabIndex = 19;
            this.AddDiscountButton.Text = "Add";
            this.AddDiscountButton.UseVisualStyleBackColor = true;
            this.AddDiscountButton.Click += new System.EventHandler(this.AddDiscountButton_Click);
            // 
            // RemoveDiscountButton
            // 
            this.RemoveDiscountButton.Location = new System.Drawing.Point(359, 348);
            this.RemoveDiscountButton.Name = "RemoveDiscountButton";
            this.RemoveDiscountButton.Size = new System.Drawing.Size(93, 48);
            this.RemoveDiscountButton.TabIndex = 20;
            this.RemoveDiscountButton.Text = "Remove";
            this.RemoveDiscountButton.UseVisualStyleBackColor = true;
            this.RemoveDiscountButton.Click += new System.EventHandler(this.RemoveDiscountButton_Click);
            // 
            // AddressControl
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 111111;
            address1.Street = "";
            this.AddressControl.Address = address1;
            this.AddressControl.Location = new System.Drawing.Point(3, 123);
            this.AddressControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(467, 187);
            this.AddressControl.TabIndex = 15;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemsSplitContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(852, 532);
            this.ItemsSplitContainer.Panel1.ResumeLayout(false);
            this.ItemsSplitContainer.Panel1.PerformLayout();
            this.ItemsSplitContainer.Panel2.ResumeLayout(false);
            this.ItemsSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsSplitContainer)).EndInit();
            this.ItemsSplitContainer.ResumeLayout(false);
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ItemsSplitContainer;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label CustomersLable2;
        private Controls.AddressControl AddressControl;
        private System.Windows.Forms.CheckBox IsPriorityCheckBox;
        private System.Windows.Forms.Label DiscountsLabel;
        private System.Windows.Forms.ListBox DiscountsListBox;
        private System.Windows.Forms.Button RemoveDiscountButton;
        private System.Windows.Forms.Button AddDiscountButton;
    }
}
