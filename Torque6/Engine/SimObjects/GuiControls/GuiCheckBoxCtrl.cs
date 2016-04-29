using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiCheckBoxCtrl : GuiButtonBaseCtrl
   {
      
      public GuiCheckBoxCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiCheckBoxCtrlCreateInstance());
      }

      public GuiCheckBoxCtrl(uint pId) : base(pId)
      {
      }

      public GuiCheckBoxCtrl(string pName) : base(pName)
      {
      }

      public GuiCheckBoxCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiCheckBoxCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiCheckBoxCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiCheckBoxCtrlGetUseInactiveState(IntPtr ctrl);
         private static _GuiCheckBoxCtrlGetUseInactiveState _GuiCheckBoxCtrlGetUseInactiveStateFunc;
         internal static bool GuiCheckBoxCtrlGetUseInactiveState(IntPtr ctrl)
         {
            if (_GuiCheckBoxCtrlGetUseInactiveStateFunc == null)
            {
               _GuiCheckBoxCtrlGetUseInactiveStateFunc =
                  (_GuiCheckBoxCtrlGetUseInactiveState)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCheckBoxCtrlGetUseInactiveState"), typeof(_GuiCheckBoxCtrlGetUseInactiveState));
            }

            return _GuiCheckBoxCtrlGetUseInactiveStateFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCheckBoxCtrlSetUseInactiveState(IntPtr ctrl, bool useInactiveState);
         private static _GuiCheckBoxCtrlSetUseInactiveState _GuiCheckBoxCtrlSetUseInactiveStateFunc;
         internal static void GuiCheckBoxCtrlSetUseInactiveState(IntPtr ctrl, bool useInactiveState)
         {
            if (_GuiCheckBoxCtrlSetUseInactiveStateFunc == null)
            {
               _GuiCheckBoxCtrlSetUseInactiveStateFunc =
                  (_GuiCheckBoxCtrlSetUseInactiveState)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCheckBoxCtrlSetUseInactiveState"), typeof(_GuiCheckBoxCtrlSetUseInactiveState));
            }

            _GuiCheckBoxCtrlSetUseInactiveStateFunc(ctrl, useInactiveState);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiCheckBoxCtrlCreateInstance();
         private static _GuiCheckBoxCtrlCreateInstance _GuiCheckBoxCtrlCreateInstanceFunc;
         internal static IntPtr GuiCheckBoxCtrlCreateInstance()
         {
            if (_GuiCheckBoxCtrlCreateInstanceFunc == null)
            {
               _GuiCheckBoxCtrlCreateInstanceFunc =
                  (_GuiCheckBoxCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCheckBoxCtrlCreateInstance"), typeof(_GuiCheckBoxCtrlCreateInstance));
            }

            return _GuiCheckBoxCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCheckBoxCtrlSetStateOn(IntPtr ctrl, int state);
         private static _GuiCheckBoxCtrlSetStateOn _GuiCheckBoxCtrlSetStateOnFunc;
         internal static void GuiCheckBoxCtrlSetStateOn(IntPtr ctrl, int state)
         {
            if (_GuiCheckBoxCtrlSetStateOnFunc == null)
            {
               _GuiCheckBoxCtrlSetStateOnFunc =
                  (_GuiCheckBoxCtrlSetStateOn)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCheckBoxCtrlSetStateOn"), typeof(_GuiCheckBoxCtrlSetStateOn));
            }

            _GuiCheckBoxCtrlSetStateOnFunc(ctrl, state);
         }
      }
      
      #endregion

      #region Properties

      public bool UseInactiveState
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiCheckBoxCtrlGetUseInactiveState(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiCheckBoxCtrlSetUseInactiveState(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public void SetStateOn(int state)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiCheckBoxCtrlSetStateOn(ObjectPtr->ObjPtr, state);
      }
      
      #endregion

      
   }
}