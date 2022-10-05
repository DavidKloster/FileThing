using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Logm.FileUpdater.FileHandling;

public class FileHandlingService : IFileHandlingService
{
    public async Task<bool> SaveFile(IFormFile file)
    {
        if (file.Length <= 0) return false;

        if (!this.Validate(file)) return false;
        
        var fileMetaData = this.ExtractMetaData(file);
        
        var path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "uploaded_files"));
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
            
        // blabla
            
        return true;
    }

    private FileMetaData ExtractMetaData(IFormFile file)
    {
        //validate properties
        
        return new FileMetaData(file.Name, file.Length, file.ContentType);
    }

    private bool Validate(IFormFile file)
    {
        return true;
    }
}