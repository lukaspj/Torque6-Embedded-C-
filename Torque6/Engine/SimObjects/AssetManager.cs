using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class AssetManager : SimObject
   {
      
      public AssetManager()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.AssetManagerCreateInstance());
      }

      public AssetManager(uint pId) : base(pId)
      {
      }

      public AssetManager(string pName) : base(pName)
      {
      }

      public AssetManager(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public AssetManager(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public AssetManager(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerGetEchoInfo(IntPtr assetManager);
         private static _AssetManagerGetEchoInfo _AssetManagerGetEchoInfoFunc;
         internal static bool AssetManagerGetEchoInfo(IntPtr assetManager)
         {
            if (_AssetManagerGetEchoInfoFunc == null)
            {
               _AssetManagerGetEchoInfoFunc =
                  (_AssetManagerGetEchoInfo)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerGetEchoInfo"), typeof(_AssetManagerGetEchoInfo));
            }

            return _AssetManagerGetEchoInfoFunc(assetManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AssetManagerSetEchoInfo(IntPtr assetManager, bool val);
         private static _AssetManagerSetEchoInfo _AssetManagerSetEchoInfoFunc;
         internal static void AssetManagerSetEchoInfo(IntPtr assetManager, bool val)
         {
            if (_AssetManagerSetEchoInfoFunc == null)
            {
               _AssetManagerSetEchoInfoFunc =
                  (_AssetManagerSetEchoInfo)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerSetEchoInfo"), typeof(_AssetManagerSetEchoInfo));
            }

            _AssetManagerSetEchoInfoFunc(assetManager, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerGetIgnoreAutoUnload(IntPtr assetManager);
         private static _AssetManagerGetIgnoreAutoUnload _AssetManagerGetIgnoreAutoUnloadFunc;
         internal static bool AssetManagerGetIgnoreAutoUnload(IntPtr assetManager)
         {
            if (_AssetManagerGetIgnoreAutoUnloadFunc == null)
            {
               _AssetManagerGetIgnoreAutoUnloadFunc =
                  (_AssetManagerGetIgnoreAutoUnload)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerGetIgnoreAutoUnload"), typeof(_AssetManagerGetIgnoreAutoUnload));
            }

            return _AssetManagerGetIgnoreAutoUnloadFunc(assetManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AssetManagerSetIgnoreAutoUnload(IntPtr assetManager, bool val);
         private static _AssetManagerSetIgnoreAutoUnload _AssetManagerSetIgnoreAutoUnloadFunc;
         internal static void AssetManagerSetIgnoreAutoUnload(IntPtr assetManager, bool val)
         {
            if (_AssetManagerSetIgnoreAutoUnloadFunc == null)
            {
               _AssetManagerSetIgnoreAutoUnloadFunc =
                  (_AssetManagerSetIgnoreAutoUnload)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerSetIgnoreAutoUnload"), typeof(_AssetManagerSetIgnoreAutoUnload));
            }

            _AssetManagerSetIgnoreAutoUnloadFunc(assetManager, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetManagerCreateInstance();
         private static _AssetManagerCreateInstance _AssetManagerCreateInstanceFunc;
         internal static IntPtr AssetManagerCreateInstance()
         {
            if (_AssetManagerCreateInstanceFunc == null)
            {
               _AssetManagerCreateInstanceFunc =
                  (_AssetManagerCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerCreateInstance"), typeof(_AssetManagerCreateInstance));
            }

            return _AssetManagerCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerCompileReferencedAssets(IntPtr assetManager, IntPtr moduleDefinition);
         private static _AssetManagerCompileReferencedAssets _AssetManagerCompileReferencedAssetsFunc;
         internal static bool AssetManagerCompileReferencedAssets(IntPtr assetManager, IntPtr moduleDefinition)
         {
            if (_AssetManagerCompileReferencedAssetsFunc == null)
            {
               _AssetManagerCompileReferencedAssetsFunc =
                  (_AssetManagerCompileReferencedAssets)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerCompileReferencedAssets"), typeof(_AssetManagerCompileReferencedAssets));
            }

            return _AssetManagerCompileReferencedAssetsFunc(assetManager, moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerAddModuleDeclaredAssets(IntPtr assetManager, IntPtr moduleDefinition);
         private static _AssetManagerAddModuleDeclaredAssets _AssetManagerAddModuleDeclaredAssetsFunc;
         internal static bool AssetManagerAddModuleDeclaredAssets(IntPtr assetManager, IntPtr moduleDefinition)
         {
            if (_AssetManagerAddModuleDeclaredAssetsFunc == null)
            {
               _AssetManagerAddModuleDeclaredAssetsFunc =
                  (_AssetManagerAddModuleDeclaredAssets)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerAddModuleDeclaredAssets"), typeof(_AssetManagerAddModuleDeclaredAssets));
            }

            return _AssetManagerAddModuleDeclaredAssetsFunc(assetManager, moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerAddDeclaredAsset(IntPtr assetManager, IntPtr moduleDefinition, string assetFilePath);
         private static _AssetManagerAddDeclaredAsset _AssetManagerAddDeclaredAssetFunc;
         internal static bool AssetManagerAddDeclaredAsset(IntPtr assetManager, IntPtr moduleDefinition, string assetFilePath)
         {
            if (_AssetManagerAddDeclaredAssetFunc == null)
            {
               _AssetManagerAddDeclaredAssetFunc =
                  (_AssetManagerAddDeclaredAsset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerAddDeclaredAsset"), typeof(_AssetManagerAddDeclaredAsset));
            }

            return _AssetManagerAddDeclaredAssetFunc(assetManager, moduleDefinition, assetFilePath);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetManagerAddPrivateAsset(IntPtr assetManager, IntPtr assetObject);
         private static _AssetManagerAddPrivateAsset _AssetManagerAddPrivateAssetFunc;
         internal static IntPtr AssetManagerAddPrivateAsset(IntPtr assetManager, IntPtr assetObject)
         {
            if (_AssetManagerAddPrivateAssetFunc == null)
            {
               _AssetManagerAddPrivateAssetFunc =
                  (_AssetManagerAddPrivateAsset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerAddPrivateAsset"), typeof(_AssetManagerAddPrivateAsset));
            }

            return _AssetManagerAddPrivateAssetFunc(assetManager, assetObject);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerRemoveDeclaredAssets(IntPtr assetManager, IntPtr moduleDefinition);
         private static _AssetManagerRemoveDeclaredAssets _AssetManagerRemoveDeclaredAssetsFunc;
         internal static bool AssetManagerRemoveDeclaredAssets(IntPtr assetManager, IntPtr moduleDefinition)
         {
            if (_AssetManagerRemoveDeclaredAssetsFunc == null)
            {
               _AssetManagerRemoveDeclaredAssetsFunc =
                  (_AssetManagerRemoveDeclaredAssets)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerRemoveDeclaredAssets"), typeof(_AssetManagerRemoveDeclaredAssets));
            }

            return _AssetManagerRemoveDeclaredAssetsFunc(assetManager, moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerRemoveDeclaredAsset(IntPtr assetManager, string assetId);
         private static _AssetManagerRemoveDeclaredAsset _AssetManagerRemoveDeclaredAssetFunc;
         internal static bool AssetManagerRemoveDeclaredAsset(IntPtr assetManager, string assetId)
         {
            if (_AssetManagerRemoveDeclaredAssetFunc == null)
            {
               _AssetManagerRemoveDeclaredAssetFunc =
                  (_AssetManagerRemoveDeclaredAsset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerRemoveDeclaredAsset"), typeof(_AssetManagerRemoveDeclaredAsset));
            }

            return _AssetManagerRemoveDeclaredAssetFunc(assetManager, assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetManagerGetAssetName(IntPtr assetManager, string assetId);
         private static _AssetManagerGetAssetName _AssetManagerGetAssetNameFunc;
         internal static IntPtr AssetManagerGetAssetName(IntPtr assetManager, string assetId)
         {
            if (_AssetManagerGetAssetNameFunc == null)
            {
               _AssetManagerGetAssetNameFunc =
                  (_AssetManagerGetAssetName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerGetAssetName"), typeof(_AssetManagerGetAssetName));
            }

            return _AssetManagerGetAssetNameFunc(assetManager, assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetManagerGetAssetDescription(IntPtr assetManager, string assetId);
         private static _AssetManagerGetAssetDescription _AssetManagerGetAssetDescriptionFunc;
         internal static IntPtr AssetManagerGetAssetDescription(IntPtr assetManager, string assetId)
         {
            if (_AssetManagerGetAssetDescriptionFunc == null)
            {
               _AssetManagerGetAssetDescriptionFunc =
                  (_AssetManagerGetAssetDescription)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerGetAssetDescription"), typeof(_AssetManagerGetAssetDescription));
            }

            return _AssetManagerGetAssetDescriptionFunc(assetManager, assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetManagerGetAssetCategory(IntPtr assetManager, string assetId);
         private static _AssetManagerGetAssetCategory _AssetManagerGetAssetCategoryFunc;
         internal static IntPtr AssetManagerGetAssetCategory(IntPtr assetManager, string assetId)
         {
            if (_AssetManagerGetAssetCategoryFunc == null)
            {
               _AssetManagerGetAssetCategoryFunc =
                  (_AssetManagerGetAssetCategory)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerGetAssetCategory"), typeof(_AssetManagerGetAssetCategory));
            }

            return _AssetManagerGetAssetCategoryFunc(assetManager, assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetManagerGetAssetType(IntPtr assetManager, string assetId);
         private static _AssetManagerGetAssetType _AssetManagerGetAssetTypeFunc;
         internal static IntPtr AssetManagerGetAssetType(IntPtr assetManager, string assetId)
         {
            if (_AssetManagerGetAssetTypeFunc == null)
            {
               _AssetManagerGetAssetTypeFunc =
                  (_AssetManagerGetAssetType)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerGetAssetType"), typeof(_AssetManagerGetAssetType));
            }

            return _AssetManagerGetAssetTypeFunc(assetManager, assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetManagerGetAssetFilePath(IntPtr assetManager, string assetId);
         private static _AssetManagerGetAssetFilePath _AssetManagerGetAssetFilePathFunc;
         internal static IntPtr AssetManagerGetAssetFilePath(IntPtr assetManager, string assetId)
         {
            if (_AssetManagerGetAssetFilePathFunc == null)
            {
               _AssetManagerGetAssetFilePathFunc =
                  (_AssetManagerGetAssetFilePath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerGetAssetFilePath"), typeof(_AssetManagerGetAssetFilePath));
            }

            return _AssetManagerGetAssetFilePathFunc(assetManager, assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetManagerGetAssetPath(IntPtr assetManager, string assetId);
         private static _AssetManagerGetAssetPath _AssetManagerGetAssetPathFunc;
         internal static IntPtr AssetManagerGetAssetPath(IntPtr assetManager, string assetId)
         {
            if (_AssetManagerGetAssetPathFunc == null)
            {
               _AssetManagerGetAssetPathFunc =
                  (_AssetManagerGetAssetPath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerGetAssetPath"), typeof(_AssetManagerGetAssetPath));
            }

            return _AssetManagerGetAssetPathFunc(assetManager, assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetManagerGetAssetModule(IntPtr assetManager, string assetId);
         private static _AssetManagerGetAssetModule _AssetManagerGetAssetModuleFunc;
         internal static IntPtr AssetManagerGetAssetModule(IntPtr assetManager, string assetId)
         {
            if (_AssetManagerGetAssetModuleFunc == null)
            {
               _AssetManagerGetAssetModuleFunc =
                  (_AssetManagerGetAssetModule)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerGetAssetModule"), typeof(_AssetManagerGetAssetModule));
            }

            return _AssetManagerGetAssetModuleFunc(assetManager, assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerIsAssetInternal(IntPtr assetManager, string assetId);
         private static _AssetManagerIsAssetInternal _AssetManagerIsAssetInternalFunc;
         internal static bool AssetManagerIsAssetInternal(IntPtr assetManager, string assetId)
         {
            if (_AssetManagerIsAssetInternalFunc == null)
            {
               _AssetManagerIsAssetInternalFunc =
                  (_AssetManagerIsAssetInternal)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerIsAssetInternal"), typeof(_AssetManagerIsAssetInternal));
            }

            return _AssetManagerIsAssetInternalFunc(assetManager, assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerIsAssetPrivate(IntPtr assetManager, string assetId);
         private static _AssetManagerIsAssetPrivate _AssetManagerIsAssetPrivateFunc;
         internal static bool AssetManagerIsAssetPrivate(IntPtr assetManager, string assetId)
         {
            if (_AssetManagerIsAssetPrivateFunc == null)
            {
               _AssetManagerIsAssetPrivateFunc =
                  (_AssetManagerIsAssetPrivate)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerIsAssetPrivate"), typeof(_AssetManagerIsAssetPrivate));
            }

            return _AssetManagerIsAssetPrivateFunc(assetManager, assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerIsAssetAutoUnload(IntPtr assetManager, string assetId);
         private static _AssetManagerIsAssetAutoUnload _AssetManagerIsAssetAutoUnloadFunc;
         internal static bool AssetManagerIsAssetAutoUnload(IntPtr assetManager, string assetId)
         {
            if (_AssetManagerIsAssetAutoUnloadFunc == null)
            {
               _AssetManagerIsAssetAutoUnloadFunc =
                  (_AssetManagerIsAssetAutoUnload)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerIsAssetAutoUnload"), typeof(_AssetManagerIsAssetAutoUnload));
            }

            return _AssetManagerIsAssetAutoUnloadFunc(assetManager, assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerIsAssetLoaded(IntPtr assetManager, string assetId);
         private static _AssetManagerIsAssetLoaded _AssetManagerIsAssetLoadedFunc;
         internal static bool AssetManagerIsAssetLoaded(IntPtr assetManager, string assetId)
         {
            if (_AssetManagerIsAssetLoadedFunc == null)
            {
               _AssetManagerIsAssetLoadedFunc =
                  (_AssetManagerIsAssetLoaded)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerIsAssetLoaded"), typeof(_AssetManagerIsAssetLoaded));
            }

            return _AssetManagerIsAssetLoadedFunc(assetManager, assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerIsDeclaredAsset(IntPtr assetManager, string assetId);
         private static _AssetManagerIsDeclaredAsset _AssetManagerIsDeclaredAssetFunc;
         internal static bool AssetManagerIsDeclaredAsset(IntPtr assetManager, string assetId)
         {
            if (_AssetManagerIsDeclaredAssetFunc == null)
            {
               _AssetManagerIsDeclaredAssetFunc =
                  (_AssetManagerIsDeclaredAsset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerIsDeclaredAsset"), typeof(_AssetManagerIsDeclaredAsset));
            }

            return _AssetManagerIsDeclaredAssetFunc(assetManager, assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerIsReferencedAsset(IntPtr assetManager, string assetId);
         private static _AssetManagerIsReferencedAsset _AssetManagerIsReferencedAssetFunc;
         internal static bool AssetManagerIsReferencedAsset(IntPtr assetManager, string assetId)
         {
            if (_AssetManagerIsReferencedAssetFunc == null)
            {
               _AssetManagerIsReferencedAssetFunc =
                  (_AssetManagerIsReferencedAsset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerIsReferencedAsset"), typeof(_AssetManagerIsReferencedAsset));
            }

            return _AssetManagerIsReferencedAssetFunc(assetManager, assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerRenameDeclaredAsset(IntPtr assetManager, string assetIdFrom, string assetIdTo);
         private static _AssetManagerRenameDeclaredAsset _AssetManagerRenameDeclaredAssetFunc;
         internal static bool AssetManagerRenameDeclaredAsset(IntPtr assetManager, string assetIdFrom, string assetIdTo)
         {
            if (_AssetManagerRenameDeclaredAssetFunc == null)
            {
               _AssetManagerRenameDeclaredAssetFunc =
                  (_AssetManagerRenameDeclaredAsset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerRenameDeclaredAsset"), typeof(_AssetManagerRenameDeclaredAsset));
            }

            return _AssetManagerRenameDeclaredAssetFunc(assetManager, assetIdFrom, assetIdTo);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerRenameReferencedAsset(IntPtr assetManager, string assetIdFrom, string assetIdTo);
         private static _AssetManagerRenameReferencedAsset _AssetManagerRenameReferencedAssetFunc;
         internal static bool AssetManagerRenameReferencedAsset(IntPtr assetManager, string assetIdFrom, string assetIdTo)
         {
            if (_AssetManagerRenameReferencedAssetFunc == null)
            {
               _AssetManagerRenameReferencedAssetFunc =
                  (_AssetManagerRenameReferencedAsset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerRenameReferencedAsset"), typeof(_AssetManagerRenameReferencedAsset));
            }

            return _AssetManagerRenameReferencedAssetFunc(assetManager, assetIdFrom, assetIdTo);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetManagerAcquireAsset(IntPtr assetManager, string assetId, bool asPrivate);
         private static _AssetManagerAcquireAsset _AssetManagerAcquireAssetFunc;
         internal static IntPtr AssetManagerAcquireAsset(IntPtr assetManager, string assetId, bool asPrivate)
         {
            if (_AssetManagerAcquireAssetFunc == null)
            {
               _AssetManagerAcquireAssetFunc =
                  (_AssetManagerAcquireAsset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerAcquireAsset"), typeof(_AssetManagerAcquireAsset));
            }

            return _AssetManagerAcquireAssetFunc(assetManager, assetId, asPrivate);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerReleaseAsset(IntPtr assetManager, string assetId);
         private static _AssetManagerReleaseAsset _AssetManagerReleaseAssetFunc;
         internal static bool AssetManagerReleaseAsset(IntPtr assetManager, string assetId)
         {
            if (_AssetManagerReleaseAssetFunc == null)
            {
               _AssetManagerReleaseAssetFunc =
                  (_AssetManagerReleaseAsset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerReleaseAsset"), typeof(_AssetManagerReleaseAsset));
            }

            return _AssetManagerReleaseAssetFunc(assetManager, assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AssetManagerPurgeAssets(IntPtr assetManager);
         private static _AssetManagerPurgeAssets _AssetManagerPurgeAssetsFunc;
         internal static void AssetManagerPurgeAssets(IntPtr assetManager)
         {
            if (_AssetManagerPurgeAssetsFunc == null)
            {
               _AssetManagerPurgeAssetsFunc =
                  (_AssetManagerPurgeAssets)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerPurgeAssets"), typeof(_AssetManagerPurgeAssets));
            }

            _AssetManagerPurgeAssetsFunc(assetManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerDeleteAsset(IntPtr assetManager, string assetId, bool deleteLooseFiles, bool deleteDependencies);
         private static _AssetManagerDeleteAsset _AssetManagerDeleteAssetFunc;
         internal static bool AssetManagerDeleteAsset(IntPtr assetManager, string assetId, bool deleteLooseFiles, bool deleteDependencies)
         {
            if (_AssetManagerDeleteAssetFunc == null)
            {
               _AssetManagerDeleteAssetFunc =
                  (_AssetManagerDeleteAsset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerDeleteAsset"), typeof(_AssetManagerDeleteAsset));
            }

            return _AssetManagerDeleteAssetFunc(assetManager, assetId, deleteLooseFiles, deleteDependencies);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AssetManagerRefreshAsset(IntPtr assetManager, string assetId);
         private static _AssetManagerRefreshAsset _AssetManagerRefreshAssetFunc;
         internal static void AssetManagerRefreshAsset(IntPtr assetManager, string assetId)
         {
            if (_AssetManagerRefreshAssetFunc == null)
            {
               _AssetManagerRefreshAssetFunc =
                  (_AssetManagerRefreshAsset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerRefreshAsset"), typeof(_AssetManagerRefreshAsset));
            }

            _AssetManagerRefreshAssetFunc(assetManager, assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AssetManagerRefreshAllAssets(IntPtr assetManager, bool includeUnloaded);
         private static _AssetManagerRefreshAllAssets _AssetManagerRefreshAllAssetsFunc;
         internal static void AssetManagerRefreshAllAssets(IntPtr assetManager, bool includeUnloaded)
         {
            if (_AssetManagerRefreshAllAssetsFunc == null)
            {
               _AssetManagerRefreshAllAssetsFunc =
                  (_AssetManagerRefreshAllAssets)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerRefreshAllAssets"), typeof(_AssetManagerRefreshAllAssets));
            }

            _AssetManagerRefreshAllAssetsFunc(assetManager, includeUnloaded);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerSaveAssetTags(IntPtr assetManager);
         private static _AssetManagerSaveAssetTags _AssetManagerSaveAssetTagsFunc;
         internal static bool AssetManagerSaveAssetTags(IntPtr assetManager)
         {
            if (_AssetManagerSaveAssetTagsFunc == null)
            {
               _AssetManagerSaveAssetTagsFunc =
                  (_AssetManagerSaveAssetTags)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerSaveAssetTags"), typeof(_AssetManagerSaveAssetTags));
            }

            return _AssetManagerSaveAssetTagsFunc(assetManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerRestoreAssetTags(IntPtr assetManager);
         private static _AssetManagerRestoreAssetTags _AssetManagerRestoreAssetTagsFunc;
         internal static bool AssetManagerRestoreAssetTags(IntPtr assetManager)
         {
            if (_AssetManagerRestoreAssetTagsFunc == null)
            {
               _AssetManagerRestoreAssetTagsFunc =
                  (_AssetManagerRestoreAssetTags)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerRestoreAssetTags"), typeof(_AssetManagerRestoreAssetTags));
            }

            return _AssetManagerRestoreAssetTagsFunc(assetManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetManagerGetAssetTags(IntPtr assetManager);
         private static _AssetManagerGetAssetTags _AssetManagerGetAssetTagsFunc;
         internal static IntPtr AssetManagerGetAssetTags(IntPtr assetManager)
         {
            if (_AssetManagerGetAssetTagsFunc == null)
            {
               _AssetManagerGetAssetTagsFunc =
                  (_AssetManagerGetAssetTags)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerGetAssetTags"), typeof(_AssetManagerGetAssetTags));
            }

            return _AssetManagerGetAssetTagsFunc(assetManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AssetManagerFindAllAssets(IntPtr assetManager, IntPtr assetQuery, bool ignoreInternal, bool ignorePrivate);
         private static _AssetManagerFindAllAssets _AssetManagerFindAllAssetsFunc;
         internal static int AssetManagerFindAllAssets(IntPtr assetManager, IntPtr assetQuery, bool ignoreInternal, bool ignorePrivate)
         {
            if (_AssetManagerFindAllAssetsFunc == null)
            {
               _AssetManagerFindAllAssetsFunc =
                  (_AssetManagerFindAllAssets)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerFindAllAssets"), typeof(_AssetManagerFindAllAssets));
            }

            return _AssetManagerFindAllAssetsFunc(assetManager, assetQuery, ignoreInternal, ignorePrivate);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AssetManagerFindAssetName(IntPtr assetManager, IntPtr assetQuery, string assetName, bool partialName);
         private static _AssetManagerFindAssetName _AssetManagerFindAssetNameFunc;
         internal static int AssetManagerFindAssetName(IntPtr assetManager, IntPtr assetQuery, string assetName, bool partialName)
         {
            if (_AssetManagerFindAssetNameFunc == null)
            {
               _AssetManagerFindAssetNameFunc =
                  (_AssetManagerFindAssetName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerFindAssetName"), typeof(_AssetManagerFindAssetName));
            }

            return _AssetManagerFindAssetNameFunc(assetManager, assetQuery, assetName, partialName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AssetManagerFindAssetCategory(IntPtr assetManager, IntPtr assetQuery, string assetName, bool assetQueryAsSource);
         private static _AssetManagerFindAssetCategory _AssetManagerFindAssetCategoryFunc;
         internal static int AssetManagerFindAssetCategory(IntPtr assetManager, IntPtr assetQuery, string assetName, bool assetQueryAsSource)
         {
            if (_AssetManagerFindAssetCategoryFunc == null)
            {
               _AssetManagerFindAssetCategoryFunc =
                  (_AssetManagerFindAssetCategory)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerFindAssetCategory"), typeof(_AssetManagerFindAssetCategory));
            }

            return _AssetManagerFindAssetCategoryFunc(assetManager, assetQuery, assetName, assetQueryAsSource);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AssetManagerFindAssetAutoUnload(IntPtr assetManager, IntPtr assetQuery, bool assetAutoUnload, bool assetQueryAsSource);
         private static _AssetManagerFindAssetAutoUnload _AssetManagerFindAssetAutoUnloadFunc;
         internal static int AssetManagerFindAssetAutoUnload(IntPtr assetManager, IntPtr assetQuery, bool assetAutoUnload, bool assetQueryAsSource)
         {
            if (_AssetManagerFindAssetAutoUnloadFunc == null)
            {
               _AssetManagerFindAssetAutoUnloadFunc =
                  (_AssetManagerFindAssetAutoUnload)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerFindAssetAutoUnload"), typeof(_AssetManagerFindAssetAutoUnload));
            }

            return _AssetManagerFindAssetAutoUnloadFunc(assetManager, assetQuery, assetAutoUnload, assetQueryAsSource);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AssetManagerFindAssetInternal(IntPtr assetManager, IntPtr assetQuery, bool assetInternal, bool assetQueryAsSource);
         private static _AssetManagerFindAssetInternal _AssetManagerFindAssetInternalFunc;
         internal static int AssetManagerFindAssetInternal(IntPtr assetManager, IntPtr assetQuery, bool assetInternal, bool assetQueryAsSource)
         {
            if (_AssetManagerFindAssetInternalFunc == null)
            {
               _AssetManagerFindAssetInternalFunc =
                  (_AssetManagerFindAssetInternal)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerFindAssetInternal"), typeof(_AssetManagerFindAssetInternal));
            }

            return _AssetManagerFindAssetInternalFunc(assetManager, assetQuery, assetInternal, assetQueryAsSource);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AssetManagerFindAssetPrivate(IntPtr assetManager, IntPtr assetQuery, bool assetPrivate, bool assetQueryAsSource);
         private static _AssetManagerFindAssetPrivate _AssetManagerFindAssetPrivateFunc;
         internal static int AssetManagerFindAssetPrivate(IntPtr assetManager, IntPtr assetQuery, bool assetPrivate, bool assetQueryAsSource)
         {
            if (_AssetManagerFindAssetPrivateFunc == null)
            {
               _AssetManagerFindAssetPrivateFunc =
                  (_AssetManagerFindAssetPrivate)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerFindAssetPrivate"), typeof(_AssetManagerFindAssetPrivate));
            }

            return _AssetManagerFindAssetPrivateFunc(assetManager, assetQuery, assetPrivate, assetQueryAsSource);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AssetManagerFindAssetType(IntPtr assetManager, IntPtr assetQuery, string assetType, bool assetQueryAsSource);
         private static _AssetManagerFindAssetType _AssetManagerFindAssetTypeFunc;
         internal static int AssetManagerFindAssetType(IntPtr assetManager, IntPtr assetQuery, string assetType, bool assetQueryAsSource)
         {
            if (_AssetManagerFindAssetTypeFunc == null)
            {
               _AssetManagerFindAssetTypeFunc =
                  (_AssetManagerFindAssetType)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerFindAssetType"), typeof(_AssetManagerFindAssetType));
            }

            return _AssetManagerFindAssetTypeFunc(assetManager, assetQuery, assetType, assetQueryAsSource);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AssetManagerFindAssetDependsOn(IntPtr assetManager, IntPtr assetQuery, string assetId);
         private static _AssetManagerFindAssetDependsOn _AssetManagerFindAssetDependsOnFunc;
         internal static int AssetManagerFindAssetDependsOn(IntPtr assetManager, IntPtr assetQuery, string assetId)
         {
            if (_AssetManagerFindAssetDependsOnFunc == null)
            {
               _AssetManagerFindAssetDependsOnFunc =
                  (_AssetManagerFindAssetDependsOn)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerFindAssetDependsOn"), typeof(_AssetManagerFindAssetDependsOn));
            }

            return _AssetManagerFindAssetDependsOnFunc(assetManager, assetQuery, assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AssetManagerFindAssetIsDependedOn(IntPtr assetManager, IntPtr assetQuery, string assetId);
         private static _AssetManagerFindAssetIsDependedOn _AssetManagerFindAssetIsDependedOnFunc;
         internal static int AssetManagerFindAssetIsDependedOn(IntPtr assetManager, IntPtr assetQuery, string assetId)
         {
            if (_AssetManagerFindAssetIsDependedOnFunc == null)
            {
               _AssetManagerFindAssetIsDependedOnFunc =
                  (_AssetManagerFindAssetIsDependedOn)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerFindAssetIsDependedOn"), typeof(_AssetManagerFindAssetIsDependedOn));
            }

            return _AssetManagerFindAssetIsDependedOnFunc(assetManager, assetQuery, assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AssetManagerFindInvalidAssetReferences(IntPtr assetManager, IntPtr assetQuery);
         private static _AssetManagerFindInvalidAssetReferences _AssetManagerFindInvalidAssetReferencesFunc;
         internal static int AssetManagerFindInvalidAssetReferences(IntPtr assetManager, IntPtr assetQuery)
         {
            if (_AssetManagerFindInvalidAssetReferencesFunc == null)
            {
               _AssetManagerFindInvalidAssetReferencesFunc =
                  (_AssetManagerFindInvalidAssetReferences)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerFindInvalidAssetReferences"), typeof(_AssetManagerFindInvalidAssetReferences));
            }

            return _AssetManagerFindInvalidAssetReferencesFunc(assetManager, assetQuery);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AssetManagerFindTaggedAssets(IntPtr assetManager, IntPtr assetQuery, string assetTagNames, bool assetQueryAsSource);
         private static _AssetManagerFindTaggedAssets _AssetManagerFindTaggedAssetsFunc;
         internal static int AssetManagerFindTaggedAssets(IntPtr assetManager, IntPtr assetQuery, string assetTagNames, bool assetQueryAsSource)
         {
            if (_AssetManagerFindTaggedAssetsFunc == null)
            {
               _AssetManagerFindTaggedAssetsFunc =
                  (_AssetManagerFindTaggedAssets)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerFindTaggedAssets"), typeof(_AssetManagerFindTaggedAssets));
            }

            return _AssetManagerFindTaggedAssetsFunc(assetManager, assetQuery, assetTagNames, assetQueryAsSource);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AssetManagerFindAssetLooseFile(IntPtr assetManager, IntPtr assetQuery, string assetLooseFile, bool assetQueryAsSource);
         private static _AssetManagerFindAssetLooseFile _AssetManagerFindAssetLooseFileFunc;
         internal static int AssetManagerFindAssetLooseFile(IntPtr assetManager, IntPtr assetQuery, string assetLooseFile, bool assetQueryAsSource)
         {
            if (_AssetManagerFindAssetLooseFileFunc == null)
            {
               _AssetManagerFindAssetLooseFileFunc =
                  (_AssetManagerFindAssetLooseFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerFindAssetLooseFile"), typeof(_AssetManagerFindAssetLooseFile));
            }

            return _AssetManagerFindAssetLooseFileFunc(assetManager, assetQuery, assetLooseFile, assetQueryAsSource);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerGetDeclaredAssetCount(IntPtr assetManager);
         private static _AssetManagerGetDeclaredAssetCount _AssetManagerGetDeclaredAssetCountFunc;
         internal static bool AssetManagerGetDeclaredAssetCount(IntPtr assetManager)
         {
            if (_AssetManagerGetDeclaredAssetCountFunc == null)
            {
               _AssetManagerGetDeclaredAssetCountFunc =
                  (_AssetManagerGetDeclaredAssetCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerGetDeclaredAssetCount"), typeof(_AssetManagerGetDeclaredAssetCount));
            }

            return _AssetManagerGetDeclaredAssetCountFunc(assetManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerGetReferencedAssetCount(IntPtr assetManager);
         private static _AssetManagerGetReferencedAssetCount _AssetManagerGetReferencedAssetCountFunc;
         internal static bool AssetManagerGetReferencedAssetCount(IntPtr assetManager)
         {
            if (_AssetManagerGetReferencedAssetCountFunc == null)
            {
               _AssetManagerGetReferencedAssetCountFunc =
                  (_AssetManagerGetReferencedAssetCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerGetReferencedAssetCount"), typeof(_AssetManagerGetReferencedAssetCount));
            }

            return _AssetManagerGetReferencedAssetCountFunc(assetManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerGetLoadedInternalAssetCount(IntPtr assetManager);
         private static _AssetManagerGetLoadedInternalAssetCount _AssetManagerGetLoadedInternalAssetCountFunc;
         internal static bool AssetManagerGetLoadedInternalAssetCount(IntPtr assetManager)
         {
            if (_AssetManagerGetLoadedInternalAssetCountFunc == null)
            {
               _AssetManagerGetLoadedInternalAssetCountFunc =
                  (_AssetManagerGetLoadedInternalAssetCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerGetLoadedInternalAssetCount"), typeof(_AssetManagerGetLoadedInternalAssetCount));
            }

            return _AssetManagerGetLoadedInternalAssetCountFunc(assetManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerGetMaxLoadedInternalAssetCount(IntPtr assetManager);
         private static _AssetManagerGetMaxLoadedInternalAssetCount _AssetManagerGetMaxLoadedInternalAssetCountFunc;
         internal static bool AssetManagerGetMaxLoadedInternalAssetCount(IntPtr assetManager)
         {
            if (_AssetManagerGetMaxLoadedInternalAssetCountFunc == null)
            {
               _AssetManagerGetMaxLoadedInternalAssetCountFunc =
                  (_AssetManagerGetMaxLoadedInternalAssetCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerGetMaxLoadedInternalAssetCount"), typeof(_AssetManagerGetMaxLoadedInternalAssetCount));
            }

            return _AssetManagerGetMaxLoadedInternalAssetCountFunc(assetManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerGetLoadedExternalAssetCount(IntPtr assetManager);
         private static _AssetManagerGetLoadedExternalAssetCount _AssetManagerGetLoadedExternalAssetCountFunc;
         internal static bool AssetManagerGetLoadedExternalAssetCount(IntPtr assetManager)
         {
            if (_AssetManagerGetLoadedExternalAssetCountFunc == null)
            {
               _AssetManagerGetLoadedExternalAssetCountFunc =
                  (_AssetManagerGetLoadedExternalAssetCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerGetLoadedExternalAssetCount"), typeof(_AssetManagerGetLoadedExternalAssetCount));
            }

            return _AssetManagerGetLoadedExternalAssetCountFunc(assetManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AssetManagerGetMaxLoadedExternalAssetCount(IntPtr assetManager);
         private static _AssetManagerGetMaxLoadedExternalAssetCount _AssetManagerGetMaxLoadedExternalAssetCountFunc;
         internal static bool AssetManagerGetMaxLoadedExternalAssetCount(IntPtr assetManager)
         {
            if (_AssetManagerGetMaxLoadedExternalAssetCountFunc == null)
            {
               _AssetManagerGetMaxLoadedExternalAssetCountFunc =
                  (_AssetManagerGetMaxLoadedExternalAssetCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerGetMaxLoadedExternalAssetCount"), typeof(_AssetManagerGetMaxLoadedExternalAssetCount));
            }

            return _AssetManagerGetMaxLoadedExternalAssetCountFunc(assetManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AssetManagerDumpDeclaredAssets(IntPtr assetManager);
         private static _AssetManagerDumpDeclaredAssets _AssetManagerDumpDeclaredAssetsFunc;
         internal static void AssetManagerDumpDeclaredAssets(IntPtr assetManager)
         {
            if (_AssetManagerDumpDeclaredAssetsFunc == null)
            {
               _AssetManagerDumpDeclaredAssetsFunc =
                  (_AssetManagerDumpDeclaredAssets)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AssetManagerDumpDeclaredAssets"), typeof(_AssetManagerDumpDeclaredAssets));
            }

            _AssetManagerDumpDeclaredAssetsFunc(assetManager);
         }
      }
      
      #endregion

      #region Properties

      public bool EchoInfo
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AssetManagerGetEchoInfo(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AssetManagerSetEchoInfo(ObjectPtr->ObjPtr, value);
         }
      }
      public bool IgnoreAutoUnload
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AssetManagerGetIgnoreAutoUnload(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AssetManagerSetIgnoreAutoUnload(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public bool CompileReferencedAssets(ModuleDefinition moduleDefinition)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerCompileReferencedAssets(ObjectPtr->ObjPtr, moduleDefinition.ObjectPtr->ObjPtr);
      }

      public bool AddModuleDeclaredAssets(ModuleDefinition moduleDefinition)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerAddModuleDeclaredAssets(ObjectPtr->ObjPtr, moduleDefinition.ObjectPtr->ObjPtr);
      }

      public bool AddDeclaredAsset(ModuleDefinition moduleDefinition, string assetFilePath)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerAddDeclaredAsset(ObjectPtr->ObjPtr, moduleDefinition.ObjectPtr->ObjPtr, assetFilePath);
      }

      public string AddPrivateAsset(AssetBase assetObject)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.AssetManagerAddPrivateAsset(ObjectPtr->ObjPtr, assetObject.ObjectPtr->ObjPtr));
      }

      public bool RemoveDeclaredAssets(ModuleDefinition moduleDefinition)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerRemoveDeclaredAssets(ObjectPtr->ObjPtr, moduleDefinition.ObjectPtr->ObjPtr);
      }

      public bool RemoveDeclaredAsset(string assetId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerRemoveDeclaredAsset(ObjectPtr->ObjPtr, assetId);
      }

      public string GetAssetName(string assetId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.AssetManagerGetAssetName(ObjectPtr->ObjPtr, assetId));
      }

      public string GetAssetDescription(string assetId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.AssetManagerGetAssetDescription(ObjectPtr->ObjPtr, assetId));
      }

      public string GetAssetCategory(string assetId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.AssetManagerGetAssetCategory(ObjectPtr->ObjPtr, assetId));
      }

      public string GetAssetType(string assetId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.AssetManagerGetAssetType(ObjectPtr->ObjPtr, assetId));
      }

      public string GetAssetFilePath(string assetId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.AssetManagerGetAssetFilePath(ObjectPtr->ObjPtr, assetId));
      }

      public string GetAssetPath(string assetId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.AssetManagerGetAssetPath(ObjectPtr->ObjPtr, assetId));
      }

      public ModuleDefinition GetAssetModule(string assetId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new ModuleDefinition(InternalUnsafeMethods.AssetManagerGetAssetModule(ObjectPtr->ObjPtr, assetId));
      }

      public bool IsAssetInternal(string assetId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerIsAssetInternal(ObjectPtr->ObjPtr, assetId);
      }

      public bool IsAssetPrivate(string assetId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerIsAssetPrivate(ObjectPtr->ObjPtr, assetId);
      }

      public bool IsAssetAutoUnload(string assetId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerIsAssetAutoUnload(ObjectPtr->ObjPtr, assetId);
      }

      public bool IsAssetLoaded(string assetId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerIsAssetLoaded(ObjectPtr->ObjPtr, assetId);
      }

      public bool IsDeclaredAsset(string assetId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerIsDeclaredAsset(ObjectPtr->ObjPtr, assetId);
      }

      public bool IsReferencedAsset(string assetId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerIsReferencedAsset(ObjectPtr->ObjPtr, assetId);
      }

      public bool RenameDeclaredAsset(string assetIdFrom, string assetIdTo)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerRenameDeclaredAsset(ObjectPtr->ObjPtr, assetIdFrom, assetIdTo);
      }

      public bool RenameReferencedAsset(string assetIdFrom, string assetIdTo)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerRenameReferencedAsset(ObjectPtr->ObjPtr, assetIdFrom, assetIdTo);
      }

      public string AcquireAsset(string assetId, bool asPrivate = false)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.AssetManagerAcquireAsset(ObjectPtr->ObjPtr, assetId, asPrivate));
      }

      public bool ReleaseAsset(string assetId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerReleaseAsset(ObjectPtr->ObjPtr, assetId);
      }

      public void PurgeAssets()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.AssetManagerPurgeAssets(ObjectPtr->ObjPtr);
      }

      public bool DeleteAsset(string assetId, bool deleteLooseFiles, bool deleteDependencies)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerDeleteAsset(ObjectPtr->ObjPtr, assetId, deleteLooseFiles, deleteDependencies);
      }

      public void RefreshAsset(string assetId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.AssetManagerRefreshAsset(ObjectPtr->ObjPtr, assetId);
      }

      public void RefreshAllAssets(bool includeUnloaded = false)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.AssetManagerRefreshAllAssets(ObjectPtr->ObjPtr, includeUnloaded);
      }

      public bool SaveAssetTags()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerSaveAssetTags(ObjectPtr->ObjPtr);
      }

      public bool RestoreAssetTags()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerRestoreAssetTags(ObjectPtr->ObjPtr);
      }

      public AssetTagsManifest GetAssetTags()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new AssetTagsManifest(InternalUnsafeMethods.AssetManagerGetAssetTags(ObjectPtr->ObjPtr));
      }

      public int FindAllAssets(AssetQuery assetQuery, bool ignoreInternal = true, bool ignorePrivate = true)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerFindAllAssets(ObjectPtr->ObjPtr, assetQuery.ObjectPtr->ObjPtr, ignoreInternal, ignorePrivate);
      }

      public int FindAssetName(AssetQuery assetQuery, string assetName, bool partialName = false)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerFindAssetName(ObjectPtr->ObjPtr, assetQuery.ObjectPtr->ObjPtr, assetName, partialName);
      }

      public int FindAssetCategory(AssetQuery assetQuery, string assetName, bool assetQueryAsSource = false)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerFindAssetCategory(ObjectPtr->ObjPtr, assetQuery.ObjectPtr->ObjPtr, assetName, assetQueryAsSource);
      }

      public int FindAssetAutoUnload(AssetQuery assetQuery, bool assetAutoUnload, bool assetQueryAsSource = false)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerFindAssetAutoUnload(ObjectPtr->ObjPtr, assetQuery.ObjectPtr->ObjPtr, assetAutoUnload, assetQueryAsSource);
      }

      public int FindAssetInternal(AssetQuery assetQuery, bool assetInternal, bool assetQueryAsSource = false)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerFindAssetInternal(ObjectPtr->ObjPtr, assetQuery.ObjectPtr->ObjPtr, assetInternal, assetQueryAsSource);
      }

      public int FindAssetPrivate(AssetQuery assetQuery, bool assetPrivate, bool assetQueryAsSource = false)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerFindAssetPrivate(ObjectPtr->ObjPtr, assetQuery.ObjectPtr->ObjPtr, assetPrivate, assetQueryAsSource);
      }

      public int FindAssetType(AssetQuery assetQuery, string assetType, bool assetQueryAsSource = false)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerFindAssetType(ObjectPtr->ObjPtr, assetQuery.ObjectPtr->ObjPtr, assetType, assetQueryAsSource);
      }

      public int FindAssetDependsOn(AssetQuery assetQuery, string assetId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerFindAssetDependsOn(ObjectPtr->ObjPtr, assetQuery.ObjectPtr->ObjPtr, assetId);
      }

      public int FindAssetIsDependedOn(AssetQuery assetQuery, string assetId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerFindAssetIsDependedOn(ObjectPtr->ObjPtr, assetQuery.ObjectPtr->ObjPtr, assetId);
      }

      public int FindInvalidAssetReferences(AssetQuery assetQuery)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerFindInvalidAssetReferences(ObjectPtr->ObjPtr, assetQuery.ObjectPtr->ObjPtr);
      }

      public int FindTaggedAssets(AssetQuery assetQuery, string assetTagNames, bool assetQueryAsSource = false)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerFindTaggedAssets(ObjectPtr->ObjPtr, assetQuery.ObjectPtr->ObjPtr, assetTagNames, assetQueryAsSource);
      }

      public int FindAssetLooseFile(AssetQuery assetQuery, string assetLooseFile, bool assetQueryAsSource = false)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerFindAssetLooseFile(ObjectPtr->ObjPtr, assetQuery.ObjectPtr->ObjPtr, assetLooseFile, assetQueryAsSource);
      }

      public bool GetDeclaredAssetCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerGetDeclaredAssetCount(ObjectPtr->ObjPtr);
      }

      public bool GetReferencedAssetCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerGetReferencedAssetCount(ObjectPtr->ObjPtr);
      }

      public bool GetLoadedInternalAssetCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerGetLoadedInternalAssetCount(ObjectPtr->ObjPtr);
      }

      public bool GetMaxLoadedInternalAssetCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerGetMaxLoadedInternalAssetCount(ObjectPtr->ObjPtr);
      }

      public bool GetLoadedExternalAssetCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerGetLoadedExternalAssetCount(ObjectPtr->ObjPtr);
      }

      public bool GetMaxLoadedExternalAssetCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.AssetManagerGetMaxLoadedExternalAssetCount(ObjectPtr->ObjPtr);
      }

      public void DumpDeclaredAssets()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.AssetManagerDumpDeclaredAssets(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}