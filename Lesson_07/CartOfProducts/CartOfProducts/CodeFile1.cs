using System;

class Product
{
    private string name;
    private int price;

    public Product(string name, int price)
    {
        this.name = name;
        this.price = price;
    }
    public string getName()
    {
        return name;
    }
    public int getPrice()
    {
        return price;
    }
}


class Cart
{
    Product[] products = new Product[10];
    public void addProduct(Product product)
    {
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i] == null)
            {
                products[i] = product;
                break;
            }
        }
    }

    public void removeProduct(string name)
    {
        for (int i = 0; i < products.Length; i++)
        {
            if (name == products[i].getName())
            {
                products[i] = null;
                break;
            }
        }
    }

    public void showCart()
    {
        Console.WriteLine("CART:");
        int total = 0;
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i] != null)
            {
                Console.WriteLine("\t" + products[i].getName() + " : " + products[i].getPrice());
                total += products[i].getPrice();
            }
        }
        Console.WriteLine("\t\tCART TOTAL: " + total);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("Coca-Cola", 15);
        Product p2 = new Product("Pepsi-Cola", 17);
        Product p3 = new Product("Milk", 26);
        Product p4 = new Product("Jack Daniels Fire", 450);
        Product p5 = new Product("Honey", 250);
        Cart cart = new Cart();
        cart.addProduct(p1);
        cart.addProduct(p3);
        cart.addProduct(p4);
        cart.addProduct(p5);
        cart.showCart();
        cart.removeProduct("Milk");
        cart.showCart();

        Console.ReadKey();
    }
}