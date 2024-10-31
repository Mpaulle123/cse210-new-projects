public class Bicycle : Activity
{
    protected double _speedBikeKmH;
    protected double _paceBikeKm => 60 / _speedBikeKmH;

    public Bicycle (DateTime date, string activityName, double duration, double speedBikeKmH)
        : base(date, activityName, duration)
    {
        _speedBikeKmH = speedBikeKmH;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date.ToShortDateString()} {_activityName}: \nlength: {_duration} minutes \nspeed: {_speedBikeKmH} km/h \npace: {_paceBikeKm:F2} min/km");
    }
}