using Microsoft.AspNetCore.Http;

namespace CloudStorage.Aplication.UseCases.Users.UploadProfilePhoto;
public interface IUploadProfilePhotoUsecase
{
    public void Execute(IFormFile file);
}
