namespace Мастер_пол
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.партнёрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оптовикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розничныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияПартнёраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.созданныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполненыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отмененныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьЗаявкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каталогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ковролинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.паркетнаяДоскаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ламинатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.партнёрыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.каталогToolStripMenuItem,
            this.складToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(233, 562);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(220, 49);
            this.toolStripMenuItem1.Text = "𝑀𝒶𝓈𝓉𝑒𝓇 𝓅𝑜𝓁";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(220, 49);
            this.toolStripMenuItem2.Text = " ";
            // 
            // партнёрыToolStripMenuItem
            // 
            this.партнёрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оптовикиToolStripMenuItem,
            this.розничныеToolStripMenuItem,
            this.регистрацияПартнёраToolStripMenuItem});
            this.партнёрыToolStripMenuItem.Name = "партнёрыToolStripMenuItem";
            this.партнёрыToolStripMenuItem.Size = new System.Drawing.Size(220, 49);
            this.партнёрыToolStripMenuItem.Text = "Партнёры";
            this.партнёрыToolStripMenuItem.Click += new System.EventHandler(this.партнёрыToolStripMenuItem_Click);
            // 
            // оптовикиToolStripMenuItem
            // 
            this.оптовикиToolStripMenuItem.Name = "оптовикиToolStripMenuItem";
            this.оптовикиToolStripMenuItem.Size = new System.Drawing.Size(452, 50);
            this.оптовикиToolStripMenuItem.Text = "Оптовые";
            this.оптовикиToolStripMenuItem.Click += new System.EventHandler(this.оптовикиToolStripMenuItem_Click);
            // 
            // розничныеToolStripMenuItem
            // 
            this.розничныеToolStripMenuItem.Name = "розничныеToolStripMenuItem";
            this.розничныеToolStripMenuItem.Size = new System.Drawing.Size(452, 50);
            this.розничныеToolStripMenuItem.Text = "Розничные";
            this.розничныеToolStripMenuItem.Click += new System.EventHandler(this.розничныеToolStripMenuItem_Click);
            // 
            // регистрацияПартнёраToolStripMenuItem
            // 
            this.регистрацияПартнёраToolStripMenuItem.Name = "регистрацияПартнёраToolStripMenuItem";
            this.регистрацияПартнёраToolStripMenuItem.Size = new System.Drawing.Size(452, 50);
            this.регистрацияПартнёраToolStripMenuItem.Text = "Регистрация партнёра";
            this.регистрацияПартнёраToolStripMenuItem.Click += new System.EventHandler(this.регистрацияПартнёраToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданныеToolStripMenuItem,
            this.выполненыеToolStripMenuItem,
            this.отмененныеToolStripMenuItem,
            this.создатьЗаявкуToolStripMenuItem});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(220, 49);
            this.сотрудникиToolStripMenuItem.Text = "Заявки";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // созданныеToolStripMenuItem
            // 
            this.созданныеToolStripMenuItem.Name = "созданныеToolStripMenuItem";
            this.созданныеToolStripMenuItem.Size = new System.Drawing.Size(341, 50);
            this.созданныеToolStripMenuItem.Text = "Созданные";
            this.созданныеToolStripMenuItem.Click += new System.EventHandler(this.созданныеToolStripMenuItem_Click);
            // 
            // выполненыеToolStripMenuItem
            // 
            this.выполненыеToolStripMenuItem.Name = "выполненыеToolStripMenuItem";
            this.выполненыеToolStripMenuItem.Size = new System.Drawing.Size(341, 50);
            this.выполненыеToolStripMenuItem.Text = "Выполненные";
            this.выполненыеToolStripMenuItem.Click += new System.EventHandler(this.выполненыеToolStripMenuItem_Click);
            // 
            // отмененныеToolStripMenuItem
            // 
            this.отмененныеToolStripMenuItem.Name = "отмененныеToolStripMenuItem";
            this.отмененныеToolStripMenuItem.Size = new System.Drawing.Size(341, 50);
            this.отмененныеToolStripMenuItem.Text = "Отмененные";
            this.отмененныеToolStripMenuItem.Click += new System.EventHandler(this.отмененныеToolStripMenuItem_Click);
            // 
            // создатьЗаявкуToolStripMenuItem
            // 
            this.создатьЗаявкуToolStripMenuItem.Name = "создатьЗаявкуToolStripMenuItem";
            this.создатьЗаявкуToolStripMenuItem.Size = new System.Drawing.Size(341, 50);
            this.создатьЗаявкуToolStripMenuItem.Text = "Создать заявку";
            this.создатьЗаявкуToolStripMenuItem.Click += new System.EventHandler(this.создатьЗаявкуToolStripMenuItem_Click);
            // 
            // каталогToolStripMenuItem
            // 
            this.каталогToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.каталогToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.каталогToolStripMenuItem.Checked = true;
            this.каталогToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.каталогToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.каталогToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ковролинToolStripMenuItem,
            this.паркетнаяДоскаToolStripMenuItem,
            this.ламинатToolStripMenuItem});
            this.каталогToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.каталогToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.каталогToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.каталогToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.MidnightBlue;
            this.каталогToolStripMenuItem.Name = "каталогToolStripMenuItem";
            this.каталогToolStripMenuItem.Size = new System.Drawing.Size(220, 45);
            this.каталогToolStripMenuItem.Text = "Продукция";
            this.каталогToolStripMenuItem.Click += new System.EventHandler(this.каталогToolStripMenuItem_Click);
            // 
            // ковролинToolStripMenuItem
            // 
            this.ковролинToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ковролинToolStripMenuItem.Name = "ковролинToolStripMenuItem";
            this.ковролинToolStripMenuItem.Size = new System.Drawing.Size(247, 46);
            this.ковролинToolStripMenuItem.Text = "Ковролин";
            this.ковролинToolStripMenuItem.Click += new System.EventHandler(this.ковролинToolStripMenuItem_Click);
            // 
            // паркетнаяДоскаToolStripMenuItem
            // 
            this.паркетнаяДоскаToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.паркетнаяДоскаToolStripMenuItem.Name = "паркетнаяДоскаToolStripMenuItem";
            this.паркетнаяДоскаToolStripMenuItem.Size = new System.Drawing.Size(247, 46);
            this.паркетнаяДоскаToolStripMenuItem.Text = "Паркет";
            this.паркетнаяДоскаToolStripMenuItem.Click += new System.EventHandler(this.паркетнаяДоскаToolStripMenuItem_Click);
            // 
            // ламинатToolStripMenuItem
            // 
            this.ламинатToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ламинатToolStripMenuItem.Name = "ламинатToolStripMenuItem";
            this.ламинатToolStripMenuItem.Size = new System.Drawing.Size(247, 46);
            this.ламинатToolStripMenuItem.Text = "Ламинат";
            this.ламинатToolStripMenuItem.Click += new System.EventHandler(this.ламинатToolStripMenuItem_Click);
            // 
            // складToolStripMenuItem
            // 
            this.складToolStripMenuItem.Name = "складToolStripMenuItem";
            this.складToolStripMenuItem.Size = new System.Drawing.Size(220, 49);
            this.складToolStripMenuItem.Text = "Склад";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(280, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 463);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(885, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(98, 38);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(280, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(585, 34);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1005, 562);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem каталогToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ковролинToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem паркетнаяДоскаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ламинатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem партнёрыToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem созданныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполненыеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отмененныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оптовикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розничныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьЗаявкуToolStripMenuItem;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ToolStripMenuItem регистрацияПартнёраToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

