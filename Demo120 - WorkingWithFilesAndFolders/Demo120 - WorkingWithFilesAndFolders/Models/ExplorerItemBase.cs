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
    public override string Thumbnail => "Images/unknown-file.png";
}