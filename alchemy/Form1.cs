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
        //List<Tuple<string, int>> ssolution = new List<Tuple<string, int>>();
        List<string> ssolution = new List<string>();
        bool finded = true;
        BinaryTree<string> bst = new BinaryTree<string>();
        Dictionary<string, string> allFacts = new Dictionary<string, string>();

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
            ssolution.Clear();
            allFacts.Clear();
            textBoxSolution.Text = "";
            answer = comboBoxOutput.SelectedItem.ToString();

            // прямой вывод
            if (checkedListBoxFacts.CheckedItems.Count != 0)
            {
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
            }

            answer = "";
        }

        private void buttonBackward_Click(object sender, EventArgs e)
        {
            finded = true;
            facts.Clear();
            rules.Clear();
            solution.Clear();
            ssolution.Clear();
            allFacts.Clear();
            textBoxSolution.Text = "";
            answer = comboBoxOutput.SelectedItem.ToString();

            // прямой вывод
            if (checkedListBoxFacts.CheckedItems.Count != 0)
            {
                foreach (var f in checkedListBoxFacts.CheckedItems)
                {
                    facts.Add(f.ToString());
                }

                textBoxSolution.Text = "Ингредиенты: ";
                foreach (var f in facts)
                    textBoxSolution.Text += f.Split(';')[1] + " ";
                textBoxSolution.Text += Environment.NewLine + "Желаемый результат: " + answer;

                //textBoxSolution.Text += "Желаемый результат: " + answer + Environment.NewLine + "Способ получения:" + Environment.NewLine;
                findSolution();
                //string res = "";
                //bst.PrintTree(ref res);
                textBoxSolution.Text += Environment.NewLine + "Способ получения: " + Environment.NewLine;
                //textBoxSolution.Text += Environment.NewLine + res;
                /*    var l = ssolution.FindAll(x => x.Item2 == true);
                    List<int> indxs = new List<int>();
                    foreach (var el in l)
                        indxs.Add(ssolution.FindIndex(x => x == el));
                    for (int i = 0; i < ssolution.Count-1; i++)
                    {
                        if (indxs.Contains(i))
                            textBoxSolution.Text += Environment.NewLine;
                        textBoxSolution.Text += Environment.NewLine + allFacts[ssolution[i].Item1];
                    }
                */

                /*                Dictionary<int, int> checkPrint = new Dictionary<int, int>();
                                checkPrint[0] = 1;
                                for (int i = 0; i < ssolution.Count - 1; i++)
                                {
                                    if (!checkPrint.ContainsKey(ssolution[i].Item2))
                                    {
                                        checkPrint[ssolution[i].Item2] = 1;
                                        textBoxSolution.Text += Environment.NewLine + allFacts[ssolution[i].Item1];
                                    }
                                    else if (checkPrint[ssolution[i].Item2] < 2)
                                    {
                                        checkPrint[ssolution[i].Item2]++;
                                        textBoxSolution.Text += Environment.NewLine + allFacts[ssolution[i].Item1];
                                    }
                                    else
                                    {
                                        textBoxSolution.Text += Environment.NewLine;
                                    }

                                }*/

                /*  for (int i = 0; i < ssolution.Count - 1; i++)
                  {
                      textBoxSolution.Text += Environment.NewLine;
                      for (int j = 0; j < ssolution[i].Item2; j++)
                          textBoxSolution.Text += "  ";
                      textBoxSolution.Text += ssolution[i].Item2 + " ";
                      textBoxSolution.Text += allFacts[ssolution[i].Item1];
                  }*/
                foreach (var s in ssolution)
                    textBoxSolution.Text += s + Environment.NewLine;

            }
            else
            {
                textBoxSolution.Text += "Нет фактов!";
            }
            answer = "";

        }


        private void comboBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonCheckSolution.Enabled = true;
            buttonBackward.Enabled = true;
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
                    allRules[ruleID] = line.Substring(ruleID.Length + 1);
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
                    string factID = tempLine[0].Split(';')[2];
                    // все правила из файла
                    allRules[ruleID] = line.Substring(ruleID.Length + 1);
                }
            }

            using (StreamReader sr = new StreamReader("../../facts.txt", System.Text.Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(';');
                    allFacts[splitLine[0]] = splitLine[1];
                }
            }

            string fact = answer;
            Stack<Tuple<string, int>> stack = new Stack<Tuple<string, int>>();
            stack.Push(Tuple.Create(fact, 0));
            //bst.Add(fact);
            Queue<string> queue = new Queue<string>();
            //solution.Add(fact);
            //queue.Enqueue(fact);
            int check = 1;
            List<string> tempSolution = new List<string>();

        searchh:           //string[] factsInRule;
            foreach (var rule in allRules)
            {
                var splitRule = rule.Value.Split(';');
                if (splitRule[1] == fact)
                {
                    //bst.FindNode(fact).LeftNode.Data = splitRule[0].Split(',')[0];
                    //bst.FindNode(fact).RightNode.Data = splitRule[0].Split(',')[1];
                    //queue.Enqueue(splitRule[0].Split(',')[0]);
                    //queue.Enqueue(splitRule[0].Split(',')[1]);
                    // if (check == 1)
                    // {
                    stack.Push(Tuple.Create(splitRule[0].Split(',')[0], check));
                    stack.Push(Tuple.Create(splitRule[0].Split(',')[1], check));
                    //  }
                    // else
                    // {
                    //     stack.Push(Tuple.Create(splitRule[0].Split(',')[0], false));
                    //     stack.Push(Tuple.Create(splitRule[0].Split(',')[1], false));
                    // }
                    check++;
                    break;
                }
            }
            //fact = queue.Dequeue();
            //fact = stack.Pop();
            /*            if (bst.FindNode(fact).LeftNode == null)
                        {
                            fact = stack.Pop();
                            bst.FindNode(fact).LeftNode = new Node<string>(fact);
                        }
                        else
                        {
                            fact = stack.Pop();
                            bst.FindNode(fact).RightNode = new Node<string>(fact);
                        }*/
            Tuple<string, int> t = null;
            if (stack.Count() != 0)
            {
                t = stack.Pop();
                fact = t.Item1;
            }
            while (facts.Contains(t.Item1))
            {
                tempSolution.Add(t.Item1);
                if (stack.Count() != 0)
                    t = stack.Pop();
                else
                    break;
            }
            fact = t.Item1;
            if (stack.Count() != 0)
                goto searchh;

            //fact = stack.Pop();
            //bst.Add(fact);
            /* if (fact == "f-1" || fact == "f-2" || fact == "f-3" || fact == "f-4")
             {
                 fact = stack.Pop();
                 bst.Add(fact);
             }*/
            /*    if (stack.Count() == 1 && (fact == "f-1" || fact == "f-2" || fact == "f-3" || fact == "f-4"))
                {
                    var t = stack.Pop();
                    //bst.Add(fact);
                    ssolution.Add(t);
                    fact = t.Item1;
                }
                else if (stack.Count() > 1)
                    goto searchh;
                if (stack.Count() == 1 && !(fact == "f-1" || fact == "f-2" || fact == "f-3" || fact == "f-4"))
                    goto searchh;*/
            //  while(true)
            //  {
            //
            //  }


            foreach (var rule in allRules)
            {
                int tempCount = 0;
                // if (Int32.Parse(rule.Value.Split(';')[1].Split('-')[1]) > Int32.Parse(answer.Split('-')[1]))
                //   break;
                var temp = rule.Value.Split(';')[0].Split(',');
                foreach (var f in temp)
                    if (tempSolution.Contains(f))
                        tempCount++;
                if (/*tempSolution.Contains(rule.Value.Split(';')[1]) ||*/ tempCount == 2)
                    ssolution.Add(rule.Value);
                if (Int32.Parse(rule.Value.Split(';')[1].Split('-')[1]) == Int32.Parse(answer.Split('-')[1]))
                    ssolution.Add(rule.Value);
            }

            ssolution = ssolution.Distinct().ToList();

            /*   foreach (var r in tempSolution)
                   if (!facts.Contains(r))
                       ssolution.Add(allRules[r]);
               ssolution.Add(allRules[answer]);
               ssolution.Distinct().ToList();*/

        }

    }
}
