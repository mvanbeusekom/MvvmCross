using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using Playground.Core.ViewModels;
using Playground.iOS.ValueConverters;
using UIKit;

namespace Playground.iOS.Views
{
    [MvxFromStoryboard("Main")]
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class RootView : MvxViewController<RootViewModel>
    {
        public RootView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.LightGray;

            var set = this.CreateBindingSet<RootView, RootViewModel>();

            set.Bind(btnTabs).To(vm => vm.ShowTabsCommand);
            set.Bind(btnSplit).To(vm => vm.ShowSplitCommand);
            set.Bind(btnChild).To(vm => vm.ShowChildCommand);
            set.Bind(btnModal).To(vm => vm.ShowModalCommand);
            set.Bind(btnNavModal).To(vm => vm.ShowModalNavCommand);
            set.Bind(btnOverrideAttribute).To(vm => vm.ShowOverrideAttributeCommand);
            set.Bind(lblRandomColor).For(lbl => lbl.TextColor).WithConversion<RandomColorValueConverter>();

            set.Apply();
        }
    }
}