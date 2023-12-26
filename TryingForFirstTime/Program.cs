
Console.Write("How are you?");
Console.WriteLine("Hey");


int x;
x = 123;

int y = 456;

int z = x + y;


double height = 1.81;
Boolean alive = true;
char symbol = '@'; //Char só tem ''
string luckPhrase = "End Is Near";

const string parent = "Barbara"; //Immutable


Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

Console.WriteLine("Your height is: " + height);
Console.WriteLine("Are you alive ? " + alive);
Console.WriteLine("Your symbol is: " + symbol);
Console.WriteLine("Your favorite phrase is: " + luckPhrase);


Console.WriteLine("Who are you ? /n");
string name = Console.ReadLine();
Console .WriteLine("Hello " + name);

Console.WriteLine("--------------------------Type casting----------------------------");


//Converte double para int
double a = 3.14;
int r= Convert.ToInt32(a);
Console.WriteLine(r);


//Converte int para string
int p = 123456;
string IntergerToString = Convert.ToString(p);

Console.WriteLine(IntergerToString);
Console.WriteLine(p.GetType());//pega o tipo da variavel


// string to char

string doido = "%";//para fazer a conversão a string deve ser somente um caractere
char doidoChar = Convert.ToChar(doido);

Console.WriteLine(doidoChar);


Console.WriteLine("--------------------User input-------------------------------");

Console.WriteLine("Hey what's your name?");
string name1 = Console.ReadLine();

Console.WriteLine("What's your age?");
int age1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What's your favorite food?");
string favoriteFood = Console.ReadLine();

Console.WriteLine("What's your weight?");
double weight = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Name: " + name1 + "/ Age: " + age1 + "/ Favorite food: " + favoriteFood + "/ Weight: " + weight);
Console.WriteLine("So... this information are correct? Yes or No");
string answer = Console.ReadLine();

if(answer == "yes")
{
    Console.WriteLine("Nice");
}
if(answer == "no")
{
    Console.WriteLine("What do you want to change? Name, age, food or weight");
    string answer2 = Console.ReadLine();
    if(answer2=="name")
    {
        Console.WriteLine("Say your name again?");
        string name2 = Console.ReadLine();
        name1 = name2;
        Console.WriteLine("Your new name is " + name2);
    }
}



Console.ReadKey();





