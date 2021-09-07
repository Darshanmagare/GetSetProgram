
using System;

namespace GetSetProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Getset obj = new Getset();
            obj.Fname = "Darshan";
            obj.Lname = "Magare";
            Console.WriteLine(obj.Fname);
            Console.WriteLine(obj.Lname);

            //AbstractChildClass obj1 = new AbstractChildClass();
            //Console.WriteLine(obj1.city);

        }
    }



class Getset
{
    public Getset() 
    { 
    
    }
    private string fname;  //private variables
    private string lname;
    private int id;

    public string Fname //public properties
    {
        get  //get method
        {
            return fname;
        }
        set
        {
            fname = value;
        }
    }
    public string Lname;
    {
        get;
        //set;

    }

    public int Id
    {
    get { return id; }
    set { this.id = value; }

    }

    public void test(int id)
    {
    this.id = id;
    Console.WriteLine(id);
    }


    }
}

public class child : Getset
{
    public void Print()
    {
        base.Fname = "Darshan";
        base.Lname = "Magare";
        base.test(10);
    }
}

public abstract class abstraction
{
    private string cityname;

}




public class AbstractChildClass : abstraction
{
    public override void abstraction()
    {
         public override void abstracttest()
          {
        Console.WriteLine("Override method");

          }
         public 
    }
}
}