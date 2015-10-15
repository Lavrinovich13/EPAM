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

            Sweetness Alenka = new Sweetness
             ("Alenka",
              "Kommunarka",
              "Russia",
              new WeightGramms(50),
              new PriceBelRubles(500),
              new SugarOn100Gramms(10),
              SweetnessTypes.ChocolateCandy
             );

            Fruit mandarin = new Fruit
            (
              "Always",
              "Sun",
              "Turkey",
              new WeightGramms(100),
              new PriceBelRubles(10000),
              new SugarOn100Gramms(20),
              FruitTypes.Mandarin
            );

            ordinaryGift.Add(Alenka, 5);
            ordinaryGift.Add(mandarin, 2);

            //BinaryFormatter formatter = new BinaryFormatter();

            //using (FileStream fileStream = new FileStream("dsaf.xml", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fileStream, Alenka);
            //}

            //using (FileStream fileStream = new FileStream("dsaf.xml", FileMode.OpenOrCreate))
            //{
            //    var v = (ElementOfGift)formatter.Deserialize(fileStream);
            //}

        }
    }
}
