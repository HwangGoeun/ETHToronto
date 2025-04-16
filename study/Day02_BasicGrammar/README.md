# 📝 Day 02: C# Basics

🎥 **Course:** [Bro Code - C# Full Course for free 🚀](https://www.youtube.com/watch?v=wxznTygnRfQ&t=1s)  
⏱️ **Progress:** 1:46:53 ~ 2:57:07 (Chapters 21–37)

---
<br>

## Array
- A variable that can store **multiple values**.
- **Fixed size** (once declared).
```c#
String[] cars = { "BMW", "Mustang", "Corvette" };
cars[0] = "Tesla";

Console.WriteLine(cars[0]); // Access by index
```

### Multidimensional Array
``` c#
string[,] parkingLot = {
    { "Mustang", "F-150", "Explorer" },
    { "Corvette", "Camaro", "Silverado" },
    { "Corolla", "Camry", "Rav4" }
};

parkingLot[0, 2] = "Fusion";
parkingLot[2, 0] = "Tacoma";
```

---
<br>

## Foreach Loop
```c#
foreach (String car in cars) {
    Console.WriteLine(car);
}
```

---
<br>

## Methods
```c#
static void Main(string[] args)
{
    String name = "Goeun";
    int age = 21;

    SingHappyBirthDay(name, age);
}

static void SingHappyBirthDay(String name, int age) {
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine("Happy birthday dear " + name);
    Console.WriteLine("You are " + age + " years old!");
    Console.WriteLine();
}
```

### Return Keyword
``` c#
static double Multiply(double x, double y) {
    return x * y;
}
```

### Method Overloading
```csharp
static double Multiply(double x, double y) {
    return x * y;
}

static double Multiply(double x, double y, double z) {
    return x * y * z;
}
```

### `params` Keyword
```csharp
static void Main(string[] args) {
    double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);
    Console.WriteLine($"Total: {total}");
}

static double CheckOut(params double[] prices) {
    double total = 0;

    foreach (double price in prices) {
        total += price;
    }

    return total;
}
```

---
<br>

## Exception Handling
In C#, `try-catch` blocks are used to gracefully handle runtime errors that would otherwise crash the program.

- `try`: Wraps the code that might throw an exception.
- `catch`: Handles specific exceptions and prevents the program from crashing.
- `finally`: (optional) Executes code regardless of whether an exception was thrown or not.

### Common exceptions:
- `FormatException`: Occurs when trying to convert an invalid string to a number.
- `DivideByZeroException`: Occurs when dividing a number by zero.
```csharp
try {
    double x = Convert.ToDouble(Console.ReadLine());
    double y = Convert.ToDouble(Console.ReadLine());

    double result = x / y;
    Console.WriteLine($"Result: {result}");
}
catch (FormatException e) {
    Console.WriteLine("Enter ONLY numbers!");
}
catch (DivideByZeroException e) {
    Console.WriteLine("You can't divide by zero!");
}
finally {
    Console.WriteLine("Thank you for visiting.");
}
```

### Additional Concepts to Remember

| Concept | Description |
|--------|-------------|
| `Exception` | The base class for all exceptions in C#. You can use it to catch any type of error. |
| `e.Message` | Returns a message that describes the current exception. Useful for debugging or logging. |
| `catch (Exception e)` | A general catch block that can handle any kind of exception. It’s a good fallback but should be used carefully. |
| `finally` | Runs regardless of whether an exception was thrown. Often used for cleanup (e.g., closing files, releasing resources). |
| Multiple `catch` blocks | You can have more than one `catch` to handle different types of exceptions separately. |

---
<br>

## Conditional Operator
```csharp
double temperature = 20;
string message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";
Console.WriteLine(message);
```

---
<br>

## Classes
### Class Declaration
```c#
static void Main(string[] args) {
    Messages.Hello();
}

class Messages {
    public static void Hello() {
        Console.WriteLine("Hello! Welcome to the program");
    }
}
```

### Object
``` c#
class Human {
    public string name;
    public int age;

    public void Eat() {
        Console.WriteLine(name + " is eating");
    }

    public void Sleep() {
        Console.WriteLine(name + " is sleeping");
    }
}

static void Main(string[] args) {
    Human human1 = new Human();
    human1.name = "Rick";
    human1.age = 65;

    Human human2 = new Human();
    human2.name = "Morty";
    human2.age = 16;

    human1.Eat(); human1.Sleep();
    human2.Eat(); human2.Sleep();
}
```

### Constructor
```c#
class Human {
    string name;
    int age;

    public Human(string name, int age) {
        this.name = name;
        this.age = age;
    }
}

static void Main(string[] args) {
    Human human1 = new Human("Rick", 65);
    Human human2 = new Human("Morty", 16);
}
```

### Static
```csharp
class Car {
    string model;
    public static int numberOfCars;

    public Car(string model) {
        this.model = model;
        numberOfCars++;
    }

    public static void StartRace() {
        Console.WriteLine("The race has begun!");
    }
}
```

---
<Br>
<Br>
<Br>

# 💾 Reflection
The more I study C#, the more I realize how similar it feels to Java. Although I'm still in the basic syntax stage and have no clear sense of how this language will be used in the blockchain context, it almost feels like I'm revisiting Java after a long time — and I’m really enjoying it.