namespace CsharpTesting {
    public class ValueVsReferenceTypes {
        // C# types fall into the following categories: value, reference, generic, and pointer
        
        public void ValueTypes() {
            //value types - simply a value. The assignment of a value-type instance always copies the instance
            const char myChar = 'J';
            int myInt = 2;
            int million = 1_000_000; //this just makes things more readable
            
            float myFloat; //These are generally used for scientific and graphical calculations
            double myDouble;
            float f = 1.0f; //Numeric suffixes explicitly define the type of a literal
            decimal myDecimal; //Decimals are generally used for financial calculations as they use base-10-accurate arithmetic and are highly precise
        
            //When performing a calculation that may overflow, you can use "checked"
            int a = 10000000;
            int b = 10000000;
            int c = checked(a*b); //This will throw an overflow error if executed. "unchecked" can be used vice versa
        }

        public void Booleans() {
            //using the ternary operator
            int a = 2;
            int b = 3;
            bool ans = (a > b) ? true :  false; //this is particularly useful in LINQ expressions
        }

        public static void Characters() {
            var escapeSequences = new Dictionary<string, string> {
                { "\'" ,  "Single Quote"},
                { "\"", "Double Quote"},
                {"\\", "Backslash"},
                {"\0", "Null"},
                {"\a", "Alert"},
                {"\b", "Backspace"},
                {"\f", "Form Feed"},
                {"\n", "New Line"},
                {"\r", "Carriage return"},
                {"\t", "Horizontal tab"},
                {"\v", "Vertical tab"}
                // {"\u", "Specify unicode characters"},
                // {"\x", "Same as \u"}
            };
            // char can be implicitly converted to an unsigned short
            int x = 'a'; 
            Console.WriteLine(x); //prints 97
        }


        class myClass{};
        public void ReferenceTypes() {
            // Reference Types (all class, array, delegate, and interface types)
            // Reference Types have an object and a reference. The content of a reference type is a reference to the object
            string myString = "asdf";


            //Comparison with reference types:
                // By default is based on reference, as opposed to actual value of the underlying object
            myClass a = new myClass();
            myClass b = new myClass();
            Console.WriteLine(a == b); // would equal False
            myClass c = a;
            Console.WriteLine(a == c); //would equal true
        }
        
        public void Strings() {
            //normal strings
            string s = "asdf";
            string s2 = @"\\server\fileshare\helloworld";

            string verbatim = @"First Line
            
                                Second Line"; // verbatim strings can also span multiple lines

            // Concatenations
            string s3 = "a" + "b";
            
            // String interpolation
            int x = 4;
            Console.WriteLine($"A suqare has {x} sides");

            // String Comparisons
            // s > s2 -> This is not valid
            int s4 = s.CompareTo(s2);

        }
        
        public void Arrays() {
            int[] arr = new int[] {1,2,3,4,5};
            // int[] arr = {1,2,3,4,5} is also valid
            Console.WriteLine(arr.Length);

            // Negative Indices
            int lastIndex = arr[^1]; // This will return 5
            int secondToLastIndex = arr[^2];

            // C# implements indices with the help of the Index type,
            Index last = ^1;
            int lastIndex2 = arr[last];

            // Slicing Arrays is possible with the .. operator
            int[] firstTwoIndices = arr[..2]; //this will exclude the 2nd index (exclusive)
            int[] lastTwoIndices = arr[^2..];
    
            // The Range type lets you assign a range explicitly 
            Range firstTwo = 0..2;
            Console.WriteLine(arr[firstTwo]);
        }

        // Generic Type parameters

        //Pointer Types

    };
}