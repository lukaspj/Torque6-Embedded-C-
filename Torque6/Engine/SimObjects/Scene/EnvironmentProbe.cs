using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class EnvironmentProbe : BaseComponent
   {
      
      public EnvironmentProbe()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.EnvironmentProbeCreateInstance());
      }

      public EnvironmentProbe(uint pId) : base(pId)
      {
      }

      public EnvironmentProbe(string pName) : base(pName)
      {
      }

      public EnvironmentProbe(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public EnvironmentProbe(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public EnvironmentProbe(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _EnvironmentProbeCreateInstance();
         private static _EnvironmentProbeCreateInstance _EnvironmentProbeCreateInstanceFunc;
         internal static IntPtr EnvironmentProbeCreateInstance()
         {
            if (_EnvironmentProbeCreateInstanceFunc == null)
            {
               _EnvironmentProbeCreateInstanceFunc =
                  (_EnvironmentProbeCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "EnvironmentProbeCreateInstance"), typeof(_EnvironmentProbeCreateInstance));
            }

            return _EnvironmentProbeCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}