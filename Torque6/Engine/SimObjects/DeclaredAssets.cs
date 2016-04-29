using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class DeclaredAssets : SimObject
   {
      
      public DeclaredAssets()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.DeclaredAssetsCreateInstance());
      }

      public DeclaredAssets(uint pId) : base(pId)
      {
      }

      public DeclaredAssets(string pName) : base(pName)
      {
      }

      public DeclaredAssets(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public DeclaredAssets(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public DeclaredAssets(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DeclaredAssetsGetPath(IntPtr assets);
         private static _DeclaredAssetsGetPath _DeclaredAssetsGetPathFunc;
         internal static IntPtr DeclaredAssetsGetPath(IntPtr assets)
         {
            if (_DeclaredAssetsGetPathFunc == null)
            {
               _DeclaredAssetsGetPathFunc =
                  (_DeclaredAssetsGetPath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DeclaredAssetsGetPath"), typeof(_DeclaredAssetsGetPath));
            }

            return _DeclaredAssetsGetPathFunc(assets);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _DeclaredAssetsSetPath(IntPtr assets, string path);
         private static _DeclaredAssetsSetPath _DeclaredAssetsSetPathFunc;
         internal static void DeclaredAssetsSetPath(IntPtr assets, string path)
         {
            if (_DeclaredAssetsSetPathFunc == null)
            {
               _DeclaredAssetsSetPathFunc =
                  (_DeclaredAssetsSetPath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DeclaredAssetsSetPath"), typeof(_DeclaredAssetsSetPath));
            }

            _DeclaredAssetsSetPathFunc(assets, path);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DeclaredAssetsGetExtension(IntPtr assets);
         private static _DeclaredAssetsGetExtension _DeclaredAssetsGetExtensionFunc;
         internal static IntPtr DeclaredAssetsGetExtension(IntPtr assets)
         {
            if (_DeclaredAssetsGetExtensionFunc == null)
            {
               _DeclaredAssetsGetExtensionFunc =
                  (_DeclaredAssetsGetExtension)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DeclaredAssetsGetExtension"), typeof(_DeclaredAssetsGetExtension));
            }

            return _DeclaredAssetsGetExtensionFunc(assets);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _DeclaredAssetsSetExtension(IntPtr assets, string path);
         private static _DeclaredAssetsSetExtension _DeclaredAssetsSetExtensionFunc;
         internal static void DeclaredAssetsSetExtension(IntPtr assets, string path)
         {
            if (_DeclaredAssetsSetExtensionFunc == null)
            {
               _DeclaredAssetsSetExtensionFunc =
                  (_DeclaredAssetsSetExtension)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DeclaredAssetsSetExtension"), typeof(_DeclaredAssetsSetExtension));
            }

            _DeclaredAssetsSetExtensionFunc(assets, path);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _DeclaredAssetsGetRecurse(IntPtr assets);
         private static _DeclaredAssetsGetRecurse _DeclaredAssetsGetRecurseFunc;
         internal static bool DeclaredAssetsGetRecurse(IntPtr assets)
         {
            if (_DeclaredAssetsGetRecurseFunc == null)
            {
               _DeclaredAssetsGetRecurseFunc =
                  (_DeclaredAssetsGetRecurse)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DeclaredAssetsGetRecurse"), typeof(_DeclaredAssetsGetRecurse));
            }

            return _DeclaredAssetsGetRecurseFunc(assets);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _DeclaredAssetsSetRecurse(IntPtr assets, bool value);
         private static _DeclaredAssetsSetRecurse _DeclaredAssetsSetRecurseFunc;
         internal static void DeclaredAssetsSetRecurse(IntPtr assets, bool value)
         {
            if (_DeclaredAssetsSetRecurseFunc == null)
            {
               _DeclaredAssetsSetRecurseFunc =
                  (_DeclaredAssetsSetRecurse)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DeclaredAssetsSetRecurse"), typeof(_DeclaredAssetsSetRecurse));
            }

            _DeclaredAssetsSetRecurseFunc(assets, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DeclaredAssetsCreateInstance();
         private static _DeclaredAssetsCreateInstance _DeclaredAssetsCreateInstanceFunc;
         internal static IntPtr DeclaredAssetsCreateInstance()
         {
            if (_DeclaredAssetsCreateInstanceFunc == null)
            {
               _DeclaredAssetsCreateInstanceFunc =
                  (_DeclaredAssetsCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DeclaredAssetsCreateInstance"), typeof(_DeclaredAssetsCreateInstance));
            }

            return _DeclaredAssetsCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string Path
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.DeclaredAssetsGetPath(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.DeclaredAssetsSetPath(ObjectPtr->ObjPtr, value);
         }
      }
      public string Extension
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.DeclaredAssetsGetExtension(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.DeclaredAssetsSetExtension(ObjectPtr->ObjPtr, value);
         }
      }
      public bool Recurse
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.DeclaredAssetsGetRecurse(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.DeclaredAssetsSetRecurse(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}