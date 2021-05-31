using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using System;
namespace i.DS{
    public class Singleton<T,I> where T:I{
        private static object lockObj = new object();
        private static T instance = default(T);
    #if DEBUG_MOCK
        public static I Mocking{get;set;}
    #endif     
        public static I Instance{
            get{
    #if DEBUG_MOCK
                if(Mocking != null)
                    return Mocking;
    #endif            
                lock(lockObj){
                    if(instance == null){
                        instance = InstanceCreater.CreateInstance<T>();
                    }
                }
                return instance;
            }
        }
    }
    public class Singleton<T> where T:class{
        private static readonly object lockObj = new object();
        private static T instance;
        public static T Instance{
            get{
                lock(lockObj){
                    if(instance == null){
                        instance = InstanceCreater.CreateInstance<T>();
                    }
                }
                return instance;
            }
        }
    #if MOCK
        public static void InstanceClear(){
            instance = null;
        }
    #endif    
    }
    static class InstanceCreater{
        public static T CreateInstance<T>(){
            var type = typeof(T);
            try{
                return (T)type.Assembly.CreateInstance(type.FullName,true,BindingFlags.NonPublic|BindingFlags.Instance,null,null,null,null);
            }catch(MissingMethodException e){
                throw new System.Exception(string.Format("{0}(In Singleton Mode,the construct function must be private)",e.Message));
            }
        }
    }
}
