using Lab_10;

class Program
{
    static void Main(string[] args)
    {
        var form = new HtmlForm();

        // Adding simple input fields
        form.AddElement(new SimpleHtmlElement("text"));
        form.AddElement(new SimpleHtmlElement("password"));

        // Creating a group of input fields
        var fieldset = new HtmlFieldset("Personal Information");
        fieldset.AddElement(new SimpleHtmlElement("text"));
        fieldset.AddElement(new SimpleHtmlElement("email"));

        form.AddElement(fieldset);

        var selectElement = new SelectHtmlElement("country");
        selectElement.AddOption("USA");
        selectElement.AddOption("Canada");
        selectElement.AddOption("Mexico");
        form.AddElement(selectElement);

        form.Display();

        /*

        <input type="text" />
        <input type="password" />
        <fieldset>
        <legend>
        Personal Information
        </legend>
        <input type="text" />
        <input type="email" />
        </fieldset>
        */
    }
}
