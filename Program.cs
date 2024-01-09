public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Zilon International Inc.");
        //SyncTask1();
        //SyncTask2();
        //SyncTask3();
        //SyncTask4();


        AsyncTask1();
        AsyncTask2();
        AsyncTask3();
        AsyncTask4();
        Console.ReadLine();

    }


    public static async void AsyncTask1()
    {
        await Task.Run(() =>
           {
               Console.WriteLine("AsyncTask1 s starting");
               Thread.Sleep(4000);
               Console.WriteLine("AsyncTask1 is completed");
           });

    }

    public static async void AsyncTask2()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("AsyncTask2 s starting");
            Thread.Sleep(1000);
            Console.WriteLine("AsyncTask2 is completed");
        });

    }


    public static async void AsyncTask3()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("AsyncTask3 s starting");
            Thread.Sleep(2000);
            Console.WriteLine("AsyncTask3 is completed");
        });

    }

    public static async void AsyncTask4()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("AsyncTask4 s starting");
            Thread.Sleep(3000);
            Console.WriteLine("AsyncTask4 is completed");
        });

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
}