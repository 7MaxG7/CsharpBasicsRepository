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
    public partial class MainForm : Form {
        int targetNumber = 0, playerNumber = 0, counter = 0;

        public MainForm() {
            InitializeComponent();
            Text = "Угадайка";
        }

        private void btn_guessNumber_Click(object sender, EventArgs e) {
            Random rand = new Random();
            targetNumber = rand.Next(1, 100);
            lbl_message.Text = "Число загадано!";
            counter = 0;
            playerNumber = 0;
            lbl_tryNumber.Text = $"Число попыток: ";
        }

        private void enterNumber_Click(object sender, EventArgs e) {
            if (targetNumber != 0) {
                EnterForm enterForm = new EnterForm(this);
                enterForm.Show();
            } else {
                lbl_message.Text = "Сначала загадайте число.";
            }
        }

        public void CheckNumber() {
            if (playerNumber == targetNumber) {
                MessageBox.Show($"Верно! Число угадано за {counter} попыток.", "Поздравляем!");
                targetNumber = 0;
                counter = 0;
                lbl_message.Text = "Число угадано.";
            } else if (playerNumber > targetNumber) {
                lbl_message.Text = "Слишком много.";
            } else if (playerNumber != 0) {
                lbl_message.Text = "Слишком мало.";
            }
        }

        public void GuessNumber(int guessNumber) {
            playerNumber = guessNumber;
            lbl_tryNumber.Text = $"Число попыток: {++counter}";
        }
    }
}
