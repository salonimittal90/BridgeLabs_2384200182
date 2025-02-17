using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_s_Runtime_Analysis___Big_O_Notation
{
    class FileReading
    {

        public static void ComparePerformance(string filePath)
        {
            // 1Using StreamReader (Character by Character)
            Stopwatch sw1 = Stopwatch.StartNew();
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.Read() != -1) { } // Character by Character Read
            }
            sw1.Stop();
            Console.WriteLine("StreamReader Time: " + sw1.ElapsedMilliseconds + " ms");

            // Using FileStream (Byte by Byte - More Efficient)
            Stopwatch sw2 = Stopwatch.StartNew();
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[4096]; // 4KB Buffer
                while (fs.Read(buffer, 0, buffer.Length) > 0) { } // Reading in chunks
            }
            sw2.Stop();
            Console.WriteLine("FileStream Time: " + sw2.ElapsedMilliseconds + " ms");
        }
    }

}
