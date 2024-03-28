public class UpperCaseDecorator : Decorator<string>
{
    public UpperCaseDecorator(component_deco<string> component) : base(component) { }

    public override string GetText()
    {
        return base.GetText().ToUpper();
    }
}