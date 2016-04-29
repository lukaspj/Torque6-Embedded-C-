using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiIconButtonCtrl : GuiButtonCtrl
   {
      
      public GuiIconButtonCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiIconButtonCtrlCreateInstance());
      }

      public GuiIconButtonCtrl(uint pId) : base(pId)
      {
      }

      public GuiIconButtonCtrl(string pName) : base(pName)
      {
      }

      public GuiIconButtonCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiIconButtonCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiIconButtonCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiIconButtonCtrlGetButtonMargin(IntPtr ctrl, out Point2I outMargin);
         private static _GuiIconButtonCtrlGetButtonMargin _GuiIconButtonCtrlGetButtonMarginFunc;
         internal static void GuiIconButtonCtrlGetButtonMargin(IntPtr ctrl, out Point2I outMargin)
         {
            if (_GuiIconButtonCtrlGetButtonMarginFunc == null)
            {
               _GuiIconButtonCtrlGetButtonMarginFunc =
                  (_GuiIconButtonCtrlGetButtonMargin)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiIconButtonCtrlGetButtonMargin"), typeof(_GuiIconButtonCtrlGetButtonMargin));
            }

            _GuiIconButtonCtrlGetButtonMarginFunc(ctrl, out outMargin);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiIconButtonCtrlSetButtonMargin(IntPtr ctrl, Point2I margin);
         private static _GuiIconButtonCtrlSetButtonMargin _GuiIconButtonCtrlSetButtonMarginFunc;
         internal static void GuiIconButtonCtrlSetButtonMargin(IntPtr ctrl, Point2I margin)
         {
            if (_GuiIconButtonCtrlSetButtonMarginFunc == null)
            {
               _GuiIconButtonCtrlSetButtonMarginFunc =
                  (_GuiIconButtonCtrlSetButtonMargin)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiIconButtonCtrlSetButtonMargin"), typeof(_GuiIconButtonCtrlSetButtonMargin));
            }

            _GuiIconButtonCtrlSetButtonMarginFunc(ctrl, margin);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiIconButtonCtrlGetIconBitmap(IntPtr ctrl);
         private static _GuiIconButtonCtrlGetIconBitmap _GuiIconButtonCtrlGetIconBitmapFunc;
         internal static IntPtr GuiIconButtonCtrlGetIconBitmap(IntPtr ctrl)
         {
            if (_GuiIconButtonCtrlGetIconBitmapFunc == null)
            {
               _GuiIconButtonCtrlGetIconBitmapFunc =
                  (_GuiIconButtonCtrlGetIconBitmap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiIconButtonCtrlGetIconBitmap"), typeof(_GuiIconButtonCtrlGetIconBitmap));
            }

            return _GuiIconButtonCtrlGetIconBitmapFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiIconButtonCtrlSetIconBitmap(IntPtr ctrl, string bitmap);
         private static _GuiIconButtonCtrlSetIconBitmap _GuiIconButtonCtrlSetIconBitmapFunc;
         internal static void GuiIconButtonCtrlSetIconBitmap(IntPtr ctrl, string bitmap)
         {
            if (_GuiIconButtonCtrlSetIconBitmapFunc == null)
            {
               _GuiIconButtonCtrlSetIconBitmapFunc =
                  (_GuiIconButtonCtrlSetIconBitmap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiIconButtonCtrlSetIconBitmap"), typeof(_GuiIconButtonCtrlSetIconBitmap));
            }

            _GuiIconButtonCtrlSetIconBitmapFunc(ctrl, bitmap);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiIconButtonCtrlGetIconLocation(IntPtr ctrl);
         private static _GuiIconButtonCtrlGetIconLocation _GuiIconButtonCtrlGetIconLocationFunc;
         internal static int GuiIconButtonCtrlGetIconLocation(IntPtr ctrl)
         {
            if (_GuiIconButtonCtrlGetIconLocationFunc == null)
            {
               _GuiIconButtonCtrlGetIconLocationFunc =
                  (_GuiIconButtonCtrlGetIconLocation)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiIconButtonCtrlGetIconLocation"), typeof(_GuiIconButtonCtrlGetIconLocation));
            }

            return _GuiIconButtonCtrlGetIconLocationFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiIconButtonCtrlSetIconLocation(IntPtr ctrl, int location);
         private static _GuiIconButtonCtrlSetIconLocation _GuiIconButtonCtrlSetIconLocationFunc;
         internal static void GuiIconButtonCtrlSetIconLocation(IntPtr ctrl, int location)
         {
            if (_GuiIconButtonCtrlSetIconLocationFunc == null)
            {
               _GuiIconButtonCtrlSetIconLocationFunc =
                  (_GuiIconButtonCtrlSetIconLocation)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiIconButtonCtrlSetIconLocation"), typeof(_GuiIconButtonCtrlSetIconLocation));
            }

            _GuiIconButtonCtrlSetIconLocationFunc(ctrl, location);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiIconButtonCtrlGetSizeIconToButton(IntPtr ctrl);
         private static _GuiIconButtonCtrlGetSizeIconToButton _GuiIconButtonCtrlGetSizeIconToButtonFunc;
         internal static bool GuiIconButtonCtrlGetSizeIconToButton(IntPtr ctrl)
         {
            if (_GuiIconButtonCtrlGetSizeIconToButtonFunc == null)
            {
               _GuiIconButtonCtrlGetSizeIconToButtonFunc =
                  (_GuiIconButtonCtrlGetSizeIconToButton)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiIconButtonCtrlGetSizeIconToButton"), typeof(_GuiIconButtonCtrlGetSizeIconToButton));
            }

            return _GuiIconButtonCtrlGetSizeIconToButtonFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiIconButtonCtrlSetSizeIconToButton(IntPtr ctrl, bool sizeIconToButton);
         private static _GuiIconButtonCtrlSetSizeIconToButton _GuiIconButtonCtrlSetSizeIconToButtonFunc;
         internal static void GuiIconButtonCtrlSetSizeIconToButton(IntPtr ctrl, bool sizeIconToButton)
         {
            if (_GuiIconButtonCtrlSetSizeIconToButtonFunc == null)
            {
               _GuiIconButtonCtrlSetSizeIconToButtonFunc =
                  (_GuiIconButtonCtrlSetSizeIconToButton)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiIconButtonCtrlSetSizeIconToButton"), typeof(_GuiIconButtonCtrlSetSizeIconToButton));
            }

            _GuiIconButtonCtrlSetSizeIconToButtonFunc(ctrl, sizeIconToButton);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiIconButtonCtrlGetTextLocation(IntPtr ctrl);
         private static _GuiIconButtonCtrlGetTextLocation _GuiIconButtonCtrlGetTextLocationFunc;
         internal static int GuiIconButtonCtrlGetTextLocation(IntPtr ctrl)
         {
            if (_GuiIconButtonCtrlGetTextLocationFunc == null)
            {
               _GuiIconButtonCtrlGetTextLocationFunc =
                  (_GuiIconButtonCtrlGetTextLocation)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiIconButtonCtrlGetTextLocation"), typeof(_GuiIconButtonCtrlGetTextLocation));
            }

            return _GuiIconButtonCtrlGetTextLocationFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiIconButtonCtrlSetTextLocation(IntPtr ctrl, int location);
         private static _GuiIconButtonCtrlSetTextLocation _GuiIconButtonCtrlSetTextLocationFunc;
         internal static void GuiIconButtonCtrlSetTextLocation(IntPtr ctrl, int location)
         {
            if (_GuiIconButtonCtrlSetTextLocationFunc == null)
            {
               _GuiIconButtonCtrlSetTextLocationFunc =
                  (_GuiIconButtonCtrlSetTextLocation)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiIconButtonCtrlSetTextLocation"), typeof(_GuiIconButtonCtrlSetTextLocation));
            }

            _GuiIconButtonCtrlSetTextLocationFunc(ctrl, location);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiIconButtonCtrlGetTextMargin(IntPtr ctrl);
         private static _GuiIconButtonCtrlGetTextMargin _GuiIconButtonCtrlGetTextMarginFunc;
         internal static int GuiIconButtonCtrlGetTextMargin(IntPtr ctrl)
         {
            if (_GuiIconButtonCtrlGetTextMarginFunc == null)
            {
               _GuiIconButtonCtrlGetTextMarginFunc =
                  (_GuiIconButtonCtrlGetTextMargin)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiIconButtonCtrlGetTextMargin"), typeof(_GuiIconButtonCtrlGetTextMargin));
            }

            return _GuiIconButtonCtrlGetTextMarginFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiIconButtonCtrlSetTextMargin(IntPtr ctrl, int margin);
         private static _GuiIconButtonCtrlSetTextMargin _GuiIconButtonCtrlSetTextMarginFunc;
         internal static void GuiIconButtonCtrlSetTextMargin(IntPtr ctrl, int margin)
         {
            if (_GuiIconButtonCtrlSetTextMarginFunc == null)
            {
               _GuiIconButtonCtrlSetTextMarginFunc =
                  (_GuiIconButtonCtrlSetTextMargin)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiIconButtonCtrlSetTextMargin"), typeof(_GuiIconButtonCtrlSetTextMargin));
            }

            _GuiIconButtonCtrlSetTextMarginFunc(ctrl, margin);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiIconButtonCtrlCreateInstance();
         private static _GuiIconButtonCtrlCreateInstance _GuiIconButtonCtrlCreateInstanceFunc;
         internal static IntPtr GuiIconButtonCtrlCreateInstance()
         {
            if (_GuiIconButtonCtrlCreateInstanceFunc == null)
            {
               _GuiIconButtonCtrlCreateInstanceFunc =
                  (_GuiIconButtonCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiIconButtonCtrlCreateInstance"), typeof(_GuiIconButtonCtrlCreateInstance));
            }

            return _GuiIconButtonCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiIconButtonCtrlSetBitmap(IntPtr ctrl, string filePath);
         private static _GuiIconButtonCtrlSetBitmap _GuiIconButtonCtrlSetBitmapFunc;
         internal static void GuiIconButtonCtrlSetBitmap(IntPtr ctrl, string filePath)
         {
            if (_GuiIconButtonCtrlSetBitmapFunc == null)
            {
               _GuiIconButtonCtrlSetBitmapFunc =
                  (_GuiIconButtonCtrlSetBitmap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiIconButtonCtrlSetBitmap"), typeof(_GuiIconButtonCtrlSetBitmap));
            }

            _GuiIconButtonCtrlSetBitmapFunc(ctrl, filePath);
         }
      }
      
      #endregion

      #region Properties

      public Point2I ButtonMargin
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Point2I outVal;
            InternalUnsafeMethods.GuiIconButtonCtrlGetButtonMargin(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiIconButtonCtrlSetButtonMargin(ObjectPtr->ObjPtr, value);
         }
      }
      public string IconBitmap
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiIconButtonCtrlGetIconBitmap(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiIconButtonCtrlSetIconBitmap(ObjectPtr->ObjPtr, value);
         }
      }
      public int IconLocation
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiIconButtonCtrlGetIconLocation(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiIconButtonCtrlSetIconLocation(ObjectPtr->ObjPtr, value);
         }
      }
      public bool SizeIconToButton
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiIconButtonCtrlGetSizeIconToButton(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiIconButtonCtrlSetSizeIconToButton(ObjectPtr->ObjPtr, value);
         }
      }
      public int TextLocation
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiIconButtonCtrlGetTextLocation(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiIconButtonCtrlSetTextLocation(ObjectPtr->ObjPtr, value);
         }
      }
      public int TextMargin
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiIconButtonCtrlGetTextMargin(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiIconButtonCtrlSetTextMargin(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public void SetBitmap(string filePath)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiIconButtonCtrlSetBitmap(ObjectPtr->ObjPtr, filePath);
      }
      
      #endregion

      
   }
}