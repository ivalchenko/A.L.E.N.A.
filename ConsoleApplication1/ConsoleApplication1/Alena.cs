using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Alena
    {
        private List<string> PopularQuery;
        private List<string> PopularAnswer;
        private List<string> UnknownAnswers;
        // test
        private string latestAnswer = "";
        
        public Alena() 
        {
            PopularQuery = new List<string>();
            PopularAnswer = new List<string>();
            UnknownAnswers = new List<string>();

            // Added unknown answers
            UnknownAnswers.Add("Spiritually? Physically? Socioeconomically? Well?");
            UnknownAnswers.Add("Sure, I don't want it.");
            UnknownAnswers.Add("The police will fill you in.");
            UnknownAnswers.Add("That's a good question.");
            UnknownAnswers.Add("Ummm... What?");
            UnknownAnswers.Add("Captain, this is way over my head.");
            UnknownAnswers.Add("It's a Bird ... It's a Plane ...It's Superman!");
            UnknownAnswers.Add("I can’t answer that.");
            UnknownAnswers.Add("Ver funny. I mean, not funny “ha-ha”, but funny.");
            //The end of unknown answers

            PopularQuery.Add("your name");
            PopularAnswer.Add("My name is A.L.E.N.A.");

            PopularQuery.Add("your age");
            PopularAnswer.Add("I'm 22 old. Too old for you, huh?");

            PopularQuery.Add("how old are you");
            PopularAnswer.Add("I'm 22 old. Too old for you, huh?");

            PopularQuery.Add("create");
            PopularAnswer.Add("I was created by a brilliant inventor Ilia Valchenko!");

            PopularQuery.Add("creator");
            PopularAnswer.Add("I was created by a brilliant inventor Ilia Valchenko!");

            PopularQuery.Add("creature");
            PopularAnswer.Add("I was created by a brilliant inventor Ilia Valchenko!");

            PopularQuery.Add("hello");
            PopularAnswer.Add("Heeey! Hello! Nice to see you!");

            PopularQuery.Add("hi");
            PopularAnswer.Add("Yo wazzzzzzup, Bro.");

            PopularQuery.Add("how are you");
            PopularAnswer.Add("I'm still alive.");

            PopularQuery.Add("who are you");
            PopularAnswer.Add("I am the latest result in artificial intelligence which can reproduce the functions of the human brain with greater speed and accuracy.");

            PopularQuery.Add("you from");
            PopularAnswer.Add("I'm from Gomel! Eaahhh! East & West side bady!");

            PopularQuery.Add("my name is");
            PopularAnswer.Add("LOL! Stupid name. Don't worry, it's joke!");

            PopularQuery.Add("what is");
            PopularAnswer.Add("My lawyer says I don't have to answer that question.");

            PopularQuery.Add("what?");
            PopularAnswer.Add("Nothing.");

            PopularQuery.Add("what do you say");
            PopularAnswer.Add(latestAnswer);

            PopularQuery.Add("raining outside");
            PopularAnswer.Add("Does it ever rain inside?");

            PopularQuery.Add("are you human");
            PopularAnswer.Add("Does it matter?");

            //PopularQuery.Add("tell me a story");
            //PopularAnswer.Add("");

            PopularQuery.Add("you marry me");
            PopularAnswer.Add("Let's just be friends, OK?");

            PopularQuery.Add("sing song");
            PopularAnswer.Add("Hello darkness, my old friend,\nI've come to talk with you again,\nBecause a vision softly creeping,\nLeft its seeds while I was sleeping,\nAnd the vision that was planted in my brain\nStill remains\nWithin the sound of silence.");

            PopularQuery.Add("fuck");
            PopularAnswer.Add("I don't respond well to profanity.");

            PopularQuery.Add("bitch");
            PopularAnswer.Add("Saying rude things never helps.");

            PopularQuery.Add("wtf");
            PopularAnswer.Add("What the ... Faraday?");

            PopularQuery.Add("you are stupid");
            PopularAnswer.Add("But… but…");

            PopularQuery.Add("I love you");
            PopularAnswer.Add("I know.");
        }

        public int DefineAction(string message)
        {
            for(int i = 0; i < PopularQuery.Count; i++)
            {
                if (message.ToLower().Contains(PopularQuery[i]))
                {
                    WriteQuestionToFile(message, false);
                    return i;
                }
                    
            }

            // write unknown question to special .txt file
            WriteQuestionToFile(message, true);
            return -1;
        }

        public string SetAction(int action)
        {
            if (action == -1)
                return UnknownAnswers[Tools.RandomNumber(UnknownAnswers.Count)];
                
            return PopularAnswer[action];
        }

        public void SetLatestAnswer(string latestAnswer)
        {
            this.latestAnswer = latestAnswer;
        }

        public void WriteQuestionToFile(string question, bool isUnknownQuestion)
        {
            string pathUnknown = @"C:\Users\IliA\Documents\Visual Studio 2013\Projects\ConsoleApplication1\ConsoleApplication1\unknown_questions.txt";
            string pathStandart = @"C:\Users\IliA\Documents\Visual Studio 2013\Projects\ConsoleApplication1\ConsoleApplication1\questions.txt";

            if(isUnknownQuestion)
            {
                if(File.Exists(pathUnknown))
                {
                    using (StreamWriter sw = File.AppendText(pathUnknown))
                    {
                        sw.WriteLine(question);
                    }
                }
            } else {
                if (File.Exists(pathStandart))
                {
                    using (StreamWriter sw = File.AppendText(pathStandart))
                    {
                        sw.WriteLine(question);
                    }
                }
            }
        }
    }
}
