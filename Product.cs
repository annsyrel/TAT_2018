
namespace DEV_6
{
   /// <summary>
   /// Class contains information about product
   /// </summary>
   class Product
    {
        
        string TypeOfProduct, ProductName;
        int CountOfProduct;
        double ProductCost;

       public Product(string Type,string Name, int Count, double Cost)
        {
            TypeOfProduct = Type;
            ProductName = Name;
            CountOfProduct = Count;
            ProductCost = Cost;
        }

        /// <summary>
        /// type getter
        /// </summary>
        public string Ptype
        {
            get
            {
                return TypeOfProduct;
            }
        }

        /// <summary>
        /// name getter
        /// </summary>
        public string Pname
        {
            get
            {
                return ProductName;
            }
        }

       /// <summary>
       /// count getter
       /// </summary>
       public int Pcount
        {
            get
            {
                return CountOfProduct;
            }
        }

        /// <summary>
        /// cost getter
        /// </summary>
        public double Pcost
        {
            get
            {
                return ProductCost;
            }
        }
    }
}
