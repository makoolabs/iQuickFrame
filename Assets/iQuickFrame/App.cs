using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using i.Frame;
using i.UI;
using i.Res;
using i.Net;
public class App : MonoBehaviour,IApp
{
    // Start is called before the first frame update
    void Start()
    {
        Frame.Instance.Initialize(this);
    }
    public List<IModule> RegisterModules(){
         return new List<IModule>(){
             Res.Instance,
             UI.Instance,
             Net.Instance
         };
     }
}
