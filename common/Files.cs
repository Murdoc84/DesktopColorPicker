using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace DesktopColorPicker.common
{
    internal class Files
    {
        private static string dir = "data";
        private string csv = dir + @"\saved.csv";
        private string cols = "Name,X,Y,A,R,G,B,hR,hG,hB,Hex";

        public void PrepareAndAppendToCsv(List<string> stream)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                //File.Create(csv);
                //File.SetAttributes(csv, FileAttributes.Normal);
            }

            string str = "";
            if (File.Exists(csv))
            {
                using (StreamReader sr = new StreamReader(csv))
                {
                    str = sr.ReadToEnd();
                }
                File.Delete(csv);
            }

            using (StreamWriter sw = new StreamWriter(csv, false))
            {
                str = String.Join(",", stream) + Environment.NewLine + str;
                sw.Write(str);
            }
        }

        public List<string> PrepareStream(string name, int x, int y, Color color)
        {
            List<string> stream = new List<string>();
            stream.Add(name);
            stream.Add(x.ToString());
            stream.Add(y.ToString());
            stream.Add(color.A.ToString());
            stream.Add(color.R.ToString());
            stream.Add(color.G.ToString());
            stream.Add(color.B.ToString());
            stream.Add(color.R.ToString("X2"));
            stream.Add(color.G.ToString("X2"));
            stream.Add(color.B.ToString("X2"));
            stream.Add("#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2"));
            return stream;
        }

        public void DeleteRow(int row)
        {
            List<string> lines = File.ReadLines(csv).ToList();
            lines.RemoveAt(row);
            File.WriteAllLines(csv, lines);
        }

        public void UpdateRow(int row, List<string> stream)
        {
            List<string> lines = File.ReadLines(csv).ToList();
            lines.RemoveAt(row);
            lines.Insert(row, String.Join(",", stream));
            File.WriteAllLines(csv, lines);
        }

        public void MoveRowUp(int row)
        {
            List<string> lines = File.ReadLines(csv).ToList();
            string line = lines[row];
            lines.RemoveAt(row);
            lines.Insert(row - 1, line);
            File.WriteAllLines(csv, lines);
        }

        public void MoveRowDown(int row)
        {
            List<string> lines = File.ReadLines(csv).ToList();
            string line = lines[row];
            lines.RemoveAt(row);
            lines.Insert(row + 1, line);
            File.WriteAllLines(csv, lines);
        }

        public DataTable ReadCsv()
        {
            DataTable dt = new DataTable();
            try
            {
                string[] Lines = File.ReadAllLines(csv);
                string[] Fields;
                Fields = cols.Split(new char[] { ',' });
                int Cols = Fields.GetLength(0);
                for (int i = 0; i < Cols; i++)
                    dt.Columns.Add(Fields[i], typeof(string));
                DataRow Row;
                for (int i = 0; i < Lines.GetLength(0); i++)
                {
                    Fields = Lines[i].Split(new char[] { ',' });
                    Row = dt.NewRow();
                    for (int f = 0; f < Cols; f++)
                        Row[f] = Fields[f];
                    dt.Rows.Add(Row);
                }
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public List<string> ReadLine(int row)
        {
            List<string> lines = File.ReadLines(csv).ToList();
            return lines[row].Split(',').ToList<string>();
        }
    }
}