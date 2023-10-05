var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Character> justiceleague = new List<Character>();

Character Superman = new Character();
Superman.SuperHero = "Superman";
Superman.SecretIdentity = "Clark Kent";
Superman.SuperPowers = new List<SuperPower>{
    new SuperPower() { Name = "Flight", Description = "The ability to defy gravity and propel oneself through the air unassisted.", IsMagic = false },
    new SuperPower() { Name = "Super Strength", Description = "The ability to exert force and lift heavy objects beyond one's natural strength.", IsMagic = false },
    new SuperPower() { Name = "Heat Vision", Description = "The ability to emit beams of concentrated heat from one's eyes.", IsMagic = false },
    new SuperPower() { Name = "X-Ray Vision", Description = "The ability to see through solid objects.", IsMagic = false },
    new SuperPower() { Name = "Super Speed", Description = "The ability to move faster than the eye can perceive.", IsMagic = false },
    new SuperPower() { Name = "Super Hearing", Description = "The ability to hear sounds from a great distance.", IsMagic = false },
    new SuperPower() { Name = "Invulnerability", Description = "The ability to be immune to one or more forms of physical, mental, and spiritual damage and influence.", IsMagic = false },
    new SuperPower() { Name = "Super Breath", Description = "The ability to inhale and exhale huge gusts of wind from the mouth.", IsMagic = false },
    new SuperPower() { Name = "Super Vision", Description = "The ability to see farther and with greater accuracy than a normal human.", IsMagic = false },
    new SuperPower() { Name = "Superhuman Stamina", Description = "The ability to maintain continuous physical actions for an extended period of time.", IsMagic = false },
    new SuperPower() { Name = "Superhuman Agility", Description = "The ability to maintain perfect balance, equilibrium, and dexterity.", IsMagic = false },
    new SuperPower() { Name = "Superhuman Reflexes", Description = "The ability to react faster than a normal human.", IsMagic = false },
    new SuperPower() { Name = "Superhuman Senses", Description = "The ability to see, smell, taste, feel, and/or hear more than a normal human.", IsMagic = false },
    new SuperPower() { Name = "Superhuman Memory", Description = "The ability to remember things far beyond the average human.", IsMagic = false },
    new SuperPower() { Name = "Superhuman Intelligence", Description = "The ability to have intelligence far beyond the average human.", IsMagic = false }
};

Character Batman = new Character();
Batman.SuperHero = "Batman";
Batman.SecretIdentity = "Bruce Wayne";
Batman.SuperPowers = new List<SuperPower>{
    new SuperPower() { Name = "Genius-Level Intellect", Description = "The ability to have intelligence far beyond the average human.", IsMagic = false },      
    new SuperPower() { Name = "Peak Human Conditioning", Description = "The ability to have strength, speed, stamina, and agility at the peak of human potential.", IsMagic = false },
    new SuperPower() { Name = "Master Martial Artist", Description = "The ability to have mastered all forms of hand-to-hand combat.", IsMagic = false },
    new SuperPower() { Name = "Master Detective", Description = "The ability to have mastered all forms of detective skills.", IsMagic = false },
    new SuperPower() { Name = "Master Acrobat", Description = "The ability to have mastered all forms of acrobatics.", IsMagic = false },
    new SuperPower() { Name = "Master Inventor", Description = "The ability to have mastered all forms of inventing.", IsMagic = false },
    new SuperPower() { Name = "Master Escapologist", Description = "The ability to have mastered all forms of escaping.", IsMagic = false },
    new SuperPower() { Name = "Master Marksman", Description = "The ability to have mastered all forms of marksmanship.", IsMagic = false },
    new SuperPower() { Name = "Master Swordsman", Description = "The ability to have mastered all forms of swordsmanship.", IsMagic = false },
    new SuperPower() { Name = "Master Strategist", Description = "The ability to have mastered all forms of strategy.", IsMagic = false },
    new SuperPower() { Name = "Master Tactician", Description = "The ability to have mastered all forms of tactics.", IsMagic = false },
    new SuperPower() { Name = "Master Acrobat", Description = "The ability to have mastered all forms of acrobatics.", IsMagic = false },
    new SuperPower() { Name = "Master of Stealth", Description = "The ability to have mastered all forms of stealth.", IsMagic = false },
    new SuperPower() { Name = "Master of Disguise", Description = "The ability to have mastered all forms of disguise.", IsMagic = false },
    new SuperPower() { Name = "Master of Deception", Description = "The ability to have mastered all forms of deception.", IsMagic = false },
    new SuperPower() { Name = "Master of Intimidation", Description = "The ability to have mastered all forms of intimidation.", IsMagic = false },
    new SuperPower() { Name = "Master of Interrogation", Description = "The ability to have mastered all forms of interrogation.", IsMagic = false },
    new SuperPower() { Name = "Master of Demolitions", Description = "The ability to have mastered all forms of demolitions.", IsMagic = false },
    new SuperPower() { Name = "Master of Medicine", Description = "The ability to have mastered all forms of medicine.", IsMagic = false },
    new SuperPower() { Name = "Master of Hypnosis", Description = "The ability to have mastered all forms of hypnosis.", IsMagic = false },
    new SuperPower() { Name = "Master of Tracking", Description = "The ability to have mastered all forms of tracking.", IsMagic = false },
    new SuperPower() { Name = "Master of Driving", Description = "The ability to have mastered all forms of driving.", IsMagic = false },
    new SuperPower() { Name = "Master of Piloting", Description = "The ability to have mastered all forms of piloting.", IsMagic = false },
    new SuperPower() { Name = "Master of Throwing", Description = "The ability to have mastered all forms of throwing.", IsMagic = false },
    new SuperPower() { Name = "Master of Weapons", Description = "The ability to have mastered all forms of weapons.", IsMagic = false },
    new SuperPower() { Name = "Master of Firearms", Description = "The ability to have mastered all forms of firearms.", IsMagic = false },
    new SuperPower() { Name = "Master of Technology", Description = "The ability to have mastered all forms of technology.", IsMagic = false },
    new SuperPower() { Name = "Master of Business", Description = "The ability to have mastered all forms of business.", IsMagic = false }
};  

Character Zatanna = new Character();
Zatanna.SuperHero = "Zatanna";
Zatanna.SecretIdentity = "Zatanna Zatara";
Zatanna.SuperPowers = new List<SuperPower>{
    new SuperPower() { Name = "Magic", Description = "The ability to use magic.", IsMagic = true }
};

Character TheFlash = new Character();
TheFlash.SuperHero = "The Flash";
TheFlash.SecretIdentity = "Barry Allen";
TheFlash.SuperPowers = new List<SuperPower>{
    new SuperPower() { Name = "Super Speed", Description = "The ability to move faster than the eye can perceive.", IsMagic = false },
    new SuperPower() { Name = "Superhuman Stamina", Description = "The ability to maintain continuous physical actions for an extended period of time.", IsMagic = false },
    new SuperPower() { Name = "Superhuman Agility", Description = "The ability to maintain perfect balance, equilibrium, and dexterity.", IsMagic = false },
    new SuperPower() { Name = "Superhuman Reflexes", Description = "The ability to react faster than a normal human.", IsMagic = false }
};

Character GreenLantern = new Character();
GreenLantern.SuperHero = "Green Lantern";
GreenLantern.SecretIdentity = "Hal Jordan";
GreenLantern.SuperPowers = new List<SuperPower>{
    new SuperPower() { Name = "Flight", Description = "The ability to defy gravity and propel oneself through the air unassisted.", IsMagic = false },
    new SuperPower() { Name = "Super Strength", Description = "The ability to exert force and lift heavy objects beyond one's natural strength.", IsMagic = false },
    new SuperPower() { Name = "Energy Projection", Description = "The ability to create and project energy.", IsMagic = false },
    new SuperPower() { Name = "Energy Constructs", Description = "The ability to create objects out of energy.", IsMagic = false },
    new SuperPower() { Name = "Force Field", Description = "The ability to create a field of energy that protects the user.", IsMagic = false },
    new SuperPower() { Name = "Energy Absorption", Description = "The ability to absorb energy.", IsMagic = false },
    new SuperPower() { Name = "Energy Manipulation", Description = "The ability to manipulate energy.", IsMagic = false },
    new SuperPower() { Name = "Energy Resistance", Description = "The ability to be resistant to energy.", IsMagic = false }
};

Character WonderWoman = new Character();
WonderWoman.SuperHero = "Wonder Woman";
WonderWoman.SecretIdentity = "Diana Prince";
WonderWoman.SuperPowers = new List<SuperPower>{
    new SuperPower() { Name = "Super Strength", Description = "The ability to exert force and lift heavy objects beyond one's natural strength.", IsMagic = false },
    new SuperPower() { Name = "Superhuman Stamina", Description = "The ability to maintain continuous physical actions for an extended period of time.", IsMagic = false },
    new SuperPower() { Name = "Superhuman Agility", Description = "The ability to maintain perfect balance, equilibrium, and dexterity.", IsMagic = false },
    new SuperPower() { Name = "Superhuman Reflexes", Description = "The ability to react faster than a normal human.", IsMagic = false },
    new SuperPower() { Name = "Superhuman Speed", Description = "The ability to move faster than the eye can perceive.", IsMagic = false },
    new SuperPower() { Name = "Flight", Description = "The ability to defy gravity and propel oneself through the air unassisted.", IsMagic = false },
    new SuperPower() { Name = "Invulnerability", Description = "The ability to be immune to one or more forms of physical, mental, and spiritual damage and influence.", IsMagic = false },
    new SuperPower() { Name = "Accelerated Healing", Description = "The ability to heal at a faster rate than a normal human.", IsMagic = false }
};

Character GreenArrow = new Character();
GreenArrow.SuperHero = "Green Arrow";
GreenArrow.SecretIdentity = "Oliver Queen";
GreenArrow.SuperPowers = new List<SuperPower>{
    new SuperPower() { Name = "Peak Human Conditioning", Description = "The ability to have strength, speed, stamina, and agility at the peak of human potential.", IsMagic = false },
    new SuperPower() { Name = "Master Archer", Description = "The ability to have mastered all forms of archery.", IsMagic = false },
    new SuperPower() { Name = "Master Martial Artist", Description = "The ability to have mastered all forms of hand-to-hand combat.", IsMagic = false },
    new SuperPower() { Name = "Master Swordsman", Description = "The ability to have mastered all forms of swordsmanship.", IsMagic = false },
    new SuperPower() { Name = "Master Acrobat", Description = "The ability to have mastered all forms of acrobatics.", IsMagic = false },
    new SuperPower() { Name = "Master Marksman", Description = "The ability to have mastered all forms of marksmanship.", IsMagic = false },
    new SuperPower() { Name = "Master Tactician", Description = "The ability to have mastered all forms of tactics.", IsMagic = false },
    new SuperPower() { Name = "Master of Stealth", Description = "The ability to have mastered all forms of stealth.", IsMagic = false },
    new SuperPower() { Name = "Master of Disguise", Description = "The ability to have mastered all forms of disguise.", IsMagic = false },
    new SuperPower() { Name = "Master of Throwing", Description = "The ability to have mastered all forms of throwing.", IsMagic = false },
    new SuperPower() { Name = "Master of Weapons", Description = "The ability to have mastered all forms of weapons.", IsMagic = false },
    new SuperPower() { Name = "Master of Firearms", Description = "The ability to have mastered all forms of firearms.", IsMagic = false },
    new SuperPower() { Name = "Master of Technology", Description = "The ability to have mastered all forms of technology.", IsMagic = false },
    new SuperPower() { Name = "Master of Business", Description = "The ability to have mastered all forms of business.", IsMagic = false }
};

Character Aquaman = new Character();
Aquaman.SuperHero = "Aquaman";
Aquaman.SecretIdentity = "Arthur Curry";
Aquaman.SuperPowers = new List<SuperPower>{
    new SuperPower() { Name = "Super Strength", Description = "The ability to exert force and lift heavy objects beyond one's natural strength.", IsMagic = false },
    new SuperPower() { Name = "Superhuman Stamina", Description = "The ability to maintain continuous physical actions for an extended period of time.", IsMagic = false },
    new SuperPower() { Name = "Superhuman Agility", Description = "The ability to maintain perfect balance, equilibrium, and dexterity.", IsMagic = false },
    new SuperPower() { Name = "Superhuman Reflexes", Description = "The ability to react faster than a normal human.", IsMagic = false },
    new SuperPower() { Name = "Superhuman Speed", Description = "The ability to move faster than the eye can perceive.", IsMagic = false },
    new SuperPower() { Name = "Invulnerability", Description = "The ability to be immune to one or more forms of physical, mental, and spiritual damage and influence.", IsMagic = false },
    new SuperPower() { Name = "Accelerated Healing", Description = "The ability to heal at a faster rate than a normal human.", IsMagic = false },
    new SuperPower() { Name = "Underwater Breathing", Description = "The ability to breathe underwater.", IsMagic = false },
    new SuperPower() { Name = "Enhanced Senses", Description = "The ability to have senses far beyond the average human.", IsMagic = false },
    new SuperPower() { Name = "Telepathy", Description = "The ability to communicate with others through the mind.", IsMagic = false },
    new SuperPower() { Name = "Animal Control", Description = "The ability to control animals.", IsMagic = false },
    new SuperPower() { Name = "Marine Telepathy", Description = "The ability to communicate with marine life through the mind.", IsMagic = false },
};  
  
Character Shazam = new Character();
Shazam.SuperHero = "Shazam";
Shazam.SecretIdentity = "Billy Batson";
Shazam.SuperPowers = new List<SuperPower>{
    new SuperPower() { Name = "Super Strength", Description = "The ability to exert force and lift heavy objects beyond one's natural strength.", IsMagic = true },
    new SuperPower() { Name = "Superhuman Stamina", Description = "The ability to maintain continuous physical actions for an extended period of time.", IsMagic = true },
    new SuperPower() { Name = "Superhuman Agility", Description = "The ability to maintain perfect balance, equilibrium, and dexterity.", IsMagic = true },
    new SuperPower() { Name = "Superhuman Reflexes", Description = "The ability to react faster than a normal human.", IsMagic = true },
    new SuperPower() { Name = "Superhuman Speed", Description = "The ability to move faster than the eye can perceive.", IsMagic = true },
    new SuperPower() { Name = "Flight", Description = "The ability to defy gravity and propel oneself through the air unassisted.", IsMagic = true },
    new SuperPower() { Name = "Invulnerability", Description = "The ability to be immune to one or more forms of physical, mental, and spiritual damage and influence.", IsMagic = true },
    new SuperPower() { Name = "Accelerated Healing", Description = "The ability to heal at a faster rate than a normal human.", IsMagic = true },
    new SuperPower() { Name = "Magic", Description = "The ability to use magic.", IsMagic = true }
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

List<Character> ViewJusticeLeague()
{
    return justiceleague; 
}

app.Run();
