using System.Globalization;

namespace Notely.Core.Models;

public class DefaultTemplateModel {
    public DateTime Now { get; set; }
    public DateTime Today { get; set; }

    public IEnumerable<DateTime> WorkWeekDays { get; set; } = Enumerable.Empty<DateTime>();
    public IEnumerable<DateTime> FullWeekDays { get; set; } = Enumerable.Empty<DateTime>();

    public CultureInfo Culture { get; set; } = new(DefaultValues.FallbackCulture);
    public string CultureTwoLetter => Culture.TwoLetterISOLanguageName;

    public string AuthorName { get; set; } = string.Empty;
    public string AuthorEmail { get; set; } = string.Empty;
}
