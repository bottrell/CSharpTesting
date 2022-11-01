// the global keyword indicates that this directive will be used in every file of our project
global using System.Collections.Generic;
using System.Linq.Expressions;
// Called importing a namespace
using System.Runtime.CompilerServices;
using System.Text;

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
            ValueVsReferenceTypes.Characters();

            // String Builders are pretty cool. They are mutable arrays of characters instead of immutable like strings
            StringBuilder myStringBuilder = new StringBuilder("asdf");
            Console.WriteLine("myStringBuilder Length: " + myStringBuilder.Length);
            Console.WriteLine("myStringBuilder Capacity: " + myStringBuilder.Capacity);
            for (int i = 0; i < 50; i++) {
                myStringBuilder.Append('a');
            }
            Console.WriteLine("myStringBuilder Capacity: " + myStringBuilder.Capacity);
            Lambdas.testingLambdas();

            Console.WriteLine("---------");
            Random r = new Random();
            var a = r.Next();
            Console.WriteLine(a.GetType());
        }

    };
}