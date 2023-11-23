﻿namespace Core.Common;

public class Pagination
{
    public Pagination(int pageSize, int pageNumber, int totalCount)
    {
        this.PageSize = pageSize;
        this.PageNumber = pageNumber;
        this.TotalCount = totalCount;
        this.TotalPages = (int) Math.Ceiling(totalCount / (double)pageSize);
    }

    public int PageSize { get; }

    public int PageNumber { get; }

    public int TotalCount { get; }

    public int TotalPages { get; }
}