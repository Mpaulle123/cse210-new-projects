public class Swimming : Activity
{
    protected int _numberLaps;
    protected double _paceMinLap => _duration/ _numberLaps;
    protected double _swimDistanceKm => _numberLaps * 50 / 100;

    public Swimming (DateTime date, string actitityName, double duration, int numberLaps)
        : base(date, actitityName, duration)
    {
        _numberLaps = numberLaps;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date.ToShortDateString()} - {_activityName}: \nlength: {_duration} minutes \ndistance: {_swimDistanceKm} km \n{_numberLaps} slaps, \npace: {_paceMinLap:F2} min/lap");
    }
}