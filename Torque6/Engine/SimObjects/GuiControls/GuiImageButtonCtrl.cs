using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiImageButtonCtrl : GuiButtonCtrl
   {
      
      public GuiImageButtonCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiImageButtonCtrlCreateInstance());
      }

      public GuiImageButtonCtrl(uint pId) : base(pId)
      {
      }

      public GuiImageButtonCtrl(string pName) : base(pName)
      {
      }

      public GuiImageButtonCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiImageButtonCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiImageButtonCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiImageButtonCtrlGetNormalImage(IntPtr ctrl);
         private static _GuiImageButtonCtrlGetNormalImage _GuiImageButtonCtrlGetNormalImageFunc;
         internal static IntPtr GuiImageButtonCtrlGetNormalImage(IntPtr ctrl)
         {
            if (_GuiImageButtonCtrlGetNormalImageFunc == null)
            {
               _GuiImageButtonCtrlGetNormalImageFunc =
                  (_GuiImageButtonCtrlGetNormalImage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiImageButtonCtrlGetNormalImage"), typeof(_GuiImageButtonCtrlGetNormalImage));
            }

            return _GuiImageButtonCtrlGetNormalImageFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiImageButtonCtrlSetNormalImage(IntPtr ctrl, string imageAssetId);
         private static _GuiImageButtonCtrlSetNormalImage _GuiImageButtonCtrlSetNormalImageFunc;
         internal static void GuiImageButtonCtrlSetNormalImage(IntPtr ctrl, string imageAssetId)
         {
            if (_GuiImageButtonCtrlSetNormalImageFunc == null)
            {
               _GuiImageButtonCtrlSetNormalImageFunc =
                  (_GuiImageButtonCtrlSetNormalImage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiImageButtonCtrlSetNormalImage"), typeof(_GuiImageButtonCtrlSetNormalImage));
            }

            _GuiImageButtonCtrlSetNormalImageFunc(ctrl, imageAssetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiImageButtonCtrlGetHoverImage(IntPtr ctrl);
         private static _GuiImageButtonCtrlGetHoverImage _GuiImageButtonCtrlGetHoverImageFunc;
         internal static IntPtr GuiImageButtonCtrlGetHoverImage(IntPtr ctrl)
         {
            if (_GuiImageButtonCtrlGetHoverImageFunc == null)
            {
               _GuiImageButtonCtrlGetHoverImageFunc =
                  (_GuiImageButtonCtrlGetHoverImage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiImageButtonCtrlGetHoverImage"), typeof(_GuiImageButtonCtrlGetHoverImage));
            }

            return _GuiImageButtonCtrlGetHoverImageFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiImageButtonCtrlSetHoverImage(IntPtr ctrl, string imageAssetId);
         private static _GuiImageButtonCtrlSetHoverImage _GuiImageButtonCtrlSetHoverImageFunc;
         internal static void GuiImageButtonCtrlSetHoverImage(IntPtr ctrl, string imageAssetId)
         {
            if (_GuiImageButtonCtrlSetHoverImageFunc == null)
            {
               _GuiImageButtonCtrlSetHoverImageFunc =
                  (_GuiImageButtonCtrlSetHoverImage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiImageButtonCtrlSetHoverImage"), typeof(_GuiImageButtonCtrlSetHoverImage));
            }

            _GuiImageButtonCtrlSetHoverImageFunc(ctrl, imageAssetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiImageButtonCtrlGetDownImage(IntPtr ctrl);
         private static _GuiImageButtonCtrlGetDownImage _GuiImageButtonCtrlGetDownImageFunc;
         internal static IntPtr GuiImageButtonCtrlGetDownImage(IntPtr ctrl)
         {
            if (_GuiImageButtonCtrlGetDownImageFunc == null)
            {
               _GuiImageButtonCtrlGetDownImageFunc =
                  (_GuiImageButtonCtrlGetDownImage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiImageButtonCtrlGetDownImage"), typeof(_GuiImageButtonCtrlGetDownImage));
            }

            return _GuiImageButtonCtrlGetDownImageFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiImageButtonCtrlSetDownImage(IntPtr ctrl, string imageAssetId);
         private static _GuiImageButtonCtrlSetDownImage _GuiImageButtonCtrlSetDownImageFunc;
         internal static void GuiImageButtonCtrlSetDownImage(IntPtr ctrl, string imageAssetId)
         {
            if (_GuiImageButtonCtrlSetDownImageFunc == null)
            {
               _GuiImageButtonCtrlSetDownImageFunc =
                  (_GuiImageButtonCtrlSetDownImage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiImageButtonCtrlSetDownImage"), typeof(_GuiImageButtonCtrlSetDownImage));
            }

            _GuiImageButtonCtrlSetDownImageFunc(ctrl, imageAssetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiImageButtonCtrlGetInactiveImage(IntPtr ctrl);
         private static _GuiImageButtonCtrlGetInactiveImage _GuiImageButtonCtrlGetInactiveImageFunc;
         internal static IntPtr GuiImageButtonCtrlGetInactiveImage(IntPtr ctrl)
         {
            if (_GuiImageButtonCtrlGetInactiveImageFunc == null)
            {
               _GuiImageButtonCtrlGetInactiveImageFunc =
                  (_GuiImageButtonCtrlGetInactiveImage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiImageButtonCtrlGetInactiveImage"), typeof(_GuiImageButtonCtrlGetInactiveImage));
            }

            return _GuiImageButtonCtrlGetInactiveImageFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiImageButtonCtrlSetInactiveImage(IntPtr ctrl, string imageAssetId);
         private static _GuiImageButtonCtrlSetInactiveImage _GuiImageButtonCtrlSetInactiveImageFunc;
         internal static void GuiImageButtonCtrlSetInactiveImage(IntPtr ctrl, string imageAssetId)
         {
            if (_GuiImageButtonCtrlSetInactiveImageFunc == null)
            {
               _GuiImageButtonCtrlSetInactiveImageFunc =
                  (_GuiImageButtonCtrlSetInactiveImage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiImageButtonCtrlSetInactiveImage"), typeof(_GuiImageButtonCtrlSetInactiveImage));
            }

            _GuiImageButtonCtrlSetInactiveImageFunc(ctrl, imageAssetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiImageButtonCtrlCreateInstance();
         private static _GuiImageButtonCtrlCreateInstance _GuiImageButtonCtrlCreateInstanceFunc;
         internal static IntPtr GuiImageButtonCtrlCreateInstance()
         {
            if (_GuiImageButtonCtrlCreateInstanceFunc == null)
            {
               _GuiImageButtonCtrlCreateInstanceFunc =
                  (_GuiImageButtonCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiImageButtonCtrlCreateInstance"), typeof(_GuiImageButtonCtrlCreateInstance));
            }

            return _GuiImageButtonCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiImageButtonCtrlSetActive(IntPtr ctrl, bool active);
         private static _GuiImageButtonCtrlSetActive _GuiImageButtonCtrlSetActiveFunc;
         internal static void GuiImageButtonCtrlSetActive(IntPtr ctrl, bool active)
         {
            if (_GuiImageButtonCtrlSetActiveFunc == null)
            {
               _GuiImageButtonCtrlSetActiveFunc =
                  (_GuiImageButtonCtrlSetActive)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiImageButtonCtrlSetActive"), typeof(_GuiImageButtonCtrlSetActive));
            }

            _GuiImageButtonCtrlSetActiveFunc(ctrl, active);
         }
      }
      
      #endregion

      #region Properties

      public string NormalImage
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiImageButtonCtrlGetNormalImage(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiImageButtonCtrlSetNormalImage(ObjectPtr->ObjPtr, value);
         }
      }
      public string HoverImage
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiImageButtonCtrlGetHoverImage(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiImageButtonCtrlSetHoverImage(ObjectPtr->ObjPtr, value);
         }
      }
      public string DownImage
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiImageButtonCtrlGetDownImage(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiImageButtonCtrlSetDownImage(ObjectPtr->ObjPtr, value);
         }
      }
      public string InactiveImage
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiImageButtonCtrlGetInactiveImage(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiImageButtonCtrlSetInactiveImage(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public void SetActive(bool active)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiImageButtonCtrlSetActive(ObjectPtr->ObjPtr, active);
      }
      
      #endregion

      
   }
}