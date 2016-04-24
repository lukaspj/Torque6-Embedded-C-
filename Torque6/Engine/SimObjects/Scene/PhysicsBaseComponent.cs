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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr PhysicsBaseComponentCreateInstance();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void PhysicsBaseComponentSetLinearVelocity(IntPtr component, Point3F velocity);
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