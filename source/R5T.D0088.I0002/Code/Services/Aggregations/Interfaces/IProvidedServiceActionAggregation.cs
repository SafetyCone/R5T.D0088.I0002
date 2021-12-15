using System;

using R5T.T0063;


namespace R5T.D0088.I0002
{
    /// <summary>
    /// Service action aggregation for services provided by <see cref="HostStartupBase"/>.
    /// </summary>
    [ServiceActionAggregationMarker]
    public interface IProvidedServiceActionAggregation : IServiceActionAggregation,
        A0001.IHostServiceActionAggregration
    {
    }
}
