namespace PZ_7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sem = new System.Windows.Forms.NumericUpDown();
            this.Zach = new System.Windows.Forms.NumericUpDown();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Zacht = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Sdan = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Sem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sdan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Семестр";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зачеты";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Экзамены";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sem
            // 
            this.Sem.Location = new System.Drawing.Point(45, 50);
            this.Sem.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Sem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Sem.Name = "Sem";
            this.Sem.Size = new System.Drawing.Size(120, 20);
            this.Sem.TabIndex = 2;
            this.Sem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Sem.ValueChanged += new System.EventHandler(this.Sem_ValueChanged);
            // 
            // Zach
            // 
            this.Zach.InterceptArrowKeys = false;
            this.Zach.Location = new System.Drawing.Point(45, 89);
            this.Zach.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Zach.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Zach.Name = "Zach";
            this.Zach.ReadOnly = true;
            this.Zach.Size = new System.Drawing.Size(120, 20);
            this.Zach.TabIndex = 2;
            this.Zach.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(45, 286);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 0;
            // 
            // Zacht
            // 
            this.Zacht.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Zacht.Location = new System.Drawing.Point(185, 168);
            this.Zacht.Name = "Zacht";
            this.Zacht.Size = new System.Drawing.Size(105, 20);
            this.Zacht.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(45, 129);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.Sem_ValueChanged);
            // 
            // Sdan
            // 
            this.Sdan.Location = new System.Drawing.Point(45, 168);
            this.Sdan.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Sdan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Sdan.Name = "Sdan";
            this.Sdan.Size = new System.Drawing.Size(120, 20);
            this.Sdan.TabIndex = 2;
            this.Sdan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Sdan.ValueChanged += new System.EventHandler(this.Sdan_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 1;
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Сданные зачеты";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Zacht);
            this.Controls.Add(this.Zach);
            this.Controls.Add(this.Sdan);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Sem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sdan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Sem;
        private System.Windows.Forms.NumericUpDown Zach;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label Zacht;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown Sdan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

