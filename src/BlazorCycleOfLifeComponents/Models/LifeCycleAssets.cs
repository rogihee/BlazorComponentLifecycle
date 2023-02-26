namespace BlazorCycleOfLifeComponents.Models;

internal class LifeCycleAssets
{
    public const string BaseUrl = "/_content/BlazorCycleOfLifeComponents";
    public const string ImagePath = $"{BaseUrl}/images";

    public static ImageAsset Background { get; set; } = new(nameof(Background), $"{ImagePath}/background.jpg");
}
