namespace ConsoleApp1;

public class Database
{
    private Database()
    {
        Console.WriteLine("Database created");
    }

    //static Database()
    //{
    //    _database = new Database();
    //}

    private static Database _database;
    private static object _lock = new object();

    public static Database GetInstance
    {
        get
        {
            lock (_lock)
            {
                if (_database == null)
                    _database = new Database();
            }

            return _database;
        }
    }
}