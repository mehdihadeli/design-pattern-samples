using System;
using System.Collections.Generic;

namespace Example1
{
    class Program
    {
        /* Interface for Strategy */
        interface IOfferStrategy
        {
            string Name { get; }
            double GetDiscountPercentage();
        }

        /* Concrete implementation of base Strategy */
        class NoDiscountStrategy : IOfferStrategy
        {
            public string Name => nameof(NoDiscountStrategy);

            public double GetDiscountPercentage()
            {
                return 0;
            }
        }

        /* Concrete implementation of base Strategy */
        class QuarterDiscountStrategy : IOfferStrategy
        {
            public string Name => nameof(QuarterDiscountStrategy);
            
            public double GetDiscountPercentage()
            {
                return 0.25;
            }
        }



        class StrategyContext
        {
            double price; // price for some item or air ticket etc.
            Dictionary<string, IOfferStrategy> strategyContext = new Dictionary<string, IOfferStrategy>();
            public StrategyContext(double price)
            {
                this.price = price;
                strategyContext.Add(nameof(NoDiscountStrategy), new NoDiscountStrategy());
                strategyContext.Add(nameof(QuarterDiscountStrategy), new QuarterDiscountStrategy());
            }

            public void ApplyStrategy(IOfferStrategy strategy)
            {
                /*
                Currently applyStrategy has simple implementation. You can Context for populating some
                more information,
                which is required to call a particular operation
                */
                Console.WriteLine("Price before offer :" + price);
                double finalPrice = price - (price * strategy.GetDiscountPercentage());
                Console.WriteLine("Price after offer:" + finalPrice);
            }

            public IOfferStrategy GetStrategy(int monthNo)
            {
                /*
                In absence of this Context method, client has to import relevant concrete
                Strategies everywhere.
                Context acts as single point of contact for the Client to get relevant Strategy
                */
                if (monthNo < 6)
                {
                    return strategyContext[nameof(NoDiscountStrategy)];
                }
                else
                {
                    return strategyContext[nameof(QuarterDiscountStrategy)];
                }
            }
        }

        static void Main(string[] args)
        {
            StrategyContext context = new StrategyContext(100);
            Console.WriteLine("Enter month number between 1 and 12");
            var input = Console.ReadLine();
            int month = Convert.ToInt32(input);
            Console.WriteLine("Month =" + month);
            IOfferStrategy strategy = context.GetStrategy(month);
            context.ApplyStrategy(strategy);
            Console.ReadLine();
        }
    }
}
