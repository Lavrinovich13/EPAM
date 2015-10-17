using ChristmasGift.Comparators;
using ChristmasGift.GiftElements;
using ChristmasGift.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChristmasGift
{
    class Program
    {
        static void Main(string[] args)
        {
            ChristmasGift ordinaryGift = new ChristmasGift();
            ordinaryGift.Add(new Sweetness
              ("Alenka",
              "Kommunarka",
              "Russia",
              new WeightGramms(15),
              new PriceBelRubles(500),
              new SugarOn100Gramms(11),
              SweetnessTypes.ChocolateCandy),
              5);

            ordinaryGift.Add(new Sweetness
              ("Krokant",
              "Jashkino",
              "Russia",
              new WeightGramms(19),
              new PriceBelRubles(600),
              new SugarOn100Gramms(10),
              SweetnessTypes.ChocolateCandy),
              10);

            ordinaryGift.Add(new Sweetness
              ("Alpen Gold",
              "Nestle",
              "Russia",
              new WeightGramms(90),
              new PriceBelRubles(20000),
              new SugarOn100Gramms(30),
              SweetnessTypes.Chocolate));

            ordinaryGift.Add(new Fruit
                ("Sun",
                "Fruit",
                "Turkey",
                new WeightGramms(200),
                new PriceBelRubles(5000),
                new SugarOn100Gramms(27),
                FruitTypes.Orange),
                2);

            ordinaryGift.Add(new Toy
            (
            "Funny Puzzle",
            "Buslik",
            "Belarus",
            new WeightGramms(300),
            new PriceBelRubles(24000),
            ToyTypes.Mosaic));

            ordinaryGift.Sort(new ElementOfGiftByTitleComparer());
            ordinaryGift.Print();
            Console.WriteLine();

            Console.WriteLine("Weight: " + ordinaryGift.Weight.Value + ordinaryGift.Weight.Dimension);
            Console.WriteLine("Price: " + ordinaryGift.Price.Value + ordinaryGift.Price.Dimension);

            SugarOn100Gramms minSugar = new SugarOn100Gramms(20);
            SugarOn100Gramms maxSugar = new SugarOn100Gramms(40);

            Console.WriteLine
                ("Element with sugar from " + minSugar.Value + minSugar.Dimension + 
                " to " + maxSugar.Value + maxSugar.Dimension + " - " + 
                (ordinaryGift.FindForSugar(minSugar, maxSugar) as IElementOfGift).Title);
            Console.Read();
        }
    }
}
