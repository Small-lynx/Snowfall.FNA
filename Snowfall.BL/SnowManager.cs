using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Snowfall.BL.Contract;
using Snowfall.BL.Contract.Model;
using System;
using System.Collections.Generic;
using Color = Microsoft.Xna.Framework.Color;
using Rectangle = Microsoft.Xna.Framework.Rectangle;

namespace Snowfall.BL
{
    /// <inheritdoc cref="ISnowManager"/>
    public class SnowManager : Game, ISnowManager
    {
        // Базовая скорость для минимального размера
        private const double BASE_SPEED = 5;
        // Коллекция снежинок
        private readonly List<Snowflake> snowflakes;
        // Размеры экрана
        private int width, height;

        public SnowManager()
        {
            snowflakes = new List<Snowflake>(); 
        }

        public void Iniеialize(int Width, int Height)
        {
            this.width = Width;
            this.height = Height;
            var rnd = new Random();
            for (int i = 0; i < 1001; i++)
            {
                snowflakes.Add(new Snowflake(rnd.Next(0, Width), rnd.Next(0, Height), rnd.Next(1, 50) / 10, BASE_SPEED / rnd.Next(1, 6)));
            }
        }

        void ISnowManager.Draw(SpriteBatch spriteBatch, Texture2D image)
        {
            foreach (var item in snowflakes)
            {
                if (image != null)
                {
                    Color color;
                    if (item.scale >= 4)
                    {
                        color = Color.DarkSlateBlue;
                    }
                    else if (item.scale >= 2)
                    {
                        color = Color.Azure;
                    }
                    else
                    {
                        color = Color.White;
                    }
                    spriteBatch.Draw(image, new Rectangle(item.x, item.y, item.scale * 10, item.scale * 10), color);
                }
            }
        }

        void ISnowManager.Fall()
        {
            foreach (var item in snowflakes)
            {
                item.y += (int)item.speed;
                if (item.y >= height || item.x >= width)
                {
                    item.y = 0 - item.scale * 10;
                    item.x = new Random().Next(0, width);
                }
            }
        }
    }
}
