
using Challenge4.Data;

List<Product> products = new List<Product>();    

Console.Write("Digite quantos produtos deseja cadastrar: ");
int quantityOfProducts = Convert.ToInt16(Console.ReadLine());

for (var i = 1; i <= quantityOfProducts; i++)
{
    Console.WriteLine($"Product #{i} data: ");
    Console.Write("Common, used or imported (c/u/i)? ");
    char choice = Convert.ToChar(Console.ReadLine());

    switch (choice)
    {
        case 'c':
            Product product = new Product();
            product.PriceTag();
            products.Add(product);
            break;
        case 'u':
            UsedProduct usedProduct = new UsedProduct();
            usedProduct.PriceTag();
            products.Add(usedProduct);
            break;
        case 'i':
            ImportedProduct importedProduct = new ImportedProduct();
            importedProduct.PriceTag();
            products.Add(importedProduct);
            break;
        default:
            Console.WriteLine("Caractere inválido!");
            break;
    }
}

Console.WriteLine("\nPRICE TAGS:");

foreach (var product in products)
{
    Console.WriteLine(product);
}