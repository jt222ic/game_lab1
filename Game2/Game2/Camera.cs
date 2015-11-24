using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Game2
{
    class Camera
    {
       private int sizeOfTile = 64;
        private int borderSize = 64;
        private int visualX;
        private int visualY;
        private float scaleX;
        private float scaleY;
        public float scale = 1;


        public Vector2 VisualCordination(int x, int y)
        {
            //Logisk koordinat |Visuell koordinat | by adding the alogritm under
            //0,0              | 64, 64
            //7,0              | 512, 64
            //1,7              | 128, 512
            //7,7              | 512, 512

            visualX = borderSize + x * sizeOfTile;
            visualY = borderSize + y * sizeOfTile;

            return new Vector2(visualX, visualY);
        }

        public Vector2 RotationCordination(int x, int y)
        {

            //Logisk koordinat |Visuell koordinat    | by adding the alogritm under
            //0,0              |  512,512
            //6,0              |  128,512
            //2,7              |  384, 64
            //7,7              |  64,64
            visualX = (sizeOfTile * 8 + borderSize - sizeOfTile) - (x * sizeOfTile);   // rotation alogaritm of 8 tiles
            visualY = (sizeOfTile * 8 + borderSize - sizeOfTile) - (y * sizeOfTile);

            return new Vector2(visualX, visualY);

        }
        public void ScaleObject(Viewport port)
        {
            // viewport//
             scaleX = port.Width / (sizeOfTile * 8  + borderSize*2);
             scaleY = port.Height / (sizeOfTile * 8  + borderSize *2);

            if(scaleX<scaleY)
            {
                 scale = scaleX;
            }
            else if (scaleX>scaleY)
            {
                scale = scaleY;
            }
           
        }
        public float scaleOfPiece(float height, float width)
        {
            
            float scale = (sizeOfTile / height) + (sizeOfTile / width);
            scale = scale / 2;
            return scale;

            
        }


    }
    }
