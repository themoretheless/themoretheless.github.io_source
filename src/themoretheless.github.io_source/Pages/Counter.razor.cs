using Microsoft.AspNetCore.Components;

namespace themoretheless.github.io_source.Pages
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;

        protected void IncrementCount()
        {
            currentCount++;
        }
    }
}