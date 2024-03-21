using System.IO;

namespace Demo120___WorkingWithFilesAndFolders.Services;

public class ExplorerServices
{
    public static List<Models.ExplorerDriveItem> GetDrives()
    {
        return DriveInfo.GetDrives().Select(c => new Models.ExplorerDriveItem()
        {
            Name = c.Name
        }).ToList();
    }

    public static List<Models.ExplorerFolderItem> GetFolders(string path)
    {
        return Directory.GetDirectories(path).Select(d => new Models.ExplorerFolderItem()
        {
            Name = Path.GetFileName(d)
        }).ToList();
    }

    public static List<Models.ExplorerFileItem> GetFiles(string path)
    {
        return Directory.GetFiles(path).Select(d => new Models.ExplorerFileItem()
        {
            Name = Path.GetFileName(d)
        }).ToList();
    }
}