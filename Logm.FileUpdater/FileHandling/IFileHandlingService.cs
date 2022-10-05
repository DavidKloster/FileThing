namespace Logm.FileUpdater.FileHandling;

public interface IFileHandlingService
{
    Task<bool> SaveFile(IFormFile file);
}