//bool userIn = false;

string userAns;
        double tsp = 1;
        double tbsp = 1;
        double slc = 1;
        double joj = 48 * tsp;
        double jop = 32 * tbsp;
        double lob = 28 * slc;
        
double jn = 0;
double pn = 0;
double bn = 0;
double tjn = 0;
double tpn = 0;
double tbn = 0;

begin:

Console.WriteLine("Hey, how's it goin'? So ya' want some PB&J? How many people are we making PB&J sandwiches for?");
        int userInput = int.Parse(Console.ReadLine());
//userIn = int.TryParse(userInput, out int result);

jn = tsp * 4 * userInput;
pn = tbsp * 2 * userInput;
bn = slc * 2 * userInput;
tjn = jn / joj;
tpn = pn / jop;
tbn = bn / lob;

int ajn = (int)Math.Ceiling(tjn);
int apn = (int)Math.Ceiling(tpn);
int abn = (int)Math.Ceiling(tbn);

/*if (userInput == null)
{
Console.WriteLine("C'mon, quit playin'.");
Console.ReadLine();
}
else*/
{
    Console.WriteLine("Okay, you're gonna' need " + jn + " teaspoon(s) of jelly, " + pn + " tablespoon(s) of peanut butter, and " +
        bn + " slice(s) of bread.");
    Console.WriteLine();
        Console.WriteLine("Which comes to " + ajn + " jar(s) of jelly, " + apn + " jar(s) of peanut butter, and " + 
        abn + " loaf/loaves of bread");
    Console.WriteLine("So, I got nuthin' better ta' do. You lookin' ta' make any more?");
    userAns = Console.ReadLine().ToLower();
    userAns.Trim();
string yes = "yes";
string y = "y";

    if (userAns == yes)
    {
        goto begin;
    }
    else if (userAns == y)
    {
        goto begin;
    }
    else
    {
        Console.WriteLine("Goodbye");
    }
    Console.ReadLine();

}
    
