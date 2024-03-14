using CloudStorage.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace CloudStorage.Domain.Storage;

public interface IStorageService
{
    string Upload(IFormFile file, User user);
}