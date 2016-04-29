using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class BehaviorComponent : DynamicConsoleMethodComponent
   {
      
      public BehaviorComponent()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.BehaviorComponentCreateInstance());
      }

      public BehaviorComponent(uint pId) : base(pId)
      {
      }

      public BehaviorComponent(string pName) : base(pName)
      {
      }

      public BehaviorComponent(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public BehaviorComponent(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public BehaviorComponent(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BehaviorComponentCreateInstance();
         private static _BehaviorComponentCreateInstance _BehaviorComponentCreateInstanceFunc;
         internal static IntPtr BehaviorComponentCreateInstance()
         {
            if (_BehaviorComponentCreateInstanceFunc == null)
            {
               _BehaviorComponentCreateInstanceFunc =
                  (_BehaviorComponentCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorComponentCreateInstance"), typeof(_BehaviorComponentCreateInstance));
            }

            return _BehaviorComponentCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _BehaviorComponentAddBehavior(IntPtr component, IntPtr inst);
         private static _BehaviorComponentAddBehavior _BehaviorComponentAddBehaviorFunc;
         internal static bool BehaviorComponentAddBehavior(IntPtr component, IntPtr inst)
         {
            if (_BehaviorComponentAddBehaviorFunc == null)
            {
               _BehaviorComponentAddBehaviorFunc =
                  (_BehaviorComponentAddBehavior)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorComponentAddBehavior"), typeof(_BehaviorComponentAddBehavior));
            }

            return _BehaviorComponentAddBehaviorFunc(component, inst);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _BehaviorComponentRemoveBehavior(IntPtr component, IntPtr inst, bool deleteBehavior);
         private static _BehaviorComponentRemoveBehavior _BehaviorComponentRemoveBehaviorFunc;
         internal static bool BehaviorComponentRemoveBehavior(IntPtr component, IntPtr inst, bool deleteBehavior)
         {
            if (_BehaviorComponentRemoveBehaviorFunc == null)
            {
               _BehaviorComponentRemoveBehaviorFunc =
                  (_BehaviorComponentRemoveBehavior)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorComponentRemoveBehavior"), typeof(_BehaviorComponentRemoveBehavior));
            }

            return _BehaviorComponentRemoveBehaviorFunc(component, inst, deleteBehavior);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _BehaviorComponentClearBehaviors(IntPtr component);
         private static _BehaviorComponentClearBehaviors _BehaviorComponentClearBehaviorsFunc;
         internal static void BehaviorComponentClearBehaviors(IntPtr component)
         {
            if (_BehaviorComponentClearBehaviorsFunc == null)
            {
               _BehaviorComponentClearBehaviorsFunc =
                  (_BehaviorComponentClearBehaviors)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorComponentClearBehaviors"), typeof(_BehaviorComponentClearBehaviors));
            }

            _BehaviorComponentClearBehaviorsFunc(component);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _BehaviorComponentGetBehaviorCount(IntPtr component);
         private static _BehaviorComponentGetBehaviorCount _BehaviorComponentGetBehaviorCountFunc;
         internal static int BehaviorComponentGetBehaviorCount(IntPtr component)
         {
            if (_BehaviorComponentGetBehaviorCountFunc == null)
            {
               _BehaviorComponentGetBehaviorCountFunc =
                  (_BehaviorComponentGetBehaviorCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorComponentGetBehaviorCount"), typeof(_BehaviorComponentGetBehaviorCount));
            }

            return _BehaviorComponentGetBehaviorCountFunc(component);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BehaviorComponentGetBehavior(IntPtr component, string name);
         private static _BehaviorComponentGetBehavior _BehaviorComponentGetBehaviorFunc;
         internal static IntPtr BehaviorComponentGetBehavior(IntPtr component, string name)
         {
            if (_BehaviorComponentGetBehaviorFunc == null)
            {
               _BehaviorComponentGetBehaviorFunc =
                  (_BehaviorComponentGetBehavior)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorComponentGetBehavior"), typeof(_BehaviorComponentGetBehavior));
            }

            return _BehaviorComponentGetBehaviorFunc(component, name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BehaviorComponentGetBehaviorByIndex(IntPtr component, uint index);
         private static _BehaviorComponentGetBehaviorByIndex _BehaviorComponentGetBehaviorByIndexFunc;
         internal static IntPtr BehaviorComponentGetBehaviorByIndex(IntPtr component, uint index)
         {
            if (_BehaviorComponentGetBehaviorByIndexFunc == null)
            {
               _BehaviorComponentGetBehaviorByIndexFunc =
                  (_BehaviorComponentGetBehaviorByIndex)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorComponentGetBehaviorByIndex"), typeof(_BehaviorComponentGetBehaviorByIndex));
            }

            return _BehaviorComponentGetBehaviorByIndexFunc(component, index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _BehaviorComponentReOrder(IntPtr component, IntPtr inst, uint index);
         private static _BehaviorComponentReOrder _BehaviorComponentReOrderFunc;
         internal static bool BehaviorComponentReOrder(IntPtr component, IntPtr inst, uint index)
         {
            if (_BehaviorComponentReOrderFunc == null)
            {
               _BehaviorComponentReOrderFunc =
                  (_BehaviorComponentReOrder)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorComponentReOrder"), typeof(_BehaviorComponentReOrder));
            }

            return _BehaviorComponentReOrderFunc(component, inst, index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _BehaviorComponentConnect(IntPtr component, IntPtr outputBehavior, string outputName, IntPtr inputBehavior, string inputName);
         private static _BehaviorComponentConnect _BehaviorComponentConnectFunc;
         internal static bool BehaviorComponentConnect(IntPtr component, IntPtr outputBehavior, string outputName, IntPtr inputBehavior, string inputName)
         {
            if (_BehaviorComponentConnectFunc == null)
            {
               _BehaviorComponentConnectFunc =
                  (_BehaviorComponentConnect)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorComponentConnect"), typeof(_BehaviorComponentConnect));
            }

            return _BehaviorComponentConnectFunc(component, outputBehavior, outputName, inputBehavior, inputName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _BehaviorComponentDisconnect(IntPtr component, IntPtr outputBehavior, string outputName, IntPtr inputBehavior, string inputName);
         private static _BehaviorComponentDisconnect _BehaviorComponentDisconnectFunc;
         internal static bool BehaviorComponentDisconnect(IntPtr component, IntPtr outputBehavior, string outputName, IntPtr inputBehavior, string inputName)
         {
            if (_BehaviorComponentDisconnectFunc == null)
            {
               _BehaviorComponentDisconnectFunc =
                  (_BehaviorComponentDisconnect)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorComponentDisconnect"), typeof(_BehaviorComponentDisconnect));
            }

            return _BehaviorComponentDisconnectFunc(component, outputBehavior, outputName, inputBehavior, inputName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _BehaviorComponentRaise(IntPtr component, IntPtr outputBehavior, string outputName, uint timeDelta);
         private static _BehaviorComponentRaise _BehaviorComponentRaiseFunc;
         internal static bool BehaviorComponentRaise(IntPtr component, IntPtr outputBehavior, string outputName, uint timeDelta)
         {
            if (_BehaviorComponentRaiseFunc == null)
            {
               _BehaviorComponentRaiseFunc =
                  (_BehaviorComponentRaise)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorComponentRaise"), typeof(_BehaviorComponentRaise));
            }

            return _BehaviorComponentRaiseFunc(component, outputBehavior, outputName, timeDelta);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate uint _BehaviorComponentGetBehaviorConnectionCount(IntPtr component, IntPtr outputBehavior, string outputName);
         private static _BehaviorComponentGetBehaviorConnectionCount _BehaviorComponentGetBehaviorConnectionCountFunc;
         internal static uint BehaviorComponentGetBehaviorConnectionCount(IntPtr component, IntPtr outputBehavior, string outputName)
         {
            if (_BehaviorComponentGetBehaviorConnectionCountFunc == null)
            {
               _BehaviorComponentGetBehaviorConnectionCountFunc =
                  (_BehaviorComponentGetBehaviorConnectionCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorComponentGetBehaviorConnectionCount"), typeof(_BehaviorComponentGetBehaviorConnectionCount));
            }

            return _BehaviorComponentGetBehaviorConnectionCountFunc(component, outputBehavior, outputName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BehaviorComponentGetBehaviorConnection(IntPtr component, IntPtr outputBehavior, string outputName, uint connectionIndex);
         private static _BehaviorComponentGetBehaviorConnection _BehaviorComponentGetBehaviorConnectionFunc;
         internal static IntPtr BehaviorComponentGetBehaviorConnection(IntPtr component, IntPtr outputBehavior, string outputName, uint connectionIndex)
         {
            if (_BehaviorComponentGetBehaviorConnectionFunc == null)
            {
               _BehaviorComponentGetBehaviorConnectionFunc =
                  (_BehaviorComponentGetBehaviorConnection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorComponentGetBehaviorConnection"), typeof(_BehaviorComponentGetBehaviorConnection));
            }

            return _BehaviorComponentGetBehaviorConnectionFunc(component, outputBehavior, outputName, connectionIndex);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public bool AddBehavior(BehaviorInstance inst)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.BehaviorComponentAddBehavior(ObjectPtr->ObjPtr, inst.ObjectPtr->ObjPtr);
      }

      public bool RemoveBehavior(BehaviorInstance inst, bool deleteBehavior = true)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.BehaviorComponentRemoveBehavior(ObjectPtr->ObjPtr, inst.ObjectPtr->ObjPtr, deleteBehavior);
      }

      public void ClearBehaviors()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.BehaviorComponentClearBehaviors(ObjectPtr->ObjPtr);
      }

      public int GetBehaviorCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.BehaviorComponentGetBehaviorCount(ObjectPtr->ObjPtr);
      }

      public BehaviorInstance GetBehavior(string name)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new BehaviorInstance(InternalUnsafeMethods.BehaviorComponentGetBehavior(ObjectPtr->ObjPtr, name));
      }

      public BehaviorInstance GetBehaviorByIndex(uint index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new BehaviorInstance(InternalUnsafeMethods.BehaviorComponentGetBehaviorByIndex(ObjectPtr->ObjPtr, index));
      }

      public bool ReOrder(BehaviorInstance inst, uint index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.BehaviorComponentReOrder(ObjectPtr->ObjPtr, inst.ObjectPtr->ObjPtr, index);
      }

      public bool Connect(BehaviorInstance outputBehavior, string outputName, BehaviorInstance inputBehavior, string inputName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.BehaviorComponentConnect(ObjectPtr->ObjPtr, outputBehavior.ObjectPtr->ObjPtr, outputName, inputBehavior.ObjectPtr->ObjPtr, inputName);
      }

      public bool Disconnect(BehaviorInstance outputBehavior, string outputName, BehaviorInstance inputBehavior, string inputName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.BehaviorComponentDisconnect(ObjectPtr->ObjPtr, outputBehavior.ObjectPtr->ObjPtr, outputName, inputBehavior.ObjectPtr->ObjPtr, inputName);
      }

      public bool Raise(BehaviorInstance outputBehavior, string outputName, uint timeDelta = 0)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.BehaviorComponentRaise(ObjectPtr->ObjPtr, outputBehavior.ObjectPtr->ObjPtr, outputName, timeDelta);
      }

      public uint GetBehaviorConnectionCount(BehaviorInstance outputBehavior, string outputName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.BehaviorComponentGetBehaviorConnectionCount(ObjectPtr->ObjPtr, outputBehavior.ObjectPtr->ObjPtr, outputName);
      }

      public string GetBehaviorConnection(BehaviorInstance outputBehavior, string outputName, uint connectionIndex)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.BehaviorComponentGetBehaviorConnection(ObjectPtr->ObjPtr, outputBehavior.ObjectPtr->ObjPtr, outputName, connectionIndex));
      }
      
      #endregion

      
   }
}