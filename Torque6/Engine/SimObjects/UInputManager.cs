using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class UInputManager : InputManager
   {
      
      public UInputManager()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.UInputManagerCreateInstance());
      }

      public UInputManager(uint pId) : base(pId)
      {
      }

      public UInputManager(string pName) : base(pName)
      {
      }

      public UInputManager(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public UInputManager(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public UInputManager(SimObject pObj) : base(pObj)
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