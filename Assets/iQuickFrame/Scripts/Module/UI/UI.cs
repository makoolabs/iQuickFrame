using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using i.DS;
using i.Frame;
using i.Res;
namespace i.UI{
    public class UI:Singleton<UI>,IModule{
        private UI(){}
        public void Initialize(){
            // Res.Res.Instance.Load("Assets/iQuickFrame/Prefabs/UI/_Frame/UI.prefab",()=>{

            // });
        }
        public void Dispose(){
            
        }
    }
}
