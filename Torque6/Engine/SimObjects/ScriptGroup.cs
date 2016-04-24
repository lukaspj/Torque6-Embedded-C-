using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class ScriptGroup : SimGroup
   {
      
      public ScriptGroup()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.ScriptGroupCreateInstance());
      }

      public ScriptGroup(uint pId) : base(pId)
      {
      }

      public ScriptGroup(string pName) : base(pName)
      {
      }

      public ScriptGroup(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public ScriptGroup(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public ScriptGroup(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr ScriptGroupCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}