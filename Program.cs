string[] Pronouns = {"I", "You", "They", "We", "He", "She", "It"};
string[] Verbs = {"eat", "drink", "play"}; 
string[] Food = {"pizza", "pasta", "rice", "a cake"};
string[] Drinks = {"Soda", "Water", "Orange Juice"};
string[] Games = {"Videogames", "football", "basketball", "dodgeball", "American Football"}; 
int WhileLoop = 0; 
while (WhileLoop == 0)
{
 Random rnd = new Random(); 
 int IndexPro = rnd.Next(Pronouns.Length);
 if (IndexPro == 4|| IndexPro == 5 || IndexPro == 6)
 {
    int IndexVerb = rnd.Next(Verbs.Length);
    System.Threading.Thread.Sleep(200);
    if (IndexVerb == 0)
    {
        int IndexFood = rnd.Next(Food.Length);
        Console.WriteLine($"{Pronouns[IndexPro]}" + " " + $"{Verbs[IndexVerb]}" + "s" + " " +  $"{Food[IndexFood]}");
    }
    else if (IndexVerb == 1)
    {
      int IndexDrinks = rnd.Next(Drinks.Length);
      Console.WriteLine($"{Pronouns[IndexPro]}" + " " + $"{Verbs[IndexVerb]}" + "s" + " " +  $"{Drinks[IndexDrinks]}");
    }
    else if (IndexVerb == 2)
    {
      int IndexGames = rnd.Next(Games.Length);   
     Console.WriteLine($"{Pronouns[IndexPro]}" + " " + $"{Verbs[IndexVerb]}" + "s" + " " +  $"{Games[IndexGames]}");

    }
 } 

 if (IndexPro == 0 || IndexPro == 1 || IndexPro == 2 || IndexPro == 3)
 {
    int IndexVerb = rnd.Next(Verbs.Length);
    System.Threading.Thread.Sleep(200);
    if (IndexVerb == 0)
    {
        int IndexFood = rnd.Next(Food.Length);
        Console.WriteLine($"{Pronouns[IndexPro]}" + " " + $"{Verbs[IndexVerb]}" + " " +  $"{Food[IndexFood]}");
    }
    else if (IndexVerb == 1)
    {
      int IndexDrinks = rnd.Next(Drinks.Length);
      Console.WriteLine($"{Pronouns[IndexPro]}" + " " + $"{Verbs[IndexVerb]}" + " " +  $"{Drinks[IndexDrinks]}");
    }
    else if (IndexVerb == 2)
    {
      int IndexGames = rnd.Next(Games.Length);   
     Console.WriteLine($"{Pronouns[IndexPro]}" + " " + $"{Verbs[IndexVerb]}" + " " +  $"{Games[IndexGames]}");

    }
 }
}