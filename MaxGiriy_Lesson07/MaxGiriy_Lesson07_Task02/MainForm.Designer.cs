namespace MaxGiriy_Lesson07_Task02 {
    partial class MainForm {
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
            this.btn_guessNumber = new System.Windows.Forms.Button();
            this.enterNumber = new System.Windows.Forms.Button();
            this.lbl_message = new System.Windows.Forms.Label();
            this.lbl_tryNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_guessNumber
            // 
            this.btn_guessNumber.Location = new System.Drawing.Point(80, 50);
            this.btn_guessNumber.Name = "btn_guessNumber";
            this.btn_guessNumber.Size = new System.Drawing.Size(160, 40);
            this.btn_guessNumber.TabIndex = 0;
            this.btn_guessNumber.Text = "Загадайте число";
            this.btn_guessNumber.UseVisualStyleBackColor = true;
            this.btn_guessNumber.Click += new System.EventHandler(this.btn_guessNumber_Click);
            // 
            // enterNumber
            // 
            this.enterNumber.Location = new System.Drawing.Point(80, 100);
            this.enterNumber.Name = "enterNumber";
            this.enterNumber.Size = new System.Drawing.Size(160, 40);
            this.enterNumber.TabIndex = 1;
            this.enterNumber.Text = "Ввести число";
            this.enterNumber.UseVisualStyleBackColor = true;
            this.enterNumber.Click += new System.EventHandler(this.enterNumber_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.Location = new System.Drawing.Point(80, 200);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(160, 40);
            this.lbl_message.TabIndex = 2;
            // 
            // lbl_tryNumber
            // 
            this.lbl_tryNumber.Location = new System.Drawing.Point(80, 250);
            this.lbl_tryNumber.Name = "lbl_tryNumber";
            this.lbl_tryNumber.Size = new System.Drawing.Size(160, 40);
            this.lbl_tryNumber.TabIndex = 3;
            this.lbl_tryNumber.Text = "Число попыток:";
            this.lbl_tryNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 314);
            this.Controls.Add(this.lbl_tryNumber);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.enterNumber);
            this.Controls.Add(this.btn_guessNumber);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_guessNumber;
        private System.Windows.Forms.Button enterNumber;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Label lbl_tryNumber;
    }
}

