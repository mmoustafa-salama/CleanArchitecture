﻿using System.Collections.Generic;

namespace BlazorWasmApp.Utils
{
    public class PaginatedList<T>
        where T : class
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int TotalPages { get; set; }

        public long TotalItems { get; set; }

        public List<T> Items { get; set; } = new List<T>();
    }
}
