using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxGiriy_Lesson07_Task01 {
    public partial class Form1 : Form {
        int counter = 0;
        int currentNumber = 0;
        int targetNumber = 0;
        bool isPlaying = false;
        Stack<Foo> turns;

        delegate void Foo();

        public Form1() {
            InitializeComponent();
            Text = "Удвоитель";
            lbl_output1.Text = "0";
            btn_add.Text = "+1";
            btn_multi.Text = "x2";
            btn_reset.Text = "Сброс";
            btn_play.Text = "Играть";
            turns = new Stack<Foo>();
        }

    #region Методы нажатия клавиш

        /// <summary>
        /// Добавляет к текущему числу 1, добавляет в стек делегат с вычитанием,
        /// увеличение счетчика и проверка достижения нужного числа
        /// </summary>
        private void btn_add_Click(object sender, EventArgs e) {
            lbl_output1.Text = (++currentNumber).ToString();
            turns.Push(Substract);
            checkTurn();
        }
        /// <summary>
        /// Умножение текущего числу на 2, добавляет в стек делегат с делением,
        /// увеличение счетчика и проверка достижения нужного числа
        /// </summary>
        private void btn_multi_Click(object sender, EventArgs e) {
            currentNumber *= 2;
            lbl_output1.Text = currentNumber.ToString();
            turns.Push(Devide);
            checkTurn();
        }
        /// <summary>
        /// Обнуляет текущее значение числа, очищает стек делегатов,
        /// но считается действием
        /// </summary>
        private void btn_reset_Click(object sender, EventArgs e) {
            currentNumber = 0;
            lbl_output1.Text = currentNumber.ToString();
            turns.Clear();
            checkTurn();
        }
        /// <summary>
        /// Отменяет последние произведенные действия с числом
        /// </summary>
        private void btn_undo_Click(object sender, EventArgs e) {
            if (turns.Count > 0) {
                Foo foo = turns.Pop();
                foo();
            }
        }
        /// <summary>
        /// Включает режим игры с достижением рандомного числа от 100 до 1000,
        /// при повторном нажатии кнопки игра прекращается
        /// </summary>
        private void btn_play_Click(object sender, EventArgs e) {
            if (!isPlaying) {
                isPlaying = true;
                btn_play.Text = "Хватит";
                Random rand = new Random();
                targetNumber = rand.Next(100, 1000);
                lbl_output2.Text = targetNumber.ToString();
                ResetNumbers();
            } else {
                StopPlaying();
            }
        }

    #endregion

    #region Методы отмены нажатий

        /// <summary>
        /// Отмена прибавления числа
        /// </summary>
        void Substract() {
            lbl_output1.Text = (--currentNumber).ToString();
            lbl_output3.Text = (--counter).ToString();
        }
        /// <summary>
        /// Отмена умножения числа
        /// </summary>
        void Devide() {
            currentNumber /= 2;
            lbl_output1.Text = currentNumber.ToString();
            lbl_output3.Text = (--counter).ToString();
        }

    #endregion

    #region Вспомогательные методы

        /// <summary>
        /// Обнуляет текущее число и счетчик
        /// </summary>
        void ResetNumbers() {
            currentNumber = 0;
            lbl_output1.Text = currentNumber.ToString();
            counter = 0;
            lbl_output3.Text = counter.ToString();
        }
        /// <summary>
        /// Увеличение счетчика и проверка текущего числа на целевое в режиме игры,
        /// в случае достижения игра прекращается
        /// </summary>
        void checkTurn() {
            lbl_output3.Text = (++counter).ToString();
            if (isPlaying) {
                if (currentNumber == targetNumber) {
                    MessageBox.Show($"Число достигнуто за {counter} ходов");
                    ResetNumbers();
                    StopPlaying();
                }
            }
        }
        /// <summary>
        /// Выход из режима игры (текущее число и счетчик не обнуляются)
        /// </summary>
        private void StopPlaying() {
            isPlaying = false;
            btn_play.Text = "Играть";
            targetNumber = 0;
            lbl_output2.Text = "-";
        }
    #endregion

    }
}
