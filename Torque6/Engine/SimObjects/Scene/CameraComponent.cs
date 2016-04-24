using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class CameraComponent : BaseComponent
   {
      
      public CameraComponent()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.CameraComponentCreateInstance());
      }

      public CameraComponent(uint pId) : base(pId)
      {
      }

      public CameraComponent(string pName) : base(pName)
      {
      }

      public CameraComponent(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public CameraComponent(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public CameraComponent(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr CameraComponentCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}