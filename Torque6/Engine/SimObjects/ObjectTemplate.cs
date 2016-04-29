using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class ObjectTemplate : SimGroup
   {
      
      public ObjectTemplate()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.ObjectTemplateCreateInstance());
      }

      public ObjectTemplate(uint pId) : base(pId)
      {
      }

      public ObjectTemplate(string pName) : base(pName)
      {
      }

      public ObjectTemplate(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public ObjectTemplate(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public ObjectTemplate(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ObjectTemplateCreateInstance();
         private static _ObjectTemplateCreateInstance _ObjectTemplateCreateInstanceFunc;
         internal static IntPtr ObjectTemplateCreateInstance()
         {
            if (_ObjectTemplateCreateInstanceFunc == null)
            {
               _ObjectTemplateCreateInstanceFunc =
                  (_ObjectTemplateCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ObjectTemplateCreateInstance"), typeof(_ObjectTemplateCreateInstance));
            }

            return _ObjectTemplateCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}