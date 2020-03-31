using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Zone {
    public class Zones {
        public int SumZones(int a, int b) {
            int c = a + b;
            File.Create("./file.txt");
            File.AppendAllText("./file.txt", c.ToString());
            return c;
        }
    }
}
