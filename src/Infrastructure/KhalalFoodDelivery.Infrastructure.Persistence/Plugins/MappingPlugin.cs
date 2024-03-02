using Itmo.Dev.Platform.Postgres.Plugins;
using Npgsql;

namespace KhalalFoodDelivery.Infrastructure.Persistence.Plugins;

public class MappingPlugin : IDataSourcePlugin
{
    public void Configure(NpgsqlDataSourceBuilder builder) { }
}