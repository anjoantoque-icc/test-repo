using static QPal.Program;

namespace QPal
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<QPalInfo> listOfQPal = new List<QPalInfo>()
            {
                new QPalInfo { Name = "James Thor", Department = "DEV"},
                new QPalInfo { Name = "Charles Daitol", Department = "QA"},
                new QPalInfo { Name = "John Vince Azares", Department = "DEV"},
                new QPalInfo { Name = "BILOY", Department = "DEV"},
                new QPalInfo { Name = "Vinceji", Department = "BAD"},
            };
            Console.WriteLine("Welcome to QPAL, where asking questions is good, but asking the right person is AWESOME.");  

            Console.WriteLine("\nLIST OF QPAL\n");
            Console.WriteLine(listOfQPal.JoinQPal());

            Console.WriteLine("\"Through unwavering composure and clarity of thought,\nour QPALs have truly mastered the art of controlling their emotions.\"");
            Console.WriteLine("\n");
            Console.WriteLine("Please select your QPAL: ");
            Console.ReadLine();
        }

        public class QPalInfo()
        {
            public string? Name { get; set; }
            public string? Department { get; set; }
        }
    }

    public static class ExtensionMethod
    {
        public static string JoinQPal(this List<QPalInfo> qpalInfo)
        {
            string result = string.Empty;

            foreach (QPalInfo qpal in qpalInfo)
            {
                result += string.Format("{0}) Name: {1}, Department: {2}\n", qpalInfo.IndexOf(qpal) + 1, qpal.Name, qpal.Department);
            }

            return result;
        }
    }
}
