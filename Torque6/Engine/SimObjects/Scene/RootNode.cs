using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class RootNode : BaseNode
   {
      
      public RootNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.RootNodeCreateInstance());
      }

      public RootNode(uint pId) : base(pId)
      {
      }

      public RootNode(string pName) : base(pName)
      {
      }

      public RootNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public RootNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public RootNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RootNodeCreateInstance();
         private static _RootNodeCreateInstance _RootNodeCreateInstanceFunc;
         internal static IntPtr RootNodeCreateInstance()
         {
            if (_RootNodeCreateInstanceFunc == null)
            {
               _RootNodeCreateInstanceFunc =
                  (_RootNodeCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "RootNodeCreateInstance"), typeof(_RootNodeCreateInstance));
            }

            return _RootNodeCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}