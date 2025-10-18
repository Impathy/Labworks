using Itmo.ObjectOrientedProgramming.Lab1.ResultTypes;
using Itmo.ObjectOrientedProgramming.Lab1.TransportTypes;

namespace Itmo.ObjectOrientedProgramming.Lab1.TrackSectionTypes;

public interface ITrackSection
{
    Result CalculateTime(ITrain train, int iterationTime);
}