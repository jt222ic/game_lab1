using Ballsimulation.Model;
using Ballsimulation.View;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Ballsimulation
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        BallView ballview;
        BallSimulation ballsimulation;
        Camera camera;
       

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            camera = new Camera();
           // graphics.PreferredBackBufferWidth = 660;
           // graphics.PreferredBackBufferHeight = 660;
            graphics.ApplyChanges();
            Content.RootDirectory = "Content";
                 
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            camera.ScaleEverything(graphics.GraphicsDevice.Viewport);
            ballsimulation = new BallSimulation();
            spriteBatch = new SpriteBatch(GraphicsDevice);
            ballview = new BallView(Content, ballsimulation, graphics);
            

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            ballsimulation.MakeTheballMove((float)gameTime.ElapsedGameTime.TotalSeconds);
            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            ballview.Draw(spriteBatch, camera);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
