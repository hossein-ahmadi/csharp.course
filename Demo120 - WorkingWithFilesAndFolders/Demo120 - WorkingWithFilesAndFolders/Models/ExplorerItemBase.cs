using System.IO;

namespace Demo120___WorkingWithFilesAndFolders.Models;

public abstract class ExplorerItemBase
{
    public string Name { get; set; }

    public abstract string Thumbnail { get; }
}

public class ExplorerBackItem : ExplorerItemBase
{
    public override string Thumbnail => "";
}

public class ExplorerDriveItem : ExplorerItemBase
{
    public override string Thumbnail => "Images/drive.png";
}

public class ExplorerFolderItem : ExplorerItemBase
{
    public override string Thumbnail => "Images/folder.png";
}

public class ExplorerFileItem : ExplorerItemBase
{
    public override string Thumbnail
    {
        get
        {
            var fileExtension = Path.GetExtension(Name)?.ToLower().Trim();

            if (fileExtension == null)
                return "Images/unknown-file.png";

            switch (fileExtension)
            {
                case ".txt":
                    return "Images/text-file.png";
                default:
                    return "Images/unknown-file.png";
            }
        }
    }
}