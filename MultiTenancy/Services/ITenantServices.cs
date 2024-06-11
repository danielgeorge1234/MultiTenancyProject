using MultiTenancy.Settings;

namespace MultiTenancy.Services
{
    public interface ITenantServices
    {
        string? GetDatabaseProvider();

        string? GetConnectionString();

        Tenant GetCurrentTenant();




    }
}
