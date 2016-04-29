using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class AssetTagsManifest : SimObject
   {
      
      public AssetTagsManifest()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.AssetTagsManifestCreateInstance());
      }

      public AssetTagsManifest(uint pId) : base(pId)
      {
      }

      public AssetTagsManifest(string pName) : base(pName)
      {
      }

      public AssetTagsManifest(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public AssetTagsManifest(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public AssetTagsManifest(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetTagsManifestCreateInstance();
         private static _AssetTagsManifestCreateInstance _AssetTagsManifestCreateInstanceFunc;
         internal static IntPtr AssetTagsManifestCreateInstance()
         {
            if (_AssetTagsManifestCreateInstanceFunc == null)
            {
               _AssetTagsManifestCreateInstanceFunc =
                  (_AssetTagsManifestCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetTagsManifestCreateInstance"), typeof(_AssetTagsManifestCreateInstance));
            }

            return _AssetTagsManifestCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AssetTagsManifestCreateTag(IntPtr assetTagsManifest, string tagName);
         private static _AssetTagsManifestCreateTag _AssetTagsManifestCreateTagFunc;
         internal static void AssetTagsManifestCreateTag(IntPtr assetTagsManifest, string tagName)
         {
            if (_AssetTagsManifestCreateTagFunc == null)
            {
               _AssetTagsManifestCreateTagFunc =
                  (_AssetTagsManifestCreateTag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetTagsManifestCreateTag"), typeof(_AssetTagsManifestCreateTag));
            }

            _AssetTagsManifestCreateTagFunc(assetTagsManifest, tagName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetTagsManifestRenameTag(IntPtr assetTagsManifest, string oldTagName, string newTagName);
         private static _AssetTagsManifestRenameTag _AssetTagsManifestRenameTagFunc;
         internal static bool AssetTagsManifestRenameTag(IntPtr assetTagsManifest, string oldTagName, string newTagName)
         {
            if (_AssetTagsManifestRenameTagFunc == null)
            {
               _AssetTagsManifestRenameTagFunc =
                  (_AssetTagsManifestRenameTag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetTagsManifestRenameTag"), typeof(_AssetTagsManifestRenameTag));
            }

            return _AssetTagsManifestRenameTagFunc(assetTagsManifest, oldTagName, newTagName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetTagsManifestDeleteTag(IntPtr assetTagsManifest, string tagName);
         private static _AssetTagsManifestDeleteTag _AssetTagsManifestDeleteTagFunc;
         internal static bool AssetTagsManifestDeleteTag(IntPtr assetTagsManifest, string tagName)
         {
            if (_AssetTagsManifestDeleteTagFunc == null)
            {
               _AssetTagsManifestDeleteTagFunc =
                  (_AssetTagsManifestDeleteTag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetTagsManifestDeleteTag"), typeof(_AssetTagsManifestDeleteTag));
            }

            return _AssetTagsManifestDeleteTagFunc(assetTagsManifest, tagName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetTagsManifestIsTag(IntPtr assetTagsManifest, string tagName);
         private static _AssetTagsManifestIsTag _AssetTagsManifestIsTagFunc;
         internal static bool AssetTagsManifestIsTag(IntPtr assetTagsManifest, string tagName)
         {
            if (_AssetTagsManifestIsTagFunc == null)
            {
               _AssetTagsManifestIsTagFunc =
                  (_AssetTagsManifestIsTag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetTagsManifestIsTag"), typeof(_AssetTagsManifestIsTag));
            }

            return _AssetTagsManifestIsTagFunc(assetTagsManifest, tagName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AssetTagsManifestGetTagCount(IntPtr assetTagsManifest);
         private static _AssetTagsManifestGetTagCount _AssetTagsManifestGetTagCountFunc;
         internal static int AssetTagsManifestGetTagCount(IntPtr assetTagsManifest)
         {
            if (_AssetTagsManifestGetTagCountFunc == null)
            {
               _AssetTagsManifestGetTagCountFunc =
                  (_AssetTagsManifestGetTagCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetTagsManifestGetTagCount"), typeof(_AssetTagsManifestGetTagCount));
            }

            return _AssetTagsManifestGetTagCountFunc(assetTagsManifest);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetTagsManifestGetTag(IntPtr assetTagsManifest, int tagIndex);
         private static _AssetTagsManifestGetTag _AssetTagsManifestGetTagFunc;
         internal static IntPtr AssetTagsManifestGetTag(IntPtr assetTagsManifest, int tagIndex)
         {
            if (_AssetTagsManifestGetTagFunc == null)
            {
               _AssetTagsManifestGetTagFunc =
                  (_AssetTagsManifestGetTag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetTagsManifestGetTag"), typeof(_AssetTagsManifestGetTag));
            }

            return _AssetTagsManifestGetTagFunc(assetTagsManifest, tagIndex);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AssetTagsManifestGetAssetTagCount(IntPtr assetTagsManifest, string assetId);
         private static _AssetTagsManifestGetAssetTagCount _AssetTagsManifestGetAssetTagCountFunc;
         internal static int AssetTagsManifestGetAssetTagCount(IntPtr assetTagsManifest, string assetId)
         {
            if (_AssetTagsManifestGetAssetTagCountFunc == null)
            {
               _AssetTagsManifestGetAssetTagCountFunc =
                  (_AssetTagsManifestGetAssetTagCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetTagsManifestGetAssetTagCount"), typeof(_AssetTagsManifestGetAssetTagCount));
            }

            return _AssetTagsManifestGetAssetTagCountFunc(assetTagsManifest, assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetTagsManifestGetAssetTag(IntPtr assetTagsManifest, string assetId, int tagIndex);
         private static _AssetTagsManifestGetAssetTag _AssetTagsManifestGetAssetTagFunc;
         internal static IntPtr AssetTagsManifestGetAssetTag(IntPtr assetTagsManifest, string assetId, int tagIndex)
         {
            if (_AssetTagsManifestGetAssetTagFunc == null)
            {
               _AssetTagsManifestGetAssetTagFunc =
                  (_AssetTagsManifestGetAssetTag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetTagsManifestGetAssetTag"), typeof(_AssetTagsManifestGetAssetTag));
            }

            return _AssetTagsManifestGetAssetTagFunc(assetTagsManifest, assetId, tagIndex);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetTagsManifestTag(IntPtr assetTagsManifest, string assetId, string tagName);
         private static _AssetTagsManifestTag _AssetTagsManifestTagFunc;
         internal static bool AssetTagsManifestTag(IntPtr assetTagsManifest, string assetId, string tagName)
         {
            if (_AssetTagsManifestTagFunc == null)
            {
               _AssetTagsManifestTagFunc =
                  (_AssetTagsManifestTag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetTagsManifestTag"), typeof(_AssetTagsManifestTag));
            }

            return _AssetTagsManifestTagFunc(assetTagsManifest, assetId, tagName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetTagsManifestUntag(IntPtr assetTagsManifest, string assetId, string tagName);
         private static _AssetTagsManifestUntag _AssetTagsManifestUntagFunc;
         internal static bool AssetTagsManifestUntag(IntPtr assetTagsManifest, string assetId, string tagName)
         {
            if (_AssetTagsManifestUntagFunc == null)
            {
               _AssetTagsManifestUntagFunc =
                  (_AssetTagsManifestUntag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetTagsManifestUntag"), typeof(_AssetTagsManifestUntag));
            }

            return _AssetTagsManifestUntagFunc(assetTagsManifest, assetId, tagName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetTagsManifestHasTag(IntPtr assetTagsManifest, string assetId, string tagName);
         private static _AssetTagsManifestHasTag _AssetTagsManifestHasTagFunc;
         internal static bool AssetTagsManifestHasTag(IntPtr assetTagsManifest, string assetId, string tagName)
         {
            if (_AssetTagsManifestHasTagFunc == null)
            {
               _AssetTagsManifestHasTagFunc =
                  (_AssetTagsManifestHasTag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetTagsManifestHasTag"), typeof(_AssetTagsManifestHasTag));
            }

            return _AssetTagsManifestHasTagFunc(assetTagsManifest, assetId, tagName);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void CreateTag(string tagName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.AssetTagsManifestCreateTag(ObjectPtr->ObjPtr, tagName);
      }

      public bool RenameTag(string oldTagName, string newTagName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetTagsManifestRenameTag(ObjectPtr->ObjPtr, oldTagName, newTagName);
      }

      public bool DeleteTag(string tagName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetTagsManifestDeleteTag(ObjectPtr->ObjPtr, tagName);
      }

      public bool IsTag(string tagName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetTagsManifestIsTag(ObjectPtr->ObjPtr, tagName);
      }

      public int GetTagCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetTagsManifestGetTagCount(ObjectPtr->ObjPtr);
      }

      public string GetTag(int tagIndex)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.AssetTagsManifestGetTag(ObjectPtr->ObjPtr, tagIndex));
      }

      public int GetAssetTagCount(string assetId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetTagsManifestGetAssetTagCount(ObjectPtr->ObjPtr, assetId);
      }

      public string GetAssetTag(string assetId, int tagIndex)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.AssetTagsManifestGetAssetTag(ObjectPtr->ObjPtr, assetId, tagIndex));
      }

      public bool Tag(string assetId, string tagName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetTagsManifestTag(ObjectPtr->ObjPtr, assetId, tagName);
      }

      public bool Untag(string assetId, string tagName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetTagsManifestUntag(ObjectPtr->ObjPtr, assetId, tagName);
      }

      public bool HasTag(string assetId, string tagName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetTagsManifestHasTag(ObjectPtr->ObjPtr, assetId, tagName);
      }
      
      #endregion

      
   }
}