using System.Threading.Channels;

namespace Part10_LINQ2;

class Program
{
    static void Main(string[] args)
    {
        var students = GetStudents();
        
        // bản thân kết quả trả về của LINQ cũng implement IEnumerable<> nên ta có thể sử dụng trong hàm Print(IEnumerable<Student> students)
        Print(students.Where(s => s.YoB > 2003));
        // nếu YoB bị trùng thì sẽ ThenBy() theo tên => lọc theo nhiều tiêu chí, ưu tiên từ trái qua phải
        Print(students.OrderByDescending(s => s.YoB).ThenBy(s => s.Name));

        Console.WriteLine("Select only the name:");
        // Sau khi Select(s => s.Name) thực hiện, nó trả về 1 tập hợp chỉ có Name (kiểu string), nên studentName bây giờ là string chứ ko phải Student
        foreach (var studentName in students.OrderBy(s => s.Name).Select(s => s.Name))
        {
            Console.WriteLine(studentName);
        }
        
        // Giả sử chỉ có students.OrderBy(s => s.Name), thì nó sẽ sort các student theo name, sau đó trả về 1 tập hợp các student đã được lọc theo name
        foreach (var studentName in students.OrderBy(s => s.Name))
        {
            Console.WriteLine(studentName.Name);
        }
        
        // lọc những student có YoB là 2012, sau đó ta in ra Name của student đó
        foreach (var student in students.Where(s => s.YoB == 2012))
        {
            Console.WriteLine(student.Name);
        }

        // FirstOrDefault(): trả về giá trị đầu tiên querying được, nếu null thì hàm sẽ trả về null. First() thì sẽ throw Exception khi bị null
        // var s = GetStudents().FirstOrDefault(s => s.YoB == 2012);
        var s = GetStudents().Where(s => s.YoB == 2012).Skip(1).Take(2);
        Print(s);
    }

    static void Print(IEnumerable<Student> students)
    {
        foreach (var student in students)
        {
            Print(student);
        }
    }

    private static void Print(Student student)
    {
        Console.WriteLine($"\nName: {student.Name}, City: {student.City}, YoB: {student.YoB}");
    }

    // all collections implement IEnumerable, so we can use it instead of the specific collection type
    static IEnumerable<Student> GetStudents()
    {
        return new Student[]
        {
            new Student()
            {
                Name = "Test 2003",
                City = "Quy Nhon",
                YoB = 2003
            },
            new Student()
            {
                Name = "Test 2014",
                City = "Quy Nhon",
                YoB = 2014
            },
            new Student()
            {
                Name = "Test 2012",
                City = "Quy Nhon",
                YoB = 2012
            },
            new Student()
            {
                Name = "Test 2012-1",
                City = "Quy Nhon",
                YoB = 2012
            }
        };
    }
}