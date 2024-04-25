namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            ObjectOrientedPractics.Model.Address address2 = new ObjectOrientedPractics.Model.Address();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.OrdersLabel = new System.Windows.Forms.Label();
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AmountText = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.OrdersLabel);
            this.splitContainer.Panel1.Controls.Add(this.OrdersGridView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.StatusComboBox);
            this.splitContainer.Panel2.Controls.Add(this.DataTextBox);
            this.splitContainer.Panel2.Controls.Add(this.IDTextBox);
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Panel2.Controls.Add(this.AmountLabel);
            this.splitContainer.Panel2.Controls.Add(this.ItemsLabel);
            this.splitContainer.Panel2.Controls.Add(this.ItemListBox);
            this.splitContainer.Panel2.Controls.Add(this.AddressControl);
            this.splitContainer.Panel2.Controls.Add(this.StatusLabel);
            this.splitContainer.Panel2.Controls.Add(this.DateLabel);
            this.splitContainer.Panel2.Controls.Add(this.IDLabel);
            this.splitContainer.Panel2.Controls.Add(this.SelectedOrderLabel);
            this.splitContainer.Size = new System.Drawing.Size(900, 550);
            this.splitContainer.SplitterDistance = 405;
            this.splitContainer.TabIndex = 0;
            // 
            // OrdersLabel
            // 
            this.OrdersLabel.AutoSize = true;
            this.OrdersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersLabel.Location = new System.Drawing.Point(3, 4);
            this.OrdersLabel.Name = "OrdersLabel";
            this.OrdersLabel.Size = new System.Drawing.Size(54, 16);
            this.OrdersLabel.TabIndex = 0;
            this.OrdersLabel.Text = "Orders";
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.AllowUserToAddRows = false;
            this.OrdersGridView.AllowUserToDeleteRows = false;
            this.OrdersGridView.AllowUserToResizeColumns = false;
            this.OrdersGridView.AllowUserToResizeRows = false;
            this.OrdersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Location = new System.Drawing.Point(6, 23);
            this.OrdersGridView.MultiSelect = false;
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.ReadOnly = true;
            this.OrdersGridView.RowHeadersWidth = 51;
            this.OrdersGridView.RowTemplate.Height = 24;
            this.OrdersGridView.Size = new System.Drawing.Size(405, 527);
            this.OrdersGridView.TabIndex = 0;
            this.OrdersGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OrdersGridView_CellMouseClick);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(76, 85);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(172, 24);
            this.StatusComboBox.TabIndex = 15;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(76, 56);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.ReadOnly = true;
            this.DataTextBox.Size = new System.Drawing.Size(172, 22);
            this.DataTextBox.TabIndex = 14;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(76, 29);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(172, 22);
            this.IDTextBox.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.AmountText);
            this.panel1.Location = new System.Drawing.Point(359, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 33);
            this.panel1.TabIndex = 12;
            // 
            // AmountText
            // 
            this.AmountText.AutoSize = true;
            this.AmountText.Dock = System.Windows.Forms.DockStyle.Right;
            this.AmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountText.Location = new System.Drawing.Point(99, 0);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(24, 25);
            this.AmountText.TabIndex = 4;
            this.AmountText.Text = "0";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(420, 428);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(62, 16);
            this.AmountLabel.TabIndex = 8;
            this.AmountLabel.Text = "Amount:";
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Location = new System.Drawing.Point(12, 274);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(76, 16);
            this.ItemsLabel.TabIndex = 7;
            this.ItemsLabel.Text = "Order Items";
            // 
            // ItemListBox
            // 
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 16;
            this.ItemListBox.Location = new System.Drawing.Point(15, 293);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(467, 132);
            this.ItemListBox.TabIndex = 6;
            // 
            // AddressControl
            // 
            address2.Apartment = "";
            address2.Building = "";
            address2.City = "";
            address2.Country = "";
            address2.Index = 111111;
            address2.Street = "";
            this.AddressControl.Address = address2;
            this.AddressControl.Location = new System.Drawing.Point(15, 117);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(467, 187);
            this.AddressControl.TabIndex = 5;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(12, 88);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(47, 16);
            this.StatusLabel.TabIndex = 4;
            this.StatusLabel.Text = "Status:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(12, 59);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(58, 16);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "Created:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(12, 32);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(23, 16);
            this.IDLabel.TabIndex = 2;
            this.IDLabel.Text = "ID:";
            // 
            // SelectedOrderLabel
            // 
            this.SelectedOrderLabel.AutoSize = true;
            this.SelectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedOrderLabel.Location = new System.Drawing.Point(12, 4);
            this.SelectedOrderLabel.Name = "SelectedOrderLabel";
            this.SelectedOrderLabel.Size = new System.Drawing.Size(108, 16);
            this.SelectedOrderLabel.TabIndex = 1;
            this.SelectedOrderLabel.Text = "SelectedOrder";
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(900, 550);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.Label OrdersLabel;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.ListBox ItemListBox;
        private Controls.AddressControl AddressControl;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label SelectedOrderLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AmountText;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
    }
}
