using System;
using System.Collections.Generic;

// Step 5: Call the method to return the list
List<Wish> wishes = GetWishes();

// Step 4: Iterate through the wishes in the list and print each one to the console
foreach (Wish myWish in wishes)
{
    Console.WriteLine(myWish.WishText);
}

// Step 2: Create a method to return a list
List<Wish> GetWishes()
{
    // Step 3: Create a list of objects
    List<Wish> wishes = new List<Wish>
    {
        new Wish
        {
            WishText = "An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'"
        },
        new Wish
        {
            WishText = "The ability to think of interesting wishes on short notice"
        },
        new Wish
        {
            WishText = "A washtub of Skittles"
        },
        new Wish
        {
            WishText = "World peace, but not the kind of world peace where all the humans are removed from existence"
        },
        new Wish
        {
            WishText = "A TV that is NOT internet-capable"
        },
        new Wish
        {
            WishText = "The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?"
        }
    };
    return (wishes);
}


// step 1: Create a class
public class Wish
{
    public string WishText { get; set; }
}
