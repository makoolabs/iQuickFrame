using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using i.DS;
using i.Frame;
using UnityEngine.AddressableAssets;
namespace i.Res{
    public class Res:Singleton<Res>,IModule{
        private Res(){}
        public void Initialize(){

        }
        public void Dispose(){
            
        }
        public void Load(){
            //Addressables.LoadAsset<GameObject>();
        }
    }
}