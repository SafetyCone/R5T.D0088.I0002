using System;

using R5T.T0063;


namespace R5T.D0088.I0002
{
    /// <summary>
    /// Service action aggregation for services required by <see cref="HostStartupBase"/>.
    /// Note: required services are *not* service dependencies. They are services that must be chosen by a derived class in the <see cref="HostStartupBase.FillRequiredServiceActions"/> method, not chosen while configuring the service collection used to provide the startup class itself.
    /// </summary>
    [ServiceActionAggregationMarker]
    public interface IRequiredServiceActionAggregation : IServiceActionAggregation
    {
    }
}
