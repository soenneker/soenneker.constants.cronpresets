[![](https://img.shields.io/nuget/v/soenneker.constants.cronpresets.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.constants.cronpresets/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.constants.cronpresets/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.constants.cronpresets/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.constants.cronpresets.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.constants.cronpresets/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.constants.cronpresets/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.constants.cronpresets/actions/workflows/codeql.yml)

# Soenneker.Constants.CronPresets

Provides reusable five-field cron expressions for common schedules.

## Install

```bash
dotnet add package Soenneker.Constants.CronPresets
```

## Usage

```csharp
using Soenneker.Constants.CronPresets;

string schedule = CronPresets.WeekdaysAt8AM;
// 0 8 * * MON-FRI
```

These values use the conventional `minute hour day-of-month month day-of-week` layout. They do not include a seconds field.

## Presets

| Constant | Expression | Schedule |
| --- | --- | --- |
| `EveryMinute` | `* * * * *` | Every minute |
| `Every5Minutes` | `*/5 * * * *` | Every 5 minutes |
| `Every10Minutes` | `*/10 * * * *` | Every 10 minutes |
| `Every15Minutes` | `*/15 * * * *` | Every 15 minutes |
| `Every30Minutes` | `*/30 * * * *` | Every 30 minutes |
| `EveryHour`, `StartOfHour` | `0 * * * *` | At minute 0 of every hour |
| `Every2Hours` | `0 */2 * * *` | Every 2 hours, aligned to midnight |
| `Every6Hours` | `0 */6 * * *` | Every 6 hours, aligned to midnight |
| `Every12Hours` | `0 */12 * * *` | Every 12 hours, aligned to midnight |
| `StartOfDay`, `DailyMidnight` | `0 0 * * *` | Daily at midnight |
| `DailyNoon` | `0 12 * * *` | Daily at noon |
| `Daily2AM`, `Daily4AM`, `Daily6AM`, `Daily8AM`, `Daily9AM` | `0 H * * *` | Daily at the hour named by the constant |
| `Daily5PM`, `Daily8PM`, `Daily10PM` | `0 H * * *` | Daily at 17:00, 20:00, or 22:00 |
| `StartOfWeek`, `EverySundayAtMidnight` | `0 0 * * SUN` | Sunday at midnight |
| `WeekdaysAt8AM` | `0 8 * * MON-FRI` | Monday through Friday at 08:00 |
| `WeekendsAt10AM` | `0 10 * * SAT,SUN` | Saturday and Sunday at 10:00 |
| `EveryMondayAt6AM` | `0 6 * * MON` | Monday at 06:00 |
| `EveryFridayAt1PM` | `0 13 * * FRI` | Friday at 13:00 |
| `StartOfMonth`, `FirstOfMonthAtMidnight` | `0 0 1 * *` | First day of each month at midnight |
| `FirstOfMonthAt6AM` | `0 6 1 * *` | First day of each month at 06:00 |
| `StartOfYear` | `0 0 1 1 *` | January 1 at midnight |

## Compatibility notes

- The scheduler determines the time zone and daylight-saving behavior; the expressions contain no zone information.
- Confirm that your cron parser accepts five fields and symbolic day names such as `MON` and `SUN`. Quartz configurations commonly expect a seconds field and cannot use these values unchanged.
- Interval presets are calendar-aligned. For example, `Every2Hours` runs at 00:00, 02:00, 04:00, and so on; it is not two hours after the previous job finishes.
