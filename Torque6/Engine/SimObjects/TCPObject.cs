using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class TCPObject : SimObject
   {
      
      public TCPObject()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.TCPObjectCreateInstance());
      }

      public TCPObject(uint pId) : base(pId)
      {
      }

      public TCPObject(string pName) : base(pName)
      {
      }

      public TCPObject(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public TCPObject(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public TCPObject(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TCPObjectCreateInstance();
         private static _TCPObjectCreateInstance _TCPObjectCreateInstanceFunc;
         internal static IntPtr TCPObjectCreateInstance()
         {
            if (_TCPObjectCreateInstanceFunc == null)
            {
               _TCPObjectCreateInstanceFunc =
                  (_TCPObjectCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TCPObjectCreateInstance"), typeof(_TCPObjectCreateInstance));
            }

            return _TCPObjectCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _TCPObjectSend(IntPtr tcpObj, int argsC, string[] argsV);
         private static _TCPObjectSend _TCPObjectSendFunc;
         internal static void TCPObjectSend(IntPtr tcpObj, int argsC, string[] argsV)
         {
            if (_TCPObjectSendFunc == null)
            {
               _TCPObjectSendFunc =
                  (_TCPObjectSend)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TCPObjectSend"), typeof(_TCPObjectSend));
            }

            _TCPObjectSendFunc(tcpObj, argsC, argsV);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _TCPObjectListen(IntPtr tcpObj, int port);
         private static _TCPObjectListen _TCPObjectListenFunc;
         internal static void TCPObjectListen(IntPtr tcpObj, int port)
         {
            if (_TCPObjectListenFunc == null)
            {
               _TCPObjectListenFunc =
                  (_TCPObjectListen)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TCPObjectListen"), typeof(_TCPObjectListen));
            }

            _TCPObjectListenFunc(tcpObj, port);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _TCPObjectConnect(IntPtr tcpObj, string address);
         private static _TCPObjectConnect _TCPObjectConnectFunc;
         internal static void TCPObjectConnect(IntPtr tcpObj, string address)
         {
            if (_TCPObjectConnectFunc == null)
            {
               _TCPObjectConnectFunc =
                  (_TCPObjectConnect)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TCPObjectConnect"), typeof(_TCPObjectConnect));
            }

            _TCPObjectConnectFunc(tcpObj, address);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _TCPObjectOpenAndConnect(IntPtr tcpObj, string address);
         private static _TCPObjectOpenAndConnect _TCPObjectOpenAndConnectFunc;
         internal static void TCPObjectOpenAndConnect(IntPtr tcpObj, string address)
         {
            if (_TCPObjectOpenAndConnectFunc == null)
            {
               _TCPObjectOpenAndConnectFunc =
                  (_TCPObjectOpenAndConnect)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TCPObjectOpenAndConnect"), typeof(_TCPObjectOpenAndConnect));
            }

            _TCPObjectOpenAndConnectFunc(tcpObj, address);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _TCPObjectDisconnect(IntPtr tcpObj);
         private static _TCPObjectDisconnect _TCPObjectDisconnectFunc;
         internal static void TCPObjectDisconnect(IntPtr tcpObj)
         {
            if (_TCPObjectDisconnectFunc == null)
            {
               _TCPObjectDisconnectFunc =
                  (_TCPObjectDisconnect)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TCPObjectDisconnect"), typeof(_TCPObjectDisconnect));
            }

            _TCPObjectDisconnectFunc(tcpObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TCPObjectURLEncodeString(IntPtr tcpObj, string data);
         private static _TCPObjectURLEncodeString _TCPObjectURLEncodeStringFunc;
         internal static IntPtr TCPObjectURLEncodeString(IntPtr tcpObj, string data)
         {
            if (_TCPObjectURLEncodeStringFunc == null)
            {
               _TCPObjectURLEncodeStringFunc =
                  (_TCPObjectURLEncodeString)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TCPObjectURLEncodeString"), typeof(_TCPObjectURLEncodeString));
            }

            return _TCPObjectURLEncodeStringFunc(tcpObj, data);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void Send(int argsC, string[] argsV)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.TCPObjectSend(ObjectPtr->ObjPtr, argsC, argsV);
      }

      public void Listen(int port)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.TCPObjectListen(ObjectPtr->ObjPtr, port);
      }

      public void Connect(string address)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.TCPObjectConnect(ObjectPtr->ObjPtr, address);
      }

      public void OpenAndConnect(string address)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.TCPObjectOpenAndConnect(ObjectPtr->ObjPtr, address);
      }

      public void Disconnect()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.TCPObjectDisconnect(ObjectPtr->ObjPtr);
      }

      public string URLEncodeString(string data)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.TCPObjectURLEncodeString(ObjectPtr->ObjPtr, data));
      }
      
      #endregion

      
   }
}