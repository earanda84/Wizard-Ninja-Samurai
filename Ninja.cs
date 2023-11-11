class Ninja : Human
{
    public string Nombre { get; set; }

    public Ninja(string nombre, int dexterity = 75) : base(nombre, 80, 100, dexterity, 90)
    {
        Nombre = nombre;
        Dexterity = dexterity;

    }

    public override int Attack(Human target)
    {
        // return base.Attack(target);
        // Daño igual a la destreza
        int damage = target.Dexterity;
        // Numero aleatorio
        Random rand = new Random();
        // Numero aleatorio entre 100
        int randomNumber = rand.Next(100);
        Console.WriteLine(randomNumber);
        // Evalúa si el numero menor o igual 20
        if (randomNumber <= 20)
        {
            Console.WriteLine($"Causaste un daño adicional de 10 puntos");
            // suma 10 puntos adicionales al daño si menor o igual a 20
            damage += 10;
        }

        // reduce la salud del objetivo en el daño ocasionado.
        target.Health -= damage;

        Console.WriteLine($"Daño sufrido por el contricante {target.Name} es de {damage}, su salud queda en {target.Health}");

        return target.Health;

    }

    public (int NinjaHealth, int TargetHealth) Steal(Human target)
    {
        // Robo de salud
        int steal = 5;
        // Reduce la salud del objetivo
        target.Health -= steal;
        // Aumenta la salud del Ninja en el daño ocasionado
        Health += 5;

        Console.WriteLine($"El robo sufrido por {target.Name} es de {steal}, su salud disminuyo a {target.Health}, la nueva salud del ninja {Nombre} es de {Health}");
        return (Health, target.Health);
    }
}