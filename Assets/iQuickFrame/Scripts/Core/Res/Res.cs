using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using i.DS;
namespace i.Res{
    public class Res:Singleton<Res>{
        private Res(){}
        public void Hello(){
            Debug.LogWarning("hello");
        }
    }
}