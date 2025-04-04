using BookingApp.Business.Operations.Feature.Dtos;
using BookingApp.Business.Types;

namespace BookingApp.Business.Operations.Feature
{
    public interface IFeatureService
    {
        Task<ServiceMessage> AddFeature(AddFeatureDto feature);
    }
}