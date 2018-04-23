using System.IO;
using System.Runtime.Serialization.Json;


namespace DEV_7
{
    /// <summary>
    /// Class for output information about cars
    /// </summary>
    public class Output
    {
        DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Car[]));

        /// <summary>
        /// Method for output info about cars in stock
        /// </summary>
        public void output_stock()
        {
            using (FileStream fs = new FileStream("stock.json", FileMode.OpenOrCreate))
            {

                Car[] newcar = (Car[])jsonFormatter.ReadObject(fs);
                foreach (Car i in newcar)
                {
                    i.output();
                }
            }
        }

        /// <summary>
        /// Method for output info about cars in catalog
        /// </summary>
        public void output_catalog()
        {
            using (FileStream fs = new FileStream("catalog.json", FileMode.OpenOrCreate))
            {
                Car[] newcar = (Car[])jsonFormatter.ReadObject(fs);
                foreach (Car i in newcar)
                {
                    i.output();
                }
            }
        }
    }
}
