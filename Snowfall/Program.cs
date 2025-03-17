using Snowfall.BL;
using Snowfall.BL.Contract;
using System;

namespace Snowfall
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ISnowManager snowManager = new SnowManager();
            using (SnowFall snowFall = new SnowFall(snowManager))
            {
                snowFall.Run();
            }
        }
    }
}
