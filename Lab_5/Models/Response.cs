namespace Lab_5.Models;

public class Response
{
    public int Code { get; set; }
    public string Status { get; set; }

    public override string ToString()
    {
        return $"Code: {Code}, Status: {Status}";
    }
}

