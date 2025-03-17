namespace Snowfall.BL.Contract.Model
{
    /// <summary>
    /// Снежинка
    /// </summary>    
    public class Snowflake
    {
        // Координата X
        public int x;
        // Координата Y
        public int y;
        // Размер снежинки
        public int scale;
        // Скорость снежинки
        public double speed;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="scale">Размер снежинки</param>
        /// <param name="speed">Скорость снежинки</param>
        public Snowflake(int x, int y, int scale, double speed)
        {
            this.x = x;
            this.y = y;
            this.scale = scale;
            this.speed = speed;
        }
    }
}
