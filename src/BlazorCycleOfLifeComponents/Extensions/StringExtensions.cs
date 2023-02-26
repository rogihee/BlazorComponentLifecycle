using System.Reflection;

// ReSharper disable once CheckNamespace
namespace System;

public static class StringExtensions
{
    private static string _version;

    public static string AppendVersion(this string url)
    {
        if (string.IsNullOrEmpty(_version))
        {
            _version = $"?v={Assembly.GetAssembly(typeof(BaseAsset))?.GetName().Version?.ToString() ?? ""}";
        }
        return $"{url}{_version}";
    }
}