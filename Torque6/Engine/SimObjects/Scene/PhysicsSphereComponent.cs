using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class PhysicsSphereComponent : PhysicsBaseComponent
   {
      
      public PhysicsSphereComponent()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.PhysicsSphereComponentCreateInstance());
      }

      public PhysicsSphereComponent(uint pId) : base(pId)
      {
      }

      public PhysicsSphereComponent(string pName) : base(pName)
      {
      }

      public PhysicsSphereComponent(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public PhysicsSphereComponent(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public PhysicsSphereComponent(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr PhysicsSphereComponentCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}