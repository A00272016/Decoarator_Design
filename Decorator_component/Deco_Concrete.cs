public class ConcreteComponent : component_deco<string>
{
    public string GetText()
    {
        return "Hi There ; HOw Are You Doing Today;";
    }
}