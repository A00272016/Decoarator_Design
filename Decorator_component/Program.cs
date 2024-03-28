namespace MyDecorator;
class Program
{
   
    static void Main()
    {
        component_deco<string> component = new ConcreteComponent();

        var plainDeco = new PlainDecorator(component);
        var upperCaseDeco = new UpperCaseDecorator(component);
        var colorDeco = new ColorDecorator(component);

        Console.WriteLine(plainDeco.GetText());
        Console.WriteLine(upperCaseDeco.GetText());
        Console.WriteLine(colorDeco.GetText());
    }
}