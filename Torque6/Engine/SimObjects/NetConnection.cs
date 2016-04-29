using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class NetConnection : SimGroup
   {
      
      public NetConnection()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.NetConnectionCreateInstance());
      }

      public NetConnection(uint pId) : base(pId)
      {
      }

      public NetConnection(string pName) : base(pName)
      {
      }

      public NetConnection(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public NetConnection(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public NetConnection(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _NetConnectionCreateInstance();
         private static _NetConnectionCreateInstance _NetConnectionCreateInstanceFunc;
         internal static IntPtr NetConnectionCreateInstance()
         {
            if (_NetConnectionCreateInstanceFunc == null)
            {
               _NetConnectionCreateInstanceFunc =
                  (_NetConnectionCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NetConnectionCreateInstance"), typeof(_NetConnectionCreateInstance));
            }

            return _NetConnectionCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _NetConnectionGetAddress(IntPtr connection);
         private static _NetConnectionGetAddress _NetConnectionGetAddressFunc;
         internal static IntPtr NetConnectionGetAddress(IntPtr connection)
         {
            if (_NetConnectionGetAddressFunc == null)
            {
               _NetConnectionGetAddressFunc =
                  (_NetConnectionGetAddress)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NetConnectionGetAddress"), typeof(_NetConnectionGetAddress));
            }

            return _NetConnectionGetAddressFunc(connection);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _NetConnectionSetSimulatedNetParams(IntPtr connection, float packetLoss, int delay);
         private static _NetConnectionSetSimulatedNetParams _NetConnectionSetSimulatedNetParamsFunc;
         internal static void NetConnectionSetSimulatedNetParams(IntPtr connection, float packetLoss, int delay)
         {
            if (_NetConnectionSetSimulatedNetParamsFunc == null)
            {
               _NetConnectionSetSimulatedNetParamsFunc =
                  (_NetConnectionSetSimulatedNetParams)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NetConnectionSetSimulatedNetParams"), typeof(_NetConnectionSetSimulatedNetParams));
            }

            _NetConnectionSetSimulatedNetParamsFunc(connection, packetLoss, delay);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _NetConnectionGetPing(IntPtr connection);
         private static _NetConnectionGetPing _NetConnectionGetPingFunc;
         internal static float NetConnectionGetPing(IntPtr connection)
         {
            if (_NetConnectionGetPingFunc == null)
            {
               _NetConnectionGetPingFunc =
                  (_NetConnectionGetPing)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NetConnectionGetPing"), typeof(_NetConnectionGetPing));
            }

            return _NetConnectionGetPingFunc(connection);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _NetConnectionGetPacketLoss(IntPtr connection);
         private static _NetConnectionGetPacketLoss _NetConnectionGetPacketLossFunc;
         internal static float NetConnectionGetPacketLoss(IntPtr connection)
         {
            if (_NetConnectionGetPacketLossFunc == null)
            {
               _NetConnectionGetPacketLossFunc =
                  (_NetConnectionGetPacketLoss)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NetConnectionGetPacketLoss"), typeof(_NetConnectionGetPacketLoss));
            }

            return _NetConnectionGetPacketLossFunc(connection);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _NetConnectionCheckMaxRate(IntPtr connection);
         private static _NetConnectionCheckMaxRate _NetConnectionCheckMaxRateFunc;
         internal static void NetConnectionCheckMaxRate(IntPtr connection)
         {
            if (_NetConnectionCheckMaxRateFunc == null)
            {
               _NetConnectionCheckMaxRateFunc =
                  (_NetConnectionCheckMaxRate)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NetConnectionCheckMaxRate"), typeof(_NetConnectionCheckMaxRate));
            }

            _NetConnectionCheckMaxRateFunc(connection);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _NetConnectionSetLogging(IntPtr connection, bool value);
         private static _NetConnectionSetLogging _NetConnectionSetLoggingFunc;
         internal static void NetConnectionSetLogging(IntPtr connection, bool value)
         {
            if (_NetConnectionSetLoggingFunc == null)
            {
               _NetConnectionSetLoggingFunc =
                  (_NetConnectionSetLogging)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NetConnectionSetLogging"), typeof(_NetConnectionSetLogging));
            }

            _NetConnectionSetLoggingFunc(connection, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _NetConnectionResolveGhostID(IntPtr connection, int ghostId);
         private static _NetConnectionResolveGhostID _NetConnectionResolveGhostIDFunc;
         internal static IntPtr NetConnectionResolveGhostID(IntPtr connection, int ghostId)
         {
            if (_NetConnectionResolveGhostIDFunc == null)
            {
               _NetConnectionResolveGhostIDFunc =
                  (_NetConnectionResolveGhostID)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NetConnectionResolveGhostID"), typeof(_NetConnectionResolveGhostID));
            }

            return _NetConnectionResolveGhostIDFunc(connection, ghostId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _NetConnectionResolveObjectFromGhostIndex(IntPtr connection, int ghostId);
         private static _NetConnectionResolveObjectFromGhostIndex _NetConnectionResolveObjectFromGhostIndexFunc;
         internal static IntPtr NetConnectionResolveObjectFromGhostIndex(IntPtr connection, int ghostId)
         {
            if (_NetConnectionResolveObjectFromGhostIndexFunc == null)
            {
               _NetConnectionResolveObjectFromGhostIndexFunc =
                  (_NetConnectionResolveObjectFromGhostIndex)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NetConnectionResolveObjectFromGhostIndex"), typeof(_NetConnectionResolveObjectFromGhostIndex));
            }

            return _NetConnectionResolveObjectFromGhostIndexFunc(connection, ghostId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _NetConnectionGetGhostID(IntPtr connection, IntPtr netObj);
         private static _NetConnectionGetGhostID _NetConnectionGetGhostIDFunc;
         internal static int NetConnectionGetGhostID(IntPtr connection, IntPtr netObj)
         {
            if (_NetConnectionGetGhostIDFunc == null)
            {
               _NetConnectionGetGhostIDFunc =
                  (_NetConnectionGetGhostID)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NetConnectionGetGhostID"), typeof(_NetConnectionGetGhostID));
            }

            return _NetConnectionGetGhostIDFunc(connection, netObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _NetConnectionConnect(IntPtr connection, string remoteAddress);
         private static _NetConnectionConnect _NetConnectionConnectFunc;
         internal static void NetConnectionConnect(IntPtr connection, string remoteAddress)
         {
            if (_NetConnectionConnectFunc == null)
            {
               _NetConnectionConnectFunc =
                  (_NetConnectionConnect)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NetConnectionConnect"), typeof(_NetConnectionConnect));
            }

            _NetConnectionConnectFunc(connection, remoteAddress);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _NetConnectionConnectLocal(IntPtr connection);
         private static _NetConnectionConnectLocal _NetConnectionConnectLocalFunc;
         internal static IntPtr NetConnectionConnectLocal(IntPtr connection)
         {
            if (_NetConnectionConnectLocalFunc == null)
            {
               _NetConnectionConnectLocalFunc =
                  (_NetConnectionConnectLocal)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NetConnectionConnectLocal"), typeof(_NetConnectionConnectLocal));
            }

            return _NetConnectionConnectLocalFunc(connection);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _NetConnectionGetGhostsActive(IntPtr connection);
         private static _NetConnectionGetGhostsActive _NetConnectionGetGhostsActiveFunc;
         internal static int NetConnectionGetGhostsActive(IntPtr connection)
         {
            if (_NetConnectionGetGhostsActiveFunc == null)
            {
               _NetConnectionGetGhostsActiveFunc =
                  (_NetConnectionGetGhostsActive)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NetConnectionGetGhostsActive"), typeof(_NetConnectionGetGhostsActive));
            }

            return _NetConnectionGetGhostsActiveFunc(connection);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public string GetAddress()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.NetConnectionGetAddress(ObjectPtr->ObjPtr));
      }

      public void SetSimulatedNetParams(float packetLoss, int delay)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.NetConnectionSetSimulatedNetParams(ObjectPtr->ObjPtr, packetLoss, delay);
      }

      public float GetPing()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.NetConnectionGetPing(ObjectPtr->ObjPtr);
      }

      public float GetPacketLoss()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.NetConnectionGetPacketLoss(ObjectPtr->ObjPtr);
      }

      public void CheckMaxRate()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.NetConnectionCheckMaxRate(ObjectPtr->ObjPtr);
      }

      public void SetLogging(bool value)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.NetConnectionSetLogging(ObjectPtr->ObjPtr, value);
      }

      public NetObject ResolveGhostID(int ghostId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new NetObject(InternalUnsafeMethods.NetConnectionResolveGhostID(ObjectPtr->ObjPtr, ghostId));
      }

      public NetObject ResolveObjectFromGhostIndex(int ghostId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new NetObject(InternalUnsafeMethods.NetConnectionResolveObjectFromGhostIndex(ObjectPtr->ObjPtr, ghostId));
      }

      public int GetGhostID(NetObject netObj)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.NetConnectionGetGhostID(ObjectPtr->ObjPtr, netObj.ObjectPtr->ObjPtr);
      }

      public void Connect(string remoteAddress)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.NetConnectionConnect(ObjectPtr->ObjPtr, remoteAddress);
      }

      public string ConnectLocal()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.NetConnectionConnectLocal(ObjectPtr->ObjPtr));
      }

      public int GetGhostsActive()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.NetConnectionGetGhostsActive(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}