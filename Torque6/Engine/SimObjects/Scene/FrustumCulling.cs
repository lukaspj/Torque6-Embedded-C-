using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class FrustumCulling : BaseComponent
   {
      
      public FrustumCulling()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.FrustumCullingCreateInstance());
      }

      public FrustumCulling(uint pId) : base(pId)
      {
      }

      public FrustumCulling(string pName) : base(pName)
      {
      }

      public FrustumCulling(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public FrustumCulling(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public FrustumCulling(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FrustumCullingCreateInstance();
         private static _FrustumCullingCreateInstance _FrustumCullingCreateInstanceFunc;
         internal static IntPtr FrustumCullingCreateInstance()
         {
            if (_FrustumCullingCreateInstanceFunc == null)
            {
               _FrustumCullingCreateInstanceFunc =
                  (_FrustumCullingCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FrustumCullingCreateInstance"), typeof(_FrustumCullingCreateInstance));
            }

            return _FrustumCullingCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}