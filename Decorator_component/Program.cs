
class Program
{
   
    static void Main()
    {
        component_deco<string> component = new ConcreteComponent();

        var plain_deco = new PlainDecorator(component);
        var Upper_deco = new UpperCaseDecorator(component);
        var Color_deco = new ColorDecorator(component);

        Console.WriteLine(plain_deco.GetText());
        Console.WriteLine(Upper_deco.GetText());
        Console.WriteLine(Color_deco.GetText());
    }
}