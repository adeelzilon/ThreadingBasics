
using System;
using System.Threading.Tasks;
using System.Threading;

public class Program
{
    // Entry point of the application
    static async Task Main(string[] args)
    {
        // Uncomment and run synchronous tasks
        // SyncTask1();
        // SyncTask2();
        // SyncTask3();
        // SyncTask4();

        // Run asynchronous tasks
        await AsyncTask1();
        await AsyncTask2();
        await AsyncTask3();
        await AsyncTask4();

        // Wait for user input before closing the console
        Console.ReadLine();
    }

    // Asynchronous task simulating work with a delay
    public static async Task AsyncTask1()
    {
        await Task.Run(() =>
        {
            // Starting AsyncTask1
            Console.WriteLine("AsyncTask1 is starting");
            // Simulating work
            Thread.Sleep(4000);
            Console.WriteLine("AsyncTask1 is completed");
        });
    }

    // Asynchronous task simulating work with a delay
    public static async Task AsyncTask2()
    {
        await Task.Run(() =>
        {
            // Starting AsyncTask2
            Console.WriteLine("AsyncTask2 is starting");
            // Simulating work
            Thread.Sleep(1000);
            Console.WriteLine("AsyncTask2 is completed");
        });
    }

    // Asynchronous task simulating work with a delay
    public static async Task AsyncTask3()
    {
        // Welcome message before the asynchronous task
        Console.WriteLine("Welcome to Zilon International Inc.");

        await Task.Run(() =>
        {
            // Starting AsyncTask3
            Console.WriteLine("AsyncTask3 is starting");
            // Simulating work
            Thread.Sleep(2000);
            Console.WriteLine("AsyncTask3 is completed");
        });
    }

    // Asynchronous task simulating work with a delay
    public static async Task AsyncTask4()
    {
        await Task.Run(() =>
        {
            // Starting AsyncTask4
            Console.WriteLine("AsyncTask4 is starting");
            // Simulating work
            Thread.Sleep(3000);
            Console.WriteLine("AsyncTask4 is completed");
        });
    }

    // Synchronous task simulating work with a delay
    public static void SyncTask1()
    {
        // Starting SyncTask1
        Console.WriteLine("SyncTask1 is starting");
        // Simulating work
        Thread.Sleep(5000);
        Console.WriteLine("SyncTask1 is completed");
    }

    // Synchronous task simulating work with a delay
    public static void SyncTask2()
    {
        // Starting SyncTask2
        Console.WriteLine("SyncTask2 is starting");
        // Simulating work
        Thread.Sleep(2000);
        Console.WriteLine("SyncTask2 is completed");
    }

    // Synchronous task simulating work with a delay
    public static void SyncTask3()
    {
        // Starting SyncTask3
        Console.WriteLine("SyncTask3 is starting");
        // Simulating work
        Thread.Sleep(3000);
        Console.WriteLine("SyncTask3 is completed");
    }

    // Synchronous task simulating work with a delay
    public static void SyncTask4()
    {
        // Starting SyncTask4
        Console.WriteLine("SyncTask4 is starting");
        // Simulating work
        Thread.Sleep(4000);
        Console.WriteLine("SyncTask4 is completed");
    }

    // Uncommented code for synchronous tasks and additional comments remain unchanged
}
