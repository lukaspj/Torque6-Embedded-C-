using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class ScriptObject : BehaviorComponent
   {
      
      public ScriptObject()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.ScriptObjectCreateInstance());
      }

      public ScriptObject(uint pId) : base(pId)
      {
      }

      public ScriptObject(string pName) : base(pName)
      {
      }

      public ScriptObject(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public ScriptObject(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public ScriptObject(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ScriptObjectCreateInstance();
         private static _ScriptObjectCreateInstance _ScriptObjectCreateInstanceFunc;
         internal static IntPtr ScriptObjectCreateInstance()
         {
            if (_ScriptObjectCreateInstanceFunc == null)
            {
               _ScriptObjectCreateInstanceFunc =
                  (_ScriptObjectCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ScriptObjectCreateInstance"), typeof(_ScriptObjectCreateInstance));
            }

            return _ScriptObjectCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}