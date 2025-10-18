namespace Itmo.ObjectOrientedProgramming.Lab1.TransportTypes;

public interface ITrain
{
    int ChangeSpeedOnDeafaultTrack(int iterationTime);

    int ChangeSpeedOnMagnetTrack(int iterationTime, int power);

    int TrainСongestion { get; }

    int MaxForceValue { get; }

    bool StopTrain(int maxStopSpeed);
}