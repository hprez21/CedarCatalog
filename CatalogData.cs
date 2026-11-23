using System.Collections.Immutable;

namespace CedarCatalog;

public sealed record Book(int Id, string Title);

public sealed record BookCopy(int Id, int BookId);

public sealed record Loan(int CopyId, DateOnly DueDate, DateOnly? ReturnDate);

public static class CatalogData
{
    public static ImmutableArray<Book> Books { get; } =
    [
        new(1, "The Glass Map"),
        new(2, "Stone and Sea"),
        new(3, "A Quiet Harbor"),
    ];

    public static ImmutableArray<BookCopy> Copies { get; } =
    [
        new(101, BookId: 1),
        new(102, BookId: 1),
        new(201, BookId: 2),
        new(301, BookId: 3),
        new(302, BookId: 3),
    ];

    // A null return date means the copy is still checked out.
    public static ImmutableArray<Loan> Loans { get; } =
    [
        new(CopyId: 101, DueDate: new(2030, 5, 3), ReturnDate: null),
        new(CopyId: 102, DueDate: new(2030, 5, 10), ReturnDate: null),
        new(CopyId: 201, DueDate: new(2025, 4, 11), ReturnDate: new(2025, 4, 9)),
        new(CopyId: 301, DueDate: new(2025, 4, 11), ReturnDate: null),
    ];
}
