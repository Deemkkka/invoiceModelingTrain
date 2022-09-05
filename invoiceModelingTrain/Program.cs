namespace invoiceModelingTrain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new()
            {
                Date = DateTime.Parse("21/4/2120"),
                Number = "21-TT-30312",
                To = "House",
                From = "Microsot",
                StorekeeperSurname = "ИВанов",
                ForwarderSurname = "Петров"
            };

            Row row = new()
            {
                Description = "Code is complete. Steve McConnell.",
                Quantity = 3,
                Price = 400
            };

            invoice.Table.AddRow(row);

            row = new()
            {
                Description = "Code is complete. 2l.",
                Quantity = 4,
                Price = 100
            };

            invoice.Table.AddRow(row);

            // ---------------ВЫВОД------------

            string stringTitle = $"Дата: {invoice.Date} \nНакладная № {invoice.Number} " + 
                $"\nКому: {invoice.To} \nОт кого: {invoice.From}";
            Console.WriteLine(stringTitle);

            for (int i = 0; i < invoice.Table.Size; i++)
            {
                row = invoice.Table.GetRow(i);
                string stringRow = $"{row.SequentialNumber} | {row.Description} | " +
                    $"{row.Quantity} шт. | {row.Price} руб. | {row.Amount} руб.";
                Console.WriteLine(stringRow);
            }

            Console.WriteLine($"Итоги: {invoice.Table.Total} руб.");

            string stringFooter = $"Кладовщик: {invoice.StorekeeperSurname}, " +
                $"Экспедитор: {invoice.ForwarderSurname}";
            Console.WriteLine(stringFooter);


            Console.ReadKey();
        }
    }
}