using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class DecalComponent : BaseComponent
   {
      
      public DecalComponent()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.DecalComponentCreateInstance());
      }

      public DecalComponent(uint pId) : base(pId)
      {
      }

      public DecalComponent(string pName) : base(pName)
      {
      }

      public DecalComponent(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public DecalComponent(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public DecalComponent(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DecalComponentCreateInstance();
         private static _DecalComponentCreateInstance _DecalComponentCreateInstanceFunc;
         internal static IntPtr DecalComponentCreateInstance()
         {
            if (_DecalComponentCreateInstanceFunc == null)
            {
               _DecalComponentCreateInstanceFunc =
                  (_DecalComponentCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DecalComponentCreateInstance"), typeof(_DecalComponentCreateInstance));
            }

            return _DecalComponentCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}