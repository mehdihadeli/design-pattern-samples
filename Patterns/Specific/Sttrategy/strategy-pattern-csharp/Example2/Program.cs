using System;

namespace Example2
{
    class Program
    {
        // The strategy interface
        public interface ITranslationStrategy
        {
            string Translate(string phrase);
        }
        // American strategy implementation
        public class AmericanTranslationStrategy : ITranslationStrategy
        {
            
            public string Translate(string phrase)
            {
                return phrase + ", bro";
            }
        }

        // Australian strategy implementation
        public class AustralianTranslationStrategy : ITranslationStrategy
        {
            
            public string Translate(string phrase)
            {
                return phrase + ", mate";
            }
        }

        // The main class which exposes a translate method
        public class EnglishTranslation
        {
            // translate a phrase using a given strategy
            public static string Translate(string phrase, ITranslationStrategy strategy)
            {
                return strategy.Translate(phrase);
            }

            // example usage
            static void Main(string[] args)
            {
                // translate a phrase using the AustralianTranslationStrategy class
                string aussieHello = Translate("Hello", new AustralianTranslationStrategy());
                Console.WriteLine(aussieHello);
                // Hello, mate
                // translate a phrase using the AmericanTranslationStrategy class
                string usaHello = Translate("Hello", new AmericanTranslationStrategy());
                Console.WriteLine(usaHello);
                // Hello, bro

                Console.ReadLine();
            }
        }

    }
}
