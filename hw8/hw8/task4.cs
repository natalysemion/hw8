using System;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/

// ,було порушено принцип розділення інтерфейсу (ISP)
interface IItemPrice
{
    void SetPrice(double price);
}

interface IItemDiscount
{
    void SetDiscount(String discount);
}
public interface IItemPromocode
{
    void SetPromocode(String promocode);
}
public interface IItemCharacteristics
{
    public void SetColor(byte color) { }
    public void SetSize(byte size) { }
}

public class Book : IItemPrice, IItemDiscount
{
    public double Price;
    public string Discount;

    public void SetPrice(double _price)
    {
        Price = _price;
    }

    public void SetDiscount(string _discount)
    {
        Discount = _discount;
        /*
        if (int.TryParse(discount, int discount){
            price -= discount;
        }
        else
        {
            Console.WriteLine("Wrong value in discount");
        }*/
    }
}

public class Outerwear : IItemPrice, IItemCharacteristics
{
    public double Price;
    public byte Colour;
    public byte Size;

    void SetPrice(double _price)
    {
        Price = _price;
    }
    void SetColor(byte color)
    {
        Colour = color;
    }
    void SetSize(byte size)
    {
        Size = size;
    }
}


class Program
{
    static void Main(string[] args)
    {

        Console.ReadKey();
    }
}