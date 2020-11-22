namespace MaxGiriy_Lesson08_Task02 {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.tb_text = new System.Windows.Forms.TextBox();
            this.nud_number = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_number)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_text
            // 
            this.tb_text.Location = new System.Drawing.Point(13, 13);
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(323, 26);
            this.tb_text.TabIndex = 0;
            // 
            // nud_number
            // 
            this.nud_number.Location = new System.Drawing.Point(343, 13);
            this.nud_number.Name = "nud_number";
            this.nud_number.Size = new System.Drawing.Size(83, 26);
            this.nud_number.TabIndex = 1;
            this.nud_number.ValueChanged += new System.EventHandler(this.nud_number_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 50);
            this.Controls.Add(this.nud_number);
            this.Controls.Add(this.tb_text);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_text;
        private System.Windows.Forms.NumericUpDown nud_number;
    }
}

