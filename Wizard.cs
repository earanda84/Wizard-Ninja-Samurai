class Wizard : Human
{
    // public int Intelligence { get; set; }
    // public int Health { get; set; }
    public string Nombre { get; set; }
    public Wizard(string nombre, int intelligence = 100, int health = 50) : base(nombre, 100, intelligence, 20, health)
    {
        Nombre = nombre;
        Intelligence = intelligence;
        Health = health;
    }

    // Sobreescribe método Attack de clase Human
    public override int Attack(Human target)
    {
        // Daño que inflinge Mago
        int damage = 3 * target.Intelligence;
        // Salud del objetivo menos el daño
        target.Health -= damage;
        // Salud recuperada por el Mago
        Health += damage;

        Console.WriteLine($"Daño infligido por el mago {Name} al Humano {target.Name} es de {target.Health}");
        return target.Health;
    }

    // Método de invocación por parte de Humano
    public int Heal(Human target)
    {
        // Recuperación Humano que lo invoque
        int recovery = 3 * target.Intelligence;
        // Salud recuperada por Humano
        target.Health += recovery;

        Console.WriteLine($"Salud recuperada por el Humano {target.Name} es de {target.Health}");
        return target.Health;
    }

}