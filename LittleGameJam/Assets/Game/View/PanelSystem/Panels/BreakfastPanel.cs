using Game.Const;
using Game.Script;
namespace Game.View.PanelSystem
{
    public class BreakfastPanel : AbstractPanel
    {
        private int eat=0;
        private int foodCount;
        protected override void Load()
        {
            Create(UIPath.PanelDir+UIName.BreakfastPanel);
            var foods=m_TransFrom.Find("Empty_Food");
            this.foodCount=foods.childCount;
            for(int i=0;i<this.foodCount;i++)
            {
                var food=foods.GetChild(i);
                var inputer=food.gameObject.AddComponent<UIInputer>();
                inputer.eventOnPointerClick+=(data)=>
                {
                    eat++;
                    food.gameObject.SetActive(false);
                };
            }
        }

        protected override void Update()
        {
            if(eat>=this.foodCount&&this.CanNext())
            {
                throw new System.Exception();
            }
        }

    }
}