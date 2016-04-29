using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiAutoScrollCtrl : GuiTickCtrl
   {
      
      public GuiAutoScrollCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiAutoScrollCtrlCreateInstance());
      }

      public GuiAutoScrollCtrl(uint pId) : base(pId)
      {
      }

      public GuiAutoScrollCtrl(string pName) : base(pName)
      {
      }

      public GuiAutoScrollCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiAutoScrollCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiAutoScrollCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _GuiAutoScrollCtrlGetStartDelay(IntPtr ctrl);
         private static _GuiAutoScrollCtrlGetStartDelay _GuiAutoScrollCtrlGetStartDelayFunc;
         internal static float GuiAutoScrollCtrlGetStartDelay(IntPtr ctrl)
         {
            if (_GuiAutoScrollCtrlGetStartDelayFunc == null)
            {
               _GuiAutoScrollCtrlGetStartDelayFunc =
                  (_GuiAutoScrollCtrlGetStartDelay)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiAutoScrollCtrlGetStartDelay"), typeof(_GuiAutoScrollCtrlGetStartDelay));
            }

            return _GuiAutoScrollCtrlGetStartDelayFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiAutoScrollCtrlSetStartDelay(IntPtr ctrl, float delay);
         private static _GuiAutoScrollCtrlSetStartDelay _GuiAutoScrollCtrlSetStartDelayFunc;
         internal static void GuiAutoScrollCtrlSetStartDelay(IntPtr ctrl, float delay)
         {
            if (_GuiAutoScrollCtrlSetStartDelayFunc == null)
            {
               _GuiAutoScrollCtrlSetStartDelayFunc =
                  (_GuiAutoScrollCtrlSetStartDelay)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiAutoScrollCtrlSetStartDelay"), typeof(_GuiAutoScrollCtrlSetStartDelay));
            }

            _GuiAutoScrollCtrlSetStartDelayFunc(ctrl, delay);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _GuiAutoScrollCtrlGetResetDelay(IntPtr ctrl);
         private static _GuiAutoScrollCtrlGetResetDelay _GuiAutoScrollCtrlGetResetDelayFunc;
         internal static float GuiAutoScrollCtrlGetResetDelay(IntPtr ctrl)
         {
            if (_GuiAutoScrollCtrlGetResetDelayFunc == null)
            {
               _GuiAutoScrollCtrlGetResetDelayFunc =
                  (_GuiAutoScrollCtrlGetResetDelay)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiAutoScrollCtrlGetResetDelay"), typeof(_GuiAutoScrollCtrlGetResetDelay));
            }

            return _GuiAutoScrollCtrlGetResetDelayFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiAutoScrollCtrlSetResetDelay(IntPtr ctrl, float delay);
         private static _GuiAutoScrollCtrlSetResetDelay _GuiAutoScrollCtrlSetResetDelayFunc;
         internal static void GuiAutoScrollCtrlSetResetDelay(IntPtr ctrl, float delay)
         {
            if (_GuiAutoScrollCtrlSetResetDelayFunc == null)
            {
               _GuiAutoScrollCtrlSetResetDelayFunc =
                  (_GuiAutoScrollCtrlSetResetDelay)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiAutoScrollCtrlSetResetDelay"), typeof(_GuiAutoScrollCtrlSetResetDelay));
            }

            _GuiAutoScrollCtrlSetResetDelayFunc(ctrl, delay);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiAutoScrollCtrlGetChildBorder(IntPtr ctrl);
         private static _GuiAutoScrollCtrlGetChildBorder _GuiAutoScrollCtrlGetChildBorderFunc;
         internal static int GuiAutoScrollCtrlGetChildBorder(IntPtr ctrl)
         {
            if (_GuiAutoScrollCtrlGetChildBorderFunc == null)
            {
               _GuiAutoScrollCtrlGetChildBorderFunc =
                  (_GuiAutoScrollCtrlGetChildBorder)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiAutoScrollCtrlGetChildBorder"), typeof(_GuiAutoScrollCtrlGetChildBorder));
            }

            return _GuiAutoScrollCtrlGetChildBorderFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiAutoScrollCtrlSetChildBorder(IntPtr ctrl, int border);
         private static _GuiAutoScrollCtrlSetChildBorder _GuiAutoScrollCtrlSetChildBorderFunc;
         internal static void GuiAutoScrollCtrlSetChildBorder(IntPtr ctrl, int border)
         {
            if (_GuiAutoScrollCtrlSetChildBorderFunc == null)
            {
               _GuiAutoScrollCtrlSetChildBorderFunc =
                  (_GuiAutoScrollCtrlSetChildBorder)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiAutoScrollCtrlSetChildBorder"), typeof(_GuiAutoScrollCtrlSetChildBorder));
            }

            _GuiAutoScrollCtrlSetChildBorderFunc(ctrl, border);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _GuiAutoScrollCtrlGetScrollSpeed(IntPtr ctrl);
         private static _GuiAutoScrollCtrlGetScrollSpeed _GuiAutoScrollCtrlGetScrollSpeedFunc;
         internal static float GuiAutoScrollCtrlGetScrollSpeed(IntPtr ctrl)
         {
            if (_GuiAutoScrollCtrlGetScrollSpeedFunc == null)
            {
               _GuiAutoScrollCtrlGetScrollSpeedFunc =
                  (_GuiAutoScrollCtrlGetScrollSpeed)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiAutoScrollCtrlGetScrollSpeed"), typeof(_GuiAutoScrollCtrlGetScrollSpeed));
            }

            return _GuiAutoScrollCtrlGetScrollSpeedFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiAutoScrollCtrlSetScrollSpeed(IntPtr ctrl, float speed);
         private static _GuiAutoScrollCtrlSetScrollSpeed _GuiAutoScrollCtrlSetScrollSpeedFunc;
         internal static void GuiAutoScrollCtrlSetScrollSpeed(IntPtr ctrl, float speed)
         {
            if (_GuiAutoScrollCtrlSetScrollSpeedFunc == null)
            {
               _GuiAutoScrollCtrlSetScrollSpeedFunc =
                  (_GuiAutoScrollCtrlSetScrollSpeed)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiAutoScrollCtrlSetScrollSpeed"), typeof(_GuiAutoScrollCtrlSetScrollSpeed));
            }

            _GuiAutoScrollCtrlSetScrollSpeedFunc(ctrl, speed);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiAutoScrollCtrlGetTickCallback(IntPtr ctrl);
         private static _GuiAutoScrollCtrlGetTickCallback _GuiAutoScrollCtrlGetTickCallbackFunc;
         internal static bool GuiAutoScrollCtrlGetTickCallback(IntPtr ctrl)
         {
            if (_GuiAutoScrollCtrlGetTickCallbackFunc == null)
            {
               _GuiAutoScrollCtrlGetTickCallbackFunc =
                  (_GuiAutoScrollCtrlGetTickCallback)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiAutoScrollCtrlGetTickCallback"), typeof(_GuiAutoScrollCtrlGetTickCallback));
            }

            return _GuiAutoScrollCtrlGetTickCallbackFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiAutoScrollCtrlSetTickCallback(IntPtr ctrl, bool enable);
         private static _GuiAutoScrollCtrlSetTickCallback _GuiAutoScrollCtrlSetTickCallbackFunc;
         internal static void GuiAutoScrollCtrlSetTickCallback(IntPtr ctrl, bool enable)
         {
            if (_GuiAutoScrollCtrlSetTickCallbackFunc == null)
            {
               _GuiAutoScrollCtrlSetTickCallbackFunc =
                  (_GuiAutoScrollCtrlSetTickCallback)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiAutoScrollCtrlSetTickCallback"), typeof(_GuiAutoScrollCtrlSetTickCallback));
            }

            _GuiAutoScrollCtrlSetTickCallbackFunc(ctrl, enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiAutoScrollCtrlCreateInstance();
         private static _GuiAutoScrollCtrlCreateInstance _GuiAutoScrollCtrlCreateInstanceFunc;
         internal static IntPtr GuiAutoScrollCtrlCreateInstance()
         {
            if (_GuiAutoScrollCtrlCreateInstanceFunc == null)
            {
               _GuiAutoScrollCtrlCreateInstanceFunc =
                  (_GuiAutoScrollCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiAutoScrollCtrlCreateInstance"), typeof(_GuiAutoScrollCtrlCreateInstance));
            }

            return _GuiAutoScrollCtrlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public float StartDelay
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiAutoScrollCtrlGetStartDelay(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiAutoScrollCtrlSetStartDelay(ObjectPtr->ObjPtr, value);
         }
      }
      public float ResetDelay
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiAutoScrollCtrlGetResetDelay(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiAutoScrollCtrlSetResetDelay(ObjectPtr->ObjPtr, value);
         }
      }
      public int ChildBorder
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiAutoScrollCtrlGetChildBorder(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiAutoScrollCtrlSetChildBorder(ObjectPtr->ObjPtr, value);
         }
      }
      public float ScrollSpeed
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiAutoScrollCtrlGetScrollSpeed(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiAutoScrollCtrlSetScrollSpeed(ObjectPtr->ObjPtr, value);
         }
      }
      public bool TickCallback
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiAutoScrollCtrlGetTickCallback(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiAutoScrollCtrlSetTickCallback(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}