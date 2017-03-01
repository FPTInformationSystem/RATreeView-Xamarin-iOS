using System;
using System.Collections.Generic;
using UIKit;
using FPT.Framework.iOS.UI.RATreeView;
using Foundation;
using ObjCRuntime;

namespace Demo
{
	public partial class ViewController : UIViewController
	{

		#region PROPERTIES

		RATreeView TreeView { get; set;}
		List<DataObject> Data { get; set;}
		UIBarButtonItem EditButton { get; set;}


		#endregion

		#region CONSTRUCTORS

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.

		}

		#endregion

		#region FUNCTIONS

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			Data = DataObject.DefaultTreeRootChildren();

			View.BackgroundColor = UIColor.White;

			Title = "Things";
			SetupTreeView();
			UpdateNavigationBarButtons();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		private void SetupTreeView()
		{
			TreeView = new RATreeView(frame: View.Bounds, style: RATreeViewStyle.Plain);
			TreeView.RegisterNibForCell(TreeTableViewCell.Nib, TreeTableViewCell.Key);
			TreeView.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;
			TreeView.Delegate = new TreeViewDelegate();
			TreeView.DataSource = new TreeViewDataSource(Data);
			TreeView.TreeFooterView = new UIView();
			TreeView.BackgroundColor = UIColor.Clear;
			View.AddSubview(TreeView);
			TreeView.NumberOfRows();
		}

		private void UpdateNavigationBarButtons()
		{
			var systemItem = TreeView.Editing ? UIBarButtonSystemItem.Done : UIBarButtonSystemItem.Edit;
			this.EditButton = new UIBarButtonItem(systemItem, this, new Selector("EditButtonTapped:"));
			this.NavigationItem.RightBarButtonItem = this.EditButton;
		}

		[Export("EditButtonTapped:")]
		private void EditButtonTapped(UIButton sender)
		{
			TreeView.SetEditing(!TreeView.Editing, true);
			UpdateNavigationBarButtons();
		}

		private class TreeViewDelegate : RATreeViewDelegate
		{
			public override nfloat HeightForRowForItem(RATreeView treeView, NSObject item)
			{
				return 44;
			}

			public override void WillExpandRowForItem(RATreeView treeView, NSObject item)
			{
				var cell = treeView.CellForItem(item) as TreeTableViewCell;
				cell.AdditionalButtonHidden = false;
			}

			public override void WillCollapseRowForItem(RATreeView treeView, NSObject item)
			{
				var cell = treeView.CellForItem(item) as TreeTableViewCell;
				cell.AdditionalButtonHidden = true;
			}
		}

		private class TreeViewDataSource : RATreeViewDataSource
		{

			List<DataObject> Data { get; set;}

			public TreeViewDataSource(List<DataObject> data)
			{
				Data = data;
			}

			public override bool CanEditRow(RATreeView treeView, NSObject item)
			{
				return true;
			}



			public override UITableViewCell GetCell(RATreeView treeView, NSObject item)
			{
				var cell = treeView.DequeueReusableCellWithIdentifier(TreeTableViewCell.Key) as TreeTableViewCell;
				var i = item as DataObject;

				var level = treeView.LevelForCellForItem(i);
				var detailsText = string.Format("Number of children {0}", i.Children.Count);
				var expanded = treeView.IsCellForItemExpanded(i);
				cell.SelectionStyle = UITableViewCellSelectionStyle.None;
				cell.Setup(level + "-" + i.Name, detailsText, level, !expanded);
				cell.AdditionButtonActionBlock = (_) =>
				{
					var newItem = new DataObject(name: "Added value");
					i.AddChild(newItem);
					treeView.InsertItemsAtIndexes(new NSIndexSet((nuint)i.Children.Count - 1), i, RATreeViewRowAnimation.None);
					treeView.ReloadRowsForItems(new NSObject[] { i }, RATreeViewRowAnimation.None);
				};

				return cell;
			}

			public override NSObject GetChildItemAtIndexOfItem(RATreeView treeView, nint index, NSObject item)
			{
				var i = item as DataObject;
				if (i != null)
				{
					return i.Children[(int)index];
				}
				else
				{
					return Data[(int)index];
				}
			}

			public override nint NumberOfChildrenOfItem(RATreeView treeView, NSObject item)
			{

				var i = item as DataObject;
				if (i != null)
				{
					return i.Children.Count;
				}
				else
				{
					return Data.Count;
				}
			}

			public override void CommitEditingStyle(RATreeView treeView, UITableViewCellEditingStyle editingStyle, NSObject item)
			{
				//base.CommitEditingStyle(treeView, editingStyle, item);
				if (editingStyle != UITableViewCellEditingStyle.Delete) return;
				var i = item as DataObject;
				var parent = treeView.ParentForItem(i) as DataObject;

				int index;
				if (parent != null)
				{
					index = parent.Children.FindIndex((dataObject) =>
					{
						return dataObject == i;
					});
					parent.RemoveChild(i);
				}
				else
				{
					index = this.Data.FindIndex((dataObject) =>
					{
						return dataObject == i;
					});
					this.Data.RemoveAt(index);
				}

				treeView.DeleteItemsAtIndexes(new NSIndexSet((uint)index), parent, RATreeViewRowAnimation.Right);
				treeView.ReloadRowsForItems(new NSObject[] { parent }, RATreeViewRowAnimation.None);
			}
		}

		#endregion
	}
}
