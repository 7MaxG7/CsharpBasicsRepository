using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxGiriy_Lesson08_Task02 {
    public partial class Form1 : Form {
        List<string> texts;
        public Form1() {
            InitializeComponent();
            InitializeTextList();
            InitializeNud();
        }

        private void InitializeTextList() {
            texts = new List<string>() { 
                    $"And all the girlies say...",
                    $"I'm pretty fly...",
                    $"For a white guy"
            };
        }
        private void InitializeNud() {
            nud_number.Value = 1;
            nud_number.Minimum = 1;
            nud_number.Maximum = texts.Count;
        }
        private void nud_number_ValueChanged(object sender, EventArgs e) {
            tb_text.Text = texts[(int)nud_number.Value - 1];
        }
    }
}
