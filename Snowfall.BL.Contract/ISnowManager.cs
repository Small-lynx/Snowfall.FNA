using Microsoft.Xna.Framework.Graphics;

namespace Snowfall.BL.Contract
{
    /// <summary>
    /// Менеджер управления снежинок
    /// </summary>
    public interface ISnowManager
    {
        /// <summary>
        /// Инициализация контейнера для снежинок
        /// </summary>
        /// <param name="Width">Высота экрана</param>
        /// <param name="Height">Ширина экрана</param>
        void Iniеialize(int Width, int Height);

        /// <summary>
        /// Прересивка снежинок
        /// </summary>
        /// <param name="spriteBatch">Пакет спрайтов</param>
        /// <param name="image">Рисунок снежинки</param>
        void Draw(SpriteBatch spriteBatch, Texture2D image);

        /// <summary>
        /// Логика падения снежинок
        /// </summary>
        void Fall();
    }
}