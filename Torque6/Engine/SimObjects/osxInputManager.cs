using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class osxInputManager : InputManager
   {
      
      public osxInputManager()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.osxInputManagerCreateInstance());
      }

      public osxInputManager(uint pId) : base(pId)
      {
      }

      public osxInputManager(string pName) : base(pName)
      {
      }

      public osxInputManager(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public osxInputManager(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public osxInputManager(SimObject pObj) : base(pObj)
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