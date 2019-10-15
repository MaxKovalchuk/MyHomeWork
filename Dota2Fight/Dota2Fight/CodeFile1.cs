using System;

class Dota2
{
    static void Main()
    {
        Inventory svenInventory = new Inventory();
        Inventory terrorbladeInventory = new Inventory();
        Inventory necrophosInventory = new Inventory();

        Sven sven = new Sven(50, 33, 28, 2000, 10, "Sven", "strength", svenInventory);
        Terrorblade terrorblade = new Terrorblade(36, 68, 32, 1550, 18, "Terrorblade", "agility", terrorbladeInventory);
        Necrophos necrophos = new Necrophos(40, 30, 58, 1780, 8, "Necrophos", "intelligence", necrophosInventory);
        Item item1 = new Item("Monkey King Bar", 4175);
        Item item2 = new Item("Divine Rapier", 6000);
        Item item3 = new Item("Aghanim's Scepter", 4200);
        Item item4 = new Item("Daedalus", 5330);
        Item item5 = new Item("Shiva's Guard", 4750);
        Item item6 = new Item("Diffusal Blade", 3150);
        Item item7 = new Item("Heart of Tarrasque", 5200);
        Item item8 = new Item("Crimson Gueard", 3700);
        Fight fight1 = new Fight(sven, necrophos);
        Fight fight2 = new Fight(sven, terrorblade);
        Fight fight3 = new Fight(terrorblade, necrophos);

        int key1, key2;
        /*Inventory svenInventory = new Inventory();
        Inventory necrophosInventory = new Inventory();
        Sven sven = new Sven(50, 33, 28, 2000, 10, "Sven", "strength", svenInventory);
        Necrophos necrophos = new Necrophos(40, 30, 58, 1780, 8, "Necrophos", "intelligence", necrophosInventory);
        sven.getInfo();
        necrophos.getInfo();
        svenInventory.buyItem(item4, sven);
        svenInventory.buyItem(item7, sven);     
        necrophosInventory.buyItem(item3, necrophos);
        necrophosInventory.buyItem(item5, necrophos);
        sven.getInfo();
        necrophos.getInfo();
        Fight fight1 = new Fight(sven, necrophos);
        fight1.fight();*/

        do
        {
            Console.WriteLine("Choose an action to do : \n 1 - open shop; 2 - start battle, 0 - close the program");
            key1 = Convert.ToInt32(Console.ReadLine());

            switch (key1)
            {
                case 1:
                    Console.WriteLine("Shop : choose an action : \n 1 - buy item; 2 - sell item" +
                        ", 0 - go to the previous menu.");
                    do
                    {
                        key2 = Convert.ToInt32(Console.ReadLine());
                        switch (key2)
                        {
                            case 1:
                                do
                                {
                                    key2 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Chose item from the list Monkey King Bar, Divine Rapier, " +
                                        " Aghanim's Scepter, " + 
                                        "Daedalus, Shiva's Guard, Diffusal Blade, Heart of Tarrasque, Crimson Guard");
                                    switch (key2)
                                    {
                                        case 1:

                                            break;
                                        case 2:

                                            break;
                                        case 3:

                                            break;
                                        case 4:

                                            break;
                                        case 5:

                                            break;
                                        case 6:

                                            break;
                                        case 7:

                                            break;
                                        case 8:

                                            break;
                                        default:
                                            Console.WriteLine("Choose corect number please!");
                                            break;
                                    }
                                } while (key2 != 0);
                                break;
                            case 2:
                                do
                                {
                                    key2 = Convert.ToInt32(Console.ReadLine());
                                    switch (key2)
                                    {
                                        case 1:

                                            break;
                                        case 2:

                                            break;
                                        default:
                                            Console.WriteLine("Choose corect number please!");
                                            break;
                                    }
                                } while (key2 != 0);
                                break;
                            default:
                                Console.WriteLine("Choose corect number please!");
                                break;
                        }
                    } while (key2 != 0);
                    break;
                case 2:
                    Console.WriteLine("Battle : 1 - Sven vs Necrophos, 2 - Sven - vs Terrorblade, 3" +
                        " - Terrorblade vs Necrophos, 0 - go to the previous menu.");
                    do
                    {
                        key2 = Convert.ToInt32(Console.ReadLine());
                        switch (key2)
                        {
                            case 1:
                                fight1.fight();
                                break;
                            case 2:
                                fight2.fight();
                                break;
                            case 3:
                                fight3.fight();
                                break;
                            default:
                                Console.WriteLine("Choose corect number please!");
                                break;
                        }
                    } while (key2 != 0);
                    break;
                default:
                    Console.WriteLine("Choose corect number please!");
                    break;
            }
        } while (key1 != 0);


        Console.ReadKey();
    }
}
abstract class Hero
{
    protected int strength;
    protected int agility;
    protected int intelligence;
    protected int strikePower = 0;
    protected int HP;
    protected int armor = 0;
    protected string name;
    protected string type;
    protected Inventory inventory = new Inventory();

    public Hero(int strength, int agility, int intelligence,
        int HP, int armor, string name, string type, Inventory inventory)
    {
        this.strength = strength;
        this.agility = agility;
        this.intelligence = intelligence;
        this.HP = HP;
        this.name = name;
        this.inventory = inventory;
        this.type = type;
        setStrikePower();
        setArmor();
    }
    public void addStats(int strength, int agility, int intelligence,
        int HP, int armor, int strikePower)
    {
        this.strength += strength;
        this.agility += agility;
        this.intelligence += intelligence;
        this.HP += HP;
        this.armor += armor;

        if (type == "strength")
        {
            this.strikePower += strikePower + strength + agility / 2 + intelligence / 2;
        }
        else if (type == "agility")
        {
            this.strikePower += strikePower + strength / 2 + agility + intelligence / 2;
        }
        else if (type == "intelligence")
        {
            this.strikePower += strikePower + strength / 2 + agility / 2 + intelligence;
        }
    }
    public int getStrikePower()
    {
        return strikePower;
    }
    public void setHP(int HP)
    {
        this.HP = HP;
    }
    public int getArmor()
    {
        return armor;
    }
    public int getHP()
    {
        return HP;
    }
    abstract protected void setStrikePower();
    abstract protected void setArmor();
    public void getInfo()
    {
        Console.Write(name + " has : S : " + strength + "; A : "
            + agility + "; I :" + intelligence + "; StrikePower : "
            + strikePower + "; HP : " + HP + "; armor : " + armor + "\n");
    }
}
class Item
{
    private string name;
    private int itemCost;
    public Item(string name, int itemCost)
    {
        if (checkItem(name, itemCost))
        {
            this.name = name;
            this.itemCost = itemCost;
        }
    }
    private string[] itemShop = new string[8] {"Monkey King Bar", "Divine Rapier", "Aghanim's Scepter",
        "Daedalus", "Shiva's Guard", "Diffusal Blade", "Heart of Tarrasque", "Crimson Guard"};
    private int[] itemsCost = new int[8] { 4175, 6000, 4200, 5330, 4750, 3150, 5200, 3700 };
    public string getName()
    {
        return name;
    }
    public int getItemCost()
    {
        return itemCost;
    }
    public bool checkItem(string name, int itemCost)
    {
        for (int i = 0; i < itemShop.Length; i++)
        {
            if (name == itemShop[i] & itemCost == itemsCost[i])
            {
                return true;
            }
        }
        return false;
    }
}
class Inventory
{
    protected Item[] items = new Item[6];
    protected int goldAmount = 25000;
    public void buyItem(Item item, Hero hero)
    {
        if (goldAmount > item.getItemCost())
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    items[i] = item;
                    break;
                }
            }
            goldAmount -= item.getItemCost();
            Console.WriteLine("\n" + getGold());

            if (item.getName() == "Monkey King Bar")
            {
                hero.addStats(0, 0, 0, 0, 0, 52);
            }
            else if (item.getName() == "Divine Rapier")
            {
                hero.addStats(0, 0, 0, 0, 0, 330);
            }
            else if (item.getName() == "Aghanim's Scepter")
            {
                hero.addStats(10, 10, 10, 175, 0, 0);
            }
            else if (item.getName() == "Daedalus")
            {
                hero.addStats(0, 0, 0, 0, 0, 80);
            }
            else if (item.getName() == "Shiva's Guard")
            {
                hero.addStats(0, 0, 30, 0, 15, 0);
            }
            else if (item.getName() == "Diffusal Blade")
            {
                hero.addStats(0, 20, 10, 0, 0, 0);
            }
            else if (item.getName() == "Heart of Tarrasque")
            {
                hero.addStats(45, 0, 0, 400, 0, 0);
            }
            else if (item.getName() == "Crimson Gueard")
            {
                hero.addStats(2, 2, 2, 250, 5, 0);
            }
        }
        else { Console.WriteLine("Not enough money"); }
    }
    public void sellItem(string name, Item item)
    {
        goldAmount += item.getItemCost() / 2;
        for (int i = 0; i < items.Length; i++)
        {
            if (name == items[i].getName())
            {
                items[i] = null;
                break;
            }
        }
        Console.WriteLine("Gold : " + getGold());
    }
    public int getGold()
    {
        return goldAmount;
    }
}
class Terrorblade : Hero
{

    public Terrorblade(int strength, int agility, int intelligence,
        int HP, int armor, string name, string type, Inventory inventory)
        : base(strength, agility, intelligence, HP, armor, name, type, inventory)
    {
    }
    protected override void setStrikePower()
    {
        strikePower = strength / 2 + agility + intelligence / 2;
    }
    protected override void setArmor()
    {
        armor = agility / 10 + 5;
    }
}
class Sven : Hero
{
    public Sven(int strength, int agility, int intelligence,
        int HP, int armor, string name, string type, Inventory inventory)
        : base(strength, agility, intelligence, HP, armor, name, type, inventory)
    {
    }
    protected override void setStrikePower()
    {
        strikePower = strength + agility / 2 + intelligence / 2;
    }
    protected override void setArmor()
    {
        armor = agility / 10 + 5;
    }
}
class Necrophos : Hero
{
    public Necrophos(int strength, int agility, int intelligence,
        int HP, int armor, string name, string type, Inventory inventory)
        : base(strength, agility, intelligence, HP, armor, name, type, inventory)
    {
    }
    protected override void setStrikePower()
    {
        strikePower = strength / 2 + agility / 2 + intelligence;
    }
    protected override void setArmor()
    {
        armor = agility / 10 + 5;
    }
}
class Fight
{
    Hero firstHero;
    Hero secondHero;

    public Fight(Hero firstHero, Hero secondHero)
    {
        this.firstHero = firstHero;
        this.secondHero = secondHero;
    }

    public void fight()
    {
        while (firstHero.getHP() > 0 & secondHero.getHP() > 0)
        {
            int temp1 = firstHero.getHP() - secondHero.getStrikePower() * (100 - firstHero.getArmor()) / 100;
            int temp2 = firstHero.getHP() - secondHero.getStrikePower() * (100 - firstHero.getArmor()) / 100;
            firstHero.setHP(temp1);
            secondHero.setHP(temp2);
            firstHero.getInfo();
            secondHero.getInfo();
            Console.WriteLine();
        }
    }
}