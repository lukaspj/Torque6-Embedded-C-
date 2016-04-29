using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class SkyLight : BaseComponent
   {
      
      public SkyLight()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.SkyLightCreateInstance());
      }

      public SkyLight(uint pId) : base(pId)
      {
      }

      public SkyLight(string pName) : base(pName)
      {
      }

      public SkyLight(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public SkyLight(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public SkyLight(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SkyLightCreateInstance();
         private static _SkyLightCreateInstance _SkyLightCreateInstanceFunc;
         internal static IntPtr SkyLightCreateInstance()
         {
            if (_SkyLightCreateInstanceFunc == null)
            {
               _SkyLightCreateInstanceFunc =
                  (_SkyLightCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SkyLightCreateInstance"), typeof(_SkyLightCreateInstance));
            }

            return _SkyLightCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}