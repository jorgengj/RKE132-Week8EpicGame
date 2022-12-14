string folderPath = @"C:\data\";
string heroFile = "heroes.txt";
string villainFile = "villains.txt"; 

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));


//string[] heroes = { "Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo" };
//string[] villains = {"Voldemort", "Joker", "Darth Vader", "Dracula", "Sauron" };
string[] weapon = { "magic wand", "plastic fork", "banana", "teeth", "Lego brick" };


string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the World!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random random = new Random();
    int randomIndex = random.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}