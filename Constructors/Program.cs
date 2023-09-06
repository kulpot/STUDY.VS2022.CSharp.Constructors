using System;   
    
//ref link:https://www.youtube.com/watch?v=oJOS21A42jQ&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=39
//  Contructor - sequencing
    
/*  OUTPUT  
 *      
 *  Cow(Bessie)         --  derive
    Cow(Betsy)          --  base
    Cow(Georgy)         --  base
    Farm()              --  base
    Hello world         --  base
    Hello world         --  base
    Hello world         --  base
    Kulpot's Farm()     --  derive
 * 
 *  
 */

class Farm      // base class constructor
{
    public Farm()   // farm constructor
    {
        Console.WriteLine("Farm()");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Hello world");
        }
    }
    Cow cow1 = new Cow("Betsy");
    Cow cow2 = new Cow("Georgy");
}

class KulpotsFarm : Farm    //derive class constructor
{
    Cow kulpotCow = new Cow("Bessie");
    public KulpotsFarm()
    {
        Console.WriteLine("Kulpot's Farm()");
    }
}


class Cow
{
    public Cow(string name) // cow constructor
    {
        Console.WriteLine("Cow(" + name + ")");
    }
}

class MainClass
{
    static void Main()
    {
        //new Farm();
        new KulpotsFarm();
    }
}