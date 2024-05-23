using System;
using System.Collections.Generic;

public class Phonebook
{
    public string name;
    public double number;
    public string address;

    public Phonebook(string name, double number, string address)
    {
        this.name = name;
        this.number = number;
        this.address = address;
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<Phonebook> phonebook = new List<Phonebook>();
        Console.WriteLine("would you like to add a contact?");
        string answer = Console.ReadLine();
        while (true)
        {

            if (answer == "yes")
            {
                Console.WriteLine("what is the name of the contact?");
                string name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("you must enter a name");
                }
                Console.WriteLine("what is the number of the contact?");
                double number = Convert.ToInt64(Console.ReadLine());
                if (number == 0)
                {
                    Console.WriteLine("you must enter a number");
                }
                Console.WriteLine("what is the address of the contact?");
                string address = Console.ReadLine();
                if (address == "")
                {
                    Console.WriteLine("you must enter an address");
                }
                phonebook.Add(new Phonebook(name, number, address));
                Console.WriteLine("would you like to add another contact or see ?");
                string answer2 = Console.ReadLine();

                if (answer2 == "no")
                {
                    Console.WriteLine("Thankyou for adding the contract");

                    break;
                }
                else if (answer2 == "see")
                {
                    foreach (Phonebook contact in phonebook)
                    {
                        Console.WriteLine("Name: " + contact.name);
                        Console.WriteLine("Number: " + contact.number);
                        Console.WriteLine("Address: " + contact.address);
                        Console.WriteLine("--------------------------------");
                    }

                }
            }
            else
            {
                Console.WriteLine("Thankyou for adding the contract");
                break;
            }
        }

    }
}
