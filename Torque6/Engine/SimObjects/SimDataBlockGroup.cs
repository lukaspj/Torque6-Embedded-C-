using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class SimDataBlockGroup : SimGroup
   {
      
      public SimDataBlockGroup()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.SimDataBlockGroupCreateInstance());
      }

      public SimDataBlockGroup(uint pId) : base(pId)
      {
      }

      public SimDataBlockGroup(string pName) : base(pName)
      {
      }

      public SimDataBlockGroup(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public SimDataBlockGroup(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public SimDataBlockGroup(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimDataBlockGroupCreateInstance();
         private static _SimDataBlockGroupCreateInstance _SimDataBlockGroupCreateInstanceFunc;
         internal static IntPtr SimDataBlockGroupCreateInstance()
         {
            if (_SimDataBlockGroupCreateInstanceFunc == null)
            {
               _SimDataBlockGroupCreateInstanceFunc =
                  (_SimDataBlockGroupCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimDataBlockGroupCreateInstance"), typeof(_SimDataBlockGroupCreateInstance));
            }

            return _SimDataBlockGroupCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}