using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class JoystickInputDevice : InputDevice
   {
      
      public JoystickInputDevice()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.JoystickInputDeviceCreateInstance());
      }

      public JoystickInputDevice(uint pId) : base(pId)
      {
      }

      public JoystickInputDevice(string pName) : base(pName)
      {
      }

      public JoystickInputDevice(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public JoystickInputDevice(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public JoystickInputDevice(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}