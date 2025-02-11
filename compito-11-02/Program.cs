using compito_11_02.models;

var persona1 = new Persona()
{
    Nome = "Camilla",
    Cognome = "Zicari",
    Eta = 23,
};

Console.WriteLine(persona1.ScriviNome());
Console.WriteLine(persona1.ScriviCognome());
Console.WriteLine(persona1.ScriviEta());