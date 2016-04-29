using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiControlArrayControl : GuiControl
   {
      
      public GuiControlArrayControl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiControlArrayControlCreateInstance());
      }

      public GuiControlArrayControl(uint pId) : base(pId)
      {
      }

      public GuiControlArrayControl(string pName) : base(pName)
      {
      }

      public GuiControlArrayControl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiControlArrayControl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiControlArrayControl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiControlArrayControlGetColCount(IntPtr ctrl);
         private static _GuiControlArrayControlGetColCount _GuiControlArrayControlGetColCountFunc;
         internal static int GuiControlArrayControlGetColCount(IntPtr ctrl)
         {
            if (_GuiControlArrayControlGetColCountFunc == null)
            {
               _GuiControlArrayControlGetColCountFunc =
                  (_GuiControlArrayControlGetColCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlArrayControlGetColCount"), typeof(_GuiControlArrayControlGetColCount));
            }

            return _GuiControlArrayControlGetColCountFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlArrayControlSetColCount(IntPtr ctrl, int cols);
         private static _GuiControlArrayControlSetColCount _GuiControlArrayControlSetColCountFunc;
         internal static void GuiControlArrayControlSetColCount(IntPtr ctrl, int cols)
         {
            if (_GuiControlArrayControlSetColCountFunc == null)
            {
               _GuiControlArrayControlSetColCountFunc =
                  (_GuiControlArrayControlSetColCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlArrayControlSetColCount"), typeof(_GuiControlArrayControlSetColCount));
            }

            _GuiControlArrayControlSetColCountFunc(ctrl, cols);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiControlArrayControlGetRowSize(IntPtr ctrl);
         private static _GuiControlArrayControlGetRowSize _GuiControlArrayControlGetRowSizeFunc;
         internal static int GuiControlArrayControlGetRowSize(IntPtr ctrl)
         {
            if (_GuiControlArrayControlGetRowSizeFunc == null)
            {
               _GuiControlArrayControlGetRowSizeFunc =
                  (_GuiControlArrayControlGetRowSize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlArrayControlGetRowSize"), typeof(_GuiControlArrayControlGetRowSize));
            }

            return _GuiControlArrayControlGetRowSizeFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlArrayControlSetRowSize(IntPtr ctrl, int size);
         private static _GuiControlArrayControlSetRowSize _GuiControlArrayControlSetRowSizeFunc;
         internal static void GuiControlArrayControlSetRowSize(IntPtr ctrl, int size)
         {
            if (_GuiControlArrayControlSetRowSizeFunc == null)
            {
               _GuiControlArrayControlSetRowSizeFunc =
                  (_GuiControlArrayControlSetRowSize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlArrayControlSetRowSize"), typeof(_GuiControlArrayControlSetRowSize));
            }

            _GuiControlArrayControlSetRowSizeFunc(ctrl, size);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiControlArrayControlGetRowSpacing(IntPtr ctrl);
         private static _GuiControlArrayControlGetRowSpacing _GuiControlArrayControlGetRowSpacingFunc;
         internal static int GuiControlArrayControlGetRowSpacing(IntPtr ctrl)
         {
            if (_GuiControlArrayControlGetRowSpacingFunc == null)
            {
               _GuiControlArrayControlGetRowSpacingFunc =
                  (_GuiControlArrayControlGetRowSpacing)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlArrayControlGetRowSpacing"), typeof(_GuiControlArrayControlGetRowSpacing));
            }

            return _GuiControlArrayControlGetRowSpacingFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlArrayControlSetRowSpacing(IntPtr ctrl, int spacing);
         private static _GuiControlArrayControlSetRowSpacing _GuiControlArrayControlSetRowSpacingFunc;
         internal static void GuiControlArrayControlSetRowSpacing(IntPtr ctrl, int spacing)
         {
            if (_GuiControlArrayControlSetRowSpacingFunc == null)
            {
               _GuiControlArrayControlSetRowSpacingFunc =
                  (_GuiControlArrayControlSetRowSpacing)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlArrayControlSetRowSpacing"), typeof(_GuiControlArrayControlSetRowSpacing));
            }

            _GuiControlArrayControlSetRowSpacingFunc(ctrl, spacing);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiControlArrayControlGetColSpacing(IntPtr ctrl);
         private static _GuiControlArrayControlGetColSpacing _GuiControlArrayControlGetColSpacingFunc;
         internal static int GuiControlArrayControlGetColSpacing(IntPtr ctrl)
         {
            if (_GuiControlArrayControlGetColSpacingFunc == null)
            {
               _GuiControlArrayControlGetColSpacingFunc =
                  (_GuiControlArrayControlGetColSpacing)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlArrayControlGetColSpacing"), typeof(_GuiControlArrayControlGetColSpacing));
            }

            return _GuiControlArrayControlGetColSpacingFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlArrayControlSetColSpacing(IntPtr ctrl, int spacing);
         private static _GuiControlArrayControlSetColSpacing _GuiControlArrayControlSetColSpacingFunc;
         internal static void GuiControlArrayControlSetColSpacing(IntPtr ctrl, int spacing)
         {
            if (_GuiControlArrayControlSetColSpacingFunc == null)
            {
               _GuiControlArrayControlSetColSpacingFunc =
                  (_GuiControlArrayControlSetColSpacing)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlArrayControlSetColSpacing"), typeof(_GuiControlArrayControlSetColSpacing));
            }

            _GuiControlArrayControlSetColSpacingFunc(ctrl, spacing);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlArrayControlCreateInstance();
         private static _GuiControlArrayControlCreateInstance _GuiControlArrayControlCreateInstanceFunc;
         internal static IntPtr GuiControlArrayControlCreateInstance()
         {
            if (_GuiControlArrayControlCreateInstanceFunc == null)
            {
               _GuiControlArrayControlCreateInstanceFunc =
                  (_GuiControlArrayControlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlArrayControlCreateInstance"), typeof(_GuiControlArrayControlCreateInstance));
            }

            return _GuiControlArrayControlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public int ColCount
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlArrayControlGetColCount(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlArrayControlSetColCount(ObjectPtr->ObjPtr, value);
         }
      }
      public int RowSize
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlArrayControlGetRowSize(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlArrayControlSetRowSize(ObjectPtr->ObjPtr, value);
         }
      }
      public int RowSpacing
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlArrayControlGetRowSpacing(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlArrayControlSetRowSpacing(ObjectPtr->ObjPtr, value);
         }
      }
      public int ColSpacing
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlArrayControlGetColSpacing(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlArrayControlSetColSpacing(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}