Human human = new Human("Pedro", 50,10,55, 100);

Wizard wizard = new Wizard("Merlin");

wizard.Attack(human);

wizard.Heal(human);

Ninja ninja = new Ninja("Jet-li");

Console.WriteLine(ninja.Name);
Console.WriteLine(ninja.Strength);

ninja.Attack(human);
ninja.Steal(human);

Samurai samurai = new Samurai("Honda Tadakatsu");

Console.WriteLine(samurai.Name);

Human human1 = new Human("José", 50,10,55, 40);

samurai.Attack(human1);

Samurai samurai1 = new Samurai("Miyamoto Musashi", 100);

samurai1.Meditate();