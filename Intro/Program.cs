

Console.WriteLine("====================================");
Console.WriteLine("      Your Personal Information     ");
Console.WriteLine("====================================");

Console.WriteLine("Please Write Your First Name => ");
string firstName = Console.ReadLine();

Console.WriteLine("Please Write Your Last Name => ");
string lastName = Console.ReadLine();

int age = 0;
bool isValidAge = false;

while (!isValidAge)
{
    Console.WriteLine("Please Write Your Age => ");
    string ageInput = Console.ReadLine();
    if (int.TryParse(ageInput, out age) && age > 0 && age < 150)
    {
        isValidAge = true;
    }
    else
    {
        Console.WriteLine("Invalid age! Please insert a number between 1 and 150.");
    }
}



double height = 0;
bool isValidHeight = false;

while (!isValidHeight)
{
    Console.WriteLine("Please Write Your height => ");
    string heightInput = Console.ReadLine();

    if (double.TryParse(heightInput, out height) && height > 0 && height < 290)
    {
        isValidHeight = true;
    }
    else
    {
        Console.WriteLine("Invalid height! Please insert a number between 0 and 290");
    }

}



double weight = 0;
bool isValidWeight = false;

while (!isValidWeight)
{
    Console.WriteLine("Please Write Your weight => ");
    string inputWeight = Console.ReadLine();
    if (double.TryParse(inputWeight , out weight) && weight > 0 && weight < 300)
    {
        isValidWeight = true;
    }
    else
    {
        Console.WriteLine("Invalid weight! Please insert a number between 0 and 300");
    }
}



Console.WriteLine("Please Write Your Living City => ");
string livingCity = Console.ReadLine();

Console.WriteLine("Please Write Your Job => ");
string job = Console.ReadLine();

double heightInMeter = height / 100;
double bmi = weight / (heightInMeter * heightInMeter);

string bmiStatus;
if (bmi < 18.5) bmiStatus = "Underweight";
else if (bmi < 25) bmiStatus = "Normal";
else if (bmi < 30) bmiStatus = "Overweight";
else if (bmi < 35) bmiStatus = "Obese Class I";
else if (bmi < 40) bmiStatus = "Obese Class II";
else bmiStatus = "Obese Class III";

string ageStatus;
if (age < 13) ageStatus = "Child";
else if (age < 18) ageStatus = "Teenager";
else if (age < 30) ageStatus = "Young Adult";
else if (age < 45) ageStatus = "Middle-Aged";
else if (age < 60) ageStatus = "Adult";
else ageStatus = "Senior";

int birthYear = DateTime.Now.Year - age;

Console.Clear();
Console.WriteLine("====================================");
Console.WriteLine("         Your Final Information       ");
Console.WriteLine("====================================");
Console.WriteLine($"Full Name: {firstName} {lastName}");
Console.WriteLine($"Age: {age} years old");
Console.WriteLine($"Height: {height} cm");
Console.WriteLine($"Weight: {weight} kg");
Console.WriteLine($"City: {livingCity}");
Console.WriteLine($"Job: {job}");
Console.WriteLine($"Birth Year (approx): {birthYear}");
Console.WriteLine($"Age Status: {ageStatus}");
Console.WriteLine($"BMI: {bmi:F1} ({bmiStatus})");
Console.WriteLine("====================================");
Console.WriteLine($"\n\nThank you {firstName}");
Console.WriteLine("Press any key for exit...");



Console.ReadKey();
