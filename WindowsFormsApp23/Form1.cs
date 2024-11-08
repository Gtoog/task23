using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApp23
{
    public partial class Form1 : Form
    {
        // Инициализация формы
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик нажатия кнопки генерации числа
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                // Чтение минимального и максимального значений из текстовых полей
                int minValue = int.Parse(txtMinValue.Text);
                int maxValue = int.Parse(txtMaxValue.Text);

                // Проверка на корректность диапазона
                if (minValue > maxValue)
                {
                    MessageBox.Show("Минимальное значение не может быть больше максимального.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Генерация случайного числа
                Random random = new Random();
                int randomNumber = random.Next(minValue, maxValue + 1);

                // Отображение результата
                lblResult.Text = "Результат: " + randomNumber;
            }
            catch (FormatException)
            {
                // Обработка ошибки в случае некорректного ввода
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
