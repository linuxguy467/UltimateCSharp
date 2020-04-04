using System;

namespace PrimitiveTypes
{
    public class TypeConversion
    {
        public static void WorkWithTypes()
        {
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);
            //int i = 1000;
            //byte b = (byte) i;
            //Console.WriteLine(b);
            try
            {
                /*  var number = "1234";
                    byte b = Convert.ToByte(number);
                    Console.WriteLine(b);
                */
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }
        }
    }
}
