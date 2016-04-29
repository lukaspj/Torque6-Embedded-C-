using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class SimGroup : SimSet
   {
      
      public SimGroup()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.SimGroupCreateInstance());
      }

      public SimGroup(uint pId) : base(pId)
      {
      }

      public SimGroup(string pName) : base(pName)
      {
      }

      public SimGroup(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public SimGroup(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public SimGroup(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimGroupCreateInstance();
         private static _SimGroupCreateInstance _SimGroupCreateInstanceFunc;
         internal static IntPtr SimGroupCreateInstance()
         {
            if (_SimGroupCreateInstanceFunc == null)
            {
               _SimGroupCreateInstanceFunc =
                  (_SimGroupCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimGroupCreateInstance"), typeof(_SimGroupCreateInstance));
            }

            return _SimGroupCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}