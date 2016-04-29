using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiScrollCtrl : GuiControl
   {
      
      public GuiScrollCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiScrollCtrlCreateInstance());
      }

      public GuiScrollCtrl(uint pId) : base(pId)
      {
      }

      public GuiScrollCtrl(string pName) : base(pName)
      {
      }

      public GuiScrollCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiScrollCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiScrollCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiScrollCtrlGetWillFirstRespond(IntPtr ctrl);
         private static _GuiScrollCtrlGetWillFirstRespond _GuiScrollCtrlGetWillFirstRespondFunc;
         internal static bool GuiScrollCtrlGetWillFirstRespond(IntPtr ctrl)
         {
            if (_GuiScrollCtrlGetWillFirstRespondFunc == null)
            {
               _GuiScrollCtrlGetWillFirstRespondFunc =
                  (_GuiScrollCtrlGetWillFirstRespond)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScrollCtrlGetWillFirstRespond"), typeof(_GuiScrollCtrlGetWillFirstRespond));
            }

            return _GuiScrollCtrlGetWillFirstRespondFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiScrollCtrlSetWillFirstRespond(IntPtr ctrl, bool enable);
         private static _GuiScrollCtrlSetWillFirstRespond _GuiScrollCtrlSetWillFirstRespondFunc;
         internal static void GuiScrollCtrlSetWillFirstRespond(IntPtr ctrl, bool enable)
         {
            if (_GuiScrollCtrlSetWillFirstRespondFunc == null)
            {
               _GuiScrollCtrlSetWillFirstRespondFunc =
                  (_GuiScrollCtrlSetWillFirstRespond)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScrollCtrlSetWillFirstRespond"), typeof(_GuiScrollCtrlSetWillFirstRespond));
            }

            _GuiScrollCtrlSetWillFirstRespondFunc(ctrl, enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiScrollCtrlGetHScrollBar(IntPtr ctrl);
         private static _GuiScrollCtrlGetHScrollBar _GuiScrollCtrlGetHScrollBarFunc;
         internal static int GuiScrollCtrlGetHScrollBar(IntPtr ctrl)
         {
            if (_GuiScrollCtrlGetHScrollBarFunc == null)
            {
               _GuiScrollCtrlGetHScrollBarFunc =
                  (_GuiScrollCtrlGetHScrollBar)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScrollCtrlGetHScrollBar"), typeof(_GuiScrollCtrlGetHScrollBar));
            }

            return _GuiScrollCtrlGetHScrollBarFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiScrollCtrlSetHScrollBar(IntPtr ctrl, int forceHScrollbar);
         private static _GuiScrollCtrlSetHScrollBar _GuiScrollCtrlSetHScrollBarFunc;
         internal static void GuiScrollCtrlSetHScrollBar(IntPtr ctrl, int forceHScrollbar)
         {
            if (_GuiScrollCtrlSetHScrollBarFunc == null)
            {
               _GuiScrollCtrlSetHScrollBarFunc =
                  (_GuiScrollCtrlSetHScrollBar)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScrollCtrlSetHScrollBar"), typeof(_GuiScrollCtrlSetHScrollBar));
            }

            _GuiScrollCtrlSetHScrollBarFunc(ctrl, forceHScrollbar);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiScrollCtrlGetVScrollBar(IntPtr ctrl);
         private static _GuiScrollCtrlGetVScrollBar _GuiScrollCtrlGetVScrollBarFunc;
         internal static int GuiScrollCtrlGetVScrollBar(IntPtr ctrl)
         {
            if (_GuiScrollCtrlGetVScrollBarFunc == null)
            {
               _GuiScrollCtrlGetVScrollBarFunc =
                  (_GuiScrollCtrlGetVScrollBar)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScrollCtrlGetVScrollBar"), typeof(_GuiScrollCtrlGetVScrollBar));
            }

            return _GuiScrollCtrlGetVScrollBarFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiScrollCtrlSetVScrollBar(IntPtr ctrl, int forceVScrollbar);
         private static _GuiScrollCtrlSetVScrollBar _GuiScrollCtrlSetVScrollBarFunc;
         internal static void GuiScrollCtrlSetVScrollBar(IntPtr ctrl, int forceVScrollbar)
         {
            if (_GuiScrollCtrlSetVScrollBarFunc == null)
            {
               _GuiScrollCtrlSetVScrollBarFunc =
                  (_GuiScrollCtrlSetVScrollBar)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScrollCtrlSetVScrollBar"), typeof(_GuiScrollCtrlSetVScrollBar));
            }

            _GuiScrollCtrlSetVScrollBarFunc(ctrl, forceVScrollbar);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiScrollCtrlGetConstantThumbHeight(IntPtr ctrl);
         private static _GuiScrollCtrlGetConstantThumbHeight _GuiScrollCtrlGetConstantThumbHeightFunc;
         internal static bool GuiScrollCtrlGetConstantThumbHeight(IntPtr ctrl)
         {
            if (_GuiScrollCtrlGetConstantThumbHeightFunc == null)
            {
               _GuiScrollCtrlGetConstantThumbHeightFunc =
                  (_GuiScrollCtrlGetConstantThumbHeight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScrollCtrlGetConstantThumbHeight"), typeof(_GuiScrollCtrlGetConstantThumbHeight));
            }

            return _GuiScrollCtrlGetConstantThumbHeightFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiScrollCtrlSetConstantThumbHeight(IntPtr ctrl, bool useConstantThumbHeight);
         private static _GuiScrollCtrlSetConstantThumbHeight _GuiScrollCtrlSetConstantThumbHeightFunc;
         internal static void GuiScrollCtrlSetConstantThumbHeight(IntPtr ctrl, bool useConstantThumbHeight)
         {
            if (_GuiScrollCtrlSetConstantThumbHeightFunc == null)
            {
               _GuiScrollCtrlSetConstantThumbHeightFunc =
                  (_GuiScrollCtrlSetConstantThumbHeight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScrollCtrlSetConstantThumbHeight"), typeof(_GuiScrollCtrlSetConstantThumbHeight));
            }

            _GuiScrollCtrlSetConstantThumbHeightFunc(ctrl, useConstantThumbHeight);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiScrollCtrlGetChildMargin(IntPtr ctrl, out Point2I outMargin);
         private static _GuiScrollCtrlGetChildMargin _GuiScrollCtrlGetChildMarginFunc;
         internal static void GuiScrollCtrlGetChildMargin(IntPtr ctrl, out Point2I outMargin)
         {
            if (_GuiScrollCtrlGetChildMarginFunc == null)
            {
               _GuiScrollCtrlGetChildMarginFunc =
                  (_GuiScrollCtrlGetChildMargin)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScrollCtrlGetChildMargin"), typeof(_GuiScrollCtrlGetChildMargin));
            }

            _GuiScrollCtrlGetChildMarginFunc(ctrl, out outMargin);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiScrollCtrlSetChildMargin(IntPtr ctrl, Point2I margin);
         private static _GuiScrollCtrlSetChildMargin _GuiScrollCtrlSetChildMarginFunc;
         internal static void GuiScrollCtrlSetChildMargin(IntPtr ctrl, Point2I margin)
         {
            if (_GuiScrollCtrlSetChildMarginFunc == null)
            {
               _GuiScrollCtrlSetChildMarginFunc =
                  (_GuiScrollCtrlSetChildMargin)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScrollCtrlSetChildMargin"), typeof(_GuiScrollCtrlSetChildMargin));
            }

            _GuiScrollCtrlSetChildMarginFunc(ctrl, margin);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiScrollCtrlCreateInstance();
         private static _GuiScrollCtrlCreateInstance _GuiScrollCtrlCreateInstanceFunc;
         internal static IntPtr GuiScrollCtrlCreateInstance()
         {
            if (_GuiScrollCtrlCreateInstanceFunc == null)
            {
               _GuiScrollCtrlCreateInstanceFunc =
                  (_GuiScrollCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScrollCtrlCreateInstance"), typeof(_GuiScrollCtrlCreateInstance));
            }

            return _GuiScrollCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiScrollCtrlScrollToTop(IntPtr ctrl);
         private static _GuiScrollCtrlScrollToTop _GuiScrollCtrlScrollToTopFunc;
         internal static void GuiScrollCtrlScrollToTop(IntPtr ctrl)
         {
            if (_GuiScrollCtrlScrollToTopFunc == null)
            {
               _GuiScrollCtrlScrollToTopFunc =
                  (_GuiScrollCtrlScrollToTop)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScrollCtrlScrollToTop"), typeof(_GuiScrollCtrlScrollToTop));
            }

            _GuiScrollCtrlScrollToTopFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiScrollCtrlScrollToBottom(IntPtr ctrl);
         private static _GuiScrollCtrlScrollToBottom _GuiScrollCtrlScrollToBottomFunc;
         internal static void GuiScrollCtrlScrollToBottom(IntPtr ctrl)
         {
            if (_GuiScrollCtrlScrollToBottomFunc == null)
            {
               _GuiScrollCtrlScrollToBottomFunc =
                  (_GuiScrollCtrlScrollToBottom)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScrollCtrlScrollToBottom"), typeof(_GuiScrollCtrlScrollToBottom));
            }

            _GuiScrollCtrlScrollToBottomFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiScrollCtrlSetScrollPosition(IntPtr ctrl, Point2I pos);
         private static _GuiScrollCtrlSetScrollPosition _GuiScrollCtrlSetScrollPositionFunc;
         internal static void GuiScrollCtrlSetScrollPosition(IntPtr ctrl, Point2I pos)
         {
            if (_GuiScrollCtrlSetScrollPositionFunc == null)
            {
               _GuiScrollCtrlSetScrollPositionFunc =
                  (_GuiScrollCtrlSetScrollPosition)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScrollCtrlSetScrollPosition"), typeof(_GuiScrollCtrlSetScrollPosition));
            }

            _GuiScrollCtrlSetScrollPositionFunc(ctrl, pos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiScrollCtrlGetScrollPositionX(IntPtr ctrl);
         private static _GuiScrollCtrlGetScrollPositionX _GuiScrollCtrlGetScrollPositionXFunc;
         internal static int GuiScrollCtrlGetScrollPositionX(IntPtr ctrl)
         {
            if (_GuiScrollCtrlGetScrollPositionXFunc == null)
            {
               _GuiScrollCtrlGetScrollPositionXFunc =
                  (_GuiScrollCtrlGetScrollPositionX)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScrollCtrlGetScrollPositionX"), typeof(_GuiScrollCtrlGetScrollPositionX));
            }

            return _GuiScrollCtrlGetScrollPositionXFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiScrollCtrlGetScrollPositionY(IntPtr ctrl);
         private static _GuiScrollCtrlGetScrollPositionY _GuiScrollCtrlGetScrollPositionYFunc;
         internal static int GuiScrollCtrlGetScrollPositionY(IntPtr ctrl)
         {
            if (_GuiScrollCtrlGetScrollPositionYFunc == null)
            {
               _GuiScrollCtrlGetScrollPositionYFunc =
                  (_GuiScrollCtrlGetScrollPositionY)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScrollCtrlGetScrollPositionY"), typeof(_GuiScrollCtrlGetScrollPositionY));
            }

            return _GuiScrollCtrlGetScrollPositionYFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiScrollCtrlComputeSizes(IntPtr ctrl);
         private static _GuiScrollCtrlComputeSizes _GuiScrollCtrlComputeSizesFunc;
         internal static void GuiScrollCtrlComputeSizes(IntPtr ctrl)
         {
            if (_GuiScrollCtrlComputeSizesFunc == null)
            {
               _GuiScrollCtrlComputeSizesFunc =
                  (_GuiScrollCtrlComputeSizes)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScrollCtrlComputeSizes"), typeof(_GuiScrollCtrlComputeSizes));
            }

            _GuiScrollCtrlComputeSizesFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiScrollCtrlGetUseScrollEvents(IntPtr ctrl);
         private static _GuiScrollCtrlGetUseScrollEvents _GuiScrollCtrlGetUseScrollEventsFunc;
         internal static bool GuiScrollCtrlGetUseScrollEvents(IntPtr ctrl)
         {
            if (_GuiScrollCtrlGetUseScrollEventsFunc == null)
            {
               _GuiScrollCtrlGetUseScrollEventsFunc =
                  (_GuiScrollCtrlGetUseScrollEvents)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScrollCtrlGetUseScrollEvents"), typeof(_GuiScrollCtrlGetUseScrollEvents));
            }

            return _GuiScrollCtrlGetUseScrollEventsFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiScrollCtrlSetUseScrollEvents(IntPtr ctrl, bool useScrollEvents);
         private static _GuiScrollCtrlSetUseScrollEvents _GuiScrollCtrlSetUseScrollEventsFunc;
         internal static void GuiScrollCtrlSetUseScrollEvents(IntPtr ctrl, bool useScrollEvents)
         {
            if (_GuiScrollCtrlSetUseScrollEventsFunc == null)
            {
               _GuiScrollCtrlSetUseScrollEventsFunc =
                  (_GuiScrollCtrlSetUseScrollEvents)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScrollCtrlSetUseScrollEvents"), typeof(_GuiScrollCtrlSetUseScrollEvents));
            }

            _GuiScrollCtrlSetUseScrollEventsFunc(ctrl, useScrollEvents);
         }
      }
      
      #endregion

      #region Properties

      public bool WillFirstRespond
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiScrollCtrlGetWillFirstRespond(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiScrollCtrlSetWillFirstRespond(ObjectPtr->ObjPtr, value);
         }
      }
      public int HScrollBar
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiScrollCtrlGetHScrollBar(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiScrollCtrlSetHScrollBar(ObjectPtr->ObjPtr, value);
         }
      }
      public int VScrollBar
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiScrollCtrlGetVScrollBar(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiScrollCtrlSetVScrollBar(ObjectPtr->ObjPtr, value);
         }
      }
      public bool ConstantThumbHeight
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiScrollCtrlGetConstantThumbHeight(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiScrollCtrlSetConstantThumbHeight(ObjectPtr->ObjPtr, value);
         }
      }
      public Point2I ChildMargin
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Point2I outVal;
            InternalUnsafeMethods.GuiScrollCtrlGetChildMargin(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiScrollCtrlSetChildMargin(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public void ScrollToTop()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiScrollCtrlScrollToTop(ObjectPtr->ObjPtr);
      }

      public void ScrollToBottom()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiScrollCtrlScrollToBottom(ObjectPtr->ObjPtr);
      }

      public void SetScrollPosition(Point2I pos)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiScrollCtrlSetScrollPosition(ObjectPtr->ObjPtr, pos);
      }

      public int GetScrollPositionX()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiScrollCtrlGetScrollPositionX(ObjectPtr->ObjPtr);
      }

      public int GetScrollPositionY()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiScrollCtrlGetScrollPositionY(ObjectPtr->ObjPtr);
      }

      public void ComputeSizes()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiScrollCtrlComputeSizes(ObjectPtr->ObjPtr);
      }

      public bool GetUseScrollEvents()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiScrollCtrlGetUseScrollEvents(ObjectPtr->ObjPtr);
      }

      public void SetUseScrollEvents(bool useScrollEvents)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiScrollCtrlSetUseScrollEvents(ObjectPtr->ObjPtr, useScrollEvents);
      }
      
      #endregion

      
   }
}