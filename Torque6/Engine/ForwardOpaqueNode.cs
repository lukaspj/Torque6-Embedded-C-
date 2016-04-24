using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine
{
   public unsafe class ForwardOpaqueNode : OpaqueNode
   {
      
      public ForwardOpaqueNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.ForwardOpaqueNodeCreateInstance());
      }

      public ForwardOpaqueNode(uint pId) : base(pId)
      {
      }

      public ForwardOpaqueNode(string pName) : base(pName)
      {
      }

      public ForwardOpaqueNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public ForwardOpaqueNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public ForwardOpaqueNode(SimObject pObj) : base(pObj)
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