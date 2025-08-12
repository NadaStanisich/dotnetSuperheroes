var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Character> justiceleague = new List<Character>();

Character Superman = new Character();
Superman.SuperHero = "Superman";
Superman.SecretIdentity = "Clark Kent";
Superman.SuperPowers = new List<SuperPower>{
    new() { Name = "Flight", Description = "The ability to defy gravity and propel oneself through the air unassisted.", IsMagic = false },
    new() { Name = "Super Strength", Description = "The ability to exert force and lift heavy objects beyond one's natural strength.", IsMagic = false },
    new() { Name = "Heat Vision", Description = "The ability to emit beams of concentrated heat from one's eyes.", IsMagic = false },
    new() { Name = "X-Ray Vision", Description = "The ability to see through solid objects.", IsMagic = false },
    new() { Name = "Super Speed", Description = "The ability to move faster than the eye can perceive.", IsMagic = false },
    new() { Name = "Super Hearing", Description = "The ability to hear sounds from a great distance.", IsMagic = false },
    new() { Name = "Invulnerability", Description = "The ability to be immune to one or more forms of physical, mental, and spiritual damage and influence.", IsMagic = false },
    new() { Name = "Super Breath", Description = "The ability to inhale and exhale huge gusts of wind from the mouth.", IsMagic = false },
    new() { Name = "Super Vision", Description = "The ability to see farther and with greater accuracy than a normal human.", IsMagic = false },
    new() { Name = "Superhuman Stamina", Description = "The ability to maintain continuous physical actions for an extended period of time.", IsMagic = false },
    new() { Name = "Superhuman Agility", Description = "The ability to maintain perfect balance, equilibrium, and dexterity.", IsMagic = false },
    new() { Name = "Superhuman Reflexes", Description = "The ability to react faster than a normal human.", IsMagic = false },
    new() { Name = "Superhuman Senses", Description = "The ability to see, smell, taste, feel, and/or hear more than a normal human.", IsMagic = false },
    new() { Name = "Superhuman Memory", Description = "The ability to remember things far beyond the average human.", IsMagic = false },
    new() { Name = "Superhuman Intelligence", Description = "The ability to have intelligence far beyond the average human.", IsMagic = false }
};

Character Batman = new Character();
Batman.SuperHero = "Batman";
Batman.SecretIdentity = "Bruce Wayne";
Batman.SuperPowers = new List<SuperPower>{
    new() { Name = "Genius-Level Intellect", Description = "The ability to have intelligence far beyond the average human.", IsMagic = false },      
    new() { Name = "Peak Human Conditioning", Description = "The ability to have strength, speed, stamina, and agility at the peak of human potential.", IsMagic = false },
    new() { Name = "Master Martial Artist", Description = "The ability to have mastered all forms of hand-to-hand combat.", IsMagic = false },
    new() { Name = "Master Detective", Description = "The ability to have mastered all forms of detective skills.", IsMagic = false },
    new() { Name = "Master Acrobat", Description = "The ability to have mastered all forms of acrobatics.", IsMagic = false },
    new() { Name = "Master Inventor", Description = "The ability to have mastered all forms of inventing.", IsMagic = false },
    new() { Name = "Master Escapologist", Description = "The ability to have mastered all forms of escaping.", IsMagic = false },
    new() { Name = "Master Marksman", Description = "The ability to have mastered all forms of marksmanship.", IsMagic = false },
    new() { Name = "Master Swordsman", Description = "The ability to have mastered all forms of swordsmanship.", IsMagic = false },
    new() { Name = "Master Strategist", Description = "The ability to have mastered all forms of strategy.", IsMagic = false },
    new() { Name = "Master Tactician", Description = "The ability to have mastered all forms of tactics.", IsMagic = false },
    new() { Name = "Master Acrobat", Description = "The ability to have mastered all forms of acrobatics.", IsMagic = false },
    new() { Name = "Master of Stealth", Description = "The ability to have mastered all forms of stealth.", IsMagic = false },
    new() { Name = "Master of Disguise", Description = "The ability to have mastered all forms of disguise.", IsMagic = false },
    new() { Name = "Master of Deception", Description = "The ability to have mastered all forms of deception.", IsMagic = false },
    new() { Name = "Master of Intimidation", Description = "The ability to have mastered all forms of intimidation.", IsMagic = false },
    new() { Name = "Master of Interrogation", Description = "The ability to have mastered all forms of interrogation.", IsMagic = false },
    new() { Name = "Master of Demolitions", Description = "The ability to have mastered all forms of demolitions.", IsMagic = false },
    new() { Name = "Master of Medicine", Description = "The ability to have mastered all forms of medicine.", IsMagic = false },
    new() { Name = "Master of Hypnosis", Description = "The ability to have mastered all forms of hypnosis.", IsMagic = false },
    new() { Name = "Master of Tracking", Description = "The ability to have mastered all forms of tracking.", IsMagic = false },
    new() { Name = "Master of Driving", Description = "The ability to have mastered all forms of driving.", IsMagic = false },
    new() { Name = "Master of Piloting", Description = "The ability to have mastered all forms of piloting.", IsMagic = false },
    new() { Name = "Master of Throwing", Description = "The ability to have mastered all forms of throwing.", IsMagic = false },
    new() { Name = "Master of Weapons", Description = "The ability to have mastered all forms of weapons.", IsMagic = false },
    new() { Name = "Master of Firearms", Description = "The ability to have mastered all forms of firearms.", IsMagic = false },
    new() { Name = "Master of Technology", Description = "The ability to have mastered all forms of technology.", IsMagic = false },
    new() { Name = "Master of Business", Description = "The ability to have mastered all forms of business.", IsMagic = false }
};  

Character Zatanna = new Character();
Zatanna.SuperHero = "Zatanna";
Zatanna.SecretIdentity = "Zatanna Zatara";
Zatanna.SuperPowers = new List<SuperPower>{
    new() { Name = "Magic", Description = "The ability to use magic.", IsMagic = true }
};

Character TheFlash = new Character();
TheFlash.SuperHero = "The Flash";
TheFlash.SecretIdentity = "Barry Allen";
TheFlash.SuperPowers = new List<SuperPower>{
    new() { Name = "Super Speed", Description = "The ability to move faster than the eye can perceive.", IsMagic = false },
    new() { Name = "Superhuman Stamina", Description = "The ability to maintain continuous physical actions for an extended period of time.", IsMagic = false },
    new() { Name = "Superhuman Agility", Description = "The ability to maintain perfect balance, equilibrium, and dexterity.", IsMagic = false },
    new() { Name = "Superhuman Reflexes", Description = "The ability to react faster than a normal human.", IsMagic = false }
};

Character GreenLantern = new Character();
GreenLantern.SuperHero = "Green Lantern";
GreenLantern.SecretIdentity = "Hal Jordan";
GreenLantern.SuperPowers = new List<SuperPower>{
    new() { Name = "Flight", Description = "The ability to defy gravity and propel oneself through the air unassisted.", IsMagic = false },
    new() { Name = "Super Strength", Description = "The ability to exert force and lift heavy objects beyond one's natural strength.", IsMagic = false },
    new() { Name = "Energy Projection", Description = "The ability to create and project energy.", IsMagic = false },
    new() { Name = "Energy Constructs", Description = "The ability to create objects out of energy.", IsMagic = false },
    new() { Name = "Force Field", Description = "The ability to create a field of energy that protects the user.", IsMagic = false },
    new() { Name = "Energy Absorption", Description = "The ability to absorb energy.", IsMagic = false },
    new() { Name = "Energy Manipulation", Description = "The ability to manipulate energy.", IsMagic = false },
    new() { Name = "Energy Resistance", Description = "The ability to be resistant to energy.", IsMagic = false }
};

Character WonderWoman = new Character();
WonderWoman.SuperHero = "Wonder Woman";
WonderWoman.SecretIdentity = "Diana Prince";
WonderWoman.SuperPowers = new List<SuperPower>{
    new() { Name = "Super Strength", Description = "The ability to exert force and lift heavy objects beyond one's natural strength.", IsMagic = false },
    new() { Name = "Superhuman Stamina", Description = "The ability to maintain continuous physical actions for an extended period of time.", IsMagic = false },
    new() { Name = "Superhuman Agility", Description = "The ability to maintain perfect balance, equilibrium, and dexterity.", IsMagic = false },
    new() { Name = "Superhuman Reflexes", Description = "The ability to react faster than a normal human.", IsMagic = false },
    new() { Name = "Superhuman Speed", Description = "The ability to move faster than the eye can perceive.", IsMagic = false },
    new() { Name = "Flight", Description = "The ability to defy gravity and propel oneself through the air unassisted.", IsMagic = false },
    new() { Name = "Invulnerability", Description = "The ability to be immune to one or more forms of physical, mental, and spiritual damage and influence.", IsMagic = false },
    new() { Name = "Accelerated Healing", Description = "The ability to heal at a faster rate than a normal human.", IsMagic = false }
};

Character GreenArrow = new Character();
GreenArrow.SuperHero = "Green Arrow";
GreenArrow.SecretIdentity = "Oliver Queen";
GreenArrow.SuperPowers = new List<SuperPower>{
    new() { Name = "Peak Human Conditioning", Description = "The ability to have strength, speed, stamina, and agility at the peak of human potential.", IsMagic = false },
    new() { Name = "Master Archer", Description = "The ability to have mastered all forms of archery.", IsMagic = false },
    new() { Name = "Master Martial Artist", Description = "The ability to have mastered all forms of hand-to-hand combat.", IsMagic = false },
    new() { Name = "Master Swordsman", Description = "The ability to have mastered all forms of swordsmanship.", IsMagic = false },
    new() { Name = "Master Acrobat", Description = "The ability to have mastered all forms of acrobatics.", IsMagic = false },
    new() { Name = "Master Marksman", Description = "The ability to have mastered all forms of marksmanship.", IsMagic = false },
    new() { Name = "Master Tactician", Description = "The ability to have mastered all forms of tactics.", IsMagic = false },
    new() { Name = "Master of Stealth", Description = "The ability to have mastered all forms of stealth.", IsMagic = false },
    new() { Name = "Master of Disguise", Description = "The ability to have mastered all forms of disguise.", IsMagic = false },
    new() { Name = "Master of Throwing", Description = "The ability to have mastered all forms of throwing.", IsMagic = false },
    new() { Name = "Master of Weapons", Description = "The ability to have mastered all forms of weapons.", IsMagic = false },
    new() { Name = "Master of Firearms", Description = "The ability to have mastered all forms of firearms.", IsMagic = false },
    new() { Name = "Master of Technology", Description = "The ability to have mastered all forms of technology.", IsMagic = false },
    new() { Name = "Master of Business", Description = "The ability to have mastered all forms of business.", IsMagic = false }
};

Character Aquaman = new Character();
Aquaman.SuperHero = "Aquaman";
Aquaman.SecretIdentity = "Arthur Curry";
Aquaman.SuperPowers = new List<SuperPower>{
    new() { Name = "Super Strength", Description = "The ability to exert force and lift heavy objects beyond one's natural strength.", IsMagic = false },
    new() { Name = "Superhuman Stamina", Description = "The ability to maintain continuous physical actions for an extended period of time.", IsMagic = false },
    new() { Name = "Superhuman Agility", Description = "The ability to maintain perfect balance, equilibrium, and dexterity.", IsMagic = false },
    new() { Name = "Superhuman Reflexes", Description = "The ability to react faster than a normal human.", IsMagic = false },
    new() { Name = "Superhuman Speed", Description = "The ability to move faster than the eye can perceive.", IsMagic = false },
    new() { Name = "Invulnerability", Description = "The ability to be immune to one or more forms of physical, mental, and spiritual damage and influence.", IsMagic = false },
    new() { Name = "Accelerated Healing", Description = "The ability to heal at a faster rate than a normal human.", IsMagic = false },
    new() { Name = "Underwater Breathing", Description = "The ability to breathe underwater.", IsMagic = false },
    new() { Name = "Enhanced Senses", Description = "The ability to have senses far beyond the average human.", IsMagic = false },
    new() { Name = "Telepathy", Description = "The ability to communicate with others through the mind.", IsMagic = false },
    new() { Name = "Animal Control", Description = "The ability to control animals.", IsMagic = false },
    new() { Name = "Marine Telepathy", Description = "The ability to communicate with marine life through the mind.", IsMagic = false },
};  
  
Character Shazam = new Character();
Shazam.SuperHero = "Shazam";
Shazam.SecretIdentity = "Billy Batson";
Shazam.SuperPowers = new List<SuperPower>{
    new() { Name = "Super Strength", Description = "The ability to exert force and lift heavy objects beyond one's natural strength.", IsMagic = true },
    new() { Name = "Superhuman Stamina", Description = "The ability to maintain continuous physical actions for an extended period of time.", IsMagic = true },
    new() { Name = "Superhuman Agility", Description = "The ability to maintain perfect balance, equilibrium, and dexterity.", IsMagic = true },
    new() { Name = "Superhuman Reflexes", Description = "The ability to react faster than a normal human.", IsMagic = true },
    new() { Name = "Superhuman Speed", Description = "The ability to move faster than the eye can perceive.", IsMagic = true },
    new() { Name = "Flight", Description = "The ability to defy gravity and propel oneself through the air unassisted.", IsMagic = true },
    new() { Name = "Invulnerability", Description = "The ability to be immune to one or more forms of physical, mental, and spiritual damage and influence.", IsMagic = true },
    new() { Name = "Accelerated Healing", Description = "The ability to heal at a faster rate than a normal human.", IsMagic = true },
    new() { Name = "Magic", Description = "The ability to use magic.", IsMagic = true }
};  

justiceleague.Add(Superman);
justiceleague.Add(Batman);
justiceleague.Add(Zatanna);
justiceleague.Add(TheFlash);
justiceleague.Add(GreenLantern);
justiceleague.Add(WonderWoman);
justiceleague.Add(GreenArrow);
justiceleague.Add(Aquaman);
justiceleague.Add(Shazam);

app.MapGet("/", () => "Hello Superheroes!");
app.MapGet("/view-justiceleague", () =>  ViewJusticeLeague());
app.MapGet("/view-justiceleague/power/{power}", (string power) => ViewHeroesWithPower(power));
app.MapGet("/view-justiceleagueID/{SecretIdentity}", (string SecretIdentity) => ViewSecretIdentity(SecretIdentity));
app.MapGet("/view-justiceleague/magic", () => ViewHeroesWithMagic());
app.MapGet("/view-justiceleague/names", () => ViewHeroNames());
app.MapGet("/view-justiceleague/superpowers", () => ViewSuperpowers());

List<Character> ViewHeroesWithPower(string power) {
    List<Character> heroesWithPower = new List<Character>();
    foreach(Character hero in justiceleague) {
        foreach(SuperPower superPower in hero.SuperPowers) {
            if(superPower.Name == power) {
                heroesWithPower.Add(hero);
                break;
            }
        }
    }

    return heroesWithPower;
}

Character ViewSecretIdentity(string SecretIdentity) {
    foreach(Character hero in justiceleague) {
        if(hero.SecretIdentity == SecretIdentity) {
            return hero;
        }
    }

    return null;
}   

List<Character> ViewHeroesWithMagic() {
    List<Character> heroesWithMagic = new List<Character>();
    foreach(Character hero in justiceleague) {
        foreach(SuperPower superPower in hero.SuperPowers) {
            if(superPower.IsMagic) {
                heroesWithMagic.Add(hero);
                break;
            }
        }
    }

    return heroesWithMagic;
}

List<string> ViewHeroNames() {
    List<string> heroNames = new List<string>();
    foreach(Character hero in justiceleague) {
        heroNames.Add(hero.SuperHero);
    }

    return heroNames;
}

List<String> ViewSuperpowers()
{
    List<String> superpowers = new List<String>();
    foreach(Character hero in justiceleague)
    {
        foreach(SuperPower superpower in hero.SuperPowers)
        {
            superpowers.Add(superpower.Name);
        }
    }
    return superpowers;
}

List<Character> ViewJusticeLeague()
{
    return justiceleague; 
}

app.Run();
