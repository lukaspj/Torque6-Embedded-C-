using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class AndroidStreamSource : SimObject
   {
      
      public AndroidStreamSource()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.AndroidStreamSourceCreateInstance());
      }

      public AndroidStreamSource(uint pId) : base(pId)
      {
      }

      public AndroidStreamSource(string pName) : base(pName)
      {
      }

      public AndroidStreamSource(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public AndroidStreamSource(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public AndroidStreamSource(SimObject pObj) : base(pObj)
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