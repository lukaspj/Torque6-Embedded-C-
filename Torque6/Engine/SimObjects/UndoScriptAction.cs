using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class UndoScriptAction : UndoAction
   {
      
      public UndoScriptAction()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.UndoScriptActionCreateInstance());
      }

      public UndoScriptAction(uint pId) : base(pId)
      {
      }

      public UndoScriptAction(string pName) : base(pName)
      {
      }

      public UndoScriptAction(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public UndoScriptAction(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public UndoScriptAction(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _UndoScriptActionCreateInstance();
         private static _UndoScriptActionCreateInstance _UndoScriptActionCreateInstanceFunc;
         internal static IntPtr UndoScriptActionCreateInstance()
         {
            if (_UndoScriptActionCreateInstanceFunc == null)
            {
               _UndoScriptActionCreateInstanceFunc =
                  (_UndoScriptActionCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "UndoScriptActionCreateInstance"), typeof(_UndoScriptActionCreateInstance));
            }

            return _UndoScriptActionCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}