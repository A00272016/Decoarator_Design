public abstract class Decorator<T> : component_deco<T>
{
    protected component_deco<T> component;

    public Decorator(component_deco<T> component) 
    {
        this.component = component;
    }

    public virtual T GetText()
    {
        return component.GetText();
    }
}