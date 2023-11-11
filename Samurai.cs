class Samurai : Human
{
    public string Nombre { get; set; }

    public Samurai(string nombre, int health = 200) : base(nombre, 90, 80, 65, health)
    {
        Nombre = nombre;
        Health = health;
    }

    public override int Attack(Human target)
    {
        // Evalúa si la salud del objetivo es menor a 50
        if (target.Health < 50)
        {
            // Reduce la salud del objetivo a 0
            target.Health = 0;

            Console.WriteLine($"La salud del objetivo {target.Name} es {target.Health}, ha quedado fuera del juego !");
            return target.Health;
        }

        return target.Health;
    }

    public int Meditate()
    {
        // Recuperación de salud
        int recovery = 200;

        // Evalúa si la salud es menor a 150
        if (Health < 150)
        {
            Console.WriteLine($"La salud del Samurai {Nombre} es de {Health}");

            // Asigna el valor de recuperación de la salud
            Health = recovery;

            Console.WriteLine($"El samurai ha entrado {Nombre} ha entrado en modo meditación y ha recuperado su salud, la cual ahora es de {Health}");

            return Health;
        }

        return Health;
    }
}