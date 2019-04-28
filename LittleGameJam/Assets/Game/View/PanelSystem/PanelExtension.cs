using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.View.PanelSystem
{
    public static class PanelExtension
    {
        public static bool CanNext(this AbstractPanel ap)
        {
            return Input.GetAxis("Mouse ScrollWheel")<0;
        }
    }
}
