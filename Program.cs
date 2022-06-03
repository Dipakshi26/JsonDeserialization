using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;

namespace JsonHandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var Ebills = new List<Ebill>
            {
            new Ebill
                {
                    CustomerId = 11396,
                    CustomerName = "Dipakshi",
                    UnitPerCost = 40,
                    Total = 1000
                },

                new Ebill
                {
                    CustomerId = 12396,
                    CustomerName = "Aditya",
                    UnitPerCost = 50,
                    Total = 1500
                },
                new Ebill
                {
                    CustomerId = 13396,
                    CustomerName = "Shatakshi",
                    UnitPerCost = 20,
                    Total = 500
                },
            };
            var Ebill1 = new Ebill
            {
                CustomerId = 14396,
                CustomerName = "Akshat",
                UnitPerCost = 50,
                Total = 2000

            };



   
            {
                var EbillJson = JsonConvert.SerializeObject(Ebill1);
                Console.WriteLine(EbillJson);

                Console.ReadKey();
            }
        }
        [Serializable]
        public class Ebill
        {

            public int CustomerId { get; set; }
            public string CustomerName { get; set; }
            public int NoOfUnits { get; set; }
            public int UnitPerCost { get; set; } = 7;
            public int Total { get; set; }
        }
    }
}
