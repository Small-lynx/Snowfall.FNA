using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Snowfall.BL.Contract;

namespace Snowfall
{
    public class SnowFall : Game
    {
        private readonly GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;        
        private ISnowManager snowManager;

        public SnowFall(ISnowManager snowManager)
        {
            this.snowManager = snowManager;
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.IsFullScreen = true;
            graphics.ApplyChanges();
        }
        
        /// <summary>
        /// Инициализация неграфических компонентов
        /// </summary>
        protected override void Initialize()
        {
            snowManager.Iniеialize(GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);
            base.Initialize();            
        }


        /// <summary>
        /// Загрузка контенка
        /// </summary>
        protected override void LoadContent()
        {            
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }


        /// <summary>
        /// Обновление логики кадров
        /// </summary>
        protected override void Update(GameTime gameTime)
        {
            snowManager.Fall();
            base.Update(gameTime);
        }


        /// <summary>
        /// Прорисовка кадров
        /// </summary>
        protected override void Draw(GameTime gameTime)
        {            
            GraphicsDevice.Clear(Color.MediumPurple);
             
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            spriteBatch.Draw(Content.Load<Texture2D>("forest"), new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), Color.White);
            snowManager.Draw(spriteBatch, Content.Load<Texture2D>("snow"));
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}

