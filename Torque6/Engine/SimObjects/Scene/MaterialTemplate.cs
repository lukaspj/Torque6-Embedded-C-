using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class MaterialTemplate : SimGroup
   {
      
      public MaterialTemplate()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.MaterialTemplateCreateInstance());
      }

      public MaterialTemplate(uint pId) : base(pId)
      {
      }

      public MaterialTemplate(string pName) : base(pName)
      {
      }

      public MaterialTemplate(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public MaterialTemplate(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public MaterialTemplate(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MaterialTemplateCreateInstance();
         private static _MaterialTemplateCreateInstance _MaterialTemplateCreateInstanceFunc;
         internal static IntPtr MaterialTemplateCreateInstance()
         {
            if (_MaterialTemplateCreateInstanceFunc == null)
            {
               _MaterialTemplateCreateInstanceFunc =
                  (_MaterialTemplateCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MaterialTemplateCreateInstance"), typeof(_MaterialTemplateCreateInstance));
            }

            return _MaterialTemplateCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}