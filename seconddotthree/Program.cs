internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите натуральное число: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Введите число, которое вы собираетесь удалять: ");
        string del = Console.ReadLine();

        Console.Write("ф) ");
        string s = num.ToString();
        char[] str = s.ToCharArray();
        string a;
        for (int i = str.Length - 1; i > -1; --i)
        {
            a = Convert.ToString(str[i]);
            Console.Write(a);
        }
        Console.WriteLine();

        Console.Write("б) ");
        string bresult = Convert.ToString("2" + num + "2");
        Console.WriteLine(bresult);

        Console.Write("в) ");
        for(int i = 0; i < str.Length; ++i)
        {
            if (str[i].ToString() == del) continue;
            else Console.Write(str[i]);
        }
        Console.WriteLine();

        Console.Write("г) ");
        for (int i = 0; i < str.Length; ++i)
        {
            if (i == 0) Console.Write(str[str.Length - 1]);
            else if (i == str.Length - 1) Console.Write(str[0]);
            else Console.Write(str[i]);
        }
        Console.WriteLine();

        Console.Write("д) ");
        Console.WriteLine(num.ToString() + num.ToString());
    }
}