using Itmo.ObjectOrientedProgramming.Lab1.ResultTypes;
using Itmo.ObjectOrientedProgramming.Lab1.TrackSectionTypes;
using Itmo.ObjectOrientedProgramming.Lab1.TransportTypes;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class TrainRoute
{
    private readonly Queue<ITrackSection> _trackSections;

    public int IterationTime { get; }

    public TrainRoute(Queue<ITrackSection> trackSections, int iterationTime)
    {
        _trackSections = trackSections;
        IterationTime = iterationTime;
    }

    public Result StartRoute(Train train)
    {
        var sectionResults = new List<Result>();
        while (_trackSections.TryDequeue(out ITrackSection? track))
        {
            Result result = track.CalculateTime(train, IterationTime);
            if (result is not Success)
            {
                return new Failure();
            }

            sectionResults.Add(result);
        }

        return new ComplexSuccess(sectionResults);
    }
}