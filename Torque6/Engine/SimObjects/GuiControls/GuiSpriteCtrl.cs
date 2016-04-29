using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiSpriteCtrl : GuiControl
   {
      
      public GuiSpriteCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiSpriteCtrlCreateInstance());
      }

      public GuiSpriteCtrl(uint pId) : base(pId)
      {
      }

      public GuiSpriteCtrl(string pName) : base(pName)
      {
      }

      public GuiSpriteCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiSpriteCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiSpriteCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiSpriteCtrlGetImage(IntPtr ctrl);
         private static _GuiSpriteCtrlGetImage _GuiSpriteCtrlGetImageFunc;
         internal static IntPtr GuiSpriteCtrlGetImage(IntPtr ctrl)
         {
            if (_GuiSpriteCtrlGetImageFunc == null)
            {
               _GuiSpriteCtrlGetImageFunc =
                  (_GuiSpriteCtrlGetImage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSpriteCtrlGetImage"), typeof(_GuiSpriteCtrlGetImage));
            }

            return _GuiSpriteCtrlGetImageFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiSpriteCtrlSetImage(IntPtr ctrl, string imageAssetId);
         private static _GuiSpriteCtrlSetImage _GuiSpriteCtrlSetImageFunc;
         internal static void GuiSpriteCtrlSetImage(IntPtr ctrl, string imageAssetId)
         {
            if (_GuiSpriteCtrlSetImageFunc == null)
            {
               _GuiSpriteCtrlSetImageFunc =
                  (_GuiSpriteCtrlSetImage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSpriteCtrlSetImage"), typeof(_GuiSpriteCtrlSetImage));
            }

            _GuiSpriteCtrlSetImageFunc(ctrl, imageAssetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiSpriteCtrlGetFrame(IntPtr ctrl);
         private static _GuiSpriteCtrlGetFrame _GuiSpriteCtrlGetFrameFunc;
         internal static int GuiSpriteCtrlGetFrame(IntPtr ctrl)
         {
            if (_GuiSpriteCtrlGetFrameFunc == null)
            {
               _GuiSpriteCtrlGetFrameFunc =
                  (_GuiSpriteCtrlGetFrame)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSpriteCtrlGetFrame"), typeof(_GuiSpriteCtrlGetFrame));
            }

            return _GuiSpriteCtrlGetFrameFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiSpriteCtrlSetFrame(IntPtr ctrl, int frame);
         private static _GuiSpriteCtrlSetFrame _GuiSpriteCtrlSetFrameFunc;
         internal static void GuiSpriteCtrlSetFrame(IntPtr ctrl, int frame)
         {
            if (_GuiSpriteCtrlSetFrameFunc == null)
            {
               _GuiSpriteCtrlSetFrameFunc =
                  (_GuiSpriteCtrlSetFrame)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSpriteCtrlSetFrame"), typeof(_GuiSpriteCtrlSetFrame));
            }

            _GuiSpriteCtrlSetFrameFunc(ctrl, frame);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiSpriteCtrlGetNamedFrame(IntPtr ctrl);
         private static _GuiSpriteCtrlGetNamedFrame _GuiSpriteCtrlGetNamedFrameFunc;
         internal static IntPtr GuiSpriteCtrlGetNamedFrame(IntPtr ctrl)
         {
            if (_GuiSpriteCtrlGetNamedFrameFunc == null)
            {
               _GuiSpriteCtrlGetNamedFrameFunc =
                  (_GuiSpriteCtrlGetNamedFrame)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSpriteCtrlGetNamedFrame"), typeof(_GuiSpriteCtrlGetNamedFrame));
            }

            return _GuiSpriteCtrlGetNamedFrameFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiSpriteCtrlSetNamedFrame(IntPtr ctrl, string frame);
         private static _GuiSpriteCtrlSetNamedFrame _GuiSpriteCtrlSetNamedFrameFunc;
         internal static void GuiSpriteCtrlSetNamedFrame(IntPtr ctrl, string frame)
         {
            if (_GuiSpriteCtrlSetNamedFrameFunc == null)
            {
               _GuiSpriteCtrlSetNamedFrameFunc =
                  (_GuiSpriteCtrlSetNamedFrame)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSpriteCtrlSetNamedFrame"), typeof(_GuiSpriteCtrlSetNamedFrame));
            }

            _GuiSpriteCtrlSetNamedFrameFunc(ctrl, frame);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiSpriteCtrlGetAnimation(IntPtr ctrl);
         private static _GuiSpriteCtrlGetAnimation _GuiSpriteCtrlGetAnimationFunc;
         internal static IntPtr GuiSpriteCtrlGetAnimation(IntPtr ctrl)
         {
            if (_GuiSpriteCtrlGetAnimationFunc == null)
            {
               _GuiSpriteCtrlGetAnimationFunc =
                  (_GuiSpriteCtrlGetAnimation)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSpriteCtrlGetAnimation"), typeof(_GuiSpriteCtrlGetAnimation));
            }

            return _GuiSpriteCtrlGetAnimationFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiSpriteCtrlSetAnimation(IntPtr ctrl, string animationAssetid);
         private static _GuiSpriteCtrlSetAnimation _GuiSpriteCtrlSetAnimationFunc;
         internal static void GuiSpriteCtrlSetAnimation(IntPtr ctrl, string animationAssetid)
         {
            if (_GuiSpriteCtrlSetAnimationFunc == null)
            {
               _GuiSpriteCtrlSetAnimationFunc =
                  (_GuiSpriteCtrlSetAnimation)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSpriteCtrlSetAnimation"), typeof(_GuiSpriteCtrlSetAnimation));
            }

            _GuiSpriteCtrlSetAnimationFunc(ctrl, animationAssetid);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiSpriteCtrlCreateInstance();
         private static _GuiSpriteCtrlCreateInstance _GuiSpriteCtrlCreateInstanceFunc;
         internal static IntPtr GuiSpriteCtrlCreateInstance()
         {
            if (_GuiSpriteCtrlCreateInstanceFunc == null)
            {
               _GuiSpriteCtrlCreateInstanceFunc =
                  (_GuiSpriteCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSpriteCtrlCreateInstance"), typeof(_GuiSpriteCtrlCreateInstance));
            }

            return _GuiSpriteCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiSpriteCtrlIsStaticFrameProvider(IntPtr ctrl);
         private static _GuiSpriteCtrlIsStaticFrameProvider _GuiSpriteCtrlIsStaticFrameProviderFunc;
         internal static bool GuiSpriteCtrlIsStaticFrameProvider(IntPtr ctrl)
         {
            if (_GuiSpriteCtrlIsStaticFrameProviderFunc == null)
            {
               _GuiSpriteCtrlIsStaticFrameProviderFunc =
                  (_GuiSpriteCtrlIsStaticFrameProvider)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSpriteCtrlIsStaticFrameProvider"), typeof(_GuiSpriteCtrlIsStaticFrameProvider));
            }

            return _GuiSpriteCtrlIsStaticFrameProviderFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiSpriteCtrlIsUsingNamedImageFrame(IntPtr ctrl);
         private static _GuiSpriteCtrlIsUsingNamedImageFrame _GuiSpriteCtrlIsUsingNamedImageFrameFunc;
         internal static bool GuiSpriteCtrlIsUsingNamedImageFrame(IntPtr ctrl)
         {
            if (_GuiSpriteCtrlIsUsingNamedImageFrameFunc == null)
            {
               _GuiSpriteCtrlIsUsingNamedImageFrameFunc =
                  (_GuiSpriteCtrlIsUsingNamedImageFrame)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSpriteCtrlIsUsingNamedImageFrame"), typeof(_GuiSpriteCtrlIsUsingNamedImageFrame));
            }

            return _GuiSpriteCtrlIsUsingNamedImageFrameFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiSpriteCtrlSetImageFrame(IntPtr ctrl, int imageFrame);
         private static _GuiSpriteCtrlSetImageFrame _GuiSpriteCtrlSetImageFrameFunc;
         internal static bool GuiSpriteCtrlSetImageFrame(IntPtr ctrl, int imageFrame)
         {
            if (_GuiSpriteCtrlSetImageFrameFunc == null)
            {
               _GuiSpriteCtrlSetImageFrameFunc =
                  (_GuiSpriteCtrlSetImageFrame)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSpriteCtrlSetImageFrame"), typeof(_GuiSpriteCtrlSetImageFrame));
            }

            return _GuiSpriteCtrlSetImageFrameFunc(ctrl, imageFrame);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiSpriteCtrlGetImageFrame(IntPtr ctrl);
         private static _GuiSpriteCtrlGetImageFrame _GuiSpriteCtrlGetImageFrameFunc;
         internal static int GuiSpriteCtrlGetImageFrame(IntPtr ctrl)
         {
            if (_GuiSpriteCtrlGetImageFrameFunc == null)
            {
               _GuiSpriteCtrlGetImageFrameFunc =
                  (_GuiSpriteCtrlGetImageFrame)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSpriteCtrlGetImageFrame"), typeof(_GuiSpriteCtrlGetImageFrame));
            }

            return _GuiSpriteCtrlGetImageFrameFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiSpriteCtrlSetNamedImageFrame(IntPtr ctrl, string frame);
         private static _GuiSpriteCtrlSetNamedImageFrame _GuiSpriteCtrlSetNamedImageFrameFunc;
         internal static bool GuiSpriteCtrlSetNamedImageFrame(IntPtr ctrl, string frame)
         {
            if (_GuiSpriteCtrlSetNamedImageFrameFunc == null)
            {
               _GuiSpriteCtrlSetNamedImageFrameFunc =
                  (_GuiSpriteCtrlSetNamedImageFrame)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSpriteCtrlSetNamedImageFrame"), typeof(_GuiSpriteCtrlSetNamedImageFrame));
            }

            return _GuiSpriteCtrlSetNamedImageFrameFunc(ctrl, frame);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiSpriteCtrlGetNamedImageFrame(IntPtr ctrl);
         private static _GuiSpriteCtrlGetNamedImageFrame _GuiSpriteCtrlGetNamedImageFrameFunc;
         internal static IntPtr GuiSpriteCtrlGetNamedImageFrame(IntPtr ctrl)
         {
            if (_GuiSpriteCtrlGetNamedImageFrameFunc == null)
            {
               _GuiSpriteCtrlGetNamedImageFrameFunc =
                  (_GuiSpriteCtrlGetNamedImageFrame)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSpriteCtrlGetNamedImageFrame"), typeof(_GuiSpriteCtrlGetNamedImageFrame));
            }

            return _GuiSpriteCtrlGetNamedImageFrameFunc(ctrl);
         }
      }
      
      #endregion

      #region Properties

      public string Image
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiSpriteCtrlGetImage(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiSpriteCtrlSetImage(ObjectPtr->ObjPtr, value);
         }
      }
      public int Frame
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiSpriteCtrlGetFrame(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiSpriteCtrlSetFrame(ObjectPtr->ObjPtr, value);
         }
      }
      public string NamedFrame
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiSpriteCtrlGetNamedFrame(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiSpriteCtrlSetNamedFrame(ObjectPtr->ObjPtr, value);
         }
      }
      public string Animation
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiSpriteCtrlGetAnimation(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiSpriteCtrlSetAnimation(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public bool IsStaticFrameProvider()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiSpriteCtrlIsStaticFrameProvider(ObjectPtr->ObjPtr);
      }

      public bool IsUsingNamedImageFrame()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiSpriteCtrlIsUsingNamedImageFrame(ObjectPtr->ObjPtr);
      }

      public bool SetImageFrame(int imageFrame)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiSpriteCtrlSetImageFrame(ObjectPtr->ObjPtr, imageFrame);
      }

      public int GetImageFrame()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiSpriteCtrlGetImageFrame(ObjectPtr->ObjPtr);
      }

      public bool SetNamedImageFrame(string frame)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiSpriteCtrlSetNamedImageFrame(ObjectPtr->ObjPtr, frame);
      }

      public string GetNamedImageFrame()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiSpriteCtrlGetNamedImageFrame(ObjectPtr->ObjPtr));
      }
      
      #endregion

      
   }
}