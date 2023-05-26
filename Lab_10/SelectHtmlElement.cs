using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10;

public class SelectHtmlElement : HtmlElement
{
    private List<string> options;

    public SelectHtmlElement(string name) : base(name)
    {
        options = new List<string>();
    }

    public void AddOption(string option)
    {
        options.Add(option);
    }

    public override void Display()
    {
        Console.WriteLine($"<select name=\"{name}\">");

        foreach (var option in options)
        {
            Console.WriteLine($"<option value=\"{option}\">{option}</option>");
        }

        Console.WriteLine("</select>");
    }
}
