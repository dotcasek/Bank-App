using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBucksBank
{
    public static class Validator
    {
        private static string title = "Entry Error";

        public static string Title { get { return title; } set { value = title; } }

        // checks if a number is positive
        public static bool IsPositive(TextBox textBox)
        {
            decimal number = 0m;
            Decimal.TryParse(textBox.Text, out number);

            if (number >= 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be positive.", Title);
                textBox.Focus();
                return false;
            }
        }

        // check if a combobox entry is selected
        public static bool isSelected(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex >= 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show(comboBox.Tag + " is a required field.", Title);
                comboBox.Focus();
                return false;
            }
        }

        // checks is a textbox is empty
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;

        }

        // checks if a textbox contains a decimal with no more than 2 decimal places
        public static bool IsMoneyDecimal(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                if (textBox.Text.Contains('.') && textBox.Text.Split('.')[1].Length > 2)
                {
                    MessageBox.Show(textBox.Tag + " is an invalid amount.", Title);
                    textBox.Focus();
                    return false;
                }
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
                textBox.Focus();
                return false;
            }
        }

        // checks if a textbox contains an integer
        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an Integer.", Title);
                textBox.Focus();
                return false;
            }
        }

        // checks if a textbox contains a string of the correct length
        public static bool IsCorrectLength(TextBox textBox, int length)
        {
            if (textBox.Text.Length != length)
            {
                MessageBox.Show(textBox.Tag + " must be " + length + " digits.", Title);
                textBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool StartsWithLetter(TextBox textBox)
        {
            if (!Char.IsLetter(textBox.Text[0]))
            {
                MessageBox.Show(textBox.Text + " is an invalid name", Title);
                textBox.Focus();
                return false;

            }
        return true;

        }
    }
}
