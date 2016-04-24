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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr DInputDeviceCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}