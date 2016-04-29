using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class ControllerComponent : BaseComponent
   {
      
      public ControllerComponent()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.ControllerComponentCreateInstance());
      }

      public ControllerComponent(uint pId) : base(pId)
      {
      }

      public ControllerComponent(string pName) : base(pName)
      {
      }

      public ControllerComponent(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public ControllerComponent(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public ControllerComponent(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ControllerComponentGetCaptureMouse(IntPtr controller);
         private static _ControllerComponentGetCaptureMouse _ControllerComponentGetCaptureMouseFunc;
         internal static bool ControllerComponentGetCaptureMouse(IntPtr controller)
         {
            if (_ControllerComponentGetCaptureMouseFunc == null)
            {
               _ControllerComponentGetCaptureMouseFunc =
                  (_ControllerComponentGetCaptureMouse)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ControllerComponentGetCaptureMouse"), typeof(_ControllerComponentGetCaptureMouse));
            }

            return _ControllerComponentGetCaptureMouseFunc(controller);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ControllerComponentSetCaptureMouse(IntPtr controller, bool capture);
         private static _ControllerComponentSetCaptureMouse _ControllerComponentSetCaptureMouseFunc;
         internal static void ControllerComponentSetCaptureMouse(IntPtr controller, bool capture)
         {
            if (_ControllerComponentSetCaptureMouseFunc == null)
            {
               _ControllerComponentSetCaptureMouseFunc =
                  (_ControllerComponentSetCaptureMouse)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ControllerComponentSetCaptureMouse"), typeof(_ControllerComponentSetCaptureMouse));
            }

            _ControllerComponentSetCaptureMouseFunc(controller, capture);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ControllerComponentCreateInstance();
         private static _ControllerComponentCreateInstance _ControllerComponentCreateInstanceFunc;
         internal static IntPtr ControllerComponentCreateInstance()
         {
            if (_ControllerComponentCreateInstanceFunc == null)
            {
               _ControllerComponentCreateInstanceFunc =
                  (_ControllerComponentCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ControllerComponentCreateInstance"), typeof(_ControllerComponentCreateInstance));
            }

            return _ControllerComponentCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ControllerComponentSetForwardVelocity(IntPtr controller, Point3F panVel);
         private static _ControllerComponentSetForwardVelocity _ControllerComponentSetForwardVelocityFunc;
         internal static void ControllerComponentSetForwardVelocity(IntPtr controller, Point3F panVel)
         {
            if (_ControllerComponentSetForwardVelocityFunc == null)
            {
               _ControllerComponentSetForwardVelocityFunc =
                  (_ControllerComponentSetForwardVelocity)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ControllerComponentSetForwardVelocity"), typeof(_ControllerComponentSetForwardVelocity));
            }

            _ControllerComponentSetForwardVelocityFunc(controller, panVel);
         }
      }
      
      #endregion

      #region Properties

      public bool CaptureMouse
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ControllerComponentGetCaptureMouse(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ControllerComponentSetCaptureMouse(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public void SetForwardVelocity(Point3F panVel)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.ControllerComponentSetForwardVelocity(ObjectPtr->ObjPtr, panVel);
      }
      
      #endregion

      
   }
}