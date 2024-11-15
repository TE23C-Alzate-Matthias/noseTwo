// skriva string[] är att det är en array
// skriva List<string> är en lista

string[] toys = ["Barbie", "Bouncy Balls", "Cars", "Fidget Spinners", "Bratz"];
List<string> names = ["Jasmine", "Mathtias", "Svea", "Femboy", "Markus"];
List<string> cities = [];

List<int> number = [2, 2, 4, 7, 10];

string answer;

int exit = 0;


for (int i = 0; i < toys.Length; i++) 
{
    Console.WriteLine($"{names[i]} gav {toys[i]} {number[i]} stjärnor");
}

while (exit == 0)
{
    Console.WriteLine("\nSkriv in en stad (Skriv exit om du vill ut)");
    answer = Console.ReadLine();

    cities.Add(answer);

    if (answer == "exit") 
    {
        exit++;
        cities.Remove("exit");
    }

}

foreach (string i in cities)
{
    Console.WriteLine(i);
}

Console.ReadLine();