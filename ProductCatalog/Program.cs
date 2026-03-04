using System;

// README.md를 읽고 코드를 작성하세요.

Product[] products = new Product[]
{
    new Electronics("노트북", 1500000, 24),
    new Clothing("청바지", 89000, "M"),
    new Food("우유", 3500, "2026-06-15")
};


Console.WriteLine("=== 상품 카탈로그 ===");
foreach (var product in products)
{
    Console.WriteLine(product);
    product.GetDescription();
}





class Product
{
    public string Name;
    public int Price;
    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} - ₩{Price:n0}";
    }
    virtual public void GetDescription()
    {

    }
}

class Electronics : Product
{
    public int Warranty;
    public Electronics(string name, int price, int warranty) : base(name, price)
    {
        Warranty = warranty;
    }

    public override string ToString()
    {
        return $"{Name} - ₩{Price:n0} (보증: {Warranty}개월)";
    }
    public override void GetDescription()
    {
        Console.WriteLine($"  -> 전자기기입니다. 취급에 주의하세요.");
    }
}
class Clothing : Product
{
    public string Size;
    public Clothing(string name, int price, string size) : base(name, price)
    {
        Size = size;
    }

    public override string ToString()
    {
        return $"{Name} - ₩{Price:n0} (사이즈: {Size})";
    }
    public override void GetDescription()
    {
        Console.WriteLine($"  -> 의류입니다. 세탁 방법을 확인하세요.");
    }
}
class Food : Product
{
    public string ExpirationDate;
    public Food(string name, int price, string expirationDate) : base(name, price)
    {
        ExpirationDate = expirationDate;
    }

    public override string ToString()
    {
        return $"{Name} - ₩{Price:n0} (유통기한: {ExpirationDate})";
    }
    public override void GetDescription()
    {
        Console.WriteLine($"  -> 식품입니다. 냉장 보관하세요.");
    }
}
