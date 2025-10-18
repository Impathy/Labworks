using Itmo.ObjectOrientedProgramming.Lab1.ResultTypes;
using Itmo.ObjectOrientedProgramming.Lab1.TransportTypes;

namespace Itmo.ObjectOrientedProgramming.Lab1.TrackSectionTypes;

public class MagnetTrack : ITrackSection
{
    private readonly int _power;
    private readonly int _length;

    public MagnetTrack(int length, int power)
    {
        _length = length;
        _power = power;
    }

    public Result CalculateTime(ITrain train, int iterationTime)
    {
        int currentLenght = 0;

        if (train.MaxForceValue < _power)
        {
            return new Failure();
        }

        int time = 0;

        while (currentLenght < _length)
        {
            int newSpeed = train.ChangeSpeedOnMagnetTrack(iterationTime, _power);

            if (newSpeed <= 0)
            {
                return new Failure();
            }

            currentLenght += newSpeed;
            time += iterationTime;
        }

        return new Success(time);
    }
}