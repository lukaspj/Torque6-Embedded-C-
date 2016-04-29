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
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ScriptMsgListenerCreateInstance();
         private static _ScriptMsgListenerCreateInstance _ScriptMsgListenerCreateInstanceFunc;
         internal static IntPtr ScriptMsgListenerCreateInstance()
         {
            if (_ScriptMsgListenerCreateInstanceFunc == null)
            {
               _ScriptMsgListenerCreateInstanceFunc =
                  (_ScriptMsgListenerCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ScriptMsgListenerCreateInstance"), typeof(_ScriptMsgListenerCreateInstance));
            }

            return _ScriptMsgListenerCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}