using System;
using System.IO;

namespace MaxGiriy_Lesson06_Task03 {
    class ListCreator {
        public ListCreator(string path, int listNumber) {
            FileStream fileOut = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryWriter output = new BinaryWriter(fileOut);
            Random rand = new Random();
            for (int i = 1; i <= listNumber; i++) {
                output.Write($"name{i},surname{i},univercity{rand.Next(1, 5)},faculty{rand.Next(1, 4)},department{rand.Next(1, 4)}" +
                        $",{rand.Next(17, 23)},{rand.Next(1, 7)},{rand.Next(1,4)},city{rand.Next(1, 4)}\n");
            }
            output.Close();
            fileOut.Close();
        }
    }
}
