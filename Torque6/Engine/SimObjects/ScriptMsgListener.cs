using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class ScriptMsgListener : SimObject
   {
      
      public ScriptMsgListener()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.ScriptMsgListenerCreateInstance());
      }

      public ScriptMsgListener(uint pId) : base(pId)
      {
      }

      public ScriptMsgListener(string pName) : base(pName)
      {
      }

      public ScriptMsgListener(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public ScriptMsgListener(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public ScriptMsgListener(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr ScriptMsgListenerCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}