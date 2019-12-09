namespace SpaceRental.Core.UseCases
{
    public interface IBookListingInteractor
        : IUseCaseInteractor<BookListingRequest, BookListingResponse>
    { }
    public class BookListingInteractor : IBookListingInteractor
    {
        public BookListingResponse Handle(BookListingRequest request)
        {
            // Studio Listing
            // Time and Date for booking
            // Payment information
            return new BookListingResponse();
        }
    }
}