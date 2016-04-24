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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr EnvironmentProbeCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}