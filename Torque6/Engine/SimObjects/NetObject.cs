using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class NetObject : SimObject
   {
      
      public NetObject()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.NetObjectCreateInstance());
      }

      public NetObject(uint pId) : base(pId)
      {
      }

      public NetObject(string pName) : base(pName)
      {
      }

      public NetObject(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public NetObject(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public NetObject(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _NetObjectCreateInstance();
         private static _NetObjectCreateInstance _NetObjectCreateInstanceFunc;
         internal static IntPtr NetObjectCreateInstance()
         {
            if (_NetObjectCreateInstanceFunc == null)
            {
               _NetObjectCreateInstanceFunc =
                  (_NetObjectCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NetObjectCreateInstance"), typeof(_NetObjectCreateInstance));
            }

            return _NetObjectCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _NetObjectScopeToClient(IntPtr netObj, IntPtr client);
         private static _NetObjectScopeToClient _NetObjectScopeToClientFunc;
         internal static void NetObjectScopeToClient(IntPtr netObj, IntPtr client)
         {
            if (_NetObjectScopeToClientFunc == null)
            {
               _NetObjectScopeToClientFunc =
                  (_NetObjectScopeToClient)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NetObjectScopeToClient"), typeof(_NetObjectScopeToClient));
            }

            _NetObjectScopeToClientFunc(netObj, client);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _NetObjectClearScopeToClient(IntPtr netObj, IntPtr client);
         private static _NetObjectClearScopeToClient _NetObjectClearScopeToClientFunc;
         internal static void NetObjectClearScopeToClient(IntPtr netObj, IntPtr client)
         {
            if (_NetObjectClearScopeToClientFunc == null)
            {
               _NetObjectClearScopeToClientFunc =
                  (_NetObjectClearScopeToClient)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NetObjectClearScopeToClient"), typeof(_NetObjectClearScopeToClient));
            }

            _NetObjectClearScopeToClientFunc(netObj, client);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _NetObjectSetScopeAlways(IntPtr netObj);
         private static _NetObjectSetScopeAlways _NetObjectSetScopeAlwaysFunc;
         internal static void NetObjectSetScopeAlways(IntPtr netObj)
         {
            if (_NetObjectSetScopeAlwaysFunc == null)
            {
               _NetObjectSetScopeAlwaysFunc =
                  (_NetObjectSetScopeAlways)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NetObjectSetScopeAlways"), typeof(_NetObjectSetScopeAlways));
            }

            _NetObjectSetScopeAlwaysFunc(netObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _NetObjectGetGhostID(IntPtr netObj);
         private static _NetObjectGetGhostID _NetObjectGetGhostIDFunc;
         internal static int NetObjectGetGhostID(IntPtr netObj)
         {
            if (_NetObjectGetGhostIDFunc == null)
            {
               _NetObjectGetGhostIDFunc =
                  (_NetObjectGetGhostID)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "NetObjectGetGhostID"), typeof(_NetObjectGetGhostID));
            }

            return _NetObjectGetGhostIDFunc(netObj);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void ScopeToClient(NetConnection client)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.NetObjectScopeToClient(ObjectPtr->ObjPtr, client.ObjectPtr->ObjPtr);
      }

      public void ClearScopeToClient(NetConnection client)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.NetObjectClearScopeToClient(ObjectPtr->ObjPtr, client.ObjectPtr->ObjPtr);
      }

      public void SetScopeAlways()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.NetObjectSetScopeAlways(ObjectPtr->ObjPtr);
      }

      public int GetGhostID()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.NetObjectGetGhostID(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}