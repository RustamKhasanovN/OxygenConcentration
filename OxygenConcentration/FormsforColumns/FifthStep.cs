﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OxygenConcentration.FormsforColumns
{
    public partial class FifthStep : Form
    {
        public FifthStep()
        {
            InitializeComponent();
            // Инициализируем TextBox значением TrackBar
            textBoxDays.Text = trackBarDaysVR.Value.ToString();
            textBoxDayct.Text = trackBarDaysCT.Value.ToString();
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            try
            {

                double a;  //textBoxBeginC
                double b;  //textBoxdCkonec
                double t;  //textBoxDays


                a = Convert.ToDouble(textBoxBeginC.Text);
                b = Convert.ToDouble(textBoxdCkonec.Text);
                t = Convert.ToDouble(textBoxDays.Text);

                double f = (a - b) / 6;  //Концентрация за сутки
                textBoxdCzasutki.Text = Convert.ToString(f);

                double g = a - f * t;   //Текущая концентрация
                textBoxInTime.Text = Convert.ToString(g);



            }
            catch (FormatException)

            {
                MessageBox.Show("Поля не заполнены или заполнены неправильно");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxdCzasutki.Text = "";
            textBoxInTime.Text = "";
            chartvr.Series["ΔCвр"].Points.Clear();
        }

        private void buttondrawgraph_Click(object sender, EventArgs e)
        {
            // Получаем значения a и f из TextBox
            if (double.TryParse(textBoxBeginC.Text, out double a) &&
                double.TryParse(textBoxdCzasutki.Text, out double f) &&
                int.TryParse(textBoxDays.Text, out int days) && days > 0)
            {
                DrawGraph(a, f, days);
            }
            else
            {
                MessageBox.Show("Введите корректные значения для Начальная концентрация, Концентрация за сутки и количество дней.");
            }
        }

        private void DrawGraph(double a, double f, int days)
        {
            // Очищаем предыдущие данные
            chartvr.Series["ΔCвр"].Points.Clear();

            // Строим график для x от 1 до days
            for (double x = 1; x <= days; x += 1)
            {
                double y = a - f * x;
                chartvr.Series["ΔCвр"].Points.AddXY(x, y);
            }

            // Настройка осей
            var chartArea = chartvr.ChartAreas[0];

            // Устанавливаем минимальные и максимальные значения для осей
            chartArea.AxisX.Minimum = 0; // Начало по оси X
            chartArea.AxisX.Maximum = days; // Максимум по оси X
            chartArea.AxisY.Minimum = Math.Min(a - f * days, a); // Минимум по оси Y
            chartArea.AxisY.Maximum = Math.Max(a, a - f); // Максимум по оси Y
            // Центрируем график
            chartArea.Position.Auto = false;
            chartArea.Position.X = 10; // Отступ от левого края
            chartArea.Position.Y = 10; // Отступ от верхнего края
            chartArea.Position.Width = 80; // Ширина области графика (в процентах)
            chartArea.Position.Height = 80; // Высота области графика (в процентах)
            chartvr.ChartAreas[0].AxisX.Title = "День цикла";
            chartvr.ChartAreas[0].AxisY.Title = "Концентрация";
            chartvr.Invalidate(); // Обновляем график

            // Создаем серию данных
            Series series = new Series
            {
                ChartType = SeriesChartType.Line,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 10
            };

            foreach (var point in series.Points)
            {
                point.ToolTip = $"X: {point.XValue}, Y: {point.YValues[0]:F2}"; // Ограничиваем до 2 знаков после запятой
            }
        }

        private void textBoxDays_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, является ли вводимое значение числом
            if (int.TryParse(textBoxDays.Text, out int value))
            {
                // Устанавливаем значение TrackBar, если оно в пределах допустимого диапазона
                if (value >= trackBarDaysVR.Minimum && value <= trackBarDaysVR.Maximum)
                {
                    trackBarDaysVR.Value = value;
                }
                else
                {
                    // Если значение вне диапазона, можно вернуть его к предыдущему значению TrackBar
                    textBoxDays.Text = trackBarDaysVR.Value.ToString();
                }
            }
            else
            {
                // Если введено не число, можно очистить TextBox или вернуть к предыдущему значению
                textBoxDays.Text = trackBarDaysVR.Value.ToString();
            }
        }

        private void trackBarDaysVR_Scroll(object sender, EventArgs e)
        {
            textBoxDays.Text = trackBarDaysVR.Value.ToString();   // Обновляем TextBox при изменении TrackBar
        }

        private void textBoxdCzasutki_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxdCzasutki.Text, out decimal value))
            {
                // Ограничиваем до 4 знаков после запятой
                textBoxdCzasutki.Text = Math.Round(value, 4).ToString("F4");
                textBoxdCzasutki.SelectionStart = textBoxdCzasutki.Text.Length; // Устанавливаем курсор в конец текста
            }
        }

        private void textBoxInTime_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxInTime.Text, out decimal value))
            {
                // Ограничиваем до 4 знаков после запятой
                textBoxInTime.Text = Math.Round(value, 4).ToString("F4");
                textBoxInTime.SelectionStart = textBoxInTime.Text.Length; // Устанавливаем курсор в конец текста
            }
        }



        //Далее Куб+Тор


        private void buttonCalculatect_Click(object sender, EventArgs e)
        {
            try
            {

                double a;  //textBoxBeginC
                double b;  //textBoxdCkonec
                double t;  //textBoxDays


                a = Convert.ToDouble(textBoxBeginCct.Text);
                b = Convert.ToDouble(textBoxKonecCct.Text);
                t = Convert.ToDouble(textBoxDayct.Text);

                double f = (a - b) / 6;  //Концентрация за сутки
                textBoxCzasytkict.Text = Convert.ToString(f);

                double g = a - f * t;   //Текущая концентрация
                textBoxIntimect.Text = Convert.ToString(g);



            }
            catch (FormatException)

            {
                MessageBox.Show("Поля не заполнены или заполнены неправильно");
            }
        }

        private void buttonClearct_Click(object sender, EventArgs e)
        {
            textBoxCzasytkict.Text = "";
            textBoxIntimect.Text = "";
            chartct.Series["ΔC"].Points.Clear();
        }

        private void buttonDrawct_Click(object sender, EventArgs e)
        {
            // Получаем значения a, f и x из TextBox
            if (double.TryParse(textBoxBeginCct.Text, out double a) &&
                double.TryParse(textBoxCzasytkict.Text, out double f) &&
                double.TryParse(textBoxDayct.Text, out double d))
            {
                DrawGraphCT(a, f, d);
            }
            else
            {
                MessageBox.Show("Введите корректные значения для Начальная концентрация, Концентрация за сутки и День цикла.");
            }
        }

        private void DrawGraphCT(double a, double f, double d)
        {
            // Очищаем предыдущие данные
            chartct.Series["ΔC"].Points.Clear();

            // Строим график для x от 1 до d
            for (double x = 1; x <= d; x += 1)
            {
                double y = a - f * x;
                chartct.Series["ΔC"].Points.AddXY(x, y);
            }

            // Добавляем точку для значения d
            double yValueAtX = a - f * d;
            chartct.Series["ΔC"].Points.AddXY(d, yValueAtX);

            // Настройка осей

            chartct.ChartAreas[0].AxisX.Title = "День цикла";
            chartct.ChartAreas[0].AxisY.Title = "Концентрация";
            chartct.Invalidate(); // Обновляем график

            // Создаем серию данных
            Series series = new Series
            {
                ChartType = SeriesChartType.Line,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 10
            };

            foreach (var point in series.Points)
            {
                point.ToolTip = $"X: {point.XValue}, Y: {point.YValues[0]:F2}"; // Ограничиваем до 2 знаков после запятой
            }
        }


        private void textBoxDayct_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, является ли вводимое значение числом
            if (int.TryParse(textBoxDayct.Text, out int value))
            {
                // Устанавливаем значение TrackBar, если оно в пределах допустимого диапазона
                if (value >= trackBarDaysCT.Minimum && value <= trackBarDaysCT.Maximum)
                {
                    trackBarDaysCT.Value = value;
                }
                else
                {
                    // Если значение вне диапазона, можно вернуть его к предыдущему значению TrackBar
                    textBoxDayct.Text = trackBarDaysCT.Value.ToString();
                }
            }
            else
            {
                // Если введено не число, можно очистить TextBox или вернуть к предыдущему значению
                textBoxDayct.Text = trackBarDaysCT.Value.ToString();
            }
        }

        private void trackBarDaysCT_Scroll(object sender, EventArgs e)
        {
            textBoxDayct.Text = trackBarDaysCT.Value.ToString();   // Обновляем TextBox при изменении TrackBar
        }

        private void textBoxCzasytkict_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxCzasytkict.Text, out decimal value))
            {
                // Ограничиваем до 4 знаков после запятой
                textBoxCzasytkict.Text = Math.Round(value, 4).ToString("F4");
                textBoxCzasytkict.SelectionStart = textBoxCzasytkict.Text.Length; // Устанавливаем курсор в конец текста
            }
        }

        private void textBoxIntimect_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxIntimect.Text, out decimal value))
            {
                // Ограничиваем до 4 знаков после запятой
                textBoxIntimect.Text = Math.Round(value, 4).ToString("F4");
                textBoxIntimect.SelectionStart = textBoxIntimect.Text.Length; // Устанавливаем курсор в конец текста
            }
        }
    }
}
