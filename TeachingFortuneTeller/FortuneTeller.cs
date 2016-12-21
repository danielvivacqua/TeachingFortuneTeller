using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingFortuneTeller
{
    class FortuneTeller
    {
        //fields are usually private, and often not "declared" at the start
        //Properties auto-generate fields if you do not have them written out 
        private string name;
        private decimal price;
        private bool blackMagic;


        //Properties
        //There are various ways to "set up" properties
        //You can initialize their value from the start:
        public string Name { get; set; } = "Fortune Teller";
        //You can spell out their connection to the field using the following format:
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                this.price = value;
            }
        }
        //You can set up a property this short and simple way. 
        //Notice that there is no private field percentEffective.
        //This way of setting up a Property creates the field "behind the scenes" or
        //"under the invisibility cloak"
        public int PercentEffective { get; set; }
        //This way of setting up a property doesn't directly spell out the connection to
        //the private field blackMagic. However, the connection is there.
        //You don't see it, because it's like ... well ... magic!
        public bool BlackMagic { get; set; }
        public string Expertise { get; set; }
        public string Practitioner { get; set; } = "Sasha the Psychic";

        //methods
        public virtual void Work()
        {
            //Notice how I am calling the Properties "out of order"
            //this.Name is at the index of 0 in the array of Properties after the string
            //this.Practitioner is at the index of 1 in the array of Properties after the string
            //As long as I use the correct index in my {curly brackets}, I don't need to reference them
            //in order
            Console.WriteLine("I am {1}. I will be your {0}", this. Name, this.Practitioner);
        }

        public void Greet()
        {
            //This is a void method, because it simply does what we tell it to, without returning a value
            Console.WriteLine("Hello! Come in ... I feel a presence about you.");
            Console.WriteLine("Let me see what I have to offer you today.");
        }

        public void Farewell()
        {
            Console.WriteLine("Thank you, and may your future be bright and mysterious.");
        }

        public void Color()
        {
            //In your FortuneTeller project, you did some work where the color the user chooses
            //results in a certain fortune. In this method, we're doing the same thing, although
            //the response for each color is a little different. Notice how we can set up this method
            //of "fortune telling" right here in the FortuneTeller class. How do you think we would
            //use this in the Main method of the Program class?
            Console.WriteLine("Please tell me your favorite ROYGBIV color by selecting a letter from ROYGBIV.");
            string userColor = Console.ReadLine().ToUpper();
            string userQuality = "";
            switch (userColor)
            {
                case "R":
                    userQuality = "You have a deep passion in your heart.";
                    break;
                case "O":
                    userQuality = "You are creative and talented.";
                    break;
                case "G":
                    userQuality = "You are successful and intuitive.";
                    break;
                case "B":
                    userQuality = "You have an incredible capacity for love.";
                    break;
                case "I":
                    userQuality = "You are very comforting and compassionate.";
                    break;
                case "V":
                    userQuality = "You're pretty much the best ever.";
                    break;
                default:
                    userQuality = "You're not too bad.";
                    break;
            }
            Console.WriteLine(userQuality);
        }


        //constructor
        
        public FortuneTeller()
        {
            //This constructor that doesn't take parameters in the parentheses is called a 
            //default constructor. Whenever we create - or instantiate - a new object of the
            //class FortuneTeller, that object will have certain values assigned to its
            //properties. If we use this constructor, the FortuneTeller's properties
            //have the following values:
            this.Price = 40.00M;
            this.PercentEffective = 82;
            this.BlackMagic = false;
            this.Expertise = "intermediate";
        }
        
        //overloaded constructor

        public FortuneTeller(string lowerPrice)
        {
            //We created another constructor! This constructor takes a parameter, and that is
            //a string. Imagine someone creating a FortuneTeller object but saying they want
            //the cheaper version. How might we use the parameter in this constructor in our 
            //Main method of the Program class?

            //When this constructor is used, the values for the properties are different than
            //the values of our default constructor. Notice how "Practitioner" - a value we 
            //initialized when creating our properties - gets changed when we use this constructor.
            //Will my Console.WriteLine() work if I have it in the constructor? Is it in the 
            //right place?
            this.Price = 15.00M;
            this.PercentEffective = 37;
            this.BlackMagic = false;
            this.Practitioner = "Bertha the Beginner";
            this.Expertise = "beginner";
            Console.WriteLine("You want a lower price? Okay, you can get {0} for {1}", this.Practitioner, this.Price);
        }

    }
}

