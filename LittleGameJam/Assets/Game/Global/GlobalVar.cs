using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game.Global
{
    public static class GlobalVar
    {
        public static GameObject G_Canvas;
        
        public static void InitGlovalVar()
        {
            G_Canvas = GameObject.Find("Canvas");
        }
    }
}
