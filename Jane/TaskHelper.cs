using System;
using System.Threading.Tasks;

namespace Jane
{
    internal static class TaskHelper
    {
        public static async Task Delay(decimal milliseconds)
        {
            var delay = decimal.ToInt32(milliseconds);
            if (delay > 0)
            {
                await Task.Delay(TimeSpan.FromMilliseconds(delay));
            }
        }
    }
}
