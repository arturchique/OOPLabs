using System;

namespace delegate_chain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            DelegateChain.ChainWorks += Handlers.RusCharHandler;
            DelegateChain.ChainWorks += Handlers.EngCharHandler;
            DelegateChain.ChainWorks += Handlers.IntCharHandler;
            DelegateChain.ReadText(text);

            Console.ReadKey();
            
        }
    }
}
