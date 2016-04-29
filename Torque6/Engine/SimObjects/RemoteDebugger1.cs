using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class RemoteDebugger1 : RemoteDebuggerBase
   {
      
      public RemoteDebugger1()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.RemoteDebugger1CreateInstance());
      }

      public RemoteDebugger1(uint pId) : base(pId)
      {
      }

      public RemoteDebugger1(string pName) : base(pName)
      {
      }

      public RemoteDebugger1(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public RemoteDebugger1(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public RemoteDebugger1(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RemoteDebugger1CreateInstance();
         private static _RemoteDebugger1CreateInstance _RemoteDebugger1CreateInstanceFunc;
         internal static IntPtr RemoteDebugger1CreateInstance()
         {
            if (_RemoteDebugger1CreateInstanceFunc == null)
            {
               _RemoteDebugger1CreateInstanceFunc =
                  (_RemoteDebugger1CreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "RemoteDebugger1CreateInstance"), typeof(_RemoteDebugger1CreateInstance));
            }

            return _RemoteDebugger1CreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RemoteDebugger1GetCodeFiles(IntPtr debugger1);
         private static _RemoteDebugger1GetCodeFiles _RemoteDebugger1GetCodeFilesFunc;
         internal static IntPtr RemoteDebugger1GetCodeFiles(IntPtr debugger1)
         {
            if (_RemoteDebugger1GetCodeFilesFunc == null)
            {
               _RemoteDebugger1GetCodeFilesFunc =
                  (_RemoteDebugger1GetCodeFiles)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "RemoteDebugger1GetCodeFiles"), typeof(_RemoteDebugger1GetCodeFiles));
            }

            return _RemoteDebugger1GetCodeFilesFunc(debugger1);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _RemoteDebugger1SetNextStatementBreak(IntPtr debugger1, bool enabled);
         private static _RemoteDebugger1SetNextStatementBreak _RemoteDebugger1SetNextStatementBreakFunc;
         internal static void RemoteDebugger1SetNextStatementBreak(IntPtr debugger1, bool enabled)
         {
            if (_RemoteDebugger1SetNextStatementBreakFunc == null)
            {
               _RemoteDebugger1SetNextStatementBreakFunc =
                  (_RemoteDebugger1SetNextStatementBreak)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "RemoteDebugger1SetNextStatementBreak"), typeof(_RemoteDebugger1SetNextStatementBreak));
            }

            _RemoteDebugger1SetNextStatementBreakFunc(debugger1, enabled);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public string GetCodeFiles()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.RemoteDebugger1GetCodeFiles(ObjectPtr->ObjPtr));
      }

      public void SetNextStatementBreak(bool enabled)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.RemoteDebugger1SetNextStatementBreak(ObjectPtr->ObjPtr, enabled);
      }
      
      #endregion

      
   }
}