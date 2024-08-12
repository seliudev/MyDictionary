//
//C# Dictionary practice using .Add();

Dictionary<int,string> stock = new Dictionary<int,string>();
stock.Add(101 ,"Pencil");
stock.Add(102,"Eraser");
stock.Add(103,"Notebook");
stock.Add(104,"Scissor");
stock.Add(105,"Crayon");
stock.Add(106, "Marker");
stock.Add(107, "Highlighter");

foreach (var product in stock)
{
    Console.WriteLine("Product name: " + product.Value + " |" + " Product code: " + product.Key);
}




