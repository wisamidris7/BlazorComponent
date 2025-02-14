﻿using System.Text.Json.Serialization;

namespace BlazorComponent.JSInterop;

public class ScrollIntoViewOptions
{
    [JsonConverter(typeof(LowerCaseEnumConverter))]
    public ScrollLogicalPosition? Block { get; }

    [JsonConverter(typeof(LowerCaseEnumConverter))]
    public ScrollLogicalPosition? Inline { get; }

    [JsonConverter(typeof(LowerCaseEnumConverter))]
    public ScrollBehavior? Behavior { get; }

    public ScrollIntoViewOptions(ScrollLogicalPosition block)
    {
        Block = block;
    }

    public ScrollIntoViewOptions(ScrollLogicalPosition block, ScrollBehavior behavior = ScrollBehavior.Smooth) : this(block)
    {
        Behavior = behavior;
    }

    public ScrollIntoViewOptions(ScrollLogicalPosition? block, ScrollLogicalPosition? inline, ScrollBehavior behavior = ScrollBehavior.Smooth)
    {
        Block = block;
        Inline = inline;
        Behavior = behavior;
    }
}