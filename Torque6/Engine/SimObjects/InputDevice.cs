using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class InputDevice : SimObject
   {
      
      public InputDevice()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.InputDeviceCreateInstance());
      }

      public InputDevice(uint pId) : base(pId)
      {
      }

      public InputDevice(string pName) : base(pName)
      {
      }

      public InputDevice(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public InputDevice(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public InputDevice(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr InputDeviceCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}