using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Demo
{
	public partial class TreeTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString("TreeTableViewCell");
		public static readonly UINib Nib;

		public bool AdditionalButtonHidden
		{
			get
			{
				return AdditionalButton.Hidden;
			}
			set
			{
				AdditionalButton.Hidden = value;
			}
		}

		static TreeTableViewCell()
		{
			Nib = UINib.FromName("TreeTableViewCell", NSBundle.MainBundle);
		}

		protected TreeTableViewCell(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void AwakeFromNib()
		{
			SelectedBackgroundView = new UIView();
			SelectedBackgroundView.BackgroundColor = UIColor.Clear;
		}

		public override void PrepareForReuse()
		{
			base.PrepareForReuse();
			this.AdditionalButtonHidden = false;
		}

		public Action<TreeTableViewCell> AdditionButtonActionBlock;

		public void Setup(string title, string detailsText, nint level, bool additionalButtonHidden)
		{
			CustomTitleLabel.Text = title;
			DetailsLabel.Text = detailsText;
			this.AdditionalButtonHidden = additionalButtonHidden;

			UIColor backgroundColor;
			if (level == 0)
			{
				backgroundColor = new UIColor(247f / 255, 247f / 255, 247f / 255, 1f);
			}
			else if (level == 1)
			{
				backgroundColor = new UIColor(209f / 255, 238f / 255, 252f / 255, 1f);
			}
			else
			{
				backgroundColor = new UIColor(224f / 255, 248f / 255, 216f / 255, 1f);
			}

			this.BackgroundColor = backgroundColor;
			this.ContentView.BackgroundColor = backgroundColor;

			var left = 11f + 20f * level;
			CGRect frame;
			frame = this.CustomTitleLabel.Frame;
			frame.X = left;
			this.CustomTitleLabel.Frame = frame;

			frame = this.DetailsLabel.Frame;
			frame.X = left;
			this.DetailsLabel.Frame = frame;
		}

		partial void AdditionButtonTapped(Foundation.NSObject sender)
		{
			if (AdditionButtonActionBlock != null)
			{
				AdditionButtonActionBlock(this);
			}
		}
	}
}
