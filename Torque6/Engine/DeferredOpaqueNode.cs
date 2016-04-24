using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine
{
   public unsafe class DeferredOpaqueNode : OpaqueNode
   {
      
      public DeferredOpaqueNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.DeferredOpaqueNodeCreateInstance());
      }

      public DeferredOpaqueNode(uint pId) : base(pId)
      {
      }

      public DeferredOpaqueNode(string pName) : base(pName)
      {
      }

      public DeferredOpaqueNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public DeferredOpaqueNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public DeferredOpaqueNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}