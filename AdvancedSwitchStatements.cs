namespace CsharpTesting {

    class AdvancedSwitchStatements{

        public void usingGoTo(int cardNumber) {
            switch (cardNumber) {
                case 13:
                    Console.WriteLine("King");
                    break;
                case 12:
                    Console.WriteLine("Queen");
                    break;
                case 11:
                    Console.WriteLine("Jack");
                    break;
                case -1:
                    goto case 12;
                default:
                    Console.WriteLine(cardNumber);
                    break;
            }
        }

        public void sequentialCases(int cardNumber) {
            switch(cardNumber) {
                case 13:
                case 12:
                case 11:
                    Console.WriteLine("Face Card");
                    break;
                default:
                    Console.WriteLine("boring normal card");
                    break;
            }
        }

        // object is the base class, so you can input anything here
        public void switchingOnTypes(object x) {
            switch (x) {
                case int i:
                    Console.WriteLine("Int!");
                    break;
                case string s:
                    Console.WriteLine("String!");
                    break;
                // An underscore is used when we don't care about the value
                case DateTime _:
                    Console.WriteLine("It's a datetime!");
                    break;
                default:
                    Console.WriteLine("who knows!");
                    break;
            }
        }

        public void predicates(object x) {
            switch (x) {
                case bool b when b == true:
                    Console.WriteLine("True!");
                    break;
                case bool b:
                    Console.WriteLine("False!");
                    break;
            }

            switch (x) {
                case float f when f > 1000:
                case double d when d > 1000:
                case decimal m when m > 1000:
                    Console.WriteLine("We can refer to x here but not f, d, or m");
                    break;
            }
        }

        public void switchExpressions(int x) {
            string numberString = x switch {
                1 => "one",
                2 => "two",
                3 => "three",
                _ => "Something else" // this is the default case
            };

            char letter = 'a';
            string @case = "lower";
            // you can also switch on multiple values with tuples
            string answer = (letter, @case) switch {
                ('a', "lower") => "lowercase a",
                ('A', "upper") => "upper case A"
            };

            
        }



    }
}