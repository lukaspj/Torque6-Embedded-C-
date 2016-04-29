using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiFilterCtrl : GuiControl
   {
      
      public GuiFilterCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiFilterCtrlCreateInstance());
      }

      public GuiFilterCtrl(uint pId) : base(pId)
      {
      }

      public GuiFilterCtrl(string pName) : base(pName)
      {
      }

      public GuiFilterCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiFilterCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiFilterCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiFilterCtrlGetControlPoints(IntPtr ctrl);
         private static _GuiFilterCtrlGetControlPoints _GuiFilterCtrlGetControlPointsFunc;
         internal static int GuiFilterCtrlGetControlPoints(IntPtr ctrl)
         {
            if (_GuiFilterCtrlGetControlPointsFunc == null)
            {
               _GuiFilterCtrlGetControlPointsFunc =
                  (_GuiFilterCtrlGetControlPoints)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFilterCtrlGetControlPoints"), typeof(_GuiFilterCtrlGetControlPoints));
            }

            return _GuiFilterCtrlGetControlPointsFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFilterCtrlSetControlPoints(IntPtr ctrl, int points);
         private static _GuiFilterCtrlSetControlPoints _GuiFilterCtrlSetControlPointsFunc;
         internal static void GuiFilterCtrlSetControlPoints(IntPtr ctrl, int points)
         {
            if (_GuiFilterCtrlSetControlPointsFunc == null)
            {
               _GuiFilterCtrlSetControlPointsFunc =
                  (_GuiFilterCtrlSetControlPoints)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFilterCtrlSetControlPoints"), typeof(_GuiFilterCtrlSetControlPoints));
            }

            _GuiFilterCtrlSetControlPointsFunc(ctrl, points);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiFilterCtrlCreateInstance();
         private static _GuiFilterCtrlCreateInstance _GuiFilterCtrlCreateInstanceFunc;
         internal static IntPtr GuiFilterCtrlCreateInstance()
         {
            if (_GuiFilterCtrlCreateInstanceFunc == null)
            {
               _GuiFilterCtrlCreateInstanceFunc =
                  (_GuiFilterCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFilterCtrlCreateInstance"), typeof(_GuiFilterCtrlCreateInstance));
            }

            return _GuiFilterCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiFilterCtrlGetValue(IntPtr ctrl);
         private static _GuiFilterCtrlGetValue _GuiFilterCtrlGetValueFunc;
         internal static IntPtr GuiFilterCtrlGetValue(IntPtr ctrl)
         {
            if (_GuiFilterCtrlGetValueFunc == null)
            {
               _GuiFilterCtrlGetValueFunc =
                  (_GuiFilterCtrlGetValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFilterCtrlGetValue"), typeof(_GuiFilterCtrlGetValue));
            }

            return _GuiFilterCtrlGetValueFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFilterCtrlSetValue(IntPtr ctrl, int argc, string[] argv);
         private static _GuiFilterCtrlSetValue _GuiFilterCtrlSetValueFunc;
         internal static void GuiFilterCtrlSetValue(IntPtr ctrl, int argc, string[] argv)
         {
            if (_GuiFilterCtrlSetValueFunc == null)
            {
               _GuiFilterCtrlSetValueFunc =
                  (_GuiFilterCtrlSetValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFilterCtrlSetValue"), typeof(_GuiFilterCtrlSetValue));
            }

            _GuiFilterCtrlSetValueFunc(ctrl, argc, argv);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFilterCtrlIdentity(IntPtr ctrl);
         private static _GuiFilterCtrlIdentity _GuiFilterCtrlIdentityFunc;
         internal static void GuiFilterCtrlIdentity(IntPtr ctrl)
         {
            if (_GuiFilterCtrlIdentityFunc == null)
            {
               _GuiFilterCtrlIdentityFunc =
                  (_GuiFilterCtrlIdentity)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFilterCtrlIdentity"), typeof(_GuiFilterCtrlIdentity));
            }

            _GuiFilterCtrlIdentityFunc(ctrl);
         }
      }
      
      #endregion

      #region Properties

      public int ControlPoints
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiFilterCtrlGetControlPoints(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiFilterCtrlSetControlPoints(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public string GetValue()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiFilterCtrlGetValue(ObjectPtr->ObjPtr));
      }

      public void SetValue(int argc, string[] argv)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiFilterCtrlSetValue(ObjectPtr->ObjPtr, argc, argv);
      }

      public void Identity()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiFilterCtrlIdentity(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}