using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace EnglishGrammar
{
    class QuestionsAnswers : List<TwoStrings>
    {
        public QuestionsAnswers()
        {

        }

        public void FillDataFromFile(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                string[] sentences = new string[2];
                while ((line = sr.ReadLine()) != null)
                {
                    sentences = line.Split('~');
                    TwoStrings questionAnswerTense = new TwoStrings
                    {
                        string1 = sentences[0],
                        string2 = sentences[1]
                    };
                    this.Add(questionAnswerTense);
                }
            }

        }

        public TwoStrings GetRandomTask()
        {
            Random random = new Random();
            int randNum = random.Next(this.Count);
            return this[randNum];
        }
    }
}
