using Ardalis.Result;
using csumathboy.SharedKernel;

namespace csumathboy.CleanArch.UseCases.Contributors.Get;
public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
