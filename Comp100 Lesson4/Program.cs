// See https://aka.ms/new-console-template for more information

bool condiction = true;
while (condiction == true) 
{
    Console.WriteLine("1 for pizza 2 for burger 3 for nothing");
    int response = Convert.ToInt32(Console.ReadLine());
    switch (response) 
    {
        case 1:
        case 2:
            Console.WriteLine("you are eating a burger or pizza");
            break;
        case 3:
            condiction = false;
            break;
        default:
            Console.WriteLine("invalid input");
            break ;
    }
}


Console.WriteLine("Press any key to exit");
Console.ReadKey();