Console.WriteLine("Sex(m/f): ");
string sex = Console.ReadLine();
string weightInput;
if (sex == "m")
{
    Console.WriteLine("How fat are you in kg: ");
    weightInput = Console.ReadLine();
    int flyWeight = (int)double.Parse(weightInput);
if (flyWeight <= 55)
{
    Console.WriteLine("You are a flyweight.");
}
else
{}
int lightWeight = (int)double.Parse(weightInput);
if (lightWeight <=66 && lightWeight > 55)
{
    Console.WriteLine("You are a lightweight.");
}
else
{}
int middleWeight = (int)double.Parse(weightInput);
if (middleWeight <= 84 && middleWeight > 66)
{
    Console.WriteLine("You are a middleweight.");
}
else
{}
int heavyWeight = (int)double.Parse(weightInput);
if (heavyWeight >= 85 && heavyWeight > 84)
{
    Console.WriteLine("Fatty McFatface");
}
else
{}
int Fat = (int)double.Parse(weightInput);
if (Fat >= 2000 && Fat > 1000)
{
    Console.WriteLine("You are officially a whale.");
}
else
{}
}
else if (sex == "f")
{
    Console.WriteLine("How fat are you in kg: ");
    weightInput = Console.ReadLine();
    int flyWeight = (int)double.Parse(weightInput);
if (flyWeight <= 48)
{
    Console.WriteLine("You are a flyweight.");
}
else
{}
int lightWeight = (int)double.Parse(weightInput);
if (lightWeight <=55 && lightWeight > 48)
{
    Console.WriteLine("You are a lightweight.");
}
else
{}
int middleWeight = (int)double.Parse(weightInput);
if (middleWeight <= 63 && middleWeight > 55)
{
    Console.WriteLine("You are a middleweight.");
}
else
{}
int heavyWeight = (int)double.Parse(weightInput);
if (heavyWeight >= 64 && heavyWeight > 63)
{
    Console.WriteLine("You are a heavyweight.");
}
else
{}
int Fat = (int)double.Parse(weightInput);
if (Fat >= 2000 && Fat > 1000)
{
    Console.WriteLine("Liam is that you?");
}
else
{}
}
else if (sex == "mehanik")
{
    Console.WriteLine("You are white.");
}
else if (sex == "email")
{
    Console.WriteLine("you are black");
}
else
{
    Console.WriteLine("Invalid input for sex.");
    return;
}
