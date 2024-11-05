using System;
using System.Windows.Forms;

namespace PTask3_22
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (string.IsNullOrEmpty(Name_TB.Text.Trim()))
                    {
                        Name_TB.Focus();
                        throw new Exception(
                        "Введите наименование завода! Строка не должна быть пустой.");
                    }

                    if (string.IsNullOrEmpty(DirectorSurname_TB.Text.Trim()))
                    {
                        DirectorSurname_TB.Focus();
                        throw new Exception(
                        "Введите фамилию директора! Строка не должна быть пустой.");
                    }

                    if (string.IsNullOrEmpty(ProductsNumber_TB.Text))
                    {
                        ProductsNumber_TB.Focus();
                        throw new Exception(
                        "Введите кол-во видов выпоскаемых товаров! Строка не должна быть пустой.");
                    }
                    int productsNumber = 0;
                    try
                    {
                        productsNumber = Convert.ToInt32(ProductsNumber_TB.Text.Trim());
                    }
                    catch (FormatException)
                    {
                        ProductsNumber_TB.Focus();
                        throw new Exception(
                        "Кол-во видов выпоскаемых товаров должно быть целым числом!");
                    }
                    if (1 > productsNumber || productsNumber > 1000)
                    {
                        ProductsNumber_TB.Focus();
                        throw new Exception(
                        "Кол-во видов выпоскаемых товаров не может быть:\n" +
                        "- меньше 1;\n" +
                        "- больше 1000");
                    }

                    if (string.IsNullOrEmpty(AverageYearIncome_TB.Text))
                    {
                        AverageYearIncome_TB.Focus();
                        throw new Exception(
                        "Введите средний годовой доход! Строка не должна быть пустой.");
                    }
                    double averageYearIncome = 0;
                    try
                    {
                        averageYearIncome = Convert.ToDouble(AverageYearIncome_TB.Text.Trim());
                    }
                    catch (FormatException)
                    {
                        AverageYearIncome_TB.Focus();
                        throw new Exception(
                        "Средний годовой доход должно быть вещественным числом!");
                    }
                    if (.1f > averageYearIncome || averageYearIncome > 1000)
                    {
                        AverageYearIncome_TB.Focus();
                        throw new Exception(
                        "Средний годовой доход не может быть:\n" +
                        "- меньше 0.1 млн. руб.\n" +
                        "- больше 1000 млн. руб.");
                    }
                }
                catch (Exception E)
                {
                    e.Cancel = true;
                    MessageBox.Show(E.Message);
                }
            }
        }
    }
}
