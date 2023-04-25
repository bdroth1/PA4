namespace ConsoleApp
{
     class JackSparrow : Character
{
    public JackSparrow()
    {
        Name = "Jack Sparrow";
        MaxPower = new Random().Next(1, 101);
        Health = 100;
        AttackStrength = new Random().Next(1, MaxPower + 1);
        DefensePower = new Random().Next(1, MaxPower + 1);
    }

    public override string AttackName => "Distract opponent";
}
}