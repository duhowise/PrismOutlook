﻿using System.Collections.Specialized;
using Infragistics.Windows.OutlookBar;
using Prism.Regions;

namespace CodeAlong.Core.Regions
{
    public class OutlookGroupRegionAdapter : RegionAdapterBase<XamOutlookBar>
    {
        public OutlookGroupRegionAdapter(IRegionBehaviorFactory factory)
            : base(factory)
        {

        }

        protected override void Adapt(IRegion region, XamOutlookBar regionTarget)
        {
            region.Views.CollectionChanged += (x, y) =>
            {
                switch (y.Action)
                {
                    case NotifyCollectionChangedAction.Add:
                        {
                            foreach (Infragistics.Windows.OutlookBar.OutlookBarGroup group in y.NewItems)
                            {
                                regionTarget.Groups.Add(group);
                                if (regionTarget.Groups[0] == group)
                                {
                                    regionTarget.SelectedGroup = group;
                                }
                            }

                            break;
                        }
                    case NotifyCollectionChangedAction.Remove:
                        {
                            foreach (Infragistics.Windows.OutlookBar.OutlookBarGroup group in y.OldItems)
                            {
                                regionTarget.Groups.Remove(group);
                            }

                            break;
                        }
                }
            };
        }



        protected override IRegion CreateRegion()
        {
            return new SingleActiveRegion();
        }
    }
}


