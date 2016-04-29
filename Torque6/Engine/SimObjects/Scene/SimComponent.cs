using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class SimComponent : SimObject
   {
      
      public SimComponent()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.SimComponentCreateInstance());
      }

      public SimComponent(uint pId) : base(pId)
      {
      }

      public SimComponent(string pName) : base(pName)
      {
      }

      public SimComponent(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public SimComponent(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public SimComponent(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimComponentGetEnabled(IntPtr component);
         private static _SimComponentGetEnabled _SimComponentGetEnabledFunc;
         internal static bool SimComponentGetEnabled(IntPtr component)
         {
            if (_SimComponentGetEnabledFunc == null)
            {
               _SimComponentGetEnabledFunc =
                  (_SimComponentGetEnabled)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimComponentGetEnabled"), typeof(_SimComponentGetEnabled));
            }

            return _SimComponentGetEnabledFunc(component);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimComponentSetEnabled(IntPtr component, bool isEnabled);
         private static _SimComponentSetEnabled _SimComponentSetEnabledFunc;
         internal static void SimComponentSetEnabled(IntPtr component, bool isEnabled)
         {
            if (_SimComponentSetEnabledFunc == null)
            {
               _SimComponentSetEnabledFunc =
                  (_SimComponentSetEnabled)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimComponentSetEnabled"), typeof(_SimComponentSetEnabled));
            }

            _SimComponentSetEnabledFunc(component, isEnabled);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimComponentCreateInstance();
         private static _SimComponentCreateInstance _SimComponentCreateInstanceFunc;
         internal static IntPtr SimComponentCreateInstance()
         {
            if (_SimComponentCreateInstanceFunc == null)
            {
               _SimComponentCreateInstanceFunc =
                  (_SimComponentCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimComponentCreateInstance"), typeof(_SimComponentCreateInstance));
            }

            return _SimComponentCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimComponentAddComponents(IntPtr component, int argc, IntPtr[] argv);
         private static _SimComponentAddComponents _SimComponentAddComponentsFunc;
         internal static bool SimComponentAddComponents(IntPtr component, int argc, IntPtr[] argv)
         {
            if (_SimComponentAddComponentsFunc == null)
            {
               _SimComponentAddComponentsFunc =
                  (_SimComponentAddComponents)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimComponentAddComponents"), typeof(_SimComponentAddComponents));
            }

            return _SimComponentAddComponentsFunc(component, argc, argv);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimComponentRemoveComponents(IntPtr component, int argc, IntPtr[] argv);
         private static _SimComponentRemoveComponents _SimComponentRemoveComponentsFunc;
         internal static bool SimComponentRemoveComponents(IntPtr component, int argc, IntPtr[] argv)
         {
            if (_SimComponentRemoveComponentsFunc == null)
            {
               _SimComponentRemoveComponentsFunc =
                  (_SimComponentRemoveComponents)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimComponentRemoveComponents"), typeof(_SimComponentRemoveComponents));
            }

            return _SimComponentRemoveComponentsFunc(component, argc, argv);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SimComponentGetComponentCount(IntPtr component);
         private static _SimComponentGetComponentCount _SimComponentGetComponentCountFunc;
         internal static int SimComponentGetComponentCount(IntPtr component)
         {
            if (_SimComponentGetComponentCountFunc == null)
            {
               _SimComponentGetComponentCountFunc =
                  (_SimComponentGetComponentCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimComponentGetComponentCount"), typeof(_SimComponentGetComponentCount));
            }

            return _SimComponentGetComponentCountFunc(component);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimComponentGetComponent(IntPtr component, int index);
         private static _SimComponentGetComponent _SimComponentGetComponentFunc;
         internal static IntPtr SimComponentGetComponent(IntPtr component, int index)
         {
            if (_SimComponentGetComponentFunc == null)
            {
               _SimComponentGetComponentFunc =
                  (_SimComponentGetComponent)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimComponentGetComponent"), typeof(_SimComponentGetComponent));
            }

            return _SimComponentGetComponentFunc(component, index);
         }
      }
      
      #endregion

      #region Properties

      public bool Enabled
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.SimComponentGetEnabled(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.SimComponentSetEnabled(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public bool AddComponents(int argc, SimObject[] argv)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimComponentAddComponents(ObjectPtr->ObjPtr, argc, argv.Select(x => x.ObjectPtr->ObjPtr).ToArray());
      }

      public bool RemoveComponents(int argc, SimObject[] argv)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimComponentRemoveComponents(ObjectPtr->ObjPtr, argc, argv.Select(x => x.ObjectPtr->ObjPtr).ToArray());
      }

      public int GetComponentCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimComponentGetComponentCount(ObjectPtr->ObjPtr);
      }

      public SimComponent GetComponent(int index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new SimComponent(InternalUnsafeMethods.SimComponentGetComponent(ObjectPtr->ObjPtr, index));
      }
      
      #endregion

      
   }
}