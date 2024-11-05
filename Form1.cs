using System;
using System.Windows.Forms;

namespace PTask3_22
{ // Рассчет, Блокировка, Сохранение/Загрузка, Иконки, Отображение выбранного в статусе
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_B_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.Text = "Добавление нового завода";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MyItem item = new MyItem(
                    dialog.Name_TB.Text,
                    dialog.DirectorSurname_TB.Text,
                    Convert.ToInt32(dialog.ProductsNumber_TB.Text),
                    Convert.ToDouble(dialog.AverageYearIncome_TB.Text)
                );
                Spisok_LB.Items.Add(item);
            }
        }

        private void Change_B_Click(object sender, EventArgs e)
        {
            if (!IsListItemSelected())
                return;

            Form2 dialog = new Form2();
            dialog.Text = "Изменение завода";

            MyItem item = Spisok_LB.SelectedItem as MyItem;
            dialog.Name_TB.Text = item.Name;
            dialog.DirectorSurname_TB.Text = item.DirectorSurname;
            dialog.ProductsNumber_TB.Text = item.ProductsNumber.ToString();
            dialog.AverageYearIncome_TB.Text = item.AverageYearIncome.ToString();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                item.Name = dialog.Name_TB.Text;
                item.DirectorSurname = dialog.DirectorSurname_TB.Text;
                item.ProductsNumber = Convert.ToInt32(dialog.ProductsNumber_TB.Text);
                item.AverageYearIncome = Convert.ToDouble(dialog.AverageYearIncome_TB.Text);
                Spisok_LB.Items[Spisok_LB.SelectedIndex] = item;
            }
        }

        private void Remove_B_Click(object sender, EventArgs e)
        {
            if (!IsListItemSelected())
                return;

            Spisok_LB.Items.RemoveAt(Spisok_LB.SelectedIndex);
        }

        private void Calculate_B_Click(object sender, EventArgs e)
        {

        }

        private void Save_B_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName.ToString());
            }
        }

        private void Load_B_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName.ToString());
            }
        }

        private bool IsListItemSelected()
        {
            if (Spisok_LB.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран элемент в списке");
                return false;
            }
            return true;
        }
    }
}
