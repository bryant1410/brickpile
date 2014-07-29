﻿namespace BrickPile.Core.Extensions
{
    public static class PageExtensions
    {
        /// <summary>
        /// Determines whether the specified page is draft.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public static bool IsDraft(this IPage page)
        {
            return page.Id.Contains("draft");
        }
    }
}
