using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiConsoleEditCtrl : GuiTextEditCtrl
   {
      
      public GuiConsoleEditCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiConsoleEditCtrlCreateInstance());
      }

      public GuiConsoleEditCtrl(uint pId) : base(pId)
      {
      }

      public GuiConsoleEditCtrl(string pName) : base(pName)
      {
      }

      public GuiConsoleEditCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiConsoleEditCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiConsoleEditCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiConsoleEditCtrlGetUseSiblingScroller(IntPtr ctrl);
         private static _GuiConsoleEditCtrlGetUseSiblingScroller _GuiConsoleEditCtrlGetUseSiblingScrollerFunc;
         internal static bool GuiConsoleEditCtrlGetUseSiblingScroller(IntPtr ctrl)
         {
            if (_GuiConsoleEditCtrlGetUseSiblingScrollerFunc == null)
            {
               _GuiConsoleEditCtrlGetUseSiblingScrollerFunc =
                  (_GuiConsoleEditCtrlGetUseSiblingScroller)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiConsoleEditCtrlGetUseSiblingScroller"), typeof(_GuiConsoleEditCtrlGetUseSiblingScroller));
            }

            return _GuiConsoleEditCtrlGetUseSiblingScrollerFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiConsoleEditCtrlSetUseSiblingScroller(IntPtr ctrl, bool use);
         private static _GuiConsoleEditCtrlSetUseSiblingScroller _GuiConsoleEditCtrlSetUseSiblingScrollerFunc;
         internal static void GuiConsoleEditCtrlSetUseSiblingScroller(IntPtr ctrl, bool use)
         {
            if (_GuiConsoleEditCtrlSetUseSiblingScrollerFunc == null)
            {
               _GuiConsoleEditCtrlSetUseSiblingScrollerFunc =
                  (_GuiConsoleEditCtrlSetUseSiblingScroller)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiConsoleEditCtrlSetUseSiblingScroller"), typeof(_GuiConsoleEditCtrlSetUseSiblingScroller));
            }

            _GuiConsoleEditCtrlSetUseSiblingScrollerFunc(ctrl, use);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiConsoleEditCtrlCreateInstance();
         private static _GuiConsoleEditCtrlCreateInstance _GuiConsoleEditCtrlCreateInstanceFunc;
         internal static IntPtr GuiConsoleEditCtrlCreateInstance()
         {
            if (_GuiConsoleEditCtrlCreateInstanceFunc == null)
            {
               _GuiConsoleEditCtrlCreateInstanceFunc =
                  (_GuiConsoleEditCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiConsoleEditCtrlCreateInstance"), typeof(_GuiConsoleEditCtrlCreateInstance));
            }

            return _GuiConsoleEditCtrlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public bool UseSiblingScroller
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiConsoleEditCtrlGetUseSiblingScroller(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiConsoleEditCtrlSetUseSiblingScroller(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}