using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class EventManager : SimObject
   {
      
      public EventManager()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.EventManagerCreateInstance());
      }

      public EventManager(uint pId) : base(pId)
      {
      }

      public EventManager(string pName) : base(pName)
      {
      }

      public EventManager(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public EventManager(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public EventManager(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _EventManagerGetQueue(IntPtr eventManager);
         private static _EventManagerGetQueue _EventManagerGetQueueFunc;
         internal static IntPtr EventManagerGetQueue(IntPtr eventManager)
         {
            if (_EventManagerGetQueueFunc == null)
            {
               _EventManagerGetQueueFunc =
                  (_EventManagerGetQueue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "EventManagerGetQueue"), typeof(_EventManagerGetQueue));
            }

            return _EventManagerGetQueueFunc(eventManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _EventManagerSetQueue(IntPtr eventManager, string value);
         private static _EventManagerSetQueue _EventManagerSetQueueFunc;
         internal static void EventManagerSetQueue(IntPtr eventManager, string value)
         {
            if (_EventManagerSetQueueFunc == null)
            {
               _EventManagerSetQueueFunc =
                  (_EventManagerSetQueue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "EventManagerSetQueue"), typeof(_EventManagerSetQueue));
            }

            _EventManagerSetQueueFunc(eventManager, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _EventManagerCreateInstance();
         private static _EventManagerCreateInstance _EventManagerCreateInstanceFunc;
         internal static IntPtr EventManagerCreateInstance()
         {
            if (_EventManagerCreateInstanceFunc == null)
            {
               _EventManagerCreateInstanceFunc =
                  (_EventManagerCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "EventManagerCreateInstance"), typeof(_EventManagerCreateInstance));
            }

            return _EventManagerCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _EventManagerRegisterEvent(IntPtr eventManager, string eventName);
         private static _EventManagerRegisterEvent _EventManagerRegisterEventFunc;
         internal static bool EventManagerRegisterEvent(IntPtr eventManager, string eventName)
         {
            if (_EventManagerRegisterEventFunc == null)
            {
               _EventManagerRegisterEventFunc =
                  (_EventManagerRegisterEvent)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "EventManagerRegisterEvent"), typeof(_EventManagerRegisterEvent));
            }

            return _EventManagerRegisterEventFunc(eventManager, eventName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _EventManagerUnregisterEvent(IntPtr eventManager, string eventName);
         private static _EventManagerUnregisterEvent _EventManagerUnregisterEventFunc;
         internal static void EventManagerUnregisterEvent(IntPtr eventManager, string eventName)
         {
            if (_EventManagerUnregisterEventFunc == null)
            {
               _EventManagerUnregisterEventFunc =
                  (_EventManagerUnregisterEvent)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "EventManagerUnregisterEvent"), typeof(_EventManagerUnregisterEvent));
            }

            _EventManagerUnregisterEventFunc(eventManager, eventName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _EventManagerIsRegisteredEvent(IntPtr eventManager, string eventName);
         private static _EventManagerIsRegisteredEvent _EventManagerIsRegisteredEventFunc;
         internal static bool EventManagerIsRegisteredEvent(IntPtr eventManager, string eventName)
         {
            if (_EventManagerIsRegisteredEventFunc == null)
            {
               _EventManagerIsRegisteredEventFunc =
                  (_EventManagerIsRegisteredEvent)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "EventManagerIsRegisteredEvent"), typeof(_EventManagerIsRegisteredEvent));
            }

            return _EventManagerIsRegisteredEventFunc(eventManager, eventName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _EventManagerPostEvent(IntPtr eventManager, string eventName, string data);
         private static _EventManagerPostEvent _EventManagerPostEventFunc;
         internal static bool EventManagerPostEvent(IntPtr eventManager, string eventName, string data)
         {
            if (_EventManagerPostEventFunc == null)
            {
               _EventManagerPostEventFunc =
                  (_EventManagerPostEvent)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "EventManagerPostEvent"), typeof(_EventManagerPostEvent));
            }

            return _EventManagerPostEventFunc(eventManager, eventName, data);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _EventManagerSubscribe(IntPtr eventManager, IntPtr listener, string eventName, string callback);
         private static _EventManagerSubscribe _EventManagerSubscribeFunc;
         internal static bool EventManagerSubscribe(IntPtr eventManager, IntPtr listener, string eventName, string callback)
         {
            if (_EventManagerSubscribeFunc == null)
            {
               _EventManagerSubscribeFunc =
                  (_EventManagerSubscribe)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "EventManagerSubscribe"), typeof(_EventManagerSubscribe));
            }

            return _EventManagerSubscribeFunc(eventManager, listener, eventName, callback);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _EventManagerRemove(IntPtr eventManager, IntPtr listener, string eventName);
         private static _EventManagerRemove _EventManagerRemoveFunc;
         internal static void EventManagerRemove(IntPtr eventManager, IntPtr listener, string eventName)
         {
            if (_EventManagerRemoveFunc == null)
            {
               _EventManagerRemoveFunc =
                  (_EventManagerRemove)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "EventManagerRemove"), typeof(_EventManagerRemove));
            }

            _EventManagerRemoveFunc(eventManager, listener, eventName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _EventManagerDumpEvents(IntPtr eventManager);
         private static _EventManagerDumpEvents _EventManagerDumpEventsFunc;
         internal static void EventManagerDumpEvents(IntPtr eventManager)
         {
            if (_EventManagerDumpEventsFunc == null)
            {
               _EventManagerDumpEventsFunc =
                  (_EventManagerDumpEvents)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "EventManagerDumpEvents"), typeof(_EventManagerDumpEvents));
            }

            _EventManagerDumpEventsFunc(eventManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _EventManagerDumpSubscribers(IntPtr eventManager, string eventName);
         private static _EventManagerDumpSubscribers _EventManagerDumpSubscribersFunc;
         internal static void EventManagerDumpSubscribers(IntPtr eventManager, string eventName)
         {
            if (_EventManagerDumpSubscribersFunc == null)
            {
               _EventManagerDumpSubscribersFunc =
                  (_EventManagerDumpSubscribers)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "EventManagerDumpSubscribers"), typeof(_EventManagerDumpSubscribers));
            }

            _EventManagerDumpSubscribersFunc(eventManager, eventName);
         }
      }
      
      #endregion

      #region Properties

      public string Queue
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.EventManagerGetQueue(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.EventManagerSetQueue(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public bool RegisterEvent(string eventName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.EventManagerRegisterEvent(ObjectPtr->ObjPtr, eventName);
      }

      public void UnregisterEvent(string eventName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.EventManagerUnregisterEvent(ObjectPtr->ObjPtr, eventName);
      }

      public bool IsRegisteredEvent(string eventName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.EventManagerIsRegisteredEvent(ObjectPtr->ObjPtr, eventName);
      }

      public bool PostEvent(string eventName, string data = null)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.EventManagerPostEvent(ObjectPtr->ObjPtr, eventName, data);
      }

      public bool Subscribe(SimObject listener, string eventName, string callback = null)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.EventManagerSubscribe(ObjectPtr->ObjPtr, listener.ObjectPtr->ObjPtr, eventName, callback);
      }

      public void Remove(SimObject listener, string eventName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.EventManagerRemove(ObjectPtr->ObjPtr, listener.ObjectPtr->ObjPtr, eventName);
      }

      public void DumpEvents()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.EventManagerDumpEvents(ObjectPtr->ObjPtr);
      }

      public void DumpSubscribers(string eventName = null)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.EventManagerDumpSubscribers(ObjectPtr->ObjPtr, eventName);
      }
      
      #endregion

      
   }
}