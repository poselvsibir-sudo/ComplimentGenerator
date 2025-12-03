using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Генератор_комплиментов
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            // обработчик закрытия крестиком
            this.FormClosing += Form3_FormClosing;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            // для закрытия крестиком
            Application.Exit();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // кнопка Выйти
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // данные
            string[] part1 = { "Ты", "Ты сегодня", "Ты действительно", "Ты взаправду" };
            string[] part2 = { "выглядишь", "сияешь", "смотришься", "точь в точь" };
            string[] part3 = {
                "как солнышко! ☀️",
                "как чудо! ✨",
                "просто великолепно! 💫",
                "как мечта! 💫",
                "невероятно красиво! 💖",
                "словно цветок! 🌸"
            };

            comboBox1.Items.AddRange(part1);
            comboBox2.Items.AddRange(part2);
            comboBox3.Items.AddRange(part3);

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            string p1 = comboBox1.SelectedItem.ToString();
            string p2 = comboBox2.SelectedItem.ToString();
            string p3 = comboBox3.SelectedItem.ToString();

            labelResult.Text = $"{p1} {p2} {p3}";
        }
    }
}