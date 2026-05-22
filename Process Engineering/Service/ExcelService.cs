using Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

namespace Process_Engineering.Service
{
    internal class ExcelService : IXlsService
    {

        private Application excel;
        private Workbook book;

        public void close()
        {
            book.Close(SaveChanges: false);
        }

        public void closeApp()
        {
            if (excel == null) { return; }
            excel.Quit();
        }

        public void open(string fileName, bool visible)
        {
            if (excel == null)
            {
                excel = visible ? getApplication() : new Application();
                excel.Visible = visible;
            }
            book = fileName.Equals(string.Empty) ? excel.Workbooks.Add() : book = excel.Workbooks.Open(fileName);
        }

        public void print(string printerName)
        {
            book.PrintOutEx(ActivePrinter: printerName);
        }

        public void setTextValue(int sheetNumber, string cellName, string value)
        {
            Worksheet workSheet = book.Sheets[sheetNumber];
            workSheet.Range[cellName].Value = value;
        }

        public void setTextValue(int sheetNumber, int Col, int Row, string value)
        {
            Worksheet workSheet = book.Sheets[sheetNumber];
            workSheet.Cells[Row, Col].Text = value;
        }

        public string getTextValue(int sheetNumber, int Col, int Row)
        {
            Worksheet workSheet = book.Sheets[sheetNumber];
            return workSheet.Cells[Row, Col].Value.ToString();
        }

        public string getTextValue(int sheetNumber, string cellName)
        {
            Worksheet workSheet = book.Sheets[sheetNumber];
            return workSheet.Range[cellName].Value?.ToString() ?? string.Empty;
        }

        public void addHyperLink(int sheetNumber, int col, int row, string link)
        {
            Worksheet workSheet = book.Sheets[sheetNumber];
            workSheet.Hyperlinks.Add(workSheet.Cells[row, col], link);
        }

        public void autoFit(int sheetNumber)
        {
            Worksheet workSheet = book.Sheets[sheetNumber];
            workSheet.Columns.AutoFit();
        }

        public void setTextFormat(int sheetNumber, string cellName)
        {
            Worksheet workSheet = book.Sheets[sheetNumber];
            workSheet.Range[cellName].NumberFormat = "@";
        }

        public void setPicture(int sheetNumber, Image picture, string leftTopCell, string rightBottomCell, bool autoSize)
        {
            Worksheet sheet = book.Sheets[sheetNumber];
            float left = (float)sheet.Range[leftTopCell].Left;
            float top = (float)sheet.Range[leftTopCell].Top;
            float width = (float)sheet.Range[$"{leftTopCell}:{rightBottomCell}"].Width;
            float height = (float)sheet.Range[$"{leftTopCell}:{rightBottomCell}"].Height;
            if (autoSize)
            {
                left += (float)sheet.Range[leftTopCell].Width / 2;
                if (height / picture.Height > width / picture.Width)
                {
                    float newHeight = width * picture.Height / picture.Width;
                    top += (height - newHeight) / 2;
                    height = newHeight;
                }
                else
                {
                    float newWidth = height * picture.Width / picture.Height;
                    left += (width - newWidth) / 2;
                    width = newWidth;
                }
            }
            else
            {
                Graphics graphic = Graphics.FromImage(picture);
                left += (width - picture.Width * 72 / graphic.DpiX) / 2;
                top += (height - picture.Height * 72 / graphic.DpiY) / 2;
                width = -1;
                height = -1;
            }

            string pictureFile = Path.GetTempFileName();
            picture.Save(pictureFile);
            sheet.Shapes.AddPicture(pictureFile, Microsoft.Office.Core.MsoTriState.msoFalse,
                Microsoft.Office.Core.MsoTriState.msoTrue, left, top, width, height);
        }

        private Application getApplication()
        {
            try
            {
                return (Application)Marshal.GetActiveObject("Excel.Application");
            }
            catch (COMException)
            {
                return new Application();
            }
        }

        public void copySheet(int sheetNumber)
        {
            Worksheet sheet = book.Sheets[sheetNumber];
            sheet.Copy(After: book.Sheets[book.Worksheets.Count]);
            sheet = book.Worksheets[book.Worksheets.Count];
            sheet.Name = $"Страница {sheetNumber + 1}";
        }

        public void copyRange(int sheetNumber, string rangeFrom, string rangeTo)
        {
            Worksheet workSheet = book.Sheets[sheetNumber];
            workSheet.Range[rangeFrom].Copy(workSheet.Range[rangeTo]);
        }

        public void copyRow(int sheetNumber, int rowNumber)
        {
            Worksheet workSheet = book.Sheets[sheetNumber];
            workSheet.Range[$"{rowNumber}:{rowNumber}"].Copy();
            workSheet.Range[$"{rowNumber}:{rowNumber}"].Insert(XlInsertShiftDirection.xlShiftDown, XlInsertFormatOrigin.xlFormatFromLeftOrAbove);
        }

        public void save(string fileName)
        {            
            book.SaveAs(fileName);            
        }
    }
}
