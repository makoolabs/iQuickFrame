using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace i.Frame{
    public interface IModule
    {
        void Initialize();
        void Dispose();
    }
}
