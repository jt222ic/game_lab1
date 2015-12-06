using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ballsimulation.Model
{
    class BallSimulation
    {
        Ball ballinstance;
        
        
        
        public BallSimulation()
        {
            
                ballinstance = new Ball();
            
        }   
        public Vector2 position()
        {
            return ballinstance.BallPosition;
        }

        public Ball GetBalls()
        {

            return ballinstance;
        }

        public void MakeTheballMove(float time)
        {
            Ballbounching();
            ballinstance.movingtheball(time);
            

        }

        public void Ballbounching()
        {


            if(ballinstance.BallPosition.X <= 0 + ballinstance.Ballsize|| ballinstance.BallPosition.X >= 1 - ballinstance.Ballsize)
            {
                ballinstance.SpeedXturn();  // do somethign about rotating the speed back
            }
            else if(ballinstance.BallPosition.Y<= 0 + ballinstance.Ballsize|| ballinstance.BallPosition.Y >=1 - ballinstance.Ballsize)
            {
                ballinstance.SpeedYturn(); // do something about rotating Y axel back
            }
        }
       
    }
}
