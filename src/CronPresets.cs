﻿namespace Soenneker.Constants.CronPresets;

/// <summary>
/// Commonly used Cron expressions.
/// </summary>
public static class CronPresets
{
    // ----- Intervals -----

    /// <summary> Every minute </summary>
    public const string EveryMinute = "* * * * *";

    /// <summary> Every 5 minutes </summary>
    public const string Every5Minutes = "*/5 * * * *";

    /// <summary> Every 10 minutes </summary>
    public const string Every10Minutes = "*/10 * * * *";

    /// <summary> Every 15 minutes </summary>
    public const string Every15Minutes = "*/15 * * * *";

    /// <summary> Every 30 minutes </summary>
    public const string Every30Minutes = "*/30 * * * *";

    /// <summary> Every hour, at 0 minutes </summary>
    public const string EveryHour = "0 * * * *";

    /// <summary> Every 2 hours </summary>
    public const string Every2Hours = "0 */2 * * *";

    /// <summary> Every 6 hours </summary>
    public const string Every6Hours = "0 */6 * * *";

    /// <summary> Every 12 hours </summary>
    public const string Every12Hours = "0 */12 * * *";

    // ----- Anchors -----

    /// <summary> Start of every hour </summary>
    public const string StartOfHour = "0 * * * *";

    /// <summary> Start of every day (midnight) </summary>
    public const string StartOfDay = "0 0 * * *";

    /// <summary> Start of every week (Sunday at midnight) </summary>
    public const string StartOfWeek = "0 0 * * SUN";

    /// <summary> Start of every month (1st at midnight) </summary>
    public const string StartOfMonth = "0 0 1 * *";

    /// <summary> Start of every year (January 1st at midnight) </summary>
    public const string StartOfYear = "0 0 1 1 *";

    // ----- Daily -----

    public const string DailyMidnight = "0 0 * * *";
    public const string DailyNoon = "0 12 * * *";
    public const string Daily2AM = "0 2 * * *";
    public const string Daily4AM = "0 4 * * *";
    public const string Daily6AM = "0 6 * * *";
    public const string Daily8AM = "0 8 * * *";
    public const string Daily9AM = "0 9 * * *";
    public const string Daily5PM = "0 17 * * *";
    public const string Daily8PM = "0 20 * * *";
    public const string Daily10PM = "0 22 * * *";

    // ----- Weekday/Weekend -----

    public const string WeekdaysAt8AM = "0 8 * * MON-FRI";
    public const string WeekendsAt10AM = "0 10 * * SAT,SUN";

    // ----- Weekly -----

    public const string EveryMondayAt6AM = "0 6 * * MON";
    public const string EveryFridayAt1PM = "0 13 * * FRI";
    public const string EverySundayAtMidnight = "0 0 * * SUN";

    // ----- Monthly -----

    public const string FirstOfMonthAtMidnight = "0 0 1 * *";
    public const string FirstOfMonthAt6AM = "0 6 1 * *";
}