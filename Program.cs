// the global keyword indicates that this directive will be used in every file of our project
global using System.Collections.Generic;
using System.Linq.Expressions;
// Called importing a namespace
using System.Runtime.CompilerServices;

namespace CsharpTesting
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // Testing out lambdas

            // The implicit type for a lambda expression is an Action or Func delegate
            // so greeter, in this case, is of type Func<string>
            var greeter = (int x) => "Hello, World";
            //Console.WriteLine(greeter());

            // You must explicitly state any parameter types
            var square = (int x) => x * x;
            //Console.WriteLine(square(2));

            // a lambda expresion can specify an explicit return type
            // this is mainly to improve compiler performance with complex nested lambdas
            var multiply = float (int x, int y) => x * y;
            //Console.WriteLine(multiply(2, 3));

            // you can pass a lambda expression into a method parameter of type object, Delegate, or Expression
            void M1(object x) { 
                Console.WriteLine(x); 
            };
            void M2(Delegate x) { };
            void M3(Expression x) { };

            M1(greeter(2)); 

            LanguageBasics x = new LanguageBasics();
            x.function1();
            x.function2();

            myStaticClass.saySomething();
        }
    
        class LanguageBasics
        {
            //testing out some constructor behavior
            public LanguageBasics() {
                Console.WriteLine("The Constructor has been called!");
            }
            public void  function1 ()
            {
                // if you really want to use a reserved keyword for a variable name, you can with @
                bool @using = true;
                Console.WriteLine(@using);
            }

            public void function2() {

            }
        };
    
    public class myStaticClass {
        public static void saySomething() {
            Console.WriteLine("This is a static method!");
        }
    };


    public class TypeConversions {
        //Conversions can be either implicit or explicit
        //implicit conversion
        public void ImplicitlyConvert() {
            int x = 1234;
            long y = x;            
        }

        //explicit conversions
        public void ExplicitlyConvert() {
            int x = 4321;
            short z = (short)x;
        }
    };

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
        
        

        // Generic Type parameters

        //Pointer Types

    };

    };
}