using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game2
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D Whitebox;
        Texture2D Blackbox;
        Texture2D chessPiece;
        Camera camera;
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
           graphics.PreferredBackBufferWidth = 320;    // windows width 
           graphics.PreferredBackBufferHeight = 240;   // windwos height
            camera = new Camera(graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight,8,8);  // 8 brickcs scaling to fit on screen if lower the other will get outside screen


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
            // camera.ScaleObject(graphics);
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Whitebox = Content.Load<Texture2D>("White");
            Blackbox = Content.Load<Texture2D>("Black");
            chessPiece = Content.Load<Texture2D>("Piece");
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

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            int a = 0;
            for (int x = 0; x < 8; x += 1)       // Looping for x and y axel
            {
                for (int y = 0; y < 8; y += 1)
                {
                    if (a % 2 == 0)
                    {
                        spriteBatch.Draw(Whitebox, camera.VisualCordination(x, y), null, Color.White, 0, new Vector2(0, 0), camera.ScaleObject(Whitebox.Width, Whitebox.Height), SpriteEffects.None, 0);
                       // spriteBatch.Draw(Whitebox, camera.RotationCordination(x, y), null, Color.White, 0, new Vector2(0, 0), camera.scale, SpriteEffects.None, 0);

                    }
                    else
                    {
                        spriteBatch.Draw(Blackbox, camera.VisualCordination(x, y), null, Color.White, 0, new Vector2(0, 0), camera.ScaleObject(Blackbox.Width, Blackbox.Height), SpriteEffects.None, 0);
                       // spriteBatch.Draw(Blackbox, camera.RotationCordination(x, y), null, Color.White, 0, new Vector2(0, 0), camera.scale, SpriteEffects.None, 0);
                    }
                    a++;
                }
                a++;
            }
            //float resize = camera.scaleOfPiece(chessPiece.Height, chessPiece.Width);
            spriteBatch.Draw(chessPiece, camera.VisualCordination(0,0), null, Color.White, 0, new Vector2(0, 0), camera.ScaleObject(chessPiece.Width, chessPiece.Height), SpriteEffects.None, 0);
            //spriteBatch.Draw(chessPiece, camera.RotationCordination(0, 0), null, Color.White, 0, new Vector2(0, 0), resize, SpriteEffects.None, 0);
            spriteBatch.End();
           
            base.Draw(gameTime);
        }
        
    }
}

//ROTATION//

//  spriteBatch.Draw(Whitebox, camera.RotationCordination(x, y), null, Color.White, 0, new Vector2(0, 0), camera.scale, SpriteEffects.None, 0);
//  spriteBatch.Draw(Blackbox, camera.RotationCordination(x, y), null, Color.White, 0, new Vector2(0, 0), camera.scale, SpriteEffects.None, 0);
//spriteBatch.Draw(chessPiece, camera.RotationCordination(0,0), null, Color.White, 0, new Vector2(0, 0), resize, SpriteEffects.None, 0);