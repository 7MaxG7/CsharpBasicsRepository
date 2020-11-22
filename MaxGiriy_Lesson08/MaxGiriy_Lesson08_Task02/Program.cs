using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxGiriy_Lesson08_Task02 {
    static class Program {
        
//        Гирий Макс
//            Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством
//            Value элемента NumericUpDown

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
