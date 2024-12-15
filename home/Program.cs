namespace home
{

    /* enum AnStudii
     {
         I = 1,
         II,
         III,
         IV,
         V,
         VI
     }
     struct Student
     {
         public string Name;
         public int Varsta;
         public string Specializare;
         public AnStudii An;

         public void AfisareInfo()
         {
             Console.WriteLine("Informatii despre student:");
             Console.WriteLine($"Nume: {Name}");
             Console.WriteLine($"Varsta: {Varsta}");
             Console.WriteLine($"Specializare: {Specializare}");
             Console.WriteLine($"An de studii: {An}");
         }
     }*/
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Introdu data de nastere dd.MM.yyyy");
            var dateOne = Console.ReadLine();
            var dateTimeOne = DateTime.ParseExact(dateOne, "dd.MM.yyyy", null);
            var dateTwo = (DateTime.UtcNow);
            var difference = (dateTwo - dateTimeOne).Days / 365;
            
            Console.WriteLine($"Varsta utilizatorului este de {difference} ani.");

            Student student;

            Console.Write("Introduce numele studentului: ");
            student.Name = Console.ReadLine();

            
            Console.Write("Introduce varsta studentului: ");
            student.Varsta = int.Parse(Console.ReadLine());

            
            Console.Write("Introduce specializarea studentului: ");
            student.Specializare = Console.ReadLine();

            
            Console.Write("Introduce anul de studii (I, II, III, IV, V, VI): ");
            student.An = (AnStudii)Enum.Parse(typeof(AnStudii), Console.ReadLine());

          
            Console.WriteLine();
            student.AfisareInfo();/*

        }
    }*/
            Exer.TipObiect();
        }
    }
}