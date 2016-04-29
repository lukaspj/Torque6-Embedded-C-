using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class ModuleDefinition : SimSet
   {
      
      public ModuleDefinition()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.ModuleDefinitionCreateInstance());
      }

      public ModuleDefinition(uint pId) : base(pId)
      {
      }

      public ModuleDefinition(string pName) : base(pName)
      {
      }

      public ModuleDefinition(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public ModuleDefinition(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public ModuleDefinition(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleDefinitionGetModuleId(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetModuleId _ModuleDefinitionGetModuleIdFunc;
         internal static IntPtr ModuleDefinitionGetModuleId(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetModuleIdFunc == null)
            {
               _ModuleDefinitionGetModuleIdFunc =
                  (_ModuleDefinitionGetModuleId)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetModuleId"), typeof(_ModuleDefinitionGetModuleId));
            }

            return _ModuleDefinitionGetModuleIdFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleDefinitionSetModuleId(IntPtr moduleDefinition, string value);
         private static _ModuleDefinitionSetModuleId _ModuleDefinitionSetModuleIdFunc;
         internal static void ModuleDefinitionSetModuleId(IntPtr moduleDefinition, string value)
         {
            if (_ModuleDefinitionSetModuleIdFunc == null)
            {
               _ModuleDefinitionSetModuleIdFunc =
                  (_ModuleDefinitionSetModuleId)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionSetModuleId"), typeof(_ModuleDefinitionSetModuleId));
            }

            _ModuleDefinitionSetModuleIdFunc(moduleDefinition, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ModuleDefinitionGetVersionId(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetVersionId _ModuleDefinitionGetVersionIdFunc;
         internal static int ModuleDefinitionGetVersionId(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetVersionIdFunc == null)
            {
               _ModuleDefinitionGetVersionIdFunc =
                  (_ModuleDefinitionGetVersionId)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetVersionId"), typeof(_ModuleDefinitionGetVersionId));
            }

            return _ModuleDefinitionGetVersionIdFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleDefinitionSetVersionId(IntPtr moduleDefinition, int value);
         private static _ModuleDefinitionSetVersionId _ModuleDefinitionSetVersionIdFunc;
         internal static void ModuleDefinitionSetVersionId(IntPtr moduleDefinition, int value)
         {
            if (_ModuleDefinitionSetVersionIdFunc == null)
            {
               _ModuleDefinitionSetVersionIdFunc =
                  (_ModuleDefinitionSetVersionId)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionSetVersionId"), typeof(_ModuleDefinitionSetVersionId));
            }

            _ModuleDefinitionSetVersionIdFunc(moduleDefinition, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ModuleDefinitionGetBuildId(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetBuildId _ModuleDefinitionGetBuildIdFunc;
         internal static int ModuleDefinitionGetBuildId(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetBuildIdFunc == null)
            {
               _ModuleDefinitionGetBuildIdFunc =
                  (_ModuleDefinitionGetBuildId)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetBuildId"), typeof(_ModuleDefinitionGetBuildId));
            }

            return _ModuleDefinitionGetBuildIdFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleDefinitionSetBuildId(IntPtr moduleDefinition, int value);
         private static _ModuleDefinitionSetBuildId _ModuleDefinitionSetBuildIdFunc;
         internal static void ModuleDefinitionSetBuildId(IntPtr moduleDefinition, int value)
         {
            if (_ModuleDefinitionSetBuildIdFunc == null)
            {
               _ModuleDefinitionSetBuildIdFunc =
                  (_ModuleDefinitionSetBuildId)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionSetBuildId"), typeof(_ModuleDefinitionSetBuildId));
            }

            _ModuleDefinitionSetBuildIdFunc(moduleDefinition, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleDefinitionGetEnabled(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetEnabled _ModuleDefinitionGetEnabledFunc;
         internal static bool ModuleDefinitionGetEnabled(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetEnabledFunc == null)
            {
               _ModuleDefinitionGetEnabledFunc =
                  (_ModuleDefinitionGetEnabled)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetEnabled"), typeof(_ModuleDefinitionGetEnabled));
            }

            return _ModuleDefinitionGetEnabledFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleDefinitionSetEnabled(IntPtr moduleDefinition, bool value);
         private static _ModuleDefinitionSetEnabled _ModuleDefinitionSetEnabledFunc;
         internal static void ModuleDefinitionSetEnabled(IntPtr moduleDefinition, bool value)
         {
            if (_ModuleDefinitionSetEnabledFunc == null)
            {
               _ModuleDefinitionSetEnabledFunc =
                  (_ModuleDefinitionSetEnabled)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionSetEnabled"), typeof(_ModuleDefinitionSetEnabled));
            }

            _ModuleDefinitionSetEnabledFunc(moduleDefinition, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleDefinitionGetSynchronized(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetSynchronized _ModuleDefinitionGetSynchronizedFunc;
         internal static bool ModuleDefinitionGetSynchronized(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetSynchronizedFunc == null)
            {
               _ModuleDefinitionGetSynchronizedFunc =
                  (_ModuleDefinitionGetSynchronized)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetSynchronized"), typeof(_ModuleDefinitionGetSynchronized));
            }

            return _ModuleDefinitionGetSynchronizedFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleDefinitionSetSynchronized(IntPtr moduleDefinition, bool value);
         private static _ModuleDefinitionSetSynchronized _ModuleDefinitionSetSynchronizedFunc;
         internal static void ModuleDefinitionSetSynchronized(IntPtr moduleDefinition, bool value)
         {
            if (_ModuleDefinitionSetSynchronizedFunc == null)
            {
               _ModuleDefinitionSetSynchronizedFunc =
                  (_ModuleDefinitionSetSynchronized)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionSetSynchronized"), typeof(_ModuleDefinitionSetSynchronized));
            }

            _ModuleDefinitionSetSynchronizedFunc(moduleDefinition, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleDefinitionGetDeprecated(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetDeprecated _ModuleDefinitionGetDeprecatedFunc;
         internal static bool ModuleDefinitionGetDeprecated(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetDeprecatedFunc == null)
            {
               _ModuleDefinitionGetDeprecatedFunc =
                  (_ModuleDefinitionGetDeprecated)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetDeprecated"), typeof(_ModuleDefinitionGetDeprecated));
            }

            return _ModuleDefinitionGetDeprecatedFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleDefinitionSetDeprecated(IntPtr moduleDefinition, bool value);
         private static _ModuleDefinitionSetDeprecated _ModuleDefinitionSetDeprecatedFunc;
         internal static void ModuleDefinitionSetDeprecated(IntPtr moduleDefinition, bool value)
         {
            if (_ModuleDefinitionSetDeprecatedFunc == null)
            {
               _ModuleDefinitionSetDeprecatedFunc =
                  (_ModuleDefinitionSetDeprecated)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionSetDeprecated"), typeof(_ModuleDefinitionSetDeprecated));
            }

            _ModuleDefinitionSetDeprecatedFunc(moduleDefinition, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleDefinitionGetCriticalMerge(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetCriticalMerge _ModuleDefinitionGetCriticalMergeFunc;
         internal static bool ModuleDefinitionGetCriticalMerge(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetCriticalMergeFunc == null)
            {
               _ModuleDefinitionGetCriticalMergeFunc =
                  (_ModuleDefinitionGetCriticalMerge)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetCriticalMerge"), typeof(_ModuleDefinitionGetCriticalMerge));
            }

            return _ModuleDefinitionGetCriticalMergeFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleDefinitionSetCriticalMerge(IntPtr moduleDefinition, bool value);
         private static _ModuleDefinitionSetCriticalMerge _ModuleDefinitionSetCriticalMergeFunc;
         internal static void ModuleDefinitionSetCriticalMerge(IntPtr moduleDefinition, bool value)
         {
            if (_ModuleDefinitionSetCriticalMergeFunc == null)
            {
               _ModuleDefinitionSetCriticalMergeFunc =
                  (_ModuleDefinitionSetCriticalMerge)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionSetCriticalMerge"), typeof(_ModuleDefinitionSetCriticalMerge));
            }

            _ModuleDefinitionSetCriticalMergeFunc(moduleDefinition, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleDefinitionGetDescription(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetDescription _ModuleDefinitionGetDescriptionFunc;
         internal static IntPtr ModuleDefinitionGetDescription(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetDescriptionFunc == null)
            {
               _ModuleDefinitionGetDescriptionFunc =
                  (_ModuleDefinitionGetDescription)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetDescription"), typeof(_ModuleDefinitionGetDescription));
            }

            return _ModuleDefinitionGetDescriptionFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleDefinitionSetDescription(IntPtr moduleDefinition, string value);
         private static _ModuleDefinitionSetDescription _ModuleDefinitionSetDescriptionFunc;
         internal static void ModuleDefinitionSetDescription(IntPtr moduleDefinition, string value)
         {
            if (_ModuleDefinitionSetDescriptionFunc == null)
            {
               _ModuleDefinitionSetDescriptionFunc =
                  (_ModuleDefinitionSetDescription)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionSetDescription"), typeof(_ModuleDefinitionSetDescription));
            }

            _ModuleDefinitionSetDescriptionFunc(moduleDefinition, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleDefinitionGetAuthor(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetAuthor _ModuleDefinitionGetAuthorFunc;
         internal static IntPtr ModuleDefinitionGetAuthor(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetAuthorFunc == null)
            {
               _ModuleDefinitionGetAuthorFunc =
                  (_ModuleDefinitionGetAuthor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetAuthor"), typeof(_ModuleDefinitionGetAuthor));
            }

            return _ModuleDefinitionGetAuthorFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleDefinitionSetAuthor(IntPtr moduleDefinition, string value);
         private static _ModuleDefinitionSetAuthor _ModuleDefinitionSetAuthorFunc;
         internal static void ModuleDefinitionSetAuthor(IntPtr moduleDefinition, string value)
         {
            if (_ModuleDefinitionSetAuthorFunc == null)
            {
               _ModuleDefinitionSetAuthorFunc =
                  (_ModuleDefinitionSetAuthor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionSetAuthor"), typeof(_ModuleDefinitionSetAuthor));
            }

            _ModuleDefinitionSetAuthorFunc(moduleDefinition, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleDefinitionGetGroup(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetGroup _ModuleDefinitionGetGroupFunc;
         internal static IntPtr ModuleDefinitionGetGroup(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetGroupFunc == null)
            {
               _ModuleDefinitionGetGroupFunc =
                  (_ModuleDefinitionGetGroup)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetGroup"), typeof(_ModuleDefinitionGetGroup));
            }

            return _ModuleDefinitionGetGroupFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleDefinitionSetGroup(IntPtr moduleDefinition, string value);
         private static _ModuleDefinitionSetGroup _ModuleDefinitionSetGroupFunc;
         internal static void ModuleDefinitionSetGroup(IntPtr moduleDefinition, string value)
         {
            if (_ModuleDefinitionSetGroupFunc == null)
            {
               _ModuleDefinitionSetGroupFunc =
                  (_ModuleDefinitionSetGroup)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionSetGroup"), typeof(_ModuleDefinitionSetGroup));
            }

            _ModuleDefinitionSetGroupFunc(moduleDefinition, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleDefinitionGetType(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetType _ModuleDefinitionGetTypeFunc;
         internal static IntPtr ModuleDefinitionGetType(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetTypeFunc == null)
            {
               _ModuleDefinitionGetTypeFunc =
                  (_ModuleDefinitionGetType)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetType"), typeof(_ModuleDefinitionGetType));
            }

            return _ModuleDefinitionGetTypeFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleDefinitionSetType(IntPtr moduleDefinition, string value);
         private static _ModuleDefinitionSetType _ModuleDefinitionSetTypeFunc;
         internal static void ModuleDefinitionSetType(IntPtr moduleDefinition, string value)
         {
            if (_ModuleDefinitionSetTypeFunc == null)
            {
               _ModuleDefinitionSetTypeFunc =
                  (_ModuleDefinitionSetType)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionSetType"), typeof(_ModuleDefinitionSetType));
            }

            _ModuleDefinitionSetTypeFunc(moduleDefinition, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleDefinitionGetDependencies(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetDependencies _ModuleDefinitionGetDependenciesFunc;
         internal static IntPtr ModuleDefinitionGetDependencies(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetDependenciesFunc == null)
            {
               _ModuleDefinitionGetDependenciesFunc =
                  (_ModuleDefinitionGetDependencies)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetDependencies"), typeof(_ModuleDefinitionGetDependencies));
            }

            return _ModuleDefinitionGetDependenciesFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleDefinitionSetDependencies(IntPtr moduleDefinition, string value);
         private static _ModuleDefinitionSetDependencies _ModuleDefinitionSetDependenciesFunc;
         internal static void ModuleDefinitionSetDependencies(IntPtr moduleDefinition, string value)
         {
            if (_ModuleDefinitionSetDependenciesFunc == null)
            {
               _ModuleDefinitionSetDependenciesFunc =
                  (_ModuleDefinitionSetDependencies)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionSetDependencies"), typeof(_ModuleDefinitionSetDependencies));
            }

            _ModuleDefinitionSetDependenciesFunc(moduleDefinition, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleDefinitionGetScriptFile(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetScriptFile _ModuleDefinitionGetScriptFileFunc;
         internal static IntPtr ModuleDefinitionGetScriptFile(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetScriptFileFunc == null)
            {
               _ModuleDefinitionGetScriptFileFunc =
                  (_ModuleDefinitionGetScriptFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetScriptFile"), typeof(_ModuleDefinitionGetScriptFile));
            }

            return _ModuleDefinitionGetScriptFileFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleDefinitionSetScriptFile(IntPtr moduleDefinition, string value);
         private static _ModuleDefinitionSetScriptFile _ModuleDefinitionSetScriptFileFunc;
         internal static void ModuleDefinitionSetScriptFile(IntPtr moduleDefinition, string value)
         {
            if (_ModuleDefinitionSetScriptFileFunc == null)
            {
               _ModuleDefinitionSetScriptFileFunc =
                  (_ModuleDefinitionSetScriptFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionSetScriptFile"), typeof(_ModuleDefinitionSetScriptFile));
            }

            _ModuleDefinitionSetScriptFileFunc(moduleDefinition, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleDefinitionGetCreateFunction(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetCreateFunction _ModuleDefinitionGetCreateFunctionFunc;
         internal static IntPtr ModuleDefinitionGetCreateFunction(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetCreateFunctionFunc == null)
            {
               _ModuleDefinitionGetCreateFunctionFunc =
                  (_ModuleDefinitionGetCreateFunction)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetCreateFunction"), typeof(_ModuleDefinitionGetCreateFunction));
            }

            return _ModuleDefinitionGetCreateFunctionFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleDefinitionSetCreateFunction(IntPtr moduleDefinition, string value);
         private static _ModuleDefinitionSetCreateFunction _ModuleDefinitionSetCreateFunctionFunc;
         internal static void ModuleDefinitionSetCreateFunction(IntPtr moduleDefinition, string value)
         {
            if (_ModuleDefinitionSetCreateFunctionFunc == null)
            {
               _ModuleDefinitionSetCreateFunctionFunc =
                  (_ModuleDefinitionSetCreateFunction)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionSetCreateFunction"), typeof(_ModuleDefinitionSetCreateFunction));
            }

            _ModuleDefinitionSetCreateFunctionFunc(moduleDefinition, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleDefinitionGetDestroyFunction(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetDestroyFunction _ModuleDefinitionGetDestroyFunctionFunc;
         internal static IntPtr ModuleDefinitionGetDestroyFunction(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetDestroyFunctionFunc == null)
            {
               _ModuleDefinitionGetDestroyFunctionFunc =
                  (_ModuleDefinitionGetDestroyFunction)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetDestroyFunction"), typeof(_ModuleDefinitionGetDestroyFunction));
            }

            return _ModuleDefinitionGetDestroyFunctionFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleDefinitionSetDestroyFunction(IntPtr moduleDefinition, string value);
         private static _ModuleDefinitionSetDestroyFunction _ModuleDefinitionSetDestroyFunctionFunc;
         internal static void ModuleDefinitionSetDestroyFunction(IntPtr moduleDefinition, string value)
         {
            if (_ModuleDefinitionSetDestroyFunctionFunc == null)
            {
               _ModuleDefinitionSetDestroyFunctionFunc =
                  (_ModuleDefinitionSetDestroyFunction)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionSetDestroyFunction"), typeof(_ModuleDefinitionSetDestroyFunction));
            }

            _ModuleDefinitionSetDestroyFunctionFunc(moduleDefinition, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleDefinitionGetAssetTagsManifest(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetAssetTagsManifest _ModuleDefinitionGetAssetTagsManifestFunc;
         internal static IntPtr ModuleDefinitionGetAssetTagsManifest(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetAssetTagsManifestFunc == null)
            {
               _ModuleDefinitionGetAssetTagsManifestFunc =
                  (_ModuleDefinitionGetAssetTagsManifest)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetAssetTagsManifest"), typeof(_ModuleDefinitionGetAssetTagsManifest));
            }

            return _ModuleDefinitionGetAssetTagsManifestFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleDefinitionSetAssetTagsManifest(IntPtr moduleDefinition, string value);
         private static _ModuleDefinitionSetAssetTagsManifest _ModuleDefinitionSetAssetTagsManifestFunc;
         internal static void ModuleDefinitionSetAssetTagsManifest(IntPtr moduleDefinition, string value)
         {
            if (_ModuleDefinitionSetAssetTagsManifestFunc == null)
            {
               _ModuleDefinitionSetAssetTagsManifestFunc =
                  (_ModuleDefinitionSetAssetTagsManifest)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionSetAssetTagsManifest"), typeof(_ModuleDefinitionSetAssetTagsManifest));
            }

            _ModuleDefinitionSetAssetTagsManifestFunc(moduleDefinition, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ModuleDefinitionGetScopeSet(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetScopeSet _ModuleDefinitionGetScopeSetFunc;
         internal static int ModuleDefinitionGetScopeSet(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetScopeSetFunc == null)
            {
               _ModuleDefinitionGetScopeSetFunc =
                  (_ModuleDefinitionGetScopeSet)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetScopeSet"), typeof(_ModuleDefinitionGetScopeSet));
            }

            return _ModuleDefinitionGetScopeSetFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleDefinitionGetModulePath(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetModulePath _ModuleDefinitionGetModulePathFunc;
         internal static IntPtr ModuleDefinitionGetModulePath(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetModulePathFunc == null)
            {
               _ModuleDefinitionGetModulePathFunc =
                  (_ModuleDefinitionGetModulePath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetModulePath"), typeof(_ModuleDefinitionGetModulePath));
            }

            return _ModuleDefinitionGetModulePathFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleDefinitionGetModuleFile(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetModuleFile _ModuleDefinitionGetModuleFileFunc;
         internal static IntPtr ModuleDefinitionGetModuleFile(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetModuleFileFunc == null)
            {
               _ModuleDefinitionGetModuleFileFunc =
                  (_ModuleDefinitionGetModuleFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetModuleFile"), typeof(_ModuleDefinitionGetModuleFile));
            }

            return _ModuleDefinitionGetModuleFileFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleDefinitionGetModuleFilePath(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetModuleFilePath _ModuleDefinitionGetModuleFilePathFunc;
         internal static IntPtr ModuleDefinitionGetModuleFilePath(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetModuleFilePathFunc == null)
            {
               _ModuleDefinitionGetModuleFilePathFunc =
                  (_ModuleDefinitionGetModuleFilePath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetModuleFilePath"), typeof(_ModuleDefinitionGetModuleFilePath));
            }

            return _ModuleDefinitionGetModuleFilePathFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleDefinitionGetModuleScriptFilePath(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetModuleScriptFilePath _ModuleDefinitionGetModuleScriptFilePathFunc;
         internal static IntPtr ModuleDefinitionGetModuleScriptFilePath(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetModuleScriptFilePathFunc == null)
            {
               _ModuleDefinitionGetModuleScriptFilePathFunc =
                  (_ModuleDefinitionGetModuleScriptFilePath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetModuleScriptFilePath"), typeof(_ModuleDefinitionGetModuleScriptFilePath));
            }

            return _ModuleDefinitionGetModuleScriptFilePathFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleDefinitionCreateInstance();
         private static _ModuleDefinitionCreateInstance _ModuleDefinitionCreateInstanceFunc;
         internal static IntPtr ModuleDefinitionCreateInstance()
         {
            if (_ModuleDefinitionCreateInstanceFunc == null)
            {
               _ModuleDefinitionCreateInstanceFunc =
                  (_ModuleDefinitionCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionCreateInstance"), typeof(_ModuleDefinitionCreateInstance));
            }

            return _ModuleDefinitionCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleDefinitionGetSignature(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetSignature _ModuleDefinitionGetSignatureFunc;
         internal static IntPtr ModuleDefinitionGetSignature(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetSignatureFunc == null)
            {
               _ModuleDefinitionGetSignatureFunc =
                  (_ModuleDefinitionGetSignature)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetSignature"), typeof(_ModuleDefinitionGetSignature));
            }

            return _ModuleDefinitionGetSignatureFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleDefinitionSave(IntPtr moduleDefinition);
         private static _ModuleDefinitionSave _ModuleDefinitionSaveFunc;
         internal static bool ModuleDefinitionSave(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionSaveFunc == null)
            {
               _ModuleDefinitionSaveFunc =
                  (_ModuleDefinitionSave)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionSave"), typeof(_ModuleDefinitionSave));
            }

            return _ModuleDefinitionSaveFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleDefinitionGetModuleManager(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetModuleManager _ModuleDefinitionGetModuleManagerFunc;
         internal static IntPtr ModuleDefinitionGetModuleManager(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetModuleManagerFunc == null)
            {
               _ModuleDefinitionGetModuleManagerFunc =
                  (_ModuleDefinitionGetModuleManager)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetModuleManager"), typeof(_ModuleDefinitionGetModuleManager));
            }

            return _ModuleDefinitionGetModuleManagerFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ModuleDefinitionGetDependencyCount(IntPtr moduleDefinition);
         private static _ModuleDefinitionGetDependencyCount _ModuleDefinitionGetDependencyCountFunc;
         internal static int ModuleDefinitionGetDependencyCount(IntPtr moduleDefinition)
         {
            if (_ModuleDefinitionGetDependencyCountFunc == null)
            {
               _ModuleDefinitionGetDependencyCountFunc =
                  (_ModuleDefinitionGetDependencyCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetDependencyCount"), typeof(_ModuleDefinitionGetDependencyCount));
            }

            return _ModuleDefinitionGetDependencyCountFunc(moduleDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleDefinitionGetDependency(IntPtr moduleDefinition, int dependencyIndex);
         private static _ModuleDefinitionGetDependency _ModuleDefinitionGetDependencyFunc;
         internal static IntPtr ModuleDefinitionGetDependency(IntPtr moduleDefinition, int dependencyIndex)
         {
            if (_ModuleDefinitionGetDependencyFunc == null)
            {
               _ModuleDefinitionGetDependencyFunc =
                  (_ModuleDefinitionGetDependency)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionGetDependency"), typeof(_ModuleDefinitionGetDependency));
            }

            return _ModuleDefinitionGetDependencyFunc(moduleDefinition, dependencyIndex);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleDefinitionAddDependency(IntPtr moduleDefinition, string moduleId, int versionId);
         private static _ModuleDefinitionAddDependency _ModuleDefinitionAddDependencyFunc;
         internal static bool ModuleDefinitionAddDependency(IntPtr moduleDefinition, string moduleId, int versionId)
         {
            if (_ModuleDefinitionAddDependencyFunc == null)
            {
               _ModuleDefinitionAddDependencyFunc =
                  (_ModuleDefinitionAddDependency)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionAddDependency"), typeof(_ModuleDefinitionAddDependency));
            }

            return _ModuleDefinitionAddDependencyFunc(moduleDefinition, moduleId, versionId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleDefinitionRemoveDependency(IntPtr moduleDefinition, string moduleId);
         private static _ModuleDefinitionRemoveDependency _ModuleDefinitionRemoveDependencyFunc;
         internal static bool ModuleDefinitionRemoveDependency(IntPtr moduleDefinition, string moduleId)
         {
            if (_ModuleDefinitionRemoveDependencyFunc == null)
            {
               _ModuleDefinitionRemoveDependencyFunc =
                  (_ModuleDefinitionRemoveDependency)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleDefinitionRemoveDependency"), typeof(_ModuleDefinitionRemoveDependency));
            }

            return _ModuleDefinitionRemoveDependencyFunc(moduleDefinition, moduleId);
         }
      }
      
      #endregion

      #region Properties

      public string ModuleId
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ModuleDefinitionGetModuleId(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ModuleDefinitionSetModuleId(ObjectPtr->ObjPtr, value);
         }
      }
      public int VersionId
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ModuleDefinitionGetVersionId(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ModuleDefinitionSetVersionId(ObjectPtr->ObjPtr, value);
         }
      }
      public int BuildId
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ModuleDefinitionGetBuildId(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ModuleDefinitionSetBuildId(ObjectPtr->ObjPtr, value);
         }
      }
      public bool Enabled
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ModuleDefinitionGetEnabled(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ModuleDefinitionSetEnabled(ObjectPtr->ObjPtr, value);
         }
      }
      public bool Synchronized
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ModuleDefinitionGetSynchronized(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ModuleDefinitionSetSynchronized(ObjectPtr->ObjPtr, value);
         }
      }
      public bool Deprecated
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ModuleDefinitionGetDeprecated(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ModuleDefinitionSetDeprecated(ObjectPtr->ObjPtr, value);
         }
      }
      public bool CriticalMerge
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ModuleDefinitionGetCriticalMerge(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ModuleDefinitionSetCriticalMerge(ObjectPtr->ObjPtr, value);
         }
      }
      public string Description
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ModuleDefinitionGetDescription(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ModuleDefinitionSetDescription(ObjectPtr->ObjPtr, value);
         }
      }
      public string Author
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ModuleDefinitionGetAuthor(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ModuleDefinitionSetAuthor(ObjectPtr->ObjPtr, value);
         }
      }
      public string Group
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ModuleDefinitionGetGroup(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ModuleDefinitionSetGroup(ObjectPtr->ObjPtr, value);
         }
      }
      public string Type
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ModuleDefinitionGetType(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ModuleDefinitionSetType(ObjectPtr->ObjPtr, value);
         }
      }
      public string Dependencies
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ModuleDefinitionGetDependencies(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ModuleDefinitionSetDependencies(ObjectPtr->ObjPtr, value);
         }
      }
      public string ScriptFile
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ModuleDefinitionGetScriptFile(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ModuleDefinitionSetScriptFile(ObjectPtr->ObjPtr, value);
         }
      }
      public string CreateFunction
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ModuleDefinitionGetCreateFunction(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ModuleDefinitionSetCreateFunction(ObjectPtr->ObjPtr, value);
         }
      }
      public string DestroyFunction
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ModuleDefinitionGetDestroyFunction(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ModuleDefinitionSetDestroyFunction(ObjectPtr->ObjPtr, value);
         }
      }
      public string AssetTagsManifest
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ModuleDefinitionGetAssetTagsManifest(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ModuleDefinitionSetAssetTagsManifest(ObjectPtr->ObjPtr, value);
         }
      }
      public int ScopeSet
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ModuleDefinitionGetScopeSet(ObjectPtr->ObjPtr);
         }

      }
      public string ModulePath
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ModuleDefinitionGetModulePath(ObjectPtr->ObjPtr));
         }

      }
      public string ModuleFile
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ModuleDefinitionGetModuleFile(ObjectPtr->ObjPtr));
         }

      }
      public string ModuleFilePath
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ModuleDefinitionGetModuleFilePath(ObjectPtr->ObjPtr));
         }

      }
      public string ModuleScriptFilePath
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ModuleDefinitionGetModuleScriptFilePath(ObjectPtr->ObjPtr));
         }

      }
      
      #endregion
      
      #region Methods

      public string GetSignature()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ModuleDefinitionGetSignature(ObjectPtr->ObjPtr));
      }

      public bool Save()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ModuleDefinitionSave(ObjectPtr->ObjPtr);
      }

      public ModuleManager GetModuleManager()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new ModuleManager(InternalUnsafeMethods.ModuleDefinitionGetModuleManager(ObjectPtr->ObjPtr));
      }

      public int GetDependencyCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ModuleDefinitionGetDependencyCount(ObjectPtr->ObjPtr);
      }

      public string GetDependency(int dependencyIndex)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ModuleDefinitionGetDependency(ObjectPtr->ObjPtr, dependencyIndex));
      }

      public bool AddDependency(string moduleId, int versionId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ModuleDefinitionAddDependency(ObjectPtr->ObjPtr, moduleId, versionId);
      }

      public bool RemoveDependency(string moduleId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ModuleDefinitionRemoveDependency(ObjectPtr->ObjPtr, moduleId);
      }
      
      #endregion

      
   }
}