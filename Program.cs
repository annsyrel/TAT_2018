using System;

namespace DEV4
{
    class Program 
    {
        static void Main(string[] args)
        {
            // todo: check length of args
            if (args.Length == 0)
            {
                Console.WriteLine("required input param: xml file path!");
                return;
            }

            string file_path = args[0];
            string xml_content = System.IO.File.ReadAllText(file_path);
            var doc = new XmlDocument();

            try
            {
                doc.SetContent(xml_content);
            }
            catch(Exception e)
            {
                Console.WriteLine(String.Format("Error parsing XML!\n\t Message: {0}", e.Message));
                return;
            }

            var tags = doc.CollectAllTags();

            Console.WriteLine("Unsorted xml tags:");
            foreach(var tag in tags)
            {
                Console.WriteLine(tag);
            }
            
            tags.Sort();
            
            Console.WriteLine();
            Console.WriteLine("sorted tags:");

            foreach (var tag in tags)
            {
                Console.WriteLine(tag.ToTaskFormatString());
            }
        }
    }    
}
