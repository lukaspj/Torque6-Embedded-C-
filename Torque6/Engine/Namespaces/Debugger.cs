using System;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Utility;

namespace Torque6.Engine.Namespaces
{
   public static unsafe class Debugger
   {
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Debugger_SetParameters(int port, string password, bool waitForClient);
         private static _Debugger_SetParameters _Debugger_SetParametersFunc;
         internal static void Debugger_SetParameters(int port, string password, bool waitForClient)
         {
            if (_Debugger_SetParametersFunc == null)
            {
               _Debugger_SetParametersFunc =
                  (_Debugger_SetParameters)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Debugger_SetParameters"), typeof(_Debugger_SetParameters));
            }

            _Debugger_SetParametersFunc(port, password, waitForClient);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Debugger_IsConnected();
         private static _Debugger_IsConnected _Debugger_IsConnectedFunc;
         internal static bool Debugger_IsConnected()
         {
            if (_Debugger_IsConnectedFunc == null)
            {
               _Debugger_IsConnectedFunc =
                  (_Debugger_IsConnected)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Debugger_IsConnected"), typeof(_Debugger_IsConnected));
            }

            return _Debugger_IsConnectedFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Debugger_Disconnect();
         private static _Debugger_Disconnect _Debugger_DisconnectFunc;
         internal static void Debugger_Disconnect()
         {
            if (_Debugger_DisconnectFunc == null)
            {
               _Debugger_DisconnectFunc =
                  (_Debugger_Disconnect)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Debugger_Disconnect"), typeof(_Debugger_Disconnect));
            }

            _Debugger_DisconnectFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Debugger_OpenRemoteDebugger(int debuggerVersion, int port, string password);
         private static _Debugger_OpenRemoteDebugger _Debugger_OpenRemoteDebuggerFunc;
         internal static bool Debugger_OpenRemoteDebugger(int debuggerVersion, int port, string password)
         {
            if (_Debugger_OpenRemoteDebuggerFunc == null)
            {
               _Debugger_OpenRemoteDebuggerFunc =
                  (_Debugger_OpenRemoteDebugger)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Debugger_OpenRemoteDebugger"), typeof(_Debugger_OpenRemoteDebugger));
            }

            return _Debugger_OpenRemoteDebuggerFunc(debuggerVersion, port, password);
         }
      }

      #endregion
      
      #region Functions

      public static void SetParameters(int port, string password, bool waitForClient)
      {
         InternalUnsafeMethods.Debugger_SetParameters(port, password, waitForClient);
      }

      public static bool IsConnected()
      {
         return InternalUnsafeMethods.Debugger_IsConnected();
      }

      public static void Disconnect()
      {
         InternalUnsafeMethods.Debugger_Disconnect();
      }

      public static bool OpenRemoteDebugger(int debuggerVersion, int port, string password)
      {
         return InternalUnsafeMethods.Debugger_OpenRemoteDebugger(debuggerVersion, port, password);
      }      

      #endregion
   }
}