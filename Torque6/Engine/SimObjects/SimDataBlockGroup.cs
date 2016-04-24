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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr SimDataBlockGroupCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}