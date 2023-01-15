using System.Globalization;

namespace Notely.Core.Services;

public class TemplateModelFactory : ITemplateModelFactory {
    private readonly INotelyConfiguration _configuration;
    private readonly IDateTimeProvider _dateTimeProvider;

    public TemplateModelFactory(INotelyConfiguration configuration, IDateTimeProvider dateTimeProvider) {
        _configuration = configuration;
        _dateTimeProvider = dateTimeProvider;
    }

    public DefaultTemplateModel CreateDefaultModel() {
        var model = new DefaultTemplateModel();

        var culture = CultureInfo.GetCultureInfo(_configuration.Culture ?? DefaultValues.FallbackCulture);

        model.Culture = culture;

        var now = _dateTimeProvider.Now;

        model.Now = now;
        model.Today = now.Date;

        var firstDayOfWeek = GetFirstDayOfWeek(now, culture);
        model.WorkWeekDays = Enumerable.Range(0, 5).Select(i => firstDayOfWeek.AddDays(i));
        model.FullWeekDays = Enumerable.Range(0, 7).Select(i => firstDayOfWeek.AddDays(i));

        return model;
    }

    internal static DateTime GetFirstDayOfWeek(DateTime date, CultureInfo cultureInfo) {
        var firstDayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek;
        var todaysDay = date.DayOfWeek;
        return DateTime.Now.AddDays(-(todaysDay - firstDayOfWeek)).Date;
    }

    internal static DateTime GetStartOfWorkWeek(DateTime date, CultureInfo cultureInfo) {
        var firstDayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek;

        // TODO Implement this to find the monday of the week

        return date;
    }
}
