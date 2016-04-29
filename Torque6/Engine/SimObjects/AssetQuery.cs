using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class AssetQuery : SimObject
   {
      
      public AssetQuery()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.AssetQueryCreateInstance());
      }

      public AssetQuery(uint pId) : base(pId)
      {
      }

      public AssetQuery(string pName) : base(pName)
      {
      }

      public AssetQuery(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public AssetQuery(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public AssetQuery(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetQueryCreateInstance();
         private static _AssetQueryCreateInstance _AssetQueryCreateInstanceFunc;
         internal static IntPtr AssetQueryCreateInstance()
         {
            if (_AssetQueryCreateInstanceFunc == null)
            {
               _AssetQueryCreateInstanceFunc =
                  (_AssetQueryCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetQueryCreateInstance"), typeof(_AssetQueryCreateInstance));
            }

            return _AssetQueryCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AssetQueryClear(IntPtr assetQuery);
         private static _AssetQueryClear _AssetQueryClearFunc;
         internal static void AssetQueryClear(IntPtr assetQuery)
         {
            if (_AssetQueryClearFunc == null)
            {
               _AssetQueryClearFunc =
                  (_AssetQueryClear)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetQueryClear"), typeof(_AssetQueryClear));
            }

            _AssetQueryClearFunc(assetQuery);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AssetQuerySet(IntPtr assetQuery, IntPtr setAssetQuery);
         private static _AssetQuerySet _AssetQuerySetFunc;
         internal static void AssetQuerySet(IntPtr assetQuery, IntPtr setAssetQuery)
         {
            if (_AssetQuerySetFunc == null)
            {
               _AssetQuerySetFunc =
                  (_AssetQuerySet)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetQuerySet"), typeof(_AssetQuerySet));
            }

            _AssetQuerySetFunc(assetQuery, setAssetQuery);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AssetQueryGetCount(IntPtr assetQuery);
         private static _AssetQueryGetCount _AssetQueryGetCountFunc;
         internal static int AssetQueryGetCount(IntPtr assetQuery)
         {
            if (_AssetQueryGetCountFunc == null)
            {
               _AssetQueryGetCountFunc =
                  (_AssetQueryGetCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetQueryGetCount"), typeof(_AssetQueryGetCount));
            }

            return _AssetQueryGetCountFunc(assetQuery);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetQueryGetAsset(IntPtr assetQuery, int resultIndex);
         private static _AssetQueryGetAsset _AssetQueryGetAssetFunc;
         internal static IntPtr AssetQueryGetAsset(IntPtr assetQuery, int resultIndex)
         {
            if (_AssetQueryGetAssetFunc == null)
            {
               _AssetQueryGetAssetFunc =
                  (_AssetQueryGetAsset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetQueryGetAsset"), typeof(_AssetQueryGetAsset));
            }

            return _AssetQueryGetAssetFunc(assetQuery, resultIndex);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void Clear()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.AssetQueryClear(ObjectPtr->ObjPtr);
      }

      public void Set(AssetQuery setAssetQuery)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.AssetQuerySet(ObjectPtr->ObjPtr, setAssetQuery.ObjectPtr->ObjPtr);
      }

      public int GetCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetQueryGetCount(ObjectPtr->ObjPtr);
      }

      public string GetAsset(int resultIndex)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.AssetQueryGetAsset(ObjectPtr->ObjPtr, resultIndex));
      }
      
      #endregion

      
   }
}