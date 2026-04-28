using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Process_Engineering.Service
{
    internal class TestService
    {
        private static int resultBookRow = 1;
        private static int filesCount = 1;

        public static void findPSheets()
        {
            string path = "C:\\Users\\jv00706\\Desktop\\M6\\CKD\\AS(1)";
            MessageBox.Show(getFilesAmount(new DirectoryInfo(path)).ToString());
            ExcelService excel = new ExcelService();
            excel.open("C:\\Users\\jv00706\\Desktop\\M6\\CKD\\Детали.xlsx", true);
            readPSheets(new DirectoryInfo(path), excel);
        }

        public static int getFilesAmount(DirectoryInfo directory)
        {
            int filesAmount = 0;
            if (!directory.Exists)
            {
                return filesAmount;
            }
            foreach (DirectoryInfo d in directory.GetDirectories())
            {
                filesAmount += getFilesAmount(d);
            }
            filesAmount += directory.GetFiles("*.xls?").Length;
            return filesAmount;
        }

        public static void readPSheets(DirectoryInfo directory, ExcelService resultBook)
        {
            foreach (DirectoryInfo d in directory.GetDirectories())
            {
                readPSheets(d, resultBook);
            }
            ExcelService card = new ExcelService();
            foreach (FileInfo f in directory.GetFiles("*.xls?"))
            {
                filesCount++;
                if (f.Name.Contains('~'))
                {
                    f.Delete();
                    continue;
                }
                card.open(f.FullName, false);
                int row = card.getTextValue(1, "V2").StartsWith("№") ? 5 : 4;
                string cardNumber = card.getTextValue(1, "V2").StartsWith("№") ? card.getTextValue(1, "V3") : card.getTextValue(1, "V2");
                while (!card.getTextValue(1, $"R{++row}").Equals(string.Empty))
                {
                    resultBook.setTextValue(1, 1, resultBookRow, cardNumber);
                    resultBook.addHyperLink(1, 1, resultBookRow, f.FullName);
                    resultBook.setTextValue(1, 2, resultBookRow, card.getTextValue(1, $"Q{row}"));
                    resultBook.setTextValue(1, 3, resultBookRow, card.getTextValue(1, $"R{row}"));
                    resultBook.setTextValue(1, 4, resultBookRow, card.getTextValue(1, $"V{row}"));
                    resultBook.setTextValue(1, 5, resultBookRow++, filesCount.ToString());
                }
                card.close();
            }
            card.closeApp();
        }        
        
        public static void modifyTextFile()
        {
            string[] lines = File.ReadAllLines("C:\\Users\\jv00706\\Desktop\\Текстовый документ.txt");
            StringBuilder sb = new StringBuilder();
            foreach (string line in lines)
            {
                sb.Append(line);
                sb.Append(",");
            }
            File.WriteAllText("C:\\Users\\jv00706\\Desktop\\Текстовый документ1.txt", sb.ToString());
        }
    }
}
