string choice = "";

Console.WriteLine("Du ser en fotboll på vägen hem från skolan");
Console.WriteLine("Vad väljer du att göra?");
Console.WriteLine("ta bollen eller lämna den");
choice = Console.ReadLine(); 
choice = choice.ToLower();

if (choice == "lämna den")
{
    Console.WriteLine("Du lämnar bollen och fortsätter gå hem");
    Console.WriteLine("Nästa morgon, kollar du på nyheterna och ser att ett barn har blivit misshandlad");
}
else if (choice == "ta bollen")
{
    Console.WriteLine("En man kommer och vill prata med dig");
    Console.WriteLine("Han heter Mr Coleman, han säger att bollen tillhör hans son");
    Console.WriteLine("Mr Coleman vill ha tillbaka bollen annars misshandlar han dig");
    Console.WriteLine("Vad kommer du göra? ge honom bollen eller springa därifrån");

    choice = Console.ReadLine();
    choice = choice.ToLower();
}
if (choice == "ge honom bollen")
{
    Console.WriteLine("Mr Coleman tackar dig och ger dig en puss på kinden");
    Console.WriteLine("Han vill bjuda dig på middag med bara han och dig");
    Console.WriteLine("Du går på middagen och får inte bara en men två bollar");
}
else if (choice == "springa därifrån")
{
    Console.WriteLine("Mr Coleman springer i kapp dig och börjar slå dig tills du dör");
}

Console.WriteLine("Tryck ENTER för att avsluta.");
Console.ReadLine();