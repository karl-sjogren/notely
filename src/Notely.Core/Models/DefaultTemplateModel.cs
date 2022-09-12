using System.Globalization;

namespace Notely.Core.Models;

public class DefaultTemplateModel {
    public DateTime Now { get; set; }
    public DateTime Today { get; set; }

    public IEnumerable<DateTime> WorkWeekDays { get; set; } = Enumerable.Empty<DateTime>();
    public IEnumerable<DateTime> FullWeekDays { get; set; } = Enumerable.Empty<DateTime>();

    public CultureInfo Culture { get; set; } = CultureInfo.CurrentCulture;
    public string CultureTwoLetter { get; set; } = DefaultValues.FallbackCulture;
}
