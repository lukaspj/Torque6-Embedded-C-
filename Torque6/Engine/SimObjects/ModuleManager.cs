using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class ModuleManager : SimObject
   {
      
      public ModuleManager()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.ModuleManagerCreateInstance());
      }

      public ModuleManager(uint pId) : base(pId)
      {
      }

      public ModuleManager(string pName) : base(pName)
      {
      }

      public ModuleManager(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public ModuleManager(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public ModuleManager(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleManagerGetEnforceDependencies(IntPtr moduleManager);
         private static _ModuleManagerGetEnforceDependencies _ModuleManagerGetEnforceDependenciesFunc;
         internal static bool ModuleManagerGetEnforceDependencies(IntPtr moduleManager)
         {
            if (_ModuleManagerGetEnforceDependenciesFunc == null)
            {
               _ModuleManagerGetEnforceDependenciesFunc =
                  (_ModuleManagerGetEnforceDependencies)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerGetEnforceDependencies"), typeof(_ModuleManagerGetEnforceDependencies));
            }

            return _ModuleManagerGetEnforceDependenciesFunc(moduleManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleManagerSetEnforceDependencies(IntPtr moduleManager, bool value);
         private static _ModuleManagerSetEnforceDependencies _ModuleManagerSetEnforceDependenciesFunc;
         internal static void ModuleManagerSetEnforceDependencies(IntPtr moduleManager, bool value)
         {
            if (_ModuleManagerSetEnforceDependenciesFunc == null)
            {
               _ModuleManagerSetEnforceDependenciesFunc =
                  (_ModuleManagerSetEnforceDependencies)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerSetEnforceDependencies"), typeof(_ModuleManagerSetEnforceDependencies));
            }

            _ModuleManagerSetEnforceDependenciesFunc(moduleManager, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleManagerGetEchoInfo(IntPtr moduleManager);
         private static _ModuleManagerGetEchoInfo _ModuleManagerGetEchoInfoFunc;
         internal static bool ModuleManagerGetEchoInfo(IntPtr moduleManager)
         {
            if (_ModuleManagerGetEchoInfoFunc == null)
            {
               _ModuleManagerGetEchoInfoFunc =
                  (_ModuleManagerGetEchoInfo)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerGetEchoInfo"), typeof(_ModuleManagerGetEchoInfo));
            }

            return _ModuleManagerGetEchoInfoFunc(moduleManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleManagerSetEchoInfo(IntPtr moduleManager, bool value);
         private static _ModuleManagerSetEchoInfo _ModuleManagerSetEchoInfoFunc;
         internal static void ModuleManagerSetEchoInfo(IntPtr moduleManager, bool value)
         {
            if (_ModuleManagerSetEchoInfoFunc == null)
            {
               _ModuleManagerSetEchoInfoFunc =
                  (_ModuleManagerSetEchoInfo)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerSetEchoInfo"), typeof(_ModuleManagerSetEchoInfo));
            }

            _ModuleManagerSetEchoInfoFunc(moduleManager, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleManagerCreateInstance();
         private static _ModuleManagerCreateInstance _ModuleManagerCreateInstanceFunc;
         internal static IntPtr ModuleManagerCreateInstance()
         {
            if (_ModuleManagerCreateInstanceFunc == null)
            {
               _ModuleManagerCreateInstanceFunc =
                  (_ModuleManagerCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerCreateInstance"), typeof(_ModuleManagerCreateInstance));
            }

            return _ModuleManagerCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleManagerSetModuleExtension(IntPtr moduleManager, string moduleExtension);
         private static _ModuleManagerSetModuleExtension _ModuleManagerSetModuleExtensionFunc;
         internal static bool ModuleManagerSetModuleExtension(IntPtr moduleManager, string moduleExtension)
         {
            if (_ModuleManagerSetModuleExtensionFunc == null)
            {
               _ModuleManagerSetModuleExtensionFunc =
                  (_ModuleManagerSetModuleExtension)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerSetModuleExtension"), typeof(_ModuleManagerSetModuleExtension));
            }

            return _ModuleManagerSetModuleExtensionFunc(moduleManager, moduleExtension);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleManagerScanModules(IntPtr moduleManager, string rootPath, bool rootOnly);
         private static _ModuleManagerScanModules _ModuleManagerScanModulesFunc;
         internal static bool ModuleManagerScanModules(IntPtr moduleManager, string rootPath, bool rootOnly)
         {
            if (_ModuleManagerScanModulesFunc == null)
            {
               _ModuleManagerScanModulesFunc =
                  (_ModuleManagerScanModules)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerScanModules"), typeof(_ModuleManagerScanModules));
            }

            return _ModuleManagerScanModulesFunc(moduleManager, rootPath, rootOnly);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleManagerUnregisterModule(IntPtr moduleManager, string moduleId, uint versionId);
         private static _ModuleManagerUnregisterModule _ModuleManagerUnregisterModuleFunc;
         internal static bool ModuleManagerUnregisterModule(IntPtr moduleManager, string moduleId, uint versionId)
         {
            if (_ModuleManagerUnregisterModuleFunc == null)
            {
               _ModuleManagerUnregisterModuleFunc =
                  (_ModuleManagerUnregisterModule)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerUnregisterModule"), typeof(_ModuleManagerUnregisterModule));
            }

            return _ModuleManagerUnregisterModuleFunc(moduleManager, moduleId, versionId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleManagerLoadGroup(IntPtr moduleManager, string moduleGroup);
         private static _ModuleManagerLoadGroup _ModuleManagerLoadGroupFunc;
         internal static bool ModuleManagerLoadGroup(IntPtr moduleManager, string moduleGroup)
         {
            if (_ModuleManagerLoadGroupFunc == null)
            {
               _ModuleManagerLoadGroupFunc =
                  (_ModuleManagerLoadGroup)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerLoadGroup"), typeof(_ModuleManagerLoadGroup));
            }

            return _ModuleManagerLoadGroupFunc(moduleManager, moduleGroup);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleManagerUnloadGroup(IntPtr moduleManager, string moduleGroup);
         private static _ModuleManagerUnloadGroup _ModuleManagerUnloadGroupFunc;
         internal static bool ModuleManagerUnloadGroup(IntPtr moduleManager, string moduleGroup)
         {
            if (_ModuleManagerUnloadGroupFunc == null)
            {
               _ModuleManagerUnloadGroupFunc =
                  (_ModuleManagerUnloadGroup)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerUnloadGroup"), typeof(_ModuleManagerUnloadGroup));
            }

            return _ModuleManagerUnloadGroupFunc(moduleManager, moduleGroup);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleManagerLoadExplicit(IntPtr moduleManager, string moduleId, uint versionId);
         private static _ModuleManagerLoadExplicit _ModuleManagerLoadExplicitFunc;
         internal static bool ModuleManagerLoadExplicit(IntPtr moduleManager, string moduleId, uint versionId)
         {
            if (_ModuleManagerLoadExplicitFunc == null)
            {
               _ModuleManagerLoadExplicitFunc =
                  (_ModuleManagerLoadExplicit)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerLoadExplicit"), typeof(_ModuleManagerLoadExplicit));
            }

            return _ModuleManagerLoadExplicitFunc(moduleManager, moduleId, versionId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleManagerUnloadExplicit(IntPtr moduleManager, string moduleId);
         private static _ModuleManagerUnloadExplicit _ModuleManagerUnloadExplicitFunc;
         internal static bool ModuleManagerUnloadExplicit(IntPtr moduleManager, string moduleId)
         {
            if (_ModuleManagerUnloadExplicitFunc == null)
            {
               _ModuleManagerUnloadExplicitFunc =
                  (_ModuleManagerUnloadExplicit)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerUnloadExplicit"), typeof(_ModuleManagerUnloadExplicit));
            }

            return _ModuleManagerUnloadExplicitFunc(moduleManager, moduleId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleManagerFindModule(IntPtr moduleManager, string moduleId, uint versionId);
         private static _ModuleManagerFindModule _ModuleManagerFindModuleFunc;
         internal static IntPtr ModuleManagerFindModule(IntPtr moduleManager, string moduleId, uint versionId)
         {
            if (_ModuleManagerFindModuleFunc == null)
            {
               _ModuleManagerFindModuleFunc =
                  (_ModuleManagerFindModule)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerFindModule"), typeof(_ModuleManagerFindModule));
            }

            return _ModuleManagerFindModuleFunc(moduleManager, moduleId, versionId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr[] _ModuleManagerFindModules(IntPtr moduleManager, bool loadedOnly);
         private static _ModuleManagerFindModules _ModuleManagerFindModulesFunc;
         internal static IntPtr[] ModuleManagerFindModules(IntPtr moduleManager, bool loadedOnly)
         {
            if (_ModuleManagerFindModulesFunc == null)
            {
               _ModuleManagerFindModulesFunc =
                  (_ModuleManagerFindModules)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerFindModules"), typeof(_ModuleManagerFindModules));
            }

            return _ModuleManagerFindModulesFunc(moduleManager, loadedOnly);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr[] _ModuleManagerFindModuleTypes(IntPtr moduleManager, string moduleType, bool loadedOnly);
         private static _ModuleManagerFindModuleTypes _ModuleManagerFindModuleTypesFunc;
         internal static IntPtr[] ModuleManagerFindModuleTypes(IntPtr moduleManager, string moduleType, bool loadedOnly)
         {
            if (_ModuleManagerFindModuleTypesFunc == null)
            {
               _ModuleManagerFindModuleTypesFunc =
                  (_ModuleManagerFindModuleTypes)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerFindModuleTypes"), typeof(_ModuleManagerFindModuleTypes));
            }

            return _ModuleManagerFindModuleTypesFunc(moduleManager, moduleType, loadedOnly);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleManagerCopyModule(IntPtr moduleManager, IntPtr sourceModuleDefinition, string targetModuleId, string targetPath, bool useVersionPathing);
         private static _ModuleManagerCopyModule _ModuleManagerCopyModuleFunc;
         internal static IntPtr ModuleManagerCopyModule(IntPtr moduleManager, IntPtr sourceModuleDefinition, string targetModuleId, string targetPath, bool useVersionPathing)
         {
            if (_ModuleManagerCopyModuleFunc == null)
            {
               _ModuleManagerCopyModuleFunc =
                  (_ModuleManagerCopyModule)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerCopyModule"), typeof(_ModuleManagerCopyModule));
            }

            return _ModuleManagerCopyModuleFunc(moduleManager, sourceModuleDefinition, targetModuleId, targetPath, useVersionPathing);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleManagerSynchronizeDependencies(IntPtr moduleManager, IntPtr rootModuleDefinition, string targetDependencyFolder);
         private static _ModuleManagerSynchronizeDependencies _ModuleManagerSynchronizeDependenciesFunc;
         internal static bool ModuleManagerSynchronizeDependencies(IntPtr moduleManager, IntPtr rootModuleDefinition, string targetDependencyFolder)
         {
            if (_ModuleManagerSynchronizeDependenciesFunc == null)
            {
               _ModuleManagerSynchronizeDependenciesFunc =
                  (_ModuleManagerSynchronizeDependencies)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerSynchronizeDependencies"), typeof(_ModuleManagerSynchronizeDependencies));
            }

            return _ModuleManagerSynchronizeDependenciesFunc(moduleManager, rootModuleDefinition, targetDependencyFolder);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleManagerIsModuleMergeAvailable(IntPtr moduleManager);
         private static _ModuleManagerIsModuleMergeAvailable _ModuleManagerIsModuleMergeAvailableFunc;
         internal static bool ModuleManagerIsModuleMergeAvailable(IntPtr moduleManager)
         {
            if (_ModuleManagerIsModuleMergeAvailableFunc == null)
            {
               _ModuleManagerIsModuleMergeAvailableFunc =
                  (_ModuleManagerIsModuleMergeAvailable)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerIsModuleMergeAvailable"), typeof(_ModuleManagerIsModuleMergeAvailable));
            }

            return _ModuleManagerIsModuleMergeAvailableFunc(moduleManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleManagerCanMergeModules(IntPtr moduleManager, string mergeSourcePath);
         private static _ModuleManagerCanMergeModules _ModuleManagerCanMergeModulesFunc;
         internal static bool ModuleManagerCanMergeModules(IntPtr moduleManager, string mergeSourcePath)
         {
            if (_ModuleManagerCanMergeModulesFunc == null)
            {
               _ModuleManagerCanMergeModulesFunc =
                  (_ModuleManagerCanMergeModules)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerCanMergeModules"), typeof(_ModuleManagerCanMergeModules));
            }

            return _ModuleManagerCanMergeModulesFunc(moduleManager, mergeSourcePath);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ModuleManagerMergeModules(IntPtr moduleManager, string mergeTargetPath, bool removeMergeDefinition, bool registerNewModules);
         private static _ModuleManagerMergeModules _ModuleManagerMergeModulesFunc;
         internal static bool ModuleManagerMergeModules(IntPtr moduleManager, string mergeTargetPath, bool removeMergeDefinition, bool registerNewModules)
         {
            if (_ModuleManagerMergeModulesFunc == null)
            {
               _ModuleManagerMergeModulesFunc =
                  (_ModuleManagerMergeModules)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerMergeModules"), typeof(_ModuleManagerMergeModules));
            }

            return _ModuleManagerMergeModulesFunc(moduleManager, mergeTargetPath, removeMergeDefinition, registerNewModules);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleManagerAddListener(IntPtr moduleManager, IntPtr listenerObject);
         private static _ModuleManagerAddListener _ModuleManagerAddListenerFunc;
         internal static void ModuleManagerAddListener(IntPtr moduleManager, IntPtr listenerObject)
         {
            if (_ModuleManagerAddListenerFunc == null)
            {
               _ModuleManagerAddListenerFunc =
                  (_ModuleManagerAddListener)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerAddListener"), typeof(_ModuleManagerAddListener));
            }

            _ModuleManagerAddListenerFunc(moduleManager, listenerObject);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleManagerRemoveListener(IntPtr moduleManager, IntPtr listenerObject);
         private static _ModuleManagerRemoveListener _ModuleManagerRemoveListenerFunc;
         internal static void ModuleManagerRemoveListener(IntPtr moduleManager, IntPtr listenerObject)
         {
            if (_ModuleManagerRemoveListenerFunc == null)
            {
               _ModuleManagerRemoveListenerFunc =
                  (_ModuleManagerRemoveListener)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleManagerRemoveListener"), typeof(_ModuleManagerRemoveListener));
            }

            _ModuleManagerRemoveListenerFunc(moduleManager, listenerObject);
         }
      }
      
      #endregion

      #region Properties

      public bool EnforceDependencies
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ModuleManagerGetEnforceDependencies(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ModuleManagerSetEnforceDependencies(ObjectPtr->ObjPtr, value);
         }
      }
      public bool EchoInfo
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ModuleManagerGetEchoInfo(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ModuleManagerSetEchoInfo(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public bool SetModuleExtension(string moduleExtension)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ModuleManagerSetModuleExtension(ObjectPtr->ObjPtr, moduleExtension);
      }

      public bool ScanModules(string rootPath, bool rootOnly = false)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ModuleManagerScanModules(ObjectPtr->ObjPtr, rootPath, rootOnly);
      }

      public bool UnregisterModule(string moduleId, uint versionId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ModuleManagerUnregisterModule(ObjectPtr->ObjPtr, moduleId, versionId);
      }

      public bool LoadGroup(string moduleGroup)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ModuleManagerLoadGroup(ObjectPtr->ObjPtr, moduleGroup);
      }

      public bool UnloadGroup(string moduleGroup)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ModuleManagerUnloadGroup(ObjectPtr->ObjPtr, moduleGroup);
      }

      public bool LoadExplicit(string moduleId, uint versionId = 0)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ModuleManagerLoadExplicit(ObjectPtr->ObjPtr, moduleId, versionId);
      }

      public bool UnloadExplicit(string moduleId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ModuleManagerUnloadExplicit(ObjectPtr->ObjPtr, moduleId);
      }

      public ModuleDefinition FindModule(string moduleId, uint versionId)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new ModuleDefinition(InternalUnsafeMethods.ModuleManagerFindModule(ObjectPtr->ObjPtr, moduleId, versionId));
      }

      public SimObject[] FindModules(bool loadedOnly)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ModuleManagerFindModules(ObjectPtr->ObjPtr, loadedOnly).Select(x => new SimObject(x)).ToArray();
      }

      public SimObject[] FindModuleTypes(string moduleType, bool loadedOnly)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ModuleManagerFindModuleTypes(ObjectPtr->ObjPtr, moduleType, loadedOnly).Select(x => new SimObject(x)).ToArray();
      }

      public string CopyModule(ModuleDefinition sourceModuleDefinition, string targetModuleId, string targetPath, bool useVersionPathing)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ModuleManagerCopyModule(ObjectPtr->ObjPtr, sourceModuleDefinition.ObjectPtr->ObjPtr, targetModuleId, targetPath, useVersionPathing));
      }

      public bool SynchronizeDependencies(ModuleDefinition rootModuleDefinition, string targetDependencyFolder)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ModuleManagerSynchronizeDependencies(ObjectPtr->ObjPtr, rootModuleDefinition.ObjectPtr->ObjPtr, targetDependencyFolder);
      }

      public bool IsModuleMergeAvailable()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ModuleManagerIsModuleMergeAvailable(ObjectPtr->ObjPtr);
      }

      public bool CanMergeModules(string mergeSourcePath)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ModuleManagerCanMergeModules(ObjectPtr->ObjPtr, mergeSourcePath);
      }

      public bool MergeModules(string mergeTargetPath, bool removeMergeDefinition, bool registerNewModules)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ModuleManagerMergeModules(ObjectPtr->ObjPtr, mergeTargetPath, removeMergeDefinition, registerNewModules);
      }

      public void AddListener(SimObject listenerObject)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.ModuleManagerAddListener(ObjectPtr->ObjPtr, listenerObject.ObjectPtr->ObjPtr);
      }

      public void RemoveListener(SimObject listenerObject)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.ModuleManagerRemoveListener(ObjectPtr->ObjPtr, listenerObject.ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}