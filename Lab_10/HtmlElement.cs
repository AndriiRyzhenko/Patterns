using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10;

public abstract class HtmlElement
{
    protected string name;

    public HtmlElement(string name)
    {
        this.name = name;
    }

    public abstract void Display();
}
