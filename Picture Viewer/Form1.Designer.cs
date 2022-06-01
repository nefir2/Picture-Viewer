
namespace Picture_Viewer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.картинная = new System.Windows.Forms.PictureBox();
            this.растягивалка = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.показывалка = new System.Windows.Forms.Button();
            this.очищалка = new System.Windows.Forms.Button();
            this.цветоменялка = new System.Windows.Forms.Button();
            this.закрывалка = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.картинная)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.картинная, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.растягивалка, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // картинная
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.картинная, 2);
            this.картинная.Dock = System.Windows.Forms.DockStyle.Fill;
            this.картинная.Location = new System.Drawing.Point(3, 3);
            this.картинная.Name = "картинная";
            this.картинная.Size = new System.Drawing.Size(794, 399);
            this.картинная.TabIndex = 0;
            this.картинная.TabStop = false;
            // 
            // растягивалка
            // 
            this.растягивалка.AutoSize = true;
            this.растягивалка.Location = new System.Drawing.Point(3, 408);
            this.растягивалка.Name = "растягивалка";
            this.растягивалка.Size = new System.Drawing.Size(77, 17);
            this.растягивалка.TabIndex = 1;
            this.растягивалка.Text = "растянуть";
            this.растягивалка.UseVisualStyleBackColor = true;
            this.растягивалка.Click += new System.EventHandler(this.растягивалка_изменение);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.показывалка);
            this.flowLayoutPanel1.Controls.Add(this.очищалка);
            this.flowLayoutPanel1.Controls.Add(this.цветоменялка);
            this.flowLayoutPanel1.Controls.Add(this.закрывалка);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(123, 408);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(674, 39);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // показывалка
            // 
            this.показывалка.AutoSize = true;
            this.показывалка.Location = new System.Drawing.Point(596, 3);
            this.показывалка.Name = "показывалка";
            this.показывалка.Size = new System.Drawing.Size(75, 23);
            this.показывалка.TabIndex = 0;
            this.показывалка.Text = "показать";
            this.показывалка.UseVisualStyleBackColor = true;
            this.показывалка.Click += new System.EventHandler(this.показывалка_клик);
            // 
            // очищалка
            // 
            this.очищалка.AutoSize = true;
            this.очищалка.Location = new System.Drawing.Point(515, 3);
            this.очищалка.Name = "очищалка";
            this.очищалка.Size = new System.Drawing.Size(75, 23);
            this.очищалка.TabIndex = 1;
            this.очищалка.Text = "очистить";
            this.очищалка.UseVisualStyleBackColor = true;
            this.очищалка.Click += new System.EventHandler(this.очищалка_клик);
            // 
            // цветоменялка
            // 
            this.цветоменялка.AutoSize = true;
            this.цветоменялка.Location = new System.Drawing.Point(434, 3);
            this.цветоменялка.Name = "цветоменялка";
            this.цветоменялка.Size = new System.Drawing.Size(75, 23);
            this.цветоменялка.TabIndex = 2;
            this.цветоменялка.Text = "цвет фона";
            this.цветоменялка.UseVisualStyleBackColor = true;
            this.цветоменялка.Click += new System.EventHandler(this.цветоменялка_клик);
            // 
            // закрывалка
            // 
            this.закрывалка.AutoSize = true;
            this.закрывалка.Location = new System.Drawing.Point(353, 3);
            this.закрывалка.Name = "закрывалка";
            this.закрывалка.Size = new System.Drawing.Size(75, 23);
            this.закрывалка.TabIndex = 3;
            this.закрывалка.Text = "закрыть";
            this.закрывалка.UseVisualStyleBackColor = true;
            this.закрывалка.Click += new System.EventHandler(this.закрывалка_клик);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "выбиралка твоих картиночек";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "просмотрщик твоих картиночек";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.картинная)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox картинная;
        private System.Windows.Forms.CheckBox растягивалка;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button показывалка;
        private System.Windows.Forms.Button очищалка;
        private System.Windows.Forms.Button цветоменялка;
        private System.Windows.Forms.Button закрывалка;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

