# 📝 Day 01: C# Basics

🎥 **Course:** [Bro Code - C# Full Course for free 🚀](https://www.youtube.com/watch?v=wxznTygnRfQ&t=1s)  
⏱️ **Progress:** 0:00 ~ 1:18:27 (Chapters 1–17)

---
<br>

## Getting Started with C#
```bash
dotnet new console -o MyApp
cd MyApp
dotnet build
dotnet run
```

**Basic structure**
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, C#!");
    }
}
```

---
<br>

## Console Input & Output
### Input
``` c#
String name = Console.ReadLine();
int age = Convert.ToInt32(Console.ReadLine());
```

### Output
```csharp
Console.Write("Hello");     // Print without newline
Console.WriteLine("Hello"); // Print with newline

// Combine string and variables
Console.WriteLine("Your age is " + age);
Console.WriteLine($"My name is {name}, and I am {age} years old."); // string interpolation
```

### Comments
```csharp
// This is a single-line comment

/*
    This is a
    multi-line comment
*/
```

---
<br>

## Variables, Constants, and Type Conversion
### Declarations
```csharp
int x;          // declaration
x = 123;        // initialization
int y = 321;    // declaration + initialization

int age = 21;
double height = 170.5;
bool alive = true;
char symbol = '@';
string name = "Goeun";
const double pi = 3.14159;
```

### Type Conversion
```c#
int x = Convert.ToInt32("123");
double y = Convert.ToDouble(x);
string z = Convert.ToString(y);
char c = Convert.ToChar("$");
bool b = Convert.ToBoolean("true");

a.GetType(); // get a data type
```

---
<br>

## Math Operations
### Arithmetic
``` c#
int a = 10;
a += 1;
a -= 1;
a *= 2;
a /= 2;
int r = a % 3;
```

### Math Class Methods
```c#
double x = 3.14;

double a = Math.Pow(x, 2);      // power: x raised to 2 → 3.14^2 = 9.8596
double b = Math.Sqrt(x);        // square root of x
double c = Math.Abs(-10);       // absolute value → 10
double d = Math.Round(x);       // round to nearest integer → 3
double e = Math.Ceiling(x);     // round up to nearest whole number → 4
double f = Math.Floor(x);       // round down to nearest whole number → 3
double g = Math.Max(x, 5);      // maximum of x and 5 → 5
double h = Math.Min(x, 5);      // minimum of x and 5 → 3.14
```

### Random Number Generator
```c#
Random random = new Random();
int i = random.Next(1, 7); // random number between 1 and 6
double d = random.NextDouble();
```

---
<br>

## String Methods
```c#
string name = "Goeun";

name.ToUpper();             // GOEUN
name.ToLower();             // goeun
name.Length;                // 5
name.Substring(0, 3);       // Goe
phone.Replace("-", " ");    // 123 456 7890
name.Insert(0, "Ms. ");     // Ms. Goeun
```

---
<br>

## Conditionals
### If / Else If / Else
```c#
if (age < 0) {
    Console.WriteLine("Invalid");
}
else if (age < 18) {
    Console.WriteLine("Minor");
}
else {
    Console.WriteLine("Adult");
}
```

### Switch
```c#
string day = Console.ReadLine();

switch (day) {
    case "Monday":
        Console.WriteLine("It's Monday!");
        break;
    case "Tuesday":
        Console.WriteLine("It's Tuesday!");
        break;
    default:
        Console.WriteLine($"{day} is not a valid day!");
        break;
}
```

### Logical Operators
`&&` (AND)
<br>
`||` (OR)
```c#
if (age > 18 && name == "Goeun") {
    Console.WriteLine("Access granted.");
}

if (age < 18 || name != "Goeun") {
    Console.WriteLine("Access denied.");
}
```


---
<br>

## Loops
### While
``` c#
string name = "";
while (name == "") {
    Console.Write("Enter your name: ");
    name = Console.ReadLine();
}
```

### For
``` c#
for (int i = 0; i < 10; i++) {
    Console.WriteLine(i);
}

for (int i = 10; i > 0; i--) {
    Console.WriteLine(i);
}
```

### Nested Loops
```c#
int rows = Convert.ToInt32(Console.ReadLine());
int cols = Convert.ToInt32(Console.ReadLine());
string symbol = Console.ReadLine();

for (int i = 0; i < rows; i++) {
    for (int j = 0; j < cols; j++) {
        Console.Write(symbol);
    }
    Console.WriteLine();
}
```

---
<br>

## Console.ReadKey()

```csharp
Console.WriteLine("Press any key to exit...");
Console.ReadKey(); // Waits for any key press before closing

Console.Write("Press a key: ");
ConsoleKeyInfo key = Console.ReadKey();
Console.WriteLine($"\nYou pressed: {key.Key}");
```
- Pauses the program and waits for the user to press any key.
- Often used at the end of console applications to **prevent immediate exit**.
- Returns a `ConsoleKeyInfo` object if you want to inspect the key.

---
<Br>
<Br>
<Br>

# 💾 Reflection
I started learning C# after being invited by a Canadian friend I met during my exchange program to join a hackathon together.
Speaking about development topics in English still feels unfamiliar, and concepts like blockchain and Ethereum are completely new to me. On top of that, this is my first time working with the C# language.

Despite all that, I want to prepare as best I can and create something I can be proud of, without regrets.
Thankfully, the syntax isn't too different from C or Java, so I haven't had much difficulty understanding the basics so far.

However, with the deadline approaching quickly, I do feel a bit pressured to finish the fundamentals soon and dive into practical work with blockchain and Ethereum.