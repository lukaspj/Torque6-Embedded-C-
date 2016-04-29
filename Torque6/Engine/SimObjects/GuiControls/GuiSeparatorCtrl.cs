using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiSeparatorCtrl : GuiControl
   {
      
      public GuiSeparatorCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiSeparatorCtrlCreateInstance());
      }

      public GuiSeparatorCtrl(uint pId) : base(pId)
      {
      }

      public GuiSeparatorCtrl(string pName) : base(pName)
      {
      }

      public GuiSeparatorCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiSeparatorCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiSeparatorCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiSeparatorCtrlGetCaption(IntPtr ctrl);
         private static _GuiSeparatorCtrlGetCaption _GuiSeparatorCtrlGetCaptionFunc;
         internal static IntPtr GuiSeparatorCtrlGetCaption(IntPtr ctrl)
         {
            if (_GuiSeparatorCtrlGetCaptionFunc == null)
            {
               _GuiSeparatorCtrlGetCaptionFunc =
                  (_GuiSeparatorCtrlGetCaption)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSeparatorCtrlGetCaption"), typeof(_GuiSeparatorCtrlGetCaption));
            }

            return _GuiSeparatorCtrlGetCaptionFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiSeparatorCtrlSetCaption(IntPtr ctrl, string caption);
         private static _GuiSeparatorCtrlSetCaption _GuiSeparatorCtrlSetCaptionFunc;
         internal static void GuiSeparatorCtrlSetCaption(IntPtr ctrl, string caption)
         {
            if (_GuiSeparatorCtrlSetCaptionFunc == null)
            {
               _GuiSeparatorCtrlSetCaptionFunc =
                  (_GuiSeparatorCtrlSetCaption)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSeparatorCtrlSetCaption"), typeof(_GuiSeparatorCtrlSetCaption));
            }

            _GuiSeparatorCtrlSetCaptionFunc(ctrl, caption);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiSeparatorCtrlGetType(IntPtr ctrl);
         private static _GuiSeparatorCtrlGetType _GuiSeparatorCtrlGetTypeFunc;
         internal static int GuiSeparatorCtrlGetType(IntPtr ctrl)
         {
            if (_GuiSeparatorCtrlGetTypeFunc == null)
            {
               _GuiSeparatorCtrlGetTypeFunc =
                  (_GuiSeparatorCtrlGetType)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSeparatorCtrlGetType"), typeof(_GuiSeparatorCtrlGetType));
            }

            return _GuiSeparatorCtrlGetTypeFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiSeparatorCtrlSetType(IntPtr ctrl, int type);
         private static _GuiSeparatorCtrlSetType _GuiSeparatorCtrlSetTypeFunc;
         internal static void GuiSeparatorCtrlSetType(IntPtr ctrl, int type)
         {
            if (_GuiSeparatorCtrlSetTypeFunc == null)
            {
               _GuiSeparatorCtrlSetTypeFunc =
                  (_GuiSeparatorCtrlSetType)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSeparatorCtrlSetType"), typeof(_GuiSeparatorCtrlSetType));
            }

            _GuiSeparatorCtrlSetTypeFunc(ctrl, type);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiSeparatorCtrlGetBorderMargin(IntPtr ctrl);
         private static _GuiSeparatorCtrlGetBorderMargin _GuiSeparatorCtrlGetBorderMarginFunc;
         internal static int GuiSeparatorCtrlGetBorderMargin(IntPtr ctrl)
         {
            if (_GuiSeparatorCtrlGetBorderMarginFunc == null)
            {
               _GuiSeparatorCtrlGetBorderMarginFunc =
                  (_GuiSeparatorCtrlGetBorderMargin)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSeparatorCtrlGetBorderMargin"), typeof(_GuiSeparatorCtrlGetBorderMargin));
            }

            return _GuiSeparatorCtrlGetBorderMarginFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiSeparatorCtrlSetBorderMargin(IntPtr ctrl, int margin);
         private static _GuiSeparatorCtrlSetBorderMargin _GuiSeparatorCtrlSetBorderMarginFunc;
         internal static void GuiSeparatorCtrlSetBorderMargin(IntPtr ctrl, int margin)
         {
            if (_GuiSeparatorCtrlSetBorderMarginFunc == null)
            {
               _GuiSeparatorCtrlSetBorderMarginFunc =
                  (_GuiSeparatorCtrlSetBorderMargin)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSeparatorCtrlSetBorderMargin"), typeof(_GuiSeparatorCtrlSetBorderMargin));
            }

            _GuiSeparatorCtrlSetBorderMarginFunc(ctrl, margin);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiSeparatorCtrlGetInvisible(IntPtr ctrl);
         private static _GuiSeparatorCtrlGetInvisible _GuiSeparatorCtrlGetInvisibleFunc;
         internal static bool GuiSeparatorCtrlGetInvisible(IntPtr ctrl)
         {
            if (_GuiSeparatorCtrlGetInvisibleFunc == null)
            {
               _GuiSeparatorCtrlGetInvisibleFunc =
                  (_GuiSeparatorCtrlGetInvisible)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSeparatorCtrlGetInvisible"), typeof(_GuiSeparatorCtrlGetInvisible));
            }

            return _GuiSeparatorCtrlGetInvisibleFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiSeparatorCtrlSetInvisible(IntPtr ctrl, bool invisible);
         private static _GuiSeparatorCtrlSetInvisible _GuiSeparatorCtrlSetInvisibleFunc;
         internal static void GuiSeparatorCtrlSetInvisible(IntPtr ctrl, bool invisible)
         {
            if (_GuiSeparatorCtrlSetInvisibleFunc == null)
            {
               _GuiSeparatorCtrlSetInvisibleFunc =
                  (_GuiSeparatorCtrlSetInvisible)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSeparatorCtrlSetInvisible"), typeof(_GuiSeparatorCtrlSetInvisible));
            }

            _GuiSeparatorCtrlSetInvisibleFunc(ctrl, invisible);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiSeparatorCtrlGetLeftMargin(IntPtr ctrl);
         private static _GuiSeparatorCtrlGetLeftMargin _GuiSeparatorCtrlGetLeftMarginFunc;
         internal static int GuiSeparatorCtrlGetLeftMargin(IntPtr ctrl)
         {
            if (_GuiSeparatorCtrlGetLeftMarginFunc == null)
            {
               _GuiSeparatorCtrlGetLeftMarginFunc =
                  (_GuiSeparatorCtrlGetLeftMargin)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSeparatorCtrlGetLeftMargin"), typeof(_GuiSeparatorCtrlGetLeftMargin));
            }

            return _GuiSeparatorCtrlGetLeftMarginFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiSeparatorCtrlSetLeftMargin(IntPtr ctrl, int leftMargin);
         private static _GuiSeparatorCtrlSetLeftMargin _GuiSeparatorCtrlSetLeftMarginFunc;
         internal static void GuiSeparatorCtrlSetLeftMargin(IntPtr ctrl, int leftMargin)
         {
            if (_GuiSeparatorCtrlSetLeftMarginFunc == null)
            {
               _GuiSeparatorCtrlSetLeftMarginFunc =
                  (_GuiSeparatorCtrlSetLeftMargin)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSeparatorCtrlSetLeftMargin"), typeof(_GuiSeparatorCtrlSetLeftMargin));
            }

            _GuiSeparatorCtrlSetLeftMarginFunc(ctrl, leftMargin);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiSeparatorCtrlCreateInstance();
         private static _GuiSeparatorCtrlCreateInstance _GuiSeparatorCtrlCreateInstanceFunc;
         internal static IntPtr GuiSeparatorCtrlCreateInstance()
         {
            if (_GuiSeparatorCtrlCreateInstanceFunc == null)
            {
               _GuiSeparatorCtrlCreateInstanceFunc =
                  (_GuiSeparatorCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSeparatorCtrlCreateInstance"), typeof(_GuiSeparatorCtrlCreateInstance));
            }

            return _GuiSeparatorCtrlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string Caption
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiSeparatorCtrlGetCaption(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiSeparatorCtrlSetCaption(ObjectPtr->ObjPtr, value);
         }
      }
      public int Type
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiSeparatorCtrlGetType(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiSeparatorCtrlSetType(ObjectPtr->ObjPtr, value);
         }
      }
      public int BorderMargin
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiSeparatorCtrlGetBorderMargin(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiSeparatorCtrlSetBorderMargin(ObjectPtr->ObjPtr, value);
         }
      }
      public bool Invisible
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiSeparatorCtrlGetInvisible(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiSeparatorCtrlSetInvisible(ObjectPtr->ObjPtr, value);
         }
      }
      public int LeftMargin
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiSeparatorCtrlGetLeftMargin(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiSeparatorCtrlSetLeftMargin(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}