int heroHP = 10;
int monsterHP = 10;
Random attDmg = new Random();

int currentAttDmgOfHero = 0;
int currentAttDmgOfMonster = 0;

do {
    currentAttDmgOfHero = attDmg.Next(1, 10);
    monsterHP -= currentAttDmgOfHero;

    Console.WriteLine($"Monster was damaged and lost {currentAttDmgOfHero} health and now has {monsterHP} health");
    

    if (monsterHP <= 0) {
        break;
    }

    currentAttDmgOfMonster = attDmg.Next(1,10);
    heroHP -= currentAttDmgOfMonster;

    Console.WriteLine($"Hero was damaged and lost {currentAttDmgOfMonster} health and now has {heroHP} health");

    if (heroHP <= 0) {
        break;
    }

} while (heroHP > 0 || monsterHP > 0);

Console.WriteLine(heroHP > monsterHP ? "Hero wins!" : "Monster wins!");