using PlatformCompose.Application.Commands;
using PlatformCompose.Application.DTOs;

namespace PlatformCompose.Application.Services;

public interface IEventService
{
    Task<EventDto> AddEventAsync(AddEventCommand command, CancellationToken cancellationToken);
    Task ExpireEventAsync(ExpireEventCommand command, CancellationToken cancellationToken);
    Task CloseEventAsync(CloseEventCommand command, CancellationToken cancellationToken);
}
