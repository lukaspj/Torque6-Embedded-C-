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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr DLAACreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}