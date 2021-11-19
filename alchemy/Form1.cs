using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alchemy
{
    public partial class Form1 : Form
    {
        string answer = "";
        List<string> rules = new List<string>();
        List<string> facts = new List<string>();
        List<string> solution = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheckSolution_Click(object sender, EventArgs e)
        {
            facts.Clear();
            rules.Clear();
            solution.Clear();
            answer = comboBoxOutput.SelectedItem.ToString();
            foreach (var f in checkedListBoxFacts.CheckedItems)
            {
                facts.Add(f.ToString());
            }

            textBoxSolution.Text = "Ингредиенты: ";
            foreach (var f in facts)
                textBoxSolution.Text += f + " ";
            textBoxSolution.Text += " Желаемый результат: " + answer;

            checkSolvability();

            textBoxSolution.Text += Environment.NewLine;
            //foreach (var r in rules)
            //    textBoxSolution.Text += Environment.NewLine + r;

            if (solution.Count() != 0)
            {
                textBoxSolution.Text += "Найдены возможные решения: " + Environment.NewLine;
                foreach (string s in solution)
                    textBoxSolution.Text += s + Environment.NewLine;
            }
            else
                textBoxSolution.Text += "Не найдены возможные решения";

            answer = "";
        }

        private void comboBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonCheckSolution.Enabled = true;

            foreach (var f in checkedListBoxFacts.CheckedItems)
            {
                facts.Add(f.ToString());
            }

            answer = comboBoxOutput.SelectedItem.ToString();
        }

        private void checkedListBoxFacts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Проверяет можно ли из данных фактов вывести желаемый рузальтат. Если да - какими продукциями (прямой вывод)
        void checkSolvability()
        {
            for(int i = 0; i < facts.Count(); i++)
            {
                facts[i] = facts[i].Split(';')[0]; // теперь список фактов - список номеров фактов
            }

            using (StreamReader sr = new StreamReader("../../facts.txt", System.Text.Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(';');
                    if (answer.Equals(splitLine[1]))
                    {
                        answer = splitLine[0]; // теперь ответ - номер факта
                        break;
                    }                       
                }
            }

            using (StreamReader sr = new StreamReader("../../rules.txt", System.Text.Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] splitLine = line.Split()[0].Split(';');
                    if (answer.Equals(splitLine[splitLine.Count()-2]))
                        rules.Add(line); // добавляем полностью строку вывода с описанием
                }
            }

            foreach(string r in rules)
            {
                int count = 0;
                string[] splitRule = r.Split()[0].Split(';');
                foreach (string factInRule in splitRule[1].Split(','))
                    foreach (string fact in facts)
                        if (factInRule.Equals(fact))
                            count++;
                if (count == 2)
                    solution.Add(r);
            }
        }

        // Находит способы вывести желаемый результат (обратный вывод)
        void findSolution()
        {

        }
    }
}
