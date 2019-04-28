using Game.Const;
using UnityEngine;

namespace Game.View.PanelSystem
{
    public class WordPanel : AbstractPanel
    {
        protected override void Load()
        {
            Create(UIPath.PanelDir+UIName.WordPanel);
        }

        protected override void Update()
        {            

            if(this.CanNext())
            {
                UIManager.Instance.PushPanel(UIName.AlarmClock);
            }
        }
    }
}