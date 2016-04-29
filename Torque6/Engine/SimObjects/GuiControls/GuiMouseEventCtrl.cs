using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiMouseEventCtrl : GuiControl
   {
      
      public GuiMouseEventCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiMouseEventCtrlCreateInstance());
      }

      public GuiMouseEventCtrl(uint pId) : base(pId)
      {
      }

      public GuiMouseEventCtrl(string pName) : base(pName)
      {
      }

      public GuiMouseEventCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiMouseEventCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiMouseEventCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiMouseEventCtrlGetLockMouse(IntPtr ctrl);
         private static _GuiMouseEventCtrlGetLockMouse _GuiMouseEventCtrlGetLockMouseFunc;
         internal static bool GuiMouseEventCtrlGetLockMouse(IntPtr ctrl)
         {
            if (_GuiMouseEventCtrlGetLockMouseFunc == null)
            {
               _GuiMouseEventCtrlGetLockMouseFunc =
                  (_GuiMouseEventCtrlGetLockMouse)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMouseEventCtrlGetLockMouse"), typeof(_GuiMouseEventCtrlGetLockMouse));
            }

            return _GuiMouseEventCtrlGetLockMouseFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMouseEventCtrlSetLockMouse(IntPtr ctrl, bool enableLock);
         private static _GuiMouseEventCtrlSetLockMouse _GuiMouseEventCtrlSetLockMouseFunc;
         internal static void GuiMouseEventCtrlSetLockMouse(IntPtr ctrl, bool enableLock)
         {
            if (_GuiMouseEventCtrlSetLockMouseFunc == null)
            {
               _GuiMouseEventCtrlSetLockMouseFunc =
                  (_GuiMouseEventCtrlSetLockMouse)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMouseEventCtrlSetLockMouse"), typeof(_GuiMouseEventCtrlSetLockMouse));
            }

            _GuiMouseEventCtrlSetLockMouseFunc(ctrl, enableLock);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMouseEventCtrlCreateInstance();
         private static _GuiMouseEventCtrlCreateInstance _GuiMouseEventCtrlCreateInstanceFunc;
         internal static IntPtr GuiMouseEventCtrlCreateInstance()
         {
            if (_GuiMouseEventCtrlCreateInstanceFunc == null)
            {
               _GuiMouseEventCtrlCreateInstanceFunc =
                  (_GuiMouseEventCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMouseEventCtrlCreateInstance"), typeof(_GuiMouseEventCtrlCreateInstance));
            }

            return _GuiMouseEventCtrlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public bool LockMouse
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiMouseEventCtrlGetLockMouse(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiMouseEventCtrlSetLockMouse(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}