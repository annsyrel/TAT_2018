using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;

namespace DEV_7
{
    /// <summary>
    /// class for input info about car for order
    /// </summary>
    public class Input
    {
        DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Car[]));

        /// <summary>
        /// Method for input to stock order info about car   
        /// </summary>
        /// <param name="newcar"></param>
        public void input(Car newcar)
        {
            List<Car> acr = new List<Car>();
            using (FileStream fs = new FileStream("stock.json", FileMode.OpenOrCreate))
            {
                Car[] car = (Car[])jsonFormatter.ReadObject(fs);
                acr.Add(newcar);
                for (int i = 0; i < car.Length; i++)
                {
                    acr.Add(car[i]);
                }
            }
            File.Delete("stock.json");
            using (FileStream fs = new FileStream("stock.json", FileMode.OpenOrCreate))
            {
                Car[] cars = new Car[acr.Count];
                for (int i = 0; i < acr.Count; i++)
                {
                    cars[i] = acr[i];
                }
                jsonFormatter.WriteObject(fs, cars);
            }
            Console.WriteLine("Ur car add to stock");
        }
    }
}
