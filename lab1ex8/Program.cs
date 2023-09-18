namespace lab1ex8
{
    class Program
    {
        /*
         Scrieti un program care interschimba valoarea a doua variabile intregi
         */
        static void Main(string[] args)
        {
            int a = 5; 
            int b = 99;
            int temp;
            Console.WriteLine("Valori initiale: ");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("Interschimbare: ");
            temp = a;
            a= b;
            b= temp;
            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
}