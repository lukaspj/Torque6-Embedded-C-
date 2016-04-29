using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class DLAA : BaseComponent
   {
      
      public DLAA()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.DLAACreateInstance());
      }

      public DLAA(uint pId) : base(pId)
      {
      }

      public DLAA(string pName) : base(pName)
      {
      }

      public DLAA(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public DLAA(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public DLAA(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DLAACreateInstance();
         private static _DLAACreateInstance _DLAACreateInstanceFunc;
         internal static IntPtr DLAACreateInstance()
         {
            if (_DLAACreateInstanceFunc == null)
            {
               _DLAACreateInstanceFunc =
                  (_DLAACreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DLAACreateInstance"), typeof(_DLAACreateInstance));
            }

            return _DLAACreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}