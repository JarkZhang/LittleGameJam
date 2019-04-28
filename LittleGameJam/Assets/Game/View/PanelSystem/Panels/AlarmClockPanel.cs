using Game.Const;
using Game.Script;
namespace Game.View.PanelSystem
{
    public class AlarmClockPanel : AbstractPanel
    {
        private bool clicked=false;
        protected override void Load()
        {
            Create(UIPath.PanelDir+UIName.AlarmClock);
            var alarmBtn=m_TransFrom.Find("Image_AlarmClock");
            var inputer=alarmBtn.gameObject.AddComponent<UIInputer>();
            inputer.eventOnPointerClick+=(data)=>clicked=true;
        }

        protected override void Update()
        {
            if(clicked&&this.CanNext())
            {
                UIManager.Instance.PushPanel(UIName.BreakfastPanel);
            }
        }
    }
}