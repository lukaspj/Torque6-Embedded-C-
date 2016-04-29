using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiBitmapButtonCtrl : GuiButtonCtrl
   {
      
      public GuiBitmapButtonCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiBitmapButtonCtrlCreateInstance());
      }

      public GuiBitmapButtonCtrl(uint pId) : base(pId)
      {
      }

      public GuiBitmapButtonCtrl(string pName) : base(pName)
      {
      }

      public GuiBitmapButtonCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiBitmapButtonCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiBitmapButtonCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiBitmapButtonCtrlGetIsLegacyVersion(IntPtr ctrl);
         private static _GuiBitmapButtonCtrlGetIsLegacyVersion _GuiBitmapButtonCtrlGetIsLegacyVersionFunc;
         internal static bool GuiBitmapButtonCtrlGetIsLegacyVersion(IntPtr ctrl)
         {
            if (_GuiBitmapButtonCtrlGetIsLegacyVersionFunc == null)
            {
               _GuiBitmapButtonCtrlGetIsLegacyVersionFunc =
                  (_GuiBitmapButtonCtrlGetIsLegacyVersion)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapButtonCtrlGetIsLegacyVersion"), typeof(_GuiBitmapButtonCtrlGetIsLegacyVersion));
            }

            return _GuiBitmapButtonCtrlGetIsLegacyVersionFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiBitmapButtonCtrlSetIsLegacyVersion(IntPtr ctrl, bool isLegacy);
         private static _GuiBitmapButtonCtrlSetIsLegacyVersion _GuiBitmapButtonCtrlSetIsLegacyVersionFunc;
         internal static void GuiBitmapButtonCtrlSetIsLegacyVersion(IntPtr ctrl, bool isLegacy)
         {
            if (_GuiBitmapButtonCtrlSetIsLegacyVersionFunc == null)
            {
               _GuiBitmapButtonCtrlSetIsLegacyVersionFunc =
                  (_GuiBitmapButtonCtrlSetIsLegacyVersion)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapButtonCtrlSetIsLegacyVersion"), typeof(_GuiBitmapButtonCtrlSetIsLegacyVersion));
            }

            _GuiBitmapButtonCtrlSetIsLegacyVersionFunc(ctrl, isLegacy);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiBitmapButtonCtrlGetBitmap(IntPtr ctrl);
         private static _GuiBitmapButtonCtrlGetBitmap _GuiBitmapButtonCtrlGetBitmapFunc;
         internal static IntPtr GuiBitmapButtonCtrlGetBitmap(IntPtr ctrl)
         {
            if (_GuiBitmapButtonCtrlGetBitmapFunc == null)
            {
               _GuiBitmapButtonCtrlGetBitmapFunc =
                  (_GuiBitmapButtonCtrlGetBitmap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapButtonCtrlGetBitmap"), typeof(_GuiBitmapButtonCtrlGetBitmap));
            }

            return _GuiBitmapButtonCtrlGetBitmapFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiBitmapButtonCtrlSetBitmap(IntPtr ctrl, string bitmap);
         private static _GuiBitmapButtonCtrlSetBitmap _GuiBitmapButtonCtrlSetBitmapFunc;
         internal static void GuiBitmapButtonCtrlSetBitmap(IntPtr ctrl, string bitmap)
         {
            if (_GuiBitmapButtonCtrlSetBitmapFunc == null)
            {
               _GuiBitmapButtonCtrlSetBitmapFunc =
                  (_GuiBitmapButtonCtrlSetBitmap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapButtonCtrlSetBitmap"), typeof(_GuiBitmapButtonCtrlSetBitmap));
            }

            _GuiBitmapButtonCtrlSetBitmapFunc(ctrl, bitmap);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiBitmapButtonCtrlGetBitmapNormal(IntPtr ctrl);
         private static _GuiBitmapButtonCtrlGetBitmapNormal _GuiBitmapButtonCtrlGetBitmapNormalFunc;
         internal static IntPtr GuiBitmapButtonCtrlGetBitmapNormal(IntPtr ctrl)
         {
            if (_GuiBitmapButtonCtrlGetBitmapNormalFunc == null)
            {
               _GuiBitmapButtonCtrlGetBitmapNormalFunc =
                  (_GuiBitmapButtonCtrlGetBitmapNormal)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapButtonCtrlGetBitmapNormal"), typeof(_GuiBitmapButtonCtrlGetBitmapNormal));
            }

            return _GuiBitmapButtonCtrlGetBitmapNormalFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiBitmapButtonCtrlSetBitmapNormal(IntPtr ctrl, string bitmap);
         private static _GuiBitmapButtonCtrlSetBitmapNormal _GuiBitmapButtonCtrlSetBitmapNormalFunc;
         internal static void GuiBitmapButtonCtrlSetBitmapNormal(IntPtr ctrl, string bitmap)
         {
            if (_GuiBitmapButtonCtrlSetBitmapNormalFunc == null)
            {
               _GuiBitmapButtonCtrlSetBitmapNormalFunc =
                  (_GuiBitmapButtonCtrlSetBitmapNormal)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapButtonCtrlSetBitmapNormal"), typeof(_GuiBitmapButtonCtrlSetBitmapNormal));
            }

            _GuiBitmapButtonCtrlSetBitmapNormalFunc(ctrl, bitmap);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiBitmapButtonCtrlGetBitmapHilight(IntPtr ctrl);
         private static _GuiBitmapButtonCtrlGetBitmapHilight _GuiBitmapButtonCtrlGetBitmapHilightFunc;
         internal static IntPtr GuiBitmapButtonCtrlGetBitmapHilight(IntPtr ctrl)
         {
            if (_GuiBitmapButtonCtrlGetBitmapHilightFunc == null)
            {
               _GuiBitmapButtonCtrlGetBitmapHilightFunc =
                  (_GuiBitmapButtonCtrlGetBitmapHilight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapButtonCtrlGetBitmapHilight"), typeof(_GuiBitmapButtonCtrlGetBitmapHilight));
            }

            return _GuiBitmapButtonCtrlGetBitmapHilightFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiBitmapButtonCtrlSetBitmapHilight(IntPtr ctrl, string bitmap);
         private static _GuiBitmapButtonCtrlSetBitmapHilight _GuiBitmapButtonCtrlSetBitmapHilightFunc;
         internal static void GuiBitmapButtonCtrlSetBitmapHilight(IntPtr ctrl, string bitmap)
         {
            if (_GuiBitmapButtonCtrlSetBitmapHilightFunc == null)
            {
               _GuiBitmapButtonCtrlSetBitmapHilightFunc =
                  (_GuiBitmapButtonCtrlSetBitmapHilight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapButtonCtrlSetBitmapHilight"), typeof(_GuiBitmapButtonCtrlSetBitmapHilight));
            }

            _GuiBitmapButtonCtrlSetBitmapHilightFunc(ctrl, bitmap);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiBitmapButtonCtrlGetBitmapDepressed(IntPtr ctrl);
         private static _GuiBitmapButtonCtrlGetBitmapDepressed _GuiBitmapButtonCtrlGetBitmapDepressedFunc;
         internal static IntPtr GuiBitmapButtonCtrlGetBitmapDepressed(IntPtr ctrl)
         {
            if (_GuiBitmapButtonCtrlGetBitmapDepressedFunc == null)
            {
               _GuiBitmapButtonCtrlGetBitmapDepressedFunc =
                  (_GuiBitmapButtonCtrlGetBitmapDepressed)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapButtonCtrlGetBitmapDepressed"), typeof(_GuiBitmapButtonCtrlGetBitmapDepressed));
            }

            return _GuiBitmapButtonCtrlGetBitmapDepressedFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiBitmapButtonCtrlSetBitmapDepressed(IntPtr ctrl, string bitmap);
         private static _GuiBitmapButtonCtrlSetBitmapDepressed _GuiBitmapButtonCtrlSetBitmapDepressedFunc;
         internal static void GuiBitmapButtonCtrlSetBitmapDepressed(IntPtr ctrl, string bitmap)
         {
            if (_GuiBitmapButtonCtrlSetBitmapDepressedFunc == null)
            {
               _GuiBitmapButtonCtrlSetBitmapDepressedFunc =
                  (_GuiBitmapButtonCtrlSetBitmapDepressed)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapButtonCtrlSetBitmapDepressed"), typeof(_GuiBitmapButtonCtrlSetBitmapDepressed));
            }

            _GuiBitmapButtonCtrlSetBitmapDepressedFunc(ctrl, bitmap);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiBitmapButtonCtrlGetBitmapInactive(IntPtr ctrl);
         private static _GuiBitmapButtonCtrlGetBitmapInactive _GuiBitmapButtonCtrlGetBitmapInactiveFunc;
         internal static IntPtr GuiBitmapButtonCtrlGetBitmapInactive(IntPtr ctrl)
         {
            if (_GuiBitmapButtonCtrlGetBitmapInactiveFunc == null)
            {
               _GuiBitmapButtonCtrlGetBitmapInactiveFunc =
                  (_GuiBitmapButtonCtrlGetBitmapInactive)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapButtonCtrlGetBitmapInactive"), typeof(_GuiBitmapButtonCtrlGetBitmapInactive));
            }

            return _GuiBitmapButtonCtrlGetBitmapInactiveFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiBitmapButtonCtrlSetBitmapInactive(IntPtr ctrl, string bitmap);
         private static _GuiBitmapButtonCtrlSetBitmapInactive _GuiBitmapButtonCtrlSetBitmapInactiveFunc;
         internal static void GuiBitmapButtonCtrlSetBitmapInactive(IntPtr ctrl, string bitmap)
         {
            if (_GuiBitmapButtonCtrlSetBitmapInactiveFunc == null)
            {
               _GuiBitmapButtonCtrlSetBitmapInactiveFunc =
                  (_GuiBitmapButtonCtrlSetBitmapInactive)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapButtonCtrlSetBitmapInactive"), typeof(_GuiBitmapButtonCtrlSetBitmapInactive));
            }

            _GuiBitmapButtonCtrlSetBitmapInactiveFunc(ctrl, bitmap);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiBitmapButtonCtrlCreateInstance();
         private static _GuiBitmapButtonCtrlCreateInstance _GuiBitmapButtonCtrlCreateInstanceFunc;
         internal static IntPtr GuiBitmapButtonCtrlCreateInstance()
         {
            if (_GuiBitmapButtonCtrlCreateInstanceFunc == null)
            {
               _GuiBitmapButtonCtrlCreateInstanceFunc =
                  (_GuiBitmapButtonCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapButtonCtrlCreateInstance"), typeof(_GuiBitmapButtonCtrlCreateInstance));
            }

            return _GuiBitmapButtonCtrlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public bool IsLegacyVersion
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiBitmapButtonCtrlGetIsLegacyVersion(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiBitmapButtonCtrlSetIsLegacyVersion(ObjectPtr->ObjPtr, value);
         }
      }
      public string Bitmap
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiBitmapButtonCtrlGetBitmap(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiBitmapButtonCtrlSetBitmap(ObjectPtr->ObjPtr, value);
         }
      }
      public string BitmapNormal
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiBitmapButtonCtrlGetBitmapNormal(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiBitmapButtonCtrlSetBitmapNormal(ObjectPtr->ObjPtr, value);
         }
      }
      public string BitmapHilight
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiBitmapButtonCtrlGetBitmapHilight(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiBitmapButtonCtrlSetBitmapHilight(ObjectPtr->ObjPtr, value);
         }
      }
      public string BitmapDepressed
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiBitmapButtonCtrlGetBitmapDepressed(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiBitmapButtonCtrlSetBitmapDepressed(ObjectPtr->ObjPtr, value);
         }
      }
      public string BitmapInactive
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiBitmapButtonCtrlGetBitmapInactive(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiBitmapButtonCtrlSetBitmapInactive(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}