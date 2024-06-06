using Ardalis.Result;
using csumathboy.SharedKernel;

namespace csumathboy.CleanArch.UseCases.Contributors.Update;
public record UpdateContributorCommand(int ContributorId, string NewName) : ICommand<Result<ContributorDTO>>;
