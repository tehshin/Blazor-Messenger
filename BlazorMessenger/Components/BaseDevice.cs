using BlazorMessenger.Models;
using BlazorMessenger.Services;
using Microsoft.AspNetCore.Blazor.Components;
using System;

namespace BlazorMessenger.Components
{
    public class BaseDevice : BlazorComponent
    {
        protected User CurrentUser { get; set; }

        protected bool IsLoggedIn
        {
            get
            {
                return CurrentUser != null;
            }
        }

        protected void SetUser(User user)
        {
            CurrentUser = user;
            StateHasChanged();
        }
    }
}
