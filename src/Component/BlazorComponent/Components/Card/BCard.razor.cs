﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Threading.Tasks;

namespace BlazorComponent
{
    public abstract partial class BCard : BDomComponentBase
    {
        [Parameter]
        public StringNumber Height { get; set; }

        [Parameter]
        public StringNumber MaxHeight { get; set; }

        [Parameter]
        public StringNumber MinHeight { get; set; }

        [Parameter]
        public StringNumber Width { get; set; }

        [Parameter]
        public StringNumber MaxWidth { get; set; }

        [Parameter]
        public StringNumber MinWidth { get; set; }

        [Parameter]
        public bool Outlined { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Obsolete("Use OnClick instead.")]
        [Parameter]
        public EventCallback<MouseEventArgs> Click { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnClick { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnContextmenu { get; set; }

        protected virtual async Task HandleOnContextmenu(MouseEventArgs args)
        {
            if (OnContextmenu.HasDelegate)
            {
                await OnContextmenu.InvokeAsync(args);
            }
        }

        protected override void OnParametersSet()
        {
            if (Click.HasDelegate)
            {
                OnClick = Click;
            }
        }
    }
}