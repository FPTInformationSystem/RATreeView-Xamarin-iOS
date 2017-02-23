using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

// @protocol RATreeViewDataSource <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface RATreeViewDataSource
{
	// @required -(NSInteger)treeView:(RATreeView * _Nonnull)treeView numberOfChildrenOfItem:(id _Nullable)item;
	[Abstract]
	[Export ("treeView:numberOfChildrenOfItem:")]
	nint TreeView (RATreeView treeView, [NullAllowed] NSObject item);

	// @required -(UITableViewCell * _Nonnull)treeView:(RATreeView * _Nonnull)treeView cellForItem:(id _Nullable)item;
	[Abstract]
	[Export ("treeView:cellForItem:")]
	UITableViewCell TreeView (RATreeView treeView, [NullAllowed] NSObject item);

	// @required -(id _Nonnull)treeView:(RATreeView * _Nonnull)treeView child:(NSInteger)index ofItem:(id _Nullable)item;
	[Abstract]
	[Export ("treeView:child:ofItem:")]
	NSObject TreeView (RATreeView treeView, nint index, [NullAllowed] NSObject item);

	// @optional -(void)treeView:(RATreeView * _Nonnull)treeView commitEditingStyle:(UITableViewCellEditingStyle)editingStyle forRowForItem:(id _Nonnull)item;
	[Export ("treeView:commitEditingStyle:forRowForItem:")]
	void TreeView (RATreeView treeView, UITableViewCellEditingStyle editingStyle, NSObject item);

	// @optional -(BOOL)treeView:(RATreeView * _Nonnull)treeView canEditRowForItem:(id _Nonnull)item;
	[Export ("treeView:canEditRowForItem:")]
	bool TreeView (RATreeView treeView, NSObject item);
}

// @protocol RATreeViewDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface RATreeViewDelegate
{
	// @optional -(CGFloat)treeView:(RATreeView * _Nonnull)treeView heightForRowForItem:(id _Nonnull)item;
	[Export ("treeView:heightForRowForItem:")]
	nfloat TreeView (RATreeView treeView, NSObject item);

	// @optional -(CGFloat)treeView:(RATreeView * _Nonnull)treeView estimatedHeightForRowForItem:(id _Nonnull)item __attribute__((availability(ios, introduced=7_0)));
	[iOS (7,0)]
	[Export ("treeView:estimatedHeightForRowForItem:")]
	nfloat TreeView (RATreeView treeView, NSObject item);

	// @optional -(NSInteger)treeView:(RATreeView * _Nonnull)treeView indentationLevelForRowForItem:(id _Nonnull)item;
	[Export ("treeView:indentationLevelForRowForItem:")]
	nint TreeView (RATreeView treeView, NSObject item);

	// @optional -(void)treeView:(RATreeView * _Nonnull)treeView willDisplayCell:(UITableViewCell * _Nonnull)cell forItem:(id _Nonnull)item;
	[Export ("treeView:willDisplayCell:forItem:")]
	void TreeView (RATreeView treeView, UITableViewCell cell, NSObject item);

	// @optional -(void)treeView:(RATreeView * _Nonnull)treeView accessoryButtonTappedForRowForItem:(id _Nonnull)item;
	[Export ("treeView:accessoryButtonTappedForRowForItem:")]
	void TreeView (RATreeView treeView, NSObject item);

	// @optional -(BOOL)treeView:(RATreeView * _Nonnull)treeView shouldExpandRowForItem:(id _Nonnull)item;
	[Export ("treeView:shouldExpandRowForItem:")]
	bool TreeView (RATreeView treeView, NSObject item);

	// @optional -(BOOL)treeView:(RATreeView * _Nonnull)treeView shouldCollapaseRowForItem:(id _Nonnull)item;
	[Export ("treeView:shouldCollapaseRowForItem:")]
	bool TreeView (RATreeView treeView, NSObject item);

	// @optional -(void)treeView:(RATreeView * _Nonnull)treeView willExpandRowForItem:(id _Nonnull)item;
	[Export ("treeView:willExpandRowForItem:")]
	void TreeView (RATreeView treeView, NSObject item);

	// @optional -(void)treeView:(RATreeView * _Nonnull)treeView willCollapseRowForItem:(id _Nonnull)item;
	[Export ("treeView:willCollapseRowForItem:")]
	void TreeView (RATreeView treeView, NSObject item);

	// @optional -(void)treeView:(RATreeView * _Nonnull)treeView didExpandRowForItem:(id _Nonnull)item;
	[Export ("treeView:didExpandRowForItem:")]
	void TreeView (RATreeView treeView, NSObject item);

	// @optional -(void)treeView:(RATreeView * _Nonnull)treeView didCollapseRowForItem:(id _Nonnull)item;
	[Export ("treeView:didCollapseRowForItem:")]
	void TreeView (RATreeView treeView, NSObject item);

	// @optional -(id _Nonnull)treeView:(RATreeView * _Nonnull)treeView willSelectRowForItem:(id _Nonnull)item;
	[Export ("treeView:willSelectRowForItem:")]
	NSObject TreeView (RATreeView treeView, NSObject item);

	// @optional -(void)treeView:(RATreeView * _Nonnull)treeView didSelectRowForItem:(id _Nonnull)item;
	[Export ("treeView:didSelectRowForItem:")]
	void TreeView (RATreeView treeView, NSObject item);

	// @optional -(id _Nonnull)treeView:(RATreeView * _Nonnull)treeView willDeselectRowForItem:(id _Nonnull)item;
	[Export ("treeView:willDeselectRowForItem:")]
	NSObject TreeView (RATreeView treeView, NSObject item);

	// @optional -(void)treeView:(RATreeView * _Nonnull)treeView didDeselectRowForItem:(id _Nonnull)item;
	[Export ("treeView:didDeselectRowForItem:")]
	void TreeView (RATreeView treeView, NSObject item);

	// @optional -(void)treeView:(RATreeView * _Nonnull)treeView willBeginEditingRowForItem:(id _Nonnull)item;
	[Export ("treeView:willBeginEditingRowForItem:")]
	void TreeView (RATreeView treeView, NSObject item);

	// @optional -(void)treeView:(RATreeView * _Nonnull)treeView didEndEditingRowForItem:(id _Nonnull)item;
	[Export ("treeView:didEndEditingRowForItem:")]
	void TreeView (RATreeView treeView, NSObject item);

	// @optional -(UITableViewCellEditingStyle)treeView:(RATreeView * _Nonnull)treeView editingStyleForRowForItem:(id _Nonnull)item;
	[Export ("treeView:editingStyleForRowForItem:")]
	UITableViewCellEditingStyle TreeView (RATreeView treeView, NSObject item);

	// @optional -(NSString * _Nonnull)treeView:(RATreeView * _Nonnull)treeView titleForDeleteConfirmationButtonForRowForItem:(id _Nonnull)item;
	[Export ("treeView:titleForDeleteConfirmationButtonForRowForItem:")]
	string TreeView (RATreeView treeView, NSObject item);

	// @optional -(BOOL)treeView:(RATreeView * _Nonnull)treeView shouldIndentWhileEditingRowForItem:(id _Nonnull)item;
	[Export ("treeView:shouldIndentWhileEditingRowForItem:")]
	bool TreeView (RATreeView treeView, NSObject item);

	// @optional -(NSArray * _Nonnull)treeView:(RATreeView * _Nonnull)treeView editActionsForItem:(id _Nonnull)item;
	[Export ("treeView:editActionsForItem:")]
	[Verify (StronglyTypedNSArray)]
	NSObject[] TreeView (RATreeView treeView, NSObject item);

	// @optional -(void)treeView:(RATreeView * _Nonnull)treeView didEndDisplayingCell:(UITableViewCell * _Nonnull)cell forItem:(id _Nonnull)item;
	[Export ("treeView:didEndDisplayingCell:forItem:")]
	void TreeView (RATreeView treeView, UITableViewCell cell, NSObject item);

	// @optional -(BOOL)treeView:(RATreeView * _Nonnull)treeView shouldShowMenuForRowForItem:(id _Nonnull)item;
	[Export ("treeView:shouldShowMenuForRowForItem:")]
	bool TreeView (RATreeView treeView, NSObject item);

	// @optional -(BOOL)treeView:(RATreeView * _Nonnull)treeView canPerformAction:(SEL _Nonnull)action forRowForItem:(id _Nonnull)item withSender:(id _Nonnull)sender;
	[Export ("treeView:canPerformAction:forRowForItem:withSender:")]
	bool TreeView (RATreeView treeView, Selector action, NSObject item, NSObject sender);

	// @optional -(void)treeView:(RATreeView * _Nonnull)treeView performAction:(SEL _Nonnull)action forRowForItem:(id _Nonnull)item withSender:(id _Nonnull)sender;
	[Export ("treeView:performAction:forRowForItem:withSender:")]
	void TreeView (RATreeView treeView, Selector action, NSObject item, NSObject sender);

	// @optional -(BOOL)treeView:(RATreeView * _Nonnull)treeView shouldHighlightRowForItem:(id _Nonnull)item;
	[Export ("treeView:shouldHighlightRowForItem:")]
	bool TreeView (RATreeView treeView, NSObject item);

	// @optional -(void)treeView:(RATreeView * _Nonnull)treeView didHighlightRowForItem:(id _Nonnull)item;
	[Export ("treeView:didHighlightRowForItem:")]
	void TreeView (RATreeView treeView, NSObject item);

	// @optional -(void)treeView:(RATreeView * _Nonnull)treeView didUnhighlightRowForItem:(id _Nonnull)item;
	[Export ("treeView:didUnhighlightRowForItem:")]
	void TreeView (RATreeView treeView, NSObject item);
}

// @interface RATreeView : UIView
[BaseType (typeof(UIView))]
interface RATreeView
{
	// -(id _Nonnull)initWithFrame:(CGRect)frame style:(RATreeViewStyle)style;
	[Export ("initWithFrame:style:")]
	IntPtr Constructor (CGRect frame, RATreeViewStyle style);

	// @property (nonatomic, weak) id<RATreeViewDataSource> _Nullable dataSource;
	[NullAllowed, Export ("dataSource", ArgumentSemantic.Weak)]
	RATreeViewDataSource DataSource { get; set; }

	[Wrap ("WeakDelegate")]
	[NullAllowed]
	RATreeViewDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<RATreeViewDelegate> _Nullable delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// -(NSInteger)numberOfRows;
	[Export ("numberOfRows")]
	[Verify (MethodToProperty)]
	nint NumberOfRows { get; }

	// @property (readonly, nonatomic) RATreeViewStyle style;
	[Export ("style")]
	RATreeViewStyle Style { get; }

	// @property (nonatomic) RATreeViewCellSeparatorStyle separatorStyle;
	[Export ("separatorStyle", ArgumentSemantic.Assign)]
	RATreeViewCellSeparatorStyle SeparatorStyle { get; set; }

	// @property (nonatomic, strong) UIColor * _Nullable separatorColor;
	[NullAllowed, Export ("separatorColor", ArgumentSemantic.Strong)]
	UIColor SeparatorColor { get; set; }

	// @property (nonatomic) CGFloat rowHeight;
	[Export ("rowHeight")]
	nfloat RowHeight { get; set; }

	// @property (nonatomic) CGFloat estimatedRowHeight __attribute__((availability(ios, introduced=7_0)));
	[iOS (7, 0)]
	[Export ("estimatedRowHeight")]
	nfloat EstimatedRowHeight { get; set; }

	// @property (nonatomic) UIEdgeInsets separatorInset __attribute__((availability(ios, introduced=7_0)));
	[iOS (7, 0)]
	[Export ("separatorInset", ArgumentSemantic.Assign)]
	UIEdgeInsets SeparatorInset { get; set; }

	// @property (copy, nonatomic) UIVisualEffect * _Nullable separatorEffect __attribute__((annotate("ui_appearance_selector"))) __attribute__((availability(ios, introduced=8_0)));
	[iOS (8, 0)]
	[NullAllowed, Export ("separatorEffect", ArgumentSemantic.Copy)]
	UIVisualEffect SeparatorEffect { get; set; }

	// @property (nonatomic) BOOL cellLayoutMarginsFollowReadableWidth __attribute__((availability(ios, introduced=9_0)));
	[iOS (9, 0)]
	[Export ("cellLayoutMarginsFollowReadableWidth")]
	bool CellLayoutMarginsFollowReadableWidth { get; set; }

	// @property (nonatomic, strong) UIView * _Nullable backgroundView;
	[NullAllowed, Export ("backgroundView", ArgumentSemantic.Strong)]
	UIView BackgroundView { get; set; }

	// -(void)expandRowForItem:(id _Nullable)item expandChildren:(BOOL)expandChildren withRowAnimation:(RATreeViewRowAnimation)animation;
	[Export ("expandRowForItem:expandChildren:withRowAnimation:")]
	void ExpandRowForItem ([NullAllowed] NSObject item, bool expandChildren, RATreeViewRowAnimation animation);

	// -(void)expandRowForItem:(id _Nullable)item withRowAnimation:(RATreeViewRowAnimation)animation;
	[Export ("expandRowForItem:withRowAnimation:")]
	void ExpandRowForItem ([NullAllowed] NSObject item, RATreeViewRowAnimation animation);

	// -(void)expandRowForItem:(id _Nullable)item;
	[Export ("expandRowForItem:")]
	void ExpandRowForItem ([NullAllowed] NSObject item);

	// -(void)collapseRowForItem:(id _Nullable)item collapseChildren:(BOOL)collapseChildren withRowAnimation:(RATreeViewRowAnimation)animation;
	[Export ("collapseRowForItem:collapseChildren:withRowAnimation:")]
	void CollapseRowForItem ([NullAllowed] NSObject item, bool collapseChildren, RATreeViewRowAnimation animation);

	// -(void)collapseRowForItem:(id _Nullable)item withRowAnimation:(RATreeViewRowAnimation)animation;
	[Export ("collapseRowForItem:withRowAnimation:")]
	void CollapseRowForItem ([NullAllowed] NSObject item, RATreeViewRowAnimation animation);

	// -(void)collapseRowForItem:(id _Nullable)item;
	[Export ("collapseRowForItem:")]
	void CollapseRowForItem ([NullAllowed] NSObject item);

	// @property (nonatomic) BOOL expandsChildRowsWhenRowExpands;
	[Export ("expandsChildRowsWhenRowExpands")]
	bool ExpandsChildRowsWhenRowExpands { get; set; }

	// @property (nonatomic) BOOL collapsesChildRowsWhenRowCollapses;
	[Export ("collapsesChildRowsWhenRowCollapses")]
	bool CollapsesChildRowsWhenRowCollapses { get; set; }

	// @property (nonatomic) RATreeViewRowAnimation rowsExpandingAnimation;
	[Export ("rowsExpandingAnimation", ArgumentSemantic.Assign)]
	RATreeViewRowAnimation RowsExpandingAnimation { get; set; }

	// @property (nonatomic) RATreeViewRowAnimation rowsCollapsingAnimation;
	[Export ("rowsCollapsingAnimation", ArgumentSemantic.Assign)]
	RATreeViewRowAnimation RowsCollapsingAnimation { get; set; }

	// -(void)beginUpdates;
	[Export ("beginUpdates")]
	void BeginUpdates ();

	// -(void)endUpdates;
	[Export ("endUpdates")]
	void EndUpdates ();

	// -(void)insertItemsAtIndexes:(NSIndexSet * _Nonnull)indexes inParent:(id _Nullable)parent withAnimation:(RATreeViewRowAnimation)animation;
	[Export ("insertItemsAtIndexes:inParent:withAnimation:")]
	void InsertItemsAtIndexes (NSIndexSet indexes, [NullAllowed] NSObject parent, RATreeViewRowAnimation animation);

	// -(void)moveItemAtIndex:(NSInteger)oldIndex inParent:(id _Nullable)oldParent toIndex:(NSInteger)newIndex inParent:(id _Nullable)newParent;
	[Export ("moveItemAtIndex:inParent:toIndex:inParent:")]
	void MoveItemAtIndex (nint oldIndex, [NullAllowed] NSObject oldParent, nint newIndex, [NullAllowed] NSObject newParent);

	// -(void)deleteItemsAtIndexes:(NSIndexSet * _Nonnull)indexes inParent:(id _Nullable)parent withAnimation:(RATreeViewRowAnimation)animation;
	[Export ("deleteItemsAtIndexes:inParent:withAnimation:")]
	void DeleteItemsAtIndexes (NSIndexSet indexes, [NullAllowed] NSObject parent, RATreeViewRowAnimation animation);

	// -(void)registerClass:(Class _Nullable)cellClass forCellReuseIdentifier:(NSString * _Nonnull)identifier __attribute__((availability(ios, introduced=6_0)));
	[iOS (6,0)]
	[Export ("registerClass:forCellReuseIdentifier:")]
	void RegisterClass ([NullAllowed] Class cellClass, string identifier);

	// -(void)registerNib:(UINib * _Nullable)nib forCellReuseIdentifier:(NSString * _Nonnull)identifier;
	[Export ("registerNib:forCellReuseIdentifier:")]
	void RegisterNib ([NullAllowed] UINib nib, string identifier);

	// -(id _Nullable)dequeueReusableCellWithIdentifier:(NSString * _Nonnull)identifier;
	[Export ("dequeueReusableCellWithIdentifier:")]
	[return: NullAllowed]
	NSObject DequeueReusableCellWithIdentifier (string identifier);

	// -(void)registerNib:(UINib * _Nonnull)nib forHeaderFooterViewReuseIdentifier:(NSString * _Nonnull)identifier __attribute__((availability(ios, introduced=6_0)));
	[iOS (6,0)]
	[Export ("registerNib:forHeaderFooterViewReuseIdentifier:")]
	void RegisterNib (UINib nib, string identifier);

	// -(void)registerClass:(Class _Nonnull)aClass forHeaderFooterViewReuseIdentifier:(NSString * _Nonnull)identifier __attribute__((availability(ios, introduced=6_0)));
	[iOS (6,0)]
	[Export ("registerClass:forHeaderFooterViewReuseIdentifier:")]
	void RegisterClass (Class aClass, string identifier);

	// -(id _Nonnull)dequeueReusableHeaderFooterViewWithIdentifier:(NSString * _Nonnull)identifier __attribute__((availability(ios, introduced=6_0)));
	[iOS (6,0)]
	[Export ("dequeueReusableHeaderFooterViewWithIdentifier:")]
	NSObject DequeueReusableHeaderFooterViewWithIdentifier (string identifier);

	// @property (nonatomic, strong) UIView * _Nullable treeHeaderView;
	[NullAllowed, Export ("treeHeaderView", ArgumentSemantic.Strong)]
	UIView TreeHeaderView { get; set; }

	// @property (nonatomic, strong) UIView * _Nullable treeFooterView;
	[NullAllowed, Export ("treeFooterView", ArgumentSemantic.Strong)]
	UIView TreeFooterView { get; set; }

	// -(BOOL)isCellForItemExpanded:(id _Nonnull)item;
	[Export ("isCellForItemExpanded:")]
	bool IsCellForItemExpanded (NSObject item);

	// -(BOOL)isCellExpanded:(UITableViewCell * _Nonnull)cell;
	[Export ("isCellExpanded:")]
	bool IsCellExpanded (UITableViewCell cell);

	// -(NSInteger)levelForCellForItem:(id _Nonnull)item;
	[Export ("levelForCellForItem:")]
	nint LevelForCellForItem (NSObject item);

	// -(NSInteger)levelForCell:(UITableViewCell * _Nonnull)cell;
	[Export ("levelForCell:")]
	nint LevelForCell (UITableViewCell cell);

	// -(id _Nullable)parentForItem:(id _Nonnull)parent;
	[Export ("parentForItem:")]
	[return: NullAllowed]
	NSObject ParentForItem (NSObject parent);

	// -(UITableViewCell * _Nullable)cellForItem:(id _Nonnull)item;
	[Export ("cellForItem:")]
	[return: NullAllowed]
	UITableViewCell CellForItem (NSObject item);

	// -(NSArray * _Nullable)visibleCells;
	[NullAllowed, Export ("visibleCells")]
	[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
	NSObject[] VisibleCells { get; }

	// -(id _Nullable)itemForCell:(UITableViewCell * _Nonnull)cell;
	[Export ("itemForCell:")]
	[return: NullAllowed]
	NSObject ItemForCell (UITableViewCell cell);

	// -(id _Nullable)itemForRowAtPoint:(CGPoint)point;
	[Export ("itemForRowAtPoint:")]
	[return: NullAllowed]
	NSObject ItemForRowAtPoint (CGPoint point);

	// -(id _Nullable)itemsForRowsInRect:(CGRect)rect;
	[Export ("itemsForRowsInRect:")]
	[return: NullAllowed]
	NSObject ItemsForRowsInRect (CGRect rect);

	// @property (readonly, copy, nonatomic) NSArray * _Nullable itemsForVisibleRows;
	[NullAllowed, Export ("itemsForVisibleRows", ArgumentSemantic.Copy)]
	[Verify (StronglyTypedNSArray)]
	NSObject[] ItemsForVisibleRows { get; }

	// -(void)scrollToRowForItem:(id _Nonnull)item atScrollPosition:(RATreeViewScrollPosition)scrollPosition animated:(BOOL)animated;
	[Export ("scrollToRowForItem:atScrollPosition:animated:")]
	void ScrollToRowForItem (NSObject item, RATreeViewScrollPosition scrollPosition, bool animated);

	// -(void)scrollToNearestSelectedRowAtScrollPosition:(RATreeViewScrollPosition)scrollPosition animated:(BOOL)animated;
	[Export ("scrollToNearestSelectedRowAtScrollPosition:animated:")]
	void ScrollToNearestSelectedRowAtScrollPosition (RATreeViewScrollPosition scrollPosition, bool animated);

	// -(id _Nullable)itemForSelectedRow;
	[NullAllowed, Export ("itemForSelectedRow")]
	[Verify (MethodToProperty)]
	NSObject ItemForSelectedRow { get; }

	// -(NSArray * _Nullable)itemsForSelectedRows;
	[NullAllowed, Export ("itemsForSelectedRows")]
	[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
	NSObject[] ItemsForSelectedRows { get; }

	// -(void)selectRowForItem:(id _Nullable)item animated:(BOOL)animated scrollPosition:(RATreeViewScrollPosition)scrollPosition;
	[Export ("selectRowForItem:animated:scrollPosition:")]
	void SelectRowForItem ([NullAllowed] NSObject item, bool animated, RATreeViewScrollPosition scrollPosition);

	// -(void)deselectRowForItem:(id _Nonnull)item animated:(BOOL)animated;
	[Export ("deselectRowForItem:animated:")]
	void DeselectRowForItem (NSObject item, bool animated);

	// @property (nonatomic) BOOL allowsSelection;
	[Export ("allowsSelection")]
	bool AllowsSelection { get; set; }

	// @property (nonatomic) BOOL allowsMultipleSelection;
	[Export ("allowsMultipleSelection")]
	bool AllowsMultipleSelection { get; set; }

	// @property (nonatomic) BOOL allowsSelectionDuringEditing;
	[Export ("allowsSelectionDuringEditing")]
	bool AllowsSelectionDuringEditing { get; set; }

	// @property (nonatomic) BOOL allowsMultipleSelectionDuringEditing;
	[Export ("allowsMultipleSelectionDuringEditing")]
	bool AllowsMultipleSelectionDuringEditing { get; set; }

	// -(void)setEditing:(BOOL)editing animated:(BOOL)animated;
	[Export ("setEditing:animated:")]
	void SetEditing (bool editing, bool animated);

	// @property (getter = isEditing, nonatomic) BOOL editing;
	[Export ("editing")]
	bool Editing { [Bind ("isEditing")] get; set; }

	// -(void)reloadData;
	[Export ("reloadData")]
	void ReloadData ();

	// -(void)reloadRowsForItems:(NSArray * _Nonnull)items withRowAnimation:(RATreeViewRowAnimation)animation;
	[Export ("reloadRowsForItems:withRowAnimation:")]
	[Verify (StronglyTypedNSArray)]
	void ReloadRowsForItems (NSObject[] items, RATreeViewRowAnimation animation);

	// -(void)reloadRows;
	[Export ("reloadRows")]
	void ReloadRows ();

	// @property (readonly, nonatomic, strong) UIScrollView * _Nonnull scrollView;
	[Export ("scrollView", ArgumentSemantic.Strong)]
	UIScrollView ScrollView { get; }
}
