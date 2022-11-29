using System;

//Який принцип S.O.L.I.D. порушено? Виправте!
//було порушено принцип відкритості/закритості (OSP)

/*Зверніть увагу на клас EmailSender. Крім того, що за допомогою методу Send, він відправляє повідомлення, 
він ще і вирішує як буде вестися лог. В даному прикладі лог ведеться через консоль.
Якщо трапиться так, що нам доведеться міняти спосіб логування, то ми будемо змушені внести правки в клас EmailSender.
Хоча, здавалося б, ці правки не стосуються відправки повідомлень. Очевидно, EmailSender виконує кілька обов'язків і, 
щоб клас ні прив'язаний тільки до одного способу вести лог, потрібно винести вибір балки з цього класу.*/
public class Email
{
    public String Theme { get; set; }
    public String From { get; set; }
    public String To { get; set; }
}

public class EmailSender
{
    public void Send(Email email, Ilog logger)
    {
        // ... sending...
        string message = "Email from '" + email.From + "' to '" + email.To + "' was send";
        logger.Log(message);
    }
}
public interface Ilog
{
    void Log(string message);
}

public class logConsole : Ilog
{
    void Log(string message)
    {
        Console.WriteLine(message);
    }
}
// та інші способи введення логу
public class logFileTxt : Ilog
{
    void Log(string message) { /*...*/}
}




class Program
{
    static void Main(string[] args)
    {
        Email e1 = new Email() { From = "Me", To = "Vasya", Theme = "Who are you?" };
        Email e2 = new Email() { From = "Vasya", To = "Me", Theme = "vacuum cleaners!" };
        Email e3 = new Email() { From = "Kolya", To = "Vasya", Theme = "No! Thanks!" };
        Email e4 = new Email() { From = "Vasya", To = "Me", Theme = "washing machines!" };
        Email e5 = new Email() { From = "Me", To = "Vasya", Theme = "Yes" };
        Email e6 = new Email() { From = "Vasya", To = "Petya", Theme = "+2" };

        logConsole logCons = new logConsole();
        EmailSender es = new EmailSender();
        es.Send(e1, logCons);
        es.Send(e2, logCons);
        es.Send(e3, logCons);
        es.Send(e4, logCons);
        es.Send(e5, logCons);
        es.Send(e6, logCons);

        Console.ReadKey();
    }
}