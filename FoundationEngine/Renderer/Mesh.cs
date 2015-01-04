﻿using System;
using System.Windows.Media.Media3D;

namespace FoundationEngine.Renderer
{
    /// <summary>
    /// This class represents a 3D mesh.
    /// </summary>
    class Mesh
    {
        public String Name { get; set; }
        public Vertex[] Vertices { get; private set; }
        public Face[] Faces { get; set; }
        public Vector3D Position { get; set; }
        public Vector3D Rotation { get; set; }

        public Mesh(String name, Int32 verticesCount, Int32 facesCount)
        {
            Vertices = new Vertex[verticesCount];
            Faces = new Face[facesCount];
            Name = name;
        }

        //public Mesh(String name, Vector3[] verts, Face[] faces)
        //{
        //    Vertices = verts;
        //    Faces = faces;
        //    Name = name;
        //}
    }
}
