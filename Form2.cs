using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Генератор_комплиментов
{
    public partial class Form2 : Form
    {
        string[] part1 = { "Ты", "Ты сегодня", "Ты действительно", "Ты взаправду" };
        string[] part2 = { "выглядишь", "сияешь", "смотришься", "точь в точь" };
        string[] part3 = {
        "как солнышко! ☀️",
        "как чудо! ✨",
        "просто великолепно!",
        "как мечта! 💫",
        "невероятно красиво! 💖",
        "словно цветок 🌸"
    };
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            string c1 = part1[rnd.Next(part1.Length)];
            string c2 = part2[rnd.Next(part2.Length)];
            string c3 = part3[rnd.Next(part3.Length)];

            label1.Text = $"{c1} {c2} {c3}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
