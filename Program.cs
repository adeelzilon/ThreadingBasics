public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Zilon International Inc.");
        SyncTask1();
        SyncTask2();
        SyncTask3();
        SyncTask4();

    }

    public static void SyncTask1()
    {
        Console.WriteLine("SyncTask1 is starting");
        Thread.Sleep(5000);
        Console.WriteLine("SyncTask1 is completed");

    }

    public static void SyncTask2()
    {
        Console.WriteLine("SyncTask2 is starting");
        Thread.Sleep(2000);    
        Console.WriteLine("SyncTask2 is completed");

    }

    public static void SyncTask3()
    {
        Console.WriteLine("SyncTask3 is starting");
        Thread.Sleep(3000);
        Console.WriteLine("SyncTask3 is completed");

    }

    public static void SyncTask4()
    {
        Console.WriteLine("SyncTask4 is starting");
        Thread.Sleep(1000);
        Console.WriteLine("SyncTask4 is completed");

    }

}