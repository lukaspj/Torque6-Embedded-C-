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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr AssetBaseCreateInstance();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr AssetBaseGetAssetName(IntPtr assetBase);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void AssetBaseSetAssetName(IntPtr assetBase, string name);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr AssetBaseGetAssetDescription(IntPtr assetBase);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void AssetBaseSetAssetDescription(IntPtr assetBase, string val);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr AssetBaseGetAssetCategory(IntPtr assetBase);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void AssetBaseSetAssetCategory(IntPtr assetBase, string val);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern bool AssetBaseGetAssetAutoUnload(IntPtr assetBase);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void AssetBaseSetAssetAutoUnload(IntPtr assetBase, bool val);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern bool AssetBaseGetAssetInternal(IntPtr assetBase);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void AssetBaseSetAssetInternal(IntPtr assetBase, bool val);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern bool AssetBaseGetAssetPrivate(IntPtr assetBase);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void AssetBaseRefreshAsset(IntPtr assetBase);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr AssetBaseGetAssetId(IntPtr assetBase);
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