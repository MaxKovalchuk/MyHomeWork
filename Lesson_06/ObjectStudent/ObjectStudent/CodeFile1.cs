using System;

class ObjectStudent
{
    static void Main()
    {
        Student student = new Student();
        Console.WriteLine("Enter student's name and department");
        student.setName(Console.ReadLine());
        student.setDepartment(Console.ReadLine());
        student.setIQ(30, 220);
        student.setDepts(0, 5);
        student.setState();
        student.getInfo();
        if (student.condition() & student.checkState())
        {
            Console.WriteLine("Continualy sober! Congratulations! You have + 10 IQ");
            student.getInfo();
        }

        Console.ReadKey();
    }
}

class Student
{
    Random rnd = new Random();
    private string name;
    private string department;
    private int IQ;
    private int dept_quantity;
    private bool state;

    public void getInfo()
    {
        Console.WriteLine("Student " + name + " from " + department + " department is "
            + (true ? "sober" : "drunk ") + " and has " + IQ + " iq and " + dept_quantity + " depts.");
    }

    public bool condition()
    {
        if (state == false & IQ < 70 || dept_quantity > 3 & (state == false || IQ < 70))
            return false;
        else
            return true;
    }

    public void setName(string name)
    {
        this.name = name;
    }
    public void setDepartment(string department)
    {
        this.department = department;
    }
    public void setIQ(int a, int b)
    {
        IQ = rnd.Next(a, b);
    }
    public void setDepts(int a, int b)

    {
        dept_quantity = rnd.Next(a, b);
    }
    public void setState()
    {
        int state = rnd.Next(0, 2);

        if (state == 0)
        {
            this.state = false;
        }
        else
        {
            this.state = true;
        }
    }

    public bool checkState()
    {
        if (state)
        {
            IQ += 10;
            return true;
        }
        else
        {
            return false;
        }
    }
}