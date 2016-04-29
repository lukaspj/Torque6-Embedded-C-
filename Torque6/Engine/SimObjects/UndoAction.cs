using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class UndoAction : SimObject
   {
      
      public UndoAction()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.UndoActionCreateInstance());
      }

      public UndoAction(uint pId) : base(pId)
      {
      }

      public UndoAction(string pName) : base(pName)
      {
      }

      public UndoAction(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public UndoAction(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public UndoAction(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _UndoActionGetActionName(IntPtr undoAction);
         private static _UndoActionGetActionName _UndoActionGetActionNameFunc;
         internal static IntPtr UndoActionGetActionName(IntPtr undoAction)
         {
            if (_UndoActionGetActionNameFunc == null)
            {
               _UndoActionGetActionNameFunc =
                  (_UndoActionGetActionName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "UndoActionGetActionName"), typeof(_UndoActionGetActionName));
            }

            return _UndoActionGetActionNameFunc(undoAction);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _UndoActionSetActionName(IntPtr undoAction, string value);
         private static _UndoActionSetActionName _UndoActionSetActionNameFunc;
         internal static void UndoActionSetActionName(IntPtr undoAction, string value)
         {
            if (_UndoActionSetActionNameFunc == null)
            {
               _UndoActionSetActionNameFunc =
                  (_UndoActionSetActionName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "UndoActionSetActionName"), typeof(_UndoActionSetActionName));
            }

            _UndoActionSetActionNameFunc(undoAction, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _UndoActionCreateInstance();
         private static _UndoActionCreateInstance _UndoActionCreateInstanceFunc;
         internal static IntPtr UndoActionCreateInstance()
         {
            if (_UndoActionCreateInstanceFunc == null)
            {
               _UndoActionCreateInstanceFunc =
                  (_UndoActionCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "UndoActionCreateInstance"), typeof(_UndoActionCreateInstance));
            }

            return _UndoActionCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _UndoActionAddToManager(IntPtr undoAction, IntPtr undoManager);
         private static _UndoActionAddToManager _UndoActionAddToManagerFunc;
         internal static void UndoActionAddToManager(IntPtr undoAction, IntPtr undoManager)
         {
            if (_UndoActionAddToManagerFunc == null)
            {
               _UndoActionAddToManagerFunc =
                  (_UndoActionAddToManager)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "UndoActionAddToManager"), typeof(_UndoActionAddToManager));
            }

            _UndoActionAddToManagerFunc(undoAction, undoManager);
         }
      }
      
      #endregion

      #region Properties

      public string ActionName
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.UndoActionGetActionName(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.UndoActionSetActionName(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public void AddToManager(UndoManager undoManager = null)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.UndoActionAddToManager(ObjectPtr->ObjPtr, undoManager.ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}