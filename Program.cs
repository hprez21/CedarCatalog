using CedarCatalog;

var actionKey = 'l';
var titleToSearch = "  THE GLASS MAP  ";
_ = titleToSearch; // The search action will use this input.

Console.WriteLine(CatalogMenu.GetMenuText());

switch (char.ToLowerInvariant(actionKey))
{
    case 'l':
        foreach (var book in CatalogData.Books)
        {
            Console.WriteLine(book.Title);
        }

        return 0;
    case 'q':
        return 0;

    // Add the title search action here.
    default:
        Console.Error.WriteLine($"Unsupported action '{actionKey}'.");
        return 2;
}
