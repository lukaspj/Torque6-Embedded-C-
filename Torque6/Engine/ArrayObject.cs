using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine
{
   public unsafe class ArrayObject : SimObject
   {
      
      public ArrayObject()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.ArrayObjectCreateInstance());
      }

      public ArrayObject(uint pId) : base(pId)
      {
      }

      public ArrayObject(string pName) : base(pName)
      {
      }

      public ArrayObject(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public ArrayObject(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public ArrayObject(SimObject pObj) : base(pObj)
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