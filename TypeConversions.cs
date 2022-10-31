namespace CsharpTesting {
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
}