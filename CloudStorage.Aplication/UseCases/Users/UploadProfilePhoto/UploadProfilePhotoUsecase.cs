using CloudStorage.Domain.Entities;
using CloudStorage.Domain.Storage;
using FileTypeChecker.Extensions;
using FileTypeChecker.Types;
using Microsoft.AspNetCore.Http;

namespace CloudStorage.Aplication.UseCases.Users.UploadProfilePhoto;

public class UploadProfilePhotoUsecase : IUploadProfilePhotoUsecase
{
    private readonly IStorageService _storageService;

    public UploadProfilePhotoUsecase(IStorageService storageService)
    {
        _storageService = storageService;
    }
    public void Execute(IFormFile file)
    {
        var fileStream = file.OpenReadStream();

        var IsImage = fileStream.Is<JointPhotographicExpertsGroup>();

        if (IsImage == false)
            throw new Exception("This file is not an image.");

        var user = GetFromDatabase();

        _storageService.Upload(file, user);
    }

    private User GetFromDatabase()
    {
        return new User
        {
            Id = 1,
            Name = "Nicollas",
            Email = "teste@gmail",
            RefreshToken = "RefreshTokenExample",
            AccesToken = "AccesTokenExample"
        };
    }
}
