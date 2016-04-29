using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class PluginAsset : AssetBase
   {
      
      public PluginAsset()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.PluginAssetCreateInstance());
      }

      public PluginAsset(uint pId) : base(pId)
      {
      }

      public PluginAsset(string pName) : base(pName)
      {
      }

      public PluginAsset(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public PluginAsset(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public PluginAsset(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PluginAssetGetPluginFile(IntPtr pluginAsset);
         private static _PluginAssetGetPluginFile _PluginAssetGetPluginFileFunc;
         internal static IntPtr PluginAssetGetPluginFile(IntPtr pluginAsset)
         {
            if (_PluginAssetGetPluginFileFunc == null)
            {
               _PluginAssetGetPluginFileFunc =
                  (_PluginAssetGetPluginFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PluginAssetGetPluginFile"), typeof(_PluginAssetGetPluginFile));
            }

            return _PluginAssetGetPluginFileFunc(pluginAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _PluginAssetSetPluginFile(IntPtr pluginAsset, string val);
         private static _PluginAssetSetPluginFile _PluginAssetSetPluginFileFunc;
         internal static void PluginAssetSetPluginFile(IntPtr pluginAsset, string val)
         {
            if (_PluginAssetSetPluginFileFunc == null)
            {
               _PluginAssetSetPluginFileFunc =
                  (_PluginAssetSetPluginFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PluginAssetSetPluginFile"), typeof(_PluginAssetSetPluginFile));
            }

            _PluginAssetSetPluginFileFunc(pluginAsset, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PluginAssetCreateInstance();
         private static _PluginAssetCreateInstance _PluginAssetCreateInstanceFunc;
         internal static IntPtr PluginAssetCreateInstance()
         {
            if (_PluginAssetCreateInstanceFunc == null)
            {
               _PluginAssetCreateInstanceFunc =
                  (_PluginAssetCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "PluginAssetCreateInstance"), typeof(_PluginAssetCreateInstance));
            }

            return _PluginAssetCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string PluginFile
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.PluginAssetGetPluginFile(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.PluginAssetSetPluginFile(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}