using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxGiriy_Lesson07_Task02 {
    public partial class EnterForm : Form {
        MainForm mainForm;
        public EnterForm(MainForm mainForm) {
            InitializeComponent();
            Text = "Ввод";
            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e) {
            int guessNum;
            if (int.TryParse(tbx_enterBox.Text, out guessNum)) {
                mainForm.GuessNumber(guessNum);
                mainForm.CheckNumber();
                Close();
            }
        }
    }
}
