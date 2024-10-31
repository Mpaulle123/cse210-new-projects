public class Running : Activity
{
    protected double _distanceKm;
    protected double _speedKmH => 60/_paceMinKm;
    protected double _paceMinKm => _duration / _distanceKm;

    public Running (DateTime date, string activityName, double duration, double distanceKm)
        : base(date, activityName, duration)
    {
        _distanceKm = distanceKm;
    }


    public override void GetSummary()
    {
        Console.WriteLine($"{_date.ToShortDateString()} - {_activityName}: \nlength: {_duration} minutes \ndistance {_distanceKm} km \nspeed: {_speedKmH:F2} km/h \npace: {_paceMinKm:F2} min/km");
    }
}