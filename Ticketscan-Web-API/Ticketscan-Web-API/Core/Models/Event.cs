using NodaTime;
using NodaTime.TimeZones;

namespace Ticketscan_Web_API.Core.Models;

public class Event
{
    public LocalDate StartDate { get; set; }
    public LocalDate EndDate { get; set; }
    public DateTimeZone Zone { get; set; }
}