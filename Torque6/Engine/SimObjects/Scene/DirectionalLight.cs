using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class DirectionalLight : BaseComponent
   {
      
      public DirectionalLight()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.DirectionalLightCreateInstance());
      }

      public DirectionalLight(uint pId) : base(pId)
      {
      }

      public DirectionalLight(string pName) : base(pName)
      {
      }

      public DirectionalLight(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public DirectionalLight(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public DirectionalLight(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr DirectionalLightCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}