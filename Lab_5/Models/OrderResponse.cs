namespace Lab_5.Models
{
    public class OrderResponse : Response
    {
        public string Json { get; set; }

        public override string ToString()
        {
            return $"Code: {Code}, Status: {Status}, Json: {Json}";
        }
    }
}
