namespace Demo120___WorkingWithFilesAndFolders.Models;

public abstract class ExplorerItemBase
{
    public string Name { get; set; }

    public abstract string Thumbnail { get; }
}

public class ExplorerDriveItem : ExplorerItemBase
{
    public override string Thumbnail => "Images/drive.png";
}

public class ExplorerFolderItem : ExplorerItemBase
{
    public override string Thumbnail => "throw new NotImplementedException()";
}

public class ExplorerFileItem : ExplorerItemBase
{
    public override string Thumbnail => "throw new NotImplementedException()";
}