
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.СписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиЗаписToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.змiнитиЗаписToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиЗаписToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ФункцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вивестиЗаписиЗаДатоюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кількістьТоваруЗаВизначенимиДатамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ВивестиУфайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getTable = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Provider = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.DeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.changeItem = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.Button();
            this.Найменування = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.fullName = new System.Windows.Forms.TextBox();
            this.ProductNumber = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deleteItem = new System.Windows.Forms.Button();
            this.deleteBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.filenm = new System.Windows.Forms.Label();
            this.countItems = new System.Windows.Forms.Label();
            this.datePanel = new System.Windows.Forms.Panel();
            this.dateBut = new System.Windows.Forms.Button();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.DateTimePicker();
            this.start = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.search2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.datePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.СписокToolStripMenuItem,
            this.ФункцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // СписокToolStripMenuItem
            // 
            this.СписокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиЗаписToolStripMenuItem1,
            this.змiнитиЗаписToolStripMenuItem,
            this.видалитиЗаписToolStripMenuItem});
            this.СписокToolStripMenuItem.Name = "СписокToolStripMenuItem";
            this.СписокToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.СписокToolStripMenuItem.Text = "Редагувати список";
            // 
            // додатиЗаписToolStripMenuItem1
            // 
            this.додатиЗаписToolStripMenuItem1.Name = "додатиЗаписToolStripMenuItem1";
            this.додатиЗаписToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.додатиЗаписToolStripMenuItem1.Text = "Додати запис";
            this.додатиЗаписToolStripMenuItem1.Click += new System.EventHandler(this.додатиЗаписToolStripMenuItem1_Click);
            // 
            // змiнитиЗаписToolStripMenuItem
            // 
            this.змiнитиЗаписToolStripMenuItem.Name = "змiнитиЗаписToolStripMenuItem";
            this.змiнитиЗаписToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.змiнитиЗаписToolStripMenuItem.Text = "Змінити запис";
            this.змiнитиЗаписToolStripMenuItem.Click += new System.EventHandler(this.змiнитиЗаписToolStripMenuItem_Click);
            // 
            // видалитиЗаписToolStripMenuItem
            // 
            this.видалитиЗаписToolStripMenuItem.Name = "видалитиЗаписToolStripMenuItem";
            this.видалитиЗаписToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.видалитиЗаписToolStripMenuItem.Text = "Видалити запис";
            this.видалитиЗаписToolStripMenuItem.Click += new System.EventHandler(this.видалитиЗаписToolStripMenuItem_Click);
            // 
            // ФункцииToolStripMenuItem
            // 
            this.ФункцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вивестиЗаписиЗаДатоюToolStripMenuItem,
            this.кількістьТоваруЗаВизначенимиДатамиToolStripMenuItem,
            this.ВивестиУфайлToolStripMenuItem});
            this.ФункцииToolStripMenuItem.Name = "ФункцииToolStripMenuItem";
            this.ФункцииToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.ФункцииToolStripMenuItem.Text = "Функції";
            // 
            // вивестиЗаписиЗаДатоюToolStripMenuItem
            // 
            this.вивестиЗаписиЗаДатоюToolStripMenuItem.Name = "вивестиЗаписиЗаДатоюToolStripMenuItem";
            this.вивестиЗаписиЗаДатоюToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.вивестиЗаписиЗаДатоюToolStripMenuItem.Text = "Вивести записи за датою";
            this.вивестиЗаписиЗаДатоюToolStripMenuItem.Click += new System.EventHandler(this.вивестиЗаписиЗаДатоюToolStripMenuItem_Click);
            // 
            // кількістьТоваруЗаВизначенимиДатамиToolStripMenuItem
            // 
            this.кількістьТоваруЗаВизначенимиДатамиToolStripMenuItem.Name = "кількістьТоваруЗаВизначенимиДатамиToolStripMenuItem";
            this.кількістьТоваруЗаВизначенимиДатамиToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.кількістьТоваруЗаВизначенимиДатамиToolStripMenuItem.Text = "Доставленнi продукти між датами";
            this.кількістьТоваруЗаВизначенимиДатамиToolStripMenuItem.Click += new System.EventHandler(this.кількістьТоваруЗаВизначенимиДатамиToolStripMenuItem_Click);
            // 
            // ВивестиУфайлToolStripMenuItem
            // 
            this.ВивестиУфайлToolStripMenuItem.Name = "ВивестиУфайлToolStripMenuItem";
            this.ВивестиУфайлToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.ВивестиУфайлToolStripMenuItem.Text = "Вивести iнформацiю у файли";
            this.ВивестиУфайлToolStripMenuItem.Click += new System.EventHandler(this.ВивестиУфайлToolStripMenuItem_Click);
            // 
            // getTable
            // 
            this.getTable.BackColor = System.Drawing.Color.LightGray;
            this.getTable.Location = new System.Drawing.Point(763, 311);
            this.getTable.Margin = new System.Windows.Forms.Padding(0);
            this.getTable.Name = "getTable";
            this.getTable.Size = new System.Drawing.Size(154, 41);
            this.getTable.TabIndex = 3;
            this.getTable.Text = "Загрузити таблицю";
            this.getTable.UseVisualStyleBackColor = false;
            this.getTable.Click += new System.EventHandler(this.getTable_Click_1);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(21, 44);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(896, 258);
            this.dataGridView.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Provider);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.DeliveryDate);
            this.panel1.Controls.Add(this.changeItem);
            this.panel1.Controls.Add(this.addItem);
            this.panel1.Controls.Add(this.Найменування);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ProductName);
            this.panel1.Controls.Add(this.fullName);
            this.panel1.Controls.Add(this.ProductNumber);
            this.panel1.Location = new System.Drawing.Point(26, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 139);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(748, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 14);
            this.label7.TabIndex = 18;
            this.label7.Text = "Постачальник";
            // 
            // Provider
            // 
            this.Provider.Location = new System.Drawing.Point(729, 45);
            this.Provider.Name = "Provider";
            this.Provider.Size = new System.Drawing.Size(142, 20);
            this.Provider.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Дата доставки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Кількість товару";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(571, 45);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(142, 20);
            this.Quantity.TabIndex = 14;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DeliveryDate.Location = new System.Drawing.Point(399, 45);
            this.DeliveryDate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Size = new System.Drawing.Size(167, 20);
            this.DeliveryDate.TabIndex = 13;
            // 
            // changeItem
            // 
            this.changeItem.BackColor = System.Drawing.Color.LightGray;
            this.changeItem.Location = new System.Drawing.Point(11, 76);
            this.changeItem.Margin = new System.Windows.Forms.Padding(0);
            this.changeItem.Name = "changeItem";
            this.changeItem.Size = new System.Drawing.Size(117, 38);
            this.changeItem.TabIndex = 12;
            this.changeItem.Text = "Змінити";
            this.changeItem.UseVisualStyleBackColor = false;
            this.changeItem.Click += new System.EventHandler(this.changeItem_Click);
            // 
            // addItem
            // 
            this.addItem.BackColor = System.Drawing.Color.LightGray;
            this.addItem.Location = new System.Drawing.Point(12, 77);
            this.addItem.Margin = new System.Windows.Forms.Padding(0);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(117, 37);
            this.addItem.TabIndex = 11;
            this.addItem.Text = "Додати";
            this.addItem.UseVisualStyleBackColor = false;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // Найменування
            // 
            this.Найменування.AutoSize = true;
            this.Найменування.Location = new System.Drawing.Point(142, 28);
            this.Найменування.Name = "Найменування";
            this.Найменування.Size = new System.Drawing.Size(101, 14);
            this.Найменування.TabIndex = 8;
            this.Найменування.Text = "Найменування";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "ПІБ відповідального";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Інвентарний номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Запишіть дані";
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(138, 45);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(116, 20);
            this.ProductName.TabIndex = 2;
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(260, 45);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(125, 20);
            this.fullName.TabIndex = 1;
            // 
            // ProductNumber
            // 
            this.ProductNumber.Location = new System.Drawing.Point(12, 45);
            this.ProductNumber.Name = "ProductNumber";
            this.ProductNumber.Size = new System.Drawing.Size(116, 20);
            this.ProductNumber.TabIndex = 0;
            this.ProductNumber.Leave += new System.EventHandler(this.id_Leave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.deleteItem);
            this.panel3.Controls.Add(this.deleteBox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(324, 314);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 69);
            this.panel3.TabIndex = 7;
            this.panel3.Visible = false;
            // 
            // deleteItem
            // 
            this.deleteItem.BackColor = System.Drawing.Color.LightGray;
            this.deleteItem.Location = new System.Drawing.Point(108, 40);
            this.deleteItem.Margin = new System.Windows.Forms.Padding(0);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(78, 28);
            this.deleteItem.TabIndex = 2;
            this.deleteItem.Text = "Видалити";
            this.deleteItem.UseVisualStyleBackColor = false;
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // deleteBox
            // 
            this.deleteBox.Location = new System.Drawing.Point(78, 17);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(138, 20);
            this.deleteBox.TabIndex = 1;
            this.deleteBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 8.2F);
            this.label8.Location = new System.Drawing.Point(-4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(304, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Введіть інвентарний номер, який треба видалити";
            // 
            // filenm
            // 
            this.filenm.AutoSize = true;
            this.filenm.Location = new System.Drawing.Point(14, 210);
            this.filenm.Name = "filenm";
            this.filenm.Size = new System.Drawing.Size(0, 14);
            this.filenm.TabIndex = 8;
            // 
            // countItems
            // 
            this.countItems.AutoSize = true;
            this.countItems.Location = new System.Drawing.Point(14, 246);
            this.countItems.Name = "countItems";
            this.countItems.Size = new System.Drawing.Size(0, 14);
            this.countItems.TabIndex = 9;
            // 
            // datePanel
            // 
            this.datePanel.Controls.Add(this.dateBut);
            this.datePanel.Controls.Add(this.labelEnd);
            this.datePanel.Controls.Add(this.labelStart);
            this.datePanel.Controls.Add(this.end);
            this.datePanel.Controls.Add(this.start);
            this.datePanel.Controls.Add(this.label6);
            this.datePanel.Location = new System.Drawing.Point(330, 308);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(290, 84);
            this.datePanel.TabIndex = 8;
            this.datePanel.Visible = false;
            // 
            // dateBut
            // 
            this.dateBut.BackColor = System.Drawing.Color.LightGray;
            this.dateBut.Location = new System.Drawing.Point(102, 59);
            this.dateBut.Margin = new System.Windows.Forms.Padding(0);
            this.dateBut.Name = "dateBut";
            this.dateBut.Size = new System.Drawing.Size(78, 28);
            this.dateBut.TabIndex = 3;
            this.dateBut.Text = "Знайти";
            this.dateBut.UseVisualStyleBackColor = false;
            this.dateBut.Click += new System.EventHandler(this.dateBut_Click);
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(147, 17);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(85, 14);
            this.labelEnd.TabIndex = 20;
            this.labelEnd.Text = "Кінцева дата";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(3, 19);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(101, 14);
            this.labelStart.TabIndex = 19;
            this.labelStart.Text = "Початкова дата";
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(149, 37);
            this.end.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(128, 20);
            this.end.TabIndex = 18;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(2, 37);
            this.start.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(128, 20);
            this.start.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Введіть відповідні дати";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(613, 18);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(255, 20);
            this.search.TabIndex = 10;
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(663, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 14);
            this.label9.TabIndex = 12;
            this.label9.Text = "Пошук за найменуванням";
            // 
            // search2
            // 
            this.search2.Location = new System.Drawing.Point(264, 18);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(258, 20);
            this.search2.TabIndex = 13;
            this.search2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search2.TextChanged += new System.EventHandler(this.search2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(310, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 14);
            this.label10.TabIndex = 14;
            this.label10.Text = "Пошук за постачальником";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(929, 569);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.search2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.datePanel);
            this.Controls.Add(this.countItems);
            this.Controls.Add(this.filenm);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.getTable);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Облік поставок на склад";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.datePanel.ResumeLayout(false);
            this.datePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem СписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиЗаписToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem змiнитиЗаписToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиЗаписToolStripMenuItem;
        private System.Windows.Forms.Button getTable;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Найменування;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.TextBox ProductNumber;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.TextBox deleteBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button changeItem;
        private System.Windows.Forms.Label filenm;
        private System.Windows.Forms.Label countItems;
        private System.Windows.Forms.ToolStripMenuItem ФункцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вивестиЗаписиЗаДатоюToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.DateTimePicker DeliveryDate;
        private System.Windows.Forms.ToolStripMenuItem кількістьТоваруЗаВизначенимиДатамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ВивестиУфайлToolStripMenuItem;
        private System.Windows.Forms.Panel datePanel;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.DateTimePicker end;
        private System.Windows.Forms.DateTimePicker start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button dateBut;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Provider;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox search2;
        private System.Windows.Forms.Label label10;
    }
}

