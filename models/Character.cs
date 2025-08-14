namespace dotnetSuperheroes;

public class Character
{
    public required string SuperHero { get; set; }
    public required string SecretIdentity { get; set; }
    public required List<SuperPower> SuperPowers { get; set; }
}