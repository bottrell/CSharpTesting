using System.Text;

namespace CsharpTesting {
    class NullOperators {
        public void nullCoalescingOperator() {
            // The ?? operator is the null-coalescing operator
            string nullString = null;
            // if the value on the left is null, give me a default value
            string couldBeNull = nullString ?? "nothing";

            // If the value on the left is null, assign the value here
            nullString ??= "asdf";
        }

        public void nullConditionalOperator() {
            // ?. allows you to call methods like . but return null instead of an exception
            StringBuilder sb = null;
            // if the method fails, return a null instead of throwing a nullexception
            string s = sb?.ToString();
        }
    };
}