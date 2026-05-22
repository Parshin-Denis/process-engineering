using System.Drawing;

namespace Process_Engineering.Service
{
    internal interface IXlsService
    {
        void open(string fileName, bool visible);

        void close();

        void closeApp();

        void setTextValue(int sheetNumber, string cellName, string value);

        void setTextFormat(int sheetNumber, string cellName);

        void setPicture(int sheetNumber, Image picture, string leftTopCell, string rightBottomCell, bool autoSize);

        void print(string printerName);

        void copySheet(int sheetNumber = 1);

        void copyRange(int sheetNumber, string rangeFrom, string rangeTo);

        void copyRow(int sheetNumber, int rowNumber);
        
        void save(string fileName);
    }
}
