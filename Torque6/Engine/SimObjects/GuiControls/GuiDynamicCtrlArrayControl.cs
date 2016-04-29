using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiDynamicCtrlArrayControl : GuiControl
   {
      
      public GuiDynamicCtrlArrayControl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiDynamicCtrlArrayControlCreateInstance());
      }

      public GuiDynamicCtrlArrayControl(uint pId) : base(pId)
      {
      }

      public GuiDynamicCtrlArrayControl(string pName) : base(pName)
      {
      }

      public GuiDynamicCtrlArrayControl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiDynamicCtrlArrayControl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiDynamicCtrlArrayControl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiDynamicCtrlArrayControlGetColCount(IntPtr ctrl);
         private static _GuiDynamicCtrlArrayControlGetColCount _GuiDynamicCtrlArrayControlGetColCountFunc;
         internal static int GuiDynamicCtrlArrayControlGetColCount(IntPtr ctrl)
         {
            if (_GuiDynamicCtrlArrayControlGetColCountFunc == null)
            {
               _GuiDynamicCtrlArrayControlGetColCountFunc =
                  (_GuiDynamicCtrlArrayControlGetColCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiDynamicCtrlArrayControlGetColCount"), typeof(_GuiDynamicCtrlArrayControlGetColCount));
            }

            return _GuiDynamicCtrlArrayControlGetColCountFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiDynamicCtrlArrayControlSetColCount(IntPtr ctrl, int cols);
         private static _GuiDynamicCtrlArrayControlSetColCount _GuiDynamicCtrlArrayControlSetColCountFunc;
         internal static void GuiDynamicCtrlArrayControlSetColCount(IntPtr ctrl, int cols)
         {
            if (_GuiDynamicCtrlArrayControlSetColCountFunc == null)
            {
               _GuiDynamicCtrlArrayControlSetColCountFunc =
                  (_GuiDynamicCtrlArrayControlSetColCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiDynamicCtrlArrayControlSetColCount"), typeof(_GuiDynamicCtrlArrayControlSetColCount));
            }

            _GuiDynamicCtrlArrayControlSetColCountFunc(ctrl, cols);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiDynamicCtrlArrayControlGetColSize(IntPtr ctrl);
         private static _GuiDynamicCtrlArrayControlGetColSize _GuiDynamicCtrlArrayControlGetColSizeFunc;
         internal static int GuiDynamicCtrlArrayControlGetColSize(IntPtr ctrl)
         {
            if (_GuiDynamicCtrlArrayControlGetColSizeFunc == null)
            {
               _GuiDynamicCtrlArrayControlGetColSizeFunc =
                  (_GuiDynamicCtrlArrayControlGetColSize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiDynamicCtrlArrayControlGetColSize"), typeof(_GuiDynamicCtrlArrayControlGetColSize));
            }

            return _GuiDynamicCtrlArrayControlGetColSizeFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiDynamicCtrlArrayControlSetColSize(IntPtr ctrl, int colSize);
         private static _GuiDynamicCtrlArrayControlSetColSize _GuiDynamicCtrlArrayControlSetColSizeFunc;
         internal static void GuiDynamicCtrlArrayControlSetColSize(IntPtr ctrl, int colSize)
         {
            if (_GuiDynamicCtrlArrayControlSetColSizeFunc == null)
            {
               _GuiDynamicCtrlArrayControlSetColSizeFunc =
                  (_GuiDynamicCtrlArrayControlSetColSize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiDynamicCtrlArrayControlSetColSize"), typeof(_GuiDynamicCtrlArrayControlSetColSize));
            }

            _GuiDynamicCtrlArrayControlSetColSizeFunc(ctrl, colSize);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiDynamicCtrlArrayControlGetRowSize(IntPtr ctrl);
         private static _GuiDynamicCtrlArrayControlGetRowSize _GuiDynamicCtrlArrayControlGetRowSizeFunc;
         internal static int GuiDynamicCtrlArrayControlGetRowSize(IntPtr ctrl)
         {
            if (_GuiDynamicCtrlArrayControlGetRowSizeFunc == null)
            {
               _GuiDynamicCtrlArrayControlGetRowSizeFunc =
                  (_GuiDynamicCtrlArrayControlGetRowSize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiDynamicCtrlArrayControlGetRowSize"), typeof(_GuiDynamicCtrlArrayControlGetRowSize));
            }

            return _GuiDynamicCtrlArrayControlGetRowSizeFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiDynamicCtrlArrayControlSetRowSize(IntPtr ctrl, int size);
         private static _GuiDynamicCtrlArrayControlSetRowSize _GuiDynamicCtrlArrayControlSetRowSizeFunc;
         internal static void GuiDynamicCtrlArrayControlSetRowSize(IntPtr ctrl, int size)
         {
            if (_GuiDynamicCtrlArrayControlSetRowSizeFunc == null)
            {
               _GuiDynamicCtrlArrayControlSetRowSizeFunc =
                  (_GuiDynamicCtrlArrayControlSetRowSize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiDynamicCtrlArrayControlSetRowSize"), typeof(_GuiDynamicCtrlArrayControlSetRowSize));
            }

            _GuiDynamicCtrlArrayControlSetRowSizeFunc(ctrl, size);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiDynamicCtrlArrayControlGetRowSpacing(IntPtr ctrl);
         private static _GuiDynamicCtrlArrayControlGetRowSpacing _GuiDynamicCtrlArrayControlGetRowSpacingFunc;
         internal static int GuiDynamicCtrlArrayControlGetRowSpacing(IntPtr ctrl)
         {
            if (_GuiDynamicCtrlArrayControlGetRowSpacingFunc == null)
            {
               _GuiDynamicCtrlArrayControlGetRowSpacingFunc =
                  (_GuiDynamicCtrlArrayControlGetRowSpacing)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiDynamicCtrlArrayControlGetRowSpacing"), typeof(_GuiDynamicCtrlArrayControlGetRowSpacing));
            }

            return _GuiDynamicCtrlArrayControlGetRowSpacingFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiDynamicCtrlArrayControlSetRowSpacing(IntPtr ctrl, int Spacing);
         private static _GuiDynamicCtrlArrayControlSetRowSpacing _GuiDynamicCtrlArrayControlSetRowSpacingFunc;
         internal static void GuiDynamicCtrlArrayControlSetRowSpacing(IntPtr ctrl, int Spacing)
         {
            if (_GuiDynamicCtrlArrayControlSetRowSpacingFunc == null)
            {
               _GuiDynamicCtrlArrayControlSetRowSpacingFunc =
                  (_GuiDynamicCtrlArrayControlSetRowSpacing)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiDynamicCtrlArrayControlSetRowSpacing"), typeof(_GuiDynamicCtrlArrayControlSetRowSpacing));
            }

            _GuiDynamicCtrlArrayControlSetRowSpacingFunc(ctrl, Spacing);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiDynamicCtrlArrayControlGetColSpacing(IntPtr ctrl);
         private static _GuiDynamicCtrlArrayControlGetColSpacing _GuiDynamicCtrlArrayControlGetColSpacingFunc;
         internal static int GuiDynamicCtrlArrayControlGetColSpacing(IntPtr ctrl)
         {
            if (_GuiDynamicCtrlArrayControlGetColSpacingFunc == null)
            {
               _GuiDynamicCtrlArrayControlGetColSpacingFunc =
                  (_GuiDynamicCtrlArrayControlGetColSpacing)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiDynamicCtrlArrayControlGetColSpacing"), typeof(_GuiDynamicCtrlArrayControlGetColSpacing));
            }

            return _GuiDynamicCtrlArrayControlGetColSpacingFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiDynamicCtrlArrayControlSetColSpacing(IntPtr ctrl, int Spacing);
         private static _GuiDynamicCtrlArrayControlSetColSpacing _GuiDynamicCtrlArrayControlSetColSpacingFunc;
         internal static void GuiDynamicCtrlArrayControlSetColSpacing(IntPtr ctrl, int Spacing)
         {
            if (_GuiDynamicCtrlArrayControlSetColSpacingFunc == null)
            {
               _GuiDynamicCtrlArrayControlSetColSpacingFunc =
                  (_GuiDynamicCtrlArrayControlSetColSpacing)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiDynamicCtrlArrayControlSetColSpacing"), typeof(_GuiDynamicCtrlArrayControlSetColSpacing));
            }

            _GuiDynamicCtrlArrayControlSetColSpacingFunc(ctrl, Spacing);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiDynamicCtrlArrayControlCreateInstance();
         private static _GuiDynamicCtrlArrayControlCreateInstance _GuiDynamicCtrlArrayControlCreateInstanceFunc;
         internal static IntPtr GuiDynamicCtrlArrayControlCreateInstance()
         {
            if (_GuiDynamicCtrlArrayControlCreateInstanceFunc == null)
            {
               _GuiDynamicCtrlArrayControlCreateInstanceFunc =
                  (_GuiDynamicCtrlArrayControlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiDynamicCtrlArrayControlCreateInstance"), typeof(_GuiDynamicCtrlArrayControlCreateInstance));
            }

            return _GuiDynamicCtrlArrayControlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiDynamicCtrlArrayControlRefresh(IntPtr ctrl);
         private static _GuiDynamicCtrlArrayControlRefresh _GuiDynamicCtrlArrayControlRefreshFunc;
         internal static void GuiDynamicCtrlArrayControlRefresh(IntPtr ctrl)
         {
            if (_GuiDynamicCtrlArrayControlRefreshFunc == null)
            {
               _GuiDynamicCtrlArrayControlRefreshFunc =
                  (_GuiDynamicCtrlArrayControlRefresh)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiDynamicCtrlArrayControlRefresh"), typeof(_GuiDynamicCtrlArrayControlRefresh));
            }

            _GuiDynamicCtrlArrayControlRefreshFunc(ctrl);
         }
      }
      
      #endregion

      #region Properties

      public int ColCount
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiDynamicCtrlArrayControlGetColCount(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiDynamicCtrlArrayControlSetColCount(ObjectPtr->ObjPtr, value);
         }
      }
      public int ColSize
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiDynamicCtrlArrayControlGetColSize(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiDynamicCtrlArrayControlSetColSize(ObjectPtr->ObjPtr, value);
         }
      }
      public int RowSize
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiDynamicCtrlArrayControlGetRowSize(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiDynamicCtrlArrayControlSetRowSize(ObjectPtr->ObjPtr, value);
         }
      }
      public int RowSpacing
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiDynamicCtrlArrayControlGetRowSpacing(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiDynamicCtrlArrayControlSetRowSpacing(ObjectPtr->ObjPtr, value);
         }
      }
      public int ColSpacing
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiDynamicCtrlArrayControlGetColSpacing(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiDynamicCtrlArrayControlSetColSpacing(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public void Refresh()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiDynamicCtrlArrayControlRefresh(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}