using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10;

public class HtmlFieldset : HtmlElement
{
    private List<HtmlElement> elements;

    public HtmlFieldset(string name) : base(name)
    {
        elements = new List<HtmlElement>();
    }

    public void AddElement(HtmlElement element)
    {
        elements.Add(element);
    }

    public override void Display()
    {
        Console.WriteLine($"<fieldset>\n<legend>\n{name}\n</legend>");

        foreach (var element in elements)
        {
            element.Display();
        }

        Console.WriteLine("</fieldset>");
    }
}