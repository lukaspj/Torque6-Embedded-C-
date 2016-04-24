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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr LightComponentCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}