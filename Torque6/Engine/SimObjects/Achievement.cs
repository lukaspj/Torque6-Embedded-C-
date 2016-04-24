using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class Achievement : SimObject
   {
      
      public Achievement()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.AchievementCreateInstance());
      }

      public Achievement(uint pId) : base(pId)
      {
      }

      public Achievement(string pName) : base(pName)
      {
      }

      public Achievement(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public Achievement(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public Achievement(SimObject pObj) : base(pObj)
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