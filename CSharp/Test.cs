using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Alice
    {
        private List<string> PopularQuery;
        private List<string> PopularAnswer;
        private List<string> UnknownAnswers;
        // test
        private string latestAnswer = "";
        
        public Alice() 
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
            
            //The end of unknown answers

            PopularQuery.Add("your name");
            PopularAnswer.Add("My name is A.L.E.N.A.");

            PopularQuery.Add("your age");
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

            PopularQuery.Add("fuck");
            PopularAnswer.Add("I don't respond well to profanity.");

            PopularQuery.Add("bitch");
            PopularAnswer.Add("Saying rude things never helps.");
        }

        public int DefineAction(string message)
        {
            for(int i = 0; i < PopularQuery.Count; i++)
            {
                if (message.Contains(PopularQuery[i]))
                    return i;
            }

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
    }
}
