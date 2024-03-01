namespace ObjectOrientedPractics
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Items = new System.Windows.Forms.TabPage();
            this.Customers = new System.Windows.Forms.TabPage();
            this.itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.customersTab1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.tabControl1.SuspendLayout();
            this.Items.SuspendLayout();
            this.Customers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Items);
            this.tabControl1.Controls.Add(this.Customers);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 634);
            this.tabControl1.TabIndex = 0;
            // 
            // Items
            // 
            this.Items.Controls.Add(this.itemsTab1);
            this.Items.Location = new System.Drawing.Point(4, 25);
            this.Items.Name = "Items";
            this.Items.Padding = new System.Windows.Forms.Padding(3);
            this.Items.Size = new System.Drawing.Size(886, 605);
            this.Items.TabIndex = 0;
            this.Items.Text = "Items";
            this.Items.UseVisualStyleBackColor = true;
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.customersTab1);
            this.Customers.Location = new System.Drawing.Point(4, 25);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(3);
            this.Customers.Size = new System.Drawing.Size(886, 605);
            this.Customers.TabIndex = 1;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            this.itemsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab1.Location = new System.Drawing.Point(3, 3);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(880, 599);
            this.itemsTab1.TabIndex = 0;
            // 
            // customersTab1
            // 
            this.customersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTab1.Location = new System.Drawing.Point(3, 3);
            this.customersTab1.Name = "customersTab1";
            this.customersTab1.Size = new System.Drawing.Size(880, 599);
            this.customersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 634);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.tabControl1.ResumeLayout(false);
            this.Items.ResumeLayout(false);
            this.Customers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Items;
        private System.Windows.Forms.TabPage Customers;
        private View.Tabs.CustomersTab customersTab1;
        private View.Tabs.ItemsTab itemsTab1;
    }
}

