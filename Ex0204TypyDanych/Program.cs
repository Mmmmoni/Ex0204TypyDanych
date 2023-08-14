using System;

namespace Ex0204TypyDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witam w zadaniach z lekcji 4., tygodnia 2..");
            Console.WriteLine("1. Zadanie pierwsze, zdefiniowane w osobnej klasie User.cs.");

            User exampleUser1 = new User() { Name = "Monika", Surname = "Es", Age = 150, Gender = 'K', Pesel = "99999999999", Id = 2509324094 };

            Console.WriteLine(exampleUser1.Name);
            Console.WriteLine(exampleUser1.Surname);
            Console.WriteLine(exampleUser1.Age);
            Console.WriteLine(exampleUser1.Gender);
            Console.WriteLine(exampleUser1.Pesel);
            Console.WriteLine(exampleUser1.Id);
            Console.WriteLine("");

            User exampleUser2 = new User() { Name = "XAEA-12", Surname = "El-Musk", Age = 0, Gender = 'M', Pesel = "01111111111", Id = 5 };

            Console.WriteLine(exampleUser2.Name);
            Console.WriteLine(exampleUser2.Surname);
            Console.WriteLine(exampleUser2.Age);
            Console.WriteLine(exampleUser2.Gender);
            Console.WriteLine(exampleUser2.Pesel);
            Console.WriteLine(exampleUser2.Id);
            Console.WriteLine("");

            Console.WriteLine("2. Zadanie drugie.");

            char first = 'A';
            char second = 'B';
            char third = 'C';

            Console.WriteLine($"{first}{second}{third}");

            char[] chars = { third, second, first };
            Console.WriteLine(chars);
            Console.WriteLine("");

            Console.WriteLine("3. Zadanie trzecie. Liczymy przekątną prostokąta!");
            Console.WriteLine("Podaj bok a prostokąta:");

            string sideA = Console.ReadLine();

            double chosenSideA = 0;
            double.TryParse(sideA, out chosenSideA);

            Console.WriteLine("Podaj bok b prostokąta:");

            string sideB = Console.ReadLine();

            double chosenSideB = 0;
            double.TryParse(sideB, out chosenSideB);

            Console.WriteLine($"Przekątna prostokąta o bokach {chosenSideA} oraz {chosenSideB} wynosi: {Math.Pow(Math.Pow(chosenSideA, 2) + Math.Pow(chosenSideB, 2), 0.5)}");
            Console.WriteLine("");

            Console.WriteLine("4. Zadanie czwarte.");
            int numberA = 0;
            string nameB;
            double numberC = 0;

            numberA = 10;
            nameB = "Szkoła Dotneta";
            numberC = 12.5;

            Console.WriteLine($"{numberA}, {nameB}, {numberC}");
            Console.WriteLine("");

            Console.WriteLine("5. Zadanie piąte, pomocnieczo zdefiniowane w osobnej klasie Helpers.cs.");
            Console.WriteLine("Witamy w kreatorze nowego użytkownika Diety NoBugs.");
            Console.WriteLine("Prosimy o podanie kilku danych osobistych w celu idealnego dopasowania produktu do Państwa oczekiwań!");

            Console.WriteLine("Na początek kilka formalności, podaj imię:");
            string nameChoice = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko:");
            string surnameChoice = Console.ReadLine();

            Console.WriteLine("Podaj numer telefonu:");
            string phoneNumberChoice = Console.ReadLine();

            Console.WriteLine("Podaj e-mail:");
            string emailChoice = Console.ReadLine();

            Console.WriteLine("Podaj wiek:");
            string ageChoice = Console.ReadLine();
            byte chosenAge = 0;
            Byte.TryParse(ageChoice, out chosenAge);

            Console.WriteLine("Podaj wzrost:");
            string heightChoice = Console.ReadLine();
            double chosenHeight = 0.0d;
            Double.TryParse(heightChoice, out chosenHeight);

            Console.WriteLine("Podaj wage:");
            string weightChoice = Console.ReadLine();
            double chosenWeight = 0.0d;
            Double.TryParse(weightChoice, out chosenWeight);

            Console.WriteLine("Podaj plec (wpisz 'K' lub 'M'):");
            string genderChoice = Console.ReadLine();
            char chosenGender = '\x0000';
            Char.TryParse(genderChoice, out chosenGender);

            Console.WriteLine("Czy korzystałeś już z naszej diety (wpisz 'true' dla tak, lub 'false' dla nie)?:");
            string wasMemberChoice = Console.ReadLine();
            bool chosenWasMember = false;
            Boolean.TryParse(wasMemberChoice, out chosenWasMember);

            Console.WriteLine("Ile kilogramów chcesz przytyć lub schudnąć?:");
            Console.WriteLine("(Jeśli chcesz schudnąć poprzeć liczbę minusem '-', natomiast jeśli chcesz przytyć wpisz liczbe bez znaku poprzedzającego)");
            string weightGoalChoice = Console.ReadLine();
            int chosenWeightGoal = 0;
            Int32.TryParse(weightGoalChoice, out chosenWeightGoal);

            Console.WriteLine("Ile złotych wydajesz dziennie na jedzenie?:");
            string dietCostChoice = Console.ReadLine();
            decimal chosenDietCost = 0.0m;
            Decimal.TryParse(dietCostChoice, out chosenDietCost);

            Console.WriteLine("");
            Console.WriteLine("Dziękujemy, poniższe dane zostały przesłane do firmy NoBugs Diet:");
            Console.WriteLine($"Imie:{nameChoice}");
            Console.WriteLine($"Nazwisko:{surnameChoice}");
            Console.WriteLine($"Numer telefonu:{phoneNumberChoice}");
            Console.WriteLine($"E-mail:{emailChoice}");
            Console.WriteLine($"Wiek:{chosenAge}");
            Console.WriteLine($"Wzrost:{chosenHeight}");
            Console.WriteLine($"Waga:{chosenWeight}");
            Console.WriteLine($"Płeć:{chosenGender}");
            Console.WriteLine($"Czy już korzystałeś z naszej diety:{chosenWasMember}");
            Console.WriteLine($"Różnica wagi jaką chce osiagnac:{chosenWeightGoal}");
            Console.WriteLine($"Koszt wyżywienia na dzień w pln:{chosenDietCost}");
            Console.WriteLine("");
            Console.WriteLine("UWAGA! W celu zmiany danych prosimy o skontaktowanie się z działem obsługi klienta, nr tel. 0-700...");
            Console.WriteLine("");
            Console.WriteLine("Życzę Szkole Dotneta wszystkiego najlepszego!");
            Console.WriteLine("");
        }
    }
}