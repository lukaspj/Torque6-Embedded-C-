using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class AssetBase : SimObject
   {
      
      public AssetBase()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.AssetBaseCreateInstance());
      }

      public AssetBase(uint pId) : base(pId)
      {
      }

      public AssetBase(string pName) : base(pName)
      {
      }

      public AssetBase(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public AssetBase(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public AssetBase(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetBaseCreateInstance();
         private static _AssetBaseCreateInstance _AssetBaseCreateInstanceFunc;
         internal static IntPtr AssetBaseCreateInstance()
         {
            if (_AssetBaseCreateInstanceFunc == null)
            {
               _AssetBaseCreateInstanceFunc =
                  (_AssetBaseCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetBaseCreateInstance"), typeof(_AssetBaseCreateInstance));
            }

            return _AssetBaseCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetBaseGetAssetName(IntPtr assetBase);
         private static _AssetBaseGetAssetName _AssetBaseGetAssetNameFunc;
         internal static IntPtr AssetBaseGetAssetName(IntPtr assetBase)
         {
            if (_AssetBaseGetAssetNameFunc == null)
            {
               _AssetBaseGetAssetNameFunc =
                  (_AssetBaseGetAssetName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetBaseGetAssetName"), typeof(_AssetBaseGetAssetName));
            }

            return _AssetBaseGetAssetNameFunc(assetBase);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AssetBaseSetAssetName(IntPtr assetBase, string name);
         private static _AssetBaseSetAssetName _AssetBaseSetAssetNameFunc;
         internal static void AssetBaseSetAssetName(IntPtr assetBase, string name)
         {
            if (_AssetBaseSetAssetNameFunc == null)
            {
               _AssetBaseSetAssetNameFunc =
                  (_AssetBaseSetAssetName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetBaseSetAssetName"), typeof(_AssetBaseSetAssetName));
            }

            _AssetBaseSetAssetNameFunc(assetBase, name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetBaseGetAssetDescription(IntPtr assetBase);
         private static _AssetBaseGetAssetDescription _AssetBaseGetAssetDescriptionFunc;
         internal static IntPtr AssetBaseGetAssetDescription(IntPtr assetBase)
         {
            if (_AssetBaseGetAssetDescriptionFunc == null)
            {
               _AssetBaseGetAssetDescriptionFunc =
                  (_AssetBaseGetAssetDescription)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetBaseGetAssetDescription"), typeof(_AssetBaseGetAssetDescription));
            }

            return _AssetBaseGetAssetDescriptionFunc(assetBase);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AssetBaseSetAssetDescription(IntPtr assetBase, string val);
         private static _AssetBaseSetAssetDescription _AssetBaseSetAssetDescriptionFunc;
         internal static void AssetBaseSetAssetDescription(IntPtr assetBase, string val)
         {
            if (_AssetBaseSetAssetDescriptionFunc == null)
            {
               _AssetBaseSetAssetDescriptionFunc =
                  (_AssetBaseSetAssetDescription)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetBaseSetAssetDescription"), typeof(_AssetBaseSetAssetDescription));
            }

            _AssetBaseSetAssetDescriptionFunc(assetBase, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetBaseGetAssetCategory(IntPtr assetBase);
         private static _AssetBaseGetAssetCategory _AssetBaseGetAssetCategoryFunc;
         internal static IntPtr AssetBaseGetAssetCategory(IntPtr assetBase)
         {
            if (_AssetBaseGetAssetCategoryFunc == null)
            {
               _AssetBaseGetAssetCategoryFunc =
                  (_AssetBaseGetAssetCategory)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetBaseGetAssetCategory"), typeof(_AssetBaseGetAssetCategory));
            }

            return _AssetBaseGetAssetCategoryFunc(assetBase);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AssetBaseSetAssetCategory(IntPtr assetBase, string val);
         private static _AssetBaseSetAssetCategory _AssetBaseSetAssetCategoryFunc;
         internal static void AssetBaseSetAssetCategory(IntPtr assetBase, string val)
         {
            if (_AssetBaseSetAssetCategoryFunc == null)
            {
               _AssetBaseSetAssetCategoryFunc =
                  (_AssetBaseSetAssetCategory)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetBaseSetAssetCategory"), typeof(_AssetBaseSetAssetCategory));
            }

            _AssetBaseSetAssetCategoryFunc(assetBase, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetBaseGetAssetAutoUnload(IntPtr assetBase);
         private static _AssetBaseGetAssetAutoUnload _AssetBaseGetAssetAutoUnloadFunc;
         internal static bool AssetBaseGetAssetAutoUnload(IntPtr assetBase)
         {
            if (_AssetBaseGetAssetAutoUnloadFunc == null)
            {
               _AssetBaseGetAssetAutoUnloadFunc =
                  (_AssetBaseGetAssetAutoUnload)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetBaseGetAssetAutoUnload"), typeof(_AssetBaseGetAssetAutoUnload));
            }

            return _AssetBaseGetAssetAutoUnloadFunc(assetBase);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AssetBaseSetAssetAutoUnload(IntPtr assetBase, bool val);
         private static _AssetBaseSetAssetAutoUnload _AssetBaseSetAssetAutoUnloadFunc;
         internal static void AssetBaseSetAssetAutoUnload(IntPtr assetBase, bool val)
         {
            if (_AssetBaseSetAssetAutoUnloadFunc == null)
            {
               _AssetBaseSetAssetAutoUnloadFunc =
                  (_AssetBaseSetAssetAutoUnload)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetBaseSetAssetAutoUnload"), typeof(_AssetBaseSetAssetAutoUnload));
            }

            _AssetBaseSetAssetAutoUnloadFunc(assetBase, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetBaseGetAssetInternal(IntPtr assetBase);
         private static _AssetBaseGetAssetInternal _AssetBaseGetAssetInternalFunc;
         internal static bool AssetBaseGetAssetInternal(IntPtr assetBase)
         {
            if (_AssetBaseGetAssetInternalFunc == null)
            {
               _AssetBaseGetAssetInternalFunc =
                  (_AssetBaseGetAssetInternal)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetBaseGetAssetInternal"), typeof(_AssetBaseGetAssetInternal));
            }

            return _AssetBaseGetAssetInternalFunc(assetBase);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AssetBaseSetAssetInternal(IntPtr assetBase, bool val);
         private static _AssetBaseSetAssetInternal _AssetBaseSetAssetInternalFunc;
         internal static void AssetBaseSetAssetInternal(IntPtr assetBase, bool val)
         {
            if (_AssetBaseSetAssetInternalFunc == null)
            {
               _AssetBaseSetAssetInternalFunc =
                  (_AssetBaseSetAssetInternal)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetBaseSetAssetInternal"), typeof(_AssetBaseSetAssetInternal));
            }

            _AssetBaseSetAssetInternalFunc(assetBase, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetBaseGetAssetPrivate(IntPtr assetBase);
         private static _AssetBaseGetAssetPrivate _AssetBaseGetAssetPrivateFunc;
         internal static bool AssetBaseGetAssetPrivate(IntPtr assetBase)
         {
            if (_AssetBaseGetAssetPrivateFunc == null)
            {
               _AssetBaseGetAssetPrivateFunc =
                  (_AssetBaseGetAssetPrivate)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetBaseGetAssetPrivate"), typeof(_AssetBaseGetAssetPrivate));
            }

            return _AssetBaseGetAssetPrivateFunc(assetBase);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AssetBaseRefreshAsset(IntPtr assetBase);
         private static _AssetBaseRefreshAsset _AssetBaseRefreshAssetFunc;
         internal static void AssetBaseRefreshAsset(IntPtr assetBase)
         {
            if (_AssetBaseRefreshAssetFunc == null)
            {
               _AssetBaseRefreshAssetFunc =
                  (_AssetBaseRefreshAsset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetBaseRefreshAsset"), typeof(_AssetBaseRefreshAsset));
            }

            _AssetBaseRefreshAssetFunc(assetBase);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetBaseGetAssetId(IntPtr assetBase);
         private static _AssetBaseGetAssetId _AssetBaseGetAssetIdFunc;
         internal static IntPtr AssetBaseGetAssetId(IntPtr assetBase)
         {
            if (_AssetBaseGetAssetIdFunc == null)
            {
               _AssetBaseGetAssetIdFunc =
                  (_AssetBaseGetAssetId)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetBaseGetAssetId"), typeof(_AssetBaseGetAssetId));
            }

            return _AssetBaseGetAssetIdFunc(assetBase);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public string GetAssetName()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.AssetBaseGetAssetName(ObjectPtr->ObjPtr));
      }

      public void SetAssetName(string name)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.AssetBaseSetAssetName(ObjectPtr->ObjPtr, name);
      }

      public string GetAssetDescription()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.AssetBaseGetAssetDescription(ObjectPtr->ObjPtr));
      }

      public void SetAssetDescription(string val)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.AssetBaseSetAssetDescription(ObjectPtr->ObjPtr, val);
      }

      public string GetAssetCategory()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.AssetBaseGetAssetCategory(ObjectPtr->ObjPtr));
      }

      public void SetAssetCategory(string val)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.AssetBaseSetAssetCategory(ObjectPtr->ObjPtr, val);
      }

      public bool GetAssetAutoUnload()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetBaseGetAssetAutoUnload(ObjectPtr->ObjPtr);
      }

      public void SetAssetAutoUnload(bool val)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.AssetBaseSetAssetAutoUnload(ObjectPtr->ObjPtr, val);
      }

      public bool GetAssetInternal()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetBaseGetAssetInternal(ObjectPtr->ObjPtr);
      }

      public void SetAssetInternal(bool val)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.AssetBaseSetAssetInternal(ObjectPtr->ObjPtr, val);
      }

      public bool GetAssetPrivate()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetBaseGetAssetPrivate(ObjectPtr->ObjPtr);
      }

      public void RefreshAsset()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.AssetBaseRefreshAsset(ObjectPtr->ObjPtr);
      }

      public string GetAssetId()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.AssetBaseGetAssetId(ObjectPtr->ObjPtr));
      }
      
      #endregion

      
   }
}