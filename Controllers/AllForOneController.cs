//Elizar Garcia
//10-25-22
//Minich#challengeEndpoints
//This project will show the challenges and a brief description of that challenge to show up on postman.
//Peer Review:andrea burr everyting runs great but cherck spelling! overall runs well!

using Microsoft.AspNetCore.Mvc;

namespace GarciaeAllForOne.Controllers;

[ApiController]
[Route("[controller]")]
public class AllForOneController : ControllerBase
{
   [HttpGet]
    [Route("hello/{name}")]

    public string SayHello(string name)
    {
        return $"Hello {name}, nice to make your aquaintance. ";

    }
    
    [HttpGet]
    [Route("adding/{number1}/{number2}")]

    public int math(string number1, string number2)
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2);
        return convertNum1 + convertNum2;

    }
  
   [HttpGet]
    [Route("asking/{name}/{time}")]

    public string talk (string name, string time)
    {
        return $"Hey {name}, did you really wake up at {time}?";

    }

    [HttpGet]
    [Route("greater/{number1}/{number2}")]

    public string mat(string number1, string number2)
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2);

        if(convertNum1 > convertNum2)
        {
            return $"{number1} is greater than {number2}. ";

        }else if(convertNum1 < convertNum2)
        {
            return $"{number1} is less than {number2}.";

        }else
        {
            return $"{number1} is equal to {number2}.";

        }
    }

     [HttpGet]
   [Route ("mad/{adjectiveone}/{vehicleOne}/{colorOne}/{nounOne}/{verbOne}/{city}/{adjectiveTwo}/{timeYear}/{favSong}/{place}")]

   public string madLib(string adjectiveOne, string vehicleOne, string colorOne, string nounOne, string verbOne, string city, string adjectiveTwo, string timeYear, string favSong, string place)
   {
    return ($" My First favorite pokemon is {adjectiveOne} My second favorite is {vehicleOne} My third favorite {colorOne} My fourth favorite {nounOne} My fifth favorite is {verbOne} My sixth favorite is {city}. My seventh {adjectiveTwo} and I guess I like {timeYear} and maybe {favSong} and why not..what it's name.. {place}! ");
   }

    
    [HttpGet]
    [Route("Odd/{numOne}")]

    public string math(string numOne)
    {
        

        
        
        int number1 = Convert.ToInt32(numOne);

        int remainder = number1 % 2;

        if (remainder == 0)
        {
          return (numOne + " is even ");
        
        }else{
            return (numOne + " is odd ");

        }
        

   

    }

   [HttpGet]
    [Route("Reverse/{input}")]

    public string reverse(string input)
    {
        string rev = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            rev = rev + input[i];
        }
        return $" {input} <[^-^]>  {rev}";
    }

    [HttpGet]
    [Route("Picker/{foodChoice}")]

    public string Food(string foodChoice)
    {
        string poop ="";

        if(foodChoice == "americanfood")
    {   

        Random rndNumber = new Random();
        int rndNumber1 = rndNumber.Next(1, 10);

        switch(rndNumber1)
        {
            case 1: poop = ("Market Tavern");
             break;
            case 2: poop = ("The Habit");
             break;
            case 3: poop = ("In N Out Burger");
             break;
            case 4: poop = ("Midgley's Public House");
            break;
            case 5: poop = ("Lumberjacks"); 
            break;
            case 6: poop = ("IHop");
            break;
            case 7: poop = ("Denny's");
            break;
            case 8: poop = ("BJ's Restaurant & Brewhouse");
            break;
            case 9: poop = ("Moo Moo's Burger Barn");
            break;
            case 10: poop = ("Whirlows");
            break;
        } 
        

    }
    
     else if(foodChoice == "asianfood" )
    {   

        Random rndNumber = new Random();
        int rndNumber2 = rndNumber.Next(1, 10);

         switch(rndNumber2)
        {
            case 1: poop = ("Prosperity Szechuan Cuisine");
             break;
            case 2: poop = ("New Yen Ching Restaurant");
             break;
            case 3: poop = ("China Palace");
             break;
            case 4: poop = ("Green Papaya");
            break;
            case 5: poop = ("GK Mongolian BBQ"); 
            break;
            case 6: poop = ("Lao, Der");
            break;
            case 7: poop = ("Sushi Villa Buffet");
            break;
            case 8: poop = ("Quickly");
            break;
            case 9: poop = ("Bayon Restaurant");
            break;
            case 10: poop = ("Shome Japenese Cuisine");
            break;
    }
    

}
else if(foodChoice == "mexicanfood")
{   

     Random rndNumber = new Random();
        int rndNumber3 = rndNumber.Next(1, 10);

         switch(rndNumber3)
        {
            case 1: poop = ("Taco Bell");
             break;
            case 2: poop = ("Chapala");
             break;
            case 3: poop = ("Nene's");
             break;
            case 4: poop = ("El Pollo Loco");
            break;
            case 5: poop = ("Casa Flores"); 
            break;
            case 6: poop = ("El Frutal");
            break;
            case 7: poop = ("Taco House");
            break;
            case 8: poop = ("Alberto's Mexican Food");
            break;
            case 9: poop = ("Rubio's Coastal Grill");
            break;
            case 10: poop = ("Don Luis");
            break;
    }
    }else{
        poop = " I swear if you dont pick one of the options I provided im going to poop on you.";
    }
    return poop;
}
}