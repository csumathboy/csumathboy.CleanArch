using Ardalis.Result;
using csumathboy.SharedKernel;

namespace csumathboy.CleanArch.UseCases.Contributors.List;
public record ListContributorsQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<ContributorDTO>>>;
