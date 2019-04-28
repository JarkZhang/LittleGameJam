using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Game.Script;
using UnityEngine.EventSystems;
using Game.Const;

namespace Game.View.PanelSystem
{
    public class WelcomePanel : AbstractPanel
    {
        private Transform btn;

        protected override void Load()
        {
            Create(UIPath.PanelDir+UIName.WelComePanel);

            btn = m_TransFrom.Find("Image_Btn");

            var inputer = btn.gameObject.AddComponent<UIInputer>();

            inputer.eventOnPointerClick += OnClick;

            
        }

        protected override void Update()
        {
            if(this.CanNext())
            {
                UIManager.Instance.PushPanel(UIName.WordPanel);
            }
        }


        void OnClick(PointerEventData data)
        {
            UIManager.Instance.PushPanel(UIPath.PanelDir+UIName.WordPanel);
        }
    }
}
