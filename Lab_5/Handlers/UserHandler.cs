using Lab_5.Models;
using Lab_5.Repositories;

namespace Lab_5.Handlers;

public class UserHandler : Handler
{
    private IRepository _repository;
    private string _validationError;

    public UserHandler(IRepository repository)
    {
        _repository = repository;
    }

    protected override IRepository GetRepository()
    {
        return _repository;
    }

    protected override string GetValidationError()
    {
        return _validationError;
    }

    protected override bool ValidateData(Item oldItem, Item newItem)
    {
        if (oldItem != null)
        {
            if (((User)newItem).Email == ((User)oldItem).Email)
            {
                return true;
            }
            _validationError = "User email cannot be changed";
        }
        else
        {
            _validationError = "The user does not exist";
        }

        return false;
    }

    protected override void ProcessIfFailed(Item item)
    {
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

