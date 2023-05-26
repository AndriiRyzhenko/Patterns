using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10;

public class SimpleHtmlElement : HtmlElement
{
    public SimpleHtmlElement(string name) : base(name)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"<input type=\"{name}\" />");
    }
}
