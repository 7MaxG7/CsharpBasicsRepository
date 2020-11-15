namespace MaxGiriy_Lesson07_Task01 {
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_output1 = new System.Windows.Forms.Label();
            this.lbl_outputText1 = new System.Windows.Forms.Label();
            this.lbl_outputText2 = new System.Windows.Forms.Label();
            this.lbl_output2 = new System.Windows.Forms.Label();
            this.lbl_outputText3 = new System.Windows.Forms.Label();
            this.lbl_output3 = new System.Windows.Forms.Label();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_undo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(255, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 40);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "+1";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Location = new System.Drawing.Point(255, 58);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(133, 40);
            this.btn_multi.TabIndex = 1;
            this.btn_multi.Text = "x2";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(255, 104);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(133, 40);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "Сброс";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lbl_output1
            // 
            this.lbl_output1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_output1.Location = new System.Drawing.Point(62, 33);
            this.lbl_output1.Name = "lbl_output1";
            this.lbl_output1.Size = new System.Drawing.Size(129, 32);
            this.lbl_output1.TabIndex = 3;
            this.lbl_output1.Text = "0";
            this.lbl_output1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_outputText1
            // 
            this.lbl_outputText1.AutoSize = true;
            this.lbl_outputText1.Location = new System.Drawing.Point(95, 13);
            this.lbl_outputText1.Name = "lbl_outputText1";
            this.lbl_outputText1.Size = new System.Drawing.Size(96, 20);
            this.lbl_outputText1.TabIndex = 4;
            this.lbl_outputText1.Text = "Что имеем:";
            // 
            // lbl_outputText2
            // 
            this.lbl_outputText2.AutoSize = true;
            this.lbl_outputText2.Location = new System.Drawing.Point(99, 214);
            this.lbl_outputText2.Name = "lbl_outputText2";
            this.lbl_outputText2.Size = new System.Drawing.Size(92, 20);
            this.lbl_outputText2.TabIndex = 6;
            this.lbl_outputText2.Text = "Что нужно:";
            // 
            // lbl_output2
            // 
            this.lbl_output2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_output2.Location = new System.Drawing.Point(62, 234);
            this.lbl_output2.Name = "lbl_output2";
            this.lbl_output2.Size = new System.Drawing.Size(129, 32);
            this.lbl_output2.TabIndex = 5;
            this.lbl_output2.Text = "-";
            this.lbl_output2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_outputText3
            // 
            this.lbl_outputText3.AutoSize = true;
            this.lbl_outputText3.Location = new System.Drawing.Point(114, 104);
            this.lbl_outputText3.Name = "lbl_outputText3";
            this.lbl_outputText3.Size = new System.Drawing.Size(77, 20);
            this.lbl_outputText3.TabIndex = 8;
            this.lbl_outputText3.Text = "Счетчик:";
            // 
            // lbl_output3
            // 
            this.lbl_output3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_output3.Location = new System.Drawing.Point(62, 124);
            this.lbl_output3.Name = "lbl_output3";
            this.lbl_output3.Size = new System.Drawing.Size(129, 32);
            this.lbl_output3.TabIndex = 7;
            this.lbl_output3.Text = "0";
            this.lbl_output3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(255, 226);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(133, 40);
            this.btn_play.TabIndex = 9;
            this.btn_play.Text = "Играть";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_undo
            // 
            this.btn_undo.Location = new System.Drawing.Point(255, 150);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(133, 40);
            this.btn_undo.TabIndex = 10;
            this.btn_undo.Text = "Отменить";
            this.btn_undo.UseVisualStyleBackColor = true;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 322);
            this.Controls.Add(this.btn_undo);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.lbl_outputText3);
            this.Controls.Add(this.lbl_output3);
            this.Controls.Add(this.lbl_outputText2);
            this.Controls.Add(this.lbl_output2);
            this.Controls.Add(this.lbl_outputText1);
            this.Controls.Add(this.lbl_output1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_output1;
        private System.Windows.Forms.Label lbl_outputText1;
        private System.Windows.Forms.Label lbl_outputText2;
        private System.Windows.Forms.Label lbl_output2;
        private System.Windows.Forms.Label lbl_outputText3;
        private System.Windows.Forms.Label lbl_output3;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_undo;
    }
}

