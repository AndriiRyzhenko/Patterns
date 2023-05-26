using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10;

public class HtmlForm
{
    private List<HtmlElement> elements;

    public HtmlForm()
    {
        elements = new List<HtmlElement>();
    }

    public void AddElement(HtmlElement element)
    {
        elements.Add(element);
    }

    public void Display()
    {
        foreach (var element in elements)
        {
            element.Display();
        }
    }
}
