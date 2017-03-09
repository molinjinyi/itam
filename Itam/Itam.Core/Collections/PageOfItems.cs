using System;
using System.Collections.Generic;
using System.Text;

namespace Itam.Core.Collections
{
    public class PageOfItems<T> : List<T>, IPageOfItems<T>
    {
        public PageOfItems(IEnumerable<T> items)
        {
            AddRange(items);
        }
        public int PageNumber
        {
            get;

            set;
        }

        public int PageSize
        {
            get;

            set;
        }

        public int TotalItemCount
        {
            get;

            set;
        }
    }
}
