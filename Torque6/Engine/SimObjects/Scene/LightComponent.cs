using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class LightComponent : BaseComponent
   {
      
      public LightComponent()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.LightComponentCreateInstance());
      }

      public LightComponent(uint pId) : base(pId)
      {
      }

      public LightComponent(string pName) : base(pName)
      {
      }

      public LightComponent(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public LightComponent(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public LightComponent(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _LightComponentCreateInstance();
         private static _LightComponentCreateInstance _LightComponentCreateInstanceFunc;
         internal static IntPtr LightComponentCreateInstance()
         {
            if (_LightComponentCreateInstanceFunc == null)
            {
               _LightComponentCreateInstanceFunc =
                  (_LightComponentCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "LightComponentCreateInstance"), typeof(_LightComponentCreateInstance));
            }

            return _LightComponentCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}