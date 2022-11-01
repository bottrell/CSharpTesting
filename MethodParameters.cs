using System.Text;

namespace CsharpTesting {
    class MethodParameters {
        //Parameters can be passed with ref, in, and out modifiers
        // ref = Reference
        // in = Reference (read-only)
        // out = Reference (going out)
        StringBuilder sb = new StringBuilder();
        // Passing in sb to testing with pass by reference
        // to call testing we would call: Console.WriteLine(testing(ref sb));
        public void testingPBR(ref StringBuilder fooSb) {
            fooSb.Append("this is pass by reference!");
        }

        // The out modifier is used to get multiple values out of a function
        string first;
        string last;
        public void testingOut(string name, out string f, out string l) {
            // because f and l are both out parameters, they must be assigned in the method
            f = name.Split(" ")[0];
            l = name.Split(" ")[^1]; 
        }

        // The in modifier says that the method cannot modify the parameter
        // This is useful for large value types 
        public void testingIn(in string[] arr) {
            Console.WriteLine(arr[0]);
        }

        // The params keyword allows you to pass in as many values as you want
        // testingParams(1,2,3,4); -> This is treated as an array
        public void testingParams(params int[] ints) {
            for (int i = 0; i < ints.Length; i++) {
                Array.Sort(ints);
            }
        }

        // Optional Parameters need default values
        // Optional parameters cannot be ref or out
        public int testingOptional(int x, int y = 20) {
            return Math.Max(x,y);
        }

        public int testingNamedValues() {
            // This is how you specify named values
            return testingOptional(x:2, y:2); // semantically identical to testingOptional(y:2, x:2);
        }

    }
}