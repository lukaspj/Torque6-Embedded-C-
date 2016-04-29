using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiMLTextEditCtrl : GuiMLTextCtrl
   {
      
      public GuiMLTextEditCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiMLTextEditCtrlCreateInstance());
      }

      public GuiMLTextEditCtrl(uint pId) : base(pId)
      {
      }

      public GuiMLTextEditCtrl(string pName) : base(pName)
      {
      }

      public GuiMLTextEditCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiMLTextEditCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiMLTextEditCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMLTextEditCtrlGetEscapeCommand(IntPtr ctrl);
         private static _GuiMLTextEditCtrlGetEscapeCommand _GuiMLTextEditCtrlGetEscapeCommandFunc;
         internal static IntPtr GuiMLTextEditCtrlGetEscapeCommand(IntPtr ctrl)
         {
            if (_GuiMLTextEditCtrlGetEscapeCommandFunc == null)
            {
               _GuiMLTextEditCtrlGetEscapeCommandFunc =
                  (_GuiMLTextEditCtrlGetEscapeCommand)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextEditCtrlGetEscapeCommand"), typeof(_GuiMLTextEditCtrlGetEscapeCommand));
            }

            return _GuiMLTextEditCtrlGetEscapeCommandFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMLTextEditCtrlSetEscapeCommand(IntPtr ctrl, string command);
         private static _GuiMLTextEditCtrlSetEscapeCommand _GuiMLTextEditCtrlSetEscapeCommandFunc;
         internal static void GuiMLTextEditCtrlSetEscapeCommand(IntPtr ctrl, string command)
         {
            if (_GuiMLTextEditCtrlSetEscapeCommandFunc == null)
            {
               _GuiMLTextEditCtrlSetEscapeCommandFunc =
                  (_GuiMLTextEditCtrlSetEscapeCommand)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextEditCtrlSetEscapeCommand"), typeof(_GuiMLTextEditCtrlSetEscapeCommand));
            }

            _GuiMLTextEditCtrlSetEscapeCommandFunc(ctrl, command);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMLTextEditCtrlCreateInstance();
         private static _GuiMLTextEditCtrlCreateInstance _GuiMLTextEditCtrlCreateInstanceFunc;
         internal static IntPtr GuiMLTextEditCtrlCreateInstance()
         {
            if (_GuiMLTextEditCtrlCreateInstanceFunc == null)
            {
               _GuiMLTextEditCtrlCreateInstanceFunc =
                  (_GuiMLTextEditCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextEditCtrlCreateInstance"), typeof(_GuiMLTextEditCtrlCreateInstance));
            }

            return _GuiMLTextEditCtrlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string EscapeCommand
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiMLTextEditCtrlGetEscapeCommand(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiMLTextEditCtrlSetEscapeCommand(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}