using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.View.PanelSystem;
using Game.Const;
using Game.Script;
public class GameMgr : MonoBehaviour
{
    private void Awake()
    {
        Game.Global.GlobalVar.InitGlovalVar();
        this.gameObject.AddComponent<MainLoop>();
        

        AbstractPanel.RegisterPanel<WelcomePanel>(UIName.WelComePanel);
        AbstractPanel.RegisterPanel<WordPanel>(UIName.WordPanel);
        AbstractPanel.RegisterPanel<AlarmClockPanel>(UIName.AlarmClock);
        AbstractPanel.RegisterPanel<BreakfastPanel>(UIName.BreakfastPanel);
    }

    private void Start()
    {
        UIManager.Instance.PushPanel(UIName.WelComePanel);
    }
}
