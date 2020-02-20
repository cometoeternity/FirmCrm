namespace CrmUi
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderAddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderedAddToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeAddToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerAddToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductToolStripMenuItem,
            this.OrderToolStripMenuItem,
            this.OrderedToolStripMenuItem,
            this.EmployeeToolStripMenuItem,
            this.CustomerToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // ProductToolStripMenuItem
            // 
            this.ProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productAddToolStripMenuItem});
            this.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem";
            this.ProductToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ProductToolStripMenuItem.Text = "Товары";
            this.ProductToolStripMenuItem.Click += new System.EventHandler(this.ProductToolStripMenuItem_Click);
            // 
            // productAddToolStripMenuItem
            // 
            this.productAddToolStripMenuItem.Name = "productAddToolStripMenuItem";
            this.productAddToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.productAddToolStripMenuItem.Text = "Добавить";
            this.productAddToolStripMenuItem.Click += new System.EventHandler(this.productAddToolStripMenuItem_Click);
            // 
            // OrderToolStripMenuItem
            // 
            this.OrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderAddToolStripMenuItem1});
            this.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem";
            this.OrderToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.OrderToolStripMenuItem.Text = "Заказ";
            this.OrderToolStripMenuItem.Click += new System.EventHandler(this.OrderToolStripMenuItem_Click);
            // 
            // orderAddToolStripMenuItem1
            // 
            this.orderAddToolStripMenuItem1.Name = "orderAddToolStripMenuItem1";
            this.orderAddToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.orderAddToolStripMenuItem1.Text = "Добавить";
            this.orderAddToolStripMenuItem1.Click += new System.EventHandler(this.orderAddToolStripMenuItem1_Click);
            // 
            // OrderedToolStripMenuItem
            // 
            this.OrderedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderedAddToolStripMenuItem2});
            this.OrderedToolStripMenuItem.Name = "OrderedToolStripMenuItem";
            this.OrderedToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.OrderedToolStripMenuItem.Text = "Заказано";
            this.OrderedToolStripMenuItem.Click += new System.EventHandler(this.OrderedToolStripMenuItem_Click);
            // 
            // orderedAddToolStripMenuItem2
            // 
            this.orderedAddToolStripMenuItem2.Name = "orderedAddToolStripMenuItem2";
            this.orderedAddToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.orderedAddToolStripMenuItem2.Text = "Добавить";
            this.orderedAddToolStripMenuItem2.Click += new System.EventHandler(this.orderedAddToolStripMenuItem2_Click);
            // 
            // EmployeeToolStripMenuItem
            // 
            this.EmployeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeAddToolStripMenuItem3});
            this.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem";
            this.EmployeeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.EmployeeToolStripMenuItem.Text = "Сотрудники";
            this.EmployeeToolStripMenuItem.Click += new System.EventHandler(this.EmployeeToolStripMenuItem_Click);
            // 
            // employeeAddToolStripMenuItem3
            // 
            this.employeeAddToolStripMenuItem3.Name = "employeeAddToolStripMenuItem3";
            this.employeeAddToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.employeeAddToolStripMenuItem3.Text = "Добавить";
            this.employeeAddToolStripMenuItem3.Click += new System.EventHandler(this.employeeAddToolStripMenuItem3_Click);
            // 
            // CustomerToolStripMenuItem
            // 
            this.CustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerAddToolStripMenuItem4});
            this.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem";
            this.CustomerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.CustomerToolStripMenuItem.Text = "Заказчики";
            this.CustomerToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // customerAddToolStripMenuItem4
            // 
            this.customerAddToolStripMenuItem4.Name = "customerAddToolStripMenuItem4";
            this.customerAddToolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.customerAddToolStripMenuItem4.Text = "Добавить";
            this.customerAddToolStripMenuItem4.Click += new System.EventHandler(this.customerAddToolStripMenuItem4_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Главное меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderAddToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderedAddToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem employeeAddToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem customerAddToolStripMenuItem4;
    }
}

