// for context see: https://learn.microsoft.com/en-gb/training/modules/csharp-do-while/3-exercise-challenge-do-while-statements

int herohealth = 10;
int monsterhealth = 10;

Random attack = new Random();

do
{
    int move = attack.Next(1, 11);
    monsterhealth = monsterhealth - move;
    Console.WriteLine($"{move} damage was dealt to the monster and now has {monsterhealth} health");

    if (monsterhealth <= 0) continue; // a good change from the microsoft solution

    move = attack.Next(1, 11);
    herohealth = herohealth - move;
    Console.WriteLine($"{move} damage was dealt to the hero and now has {herohealth} health");
} while (herohealth > 0 && monsterhealth > 0);

Console.WriteLine(herohealth > monsterhealth ? "Hero wins!" : "Monster wins!");
