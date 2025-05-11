﻿using BuildingBlocks.CQRS;
using Catalog.API.Models;

namespace Catalog.API.Products.CreateProduct;

public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, double Price) : ICommand<CreateProductResult>;
public record CreateProductResult(Guid Id);
public class CreateProductCommonHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        //Create a new product entity from command object
        // save to database
        // return CreateProductResult result

        var product = new Product
        {
            Name = command.Name,
            Category = command.Category,
            Description = command.Description,
            ImageFile = command.ImageFile,
            Price = command.Price,
        };

        // Todo:
        // save to database.
        // return CreateProductResult result
        return new CreateProductResult(Guid.NewGuid());
    }
}
