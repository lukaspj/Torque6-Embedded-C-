using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class RootNode : BaseNode
   {
      
      public RootNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.RootNodeCreateInstance());
      }

      public RootNode(uint pId) : base(pId)
      {
      }

      public RootNode(string pName) : base(pName)
      {
      }

      public RootNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public RootNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public RootNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr RootNodeCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}