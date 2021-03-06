public enum RATreeViewStyle : uint
{
	Plain = 0,
	Grouped
}

public enum RATreeViewCellSeparatorStyle : uint
{
	None = 0,
	SingleLine,
	SingleLineEtched
}

public enum RATreeViewScrollPosition : uint
{
	None = 0,
	Top,
	Middle,
	Bottom
}

public enum RATreeViewRowAnimation : uint
{
	Fade = 0,
	Right,
	Left,
	Top,
	Bottom,
	None,
	Middle,
	Automatic = UITableViewRowAnimationAutomatic
}
