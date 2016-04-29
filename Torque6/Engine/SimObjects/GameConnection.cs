using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class GameConnection : NetConnection
   {
      
      public GameConnection()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GameConnectionCreateInstance());
      }

      public GameConnection(uint pId) : base(pId)
      {
      }

      public GameConnection(string pName) : base(pName)
      {
      }

      public GameConnection(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GameConnection(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GameConnection(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GameConnectionCreateInstance();
         private static _GameConnectionCreateInstance _GameConnectionCreateInstanceFunc;
         internal static IntPtr GameConnectionCreateInstance()
         {
            if (_GameConnectionCreateInstanceFunc == null)
            {
               _GameConnectionCreateInstanceFunc =
                  (_GameConnectionCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GameConnectionCreateInstance"), typeof(_GameConnectionCreateInstance));
            }

            return _GameConnectionCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GameConnectionSetJoinPassword(IntPtr connection, string password);
         private static _GameConnectionSetJoinPassword _GameConnectionSetJoinPasswordFunc;
         internal static void GameConnectionSetJoinPassword(IntPtr connection, string password)
         {
            if (_GameConnectionSetJoinPasswordFunc == null)
            {
               _GameConnectionSetJoinPasswordFunc =
                  (_GameConnectionSetJoinPassword)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GameConnectionSetJoinPassword"), typeof(_GameConnectionSetJoinPassword));
            }

            _GameConnectionSetJoinPasswordFunc(connection, password);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GameConnectionSetConnectArgs(IntPtr connection, int argC, string[] argV);
         private static _GameConnectionSetConnectArgs _GameConnectionSetConnectArgsFunc;
         internal static void GameConnectionSetConnectArgs(IntPtr connection, int argC, string[] argV)
         {
            if (_GameConnectionSetConnectArgsFunc == null)
            {
               _GameConnectionSetConnectArgsFunc =
                  (_GameConnectionSetConnectArgs)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GameConnectionSetConnectArgs"), typeof(_GameConnectionSetConnectArgs));
            }

            _GameConnectionSetConnectArgsFunc(connection, argC, argV);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GameConnectionActivateGhosting(IntPtr connection);
         private static _GameConnectionActivateGhosting _GameConnectionActivateGhostingFunc;
         internal static void GameConnectionActivateGhosting(IntPtr connection)
         {
            if (_GameConnectionActivateGhostingFunc == null)
            {
               _GameConnectionActivateGhostingFunc =
                  (_GameConnectionActivateGhosting)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GameConnectionActivateGhosting"), typeof(_GameConnectionActivateGhosting));
            }

            _GameConnectionActivateGhostingFunc(connection);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GameConnectionResetGhosting(IntPtr connection);
         private static _GameConnectionResetGhosting _GameConnectionResetGhostingFunc;
         internal static void GameConnectionResetGhosting(IntPtr connection)
         {
            if (_GameConnectionResetGhostingFunc == null)
            {
               _GameConnectionResetGhostingFunc =
                  (_GameConnectionResetGhosting)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GameConnectionResetGhosting"), typeof(_GameConnectionResetGhosting));
            }

            _GameConnectionResetGhostingFunc(connection);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GameConnectionDelete(IntPtr connection, string reason);
         private static _GameConnectionDelete _GameConnectionDeleteFunc;
         internal static void GameConnectionDelete(IntPtr connection, string reason)
         {
            if (_GameConnectionDeleteFunc == null)
            {
               _GameConnectionDeleteFunc =
                  (_GameConnectionDelete)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GameConnectionDelete"), typeof(_GameConnectionDelete));
            }

            _GameConnectionDeleteFunc(connection, reason);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GameConnectionGetServerConnection(IntPtr connection);
         private static _GameConnectionGetServerConnection _GameConnectionGetServerConnectionFunc;
         internal static IntPtr GameConnectionGetServerConnection(IntPtr connection)
         {
            if (_GameConnectionGetServerConnectionFunc == null)
            {
               _GameConnectionGetServerConnectionFunc =
                  (_GameConnectionGetServerConnection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GameConnectionGetServerConnection"), typeof(_GameConnectionGetServerConnection));
            }

            return _GameConnectionGetServerConnectionFunc(connection);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void SetJoinPassword(string password)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GameConnectionSetJoinPassword(ObjectPtr->ObjPtr, password);
      }

      public void SetConnectArgs(int argC, string[] argV)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GameConnectionSetConnectArgs(ObjectPtr->ObjPtr, argC, argV);
      }

      public void ActivateGhosting()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GameConnectionActivateGhosting(ObjectPtr->ObjPtr);
      }

      public void ResetGhosting()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GameConnectionResetGhosting(ObjectPtr->ObjPtr);
      }

      public void Delete(string reason = null)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GameConnectionDelete(ObjectPtr->ObjPtr, reason);
      }

      public NetConnection GetServerConnection()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new NetConnection(InternalUnsafeMethods.GameConnectionGetServerConnection(ObjectPtr->ObjPtr));
      }
      
      #endregion

      
   }
}