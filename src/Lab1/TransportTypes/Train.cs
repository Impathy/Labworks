namespace Itmo.ObjectOrientedProgramming.Lab1.TransportTypes;

public class Train : ITrain
{
    private readonly int _weight;
    private int _speed;

    public int MaxForceValue { get; }

    public int TrainСongestion { get; }

    public Train(int weight, int speed, int maxForceValue)
    {
        _weight = weight;
        _speed = speed;
        MaxForceValue = maxForceValue;
        TrainСongestion = 0;
        if (_weight < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(weight), "Weight must be greater than zero");
        }
    }

    public int ChangeSpeedOnDeafaultTrack(int iterationTime)
    {
        int speed = _speed;
        SetSpeed(speed);
        return speed;
    }

    public int ChangeSpeedOnMagnetTrack(int iterationTime, int power)
    {
        int speed = _speed;
        int acceleration = power / _weight;
        speed += acceleration * iterationTime;
        SetSpeed(speed);
        return speed;
    }

    public bool StopTrain(int maxStopSpeed)
    {
        if (_speed > maxStopSpeed)
        {
            return false;
        }

        return true;
    }

    private void SetSpeed(int speed)
    {
        if (speed > 0)
        {
            _speed = speed;
        }
    }
}