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
        private int borderSize = 10;
        private float scaleX;
        private float scaleY;
        private float virtualWidth = 1;
        private float virtualHeight = 1;
        public float scale = 1;

        public Camera(int width, int height, float virtualWidth = 1, float virtualHeight = 1)
        {
            this.virtualHeight = virtualHeight;
            this.virtualWidth = virtualWidth;

            scaleX = (float)(width - borderSize * 2) / virtualWidth ;
            scaleY = (float)(height - borderSize * 2) / virtualHeight;
        }

        public Vector2 VisualCordination(float x, float y)
        {
            //Logisk koordinat |Visuell koordinat | by adding the alogritm under
            //0,0              | 64, 64
            //7,0              | 512, 64
            //1,7              | 128, 512
            //7,7              | 512, 512

            int visualX = (int)(borderSize + x * scaleX);
            int visualY = (int)(borderSize + y * scaleY);

            return new Vector2(visualX, visualY);
        }

        public Vector2 RotationCordination(int x, int y)
        {

            //Logisk koordinat |Visuell koordinat    | by adding the alogritm under
            //0,0              |  512,512
            //6,0              |  128,512
            //2,7              |  384, 64
            //7,7              |  64,64
            float visualX = (sizeOfTile * 8 + borderSize - sizeOfTile) - (x * sizeOfTile);   // rotation alogaritm of 8 tiles
            float visualY = (sizeOfTile * 8 + borderSize - sizeOfTile) - (y * sizeOfTile);

            return new Vector2(visualX, visualY);

        }
        public Vector2 ScaleObject( int width, int height)
        {
            return new Vector2( scaleX / width, scaleY / height);
        }
      
    }
    }
