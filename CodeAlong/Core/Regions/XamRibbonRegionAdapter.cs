using System;
using System.Collections.Specialized;
using Infragistics.Windows.Ribbon;
using Prism.Regions;

namespace CodeAlong.Core.Regions
{
    public class XamRibbonRegionAdapter : RegionAdapterBase<XamRibbon>
    {
        public XamRibbonRegionAdapter(IRegionBehaviorFactory factory)
            : base(factory)
        {

        }

        protected override void Adapt(IRegion region, XamRibbon regionTarget)
        {
            if (region == null) throw new ArgumentNullException(nameof(region));
            if (regionTarget == null) throw new ArgumentNullException(nameof(regionTarget));

            region.Views.CollectionChanged += (s, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    foreach (var view in e.NewItems)
                    {
                        AddViewToRegion(view, regionTarget);
                    }
                }
                else if (e.Action == NotifyCollectionChangedAction.Remove)
                {
                    foreach (var view in e.OldItems)
                    {

                    }
                }
            };
        }

        private void AddViewToRegion(object view, XamRibbon regionTarget)
        {
            if (view is RibbonTabItem ribbonTabItem)
            {
                regionTarget.Tabs.Add(ribbonTabItem);
            }

        }

        private void RemoveViewFromRegion(object view, XamRibbon regionTarget)
        {
            if (view is RibbonTabItem ribbonTabItem)
            {
                regionTarget.Tabs.Remove(ribbonTabItem);
            }
        }


        protected override IRegion CreateRegion()
        {
            return new SingleActiveRegion();
        }
    }
}