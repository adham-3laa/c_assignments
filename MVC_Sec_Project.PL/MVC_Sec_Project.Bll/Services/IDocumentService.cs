using Microsoft.AspNetCore.Http;

namespace MVC_Sec_Project.Bll.Services;
public interface IDocumentService
{
    Task<string?> UploadAsync(IFormFile file, string folderName);
    Task DeleteAsync(string fileName, string folderName);
}
