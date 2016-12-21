using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingFortuneTeller
{
    class CrystalBall 
    {
        //Fields.
        private Random random = new Random();
        private string name;


        //The CrystalBall has similar properties to the FortuneTeller class.
        //When we cover Inheritance, you'll learn how to set up classes so that
        //they are not as repetitive as they are in this example. One of our 
        //favorite principles as programmers is "DRY - Don't Repeat Yourself!"

        //The CrystalBall has a property that is a List. You can see that, because
        //we're using the word "new", we are constructing a new List object. That
        //means an object can be a property! Mind blown?
        //We'll play with this List property in the Methods below.
        protected List<string> Phrases { get; set; } = new List<string>();
        public string Name { get; set; } = "Crystal Ball";
        public decimal Price { get; set; }
        public int PercentEffective { get; set; }
        public bool BlackMagic { get; set; }
        public string Expertise { get; set; }

        //methods
        public virtual void Work()
        {
            Console.WriteLine("Let me pull out my {0}", this.Name);
        }

        protected void CreatePhrases()
        {
            //I chose happy, mushy phrases for my List. Do you see the .Add() method?
            //That's built in to the List object. What is that similar to if we're comparing
            //Lists to arrays? 

            //This method gives us something to do with our Phrases property.
            Phrases.Add("Your best friend will be there for you when you need them.");
            Phrases.Add("I see joy in your near future");
            Phrases.Add("You will soon feel deeply loved.");
            Phrases.Add("I believe you will be successful in all of your endeavors.");
            Phrases.Add("You will soon make a friend who will be in your life forever.");
            Phrases.Add("You will see something adorable today.");
        }

        //let's create an overloaded method now
        internal void CreatePhrases(string phrase)
        {
            //See how this version of CreatePhrases takes a parameter? That parameter
            //is a string called "phrase". Notice how that "phrase" string is also used
            //in the Method itself, as part of the .Add() method. What do you think this
            //version of CreatePhrases will do?
            Phrases.Add(phrase);
        }

        private string GetPhrase()
        {
            //local variable, meaning because I'm declaring and initializing this 
            //int inside of this method, it only exists inside this method. That's an
            //example of scope. 

            //Notice how my list - Phrases - has a .Count property. What do you think
            //that is? It also has an .ElementAt() property. What is this chunk of code
            //doing?
            int randomNumber = random.Next(Phrases.Count);
            return Phrases.ElementAt(randomNumber);
        }

        //constructor
        public CrystalBall()
        {
            this.Price = 20.00M;
            this.PercentEffective = 65;
            this.BlackMagic = false;
            this.Expertise = "beginner";
            //I want to call my initializer for phrases.
            CreatePhrases();
        }

        //Can you think of another constructor we could make for CrystalBall?
    }

}
