namespace MethodOverloading
{
    public class MyClass
    {
        public static void Main()
        {
             
        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isDollars)
        {
            int sum = a + b;
            if (isDollars)
            {
                if (sum == 1)
                {
                    return $"{sum}dollar";
                }
       
                    
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }

          
        }
    }
}
