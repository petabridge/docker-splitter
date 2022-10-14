﻿// -----------------------------------------------------------------------
//  <copyright file="Command.cs" company="Petabridge, LLC">
//      Copyright (C) 2017-2022 Petabridge, LLC <https://petabridge.com>
//  </copyright>
// -----------------------------------------------------------------------

using System.Collections.Immutable;

namespace Docker.Cluster.Splitter.Tool;

public sealed class Command
{
    public Command(IEnumerable<NodeInfo> targetNodes, IEnumerable<NodeInfo>? fromNodes = null)
    {
        TargetNodes = targetNodes.ToImmutableHashSet();
        FromNodes = fromNodes?.ToImmutableHashSet() ?? ImmutableHashSet<NodeInfo>.Empty;
    }

    public ImmutableHashSet<NodeInfo> TargetNodes { get; }
    public ImmutableHashSet<NodeInfo> FromNodes { get; }

    public override string ToString()
    {
        var from = string.Join(", ", FromNodes.Select(n => n.Name));
        from = string.IsNullOrEmpty(from) ? "ALL" : from;
        return $"SPLITTING [{string.Join(", ", TargetNodes.Select(n => n.Name))}] FROM [{from}]";
    }
}