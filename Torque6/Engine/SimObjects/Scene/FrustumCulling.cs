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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr FrustumCullingCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}