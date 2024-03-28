public class PlainDecorator : Decorator<string>
{
    public PlainDecorator(component_deco<string> component) : base(component) 
    {

    }

    public override string GetText()
    {
        return base.GetText();
    }
}