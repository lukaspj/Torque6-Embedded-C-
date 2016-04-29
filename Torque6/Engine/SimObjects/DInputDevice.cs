using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class DInputDevice : InputDevice
   {
      
      public DInputDevice()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.DInputDeviceCreateInstance());
      }

      public DInputDevice(uint pId) : base(pId)
      {
      }

      public DInputDevice(string pName) : base(pName)
      {
      }

      public DInputDevice(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public DInputDevice(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public DInputDevice(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DInputDeviceCreateInstance();
         private static _DInputDeviceCreateInstance _DInputDeviceCreateInstanceFunc;
         internal static IntPtr DInputDeviceCreateInstance()
         {
            if (_DInputDeviceCreateInstanceFunc == null)
            {
               _DInputDeviceCreateInstanceFunc =
                  (_DInputDeviceCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DInputDeviceCreateInstance"), typeof(_DInputDeviceCreateInstance));
            }

            return _DInputDeviceCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}