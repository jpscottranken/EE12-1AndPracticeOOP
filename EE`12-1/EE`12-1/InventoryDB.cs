using System;

namespace EE_12_1
{
    public class InventoryDB
    {
        private const string Path = @"..\..\..\InventoryItems.txt";
        //private const string Path = @"C:\C#\Files\InventoryItems.txt";
        private const string Delimiter = "|";

        public static List<InventoryItem> GetItems()
        {
            //  Create the object for the input
            //  stream for a text file;
            using StreamReader textIn =
                new StreamReader(
                new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));

            // create the list
            List<InventoryItem> items = new();

            // read the data from the file and store it in the list
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? "";
                string[] columns = row.Split(Delimiter);

                if (columns.Length == 3)
                {
                    InventoryItem item = new()
                    {
                        ItemNo = Convert.ToInt32(columns[0]),
                        Description = columns[1],
                        Price = Convert.ToDecimal(columns[2])
                    };

                    items.Add(item);
                }
            }

            return items;
        }

        public static void SaveItems(List<InventoryItem> items)
        {
            //  Create the output stream for
            //  a text file that exists
            using StreamWriter textOut =
                new StreamWriter(
                new FileStream(Path, FileMode.Create, FileAccess.Write));

            //  Write each product
            foreach (InventoryItem item in items)
            {
                textOut.Write(item.ItemNo + Delimiter);
                textOut.Write(item.Description + Delimiter);
                textOut.WriteLine(item.Price);
            }
        }
    }
}
