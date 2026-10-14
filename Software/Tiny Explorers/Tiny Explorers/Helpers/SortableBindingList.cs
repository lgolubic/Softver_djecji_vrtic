using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Tiny_Explorers.Helpers
{
    public class SortableBindingList<T> : BindingList<T>
    {
        private bool isSortedValue;
        private ListSortDirection sortDirectionValue;
        private PropertyDescriptor sortPropertyValue;

       
        public SortableBindingList() : base() { }

        public SortableBindingList(IList<T> list) : base(list) { }

        protected override bool SupportsSortingCore => true;
        protected override bool IsSortedCore => isSortedValue;

        protected override PropertyDescriptor SortPropertyCore => sortPropertyValue;
        protected override ListSortDirection SortDirectionCore => sortDirectionValue;

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            var itemsList = (List<T>)Items;

            var propInfo = typeof(T).GetProperty(prop.Name);
            if (propInfo == null)
            {
                isSortedValue = false;
                return;
            }

            itemsList.Sort((x, y) =>
            {
                var xValue = propInfo.GetValue(x, null);
                var yValue = propInfo.GetValue(y, null);

                int result;

                if (xValue == null)
                {
                    result = (yValue == null) ? 0 : -1;
                }
                else if (yValue == null)
                {
                    result = 1;
                }
                else if (xValue is IComparable comparableX)
                {
                    result = comparableX.CompareTo(yValue);
                }
                else
                {
                    result = string.Compare(xValue.ToString(), yValue.ToString(), StringComparison.Ordinal);
                }

                return direction == ListSortDirection.Ascending ? result : -result;
            });

            sortPropertyValue = prop;
            sortDirectionValue = direction;
            isSortedValue = true;

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override void RemoveSortCore()
        {
            isSortedValue = false;
        }
    }
}

