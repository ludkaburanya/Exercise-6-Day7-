namespace z1
{
    public class Program
    {
        static void Main ()
        {
            Console.Write("Введите текст :");
            string s = Console.ReadLine();
            int k = 0; int max = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    k++;

                    if (k > max)
                        max = k;
                }
                else
                    k = 0;
            }
            Console.WriteLine("Наибольшее количество цифр идущих подряд = {0}", k); ;
            Console.ReadKey();
        }
    }
}