using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiToolboxButtonCtrl : GuiButtonCtrl
   {
      
      public GuiToolboxButtonCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiToolboxButtonCtrlCreateInstance());
      }

      public GuiToolboxButtonCtrl(uint pId) : base(pId)
      {
      }

      public GuiToolboxButtonCtrl(string pName) : base(pName)
      {
      }

      public GuiToolboxButtonCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiToolboxButtonCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiToolboxButtonCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiToolboxButtonCtrlGetNormalBitmap(IntPtr ctrl);
         private static _GuiToolboxButtonCtrlGetNormalBitmap _GuiToolboxButtonCtrlGetNormalBitmapFunc;
         internal static IntPtr GuiToolboxButtonCtrlGetNormalBitmap(IntPtr ctrl)
         {
            if (_GuiToolboxButtonCtrlGetNormalBitmapFunc == null)
            {
               _GuiToolboxButtonCtrlGetNormalBitmapFunc =
                  (_GuiToolboxButtonCtrlGetNormalBitmap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiToolboxButtonCtrlGetNormalBitmap"), typeof(_GuiToolboxButtonCtrlGetNormalBitmap));
            }

            return _GuiToolboxButtonCtrlGetNormalBitmapFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiToolboxButtonCtrlSetNormalBitmap(IntPtr ctrl, string bitmap);
         private static _GuiToolboxButtonCtrlSetNormalBitmap _GuiToolboxButtonCtrlSetNormalBitmapFunc;
         internal static void GuiToolboxButtonCtrlSetNormalBitmap(IntPtr ctrl, string bitmap)
         {
            if (_GuiToolboxButtonCtrlSetNormalBitmapFunc == null)
            {
               _GuiToolboxButtonCtrlSetNormalBitmapFunc =
                  (_GuiToolboxButtonCtrlSetNormalBitmap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiToolboxButtonCtrlSetNormalBitmap"), typeof(_GuiToolboxButtonCtrlSetNormalBitmap));
            }

            _GuiToolboxButtonCtrlSetNormalBitmapFunc(ctrl, bitmap);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiToolboxButtonCtrlGetLoweredBitmap(IntPtr ctrl);
         private static _GuiToolboxButtonCtrlGetLoweredBitmap _GuiToolboxButtonCtrlGetLoweredBitmapFunc;
         internal static IntPtr GuiToolboxButtonCtrlGetLoweredBitmap(IntPtr ctrl)
         {
            if (_GuiToolboxButtonCtrlGetLoweredBitmapFunc == null)
            {
               _GuiToolboxButtonCtrlGetLoweredBitmapFunc =
                  (_GuiToolboxButtonCtrlGetLoweredBitmap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiToolboxButtonCtrlGetLoweredBitmap"), typeof(_GuiToolboxButtonCtrlGetLoweredBitmap));
            }

            return _GuiToolboxButtonCtrlGetLoweredBitmapFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiToolboxButtonCtrlSetLoweredBitmap(IntPtr ctrl, string bitmap);
         private static _GuiToolboxButtonCtrlSetLoweredBitmap _GuiToolboxButtonCtrlSetLoweredBitmapFunc;
         internal static void GuiToolboxButtonCtrlSetLoweredBitmap(IntPtr ctrl, string bitmap)
         {
            if (_GuiToolboxButtonCtrlSetLoweredBitmapFunc == null)
            {
               _GuiToolboxButtonCtrlSetLoweredBitmapFunc =
                  (_GuiToolboxButtonCtrlSetLoweredBitmap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiToolboxButtonCtrlSetLoweredBitmap"), typeof(_GuiToolboxButtonCtrlSetLoweredBitmap));
            }

            _GuiToolboxButtonCtrlSetLoweredBitmapFunc(ctrl, bitmap);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiToolboxButtonCtrlGetHoverBitmap(IntPtr ctrl);
         private static _GuiToolboxButtonCtrlGetHoverBitmap _GuiToolboxButtonCtrlGetHoverBitmapFunc;
         internal static IntPtr GuiToolboxButtonCtrlGetHoverBitmap(IntPtr ctrl)
         {
            if (_GuiToolboxButtonCtrlGetHoverBitmapFunc == null)
            {
               _GuiToolboxButtonCtrlGetHoverBitmapFunc =
                  (_GuiToolboxButtonCtrlGetHoverBitmap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiToolboxButtonCtrlGetHoverBitmap"), typeof(_GuiToolboxButtonCtrlGetHoverBitmap));
            }

            return _GuiToolboxButtonCtrlGetHoverBitmapFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiToolboxButtonCtrlSetHoverBitmap(IntPtr ctrl, string bitmap);
         private static _GuiToolboxButtonCtrlSetHoverBitmap _GuiToolboxButtonCtrlSetHoverBitmapFunc;
         internal static void GuiToolboxButtonCtrlSetHoverBitmap(IntPtr ctrl, string bitmap)
         {
            if (_GuiToolboxButtonCtrlSetHoverBitmapFunc == null)
            {
               _GuiToolboxButtonCtrlSetHoverBitmapFunc =
                  (_GuiToolboxButtonCtrlSetHoverBitmap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiToolboxButtonCtrlSetHoverBitmap"), typeof(_GuiToolboxButtonCtrlSetHoverBitmap));
            }

            _GuiToolboxButtonCtrlSetHoverBitmapFunc(ctrl, bitmap);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiToolboxButtonCtrlCreateInstance();
         private static _GuiToolboxButtonCtrlCreateInstance _GuiToolboxButtonCtrlCreateInstanceFunc;
         internal static IntPtr GuiToolboxButtonCtrlCreateInstance()
         {
            if (_GuiToolboxButtonCtrlCreateInstanceFunc == null)
            {
               _GuiToolboxButtonCtrlCreateInstanceFunc =
                  (_GuiToolboxButtonCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiToolboxButtonCtrlCreateInstance"), typeof(_GuiToolboxButtonCtrlCreateInstance));
            }

            return _GuiToolboxButtonCtrlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string NormalBitmap
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiToolboxButtonCtrlGetNormalBitmap(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiToolboxButtonCtrlSetNormalBitmap(ObjectPtr->ObjPtr, value);
         }
      }
      public string LoweredBitmap
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiToolboxButtonCtrlGetLoweredBitmap(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiToolboxButtonCtrlSetLoweredBitmap(ObjectPtr->ObjPtr, value);
         }
      }
      public string HoverBitmap
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiToolboxButtonCtrlGetHoverBitmap(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiToolboxButtonCtrlSetHoverBitmap(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}