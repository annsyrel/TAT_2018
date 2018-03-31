using System;
using System.Runtime.Serialization;

namespace DEV_7
{
    /// <summary>
    /// Class with car parametrs
    /// </summary>
    [DataContract]
    public class Car
    {

        [DataMember]
        public string brand { get; set; }
        [DataMember]
        public string model { get; set; }
        [DataMember]
        public string body_type { get; set; }
        [DataMember]
        public string transmission { get; set; }
        [DataMember]
        public string engine { get; set; }
        [DataMember]
        public string engine_capacity { get; set; }
        [DataMember]
        public string power { get; set; }
        [DataMember]
        public string climat_managment { get; set; }
        [DataMember]
        public string interior_type { get; set; }

        /// <summary>
        /// Method for input information about car
        /// </summary>
        public virtual void Entercar() 
        {
            
            Console.WriteLine("Enter Ur parametres ");
            Console.Write("Brand: ");
            this.brand = Console.ReadLine();
            Console.Write("Model: ");
            this.model = Console.ReadLine();
            Console.Write("Body type: ");
            this.body_type = Console.ReadLine();
            Console.Write("Transmission: ");
            this.transmission = Console.ReadLine();
            Console.Write("Enigine: ");
            this.engine = Console.ReadLine();
            Console.Write("Engine capacity: ");
            this.engine_capacity = Console.ReadLine();
            Console.Write("Power: ");
            this.power = Console.ReadLine();
            Console.Write("Climat managment: ");
            this.climat_managment = Console.ReadLine();
            Console.Write("Interior type: ");
            if(this.transmission == "auto")
            {

                this.interior_type = "Leather";
            }
            else
            {
                this.interior_type = Console.ReadLine();
            }
            Console.WriteLine();
        }
    /// <summary>
    /// Output information about car
    /// </summary>
    public void output()
        {
            Console.WriteLine();
            Console.WriteLine("Brand: " + this.brand);
            Console.WriteLine("Model: " + this.model);
            Console.WriteLine("Body type: " + this.body_type);
            Console.WriteLine("Transmission: " + this.transmission);
            Console.WriteLine("Enigine with engine capacity: " + this.engine + " " + this.engine_capacity);
            Console.WriteLine("Power: " + this.power);
            Console.WriteLine("Climat managment: " + this.climat_managment);
            Console.WriteLine("Interior type: " + this.interior_type);
            Console.WriteLine();
        }
    }
}