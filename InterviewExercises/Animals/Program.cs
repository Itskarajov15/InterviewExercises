using Animals.Animals;
using Animals.Enums;

Animal wolf1 = new Wolf(70);
Animal wolf2 = new Wolf(70);
Animal rabbit1 = new Rabbit(30);
Animal rabbit2 = new Rabbit(30);
Animal bear1 = new Bear(100);
Animal bear2 = new Bear(100);

var animalsLifespan = new Dictionary<string, int>()
{
    {"wolf1", 1},
    {"wolf2", 1},
    {"rabbit1", 1},
    {"rabbit2", 1},
    {"bear1", 1},
    {"bear2", 1},
};

var randomNumber = new Random();
int days = 1;

while (wolf1.Energy > 0 || wolf2.Energy > 0 || rabbit1.Energy > 0 || rabbit2.Energy > 0
    || bear1.Energy > 0 || bear2.Energy > 0)
{
    wolf1.Feed(((Food)randomNumber.Next(6)).ToString());
    wolf2.Feed(((Food)randomNumber.Next(6)).ToString());
    rabbit1.Feed(((Food)randomNumber.Next(6)).ToString());
    rabbit2.Feed(((Food)randomNumber.Next(6)).ToString());
    bear1.Feed(((Food)randomNumber.Next(6)).ToString());
    bear2.Feed(((Food)randomNumber.Next(6)).ToString());

    days++;

    if (wolf1.Energy > 0)
    {
        animalsLifespan["wolf1"]++;
    }

    if (wolf2.Energy > 0)
    {
        animalsLifespan["wolf2"]++;
    }

    if (rabbit1.Energy > 0)
    {
        animalsLifespan["rabbit1"]++;
    }

    if (rabbit2.Energy > 0)
    {
        animalsLifespan["rabbit2"]++;
    }

    if (bear1.Energy > 0)
    {
        animalsLifespan["bear1"]++;
    }

    if (bear2.Energy > 0)
    {
        animalsLifespan["bear2"]++;
    }
}

Console.WriteLine($"The whole simulation was {days} days");

Console.WriteLine($"Wolf1: {animalsLifespan["wolf1"]}");
Console.WriteLine($"Wolf2: {animalsLifespan["wolf2"]}");
Console.WriteLine($"Rabbit1: {animalsLifespan["rabbit1"]}");
Console.WriteLine($"Rabbit2: {animalsLifespan["rabbit2"]}");
Console.WriteLine($"Bear1: {animalsLifespan["bear1"]}");
Console.WriteLine($"Bear2: {animalsLifespan["bear2"]}");

Console.WriteLine("Minimum lifespan for wolfs: ");
Console.WriteLine(animalsLifespan["wolf1"] > animalsLifespan["wolf2"] ? animalsLifespan["wolf2"] : animalsLifespan["wolf1"]);

Console.WriteLine("Minimum lifespan for rabbits: ");
Console.WriteLine(animalsLifespan["rabbit1"] > animalsLifespan["rabbit2"] ? animalsLifespan["rabbit2"] : animalsLifespan["rabbit1"]);

Console.WriteLine("Minimum lifespan for bears: ");
Console.WriteLine(animalsLifespan["bear1"] > animalsLifespan["bear2"] ? animalsLifespan["bear2"] : animalsLifespan["bear1"]);

Console.WriteLine("Average lifespan for wolfs: ");
Console.WriteLine((animalsLifespan["wolf1"] + animalsLifespan["wolf2"]) / 2);

Console.WriteLine("Average lifespan for rabbits: ");
Console.WriteLine((animalsLifespan["rabbit1"] + animalsLifespan["rabbit2"]) / 2);

Console.WriteLine("Average lifespan for bears: ");
Console.WriteLine((animalsLifespan["bear1"] + animalsLifespan["bear2"]) / 2);

Console.WriteLine("Maximum lifespan for wolfs: ");
Console.WriteLine(animalsLifespan["wolf1"] < animalsLifespan["wolf2"] ? animalsLifespan["wolf2"] : animalsLifespan["wolf1"]);

Console.WriteLine("Maximum lifespan for rabbits: ");
Console.WriteLine(animalsLifespan["rabbit1"] < animalsLifespan["rabbit2"] ? animalsLifespan["rabbit2"] : animalsLifespan["rabbit1"]);

Console.WriteLine("Maximum lifespan for bears: ");
Console.WriteLine(animalsLifespan["bear1"] < animalsLifespan["bear2"] ? animalsLifespan["bear2"] : animalsLifespan["bear1"]);