using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class GameObject : NetObject
   {
      
      public GameObject()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GameObjectCreateInstance());
      }

      public GameObject(uint pId) : base(pId)
      {
      }

      public GameObject(string pName) : base(pName)
      {
      }

      public GameObject(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GameObject(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GameObject(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GameObjectCreateInstance();
         private static _GameObjectCreateInstance _GameObjectCreateInstanceFunc;
         internal static IntPtr GameObjectCreateInstance()
         {
            if (_GameObjectCreateInstanceFunc == null)
            {
               _GameObjectCreateInstanceFunc =
                  (_GameObjectCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GameObjectCreateInstance"), typeof(_GameObjectCreateInstance));
            }

            return _GameObjectCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}