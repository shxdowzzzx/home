using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace home
{
    struct Angajat
    {
        public string Name;
        public string Departament;
        public double Salariu;

        public Angajat(string nume, string departament, double salariu)
        {
            Name = nume;   
            Departament = departament;  
            Salariu = salariu;
        }
    }
    internal class Exer
    {
        public static void TipObiect()
        {
            var obj = 123;
            var objOne = 123.12;
            var objTwo = "hahaha";
            var objThree = 'a';
            object objFour = new { test = 1 };

            if (obj is int i && obj % 2 == 0)
            {
                Console.WriteLine($"Tipul este int,cu valoarea {i} si acest numar este par ");
            }
            else if (obj is int a && obj % 2 == 1)
            {
                Console.WriteLine($"Tipul este int,cu valoarea {a} si acest numar este impar ");
            }
            else
            {
                Console.WriteLine($"Tipul nu este int");
            }
            if (objOne is double d)
            {
                Console.WriteLine($"Tipul este double,cu valoarea {d}");
            }
            else
            {
                Console.WriteLine("Tipul nu este double");
            }
            if (objTwo is string s && objTwo.Length > 5)
            {
                Console.WriteLine($"Tipul este string,cu valoarea {s},si este sir lung");
            }
            else if (objTwo is string n && objTwo.Length < 5)
            {
                Console.WriteLine($"Tipul este string,cu valoarea {n},si este sir scurt");
            }
            else
            {
                Console.WriteLine("Tipul nu este string");
            }
            if (objThree is char c)
            {
                Console.WriteLine($"Tipul este char,cu valoarea {c}");
            }
            else
            {
                Console.WriteLine("Tipul nu este char");
            }
            if (objFour is not int && objFour is not string && objFour is not char && objFour is not double)
            {
                Console.WriteLine($"Tip necunoscut, cu valoarea {objFour}");
            }
        }

        public static void EvaluareCalificativ()
        {
            Console.WriteLine("Introdu nota de la test");
            int.TryParse(Console.ReadLine(), out int calificativ);
            if (calificativ == 1 || calificativ == 2 || calificativ == 3 || calificativ == 4)
            {
                Console.WriteLine("Necalificat");
            }
            else if (calificativ == 5 || calificativ == 6 || calificativ == 7)
            {
                Console.WriteLine("Suficient");
            }
            else if (calificativ == 8 || calificativ == 9)
            {
                Console.WriteLine("Bun");
            }
            else if (calificativ == 10)
            {
                Console.WriteLine("Excelent");
            }
            else
            {
                Console.WriteLine("Incearca din nou");
            }

        }

        public static void NouObiect()
        {

            FindObject("haha");
            FindObject(122);
            FindObject('a');
            FindObject(12.12);
            FindObject(new { test = 1 });

            void FindObject(object obj)
            {
                bool foundType = true;
                switch (obj)
                {
                    case string s when s.Length > 5:
                        Console.WriteLine($"Tipul este string cu valoare {s} si este sir lung");
                        break;
                    case string s when s.Length < 5:
                        Console.WriteLine($"Tipul este string cu valoare {s} si este sir scurt");
                        break;
                    case int i when i % 2 == 0:
                        Console.WriteLine($"Tipul este int cu valoare {i} si este numar par");
                        break;
                    case int i when i % 2 == 1:
                        Console.WriteLine($"Tipul este int cu valoare {i} si este numar impar");
                        break;
                    case double d:
                        Console.WriteLine($"Tipul este double cu valoare {d}");
                        break;
                    case char c:
                        Console.WriteLine($"Tipul este char cu valoare {c}");
                        break;
                    default:
                        foundType = false;
                        break;
                }
                if (!foundType)
                {
                    Console.WriteLine($"Obiect necunoscut cu valoarea {obj}");
                }
            }
        }

        public static void SuprafataObiect()
        {
            var firstArea = ("Cerc", 5d);
            var secondArea = ("Triunghi", 5d, 7d, 4d);
            var thirdArea = ("Patrat", 5d);
            var forthArea = ("Dreptungi", 5d, 7d);
            CalculareArea(firstArea);
            CalculareArea(secondArea);
            CalculareArea(thirdArea);
            CalculareArea(forthArea);
            CalculareArea(("test", 1));

            void CalculareArea(object obj)
            {
                bool yesType = true;
                switch (obj)
                {
                    case ("Cerc", double radius):
                        Console.WriteLine($"Aria cercului este {Math.PI * radius * radius}");
                        break;
                    case ("Triunghi", double a, double b, double c):
                        double s = (a + b + c) / 2;
                        Console.WriteLine($"Aria triunghiului este {Math.Sqrt(s * (s - a) * (s - b) * (s - c))}");
                        break;
                    case ("Patrat", double lat):
                        Console.WriteLine($"Aria patratului este {lat * lat}");
                        break;
                    case ("Dreptungi", double lat1, double lat2):
                        Console.WriteLine($"Aria dreptunghiului este {lat1 * lat2}");
                        break;
                    default:
                        yesType = false;
                        break;
                }
                if (!yesType) {
                    Console.WriteLine("Forma necunoscuta");
                }
            }
        }


        public static void HahaHa()
        {
            var arr = new int[5];
            int sum = 0;
            Console.WriteLine($"Cititi 5 elemente");
            arr[0] = int.Parse(Console.ReadLine());
            sum += arr[0];
            arr[1] = int.Parse(Console.ReadLine());
            sum += arr[1];
            arr[2] = int.Parse(Console.ReadLine());
            sum += arr[2];
            arr[3] = int.Parse(Console.ReadLine());
            sum += arr[3];
            arr[4] = int.Parse(Console.ReadLine());
            sum += arr[4];
            Console.WriteLine($"Suma medie este{sum / 5}");


        }

        public static void ArrayUni()
        {
            Console.WriteLine("Introdu numarul de studenti");
            int NrStud = int.Parse(Console.ReadLine());
            double [] note = new double[NrStud];
            double sum = 0;
            
            for (int i = 0; i < NrStud; i++)
            {
                
                Console.WriteLine($"\nNota studentului {i + 1} este:");
                
                    note[i] = double.Parse(Console.ReadLine());
              
                
                sum += note[i]; 
            }
           
            foreach (double nota in note)
            {
                Console.WriteLine($"\nNota este {nota}");
            }

            Console.WriteLine($"\nNota medie este {sum / NrStud}");
            


        }

        public static void AngajatArray()
        {
            

        const int NrAngajat = 3;
        Angajat[] angajati = new Angajat[NrAngajat];
        double sum = 0;
            for(int i = 0;i < NrAngajat; i++)
            {
                Console.WriteLine($"Introdu datele despre anagajati {i+1}");

                Console.WriteLine($"Nume: ");
                string nume = Console.ReadLine();

                Console.WriteLine($"Departament: ");
                string departament = Console.ReadLine();

                Console.WriteLine($"Salariu: ");
                double salariu = double.Parse(Console.ReadLine());

                angajati [i]  = new Angajat(nume, departament , salariu);
            }
            foreach(var angajat in angajati)
            {
                sum += angajat.Salariu;
            }
            double SumMed = sum / NrAngajat;

            Console.WriteLine($"Salariul mediu este {SumMed}");
            Console.WriteLine("\nAngajaii cu salariul mai mare decât media:");
            foreach (var angajat in angajati)
            {
                if(angajat.Salariu > SumMed)
                {
                    Console.WriteLine($"Anagajatul: {angajat.Name}, Departamentul: {angajat.Departament}, Salariul: {angajat.Salariu}");
                }
            }



        }

        public static void NrPar()
        {
            
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            
            for (int i = n; i <= x; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
                
                
            }
        }

        public static void WhileA()
        {
            int n;
            Console.WriteLine("Introduceti numere(0 pentru a opri programul)");
            while (true)
            {
                Console.WriteLine("Numar: ");
                n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    Console.WriteLine("Sa inchis programul");
                    break;
                }
            }
        }

        public static void CitestFile()
        {
            using (var file1 = File.Create("C:\\file1.txt")) { }
            using (var file2 = File.Create("C:\\file2.txt")) { }
            string contentOne = File.ReadAllText("C:\\file1.txt");
            File.WriteAllText("C:\\file1.txt", "Primul continut");
            File.WriteAllText("C:\\file2.txt", "Al doilea continut");

            string contenTwo = File.ReadAllText("C:\\file2.txt");
            if (contentOne.Equals(contenTwo))
            {
                Console.WriteLine("Textul din fisiere este egal");
            }
            else
            {
                Console.WriteLine("Textul din fisiere nu este egal");
            }

        
        }

        public static void DirectoryF() 
        {
            string directoryPath = "C:\\SourceFolder";
            string backupFolder = "C:\\BackupFolder";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            string[] files = { "file1.txt", "file2.txt", "file3.txt" };
            foreach (var fileName in files)
            {
                string filePath = Path.Combine(directoryPath, fileName);
                File.WriteAllText(filePath, $"Acesta este fișierul {fileName}");
            }
            if (!Directory.Exists(backupFolder))
            {
                Directory.CreateDirectory(backupFolder);
            }
            foreach (var fileName in files)
            {
                string sourceFilePath = Path.Combine(directoryPath, fileName);
                string destinationFilePath = Path.Combine(backupFolder, fileName);
                File.Move(sourceFilePath, destinationFilePath);
            }
            Console.WriteLine("Fisierele din BackupFolder:");
            string[] movedFiles = Directory.GetFiles(backupFolder);
            foreach (var filePath in movedFiles)
            {
                Console.WriteLine(Path.GetFileName(filePath));
            }

        }
    }
}



