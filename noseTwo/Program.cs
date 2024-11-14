string[] toys = ["Barbie", "Bouncy Balls", "Cars", "Fidget Spinners", "Bratz"];
string[] names = ["Jasmine", "Mathtias", "Svea", "Femboy", "Markus"];
List<string> cities = [];

int[] number = [2, 2, 4, 7, 10];

string answer;

int exit = 0;


for (int i = 0; i < toys.Length; i++) 
{
    Console.WriteLine($"{names[i]} gav {toys[i]} {number[i]} stjärnor");
}

while (exit == 0)
{
    Console.WriteLine("Skriv in en stad (Skriv exit om du vill ut)");
    answer = Console.ReadLine();

    if (answer == "exit") 
    {
        exit++;
        cities.Remove("exit");
    }
    cities.Add(answer);
}

foreach (string i in cities)
{
    Console.WriteLine(i);
}


Console.ReadLine();
