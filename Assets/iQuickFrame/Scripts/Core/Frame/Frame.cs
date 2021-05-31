using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using i.DS;
namespace i.Frame{
    public class Frame:Singleton<Frame>{
        private List<IModule> modules;
        private Frame(){}
        public void Initialize(IApp app){
            modules = app.RegisterModules()??new List<IModule>();
            foreach(var module in modules){
                module.Initialize();
            }
        }
        public void Dispose(){
            foreach(var module in modules){
                module.Dispose();
            }
        }
    }
}
