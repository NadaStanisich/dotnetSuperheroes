var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Character> justiceleague = new List<Character>();

Character Superman = new Character();
Superman.SuperHero = "Superman";
Superman.SecretIdentity = "Clark Kent";
Superman.SuperPowers = new Powers() { Skillset = "Flight", Natural = "Super Strength", Magic = false };

Character Batman = new Character();
Batman.SuperHero = "Batman";
Batman.SecretIdentity = "Bruce Wayne";
Batman.SuperPowers = new Powers() { Skillset = "Martial Arts", Natural = "Intelligence", Magic = false };   

Character Zatanna = new Character();
Zatanna.SuperHero = "Zatanna";
Zatanna.SecretIdentity = "Zatanna Zatara";
Zatanna.SuperPowers = new Powers() { Skillset = "Magic", Natural = "Incantations", Magic = true };

Character TheFlash = new Character();
TheFlash.SuperHero = "The Flash";
TheFlash.SecretIdentity = "Barry Allen";
TheFlash.SuperPowers = new Powers() { Skillset = "Speedster", Natural = "Speed", Magic = false };

Character GreenLantern = new Character();
GreenLantern.SuperHero = "Green Lantern";
GreenLantern.SecretIdentity = "Hal Jordan";
GreenLantern.SuperPowers = new Powers() { Skillset = "Willpower", Natural = "Power Ring", Magic = false };

Character WonderWoman = new Character();
WonderWoman.SuperHero = "Wonder Woman";
WonderWoman.SecretIdentity = "Diana Prince";
WonderWoman.SuperPowers = new Powers() { Skillset = "Flight", Natural = "Super Strength", Magic = false };

justiceleague.Add(Superman);
justiceleague.Add(Batman);
justiceleague.Add(Zatanna);
justiceleague.Add(TheFlash);
justiceleague.Add(GreenLantern);
justiceleague.Add(WonderWoman);

app.MapGet("/", () => "Hello Superheroes!");
app.MapGet("/view-justiceleague", () =>  ViewJusticeLeague());
app.MapGet("/view-justiceleague/{Skill}", (string Skill) => ViewSkillset(Skill));
app.MapGet("/view-justiceleagueID/{SecretIdentity}", (string SecretIdentity) => ViewSecretIdentity(SecretIdentity));
app.MapGet("/view-justiceleague/nomagic", () => NoMagicPowers());

Character ViewSkillset(string Skill) {
    foreach(Character hero in justiceleague) {
        if(hero.SuperPowers.Skillset == Skill) {
            return hero;
        }
    }

    return null;
}

Character ViewSecretIdentity(string SecretIdentity) {
    foreach(Character hero in justiceleague) {
        if(hero.SecretIdentity == SecretIdentity) {
            return hero;
        }
    }

    return null;
}   

List<Character> NoMagicPowers() {
    List<Character> nonmagicHeroes = new List<Character>();
    foreach(Character hero in justiceleague) {
        if(hero.SuperPowers.Magic == false) {
            nonmagicHeroes.Add(hero);
        }
    }

    return nonmagicHeroes;
}   

List<Character> ViewJusticeLeague()
{
    return justiceleague; 
}

app.Run();
