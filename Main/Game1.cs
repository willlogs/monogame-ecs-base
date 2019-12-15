using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Main
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        public static Scene.Scene curScene;
        public static Game1 instance;
        public static int pixelsPerUnit = 100;
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            instance = this;
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
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            MakeTestScene();
        }

        private void MakeTestScene()
        {
            Texture2D balltxt = Content.Load<Texture2D>("ball");
            curScene = new Scene.Scene();

            // =================================================
            // =================================================
            // ================Adding a ball====================
            // =================================================
            // =================================================
            Entity.Entity ent =
                curScene.AddEntity(
                    new Entity.Entity(
                        Vector2.Zero,
                        0.1f,
                        name: "ball1",
                        tag: 0
                    )
                );

            ent.AddComponent(
                new Component.Rendering.Sprite(
                    balltxt,
                    ent,
                    index: 0
                )
            );

            ent.AddComponent(
                new Component.Physics.RigidBodies.Rigidbody(
                    ent    
                )
            );

            ent.AddComponent(
                new Component.Physics.Colliders.CircleCollider(
                    ent,
                    35f,
                    Vector2.Zero
                )    
            );

            // =================================================
            // =================================================
            // ================Adding a ball====================
            // =================================================
            // =================================================
            Entity.Entity ent1 =
                curScene.AddEntity(
                    new Entity.Entity(
                        new Vector2(0, 400),
                        0.1f,
                        name: "ball2",
                        tag: 0
                    )
                );

            ent1.AddComponent(
                new Component.Rendering.Sprite(
                    balltxt,
                    ent1,
                    index: 0
                )
            );

            ent1.AddComponent(
                new Component.Physics.Colliders.CircleCollider(
                    ent1,
                    35f,
                    Vector2.Zero
                )
            );

            // =================================================
            // =================================================
            // ================Adding a ball====================
            // =================================================
            // =================================================
            Entity.Entity ent2 =
                curScene.AddEntity(
                    new Entity.Entity(
                        new Vector2(0, 250),
                        0.1f,
                        name: "ball2",
                        tag: 0
                    )
                );

            ent2.AddComponent(
                new Component.Rendering.Sprite(
                    balltxt,
                    ent2,
                    index: 0
                )
            );

            ent2.AddComponent(
                new Component.Physics.RigidBodies.Rigidbody(
                    ent2
                )
            );

            ent2.AddComponent(
                new Component.Physics.Colliders.CircleCollider(
                    ent2,
                    35f,
                    Vector2.Zero
                )
            );
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
            curScene.Update(gameTime);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            Rendering.Renderer.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
