using Microsoft.AspNetCore.Http;

namespace MVC_Sec_Project.Bll.Services;
public class DocumentService : IDocumentService
{

    private List<string> _allowedExtensions = [".png", ".Pdf", ".jpeg"];
    private const int MAXSIZE = 2_097_152;
    public async Task<string?> UploadAsync(IFormFile file, string folderName)
    {
        // Validate Extension and size 
        var extension = Path.GetExtension(file.FileName);
        if (!_allowedExtensions.Contains(extension))
            return null; /// throw new Exception => 
        if (file.Length > MAXSIZE)
            return null;
        // Create Unique filename 

        var fileName = $"{Guid.NewGuid()}{extension}";


        var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Data", folderName);

        var filePath = Path.Combine(folderPath, fileName);

        using Stream stream = new FileStream(filePath, FileMode.Create);


        await file.CopyToAsync(stream);
        return fileName;

    }
    public Task DeleteAsync(string fileName, string folderName)
    {
        throw new NotImplementedException();
    }



}
