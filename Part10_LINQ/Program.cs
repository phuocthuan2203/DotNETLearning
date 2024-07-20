namespace Part10_LINQ;

class Program
{
    static void Main(string[] args)
    {
        var dataSource = GetIntegerNumbers();
        Print(dataSource);
        
        // LINQ is also an expression, so we can assign it into a variable and call this variable (we can also call directly this expression)
        
        // There are to ways writing LINQ query
        // query syntax
        var ns = from n in dataSource where (GreaterThanZero(n) && n % 2 == 0) select n; // LINQ to object
        
        // method syntax: using this way when we want to return Count(), Sum()
        var ns1 = dataSource.Where(n => GreaterThanZero(n) && n % 2 == 0);
        
        Print(ns1);
        Console.WriteLine("\n---------------------");
        Console.WriteLine(ns1.Count());

        Console.WriteLine("Query syntax structure: ");
        QuerySyntaxStructure();

        Console.WriteLine("Method syntax structure: ");
        MethodSyntaxStructure();

        Console.WriteLine("Advanced LINQ query example: ");
        AdvancedLinqExample();
    }

    static void QuerySyntaxStructure()
    {
        List<int> numbers = new List<int> { 5, 10, 8, 3, 6, 12 };

        var query = from num in numbers
            where num > 5
            orderby num
            select num;

        foreach (var num in query)
        {
            Console.WriteLine(num);
        }
    }

    static void MethodSyntaxStructure()
    {
        List<int> numbers = new List<int> { 5, 10, 8, 3, 6, 12 };

        var query = numbers.Where(num => num > 5)
            .OrderBy(num => num)
            .Select(num => num);

        foreach (var num in query)
        {
            Console.WriteLine(num);
        }
    }
    
    static void AdvancedLinqExample()
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer { ID = 1, Name = "Alice", City = "New York" },
            new Customer { ID = 2, Name = "Bob", City = "Los Angeles" },
            new Customer { ID = 3, Name = "Charlie", City = "New York" }
        };

        List<Order> orders = new List<Order>
        {
            new Order { CustomerID = 1, Amount = 100 },
            new Order { CustomerID = 2, Amount = 150 },
            new Order { CustomerID = 1, Amount = 200 }
        };

        var query = from customer in customers
            join order in orders on customer.ID equals order.CustomerID
            where customer.City == "New York"
            group order by customer.Name into customerGroup
            let totalAmount = customerGroup.Sum(o => o.Amount)
            orderby totalAmount descending
            select new
            {
                CustomerName = customerGroup.Key,
                TotalAmount = totalAmount
            };

        foreach (var item in query)
        {
            Console.WriteLine($"{item.CustomerName}: {item.TotalAmount}");
        }
    }
    
    

    static bool GreaterThanZero(int n)
    {
        Console.WriteLine($"{n} > 0 = {n > 0}");
        return n > 0;
    }

    // create a data source for processing
    static IEnumerable<int> GetIntegerNumbers()
    {
        var ns = new int[] { 0, 1, 234, 2, 3, 5544, 345, 23443, 0, -22, -456, 123455 };
        return ns;
    }

    static void Print(IEnumerable<int> values)
    {
        Console.WriteLine("\nThe list of numbers:");
        foreach (var value in values)
        {
            Console.Write($"{value}   ");
        }
    }
}

class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
}

class Order
{
    public int CustomerID { get; set; }
    public int Amount { get; set; }
}