using NodaTime;

namespace Ticketscan_Web_API.Core.Models;
/// <summary>
/// A model for a scannable ticket.
/// </summary>
public class Ticket
{
    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    public Guid Id { get; private set; }
    
    /// <summary>
    /// Gets or sets the id of the event where the ticket is allowed.
    /// </summary>
    public Guid EventId { get; private set; }
    
    /// <summary>
    /// Gets or sets if this ticket is already scanned.
    /// </summary>
    public Boolean Scanned { get; set; }
    
    /// <summary>
    /// Gets or sets the start date when the ticket is allowed.
    /// </summary>
    public LocalDate StartDate { get; private set; }
    
    /// <summary>
    /// Gets or sets the end date when the ticket is allowed.
    /// </summary>
    public LocalDate EndDate { get; private set; }
    
    /// <summary>
    /// Gets or sets the start time when the ticket is allowed.
    /// </summary>
    public LocalTime? StartTime { get; private set; }
    
    /// <summary>
    /// Gets or sets the end time when the ticket is allowed.
    /// </summary>
    public LocalTime? EndTime { get; private set; }
    
    /// <summary>
    /// Gets the interval when the ticket is allowed.
    /// </summary>
    public List<Interval> AllowedIntervals { get; private set; } = new();

    public Ticket(Guid id, Guid eventId, bool scanned, LocalDate startDate, LocalDate endDate, LocalTime? startTime, LocalTime? endTime, DateTimeZone zone)
    {
        if (zone == null)
            throw new ArgumentNullException(nameof(zone), "The time zone cannot be null.");

        StartDate = startDate;
        EndDate = endDate;

        if (StartDate > EndDate)
            throw new ArgumentException("The start date must be before the end date.");

        Id = id;
        EventId = eventId;
        Scanned = scanned;

        StartTime = startTime ?? new LocalTime(0, 0);
        EndTime = endTime ?? new LocalTime(23, 59, 59);

        if (StartTime > EndTime)
            throw new ArgumentException("The start time must be before or equal to the end time.");

        var currentDate = StartDate;
        while (currentDate <= EndDate)
        {
            var startDateTime = currentDate.At(StartTime.Value);
            var endDateTime = currentDate.At(EndTime.Value);

            var startInstant = zone.AtStrictly(startDateTime).ToInstant();
            var endInstant = zone.AtStrictly(endDateTime).ToInstant();

            AllowedIntervals.Add(new Interval(startInstant, endInstant));
            currentDate = currentDate.PlusDays(1);
        }
    }
}