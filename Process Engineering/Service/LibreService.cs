/*
 * This file is part of the LibreOffice project.
 *
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 *
 * This file incorporates work covered by the following license notice:
 *
 *   Licensed to the Apache Software Foundation (ASF) under one or more
 *   contributor license agreements. See the NOTICE file distributed
 *   with this work for additional information regarding copyright
 *   ownership. The ASF licenses this file to you under the Apache
 *   License, Version 2.0 (the "License"); you may not use this file
 *   except in compliance with the License. You may obtain a copy of
 *   the License at http://www.apache.org/licenses/LICENSE-2.0 .
 */

using Process_Engineering.Service;
using System;
using System.IO;
using System.Net;
using unoidl.com.sun.star.awt;
using unoidl.com.sun.star.beans;
using unoidl.com.sun.star.container;
using unoidl.com.sun.star.drawing;
using unoidl.com.sun.star.frame;
using unoidl.com.sun.star.graphic;
using unoidl.com.sun.star.lang;
using unoidl.com.sun.star.sheet;
using unoidl.com.sun.star.table;
using unoidl.com.sun.star.text;
using unoidl.com.sun.star.util;
using unoidl.com.sun.star.view;

// __________  implementation  ____________________________________

/** This is a helper class for the spreadsheet and table samples.
    It connects to a running office and creates a spreadsheet document.
    Additionally it contains various helper functions.
 */
public class LibreService : System.IDisposable, IXlsService
{

    // __  private members  ___________________________________________

    private const String msDataSheetName = "Data";

    private unoidl.com.sun.star.uno.XComponentContext m_xContext;
    private unoidl.com.sun.star.lang.XMultiServiceFactory mxMSFactory;
    private unoidl.com.sun.star.sheet.XSpreadsheetDocument mxDocument;
    private unoidl.com.sun.star.frame.XDesktop xDesktop;

    public LibreService()
    {
        mxMSFactory = connect();
        string[] names = mxMSFactory.getAvailableServiceNames();
        xDesktop = (XDesktop)mxMSFactory.createInstance("com.sun.star.frame.Desktop");
    }

    #region Примеры

    public LibreService(String path, bool readOnly = true)
    {
        // Connect to a running office and get the service manager
        mxMSFactory = connect();
        // Create a new spreadsheet document
        mxDocument = initDocument(path, readOnly);
    }

    // __  helper methods  ____________________________________________

    /** Returns the service manager.
        @return  XMultiServiceFactory interface of the service manager. */
    public unoidl.com.sun.star.lang.XMultiServiceFactory getServiceManager()
    {
        return mxMSFactory;
    }

    /** Returns the whole spreadsheet document.
        @return  XSpreadsheetDocument interface of the document. */
    public unoidl.com.sun.star.sheet.XSpreadsheetDocument getDocument()
    {
        return mxDocument;
    }

    /** Returns the spreadsheet with the specified index (0-based).
        @param nIndex  The index of the sheet.
        @return  XSpreadsheet interface of the sheet. */
    public unoidl.com.sun.star.sheet.XSpreadsheet getSpreadsheet(int nIndex)
    {
        // Collection of sheets
        unoidl.com.sun.star.sheet.XSpreadsheets xSheets =
            mxDocument.getSheets();

        unoidl.com.sun.star.container.XIndexAccess xSheetsIA =
            (unoidl.com.sun.star.container.XIndexAccess)xSheets;

        unoidl.com.sun.star.sheet.XSpreadsheet xSheet =
            (unoidl.com.sun.star.sheet.XSpreadsheet)
              xSheetsIA.getByIndex(nIndex).Value;
        return xSheet;
    }

    /** Inserts a new empty spreadsheet with the specified name.
        @param aName  The name of the new sheet.
        @param nIndex  The insertion index.
        @return  The XSpreadsheet interface of the new sheet. */
    public unoidl.com.sun.star.sheet.XSpreadsheet insertSpreadsheet(
        String aName, short nIndex)
    {
        // Collection of sheets
        unoidl.com.sun.star.sheet.XSpreadsheets xSheets =
            mxDocument.getSheets();

        xSheets.insertNewByName(aName, nIndex);
        unoidl.com.sun.star.sheet.XSpreadsheet xSheet =
            (unoidl.com.sun.star.sheet.XSpreadsheet)
              xSheets.getByName(aName).Value;

        return xSheet;
    }

    // Methods to fill values into cells.

    /** Writes a double value into a spreadsheet.
        @param xSheet  The XSpreadsheet interface of the spreadsheet.
        @param aCellName  The address of the cell (or a named range).
        @param fValue  The value to write into the cell. */
    public void setValue(
        unoidl.com.sun.star.sheet.XSpreadsheet xSheet,
        String aCellName,
        double fValue)
    {
        xSheet.getCellRangeByName(aCellName).getCellByPosition(
            0, 0).setValue(fValue);
    }

    /** Writes a formula into a spreadsheet.
        @param xSheet  The XSpreadsheet interface of the spreadsheet.
        @param aCellName  The address of the cell (or a named range).
        @param aFormula  The formula to write into the cell. */
    public void setFormula(
        unoidl.com.sun.star.sheet.XSpreadsheet xSheet,
        String aCellName,
        String aFormula)
    {
        xSheet.getCellRangeByName(aCellName).getCellByPosition(
            0, 0).setFormula(aFormula);
    }

    /** Writes a date with standard date format into a spreadsheet.
        @param xSheet  The XSpreadsheet interface of the spreadsheet.
        @param aCellName  The address of the cell (or a named range).
        @param nDay  The day of the date.
        @param nMonth  The month of the date.
        @param nYear  The year of the date. */
    public void setDate(
        unoidl.com.sun.star.sheet.XSpreadsheet xSheet,
        String aCellName,
        int nDay, int nMonth, int nYear)
    {
        // Set the date value.
        unoidl.com.sun.star.table.XCell xCell =
            xSheet.getCellRangeByName(aCellName).getCellByPosition(0, 0);
        String aDateStr = nMonth + "/" + nDay + "/" + nYear;
        xCell.setFormula(aDateStr);

        // Set standard date format.
        unoidl.com.sun.star.util.XNumberFormatsSupplier xFormatsSupplier =
            (unoidl.com.sun.star.util.XNumberFormatsSupplier)getDocument();
        unoidl.com.sun.star.util.XNumberFormatTypes xFormatTypes =
            (unoidl.com.sun.star.util.XNumberFormatTypes)
              xFormatsSupplier.getNumberFormats();
        int nFormat = xFormatTypes.getStandardFormat(
            unoidl.com.sun.star.util.NumberFormat.DATE,
            new unoidl.com.sun.star.lang.Locale());

        unoidl.com.sun.star.beans.XPropertySet xPropSet =
            (unoidl.com.sun.star.beans.XPropertySet)xCell;
        xPropSet.setPropertyValue(
            "NumberFormat",
            new uno.Any((Int32)nFormat));
    }

    /** Draws a colored border around the range and writes the headline
        in the first cell.
        
        @param xSheet  The XSpreadsheet interface of the spreadsheet.
        @param aRange  The address of the cell range (or a named range).
        @param aHeadline  The headline text. */
    public void prepareRange(
        unoidl.com.sun.star.sheet.XSpreadsheet xSheet,
        String aRange, String aHeadline)
    {
        unoidl.com.sun.star.beans.XPropertySet xPropSet = null;
        unoidl.com.sun.star.table.XCellRange xCellRange = null;

        // draw border
        xCellRange = xSheet.getCellRangeByName(aRange);
        xPropSet = (unoidl.com.sun.star.beans.XPropertySet)xCellRange;
        unoidl.com.sun.star.table.BorderLine aLine =
            new unoidl.com.sun.star.table.BorderLine();
        aLine.Color = 0x99CCFF;
        aLine.InnerLineWidth = aLine.LineDistance = 0;
        aLine.OuterLineWidth = 100;
        unoidl.com.sun.star.table.TableBorder aBorder =
            new unoidl.com.sun.star.table.TableBorder();
        aBorder.TopLine = aBorder.BottomLine = aBorder.LeftLine =
            aBorder.RightLine = aLine;
        aBorder.IsTopLineValid = aBorder.IsBottomLineValid = true;
        aBorder.IsLeftLineValid = aBorder.IsRightLineValid = true;
        xPropSet.setPropertyValue(
            "TableBorder",
            new uno.Any(
                typeof(unoidl.com.sun.star.table.TableBorder), aBorder));

        // draw headline
        unoidl.com.sun.star.sheet.XCellRangeAddressable xAddr =
            (unoidl.com.sun.star.sheet.XCellRangeAddressable)xCellRange;
        unoidl.com.sun.star.table.CellRangeAddress aAddr =
            xAddr.getRangeAddress();

        xCellRange = xSheet.getCellRangeByPosition(
            aAddr.StartColumn,
            aAddr.StartRow, aAddr.EndColumn, aAddr.StartRow);

        xPropSet = (unoidl.com.sun.star.beans.XPropertySet)xCellRange;
        xPropSet.setPropertyValue(
            "CellBackColor", new uno.Any((Int32)0x99CCFF));
        // write headline
        unoidl.com.sun.star.table.XCell xCell =
            xCellRange.getCellByPosition(0, 0);
        xCell.setFormula(aHeadline);
        xPropSet = (unoidl.com.sun.star.beans.XPropertySet)xCell;
        xPropSet.setPropertyValue(
            "CharColor", new uno.Any((Int32)0x003399));
        xPropSet.setPropertyValue(
            "CharWeight",
            new uno.Any((Single)unoidl.com.sun.star.awt.FontWeight.BOLD));
    }


    // Methods to create cell addresses and range addresses.

    /** Creates a unoidl.com.sun.star.table.CellAddress and initializes it
        with the given range.
        @param xSheet  The XSpreadsheet interface of the spreadsheet.
        @param aCell  The address of the cell (or a named cell). */
    public unoidl.com.sun.star.table.CellAddress createCellAddress(
        unoidl.com.sun.star.sheet.XSpreadsheet xSheet,
        String aCell)
    {
        unoidl.com.sun.star.sheet.XCellAddressable xAddr =
        (unoidl.com.sun.star.sheet.XCellAddressable)
            xSheet.getCellRangeByName(aCell).getCellByPosition(0, 0);
        return xAddr.getCellAddress();
    }

    /** Creates a unoidl.com.sun.star.table.CellRangeAddress and initializes
        it with the given range.
        @param xSheet  The XSpreadsheet interface of the spreadsheet.
        @param aRange  The address of the cell range (or a named range). */
    public unoidl.com.sun.star.table.CellRangeAddress createCellRangeAddress(
        unoidl.com.sun.star.sheet.XSpreadsheet xSheet, String aRange)
    {
        unoidl.com.sun.star.sheet.XCellRangeAddressable xAddr =
            (unoidl.com.sun.star.sheet.XCellRangeAddressable)
            xSheet.getCellRangeByName(aRange);
        return xAddr.getRangeAddress();
    }


    // Methods to convert cell addresses and range addresses to strings.

    /** Returns the text address of the cell.
        @param nColumn  The column index.
        @param nRow  The row index.
        @return  A string containing the cell address. */
    public String getCellAddressString(int nColumn, int nRow)
    {
        String aStr = "";
        if (nColumn > 25)
            aStr += (char)('A' + nColumn / 26 - 1);
        aStr += (char)('A' + nColumn % 26);
        aStr += (nRow + 1);
        return aStr;
    }

    /** Returns the text address of the cell range.
        @param aCellRange  The cell range address.
        @return  A string containing the cell range address. */
    public String getCellRangeAddressString(
        unoidl.com.sun.star.table.CellRangeAddress aCellRange)
    {
        return
            getCellAddressString(aCellRange.StartColumn, aCellRange.StartRow)
            + ":"
            + getCellAddressString(aCellRange.EndColumn, aCellRange.EndRow);
    }

    /** Returns the text address of the cell range.
        @param xCellRange  The XSheetCellRange interface of the cell range.
        @param bWithSheet  true = Include sheet name.
        @return  A string containing the cell range address. */
    public String getCellRangeAddressString(
        unoidl.com.sun.star.sheet.XSheetCellRange xCellRange, bool bWithSheet)
    {
        String aStr = "";
        if (bWithSheet)
        {
            unoidl.com.sun.star.sheet.XSpreadsheet xSheet =
                xCellRange.getSpreadsheet();
            unoidl.com.sun.star.container.XNamed xNamed =
                (unoidl.com.sun.star.container.XNamed)xSheet;
            aStr += xNamed.getName() + ".";
        }
        unoidl.com.sun.star.sheet.XCellRangeAddressable xAddr =
            (unoidl.com.sun.star.sheet.XCellRangeAddressable)xCellRange;
        aStr += getCellRangeAddressString(xAddr.getRangeAddress());
        return aStr;
    }

    /** Returns a list of addresses of all cell ranges contained in the
        collection.
        
        @param xRangesIA  The XIndexAccess interface of the collection.
        @return  A string containing the cell range address list. */
    public String getCellRangeListString(
        unoidl.com.sun.star.container.XIndexAccess xRangesIA)
    {
        String aStr = "";
        int nCount = xRangesIA.getCount();
        for (int nIndex = 0; nIndex < nCount; ++nIndex)
        {
            if (nIndex > 0)
                aStr += " ";
            uno.Any aRangeObj = xRangesIA.getByIndex(nIndex);
            unoidl.com.sun.star.sheet.XSheetCellRange xCellRange =
                (unoidl.com.sun.star.sheet.XSheetCellRange)aRangeObj.Value;
            aStr += getCellRangeAddressString(xCellRange, false);
        }
        return aStr;
    }

    /** Connect to a running office that is accepting connections.
        @return  The ServiceManager to instantiate office components. */
    private XMultiServiceFactory connect()
    {
        m_xContext = uno.util.Bootstrap.bootstrap();

        return (XMultiServiceFactory)m_xContext.getServiceManager();
    }

    public void Dispose()
    {

    }

    /** Creates an empty spreadsheet document.
        @return  The XSpreadsheetDocument interface of the document. */
    private unoidl.com.sun.star.sheet.XSpreadsheetDocument initDocument(string path, bool readOnly = true)
    {
        XComponentLoader aLoader = (XComponentLoader)
            mxMSFactory.createInstance("com.sun.star.frame.Desktop");

        PropertyValue[] propertyArray = new PropertyValue[2];
        propertyArray[0] = new PropertyValue();
        propertyArray[0].Name = "ReadOnly";
        propertyArray[0].Value = new uno.Any(readOnly);
        propertyArray[1] = new PropertyValue();
        propertyArray[1].Name = "Hidden";
        propertyArray[1].Value = new uno.Any(false);


        XComponent xComponent = aLoader.loadComponentFromURL(
            "file:///" + path.Replace("\\", "/"), "_blank", 0, propertyArray);

        return (unoidl.com.sun.star.sheet.XSpreadsheetDocument)xComponent;
    }

    #endregion

    public void close()
    {
        ((unoidl.com.sun.star.util.XCloseable)mxDocument).close(true);
    }

    public void closeApp()
    {
        xDesktop.terminate();
    }

    public void save()
    {
        ((XStorable)mxDocument).store();
    }

    public void save(string fileName)
    {
        ((XStorable)mxDocument).storeAsURL("file:///" + fileName.Replace("\\", "/"), new PropertyValue[0]);
    }

    public void open(string fileName, bool visible)
    {
        XComponentLoader aLoader = (XComponentLoader)xDesktop;

        PropertyValue[] propertyArray = new PropertyValue[2];
        propertyArray[0] = new PropertyValue();
        propertyArray[0].Name = "ReadOnly";
        propertyArray[0].Value = new uno.Any(false);
        propertyArray[1] = new PropertyValue();
        propertyArray[1].Name = "Hidden";
        propertyArray[1].Value = new uno.Any(!visible);


        XComponent xComponent = aLoader.loadComponentFromURL(
            fileName.Equals(string.Empty)
                ? "private:factory/scalc"
                : "file:///" + fileName.Replace("\\", "/"),
            "_blank", 0, propertyArray);

        mxDocument = (XSpreadsheetDocument)xComponent;
    }

    public XSpreadsheet getSheet(int nIndex)
    {
        XSpreadsheets xSheets = mxDocument.getSheets();

        XIndexAccess xSheetsIA = (XIndexAccess)xSheets;

        return (XSpreadsheet)xSheetsIA.getByIndex(nIndex).Value;
    }

    public void setTextValue(int sheetNumber, string cellName, string value)
    {
        XSpreadsheet xSheet = getSheet(sheetNumber - 1);

        XText xText = (XText)xSheet
            .getCellRangeByName(cellName)
            .getCellByPosition(0, 0);

        xText.setString(value);
    }

    public void setTextValue(int nSheet, int nColumn, int nRow, string value)
    {
        XSpreadsheet xSheet = getSheet(nSheet);
        XCell xCell = xSheet.getCellByPosition(nColumn, nRow);
        XText xText = (XText)xCell;
        xText.setString(value);
    }

    public void setTextFormat(int sheetNumber, string cellName)
    {
        XNumberFormatsSupplier xNumberFormatsSupplier = (XNumberFormatsSupplier)mxDocument;
        XNumberFormatTypes xNumberFormatTypes = (XNumberFormatTypes)xNumberFormatsSupplier.getNumberFormats();        
        int format = xNumberFormatTypes.getStandardFormat(NumberFormat.TEXT, new Locale());
        XSpreadsheet xSheet = getSheet(sheetNumber - 1);
        XPropertySet xProp = (XPropertySet)xSheet.getCellRangeByName(cellName);        
        xProp.setPropertyValue("NumberFormat", new uno.Any(format));        
    }

    public void setPicture(int sheetNumber, System.Drawing.Image picture, string leftTopCell, string rightBottomCell, bool autoSize)
    {
        XSpreadsheet sheet = getSheet(sheetNumber - 1);
        string pictureFile = Path.GetTempFileName();
        picture.Save(pictureFile);

        Size imageSize = getImageSize(pictureFile);
        Point imagePosition = getRangePosition(sheet, leftTopCell);
        Size rangeSize = getRangeSize(sheet, $"{leftTopCell}:{rightBottomCell}");
        if (autoSize)
        {
            imageSize = rangeSize;
            if (imageSize.Height / picture.Height > imageSize.Width / picture.Width)
            {
                int height = imageSize.Width * picture.Height / picture.Width;
                imagePosition.Y += (imageSize.Height - height) / 2;
                imageSize.Height = height;
            }
            else
            {
                int width = imageSize.Height * picture.Width / picture.Height;
                imagePosition.X += (imageSize.Width - width) / 2;
                imageSize.Width = width;
            }
            Size cellSize = getRangeSize(sheet, leftTopCell);
            imagePosition.X = imagePosition.X + cellSize.Width / 2;
        }
        else
        {
            imagePosition.X += (rangeSize.Width - imageSize.Width) / 2;
            imagePosition.Y += (rangeSize.Height - imageSize.Height) / 2;
        }

        drawPicture(sheet, pictureFile, imageSize, imagePosition);
    }

    private Size getImageSize(string pictureFile)
    {
        XGraphicProvider graphicProvider = (XGraphicProvider)mxMSFactory.createInstance("com.sun.star.graphic.GraphicProvider");

        PropertyValue[] graphicProperty = new PropertyValue[1];
        graphicProperty[0] = new PropertyValue();
        graphicProperty[0].Name = "URL";
        graphicProperty[0].Value = new uno.Any("file:///" + pictureFile);

        XPropertySet imageProperty = graphicProvider.queryGraphicDescriptor(graphicProperty);

        return (Size)imageProperty.getPropertyValue("Size100thMM").Value;
    }

    private Size getRangeSize(XSpreadsheet sheet, string range)
    {
        return (Size)((XPropertySet)sheet
                .getCellRangeByName(range))
                .getPropertyValue("Size").Value;
    }

    private Point getRangePosition(XSpreadsheet sheet, string range)
    {
        return (Point)((XPropertySet)sheet
                .getCellRangeByName(range))
                .getPropertyValue("Position").Value;
    }

    private void drawPicture(XSpreadsheet sheet, string pictureFile, Size size, Point position)
    {
        XMultiServiceFactory serviceFactory = (XMultiServiceFactory)mxDocument;

        XNameContainer bitmapContainer = (XNameContainer)serviceFactory.createInstance("com.sun.star.drawing.BitmapTable");
        bitmapContainer.insertByName(pictureFile, new uno.Any("file:///" + pictureFile));

        object shape = serviceFactory.createInstance("com.sun.star.drawing.GraphicObjectShape");
        //((XPropertySet)shape).setPropertyValue("GraphicURL", new uno.Any("file:///" + pictureFile));
        ((XPropertySet)shape).setPropertyValue("GraphicURL", bitmapContainer.getByName(pictureFile));
        ((XShape)shape).setSize(size);
        ((XShape)shape).setPosition(position);

        XDrawPageSupplier XDPS = (XDrawPageSupplier)sheet;

        XDPS.getDrawPage().add((XShape)shape);
    }

    public void print(string printerName)
    {
        XPrintable xPrintable = (XPrintable)mxDocument;

        PropertyValue[] printer = new PropertyValue[1];
        printer[0] = new PropertyValue();
        printer[0].Name = "Name";
        printer[0].Value = new uno.Any(printerName);
        xPrintable.setPrinter(printer);

        PropertyValue[] printOptions = new PropertyValue[1];
        printOptions[0] = new PropertyValue();
        printOptions[0].Name = "Wait";
        printOptions[0].Value = new uno.Any(true);

        xPrintable.print(printOptions);
    }

    public string getTextValue(int nSheet, int nColumn, int nRow)
    {
        XSpreadsheet xSheet = getSheet(nSheet);
        XCell xCell = xSheet.getCellByPosition(nColumn, nRow);
        XText xText = (XText)xCell;
        return xText.getString();
    }

    public int findValueInColumn(int nSheet, int nColumn, string value)
    {
        int nRow = 0;
        string cellValue = getTextValue(nSheet, nColumn, nRow);
        while (!cellValue.Equals(value) && !cellValue.Equals(string.Empty))
        {
            cellValue = getTextValue(nSheet, nColumn, nRow++);
        }
        return cellValue.Equals(value) ? --nRow : -1;
    }

    public void copySheet(int sheetNumber = 1)
    {
        XSpreadsheets xSheets = mxDocument.getSheets();
        XSpreadsheet sheet = getSheet(sheetNumber - 1);
        XNamed sheetName = (XNamed)sheet;
        xSheets.copyByName(sheetName.getName(), $"Страница {sheetNumber + 1}", 2);
    }

    public void copyRange(int sheetNumber, string rangeFrom, string rangeTo)
    {
        XSpreadsheet xSheet = getSheet(sheetNumber - 1);
        XCellRangeMovement xCellRangeMovement = (XCellRangeMovement) xSheet;        
        xCellRangeMovement.copyRange(createCellAddress(xSheet, rangeTo), createCellRangeAddress(xSheet, rangeFrom));
    }

    public void copyRow(int sheetNumber, int rowNumber)
    {
        XSpreadsheet xSheet = getSheet(sheetNumber - 1);
        XCellRangeMovement xCellRangeMovement = (XCellRangeMovement)xSheet;
        xCellRangeMovement.insertCells(createCellRangeAddress(xSheet, $"{rowNumber}:{rowNumber}"), CellInsertMode.ROWS);
        copyRange(sheetNumber, $"{rowNumber + 1}:{rowNumber + 1}", $"{rowNumber}:{rowNumber}");
    }
}
