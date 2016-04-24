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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr SkyLightCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}