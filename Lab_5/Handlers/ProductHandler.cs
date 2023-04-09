using Lab_5.Models;
using Lab_5.Repositories;

namespace Lab_5.Handlers;

public class ProductHandler : Handler
{
    private IRepository _repository;

    public ProductHandler(IRepository repository)
    {
        _repository = repository;
    }

    protected override IRepository GetRepository()
    {
        return _repository;
    }

    protected override string GetValidationError()
    {
        return string.Empty;
    }

    protected override bool ValidateData(Item oldItem, Item newItem)
    {
        return true;
    }

    protected override void ProcessIfFailed(Item item)
    {
        Console.WriteLine("Send message to manager");
    }

    protected override Response CreateResponse(Item item)
    {
        return new Response { Status = "Updated", Code = 200 };
    }

    // Hooks for future use
    protected override void PreValidation(Item item)
    {
    }

    protected override void Initialization()
    {
    }

    protected override void ReleaseConnection()
    {
    }
}

