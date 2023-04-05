//Thread thread1 = new Thread(ShowA);
//Thread thread2 = new Thread(ShowB);

//thread1.Start();
//thread1.Join();
//thread2.Start();
//Thread.Sleep(50);
//Console.WriteLine("Hello");

////ShowA();
////ShowB();

//void ShowA()
//{
//    for (int i = 0; i < 10000; i++)
//    {
//        Console.Write("a ");
//    }
//}

//void ShowB()
//{
//    for (int i = 0; i < 10000; i++)
//    {
//        Console.Write("b ");
//    }
//}

//int count = 0;
//object togrulObj1 = new object();
//object togrulObj2 = new object();

//Thread thread1 = new Thread(Increase);
//Thread thread2 = new Thread(Decrease);

//thread1.Start();
//thread2.Start();
//thread1.Join();
//thread2.Join();
//Increase();
//Decrease();

//Console.WriteLine(count);

//void Increase()
//{
//    for (int i = 0; i < 100000; i++)
//    {
//        lock (togrulObj1)
//        {
//            count++;
//        }
//    }
//}

//void Decrease()
//{
//    for (int i = 0; i < 100000; i++)
//    {
//        lock (togrulObj1)
//        {
//            count--;
//        }
//    }
//}

//async await Task

//var result = await GetAsync("https://jsonplaceholder.typicode.com/posts");
//Console.WriteLine(result);

//async Task<string> GetAsync(string path)
//{
//    HttpClient client = new HttpClient();
//    var response = await client.GetStringAsync(path);

//    return response;
//}

using ConsoleApp1;

//Database database1 = new Database();
//Database database2 = new Database();
//Database database3 = new Database();
//Database database4 = new Database();

//Database database1 = Database.GetInstance;
//Database database2 = Database.GetInstance;
//Database database3 = Database.GetInstance;
//Database database4 = Database.GetInstance;
//Database database5 = Database.GetInstance;

var t1 = Task.Run(() =>
{
    Database database = Database.GetInstance;
});
var t2 = Task.Run(() =>
{
    Database database = Database.GetInstance;
});

await Task.WhenAll(t1, t2);