using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Ballsimulation.Model
{
    class Ball
    {
        // bollens egenskaper
        // ska studsa med 0,1 -0,0
        // en simulering
        // skapa bollens egenskaper 
        // vector Ball cordination = going x and y axel//


        public float Ballsize = 0.05f;
        private Vector2 BallCordination = new Vector2(0.5f,0.2f);
        private Vector2 Ballspeed = new Vector2(0.4f,0.4f);
       


        public Vector2 GetBallSpeed
        {
            get
            {
                return Ballspeed;
            }
        }

        public Vector2 BallPosition
        { 
            get
            {
                return BallCordination;
            }
        }

        public void movingtheball(float time)
        {
            BallCordination += Ballspeed * time;
        }

        public void SpeedXturn()
        {
            Ballspeed.X = -Ballspeed.X;
        }
        public void SpeedYturn()
        {
            Ballspeed.Y = -Ballspeed.Y;
        }
    }
}
