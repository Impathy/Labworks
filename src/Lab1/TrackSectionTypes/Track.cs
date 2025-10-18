using Itmo.ObjectOrientedProgramming.Lab1.ResultTypes;
using Itmo.ObjectOrientedProgramming.Lab1.TransportTypes;

namespace Itmo.ObjectOrientedProgramming.Lab1.TrackSectionTypes;

public class Track : ITrackSection
{
    private readonly int _length;

    public Track(int length)
    {
        _length = length;
    }

    public Result CalculateTime(ITrain train, int iterationTime)
    {
        int currentLenght = 0;
        int time = 0;

        while (currentLenght < _length)
        {
            int newSpeed = train.ChangeSpeedOnDeafaultTrack(iterationTime);

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