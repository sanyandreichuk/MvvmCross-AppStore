﻿using System;
using UIKit;
using MvvmCross.Binding.iOS.Views;


namespace AppStore.iOS.Cells
{
    public class ScreenshotImageCell : MvxCollectionViewCell
    {
        public static readonly string Id = "ScreenshotImageCellId";

        private UIImageView imageView;
        public UIImageView ImageView
        {
            get
            {
                if (imageView == null) {
                    imageView = new UIImageView {
                        ContentMode = UIViewContentMode.ScaleAspectFill,
                        TranslatesAutoresizingMaskIntoConstraints = false,
                        BackgroundColor = UIColor.Gray
                    };
                }

                return imageView;
            }
        }

        public ScreenshotImageCell(IntPtr handle) : base(handle)
        {
            SetupViews();
        }

        private void SetupViews()
        {
            AddSubview(ImageView);

            AddConstraints(NSLayoutConstraint.FromVisualFormat("H:|[v0]|", 0, "v0", ImageView));
            AddConstraints(NSLayoutConstraint.FromVisualFormat("V:|[v0]|", 0, "v0", ImageView));
        }
    }
}