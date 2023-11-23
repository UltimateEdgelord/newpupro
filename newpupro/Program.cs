// See https://aka.ms/new-console-template for more information

string input = "";
bool inp = true;
string input1 = "";
while (inp == true)
{
    Console.WriteLine("Zadej slovo.");
    input1 = Console.ReadLine();
    input = input + input1;
    if (string.IsNullOrWhiteSpace(input1))
    {
        inp = false;
    }
    
}
Console.WriteLine(input + ".");

Console.WriteLine("Zadejte slovo");
string text = Console.ReadLine();
for (int im = 0; 4 > im; im++)
{
    Console.WriteLine(text);
}

bool ost = true;
int imp = 1;
while (ost == true)
{
    Console.WriteLine("Zadejte slovo.");
    string name = Console.ReadLine();

    for (int impr = 0; impr < imp; impr++)
    {

        Console.WriteLine(name);

    }

    imp++;

}