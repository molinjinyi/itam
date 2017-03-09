using System;
using System.Collections.Generic;
using System.Text;

namespace Itam.Core.Collections
{
    public interface IPageOfItems<out T> : IEnumerable<T>
    {
        int PageNumber { get; set; }
        int PageSize { get; set; }
        int TotalItemCount { get; set; }
    }
}
