using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class InputManager : SimGroup
   {
      
      public InputManager()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.InputManagerCreateInstance());
      }

      public InputManager(uint pId) : base(pId)
      {
      }

      public InputManager(string pName) : base(pName)
      {
      }

      public InputManager(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public InputManager(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public InputManager(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _InputManagerCreateInstance();
         private static _InputManagerCreateInstance _InputManagerCreateInstanceFunc;
         internal static IntPtr InputManagerCreateInstance()
         {
            if (_InputManagerCreateInstanceFunc == null)
            {
               _InputManagerCreateInstanceFunc =
                  (_InputManagerCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "InputManagerCreateInstance"), typeof(_InputManagerCreateInstance));
            }

            return _InputManagerCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}