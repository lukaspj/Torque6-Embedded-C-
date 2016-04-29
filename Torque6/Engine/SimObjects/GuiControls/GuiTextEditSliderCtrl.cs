using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiTextEditSliderCtrl : GuiTextEditCtrl
   {
      
      public GuiTextEditSliderCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiTextEditSliderCtrlCreateInstance());
      }

      public GuiTextEditSliderCtrl(uint pId) : base(pId)
      {
      }

      public GuiTextEditSliderCtrl(string pName) : base(pName)
      {
      }

      public GuiTextEditSliderCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiTextEditSliderCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiTextEditSliderCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTextEditSliderCtrlGetFormat(IntPtr ctrl);
         private static _GuiTextEditSliderCtrlGetFormat _GuiTextEditSliderCtrlGetFormatFunc;
         internal static IntPtr GuiTextEditSliderCtrlGetFormat(IntPtr ctrl)
         {
            if (_GuiTextEditSliderCtrlGetFormatFunc == null)
            {
               _GuiTextEditSliderCtrlGetFormatFunc =
                  (_GuiTextEditSliderCtrlGetFormat)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditSliderCtrlGetFormat"), typeof(_GuiTextEditSliderCtrlGetFormat));
            }

            return _GuiTextEditSliderCtrlGetFormatFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextEditSliderCtrlSetFormat(IntPtr ctrl, string format);
         private static _GuiTextEditSliderCtrlSetFormat _GuiTextEditSliderCtrlSetFormatFunc;
         internal static void GuiTextEditSliderCtrlSetFormat(IntPtr ctrl, string format)
         {
            if (_GuiTextEditSliderCtrlSetFormatFunc == null)
            {
               _GuiTextEditSliderCtrlSetFormatFunc =
                  (_GuiTextEditSliderCtrlSetFormat)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditSliderCtrlSetFormat"), typeof(_GuiTextEditSliderCtrlSetFormat));
            }

            _GuiTextEditSliderCtrlSetFormatFunc(ctrl, format);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextEditSliderCtrlGetRange(IntPtr ctrl, out Point2F outRange);
         private static _GuiTextEditSliderCtrlGetRange _GuiTextEditSliderCtrlGetRangeFunc;
         internal static void GuiTextEditSliderCtrlGetRange(IntPtr ctrl, out Point2F outRange)
         {
            if (_GuiTextEditSliderCtrlGetRangeFunc == null)
            {
               _GuiTextEditSliderCtrlGetRangeFunc =
                  (_GuiTextEditSliderCtrlGetRange)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditSliderCtrlGetRange"), typeof(_GuiTextEditSliderCtrlGetRange));
            }

            _GuiTextEditSliderCtrlGetRangeFunc(ctrl, out outRange);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextEditSliderCtrlSetRange(IntPtr ctrl, Point2F range);
         private static _GuiTextEditSliderCtrlSetRange _GuiTextEditSliderCtrlSetRangeFunc;
         internal static void GuiTextEditSliderCtrlSetRange(IntPtr ctrl, Point2F range)
         {
            if (_GuiTextEditSliderCtrlSetRangeFunc == null)
            {
               _GuiTextEditSliderCtrlSetRangeFunc =
                  (_GuiTextEditSliderCtrlSetRange)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditSliderCtrlSetRange"), typeof(_GuiTextEditSliderCtrlSetRange));
            }

            _GuiTextEditSliderCtrlSetRangeFunc(ctrl, range);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _GuiTextEditSliderCtrlGetIncrement(IntPtr ctrl);
         private static _GuiTextEditSliderCtrlGetIncrement _GuiTextEditSliderCtrlGetIncrementFunc;
         internal static float GuiTextEditSliderCtrlGetIncrement(IntPtr ctrl)
         {
            if (_GuiTextEditSliderCtrlGetIncrementFunc == null)
            {
               _GuiTextEditSliderCtrlGetIncrementFunc =
                  (_GuiTextEditSliderCtrlGetIncrement)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditSliderCtrlGetIncrement"), typeof(_GuiTextEditSliderCtrlGetIncrement));
            }

            return _GuiTextEditSliderCtrlGetIncrementFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextEditSliderCtrlSetIncrement(IntPtr ctrl, float incrementAmount);
         private static _GuiTextEditSliderCtrlSetIncrement _GuiTextEditSliderCtrlSetIncrementFunc;
         internal static void GuiTextEditSliderCtrlSetIncrement(IntPtr ctrl, float incrementAmount)
         {
            if (_GuiTextEditSliderCtrlSetIncrementFunc == null)
            {
               _GuiTextEditSliderCtrlSetIncrementFunc =
                  (_GuiTextEditSliderCtrlSetIncrement)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditSliderCtrlSetIncrement"), typeof(_GuiTextEditSliderCtrlSetIncrement));
            }

            _GuiTextEditSliderCtrlSetIncrementFunc(ctrl, incrementAmount);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTextEditSliderCtrlCreateInstance();
         private static _GuiTextEditSliderCtrlCreateInstance _GuiTextEditSliderCtrlCreateInstanceFunc;
         internal static IntPtr GuiTextEditSliderCtrlCreateInstance()
         {
            if (_GuiTextEditSliderCtrlCreateInstanceFunc == null)
            {
               _GuiTextEditSliderCtrlCreateInstanceFunc =
                  (_GuiTextEditSliderCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditSliderCtrlCreateInstance"), typeof(_GuiTextEditSliderCtrlCreateInstance));
            }

            return _GuiTextEditSliderCtrlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string Format
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiTextEditSliderCtrlGetFormat(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTextEditSliderCtrlSetFormat(ObjectPtr->ObjPtr, value);
         }
      }
      public Point2F Range
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Point2F outVal;
            InternalUnsafeMethods.GuiTextEditSliderCtrlGetRange(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTextEditSliderCtrlSetRange(ObjectPtr->ObjPtr, value);
         }
      }
      public float Increment
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTextEditSliderCtrlGetIncrement(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTextEditSliderCtrlSetIncrement(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}