using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace i.Frame{
    public interface IApp
    {
        List<IModule> RegisterModules();
    }
}
