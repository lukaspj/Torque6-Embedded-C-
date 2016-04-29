using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class PhysicsBoxComponent : PhysicsBaseComponent
   {
      
      public PhysicsBoxComponent()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.PhysicsBoxComponentCreateInstance());
      }

      public PhysicsBoxComponent(uint pId) : base(pId)
      {
      }

      public PhysicsBoxComponent(string pName) : base(pName)
      {
      }

      public PhysicsBoxComponent(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public PhysicsBoxComponent(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public PhysicsBoxComponent(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PhysicsBoxComponentCreateInstance();
         private static _PhysicsBoxComponentCreateInstance _PhysicsBoxComponentCreateInstanceFunc;
         internal static IntPtr PhysicsBoxComponentCreateInstance()
         {
            if (_PhysicsBoxComponentCreateInstanceFunc == null)
            {
               _PhysicsBoxComponentCreateInstanceFunc =
                  (_PhysicsBoxComponentCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PhysicsBoxComponentCreateInstance"), typeof(_PhysicsBoxComponentCreateInstance));
            }

            return _PhysicsBoxComponentCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}