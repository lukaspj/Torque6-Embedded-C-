using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiBitmapCtrl : GuiControl
   {
      
      public GuiBitmapCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiBitmapCtrlCreateInstance());
      }

      public GuiBitmapCtrl(uint pId) : base(pId)
      {
      }

      public GuiBitmapCtrl(string pName) : base(pName)
      {
      }

      public GuiBitmapCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiBitmapCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiBitmapCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiBitmapCtrlGetBitmap(IntPtr ctrl);
         private static _GuiBitmapCtrlGetBitmap _GuiBitmapCtrlGetBitmapFunc;
         internal static IntPtr GuiBitmapCtrlGetBitmap(IntPtr ctrl)
         {
            if (_GuiBitmapCtrlGetBitmapFunc == null)
            {
               _GuiBitmapCtrlGetBitmapFunc =
                  (_GuiBitmapCtrlGetBitmap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapCtrlGetBitmap"), typeof(_GuiBitmapCtrlGetBitmap));
            }

            return _GuiBitmapCtrlGetBitmapFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiBitmapCtrlSetBitmap(IntPtr ctrl, string bitmapFile);
         private static _GuiBitmapCtrlSetBitmap _GuiBitmapCtrlSetBitmapFunc;
         internal static void GuiBitmapCtrlSetBitmap(IntPtr ctrl, string bitmapFile)
         {
            if (_GuiBitmapCtrlSetBitmapFunc == null)
            {
               _GuiBitmapCtrlSetBitmapFunc =
                  (_GuiBitmapCtrlSetBitmap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapCtrlSetBitmap"), typeof(_GuiBitmapCtrlSetBitmap));
            }

            _GuiBitmapCtrlSetBitmapFunc(ctrl, bitmapFile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiBitmapCtrlGetWrap(IntPtr ctrl);
         private static _GuiBitmapCtrlGetWrap _GuiBitmapCtrlGetWrapFunc;
         internal static bool GuiBitmapCtrlGetWrap(IntPtr ctrl)
         {
            if (_GuiBitmapCtrlGetWrapFunc == null)
            {
               _GuiBitmapCtrlGetWrapFunc =
                  (_GuiBitmapCtrlGetWrap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapCtrlGetWrap"), typeof(_GuiBitmapCtrlGetWrap));
            }

            return _GuiBitmapCtrlGetWrapFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiBitmapCtrlSetWrap(IntPtr ctrl, bool wrap);
         private static _GuiBitmapCtrlSetWrap _GuiBitmapCtrlSetWrapFunc;
         internal static void GuiBitmapCtrlSetWrap(IntPtr ctrl, bool wrap)
         {
            if (_GuiBitmapCtrlSetWrapFunc == null)
            {
               _GuiBitmapCtrlSetWrapFunc =
                  (_GuiBitmapCtrlSetWrap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapCtrlSetWrap"), typeof(_GuiBitmapCtrlSetWrap));
            }

            _GuiBitmapCtrlSetWrapFunc(ctrl, wrap);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiBitmapCtrlGetUseSourceRect(IntPtr ctrl);
         private static _GuiBitmapCtrlGetUseSourceRect _GuiBitmapCtrlGetUseSourceRectFunc;
         internal static bool GuiBitmapCtrlGetUseSourceRect(IntPtr ctrl)
         {
            if (_GuiBitmapCtrlGetUseSourceRectFunc == null)
            {
               _GuiBitmapCtrlGetUseSourceRectFunc =
                  (_GuiBitmapCtrlGetUseSourceRect)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapCtrlGetUseSourceRect"), typeof(_GuiBitmapCtrlGetUseSourceRect));
            }

            return _GuiBitmapCtrlGetUseSourceRectFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiBitmapCtrlSetUseSourceRect(IntPtr ctrl, bool use);
         private static _GuiBitmapCtrlSetUseSourceRect _GuiBitmapCtrlSetUseSourceRectFunc;
         internal static void GuiBitmapCtrlSetUseSourceRect(IntPtr ctrl, bool use)
         {
            if (_GuiBitmapCtrlSetUseSourceRectFunc == null)
            {
               _GuiBitmapCtrlSetUseSourceRectFunc =
                  (_GuiBitmapCtrlSetUseSourceRect)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapCtrlSetUseSourceRect"), typeof(_GuiBitmapCtrlSetUseSourceRect));
            }

            _GuiBitmapCtrlSetUseSourceRectFunc(ctrl, use);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiBitmapCtrlGetSourceRect(IntPtr ctrl, out RectI outRect);
         private static _GuiBitmapCtrlGetSourceRect _GuiBitmapCtrlGetSourceRectFunc;
         internal static void GuiBitmapCtrlGetSourceRect(IntPtr ctrl, out RectI outRect)
         {
            if (_GuiBitmapCtrlGetSourceRectFunc == null)
            {
               _GuiBitmapCtrlGetSourceRectFunc =
                  (_GuiBitmapCtrlGetSourceRect)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapCtrlGetSourceRect"), typeof(_GuiBitmapCtrlGetSourceRect));
            }

            _GuiBitmapCtrlGetSourceRectFunc(ctrl, out outRect);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiBitmapCtrlSetSourceRect(IntPtr ctrl, RectI rect);
         private static _GuiBitmapCtrlSetSourceRect _GuiBitmapCtrlSetSourceRectFunc;
         internal static void GuiBitmapCtrlSetSourceRect(IntPtr ctrl, RectI rect)
         {
            if (_GuiBitmapCtrlSetSourceRectFunc == null)
            {
               _GuiBitmapCtrlSetSourceRectFunc =
                  (_GuiBitmapCtrlSetSourceRect)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapCtrlSetSourceRect"), typeof(_GuiBitmapCtrlSetSourceRect));
            }

            _GuiBitmapCtrlSetSourceRectFunc(ctrl, rect);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiBitmapCtrlCreateInstance();
         private static _GuiBitmapCtrlCreateInstance _GuiBitmapCtrlCreateInstanceFunc;
         internal static IntPtr GuiBitmapCtrlCreateInstance()
         {
            if (_GuiBitmapCtrlCreateInstanceFunc == null)
            {
               _GuiBitmapCtrlCreateInstanceFunc =
                  (_GuiBitmapCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapCtrlCreateInstance"), typeof(_GuiBitmapCtrlCreateInstance));
            }

            return _GuiBitmapCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiBitmapCtrlSetValue(IntPtr ctrl, int x, int y);
         private static _GuiBitmapCtrlSetValue _GuiBitmapCtrlSetValueFunc;
         internal static void GuiBitmapCtrlSetValue(IntPtr ctrl, int x, int y)
         {
            if (_GuiBitmapCtrlSetValueFunc == null)
            {
               _GuiBitmapCtrlSetValueFunc =
                  (_GuiBitmapCtrlSetValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapCtrlSetValue"), typeof(_GuiBitmapCtrlSetValue));
            }

            _GuiBitmapCtrlSetValueFunc(ctrl, x, y);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiBitmapCtrlGetTextureWidth(IntPtr ctrl);
         private static _GuiBitmapCtrlGetTextureWidth _GuiBitmapCtrlGetTextureWidthFunc;
         internal static int GuiBitmapCtrlGetTextureWidth(IntPtr ctrl)
         {
            if (_GuiBitmapCtrlGetTextureWidthFunc == null)
            {
               _GuiBitmapCtrlGetTextureWidthFunc =
                  (_GuiBitmapCtrlGetTextureWidth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapCtrlGetTextureWidth"), typeof(_GuiBitmapCtrlGetTextureWidth));
            }

            return _GuiBitmapCtrlGetTextureWidthFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiBitmapCtrlGetTextureHeight(IntPtr ctrl);
         private static _GuiBitmapCtrlGetTextureHeight _GuiBitmapCtrlGetTextureHeightFunc;
         internal static int GuiBitmapCtrlGetTextureHeight(IntPtr ctrl)
         {
            if (_GuiBitmapCtrlGetTextureHeightFunc == null)
            {
               _GuiBitmapCtrlGetTextureHeightFunc =
                  (_GuiBitmapCtrlGetTextureHeight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiBitmapCtrlGetTextureHeight"), typeof(_GuiBitmapCtrlGetTextureHeight));
            }

            return _GuiBitmapCtrlGetTextureHeightFunc(ctrl);
         }
      }
      
      #endregion

      #region Properties

      public string Bitmap
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiBitmapCtrlGetBitmap(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiBitmapCtrlSetBitmap(ObjectPtr->ObjPtr, value);
         }
      }
      public bool Wrap
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiBitmapCtrlGetWrap(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiBitmapCtrlSetWrap(ObjectPtr->ObjPtr, value);
         }
      }
      public bool UseSourceRect
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiBitmapCtrlGetUseSourceRect(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiBitmapCtrlSetUseSourceRect(ObjectPtr->ObjPtr, value);
         }
      }
      public RectI SourceRect
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            RectI outVal;
            InternalUnsafeMethods.GuiBitmapCtrlGetSourceRect(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiBitmapCtrlSetSourceRect(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public void SetValue(int x, int y)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiBitmapCtrlSetValue(ObjectPtr->ObjPtr, x, y);
      }

      public int GetTextureWidth()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiBitmapCtrlGetTextureWidth(ObjectPtr->ObjPtr);
      }

      public int GetTextureHeight()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiBitmapCtrlGetTextureHeight(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}