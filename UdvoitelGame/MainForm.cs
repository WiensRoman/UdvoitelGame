using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdvoitelGame
{
    public partial class MainForm : Form
    {
        private int _counter;
        private int _commandsCounter;
        private int _victoryNumber;
        public MainForm()
        {
            InitializeComponent();
            newVictoryNumber(); // Получение рандомного победного числа
            MessageBox.Show("Победное число: " + _victoryNumber);
            _counter = 1; // Изначальное значение текущего числа
            _commandsCounter = 0; // Количество ходов
            SetNumber();
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            _counter++;
            _commandsCounter++;
            SetNumber();
        }

        private void SetNumber()
        {
            lblNumber.Text = _counter.ToString();
            CommandsCounter.Text = _commandsCounter.ToString();
            VictoryNumberLabel.Text = _victoryNumber.ToString();
            if (_counter == _victoryNumber)// Проверка соответствия полученого числа с победным числом
            {
                MessageBox.Show("Поздравляем,вы победили!" + " Количество ходов: " + _commandsCounter);
                this.Close();
            }
        }

        private void btnMultiply2_Click(object sender, EventArgs e)
        {
            _counter *= 2;
            _commandsCounter++;
            SetNumber();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _counter = 1;
            _commandsCounter++;
            SetNumber();
        }

        private void btnShowForm_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newVictoryNumber()
        {
            Random rnd = new Random();
            _victoryNumber = rnd.Next(1, 100);
        }
    }
}
