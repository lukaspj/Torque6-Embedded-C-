using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class SimDataBlock : SimObject
   {
      
      public SimDataBlock()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.SimDataBlockCreateInstance());
      }

      public SimDataBlock(uint pId) : base(pId)
      {
      }

      public SimDataBlock(string pName) : base(pName)
      {
      }

      public SimDataBlock(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public SimDataBlock(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public SimDataBlock(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimDataBlockCreateInstance();
         private static _SimDataBlockCreateInstance _SimDataBlockCreateInstanceFunc;
         internal static IntPtr SimDataBlockCreateInstance()
         {
            if (_SimDataBlockCreateInstanceFunc == null)
            {
               _SimDataBlockCreateInstanceFunc =
                  (_SimDataBlockCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimDataBlockCreateInstance"), typeof(_SimDataBlockCreateInstance));
            }

            return _SimDataBlockCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}