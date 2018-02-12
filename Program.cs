using System;
using System.Collections.Generic;
using System.IO;


abstract class Book
{

    protected String title;
    protected String author;

    public Book(String t, String a)
    {
        title = t;
        author = a;
    }
    public abstract void display();


}

//Write MyBook class
class MyBook : Book
{
    public int price;

    public MyBook(String t2, String a2, int p2) : base(t2, a2)
    {
        this.title = t2;
        this.author = a2;
        this.price = p2;
        
    }

    public override void display()
    {
        Console.WriteLine("{0}: {1}", "Title", this.title);
        Console.WriteLine("{0}: {1}", "Author", this.author);
        Console.WriteLine("{0}: {1}", "Price", this.price);
    }

}

class Solution
{
    static void Main(String[] args)
    {
        String title = Console.ReadLine();
        String author = Console.ReadLine();
        int price = Int32.Parse(Console.ReadLine());
        Book new_novel = new MyBook(title, author, price);
        new_novel.display();

        //Console.ReadKey();
    }
}
