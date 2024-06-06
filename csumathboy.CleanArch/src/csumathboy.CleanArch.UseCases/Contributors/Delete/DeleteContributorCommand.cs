using Ardalis.Result;
using csumathboy.SharedKernel;

namespace csumathboy.CleanArch.UseCases.Contributors.Delete;
public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
