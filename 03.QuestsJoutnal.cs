using System;
using System.Collections.Generic;
using System.Linq;

namespace QuestsJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> quest = Console.ReadLine()
                .Split(", ")
                .ToList(); // ", "

            string command;

            while ((command = Console.ReadLine()) != "Retire!")
            {
                string[] array = command
                    .Split(" - ")
                    .ToArray(); //" - "

                if (array[0] == "Start")
                {
                    if (!quest.Contains(array[1]))
                    {
                        quest.Add(array[1]);
                    }
                }

                if (array[0] == "Complete")
                {
                    if (quest.Contains(array[1]))
                    {
                        quest.Remove(array[1]);
                    }
                }

                if (array[0] == "Side Quest")
                {
                    string[] tempQuest = array[1]
                        .Split(':')
                        .ToArray(); //If else:Switch

                    int index = 0;

                    if (quest.Contains(tempQuest[0]))
                    {
                        if (quest.Contains(tempQuest[1]) == false)
                        {
                            for (int i = 0; i < quest.Count; i++)
                            {
                                if (quest[i] == tempQuest[0])
                                {
                                    index = i + 1;
                                }
                            }

                            quest.Insert(index, tempQuest[1]);
                        }

                    }
                }

                if (array[0] == "Renew")
                {
                    if (quest.Contains(array[1]))
                    {
                        int remove = quest.IndexOf(array[1]);
                        quest.RemoveAt(remove);
                        quest.Add(array[1]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", quest));
        }
    }
}