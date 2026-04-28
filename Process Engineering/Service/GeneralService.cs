using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Process_Engineering.Service
{
    internal class GeneralService
    {
        public static void FilterComboBoxItems(ComboBox comboBox, IList list)
        {
            comboBox.DroppedDown = false;            
            RemoveUnusedItems(comboBox, list);
            int indexToInsert = 0;
            foreach (var item in list)
            {
                if (comboBox.SelectedIndex == -1 && !item.ToString().ToLower().Contains(comboBox.Text.ToLower()))
                {
                    comboBox.Items.Remove(item);
                }
                else
                {
                    indexToInsert = InsertNewItem(comboBox, item, indexToInsert);
                }
            }
            comboBox.DroppedDown = comboBox.SelectedIndex == -1 && !comboBox.Text.Equals(string.Empty);
            Cursor.Current = Cursors.Default;
        }

        public static void UpdateComboBoxItems(ComboBox comboBox, IList list)
        {            
            RemoveUnusedItems(comboBox, list);
            int indexToInsert = 0;
            foreach (var item in list)
            {
                indexToInsert = InsertNewItem(comboBox, item, indexToInsert);
            }
        }

        public static void RemoveUnusedItems(ComboBox comboBox, IList list)
        {
            List<object> itemsToRemove = new List<object>();
            foreach (var item in comboBox.Items)
            {
                if (!list.Contains(item))
                {
                    itemsToRemove.Add(item);
                }
            }
            itemsToRemove.ForEach(i => comboBox.Items.Remove(i));
        }

        public static int InsertNewItem(ComboBox comboBox, object item, int indexToInsert)
        {
            if (!comboBox.Items.Contains(item))
            {
                comboBox.Items.Insert(indexToInsert++, item);
            }
            else
            {
                indexToInsert = comboBox.Items.IndexOf(item) + 1;
            }
            return indexToInsert;
        }

        public static void FilterDigitKeyPress(TextBox textBox, KeyPressEventArgs e, bool isInt)
        {
            char decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            if (!isInt && (e.KeyChar == '.' || e.KeyChar == ','))
            {
                e.KeyChar = decimalSeparator;
                e.Handled = textBox.Text.IndexOf(decimalSeparator) > -1;
                return;
            }
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        public static bool AreDatesEqual(DateTime date1, DateTime date2)
        {
            return date1.Year == date2.Year && date1.Month == date2.Month && date1.Day == date2.Day;
        }

        public static string GetCardDesignation<T>(T card)
        {
            string cardType = (string)typeof(T).GetProperty("cardType").GetValue(card);
            string project = (string)typeof(T).GetProperty("project").GetValue(card);
            int number = (int)typeof(T).GetProperty("number").GetValue(card);

            return number == 0 ? ConstStorage.CARD_IS_NOT_SET : $"{cardType}*{project}{number:000000}";
        }

    }
}
