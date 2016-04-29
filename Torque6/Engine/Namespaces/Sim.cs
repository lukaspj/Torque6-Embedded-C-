using System;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Utility;

namespace Torque6.Engine.Namespaces
{
   public static unsafe class Sim
   {
      [StructLayout(LayoutKind.Explicit, Size = 4)]
      public partial struct SimObjectPtr
      {
         [FieldOffset(0)] public IntPtr ObjPtr;
      }

      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Sim_FindObjectById(uint id);
         private static _Sim_FindObjectById _Sim_FindObjectByIdFunc;
         internal static IntPtr Sim_FindObjectById(uint id)
         {
            if (_Sim_FindObjectByIdFunc == null)
            {
               _Sim_FindObjectByIdFunc =
                  (_Sim_FindObjectById)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Sim_FindObjectById"), typeof(_Sim_FindObjectById));
            }

            return _Sim_FindObjectByIdFunc(id);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Sim_FindObjectWrapperById(uint id);
         private static _Sim_FindObjectWrapperById _Sim_FindObjectWrapperByIdFunc;
         internal static IntPtr Sim_FindObjectWrapperById(uint id)
         {
            if (_Sim_FindObjectWrapperByIdFunc == null)
            {
               _Sim_FindObjectWrapperByIdFunc =
                  (_Sim_FindObjectWrapperById)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Sim_FindObjectWrapperById"), typeof(_Sim_FindObjectWrapperById));
            }

            return _Sim_FindObjectWrapperByIdFunc(id);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Sim_FindObjectByName(string name);
         private static _Sim_FindObjectByName _Sim_FindObjectByNameFunc;
         internal static IntPtr Sim_FindObjectByName(string name)
         {
            if (_Sim_FindObjectByNameFunc == null)
            {
               _Sim_FindObjectByNameFunc =
                  (_Sim_FindObjectByName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Sim_FindObjectByName"), typeof(_Sim_FindObjectByName));
            }

            return _Sim_FindObjectByNameFunc(name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Sim_FindObjectWrapperByName(string name);
         private static _Sim_FindObjectWrapperByName _Sim_FindObjectWrapperByNameFunc;
         internal static IntPtr Sim_FindObjectWrapperByName(string name)
         {
            if (_Sim_FindObjectWrapperByNameFunc == null)
            {
               _Sim_FindObjectWrapperByNameFunc =
                  (_Sim_FindObjectWrapperByName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Sim_FindObjectWrapperByName"), typeof(_Sim_FindObjectWrapperByName));
            }

            return _Sim_FindObjectWrapperByNameFunc(name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Sim_WrapObject(IntPtr obj);
         private static _Sim_WrapObject _Sim_WrapObjectFunc;
         internal static IntPtr Sim_WrapObject(IntPtr obj)
         {
            if (_Sim_WrapObjectFunc == null)
            {
               _Sim_WrapObjectFunc =
                  (_Sim_WrapObject)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Sim_WrapObject"), typeof(_Sim_WrapObject));
            }

            return _Sim_WrapObjectFunc(obj);
         }
      }

      #endregion
      
      #region Functions

      public static SimObject FindObjectById(uint id)
      {
         return new SimObject(InternalUnsafeMethods.Sim_FindObjectById(id));
      }

      public static SimObjectPtr* FindObjectWrapperById(uint id)
      {
         return (SimObjectPtr*)InternalUnsafeMethods.Sim_FindObjectWrapperById(id);
      }

      public static SimObject FindObjectByName(string name)
      {
         return new SimObject(InternalUnsafeMethods.Sim_FindObjectByName(name));
      }

      public static SimObjectPtr* FindObjectWrapperByName(string name)
      {
         return (SimObjectPtr*)InternalUnsafeMethods.Sim_FindObjectWrapperByName(name);
      }

      public static SimObjectPtr* WrapObject(IntPtr obj)
      {
         return (SimObjectPtr*)InternalUnsafeMethods.Sim_WrapObject(obj);
      }      

      #endregion
   }
}