namespace BlazorCycleOfLifeComponents.Models;

public abstract class BaseAsset
{
    public string Url { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return Url;
    }
}

internal class ImageAsset : BaseAsset
{
    public ImageAsset(string name, string url)
    {
        Name = name;
        Url = url.AppendVersion();
    }
}
