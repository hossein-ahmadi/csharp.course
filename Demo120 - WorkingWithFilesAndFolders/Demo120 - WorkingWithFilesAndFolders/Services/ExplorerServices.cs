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
}