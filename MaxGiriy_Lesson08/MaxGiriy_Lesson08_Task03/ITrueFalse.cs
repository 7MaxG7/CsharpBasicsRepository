using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxGiriy_Lesson08_Task03 {
    interface ITrueFalse {
        string Quest { get; set; }
        bool TrueFalse { get; set; }
        uint QuestNumber { get; }
        string FileName { get; set; }
    }
}
