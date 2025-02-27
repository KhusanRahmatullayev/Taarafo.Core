﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System;
using System.Linq;
using System.Threading.Tasks;
using Taarafo.Core.Models.PostReports;

namespace Taarafo.Core.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<PostReport> InsertPostReportAsync(PostReport postReport);
        IQueryable<PostReport> SelectAllPostReports();
        ValueTask<PostReport> SelectPostReportByIdAsync(Guid Id);
        ValueTask<PostReport> UpdatePostReportAsync(PostReport postReport);
        ValueTask<PostReport> DeletePostReportAsync(PostReport postReport);
    }
}
