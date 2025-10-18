using Itmo.ObjectOrientedProgramming.Lab1.ResultTypes;
using Itmo.ObjectOrientedProgramming.Lab1.TransportTypes;

namespace Itmo.ObjectOrientedProgramming.Lab1.TrackSectionTypes;

public class TrainStation : ITrackSection
{
    private readonly int _stationCongestion;
    private readonly int _maxStopSpeed;

    public TrainStation(int stationСongestion, int maxStopSpeed)
    {
        _stationCongestion = stationСongestion;
        _maxStopSpeed = maxStopSpeed;
    }

    public Result CalculateTime(ITrain train, int iterationTime)
    {
        if (!train.StopTrain(_maxStopSpeed))
        {
            return new Failure();
        }

        int time = 0;
        if (_stationCongestion > 50 && train.TrainСongestion > 50)
        {
            time = 3 * iterationTime;
        }
        else if (_stationCongestion > 50 || train.TrainСongestion > 50)
        {
            time = 2 * iterationTime;
        }
        else
        {
            time = iterationTime;
        }

        return new Success(time);
    }
}