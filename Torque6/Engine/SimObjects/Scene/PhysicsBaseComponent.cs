using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class PhysicsBaseComponent : BaseComponent
   {
      
      public PhysicsBaseComponent()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.PhysicsBaseComponentCreateInstance());
      }

      public PhysicsBaseComponent(uint pId) : base(pId)
      {
      }

      public PhysicsBaseComponent(string pName) : base(pName)
      {
      }

      public PhysicsBaseComponent(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public PhysicsBaseComponent(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public PhysicsBaseComponent(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PhysicsBaseComponentCreateInstance();
         private static _PhysicsBaseComponentCreateInstance _PhysicsBaseComponentCreateInstanceFunc;
         internal static IntPtr PhysicsBaseComponentCreateInstance()
         {
            if (_PhysicsBaseComponentCreateInstanceFunc == null)
            {
               _PhysicsBaseComponentCreateInstanceFunc =
                  (_PhysicsBaseComponentCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PhysicsBaseComponentCreateInstance"), typeof(_PhysicsBaseComponentCreateInstance));
            }

            return _PhysicsBaseComponentCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _PhysicsBaseComponentSetLinearVelocity(IntPtr component, Point3F velocity);
         private static _PhysicsBaseComponentSetLinearVelocity _PhysicsBaseComponentSetLinearVelocityFunc;
         internal static void PhysicsBaseComponentSetLinearVelocity(IntPtr component, Point3F velocity)
         {
            if (_PhysicsBaseComponentSetLinearVelocityFunc == null)
            {
               _PhysicsBaseComponentSetLinearVelocityFunc =
                  (_PhysicsBaseComponentSetLinearVelocity)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PhysicsBaseComponentSetLinearVelocity"), typeof(_PhysicsBaseComponentSetLinearVelocity));
            }

            _PhysicsBaseComponentSetLinearVelocityFunc(component, velocity);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void SetLinearVelocity(Point3F velocity)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.PhysicsBaseComponentSetLinearVelocity(ObjectPtr->ObjPtr, velocity);
      }
      
      #endregion

      
   }
}