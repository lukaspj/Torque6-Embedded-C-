using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class MessageForwarder : ScriptMsgListener
   {
      
      public MessageForwarder()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.MessageForwarderCreateInstance());
      }

      public MessageForwarder(uint pId) : base(pId)
      {
      }

      public MessageForwarder(string pName) : base(pName)
      {
      }

      public MessageForwarder(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public MessageForwarder(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public MessageForwarder(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MessageForwarderGetToQueue(IntPtr forwarder);
         private static _MessageForwarderGetToQueue _MessageForwarderGetToQueueFunc;
         internal static IntPtr MessageForwarderGetToQueue(IntPtr forwarder)
         {
            if (_MessageForwarderGetToQueueFunc == null)
            {
               _MessageForwarderGetToQueueFunc =
                  (_MessageForwarderGetToQueue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageForwarderGetToQueue"), typeof(_MessageForwarderGetToQueue));
            }

            return _MessageForwarderGetToQueueFunc(forwarder);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _MessageForwarderSetToQueue(IntPtr forwarder, string value);
         private static _MessageForwarderSetToQueue _MessageForwarderSetToQueueFunc;
         internal static void MessageForwarderSetToQueue(IntPtr forwarder, string value)
         {
            if (_MessageForwarderSetToQueueFunc == null)
            {
               _MessageForwarderSetToQueueFunc =
                  (_MessageForwarderSetToQueue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageForwarderSetToQueue"), typeof(_MessageForwarderSetToQueue));
            }

            _MessageForwarderSetToQueueFunc(forwarder, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MessageForwarderCreateInstance();
         private static _MessageForwarderCreateInstance _MessageForwarderCreateInstanceFunc;
         internal static IntPtr MessageForwarderCreateInstance()
         {
            if (_MessageForwarderCreateInstanceFunc == null)
            {
               _MessageForwarderCreateInstanceFunc =
                  (_MessageForwarderCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MessageForwarderCreateInstance"), typeof(_MessageForwarderCreateInstance));
            }

            return _MessageForwarderCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string ToQueue
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.MessageForwarderGetToQueue(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.MessageForwarderSetToQueue(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}