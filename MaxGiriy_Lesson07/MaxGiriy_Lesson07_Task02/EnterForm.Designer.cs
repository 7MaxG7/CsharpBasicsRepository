namespace MaxGiriy_Lesson07_Task02 {
    partial class EnterForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbl_enterMessage = new System.Windows.Forms.Label();
            this.tbx_enterBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_enterMessage
            // 
            this.lbl_enterMessage.Location = new System.Drawing.Point(50, 50);
            this.lbl_enterMessage.Name = "lbl_enterMessage";
            this.lbl_enterMessage.Size = new System.Drawing.Size(230, 20);
            this.lbl_enterMessage.TabIndex = 0;
            this.lbl_enterMessage.Text = "Введите число от 1 до 100";
            // 
            // tbx_enterBox
            // 
            this.tbx_enterBox.Location = new System.Drawing.Point(115, 100);
            this.tbx_enterBox.Name = "tbx_enterBox";
            this.tbx_enterBox.Size = new System.Drawing.Size(100, 26);
            this.tbx_enterBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назвать число";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbx_enterBox);
            this.Controls.Add(this.lbl_enterMessage);
            this.Name = "EnterForm";
            this.Text = "EnterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_enterMessage;
        private System.Windows.Forms.TextBox tbx_enterBox;
        private System.Windows.Forms.Button button1;
    }
}