    using PlatformCompose.Application.Services;

namespace PlatformCompose.Infrastructure.Services
{
    public static class NServiceBusEventPublisherAccessor
    {
        public static ISenderService? Instance { get; set; }
    }
}
