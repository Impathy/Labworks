namespace Itmo.ObjectOrientedProgramming.Lab1.ResultTypes;

public record ComplexSuccess(ICollection<Result> Subresults) : Result;