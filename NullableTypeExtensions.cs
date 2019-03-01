using System;

namespace PadawansTask10
{
    public static class NullableTypeExtensions
    {
        public static bool IsNull(this object variable)
        {
            // put your code here
            //throw new NotImplementedException();
            try
            {
                string a = (string)variable;
                int b = (int)variable;
                double c = (double)variable;
                char d = (char)variable;
            }
            catch
            {
                if (variable!=null)
                    return false;
            }
            return true;
        }
    }
}
