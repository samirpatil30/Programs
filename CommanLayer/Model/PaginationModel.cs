using System;
using System.Collections.Generic;
using System.Text;

namespace CommanLayer.Model
{
   public class PaginationModel
    {
        const int maxPageSize = 1;
        public int pageNumber { get; set; } 
        public int _pageSize { get; set; } 
        public int pageSize
        {
            get { return _pageSize; }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : maxPageSize;
            }
        }
    }
}