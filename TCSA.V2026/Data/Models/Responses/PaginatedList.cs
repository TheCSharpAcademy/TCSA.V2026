namespace TCSA.V2026.Data.Models.Responses;

public class PaginatedList<T>
{
    public List<T> Items { get; } = new();
    public int TotalItems { get; }
    public int PageNumber { get; }
    public readonly int PageSize;
    public int TotalPages => (int)Math.Ceiling(TotalItems / (double)PageSize);

    public PaginatedList(List<T> items, int totalItems, int pageNumber)
    {
        Items = items;
        TotalItems = totalItems;
        PageNumber = pageNumber;
    }
}
