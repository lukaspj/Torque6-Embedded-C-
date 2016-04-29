using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class CameraComponent : BaseComponent
   {
      
      public CameraComponent()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.CameraComponentCreateInstance());
      }

      public CameraComponent(uint pId) : base(pId)
      {
      }

      public CameraComponent(string pName) : base(pName)
      {
      }

      public CameraComponent(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public CameraComponent(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public CameraComponent(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _CameraComponentCreateInstance();
         private static _CameraComponentCreateInstance _CameraComponentCreateInstanceFunc;
         internal static IntPtr CameraComponentCreateInstance()
         {
            if (_CameraComponentCreateInstanceFunc == null)
            {
               _CameraComponentCreateInstanceFunc =
                  (_CameraComponentCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "CameraComponentCreateInstance"), typeof(_CameraComponentCreateInstance));
            }

            return _CameraComponentCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}