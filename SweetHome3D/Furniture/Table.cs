﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;
using Tao.DevIl;
using System.Drawing;

namespace SweetHome3D.Furniture
{
    [Serializable]
    public class Table : FurnitureObject
    {
        public Table()
        {
            Height = 45;
            Width = 200;
            Depth = 60;
            Name = "Стол";
            TypeName = "Table";
            AddressOfTheImageTexture=@"Table\1.jpg";
        }
        public override void Draw()
        {
            Width /= 2;
            Depth /= 2;
             Gl.glEnable(Gl.GL_TEXTURE_2D);
             Gl.glDisable(Gl.GL_TEXTURE_GEN_S);
             Gl.glDisable(Gl.GL_TEXTURE_GEN_T);
             Gl.glBindTexture(Gl.GL_TEXTURE_2D, Texture);
             Gl.glColor3d(0.7,0.7,0.7);
             Gl.glPushMatrix();
             if (Angle == 0 || Angle == 180)
                 Gl.glTranslated(Location.X - Width, 0, Location.Y - Depth );
             else
                 Gl.glTranslated(Location.X - Depth, 0, Location.Y - Width);
             Gl.glRotated(Angle, 0, 1, 0);
             Gl.glBegin(Gl.GL_QUADS);
                 Gl.glTexCoord2d(0,0); Gl.glVertex3d( Width, Height, Depth);
                 Gl.glTexCoord2d(0,1); Gl.glVertex3d( Width, Height, Depth-4);
                 Gl.glTexCoord2d(1,1); Gl.glVertex3d( Width-4, Height,Depth-4);
                 Gl.glTexCoord2d(1,0); Gl.glVertex3d( Width-4, Height, Depth);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
                 Gl.glTexCoord2d(0,0); Gl.glVertex3d(  Width-4, Height, Depth);
                 Gl.glTexCoord2d(0,1); Gl.glVertex3d(  Width-4,  0, Depth);
                 Gl.glTexCoord2d(1,1); Gl.glVertex3d(  Width-4,  0, Depth-4);
                 Gl.glTexCoord2d(1,0); Gl.glVertex3d(  Width-4, Height, Depth-4);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
                 Gl.glTexCoord2d(0,0); Gl.glVertex3d( Width, Height, Depth);
                 Gl.glTexCoord2d(0,1); Gl.glVertex3d( Width,  0, Depth);
                 Gl.glTexCoord2d(1,1); Gl.glVertex3d( Width,  0, Depth-4);
                 Gl.glTexCoord2d(1,0); Gl.glVertex3d( Width,  Height, Depth-4);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
                 Gl.glTexCoord2d(0,0); Gl.glVertex3d( Width, Height, Depth);
                 Gl.glTexCoord2d(0,1); Gl.glVertex3d( Width,  0, Depth);
                 Gl.glTexCoord2d(1,1); Gl.glVertex3d( Width-4,  0, Depth);
                 Gl.glTexCoord2d(1, 0); Gl.glVertex3d(Width - 4, Height, Depth);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width, Height, Depth-4);
                 Gl.glTexCoord2d(0,1); Gl.glVertex3d( Width,  0, Depth-4);
                 Gl.glTexCoord2d(1,1); Gl.glVertex3d( Width-4,  0, Depth-4);
                 Gl.glTexCoord2d(1, 0); Gl.glVertex3d(Width - 4, Height, Depth-4);
              Gl.glEnd();

              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(-Width, Height, Depth);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(-Width, Height, Depth-4);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-Width + 4, Height, Depth-4);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 4, Height, Depth);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(-Width + 4, Height, Depth);
                 Gl.glTexCoord2d(0,1); Gl.glVertex3d( -Width+4,  0, Depth);
                 Gl.glTexCoord2d(1,1); Gl.glVertex3d( -Width+4,  0, Depth-4);
                 Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 4, Height, Depth-4);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(-Width, Height, Depth);
                 Gl.glTexCoord2d(0,1); Gl.glVertex3d(-Width,  0, Depth);
                 Gl.glTexCoord2d(1,1); Gl.glVertex3d(-Width,  0, Depth-4);
                 Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width, Height, Depth-4);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(-Width, Height, Depth);
                 Gl.glTexCoord2d(0,1); Gl.glVertex3d(-Width,  0, Depth);
                 Gl.glTexCoord2d(1,1); Gl.glVertex3d( -Width+4,  0, Depth);
                 Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 4, Height, Depth);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(-Width, Height, Depth-4);
                 Gl.glTexCoord2d(0,1); Gl.glVertex3d(-Width,  0, Depth-4);
                 Gl.glTexCoord2d(1,1); Gl.glVertex3d( -Width+4,  0, Depth-4);
                 Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 4, Height, Depth-4);
              Gl.glEnd();

              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width, Height, -Depth);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(Width, Height, -Depth+4);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(Width - 4, Height, -Depth+4);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(Width - 4, Height, -Depth);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width - 4, Height, -Depth);
                 Gl.glTexCoord2d(0,1); Gl.glVertex3d(  Width-4,  0,-Depth);
                 Gl.glTexCoord2d(1,1); Gl.glVertex3d(  Width-4,  0,-Depth+4);
                 Gl.glTexCoord2d(1, 0); Gl.glVertex3d(Width - 4, Height, -Depth+4);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width, Height, -Depth);
                 Gl.glTexCoord2d(0,1); Gl.glVertex3d( Width,  0,-Depth);
                 Gl.glTexCoord2d(1,1); Gl.glVertex3d( Width,  0,-Depth+4);
                 Gl.glTexCoord2d(1, 0); Gl.glVertex3d(Width, Height, -Depth+4);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width, Height, -Depth);
                 Gl.glTexCoord2d(0,1); Gl.glVertex3d( Width,  0,-Depth);
                 Gl.glTexCoord2d(1,1); Gl.glVertex3d( Width-4,  0,-Depth);
                 Gl.glTexCoord2d(1, 0); Gl.glVertex3d(Width - 4, Height, -Depth);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width - 4, Height, -Depth+4);
                 Gl.glTexCoord2d(0,1); Gl.glVertex3d( Width-4,  0,-Depth+4);
                 Gl.glTexCoord2d(1,1); Gl.glVertex3d( Width-4,  0,-Depth+4);
                 Gl.glTexCoord2d(1, 0); Gl.glVertex3d(Width - 4, Height, -Depth+4);
              Gl.glEnd();

              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(-Width, Height, -Depth);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(-Width, Height, -Depth+4);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-Width + 4, Height, -Depth+4);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 4, Height, -Depth);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(-Width + 4, Height, -Depth);
                 Gl.glTexCoord2d(0,1); Gl.glVertex3d( -Width+4,  0,-Depth);
                 Gl.glTexCoord2d(1,1); Gl.glVertex3d( -Width+4,  0,-Depth+4);
                 Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 4, Height, -Depth+4);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(-Width, Height, -Depth);
                 Gl.glTexCoord2d(0,1); Gl.glVertex3d(-Width,  0,-Depth);
                 Gl.glTexCoord2d(1,1); Gl.glVertex3d(-Width,  0,-Depth+4);
                 Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width, Height, -Depth+4);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(-Width, Height, -Depth);
                 Gl.glTexCoord2d(0,1); Gl.glVertex3d(-Width,  0,-Depth);
                 Gl.glTexCoord2d(1,1); Gl.glVertex3d( -Width+4,  0,-Depth);
                 Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 4, Height, -Depth);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(-Width, Height, -Depth+4);
                 Gl.glTexCoord2d(0,1); Gl.glVertex3d(-Width,  0,-Depth+4);
                 Gl.glTexCoord2d(1,1); Gl.glVertex3d( -Width+4,  0,-Depth+4);
                 Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 4, Height, -Depth+4);
              Gl.glEnd();

              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width - 4, Height, Depth-1);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(Width - 4, Height, Depth-3);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-Width + 4, Height, Depth-3);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 4, Height, Depth-1);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width - 4, Height-5, Depth-1);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(Width - 4, Height-5, Depth-3);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-Width + 4, Height-5,Depth-3);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 4, Height-5,Depth-1);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width - 4, Height, Depth-1);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(Width - 4, Height-5, Depth-1);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-Width + 4, Height-5, Depth-1);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 4, Height, Depth-1);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width - 4, Height, Depth-3);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(Width - 4, Height-5, Depth-3);
                 Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-Width + 4, Height-5, Depth-3);
                 Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 4, Height, Depth-3);
              Gl.glEnd();

              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width - 4, Height, -Depth+1);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(Width - 4, Height, -Depth+3);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-Width + 4, Height, -Depth+3);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 4, Height, -Depth+1);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width - 4, Height-5, -Depth+1);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(Width - 4, Height-5, -Depth+3);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-Width + 4, Height-5, -Depth+3);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 4, Height-5, -Depth+1);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width - 4, Height, -Depth+1);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(Width - 4, Height-5, -Depth+1);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-Width + 4, Height-5, -Depth+1);
                 Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 4, Height, -Depth+1);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width - 4, Height, -Depth+3);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(Width - 4, Height-5, -Depth+3);
                 Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-Width + 4, Height-5, -Depth+3);
                 Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 4, Height, -Depth+3);
              Gl.glEnd();

              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width - 1, Height, Depth-4);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(Width - 1, Height-5, Depth-4);
                 Gl.glTexCoord2d(1, 1); Gl.glVertex3d(Width - 1, Height-5, -Depth+4);
                 Gl.glTexCoord2d(1, 0); Gl.glVertex3d(Width - 1, Height, -Depth+4);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width - 3, Height, Depth-4);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(Width - 3, Height-5, Depth-4);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(Width - 3, Height-5, -Depth+4);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(Width - 3, Height, -Depth+4);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width - 1, Height, Depth-4);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(Width - 1, Height, -Depth+4);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(Width - 3, Height, -Depth+4);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(Width - 3, Height, Depth-4);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width - 1, Height-5, Depth-4);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(Width - 1, Height-5, -Depth+4);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(Width - 3, Height-5, -Depth+4);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(Width - 3, Height-5, Depth-4);
              Gl.glEnd();

              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(-Width + 1, Height, Depth-4);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(-Width + 1, Height-5, Depth-4);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-Width + 1, Height-5, -Depth+4);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 1, Height, -Depth+4);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(-Width + 3, Height, Depth-4);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(-Width + 3, Height-5, Depth-4);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-Width + 3, Height-5, -Depth+4);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 3, Height, -Depth+4);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(-Width + 1, Height, Depth-4);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(-Width + 1, Height, -Depth+4);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-Width + 3, Height, -Depth+4);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 3, Height, Depth-4);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(-Width + 1, Height-5, Depth-4);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(-Width + 1, Height-5, -Depth+4);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-Width + 3, Height-5, -Depth+4);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width + 3, Height-5, Depth-4);
              Gl.glEnd();
              Gl.glDisable(Gl.GL_TEXTURE_2D);

              Gl.glDisable(Gl.GL_DEPTH_TEST);
              Gl.glEnable(Gl.GL_ALPHA_TEST);
              Gl.glEnable(Gl.GL_BLEND);
              Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);
              Gl.glColor4d(1.0,1.0,1.0,0.35);
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width, Height, Depth);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(Width, Height, -Depth);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-Width, Height, -Depth);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width, Height, Depth);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width, Height+0.5, Depth);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(Width, Height + 0.5, -Depth);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-Width, Height + 0.5, -Depth);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width, Height + 0.5, Depth);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width, Height , Depth);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width, Height , Depth);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(Width, Height + 0.5, Depth);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(Width, Height + 0.5, -Depth);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(Width, Height , -Depth);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(-Width, Height , Depth);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(-Width, Height + 0.5, Depth);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-Width, Height + 0.5, -Depth);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width, Height , -Depth);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width, Height , Depth);
              Gl.glTexCoord2d(0, 1); Gl.glVertex3d(Width, Height + 0.5, Depth);
              Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-Width, Height + 0.5, Depth);
              Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width, Height , Depth);
              Gl.glEnd();
              Gl.glBegin(Gl.GL_QUADS);
              Gl.glTexCoord2d(0, 0); Gl.glVertex3d(Width, Height , -Depth);
                 Gl.glTexCoord2d(0, 1); Gl.glVertex3d(Width, Height + 0.5, -Depth);
                 Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-Width, Height + 0.5, -Depth);
                 Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-Width, Height, -Depth);
              Gl.glEnd();
              Gl.glPopMatrix();
              Gl.glDisable(Gl.GL_BLEND);
              Gl.glDisable(Gl.GL_ALPHA_TEST);
              Gl.glEnable(Gl.GL_DEPTH_TEST);

              
              Width *= 2;
              Depth *= 2;
        }

    }
}