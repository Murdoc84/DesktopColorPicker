using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopColorPicker.common
{
    class Templates
    {
        private static string dir = "templates";

        public string BuildFromTemplate(List<string> list, string name)
        {
            StringBuilder sb = new StringBuilder(ReadTemplate(name));
            return sb
                  .Replace("$Name", list[0])
                  .Replace("$X", list[1])
                  .Replace("$Y", list[2])
                  .Replace("$A", list[3])
                  .Replace("$R", list[4])
                  .Replace("$G", list[5])
                  .Replace("$B", list[6])
                  .Replace("$hR", list[7])
                  .Replace("$hG", list[8])
                  .Replace("$hB", list[9])
                  .Replace("$Hex", list[10])
                  .ToString();
        }

        public string ReadTemplate(string name)
        {
            return String.Join("\n", File.ReadAllLines(dir + @"\" + name + ".txt"));
        }
    }
}
