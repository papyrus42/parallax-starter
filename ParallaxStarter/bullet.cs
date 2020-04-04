using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace ParallaxStarter
{
    public class bullet:ISprite
    {
        public StaticSprite sprite;


        public Boolean isShot;

        

        

        public float Speed { get; set; } = 200;

        public bullet(StaticSprite s)
        {
            sprite = s;
            isShot = false;
        }

        //public void Update(GameTime gameTime)
        //{
        //    //Vector2 direction = Vector2.Zero;

        //    //if (Keyboard.GetState().IsKeyDown(Keys.Space))
        //    //{
        //    //    isShot = true;
        //    //}

        //    //if (isShot)
        //    //{
        //    //    direction.X += 2;
        //    //    sprite.position += (float)gameTime.ElapsedGameTime.TotalSeconds * Speed * direction;
        //    //}
        //}

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            sprite.Draw(spriteBatch, gameTime);
        }
    }
}
