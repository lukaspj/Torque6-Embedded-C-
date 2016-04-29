using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class Message : SimObject
   {
      
      public Message()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.MessageCreateInstance());
      }

      public Message(uint pId) : base(pId)
      {
      }

      public Message(string pName) : base(pName)
      {
      }

      public Message(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public Message(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public Message(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MessageCreateInstance();
         private static _MessageCreateInstance _MessageCreateInstanceFunc;
         internal static IntPtr MessageCreateInstance()
         {
            if (_MessageCreateInstanceFunc == null)
            {
               _MessageCreateInstanceFunc =
                  (_MessageCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageCreateInstance"), typeof(_MessageCreateInstance));
            }

            return _MessageCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MessageGetType(IntPtr message);
         private static _MessageGetType _MessageGetTypeFunc;
         internal static IntPtr MessageGetType(IntPtr message)
         {
            if (_MessageGetTypeFunc == null)
            {
               _MessageGetTypeFunc =
                  (_MessageGetType)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageGetType"), typeof(_MessageGetType));
            }

            return _MessageGetTypeFunc(message);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _MessageAddReference(IntPtr message);
         private static _MessageAddReference _MessageAddReferenceFunc;
         internal static void MessageAddReference(IntPtr message)
         {
            if (_MessageAddReferenceFunc == null)
            {
               _MessageAddReferenceFunc =
                  (_MessageAddReference)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageAddReference"), typeof(_MessageAddReference));
            }

            _MessageAddReferenceFunc(message);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _MessageFreeReference(IntPtr message);
         private static _MessageFreeReference _MessageFreeReferenceFunc;
         internal static void MessageFreeReference(IntPtr message)
         {
            if (_MessageFreeReferenceFunc == null)
            {
               _MessageFreeReferenceFunc =
                  (_MessageFreeReference)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageFreeReference"), typeof(_MessageFreeReference));
            }

            _MessageFreeReferenceFunc(message);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public string GetType()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.MessageGetType(ObjectPtr->ObjPtr));
      }

      public void AddReference()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.MessageAddReference(ObjectPtr->ObjPtr);
      }

      public void FreeReference()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.MessageFreeReference(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}