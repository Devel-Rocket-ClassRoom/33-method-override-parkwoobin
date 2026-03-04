using System;

// README.md를 읽고 코드를 작성하세요.

Parent parent = new Parent();
parent.Work();
Child child = new Child();
child.Work();

Animal animal = new Animal();
animal.Eat();
Animal cat = new Cat();
cat.Eat();

Child1 child1 = new Child1();
child1.Say();
child1.Run();
child1.Walk();
Console.WriteLine();

// 부모 클래스의 참조 변수로 자식 클래스의 객체를 참조할 수 있다.
Parent1 parent1 = child1;
parent1.Say();
parent1.Run();
parent1.Walk();

Calculator calculator = new Calculator();
Console.WriteLine(calculator.Add(1, 2));
Console.WriteLine(calculator.Add(2, 2));
Console.WriteLine(calculator.Add(1, 2, 3));

Animal1 animal1 = new Animal1();
animal1.Speak();

Animal1 dog1 = new Dog1();
dog1.Speak();

Animal1 cat1 = new Cat1();
cat1.Speak();

Parent2 child2 = new Child2();
child2.Greet();

new Parent3().Work();
new Child3().Work();
new GrandChild().Work();

new Parent4().Work();
new Child4().Work();
new GrandChild1().Work();
new GrandChild1().Play();

Person person = new Person { Name = "홍길동" };
Console.WriteLine(person);
Console.WriteLine(person.ToString());

Person1 person1 = new Person1 { Name = "박용준" };
Console.WriteLine(person1);

Character character1 = new Character { Name = "용사", Level = 10, Health = 100 };
Character character2 = new Character { Name = "마법사", Level = 8, Health = 70 };
Console.WriteLine(character1);
Console.WriteLine(character2);

Character1 warrior = new Warrior("전사");
Character1 mage = new Mage("마법사");
Character1 archer = new Archer("궁수");
Console.WriteLine(warrior);
Console.WriteLine(mage);
Console.WriteLine(archer);

warrior.Attack();
mage.Attack();
archer.Attack();

Character1[] party = new Character1[]
{
    new Warrior("전사"),
    new Mage("마법사"),
    new Archer("궁수")
};

Console.WriteLine("===파티 공격===");
foreach (Character1 character in party)
{
    character.Attack();
}




class Parent
{
    virtual public void Work()
    {
        Console.WriteLine("프로그래머");
    }
}

class Child : Parent
{
    public override void Work()
    {
        Console.WriteLine("프로게이머");
    }
}

class Animal
{
    virtual public void Eat()
    {
        Console.WriteLine("Animal Eat");
    }
}

class Cat : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Cat Eat");
    }
}

class Parent1
{
    public void Say()
    {
        Console.WriteLine("부모_안녕하세요.");
    }
    public void Run()
    {
        Console.WriteLine("부모_달리다.");
    }
    virtual public void Walk()
    {
        Console.WriteLine("부모_걷다.");
    }
}

class Child1 : Parent1
{
    public new void Say()
    {
        Console.WriteLine("자식_안녕하세요.");
    }
    public new void Run()
    {
        Console.WriteLine("자식_달리다.");
    }
    override public void Walk()
    {
        Console.WriteLine("자식_걷다.");
    }
}

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Animal1
{
    virtual public void Speak()
    {
        Console.WriteLine("동물이 소리를 낸다");
    }
}

class Dog1 : Animal1
{
    public override void Speak()
    {
        Console.WriteLine("멍멍!");
    }
}

class Cat1 : Animal1
{
    public override void Speak()
    {
        Console.WriteLine("야옹!");
    }
}

class Parent2
{
    virtual public void Greet()
    {
        Console.WriteLine("안녕하세요.");
    }
}

class Child2 : Parent2
{

    public override void Greet()
    {
        base.Greet();
        Console.WriteLine("반갑습니다.");
    }
}

class Parent3
{
    virtual public void Work()
    {
        Console.WriteLine("프로그래머");
    }
}
class Child3 : Parent3
{
    public override void Work()
    {
        base.Work();
    }

}
class GrandChild : Child3
{
    public override void Work()
    {
        Console.WriteLine("프로게이머");
    }
}

class Parent4
{
    virtual public void Work()
    {
        Console.WriteLine("프로그래머");
    }
}
class Child4 : Parent4
{
    sealed public override void Work()
    {
        base.Work();
    }
}
class GrandChild1 : Child4
{
    // Child4 클래스의 Work 메서드는 sealed 로 봉인되어 있어서 override로 재정의 불가
    public void Play()
    {
        Console.WriteLine("프로게이머");
    }
}

class Person
{
    public string Name { get; set; }

}

class Person1
{
    public string Name { get; set; }
    public override string ToString()
    {
        return $"[Person1 클래스: {Name}]";
    }
}

class Character
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Health { get; set; }

    public override string ToString()
    {
        return $"[{Name}] Lv.{Level} HP:{Health}";
    }
}

class Character1
{
    public string Name;
    public int AttackPower;

    public Character1(string name, int attackPower)
    {
        Name = name;
        AttackPower = attackPower;
    }


    virtual public void Attack() { }
    public override string ToString()
    {
        return $"[{Name}] 공격력 :{AttackPower}";
    }
}

class Warrior : Character1
{
    public Warrior(string name) : base(name, 50) { }
    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 칼로 베어냅니다! 데미지: {AttackPower}");
    }
}
class Mage : Character1
{
    public Mage(string name) : base(name, 30) { }
    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 파이어볼을 시전합니다! 데미지: {AttackPower}");
    }
}
class Archer : Character1
{
    public Archer(string name) : base(name, 40) { }
    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 활을 쏩니다! 데미지: {AttackPower}");
    }
}
