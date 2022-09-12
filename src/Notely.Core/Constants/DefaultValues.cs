using System.Text.Json;
using System.Text.Json.Serialization;

namespace Notely.Core.Constants;

public static class DefaultValues {
    public static string FallbackCulture => "en-US";

    public static readonly JsonSerializerOptions DefaultJsonOptions = new() {
        AllowTrailingCommas = true,
        NumberHandling = JsonNumberHandling.AllowReadingFromString,
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        ReadCommentHandling = JsonCommentHandling.Skip
    };
}
