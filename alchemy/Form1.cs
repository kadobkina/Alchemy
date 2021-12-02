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
        bool finded = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheckSolution_Click(object sender, EventArgs e)
        {
            finded = true;
            facts.Clear();
            rules.Clear();
            solution.Clear();
            textBoxSolution.Text = "";
            answer = comboBoxOutput.SelectedItem.ToString();

            foreach (var f in checkedListBoxFacts.CheckedItems)
            {
                facts.Add(f.ToString());
            }

            textBoxSolution.Text = "Ингредиенты: ";
            foreach (var f in facts)
                textBoxSolution.Text += f.Split(';')[1] + " ";
            textBoxSolution.Text += Environment.NewLine + "Желаемый результат: " + answer;

            checkSolvability();

            textBoxSolution.Text += Environment.NewLine;
            //foreach (var r in rules)
            //    textBoxSolution.Text += Environment.NewLine + r;

            if (solution.Count() != 0)
            {
                solution = solution.Distinct().ToList();
                textBoxSolution.Text += Environment.NewLine + "Можно получить: " + Environment.NewLine;
                foreach (string s in solution)
                    textBoxSolution.Text += s + Environment.NewLine;

                if (finded)
                    textBoxSolution.Text += Environment.NewLine + "Получен желаемый результат!" + Environment.NewLine;
                else
                    textBoxSolution.Text += Environment.NewLine + "Не найдено способов получения желаемого результата" + Environment.NewLine;
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

        // Проверяет можно ли из данных фактов вывести желаемый рузальтат. Если да - какими продукциями (прямой вывод)
        void checkSolvability()
        {
            for (int i = 0; i < facts.Count(); i++)
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

            Dictionary<string, string> allRules = new Dictionary<string, string>();
            using (StreamReader sr = new StreamReader("../../rules.txt", System.Text.Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // string[] tempLine = line.Split()[0].Split(';');
                    string[] tempLine = line.Split();

                    string ruleID = tempLine[0].Split(';')[0];
                    // все правила из файла
                    allRules[ruleID] = line.Substring(ruleID.Length+1);
                }
            }

            int factsCount = 0;

search:
            foreach (string r in allRules.Values)
            {
                factsCount = facts.Count();
                int count = 0;
                string[] splitRule = r.Split()[0].Split(';');
                foreach (string factInRule in splitRule[0].Split(','))
                {
                    foreach (string fact in facts)
                        if (factInRule.Equals(fact))
                            count++;
                }

                if (count == 2)
                {
                    facts.Add(splitRule[1]);
                    solution.Add(r);
                }
                facts = facts.Distinct().ToList();

                if (facts.Contains(answer))
                    break;

            }
            // if (!facts.Contains(answer))
            // {
            if (factsCount == facts.Count())
            {
                if (!facts.Contains(answer))
                    finded = false;
            }
            else
                goto search;
            // }


            /*  foreach (string r in rules)
              {
                  int count = 0;
                  string[] splitRule = r.Split()[0].Split(';');
                  foreach (string factInRule in splitRule[1].Split(','))
                  {
                      foreach (string fact in facts)
                          if (factInRule.Equals(fact))
                              count++;
                  }
                  if (count == 2)
                      solution.Add(r);
              }
            */
            //List<string> tempRules = rules;
            /*  List<string> tempFacts = facts;
              int countList = 0;
              while (true)
              {
                  List<string> temp = new List<string>();
                  using (StreamReader sr = new StreamReader("../../rules.txt", System.Text.Encoding.UTF8))
                  {
                      string rule;
                      while ((rule = sr.ReadLine()) != null)
                      {
                          int count = 0;
                          string[] splitRule = rule.Split()[0].Split(';');
                          foreach (string factInRule in splitRule[1].Split(','))
                          {
                              foreach (string fact in tempFacts)
                                  if (factInRule.Equals(fact))
                                      count++;
                          }
                          if (count == 2)
                              temp.Add(rule);
                      }
                  }

                  if (temp.Count() != 0)
                  {
                      foreach(string t in temp)
                      {
                          var tt = t.Split()[0];
                          tempFacts.Add(tt.Split(';')[tt.Count() - 2]);
                      }
                  }

                  tempFacts = tempFacts.Distinct().ToList();

                  if (countList == tempFacts.Count())
                      break;

                  countList = tempFacts.Count();
              }
            */
        }



        /*   void checkSolvability()
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
                   {
                       foreach (string fact in facts)
                           if (factInRule.Equals(fact))
                               count++;
                   }
                   if (count == 2)
                       solution.Add(r);
               }
           }*/

        // Находит способы вывести желаемый результат (обратный вывод)
        void findSolution()
        {

        }
    }
}
