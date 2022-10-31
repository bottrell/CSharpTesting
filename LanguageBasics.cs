
namespace CsharpTesting{
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
}