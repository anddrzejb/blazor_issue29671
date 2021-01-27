using Microsoft.AspNetCore.Components;
using System;

namespace BlazorApp.Pages
{
    public class ForwardRef
    {
        private ElementReference _current;
        public ElementReference Current
        {
            get => _current;
            set
            {
                Set(value);
                //this is just for debugging purpose
                Console.WriteLine($"Ref: {value.Id ?? "null"}");
            }
        }
        public void Set(ElementReference value) => _current = value;
    }
}
