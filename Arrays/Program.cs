// array = a variable that can store multiple values. fixed size

String[] cars = new string[3];

//String[] cars = { "BMW", "Mustang", "Corvette" };

cars[0] = "Tesla";
cars[1] = "Mustang";
cars[3] = "Corvette";

for(int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}

Console.ReadKey();