using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EnglishGrammar
{
    class QuestionsAnswersTenses : List<ThreeStrings>
    {
        public QuestionsAnswersTenses()
        {

        }

        public void FillDataFromFile(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                string[] sentences = new string[3];
                while ((line = sr.ReadLine()) != null)
                {
                    sentences = line.Split('~');
                    ThreeStrings questionAnswerTense = new ThreeStrings
                    {
                        string1 = sentences[0],
                        string2 = sentences[1],
                        string3 = sentences[2]
                    };
                    this.Add(questionAnswerTense);
                }
            }

        }

        public ThreeStrings GetRandomTask()
        {
            Random random = new Random();
            int randNum = random.Next(this.Count);
            return this[randNum];
        }

    }
}
