﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Data;

public partial class Tweet
{
    public int Id { get; set; }

    public string TweetId { get; set; }

    public string Text { get; set; }

    public DateTimeOffset CreatedAt { get; set; }

    public DateTime? EventProcessedUtcTime { get; set; }

    public long? PartitionId { get; set; }

    public DateTime? EventEnqueuedUtcTime { get; set; }
}