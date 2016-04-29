using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiTabBookCtrl : GuiControl
   {
      
      public GuiTabBookCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiTabBookCtrlCreateInstance());
      }

      public GuiTabBookCtrl(uint pId) : base(pId)
      {
      }

      public GuiTabBookCtrl(string pName) : base(pName)
      {
      }

      public GuiTabBookCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiTabBookCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiTabBookCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTabBookCtrlGetTabPosition(IntPtr ctrl);
         private static _GuiTabBookCtrlGetTabPosition _GuiTabBookCtrlGetTabPositionFunc;
         internal static int GuiTabBookCtrlGetTabPosition(IntPtr ctrl)
         {
            if (_GuiTabBookCtrlGetTabPositionFunc == null)
            {
               _GuiTabBookCtrlGetTabPositionFunc =
                  (_GuiTabBookCtrlGetTabPosition)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTabBookCtrlGetTabPosition"), typeof(_GuiTabBookCtrlGetTabPosition));
            }

            return _GuiTabBookCtrlGetTabPositionFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTabBookCtrlSetTabPosition(IntPtr ctrl, int tabPosition);
         private static _GuiTabBookCtrlSetTabPosition _GuiTabBookCtrlSetTabPositionFunc;
         internal static void GuiTabBookCtrlSetTabPosition(IntPtr ctrl, int tabPosition)
         {
            if (_GuiTabBookCtrlSetTabPositionFunc == null)
            {
               _GuiTabBookCtrlSetTabPositionFunc =
                  (_GuiTabBookCtrlSetTabPosition)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTabBookCtrlSetTabPosition"), typeof(_GuiTabBookCtrlSetTabPosition));
            }

            _GuiTabBookCtrlSetTabPositionFunc(ctrl, tabPosition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTabBookCtrlGetTabHeight(IntPtr ctrl);
         private static _GuiTabBookCtrlGetTabHeight _GuiTabBookCtrlGetTabHeightFunc;
         internal static int GuiTabBookCtrlGetTabHeight(IntPtr ctrl)
         {
            if (_GuiTabBookCtrlGetTabHeightFunc == null)
            {
               _GuiTabBookCtrlGetTabHeightFunc =
                  (_GuiTabBookCtrlGetTabHeight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTabBookCtrlGetTabHeight"), typeof(_GuiTabBookCtrlGetTabHeight));
            }

            return _GuiTabBookCtrlGetTabHeightFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTabBookCtrlSetTabHeight(IntPtr ctrl, int height);
         private static _GuiTabBookCtrlSetTabHeight _GuiTabBookCtrlSetTabHeightFunc;
         internal static void GuiTabBookCtrlSetTabHeight(IntPtr ctrl, int height)
         {
            if (_GuiTabBookCtrlSetTabHeightFunc == null)
            {
               _GuiTabBookCtrlSetTabHeightFunc =
                  (_GuiTabBookCtrlSetTabHeight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTabBookCtrlSetTabHeight"), typeof(_GuiTabBookCtrlSetTabHeight));
            }

            _GuiTabBookCtrlSetTabHeightFunc(ctrl, height);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTabBookCtrlGetTabMargin(IntPtr ctrl);
         private static _GuiTabBookCtrlGetTabMargin _GuiTabBookCtrlGetTabMarginFunc;
         internal static int GuiTabBookCtrlGetTabMargin(IntPtr ctrl)
         {
            if (_GuiTabBookCtrlGetTabMarginFunc == null)
            {
               _GuiTabBookCtrlGetTabMarginFunc =
                  (_GuiTabBookCtrlGetTabMargin)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTabBookCtrlGetTabMargin"), typeof(_GuiTabBookCtrlGetTabMargin));
            }

            return _GuiTabBookCtrlGetTabMarginFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTabBookCtrlSetTabMargin(IntPtr ctrl, int margin);
         private static _GuiTabBookCtrlSetTabMargin _GuiTabBookCtrlSetTabMarginFunc;
         internal static void GuiTabBookCtrlSetTabMargin(IntPtr ctrl, int margin)
         {
            if (_GuiTabBookCtrlSetTabMarginFunc == null)
            {
               _GuiTabBookCtrlSetTabMarginFunc =
                  (_GuiTabBookCtrlSetTabMargin)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTabBookCtrlSetTabMargin"), typeof(_GuiTabBookCtrlSetTabMargin));
            }

            _GuiTabBookCtrlSetTabMarginFunc(ctrl, margin);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTabBookCtrlGetMinTabWidth(IntPtr ctrl);
         private static _GuiTabBookCtrlGetMinTabWidth _GuiTabBookCtrlGetMinTabWidthFunc;
         internal static int GuiTabBookCtrlGetMinTabWidth(IntPtr ctrl)
         {
            if (_GuiTabBookCtrlGetMinTabWidthFunc == null)
            {
               _GuiTabBookCtrlGetMinTabWidthFunc =
                  (_GuiTabBookCtrlGetMinTabWidth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTabBookCtrlGetMinTabWidth"), typeof(_GuiTabBookCtrlGetMinTabWidth));
            }

            return _GuiTabBookCtrlGetMinTabWidthFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTabBookCtrlSetMinTabWidth(IntPtr ctrl, int width);
         private static _GuiTabBookCtrlSetMinTabWidth _GuiTabBookCtrlSetMinTabWidthFunc;
         internal static void GuiTabBookCtrlSetMinTabWidth(IntPtr ctrl, int width)
         {
            if (_GuiTabBookCtrlSetMinTabWidthFunc == null)
            {
               _GuiTabBookCtrlSetMinTabWidthFunc =
                  (_GuiTabBookCtrlSetMinTabWidth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTabBookCtrlSetMinTabWidth"), typeof(_GuiTabBookCtrlSetMinTabWidth));
            }

            _GuiTabBookCtrlSetMinTabWidthFunc(ctrl, width);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTabBookCtrlCreateInstance();
         private static _GuiTabBookCtrlCreateInstance _GuiTabBookCtrlCreateInstanceFunc;
         internal static IntPtr GuiTabBookCtrlCreateInstance()
         {
            if (_GuiTabBookCtrlCreateInstanceFunc == null)
            {
               _GuiTabBookCtrlCreateInstanceFunc =
                  (_GuiTabBookCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTabBookCtrlCreateInstance"), typeof(_GuiTabBookCtrlCreateInstance));
            }

            return _GuiTabBookCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTabBookCtrlAddPage(IntPtr ctrl);
         private static _GuiTabBookCtrlAddPage _GuiTabBookCtrlAddPageFunc;
         internal static void GuiTabBookCtrlAddPage(IntPtr ctrl)
         {
            if (_GuiTabBookCtrlAddPageFunc == null)
            {
               _GuiTabBookCtrlAddPageFunc =
                  (_GuiTabBookCtrlAddPage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTabBookCtrlAddPage"), typeof(_GuiTabBookCtrlAddPage));
            }

            _GuiTabBookCtrlAddPageFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTabBookCtrlSelectPage(IntPtr ctrl, int pageIndex);
         private static _GuiTabBookCtrlSelectPage _GuiTabBookCtrlSelectPageFunc;
         internal static void GuiTabBookCtrlSelectPage(IntPtr ctrl, int pageIndex)
         {
            if (_GuiTabBookCtrlSelectPageFunc == null)
            {
               _GuiTabBookCtrlSelectPageFunc =
                  (_GuiTabBookCtrlSelectPage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTabBookCtrlSelectPage"), typeof(_GuiTabBookCtrlSelectPage));
            }

            _GuiTabBookCtrlSelectPageFunc(ctrl, pageIndex);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTabBookCtrlSelectPageName(IntPtr ctrl, string pageName);
         private static _GuiTabBookCtrlSelectPageName _GuiTabBookCtrlSelectPageNameFunc;
         internal static void GuiTabBookCtrlSelectPageName(IntPtr ctrl, string pageName)
         {
            if (_GuiTabBookCtrlSelectPageNameFunc == null)
            {
               _GuiTabBookCtrlSelectPageNameFunc =
                  (_GuiTabBookCtrlSelectPageName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTabBookCtrlSelectPageName"), typeof(_GuiTabBookCtrlSelectPageName));
            }

            _GuiTabBookCtrlSelectPageNameFunc(ctrl, pageName);
         }
      }
      
      #endregion

      #region Properties

      public int TabPosition
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTabBookCtrlGetTabPosition(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTabBookCtrlSetTabPosition(ObjectPtr->ObjPtr, value);
         }
      }
      public int TabHeight
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTabBookCtrlGetTabHeight(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTabBookCtrlSetTabHeight(ObjectPtr->ObjPtr, value);
         }
      }
      public int TabMargin
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTabBookCtrlGetTabMargin(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTabBookCtrlSetTabMargin(ObjectPtr->ObjPtr, value);
         }
      }
      public int MinTabWidth
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTabBookCtrlGetMinTabWidth(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTabBookCtrlSetMinTabWidth(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public void AddPage()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTabBookCtrlAddPage(ObjectPtr->ObjPtr);
      }

      public void SelectPage(int pageIndex)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTabBookCtrlSelectPage(ObjectPtr->ObjPtr, pageIndex);
      }

      public void SelectPageName(string pageName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTabBookCtrlSelectPageName(ObjectPtr->ObjPtr, pageName);
      }
      
      #endregion

      
   }
}