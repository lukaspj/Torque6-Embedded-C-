using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiSliderCtrl : GuiControl
   {
      
      public GuiSliderCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiSliderCtrlCreateInstance());
      }

      public GuiSliderCtrl(uint pId) : base(pId)
      {
      }

      public GuiSliderCtrl(string pName) : base(pName)
      {
      }

      public GuiSliderCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiSliderCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiSliderCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiSliderCtrlGetRange(IntPtr ctrl, out Point2F outRange);
         private static _GuiSliderCtrlGetRange _GuiSliderCtrlGetRangeFunc;
         internal static void GuiSliderCtrlGetRange(IntPtr ctrl, out Point2F outRange)
         {
            if (_GuiSliderCtrlGetRangeFunc == null)
            {
               _GuiSliderCtrlGetRangeFunc =
                  (_GuiSliderCtrlGetRange)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSliderCtrlGetRange"), typeof(_GuiSliderCtrlGetRange));
            }

            _GuiSliderCtrlGetRangeFunc(ctrl, out outRange);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiSliderCtrlSetRange(IntPtr ctrl, Point2F range);
         private static _GuiSliderCtrlSetRange _GuiSliderCtrlSetRangeFunc;
         internal static void GuiSliderCtrlSetRange(IntPtr ctrl, Point2F range)
         {
            if (_GuiSliderCtrlSetRangeFunc == null)
            {
               _GuiSliderCtrlSetRangeFunc =
                  (_GuiSliderCtrlSetRange)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSliderCtrlSetRange"), typeof(_GuiSliderCtrlSetRange));
            }

            _GuiSliderCtrlSetRangeFunc(ctrl, range);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiSliderCtrlGetTicks(IntPtr ctrl);
         private static _GuiSliderCtrlGetTicks _GuiSliderCtrlGetTicksFunc;
         internal static int GuiSliderCtrlGetTicks(IntPtr ctrl)
         {
            if (_GuiSliderCtrlGetTicksFunc == null)
            {
               _GuiSliderCtrlGetTicksFunc =
                  (_GuiSliderCtrlGetTicks)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSliderCtrlGetTicks"), typeof(_GuiSliderCtrlGetTicks));
            }

            return _GuiSliderCtrlGetTicksFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiSliderCtrlSetTicks(IntPtr ctrl, int ticks);
         private static _GuiSliderCtrlSetTicks _GuiSliderCtrlSetTicksFunc;
         internal static void GuiSliderCtrlSetTicks(IntPtr ctrl, int ticks)
         {
            if (_GuiSliderCtrlSetTicksFunc == null)
            {
               _GuiSliderCtrlSetTicksFunc =
                  (_GuiSliderCtrlSetTicks)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSliderCtrlSetTicks"), typeof(_GuiSliderCtrlSetTicks));
            }

            _GuiSliderCtrlSetTicksFunc(ctrl, ticks);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _GuiSliderCtrlGetValue(IntPtr ctrl);
         private static _GuiSliderCtrlGetValue _GuiSliderCtrlGetValueFunc;
         internal static float GuiSliderCtrlGetValue(IntPtr ctrl)
         {
            if (_GuiSliderCtrlGetValueFunc == null)
            {
               _GuiSliderCtrlGetValueFunc =
                  (_GuiSliderCtrlGetValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSliderCtrlGetValue"), typeof(_GuiSliderCtrlGetValue));
            }

            return _GuiSliderCtrlGetValueFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiSliderCtrlSetValue(IntPtr ctrl, float value);
         private static _GuiSliderCtrlSetValue _GuiSliderCtrlSetValueFunc;
         internal static void GuiSliderCtrlSetValue(IntPtr ctrl, float value)
         {
            if (_GuiSliderCtrlSetValueFunc == null)
            {
               _GuiSliderCtrlSetValueFunc =
                  (_GuiSliderCtrlSetValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSliderCtrlSetValue"), typeof(_GuiSliderCtrlSetValue));
            }

            _GuiSliderCtrlSetValueFunc(ctrl, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiSliderCtrlCreateInstance();
         private static _GuiSliderCtrlCreateInstance _GuiSliderCtrlCreateInstanceFunc;
         internal static IntPtr GuiSliderCtrlCreateInstance()
         {
            if (_GuiSliderCtrlCreateInstanceFunc == null)
            {
               _GuiSliderCtrlCreateInstanceFunc =
                  (_GuiSliderCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiSliderCtrlCreateInstance"), typeof(_GuiSliderCtrlCreateInstance));
            }

            return _GuiSliderCtrlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public Point2F Range
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Point2F outVal;
            InternalUnsafeMethods.GuiSliderCtrlGetRange(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiSliderCtrlSetRange(ObjectPtr->ObjPtr, value);
         }
      }
      public int Ticks
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiSliderCtrlGetTicks(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiSliderCtrlSetTicks(ObjectPtr->ObjPtr, value);
         }
      }
      public float Value
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiSliderCtrlGetValue(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiSliderCtrlSetValue(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}