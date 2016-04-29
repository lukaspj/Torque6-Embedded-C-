using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class BehaviorInstance : SimObject
   {
      
      public BehaviorInstance()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.BehaviorInstanceCreateInstance());
      }

      public BehaviorInstance(uint pId) : base(pId)
      {
      }

      public BehaviorInstance(string pName) : base(pName)
      {
      }

      public BehaviorInstance(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public BehaviorInstance(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public BehaviorInstance(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BehaviorInstanceGetTemplate(IntPtr instance);
         private static _BehaviorInstanceGetTemplate _BehaviorInstanceGetTemplateFunc;
         internal static IntPtr BehaviorInstanceGetTemplate(IntPtr instance)
         {
            if (_BehaviorInstanceGetTemplateFunc == null)
            {
               _BehaviorInstanceGetTemplateFunc =
                  (_BehaviorInstanceGetTemplate)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorInstanceGetTemplate"), typeof(_BehaviorInstanceGetTemplate));
            }

            return _BehaviorInstanceGetTemplateFunc(instance);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _BehaviorInstanceSetTemplate(IntPtr instance, IntPtr temp);
         private static _BehaviorInstanceSetTemplate _BehaviorInstanceSetTemplateFunc;
         internal static void BehaviorInstanceSetTemplate(IntPtr instance, IntPtr temp)
         {
            if (_BehaviorInstanceSetTemplateFunc == null)
            {
               _BehaviorInstanceSetTemplateFunc =
                  (_BehaviorInstanceSetTemplate)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorInstanceSetTemplate"), typeof(_BehaviorInstanceSetTemplate));
            }

            _BehaviorInstanceSetTemplateFunc(instance, temp);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BehaviorInstanceGetOwner(IntPtr instance);
         private static _BehaviorInstanceGetOwner _BehaviorInstanceGetOwnerFunc;
         internal static IntPtr BehaviorInstanceGetOwner(IntPtr instance)
         {
            if (_BehaviorInstanceGetOwnerFunc == null)
            {
               _BehaviorInstanceGetOwnerFunc =
                  (_BehaviorInstanceGetOwner)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorInstanceGetOwner"), typeof(_BehaviorInstanceGetOwner));
            }

            return _BehaviorInstanceGetOwnerFunc(instance);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _BehaviorInstanceSetOwner(IntPtr instance, IntPtr val);
         private static _BehaviorInstanceSetOwner _BehaviorInstanceSetOwnerFunc;
         internal static void BehaviorInstanceSetOwner(IntPtr instance, IntPtr val)
         {
            if (_BehaviorInstanceSetOwnerFunc == null)
            {
               _BehaviorInstanceSetOwnerFunc =
                  (_BehaviorInstanceSetOwner)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorInstanceSetOwner"), typeof(_BehaviorInstanceSetOwner));
            }

            _BehaviorInstanceSetOwnerFunc(instance, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BehaviorInstanceCreateInstance();
         private static _BehaviorInstanceCreateInstance _BehaviorInstanceCreateInstanceFunc;
         internal static IntPtr BehaviorInstanceCreateInstance()
         {
            if (_BehaviorInstanceCreateInstanceFunc == null)
            {
               _BehaviorInstanceCreateInstanceFunc =
                  (_BehaviorInstanceCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorInstanceCreateInstance"), typeof(_BehaviorInstanceCreateInstance));
            }

            return _BehaviorInstanceCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BehaviorInstanceGetTemplateName(IntPtr instance);
         private static _BehaviorInstanceGetTemplateName _BehaviorInstanceGetTemplateNameFunc;
         internal static IntPtr BehaviorInstanceGetTemplateName(IntPtr instance)
         {
            if (_BehaviorInstanceGetTemplateNameFunc == null)
            {
               _BehaviorInstanceGetTemplateNameFunc =
                  (_BehaviorInstanceGetTemplateName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorInstanceGetTemplateName"), typeof(_BehaviorInstanceGetTemplateName));
            }

            return _BehaviorInstanceGetTemplateNameFunc(instance);
         }
      }
      
      #endregion

      #region Properties

      public BehaviorTemplate Template
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return new BehaviorTemplate(InternalUnsafeMethods.BehaviorInstanceGetTemplate(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.BehaviorInstanceSetTemplate(ObjectPtr->ObjPtr, value.ObjectPtr->ObjPtr);
         }
      }
      public BehaviorComponent Owner
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return new BehaviorComponent(InternalUnsafeMethods.BehaviorInstanceGetOwner(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.BehaviorInstanceSetOwner(ObjectPtr->ObjPtr, value.ObjectPtr->ObjPtr);
         }
      }
      
      #endregion
      
      #region Methods

      public string GetTemplateName()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.BehaviorInstanceGetTemplateName(ObjectPtr->ObjPtr));
      }
      
      #endregion

      
   }
}