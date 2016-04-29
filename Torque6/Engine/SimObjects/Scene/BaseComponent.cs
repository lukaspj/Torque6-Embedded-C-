using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class BaseComponent : SimObject
   {
      
      public BaseComponent()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.BaseComponentCreateInstance());
      }

      public BaseComponent(uint pId) : base(pId)
      {
      }

      public BaseComponent(string pName) : base(pName)
      {
      }

      public BaseComponent(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public BaseComponent(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public BaseComponent(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BaseComponentCreateInstance();
         private static _BaseComponentCreateInstance _BaseComponentCreateInstanceFunc;
         internal static IntPtr BaseComponentCreateInstance()
         {
            if (_BaseComponentCreateInstanceFunc == null)
            {
               _BaseComponentCreateInstanceFunc =
                  (_BaseComponentCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BaseComponentCreateInstance"), typeof(_BaseComponentCreateInstance));
            }

            return _BaseComponentCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _BaseComponentSetUniformVec4(IntPtr baseComponent, string name, Point4F value);
         private static _BaseComponentSetUniformVec4 _BaseComponentSetUniformVec4Func;
         internal static void BaseComponentSetUniformVec4(IntPtr baseComponent, string name, Point4F value)
         {
            if (_BaseComponentSetUniformVec4Func == null)
            {
               _BaseComponentSetUniformVec4Func =
                  (_BaseComponentSetUniformVec4)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BaseComponentSetUniformVec4"), typeof(_BaseComponentSetUniformVec4));
            }

            _BaseComponentSetUniformVec4Func(baseComponent, name, value);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void SetUniformVec4(string name, Point4F value)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.BaseComponentSetUniformVec4(ObjectPtr->ObjPtr, name, value);
      }
      
      #endregion

      
   }
}