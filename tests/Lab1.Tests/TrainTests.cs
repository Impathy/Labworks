using Itmo.ObjectOrientedProgramming.Lab1.ResultTypes;
using Itmo.ObjectOrientedProgramming.Lab1.TrackSectionTypes;
using Itmo.ObjectOrientedProgramming.Lab1.TransportTypes;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TrainTests
{
    [Fact]
    public void TestPaths1()
    {
        var train = new Train(10, 0, 1000);
        var route = new TrainRoute(
            new Queue<ITrackSection>(new ITrackSection[]
            {
                new MagnetTrack(100, 10),
                new Track(100),
            }),
            1);
        Result result = route.StartRoute(train);
        Assert.True(result is ComplexSuccess);
    }

    [Fact]
    public void TestPaths2()
    {
        var train = new Train(10, 0, 1);
        var route = new TrainRoute(
            new Queue<ITrackSection>(new ITrackSection[]
            {
                new MagnetTrack(100, 10),
                new Track(100),
            }),
            1);
        Result result = route.StartRoute(train);
        Assert.True(result is Failure);
    }

    [Fact]
    public void TestPaths3()
    {
        var train = new Train(1, 0, 10000000);
        var route = new TrainRoute(
            new Queue<ITrackSection>(new ITrackSection[]
            {
                new MagnetTrack(1, 1),
                new Track(1),
                new TrainStation(1, 1000000000),
                new Track(100),
            }),
            1);
        Result result = route.StartRoute(train);
        Assert.True(result is ComplexSuccess);
    }

    [Fact]
    public void TestPaths4()
    {
        var train = new Train(10, 0, 1);
        var route = new TrainRoute(
            new Queue<ITrackSection>(new ITrackSection[]
            {
                new MagnetTrack(100, 10),
                new TrainStation(100, 1),
            }),
            1);
        Result result = route.StartRoute(train);
        Assert.True(result is Failure);
    }

    [Fact]
    public void TestPaths5()
    {
        var train = new Train(10, 0, 1);
        var route = new TrainRoute(
            new Queue<ITrackSection>(new ITrackSection[]
            {
                new MagnetTrack(1, 10),
                new Track(1),
                new TrainStation(1, 1000000000),
                new Track(100),
            }),
            1);
        Result result = route.StartRoute(train);
        Assert.True(result is Failure);
    }

    [Fact]
    public void TestPaths6()
    {
        var train = new Train(1, 0, 10000);
        var route = new TrainRoute(
            new Queue<ITrackSection>(new ITrackSection[]
            {
                new MagnetTrack(1, 11),
                new Track(1),
                new MagnetTrack(1, -9),
                new TrainStation(1, 10),
                new Track(100),
                new MagnetTrack(1, 10000),
                new Track(100),
                new MagnetTrack(1, -1000),
            }),
            1);
        Result result = route.StartRoute(train);
        Assert.True(result is ComplexSuccess);
    }

    [Fact]
    public void TestPaths7()
    {
        var train = new Train(10, 0, 1);
        var route = new TrainRoute(
            new Queue<ITrackSection>(new ITrackSection[]
            {
                new Track(100),
            }),
            1);
        Result result = route.StartRoute(train);
        Assert.True(result is Failure);
    }

    [Fact]
    public void TestPaths8()
    {
        var train = new Train(10, 0, 100);
        var route = new TrainRoute(
            new Queue<ITrackSection>(new ITrackSection[]
            {
                new MagnetTrack(100, 1),
                new MagnetTrack(100, -2),
            }),
            1);
        Result result = route.StartRoute(train);
        Assert.True(result is Failure);
    }
}