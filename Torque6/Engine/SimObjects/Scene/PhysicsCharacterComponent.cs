using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class PhysicsCharacterComponent : PhysicsBaseComponent
   {
      
      public PhysicsCharacterComponent()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.PhysicsCharacterComponentCreateInstance());
      }

      public PhysicsCharacterComponent(uint pId) : base(pId)
      {
      }

      public PhysicsCharacterComponent(string pName) : base(pName)
      {
      }

      public PhysicsCharacterComponent(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public PhysicsCharacterComponent(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public PhysicsCharacterComponent(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr PhysicsCharacterComponentCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}