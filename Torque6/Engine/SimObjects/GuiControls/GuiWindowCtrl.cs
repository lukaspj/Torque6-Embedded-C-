using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiWindowCtrl : GuiTextCtrl
   {
      
      public GuiWindowCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiWindowCtrlCreateInstance());
      }

      public GuiWindowCtrl(uint pId) : base(pId)
      {
      }

      public GuiWindowCtrl(string pName) : base(pName)
      {
      }

      public GuiWindowCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiWindowCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiWindowCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiWindowCtrlGetResizeWidth(IntPtr ctrl);
         private static _GuiWindowCtrlGetResizeWidth _GuiWindowCtrlGetResizeWidthFunc;
         internal static bool GuiWindowCtrlGetResizeWidth(IntPtr ctrl)
         {
            if (_GuiWindowCtrlGetResizeWidthFunc == null)
            {
               _GuiWindowCtrlGetResizeWidthFunc =
                  (_GuiWindowCtrlGetResizeWidth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiWindowCtrlGetResizeWidth"), typeof(_GuiWindowCtrlGetResizeWidth));
            }

            return _GuiWindowCtrlGetResizeWidthFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiWindowCtrlSetResizeWidth(IntPtr ctrl, bool enable);
         private static _GuiWindowCtrlSetResizeWidth _GuiWindowCtrlSetResizeWidthFunc;
         internal static void GuiWindowCtrlSetResizeWidth(IntPtr ctrl, bool enable)
         {
            if (_GuiWindowCtrlSetResizeWidthFunc == null)
            {
               _GuiWindowCtrlSetResizeWidthFunc =
                  (_GuiWindowCtrlSetResizeWidth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiWindowCtrlSetResizeWidth"), typeof(_GuiWindowCtrlSetResizeWidth));
            }

            _GuiWindowCtrlSetResizeWidthFunc(ctrl, enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiWindowCtrlGetResizeHeight(IntPtr ctrl);
         private static _GuiWindowCtrlGetResizeHeight _GuiWindowCtrlGetResizeHeightFunc;
         internal static bool GuiWindowCtrlGetResizeHeight(IntPtr ctrl)
         {
            if (_GuiWindowCtrlGetResizeHeightFunc == null)
            {
               _GuiWindowCtrlGetResizeHeightFunc =
                  (_GuiWindowCtrlGetResizeHeight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiWindowCtrlGetResizeHeight"), typeof(_GuiWindowCtrlGetResizeHeight));
            }

            return _GuiWindowCtrlGetResizeHeightFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiWindowCtrlSetResizeHeight(IntPtr ctrl, bool enable);
         private static _GuiWindowCtrlSetResizeHeight _GuiWindowCtrlSetResizeHeightFunc;
         internal static void GuiWindowCtrlSetResizeHeight(IntPtr ctrl, bool enable)
         {
            if (_GuiWindowCtrlSetResizeHeightFunc == null)
            {
               _GuiWindowCtrlSetResizeHeightFunc =
                  (_GuiWindowCtrlSetResizeHeight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiWindowCtrlSetResizeHeight"), typeof(_GuiWindowCtrlSetResizeHeight));
            }

            _GuiWindowCtrlSetResizeHeightFunc(ctrl, enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiWindowCtrlGetCanMove(IntPtr ctrl);
         private static _GuiWindowCtrlGetCanMove _GuiWindowCtrlGetCanMoveFunc;
         internal static bool GuiWindowCtrlGetCanMove(IntPtr ctrl)
         {
            if (_GuiWindowCtrlGetCanMoveFunc == null)
            {
               _GuiWindowCtrlGetCanMoveFunc =
                  (_GuiWindowCtrlGetCanMove)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiWindowCtrlGetCanMove"), typeof(_GuiWindowCtrlGetCanMove));
            }

            return _GuiWindowCtrlGetCanMoveFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiWindowCtrlSetCanMove(IntPtr ctrl, bool enable);
         private static _GuiWindowCtrlSetCanMove _GuiWindowCtrlSetCanMoveFunc;
         internal static void GuiWindowCtrlSetCanMove(IntPtr ctrl, bool enable)
         {
            if (_GuiWindowCtrlSetCanMoveFunc == null)
            {
               _GuiWindowCtrlSetCanMoveFunc =
                  (_GuiWindowCtrlSetCanMove)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiWindowCtrlSetCanMove"), typeof(_GuiWindowCtrlSetCanMove));
            }

            _GuiWindowCtrlSetCanMoveFunc(ctrl, enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiWindowCtrlGetCanClose(IntPtr ctrl);
         private static _GuiWindowCtrlGetCanClose _GuiWindowCtrlGetCanCloseFunc;
         internal static bool GuiWindowCtrlGetCanClose(IntPtr ctrl)
         {
            if (_GuiWindowCtrlGetCanCloseFunc == null)
            {
               _GuiWindowCtrlGetCanCloseFunc =
                  (_GuiWindowCtrlGetCanClose)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiWindowCtrlGetCanClose"), typeof(_GuiWindowCtrlGetCanClose));
            }

            return _GuiWindowCtrlGetCanCloseFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiWindowCtrlSetCanClose(IntPtr ctrl, bool enable);
         private static _GuiWindowCtrlSetCanClose _GuiWindowCtrlSetCanCloseFunc;
         internal static void GuiWindowCtrlSetCanClose(IntPtr ctrl, bool enable)
         {
            if (_GuiWindowCtrlSetCanCloseFunc == null)
            {
               _GuiWindowCtrlSetCanCloseFunc =
                  (_GuiWindowCtrlSetCanClose)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiWindowCtrlSetCanClose"), typeof(_GuiWindowCtrlSetCanClose));
            }

            _GuiWindowCtrlSetCanCloseFunc(ctrl, enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiWindowCtrlGetCanMinimize(IntPtr ctrl);
         private static _GuiWindowCtrlGetCanMinimize _GuiWindowCtrlGetCanMinimizeFunc;
         internal static bool GuiWindowCtrlGetCanMinimize(IntPtr ctrl)
         {
            if (_GuiWindowCtrlGetCanMinimizeFunc == null)
            {
               _GuiWindowCtrlGetCanMinimizeFunc =
                  (_GuiWindowCtrlGetCanMinimize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiWindowCtrlGetCanMinimize"), typeof(_GuiWindowCtrlGetCanMinimize));
            }

            return _GuiWindowCtrlGetCanMinimizeFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiWindowCtrlSetCanMinimize(IntPtr ctrl, bool enable);
         private static _GuiWindowCtrlSetCanMinimize _GuiWindowCtrlSetCanMinimizeFunc;
         internal static void GuiWindowCtrlSetCanMinimize(IntPtr ctrl, bool enable)
         {
            if (_GuiWindowCtrlSetCanMinimizeFunc == null)
            {
               _GuiWindowCtrlSetCanMinimizeFunc =
                  (_GuiWindowCtrlSetCanMinimize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiWindowCtrlSetCanMinimize"), typeof(_GuiWindowCtrlSetCanMinimize));
            }

            _GuiWindowCtrlSetCanMinimizeFunc(ctrl, enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiWindowCtrlGetCanMaximize(IntPtr ctrl);
         private static _GuiWindowCtrlGetCanMaximize _GuiWindowCtrlGetCanMaximizeFunc;
         internal static bool GuiWindowCtrlGetCanMaximize(IntPtr ctrl)
         {
            if (_GuiWindowCtrlGetCanMaximizeFunc == null)
            {
               _GuiWindowCtrlGetCanMaximizeFunc =
                  (_GuiWindowCtrlGetCanMaximize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiWindowCtrlGetCanMaximize"), typeof(_GuiWindowCtrlGetCanMaximize));
            }

            return _GuiWindowCtrlGetCanMaximizeFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiWindowCtrlSetCanMaximize(IntPtr ctrl, bool enable);
         private static _GuiWindowCtrlSetCanMaximize _GuiWindowCtrlSetCanMaximizeFunc;
         internal static void GuiWindowCtrlSetCanMaximize(IntPtr ctrl, bool enable)
         {
            if (_GuiWindowCtrlSetCanMaximizeFunc == null)
            {
               _GuiWindowCtrlSetCanMaximizeFunc =
                  (_GuiWindowCtrlSetCanMaximize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiWindowCtrlSetCanMaximize"), typeof(_GuiWindowCtrlSetCanMaximize));
            }

            _GuiWindowCtrlSetCanMaximizeFunc(ctrl, enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiWindowCtrlGetMinSize(IntPtr ctrl, out Point2I outSize);
         private static _GuiWindowCtrlGetMinSize _GuiWindowCtrlGetMinSizeFunc;
         internal static void GuiWindowCtrlGetMinSize(IntPtr ctrl, out Point2I outSize)
         {
            if (_GuiWindowCtrlGetMinSizeFunc == null)
            {
               _GuiWindowCtrlGetMinSizeFunc =
                  (_GuiWindowCtrlGetMinSize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiWindowCtrlGetMinSize"), typeof(_GuiWindowCtrlGetMinSize));
            }

            _GuiWindowCtrlGetMinSizeFunc(ctrl, out outSize);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiWindowCtrlSetMinSize(IntPtr ctrl, Point2I size);
         private static _GuiWindowCtrlSetMinSize _GuiWindowCtrlSetMinSizeFunc;
         internal static void GuiWindowCtrlSetMinSize(IntPtr ctrl, Point2I size)
         {
            if (_GuiWindowCtrlSetMinSizeFunc == null)
            {
               _GuiWindowCtrlSetMinSizeFunc =
                  (_GuiWindowCtrlSetMinSize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiWindowCtrlSetMinSize"), typeof(_GuiWindowCtrlSetMinSize));
            }

            _GuiWindowCtrlSetMinSizeFunc(ctrl, size);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiWindowCtrlGetCloseCommand(IntPtr ctrl);
         private static _GuiWindowCtrlGetCloseCommand _GuiWindowCtrlGetCloseCommandFunc;
         internal static IntPtr GuiWindowCtrlGetCloseCommand(IntPtr ctrl)
         {
            if (_GuiWindowCtrlGetCloseCommandFunc == null)
            {
               _GuiWindowCtrlGetCloseCommandFunc =
                  (_GuiWindowCtrlGetCloseCommand)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiWindowCtrlGetCloseCommand"), typeof(_GuiWindowCtrlGetCloseCommand));
            }

            return _GuiWindowCtrlGetCloseCommandFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiWindowCtrlSetCloseCommand(IntPtr ctrl, string command);
         private static _GuiWindowCtrlSetCloseCommand _GuiWindowCtrlSetCloseCommandFunc;
         internal static void GuiWindowCtrlSetCloseCommand(IntPtr ctrl, string command)
         {
            if (_GuiWindowCtrlSetCloseCommandFunc == null)
            {
               _GuiWindowCtrlSetCloseCommandFunc =
                  (_GuiWindowCtrlSetCloseCommand)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiWindowCtrlSetCloseCommand"), typeof(_GuiWindowCtrlSetCloseCommand));
            }

            _GuiWindowCtrlSetCloseCommandFunc(ctrl, command);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiWindowCtrlCreateInstance();
         private static _GuiWindowCtrlCreateInstance _GuiWindowCtrlCreateInstanceFunc;
         internal static IntPtr GuiWindowCtrlCreateInstance()
         {
            if (_GuiWindowCtrlCreateInstanceFunc == null)
            {
               _GuiWindowCtrlCreateInstanceFunc =
                  (_GuiWindowCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiWindowCtrlCreateInstance"), typeof(_GuiWindowCtrlCreateInstance));
            }

            return _GuiWindowCtrlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public bool ResizeWidth
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiWindowCtrlGetResizeWidth(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiWindowCtrlSetResizeWidth(ObjectPtr->ObjPtr, value);
         }
      }
      public bool ResizeHeight
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiWindowCtrlGetResizeHeight(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiWindowCtrlSetResizeHeight(ObjectPtr->ObjPtr, value);
         }
      }
      public bool CanMove
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiWindowCtrlGetCanMove(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiWindowCtrlSetCanMove(ObjectPtr->ObjPtr, value);
         }
      }
      public bool CanClose
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiWindowCtrlGetCanClose(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiWindowCtrlSetCanClose(ObjectPtr->ObjPtr, value);
         }
      }
      public bool CanMinimize
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiWindowCtrlGetCanMinimize(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiWindowCtrlSetCanMinimize(ObjectPtr->ObjPtr, value);
         }
      }
      public bool CanMaximize
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiWindowCtrlGetCanMaximize(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiWindowCtrlSetCanMaximize(ObjectPtr->ObjPtr, value);
         }
      }
      public Point2I MinSize
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Point2I outVal;
            InternalUnsafeMethods.GuiWindowCtrlGetMinSize(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiWindowCtrlSetMinSize(ObjectPtr->ObjPtr, value);
         }
      }
      public string CloseCommand
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiWindowCtrlGetCloseCommand(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiWindowCtrlSetCloseCommand(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}