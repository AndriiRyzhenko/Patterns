using System.Text;

namespace Lab_5.Models;

public class Order : Item
{
    public List<Product> Products { get; set; }
    public int TotalPrice => Products.Sum(x => x.Price);


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("");
        sb.AppendLine("{");
        sb.AppendLine($"\"Id\":\"{Id}\",");

        sb.AppendLine("\"Products\":[");
        foreach (Product product in Products)
        {
            sb.AppendLine("{");
            sb.AppendLine($"\"Id\":\"{product.Id}\",");
            sb.AppendLine($"\"Name\":\"{product.Name}\",");
            sb.AppendLine($"\"Price\":{product.Price}");
            sb.AppendLine("},");
        }
        sb.Remove(sb.Length - 1, 1);
        sb.AppendLine("],");

        sb.AppendLine($"\"TotalPrice\":{TotalPrice}");
        sb.AppendLine("}");

        return sb.ToString();
    }

}
