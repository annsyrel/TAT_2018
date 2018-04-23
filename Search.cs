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
    /// Class to find car with needed parametrs
    /// </summary>
    class Search
    {

        DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Car[]));
        Car search = new Car();
        Input put = new Input();

        /// <summary>
        /// Method for searching needed car in catalog
        /// </summary>
        public void search_catalog()
        {
            using (FileStream fs = new FileStream("catalog.json", FileMode.OpenOrCreate))
            {
                search.Entercar();
                Car[] newcar = (Car[])jsonFormatter.ReadObject(fs);
                var selectedcar = from c in newcar
                                  where c.brand.StartsWith(search.brand)
                                  && c.model.StartsWith(search.model)
                                  && c.engine_capacity.StartsWith(search.engine_capacity)
                                  && c.body_type.StartsWith(search.body_type)
                                  && c.climat_managment.StartsWith(search.climat_managment)
                                  && c.engine.StartsWith(search.engine)
                                  && c.transmission.StartsWith(search.transmission)
                                  && c.interior_type.StartsWith(search.interior_type)
                                  && c.power.StartsWith(search.power)
                                  select c;

                if (selectedcar == null)
                {
                    Console.WriteLine("Not found car with these paramerts");
                }
                else
                {
                    int j = 0;
                    foreach (Car i in selectedcar)
                    {
                        i.output();
                        j++;
                    }
                    if (j != 0)
                    {
                        Console.WriteLine("Do U want to find this car on stock? ");
                        if (Console.ReadLine() == "yes")
                        {
                            Car[] car = new Car[j];
                            j = 0;
                            foreach (Car i in selectedcar)
                            {
                                car[j] = i;
                                j++;
                            }
                            if (!search_stock(car))
                            {
                                Console.WriteLine("Do U want to order this car? ");
                                if (Console.ReadLine() == "yes")
                                {
                                    foreach (Car i in selectedcar)
                                    {
                                        i.output();
                                    }

                                    Console.WriteLine("Enter a number of a car: ");
                                    int k = Convert.ToInt32(Console.ReadLine());
                                    put.input(car[k - 1]);
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("We have not this car at our catalog. ");
                    }
                }
            }
        }

        /// <summary>
        /// Method for searching needed car in stock
        /// </summary>
        /// <param name="newcar"></param>
        /// <returns></returns>
        public bool search_stock(Car[] newcar)
        {

            using (FileStream fs = new FileStream("stock.json", FileMode.OpenOrCreate))
            {
                int k = 0;
                Car[] car = (Car[])jsonFormatter.ReadObject(fs);
                foreach (Car i in newcar)
                {
                    foreach (Car j in car)
                    {
                        if (i.brand == j.brand
                                  && i.model == j.model
                                  && i.engine_capacity == j.engine_capacity
                                  && i.body_type == j.body_type
                                  && i.climat_managment == j.climat_managment
                                  && i.engine == j.engine
                                  && i.transmission == j.transmission
                                  && i.interior_type == j.interior_type
                                  && i.power == j.power)
                        {
                            i.output();
                            k++;
                        }
                    }
                }
                if (k == 0)
                {
                    Console.WriteLine("Not found car with these paramerts");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
