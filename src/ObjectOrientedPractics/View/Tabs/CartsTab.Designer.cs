namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            System.Windows.Forms.Label DiscountAmmountLabel;
            System.Windows.Forms.Label TotalLabel;
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.CartLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountText = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.AddButton = new System.Windows.Forms.Button();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DiscountsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.DiscountsLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DiscountAmmountText = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TotalText = new System.Windows.Forms.Label();
            DiscountAmmountLabel = new System.Windows.Forms.Label();
            TotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsLabel.Location = new System.Drawing.Point(6, 6);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(48, 16);
            this.ItemsLabel.TabIndex = 0;
            this.ItemsLabel.Text = "Items:";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerLabel.Location = new System.Drawing.Point(17, 25);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(76, 16);
            this.CustomerLabel.TabIndex = 1;
            this.CustomerLabel.Text = "Customer:";
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CartLabel.Location = new System.Drawing.Point(17, 60);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(34, 16);
            this.CartLabel.TabIndex = 2;
            this.CartLabel.Text = "Cart:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(293, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(62, 16);
            this.AmountLabel.TabIndex = 3;
            this.AmountLabel.Text = "Amount:";
            // 
            // AmountText
            // 
            this.AmountText.AutoSize = true;
            this.AmountText.Dock = System.Windows.Forms.DockStyle.Right;
            this.AmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountText.Location = new System.Drawing.Point(105, 0);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(24, 25);
            this.AmountText.TabIndex = 4;
            this.AmountText.Text = "0";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 16;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 22);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(245, 404);
            this.ItemsListBox.TabIndex = 5;
            this.ItemsListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemsListBox_KeyPress);
            this.ItemsListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ItemsListBox_MouseDown);
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.ItemsListBox);
            this.SplitContainer.Panel1.Controls.Add(this.ItemsLabel);
            this.SplitContainer.Panel1.Controls.Add(this.AddButton);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.DiscountsCheckedListBox);
            this.SplitContainer.Panel2.Controls.Add(this.CartListBox);
            this.SplitContainer.Panel2.Controls.Add(this.CartLabel);
            this.SplitContainer.Panel2.Controls.Add(this.CustomerComboBox);
            this.SplitContainer.Panel2.Controls.Add(this.CustomerLabel);
            this.SplitContainer.Panel2.Controls.Add(this.ButtonPanel);
            this.SplitContainer.Size = new System.Drawing.Size(650, 500);
            this.SplitContainer.SplitterDistance = 251;
            this.SplitContainer.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Location = new System.Drawing.Point(9, 439);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(102, 45);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add To Cart";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CartListBox
            // 
            this.CartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.ItemHeight = 16;
            this.CartListBox.Location = new System.Drawing.Point(13, 79);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(348, 196);
            this.CartListBox.TabIndex = 6;
            this.CartListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CartListBox_MouseDown);
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(95, 22);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(273, 24);
            this.CustomerComboBox.TabIndex = 2;
            this.CustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
            this.CustomerComboBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CustomerComboBox_MouseDown);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonPanel.Controls.Add(this.panel3);
            this.ButtonPanel.Controls.Add(TotalLabel);
            this.ButtonPanel.Controls.Add(this.panel2);
            this.ButtonPanel.Controls.Add(DiscountAmmountLabel);
            this.ButtonPanel.Controls.Add(this.DiscountsLabel);
            this.ButtonPanel.Controls.Add(this.panel1);
            this.ButtonPanel.Controls.Add(this.ClearButton);
            this.ButtonPanel.Controls.Add(this.CreateButton);
            this.ButtonPanel.Controls.Add(this.AmountLabel);
            this.ButtonPanel.Controls.Add(this.RemoveButton);
            this.ButtonPanel.Location = new System.Drawing.Point(13, 281);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(379, 216);
            this.ButtonPanel.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.AmountText);
            this.panel1.Location = new System.Drawing.Point(226, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 31);
            this.panel1.TabIndex = 11;
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClearButton.Location = new System.Drawing.Point(247, 56);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(108, 41);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Clear Cart";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(3, 56);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(105, 41);
            this.CreateButton.TabIndex = 8;
            this.CreateButton.Text = "Create Order";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Location = new System.Drawing.Point(136, 56);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(105, 41);
            this.RemoveButton.TabIndex = 9;
            this.RemoveButton.Text = "Remove Item";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // DiscountsCheckedListBox
            // 
            this.DiscountsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DiscountsCheckedListBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DiscountsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscountsCheckedListBox.CheckOnClick = true;
            this.DiscountsCheckedListBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DiscountsCheckedListBox.FormattingEnabled = true;
            this.DiscountsCheckedListBox.Location = new System.Drawing.Point(16, 401);
            this.DiscountsCheckedListBox.Name = "DiscountsCheckedListBox";
            this.DiscountsCheckedListBox.Size = new System.Drawing.Size(206, 85);
            this.DiscountsCheckedListBox.TabIndex = 12;
            this.DiscountsCheckedListBox.Click += new System.EventHandler(this.DiscountsCheckedListBox_Click);
            // 
            // DiscountsLabel
            // 
            this.DiscountsLabel.AutoSize = true;
            this.DiscountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountsLabel.Location = new System.Drawing.Point(4, 100);
            this.DiscountsLabel.Name = "DiscountsLabel";
            this.DiscountsLabel.Size = new System.Drawing.Size(79, 16);
            this.DiscountsLabel.TabIndex = 12;
            this.DiscountsLabel.Text = "Discounts:";
            // 
            // DiscountAmmountLabel
            // 
            DiscountAmmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            DiscountAmmountLabel.AutoSize = true;
            DiscountAmmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            DiscountAmmountLabel.Location = new System.Drawing.Point(214, 100);
            DiscountAmmountLabel.Name = "DiscountAmmountLabel";
            DiscountAmmountLabel.Size = new System.Drawing.Size(138, 16);
            DiscountAmmountLabel.TabIndex = 13;
            DiscountAmmountLabel.Text = "Discount Ammount:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.DiscountAmmountText);
            this.panel2.Location = new System.Drawing.Point(226, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(129, 31);
            this.panel2.TabIndex = 14;
            // 
            // DiscountAmmountText
            // 
            this.DiscountAmmountText.AutoSize = true;
            this.DiscountAmmountText.Dock = System.Windows.Forms.DockStyle.Right;
            this.DiscountAmmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountAmmountText.Location = new System.Drawing.Point(105, 0);
            this.DiscountAmmountText.Name = "DiscountAmmountText";
            this.DiscountAmmountText.Size = new System.Drawing.Size(24, 25);
            this.DiscountAmmountText.TabIndex = 4;
            this.DiscountAmmountText.Text = "0";
            // 
            // TotalLabel
            // 
            TotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            TotalLabel.Location = new System.Drawing.Point(298, 158);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new System.Drawing.Size(57, 20);
            TotalLabel.TabIndex = 15;
            TotalLabel.Text = "Total:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.TotalText);
            this.panel3.Location = new System.Drawing.Point(226, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 31);
            this.panel3.TabIndex = 16;
            // 
            // TotalText
            // 
            this.TotalText.AutoSize = true;
            this.TotalText.Dock = System.Windows.Forms.DockStyle.Right;
            this.TotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalText.Location = new System.Drawing.Point(105, 0);
            this.TotalText.Name = "TotalText";
            this.TotalText.Size = new System.Drawing.Size(24, 25);
            this.TotalText.TabIndex = 4;
            this.TotalText.Text = "0";
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SplitContainer);
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(650, 500);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label AmountText;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.ListBox CartListBox;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox DiscountsCheckedListBox;
        private System.Windows.Forms.Label DiscountsLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TotalText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label DiscountAmmountText;
    }
}
