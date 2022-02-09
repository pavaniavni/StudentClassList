namespace StudentClassList
{
    public class StudentClass
    {
        static void Main(string[] args)
        {
            
            List<String> SIds = new List<String>();
            
            List<string> SNames = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Student ID : ");
                SIds.Add(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Student Name : ");
                SNames.Add(Console.ReadLine());
                Console.WriteLine();
                
            }

            Console.WriteLine();
            Console.WriteLine("The Student Id is : ");
            foreach (var s in SIds)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.WriteLine("The Student Names are :");
            foreach (var s1 in SNames)
            {
                Console.WriteLine(s1);

            }

            
        }
    }
}
