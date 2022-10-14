// -----------------------------------------------------------------------
//  <copyright file="NodeInfo.cs" company="Petabridge, LLC">
//      Copyright (C) 2017-2022 Petabridge, LLC <https://petabridge.com>
//  </copyright>
// -----------------------------------------------------------------------

namespace Docker.Cluster.Splitter.Tool;

public sealed class NodeInfo
{
    public NodeInfo(string id, string name, string? address)
    {
        Id = id;
        Name = name;
        Address = address;
    }

    public string Id { get; }
    public string Name { get; }
    public string? Address { get; }

    public override string ToString()
        => $"[{Id}] {Name}:{Address}";
}