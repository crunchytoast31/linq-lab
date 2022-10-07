namespace linq_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 100, 949, 3764, 2942 };

            int highest = nums.Max();
            Console.WriteLine(highest);

            int lowest = nums.Min();
            Console.WriteLine(lowest);

            int secondhighest = nums.Where(x => x < highest).Max();
            Console.WriteLine(secondhighest);

            List<int> evenNums = nums.Where(num => num % 2 == 0).ToList();
            PrintList(evenNums);

            Console.WriteLine();

            nums = nums.OrderByDescending(n => n).ToArray();

            foreach (int value in nums)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            List<int> between = nums.Where(s => s >= 10 && s <= 100).ToList();
            PrintList(between);

            Console.WriteLine();

            List<int> Between = nums.Where(s => s >= 100000 && s <= 999999).ToList();
            PrintList(Between);

            List<Students> students = new List<Students>();
            students.Add(new Students("Jimmy", 13));
            students.Add(new Students("Hannah Baker", 21));
            students.Add(new Students("Justin", 30));
            students.Add(new Students("Sarah", 53));
            students.Add(new Students("Hannibal", 15));
            students.Add(new Students("Phillip", 16));
            students.Add(new Students("Maria", 63));
            students.Add(new Students("Abe", 33));
            students.Add(new Students("Curtis", 10));

            List<Students> studentsOver21 = students.Where(c => c.Age > 21).ToList();
            PrintNames(studentsOver21);


            int oldestStudent = students.Max(c => c.Age);
            Students OldestStudentName = students.Where(s => s.Age == oldestStudent).ToList().First();
            Console.WriteLine($"Oldest student: {OldestStudentName}");

            int YoungestStudent = students.Min(c => c.Age);
            Students YoungestStudentName = students.Where(s => s.Age == YoungestStudent).First();

            Console.WriteLine($"Youngest student: {YoungestStudent}");

            List<Students> over21 = students.Where(s => s.Age > 21 && s.Age % 2 == 0).ToList();
            Console.WriteLine("Over 21 and even age:");
            PrintNames(over21);

            List<Students> teenagers = students.Where(s => s.Age >= 13 && s.Age <= 19).ToList();
            Console.WriteLine("Teenage students:");
            PrintNames(teenagers);


            string vowels = "AEIOU";
            List<Students> studentNamesBeginWithVowel = new List<Students>();

            List<Students> studentVowelNames = students.Where(s => vowels.Contains(s.Name[0])).ToList();
            Console.WriteLine("Students names that begin with vowels.");
            PrintNames(studentVowelNames);

            List<Students> oldestStudentUnder25 = students.Where(s => s.Age <= 25).ToList();
            int oldestStudentUnder25Age = oldestStudentUnder25.Max(c => c.Age);
            Students oldestStudentUnder25Name = oldestStudentUnder25.Where(s => s.Age == oldestStudentUnder25Age).First();

            Console.WriteLine($"Oldest student under 25{oldestStudentUnder25Name.Name} and they are {oldestStudentUnder25Age} years old");




        }
        public static void PrintList(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                int num = input[i];
                Console.WriteLine($"{i}: {num}");
            }
        }

        public static void PrintNames(List<Students> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Students student = students[i];
                Console.WriteLine();
                Console.WriteLine($"Name:{student.Name} Age : {student.Age}");
            }
        }
    }


}