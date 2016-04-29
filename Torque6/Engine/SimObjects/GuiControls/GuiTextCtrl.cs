using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiTextCtrl : GuiControl
   {
      
      public GuiTextCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiTextCtrlCreateInstance());
      }

      public GuiTextCtrl(uint pId) : base(pId)
      {
      }

      public GuiTextCtrl(string pName) : base(pName)
      {
      }

      public GuiTextCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiTextCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiTextCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTextCtrlGetText(IntPtr ctrl);
         private static _GuiTextCtrlGetText _GuiTextCtrlGetTextFunc;
         internal static IntPtr GuiTextCtrlGetText(IntPtr ctrl)
         {
            if (_GuiTextCtrlGetTextFunc == null)
            {
               _GuiTextCtrlGetTextFunc =
                  (_GuiTextCtrlGetText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextCtrlGetText"), typeof(_GuiTextCtrlGetText));
            }

            return _GuiTextCtrlGetTextFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextCtrlSetText(IntPtr ctrl, string text);
         private static _GuiTextCtrlSetText _GuiTextCtrlSetTextFunc;
         internal static void GuiTextCtrlSetText(IntPtr ctrl, string text)
         {
            if (_GuiTextCtrlSetTextFunc == null)
            {
               _GuiTextCtrlSetTextFunc =
                  (_GuiTextCtrlSetText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextCtrlSetText"), typeof(_GuiTextCtrlSetText));
            }

            _GuiTextCtrlSetTextFunc(ctrl, text);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTextCtrlGetTextID(IntPtr ctrl);
         private static _GuiTextCtrlGetTextID _GuiTextCtrlGetTextIDFunc;
         internal static IntPtr GuiTextCtrlGetTextID(IntPtr ctrl)
         {
            if (_GuiTextCtrlGetTextIDFunc == null)
            {
               _GuiTextCtrlGetTextIDFunc =
                  (_GuiTextCtrlGetTextID)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextCtrlGetTextID"), typeof(_GuiTextCtrlGetTextID));
            }

            return _GuiTextCtrlGetTextIDFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextCtrlSetTextID(IntPtr ctrl, string text);
         private static _GuiTextCtrlSetTextID _GuiTextCtrlSetTextIDFunc;
         internal static void GuiTextCtrlSetTextID(IntPtr ctrl, string text)
         {
            if (_GuiTextCtrlSetTextIDFunc == null)
            {
               _GuiTextCtrlSetTextIDFunc =
                  (_GuiTextCtrlSetTextID)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextCtrlSetTextID"), typeof(_GuiTextCtrlSetTextID));
            }

            _GuiTextCtrlSetTextIDFunc(ctrl, text);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTextCtrlGetMaxLength(IntPtr ctrl);
         private static _GuiTextCtrlGetMaxLength _GuiTextCtrlGetMaxLengthFunc;
         internal static int GuiTextCtrlGetMaxLength(IntPtr ctrl)
         {
            if (_GuiTextCtrlGetMaxLengthFunc == null)
            {
               _GuiTextCtrlGetMaxLengthFunc =
                  (_GuiTextCtrlGetMaxLength)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextCtrlGetMaxLength"), typeof(_GuiTextCtrlGetMaxLength));
            }

            return _GuiTextCtrlGetMaxLengthFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextCtrlSetMaxLength(IntPtr ctrl, int length);
         private static _GuiTextCtrlSetMaxLength _GuiTextCtrlSetMaxLengthFunc;
         internal static void GuiTextCtrlSetMaxLength(IntPtr ctrl, int length)
         {
            if (_GuiTextCtrlSetMaxLengthFunc == null)
            {
               _GuiTextCtrlSetMaxLengthFunc =
                  (_GuiTextCtrlSetMaxLength)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextCtrlSetMaxLength"), typeof(_GuiTextCtrlSetMaxLength));
            }

            _GuiTextCtrlSetMaxLengthFunc(ctrl, length);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTextCtrlGetTruncate(IntPtr ctrl);
         private static _GuiTextCtrlGetTruncate _GuiTextCtrlGetTruncateFunc;
         internal static bool GuiTextCtrlGetTruncate(IntPtr ctrl)
         {
            if (_GuiTextCtrlGetTruncateFunc == null)
            {
               _GuiTextCtrlGetTruncateFunc =
                  (_GuiTextCtrlGetTruncate)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextCtrlGetTruncate"), typeof(_GuiTextCtrlGetTruncate));
            }

            return _GuiTextCtrlGetTruncateFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextCtrlSetTruncate(IntPtr ctrl, bool truncate);
         private static _GuiTextCtrlSetTruncate _GuiTextCtrlSetTruncateFunc;
         internal static void GuiTextCtrlSetTruncate(IntPtr ctrl, bool truncate)
         {
            if (_GuiTextCtrlSetTruncateFunc == null)
            {
               _GuiTextCtrlSetTruncateFunc =
                  (_GuiTextCtrlSetTruncate)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextCtrlSetTruncate"), typeof(_GuiTextCtrlSetTruncate));
            }

            _GuiTextCtrlSetTruncateFunc(ctrl, truncate);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTextCtrlCreateInstance();
         private static _GuiTextCtrlCreateInstance _GuiTextCtrlCreateInstanceFunc;
         internal static IntPtr GuiTextCtrlCreateInstance()
         {
            if (_GuiTextCtrlCreateInstanceFunc == null)
            {
               _GuiTextCtrlCreateInstanceFunc =
                  (_GuiTextCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextCtrlCreateInstance"), typeof(_GuiTextCtrlCreateInstance));
            }

            return _GuiTextCtrlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string Text
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiTextCtrlGetText(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTextCtrlSetText(ObjectPtr->ObjPtr, value);
         }
      }
      public string TextID
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiTextCtrlGetTextID(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTextCtrlSetTextID(ObjectPtr->ObjPtr, value);
         }
      }
      public int MaxLength
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTextCtrlGetMaxLength(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTextCtrlSetMaxLength(ObjectPtr->ObjPtr, value);
         }
      }
      public bool Truncate
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTextCtrlGetTruncate(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTextCtrlSetTruncate(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}