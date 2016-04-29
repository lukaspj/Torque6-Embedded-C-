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
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ScriptGroupCreateInstance();
         private static _ScriptGroupCreateInstance _ScriptGroupCreateInstanceFunc;
         internal static IntPtr ScriptGroupCreateInstance()
         {
            if (_ScriptGroupCreateInstanceFunc == null)
            {
               _ScriptGroupCreateInstanceFunc =
                  (_ScriptGroupCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ScriptGroupCreateInstance"), typeof(_ScriptGroupCreateInstance));
            }

            return _ScriptGroupCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}