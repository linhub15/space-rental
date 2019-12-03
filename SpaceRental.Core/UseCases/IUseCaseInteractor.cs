namespace SpaceRental.Core.UseCases
{
    public interface IUseCaseInteractor<TRequest, TResponse>
    {
        TResponse Handle(TRequest useCaseRequest);
    }
}