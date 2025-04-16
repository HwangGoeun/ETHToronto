# 📝 Day 03: C# Basics

🎥 **Course:** [Bro Code - C# Full Course for free 🚀](https://www.youtube.com/watch?v=wxznTygnRfQ&t=1s)  
⏱️ **Progress:** 2:57:08 ~ 3:40:25 (Chapters 38–47)

---
<br>

## Array of Objects
An array can store object instances just like primitive values.
```c#
class Program {
    static void Main(string[] args) {   
        Car[] garage = {
            new Car("Mustang"),
            new Car("Corvette"),
            new Car("Lambo"),
        };

        foreach (Car car in garage) {
            Console.WriteLine(car.model);
        }
    }
}

class Car {
    public string model;

    public Car(string model) {
        this.model = model;
    }
}
```

---
<br>

## Objects as Arguments
Objects are passed by reference, so modifications inside methods affect the original instance.
```c#
class Program {
    static void Main(string[] args) {
        Car car1 = new Car("Mustang", "red");

        ChangeColor(car1, "silver");
        Console.WriteLine(car1.color + " " + car1.model);

        Car car2 = Copy(car1);
        Console.WriteLine(car2.color + " " + car2.model);
    }

    public static void ChangeColor(Car car, string color) {
        car.color = color;
    }

    public static Car Copy(Car car) {
        return new Car(car.model, car.color);
    }
}

class Car {
    public string model;
    public string color;

    public Car(string model, string color) {
        this.model = model;
        this.color = color;
    }
}
```

---
<br>

## Method Overriding
Method overriding allows child classes to provide specific behavior for inherited methods. The base method must be marked as `virtual`.
``` c#
class Program {
    static void Main(string[] args) {
        Dog dog = new Dog();
        Cat cat = new Cat();

        dog.Speak();
        cat.Speak();
    }
}

class Animal {
    public virtual void Speak() {
        Console.WriteLine("The animal goes *brrr*");
    }
}

class Dog : Animal {
    public override void Speak() {
        Console.WriteLine("The dog goes *woof*");
    }
}

class Cat : Animal {
    public override void Speak() {
        Console.WriteLine("The cat goes *meow*");
    }
}
```

---
<br>

## ToString Method
`ToString()` converts an object to a human-readable string, which is useful for logging and debugging.
``` c#
class Program {
    static void Main(string[] args) {
        Car car = new Car("Chevy", "Corvette", 2022, "blue");
        Console.WriteLine(car.ToString());
        Console.WriteLine(car);
    }
}

class Car {
    string make;
    string model;
    int year;
    string color;

    public Car(string make, string model, int year, string color) {
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
    }

    public override string ToString() {
        return $"This is a {make} {model}";
    }
}
```

---
<br>

## Polymorphism
Allows an object to take many forms. Common with base-class references pointing to derived objects.
``` c#
class Program {
    static void Main(string[] args) {
        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Boat boat = new Boat();

        Vehicle[] vehicles = { car, bicycle, boat };

        foreach (Vehicle vehicle in vehicles) {
            vehicle.Go();
        }
    }
}

class Vehicle {
    public virtual void Go() { }
}

class Car : Vehicle {
    public override void Go() {
        Console.WriteLine("The car is moving!");
    }
}

class Bicycle : Vehicle {
    public override void Go() {
        Console.WriteLine("The bicycle is moving!");
    }
}

class Boat : Vehicle {
    public override void Go() {
        Console.WriteLine("The boat is moving!");
    }
}
```

---
<br>

## Interfaces
Interfaces define behavior contracts. A class must implement all declared members of an interface.
``` c#
class Program {
    static void Main(string[] args) {
        Rabbit rabbit = new Rabbit();
        Hawk hawk = new Hawk();
        Fish fish = new Fish();

        rabbit.Flee();
        hawk.Hunt();
        fish.Flee();
        fish.Hunt();
    }
}

interface IPrey {
    void Flee();
}

interface IPredator {
    void Hunt();
}

class Rabbit : IPrey {
    public void Flee() {
        Console.WriteLine("The rabbit runs away!");
    }
}

class Hawk : IPredator {
    public void Hunt() {
        Console.WriteLine("The hawk is searching for food!");
    }
}

class Fish : IPrey, IPredator {
    public void Flee() {
        Console.WriteLine("The fish swims away!");
    }

    public void Hunt() {
        Console.WriteLine("The fish is searching for smaller fish.");
    }
}
```

---
<br>

## Lists
### List of Primitives
List is a dynamic array. You can add, remove, insert, sort, and convert to arrays.
```c#
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        List<string> food = new List<string>();

        food.Add("pizza");
        food.Add("hamburger");
        food.Add("hotdog");
        food.Add("fries");

        foreach (string item in food) {
            Console.WriteLine(item);
        }

        food.Remove("fries");
        food.Insert(0, "sushi");

        Console.WriteLine(food.Count);
        Console.WriteLine(food.IndexOf("pizza"));
        Console.WriteLine(food.Contains("pizza"));

        food.Sort();
        food.Reverse();
        string[] foodArray = food.ToArray();
    }
}
```
<br>

| Method               | Description |
|----------------------|-------------|
| `Add(item)`          | Adds an item to the end of the list. |
| `Remove(item)`       | Removes the first occurrence of the specified item. |
| `Insert(index, item)`| Inserts an item at the specified index. |
| `Count`              | Gets the number of elements in the list. |
| `IndexOf(item)`      | Returns the index of the first occurrence of the item. |
| `LastIndexOf(item)`  | Returns the index of the last occurrence of the item. |
| `Contains(item)`     | Checks whether the list contains the specified item. |
| `Sort()`             | Sorts the elements in ascending order. |
| `Reverse()`          | Reverses the order of the elements. |
| `Clear()`            | Removes all elements from the list. |
| `ToArray()`          | Copies the elements to a new array. |

### List of Objects
You can also use lists to store custom class objects.
```c#
class Program {
    static void Main(string[] args) {
        List<Player> players = new List<Player> {
            new Player("Chad"),
            new Player("Steve"),
            new Player("Karen")
        };

        foreach (Player player in players) {
            Console.WriteLine(player);
        }
    }
}

class Player {
    public string username;

    public Player(string username) {
        this.username = username;
    }

    public override string ToString() {
        return username;
    }
}
```

---
<br>

## Properties
### Getters & Setters
Encapsulation in C# is implemented using properties. Setters can include logic for validation.
```c#
class Program {
    static void Main(string[] args) {
        Car car = new Car(400);
        car.Speed = 1000000000;
        Console.WriteLine(car.Speed);
    }
}

class Car {
    private int speed;

    public Car(int speed) {
        Speed = speed;
    }

    public int Speed {
        get { return speed; }
        set {
            speed = value > 500 ? 500 : value;
        }
    }
}
```

### Auto-Implemented Properties
Shorthand syntax for properties when no logic is needed.
``` c#
class Program {
    static void Main(string[] args) {
        Car car = new Car("Porsche");
        Console.WriteLine(car.Model);
    }
}

class Car {
    public string Model { get; set; }

    public Car(string model) {
        Model = model;
    }
}
```

---
<Br>
<Br>
<Br>

# 💾 Reflection
It really feels like I’m starting to learn proper object-oriented programming. While building the contact book project, I found the process of implementing the user deletion feature quite interesting. Using the `Find()` function to search for a user reminded me of working with pointers in C — especially how you assign the result to a variable and check for null. That approach of using a `null` check to either delete the user or show a `"not found"` message felt intuitive and impactful. Also, I’d like to explore more about the `=>` symbol used inside the `Find()` function — it seems like a concise and powerful feature.