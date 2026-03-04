using System;

// README.md를 읽고 코드를 작성하세요.

Vehicle[] vehicles = new Vehicle[]
{
    new Car("스포츠카"),
    new Airplane("보잉747"),
    new Boat("요트")
};




Console.WriteLine("=== 경주 시작! ===");
foreach (var vehicle in vehicles)
{
    vehicle.Move();
}

class Vehicle
{
    public string Name;
    public int Speed;

    public Vehicle(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }

    virtual public void Move()
    {
        Console.WriteLine($"{Name}이(가) 이동합니다! 속도: {Speed}km/h");
    }
}
class Car : Vehicle
{
    public Car(string name, int speed = 120) : base(name, speed) { }

    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 도로를 달립니다! 속도: {Speed}km/h");
    }
}
class Airplane : Vehicle
{
    public Airplane(string name, int speed = 900) : base(name, speed) { }

    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 하늘을 납니다! 속도: {Speed}km/h");
    }
}
class Boat : Vehicle
{
    public Boat(string name, int speed = 60) : base(name, speed) { }

    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 바다를 항해합니다! 속도: {Speed}km/h");
    }
}
