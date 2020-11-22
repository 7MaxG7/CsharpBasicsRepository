using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MaxGiriy_Lesson08_Task03 {
    public partial class Form1 : Form, ITrueFalse {
        //TrueFalseBase database;
        Adapter adapter;

        public Form1() {
            InitializeComponent();
            adapter = new Adapter(this);
        }

        public string Quest { get => tboxQuestion.Text; set => tboxQuestion.Text = value; }
        public bool TrueFalse { get => cboxTrue.Checked; set => cboxTrue.Checked = value; }
        public uint QuestNumber { get => (uint)nudNumber.Value; }
        public string FileName { get; set; }

        private void miExit_Click(object sender, EventArgs e) {
            this.Close();
        }
        // Обработчик пункта меню New
        private void miNew_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK) {
                FileName = sfd.FileName;
                adapter.CreateDb();
                nudNumber.Value = 1;
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
            };
        }
        // Обработчик пункта меню Save
        private void miSave_Click(object sender, EventArgs e) {
            if (!adapter.SaveDb())
                MessageBox.Show("База данных не создана");
        }
        // Обработчик пункта меню SaveAs
        private void miSaveAs_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK) {
                FileName = sfd.FileName;
                miSave_Click(sender, e);
            }
        }
        // Обработчик пункта меню Open
        private void miOpen_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                FileName = ofd.FileName;
                if (!adapter.LoadDb()) {
                    MessageBox.Show("Ошибка загрузки базы");
                    return;
                }
                nudNumber.Minimum = 1;
                nudNumber.Maximum = adapter.Count;
                nudNumber.Value = 1;
            }
        }
        // Обработчик пункта меню About
        private void miAbout_Click(object sender, EventArgs e) {
            MessageBox.Show("Автор: Бездельник!\nВерсия: 1.0\n©Бездельник");
        }
        // Обработчик события изменения значения numericUpDown
        private void nudNumber_ValueChanged(object sender, EventArgs e) {
            Question quest = adapter.GetQuestion();
            tboxQuestion.Text = quest.Text;
            cboxTrue.Checked = quest.TrueFalse;
        }
        // Обработчик кнопки Добавить
        private void btnAdd_Click(object sender, EventArgs e) {
            if (!adapter.AddNewQuestion()) {
                MessageBox.Show("Не создана база данных либо не заполнен вопрос", "Сообщение");
                return;
            }
            nudNumber.Maximum = adapter.Count;
            nudNumber.Value = adapter.Count;
        }
        // Обработчик кнопки Сохранить (вопрос)
        private void btnSaveQuest_Click(object sender, EventArgs e) {
            adapter.ChangeQuestion();
        }
        // Обработчик кнопки Удалить
        private void btnDelete_Click(object sender, EventArgs e) {
            adapter.RemoveQuestion();
            nudNumber.Maximum = adapter.Count > 0 ? adapter.Count : 1;
            if (nudNumber.Value > nudNumber.Maximum) nudNumber.Value--;
            nudNumber_ValueChanged(sender, e);
        }
    }
}
