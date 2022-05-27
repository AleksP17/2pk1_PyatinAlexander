using System;
delegate void MyDelegate();

namespace pz_2_9
{
    class Program
    {
        class BankAccount
        {
            public int payment;
            public BankAccount(int p)
            {
                payment = p;
            }
            public event MyDelegate MyEvent;

            public void avtoplatej()
            {
                for (int i = 0; i < payment; i = 0)
                {
                    payment--;
                    if (payment < 10)
                    {
                        if (MyEvent != null)
                        {
                            MyEvent();
                        }
                    }
                    Console.WriteLine(payment);
                }
            }
            public void vnesti(int sum)
            {
                payment += sum;
                if (payment > 10)
                {
                    if (MyEvent != null)
                    {
                        MyEvent();
                    }
                }
                Console.WriteLine(payment);
            }
        }
        internal class Client
        {

            public void Error()
            {
                Console.WriteLine($"Снятие средств невозможно произвести");
            }
            public void NotError()
            {
                Console.WriteLine($"Возможно совершить платёж");
            }
        }
        static void Main(string[] args)
        {
            BankAccount chet = new BankAccount(25);
            Client client = new Client();
            chet.MyEvent += client.Error;
            Console.WriteLine("Создать автоплатёж");
            chet.avtoplatej();
            chet.MyEvent -= client.Error;
            chet.MyEvent += client.NotError;
            Console.WriteLine("Пополение счёта на сумму 100");
            chet.vnesti(100);
            chet.MyEvent -= client.NotError;
            chet.MyEvent += client.Error;
            chet.avtoplatej();

        }
    } 
}
