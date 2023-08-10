var friend = new string[] { "ali", "ahmed", "omar" };
var s = friend[..2];
s.print();
var amountJOD = 100;
var currType=Console.ReadLine();
var output = 0d;
//JOD -- USD=1.41 , JOD -- EUR =1.19 , JOD -- CAD=1.78
var JODUSD = 1.41d;
var JODEUR = 1.19d;
var JODCAD = 1.78d;
switch(currType)
{
    case "USD":
        output = amountJOD * JODUSD;
        Console.WriteLine($"{amountJOD} JOD = ${output}USD");      
        break;
    case "EUR":
     output = amountJOD * JODEUR;
        Console.WriteLine($"{amountJOD} JOD = ${output}EUR");
        break;
    case "CAD":
        output = amountJOD * JODCAD;
        Console.WriteLine($"{amountJOD} JOD = ${output}CAD");
        break;
    default:
        Console.WriteLine("unknow currency type"); 
        break;    
}
bool isvip
    = false;
switch (isvip)
{
    case bool i when i == true:
        Console.WriteLine("YES");
        break;
    case bool i when i == false:
        Console.WriteLine("no");
        break;
}
///////////////////////////////////////////////
var v = 13;
string car = v switch
{
    1 => "ASA",
    13 => "king",
    _=> v.ToString() 
    };
///////////////////////////////////////////////////////
int num = int.Parse(Console.ReadLine());
switch(num)
{
    case 1:
    case 3:
    case 5:
    case 7:
        Console.WriteLine("odd");
        break;
        case 2: 
        case 4:
        case 6:
        Console.WriteLine("even");
        break;  
}
var count = 0;
while (true)
{
    Console.WriteLine(count++); 
}
public static class Extention
{
    public static void print<I>(this I[]source)
    {
        if(source==null)
        { Console.WriteLine("{ }");
        return; }
        Console.Write("{ ");
        Console.WriteLine(source.Length);
        for(var i =0; i < source.Length;i++)
        {
            Console.Write($"{source[i]}");
            Console.Write(i < source.Length -1 ? ", ":"");   
        }
        Console.WriteLine(" } ");
    }
}
