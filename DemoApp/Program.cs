// DemoApp — версія 1.1
// Консольний застосунок: запитує ім'я та вік користувача,
// виводить привітання та інформацію про користувача.

Console.Write("Введіть ваше ім'я: ");
string? userName = Console.ReadLine();

Console.Write("Введіть ваш вік: ");
string? ageInput = Console.ReadLine();

Console.WriteLine($"Вітаю {userName}!");

if (int.TryParse(ageInput, out int age))
{
    string status = age >= 18 ? "повнолітній" : "неповнолітній";
    Console.WriteLine($"Користувач: {userName}, вік: {age} ({status}).");
}
else
{
    Console.WriteLine("Вік введено некоректно. Будь ласка, введіть число.");
}
