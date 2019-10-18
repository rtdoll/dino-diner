/* IMenuItem.cs
 * Author: Ryan Doll
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// 
    /// </summary>
    public interface IOrderItem
    {
        double Price { get; }

        string Description { get; }

        string[] Special { get; }
    }
}
