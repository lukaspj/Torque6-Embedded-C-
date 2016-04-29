using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class Taml : SimObject
   {
      
      public Taml()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.TamlCreateInstance());
      }

      public Taml(uint pId) : base(pId)
      {
      }

      public Taml(string pName) : base(pName)
      {
      }

      public Taml(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public Taml(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public Taml(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TamlGetFormat(IntPtr tamlObj);
         private static _TamlGetFormat _TamlGetFormatFunc;
         internal static IntPtr TamlGetFormat(IntPtr tamlObj)
         {
            if (_TamlGetFormatFunc == null)
            {
               _TamlGetFormatFunc =
                  (_TamlGetFormat)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlGetFormat"), typeof(_TamlGetFormat));
            }

            return _TamlGetFormatFunc(tamlObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _TamlSetFormat(IntPtr tamlObj, string value);
         private static _TamlSetFormat _TamlSetFormatFunc;
         internal static void TamlSetFormat(IntPtr tamlObj, string value)
         {
            if (_TamlSetFormatFunc == null)
            {
               _TamlSetFormatFunc =
                  (_TamlSetFormat)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlSetFormat"), typeof(_TamlSetFormat));
            }

            _TamlSetFormatFunc(tamlObj, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _TamlGetJSONStrict(IntPtr tamlObj);
         private static _TamlGetJSONStrict _TamlGetJSONStrictFunc;
         internal static bool TamlGetJSONStrict(IntPtr tamlObj)
         {
            if (_TamlGetJSONStrictFunc == null)
            {
               _TamlGetJSONStrictFunc =
                  (_TamlGetJSONStrict)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlGetJSONStrict"), typeof(_TamlGetJSONStrict));
            }

            return _TamlGetJSONStrictFunc(tamlObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _TamlSetJSONStrict(IntPtr tamlObj, bool value);
         private static _TamlSetJSONStrict _TamlSetJSONStrictFunc;
         internal static void TamlSetJSONStrict(IntPtr tamlObj, bool value)
         {
            if (_TamlSetJSONStrictFunc == null)
            {
               _TamlSetJSONStrictFunc =
                  (_TamlSetJSONStrict)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlSetJSONStrict"), typeof(_TamlSetJSONStrict));
            }

            _TamlSetJSONStrictFunc(tamlObj, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _TamlGetBinaryCompression(IntPtr tamlObj);
         private static _TamlGetBinaryCompression _TamlGetBinaryCompressionFunc;
         internal static bool TamlGetBinaryCompression(IntPtr tamlObj)
         {
            if (_TamlGetBinaryCompressionFunc == null)
            {
               _TamlGetBinaryCompressionFunc =
                  (_TamlGetBinaryCompression)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlGetBinaryCompression"), typeof(_TamlGetBinaryCompression));
            }

            return _TamlGetBinaryCompressionFunc(tamlObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _TamlSetBinaryCompression(IntPtr tamlObj, bool value);
         private static _TamlSetBinaryCompression _TamlSetBinaryCompressionFunc;
         internal static void TamlSetBinaryCompression(IntPtr tamlObj, bool value)
         {
            if (_TamlSetBinaryCompressionFunc == null)
            {
               _TamlSetBinaryCompressionFunc =
                  (_TamlSetBinaryCompression)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlSetBinaryCompression"), typeof(_TamlSetBinaryCompression));
            }

            _TamlSetBinaryCompressionFunc(tamlObj, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _TamlGetWriteDefaults(IntPtr tamlObj);
         private static _TamlGetWriteDefaults _TamlGetWriteDefaultsFunc;
         internal static bool TamlGetWriteDefaults(IntPtr tamlObj)
         {
            if (_TamlGetWriteDefaultsFunc == null)
            {
               _TamlGetWriteDefaultsFunc =
                  (_TamlGetWriteDefaults)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlGetWriteDefaults"), typeof(_TamlGetWriteDefaults));
            }

            return _TamlGetWriteDefaultsFunc(tamlObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _TamlSetWriteDefaults(IntPtr tamlObj, bool value);
         private static _TamlSetWriteDefaults _TamlSetWriteDefaultsFunc;
         internal static void TamlSetWriteDefaults(IntPtr tamlObj, bool value)
         {
            if (_TamlSetWriteDefaultsFunc == null)
            {
               _TamlSetWriteDefaultsFunc =
                  (_TamlSetWriteDefaults)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlSetWriteDefaults"), typeof(_TamlSetWriteDefaults));
            }

            _TamlSetWriteDefaultsFunc(tamlObj, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _TamlGetProgenitorUpdate(IntPtr tamlObj);
         private static _TamlGetProgenitorUpdate _TamlGetProgenitorUpdateFunc;
         internal static bool TamlGetProgenitorUpdate(IntPtr tamlObj)
         {
            if (_TamlGetProgenitorUpdateFunc == null)
            {
               _TamlGetProgenitorUpdateFunc =
                  (_TamlGetProgenitorUpdate)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlGetProgenitorUpdate"), typeof(_TamlGetProgenitorUpdate));
            }

            return _TamlGetProgenitorUpdateFunc(tamlObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _TamlSetProgenitorUpdate(IntPtr tamlObj, bool value);
         private static _TamlSetProgenitorUpdate _TamlSetProgenitorUpdateFunc;
         internal static void TamlSetProgenitorUpdate(IntPtr tamlObj, bool value)
         {
            if (_TamlSetProgenitorUpdateFunc == null)
            {
               _TamlSetProgenitorUpdateFunc =
                  (_TamlSetProgenitorUpdate)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlSetProgenitorUpdate"), typeof(_TamlSetProgenitorUpdate));
            }

            _TamlSetProgenitorUpdateFunc(tamlObj, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _TamlGetAutoFormat(IntPtr tamlObj);
         private static _TamlGetAutoFormat _TamlGetAutoFormatFunc;
         internal static bool TamlGetAutoFormat(IntPtr tamlObj)
         {
            if (_TamlGetAutoFormatFunc == null)
            {
               _TamlGetAutoFormatFunc =
                  (_TamlGetAutoFormat)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlGetAutoFormat"), typeof(_TamlGetAutoFormat));
            }

            return _TamlGetAutoFormatFunc(tamlObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _TamlSetAutoFormat(IntPtr tamlObj, bool value);
         private static _TamlSetAutoFormat _TamlSetAutoFormatFunc;
         internal static void TamlSetAutoFormat(IntPtr tamlObj, bool value)
         {
            if (_TamlSetAutoFormatFunc == null)
            {
               _TamlSetAutoFormatFunc =
                  (_TamlSetAutoFormat)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlSetAutoFormat"), typeof(_TamlSetAutoFormat));
            }

            _TamlSetAutoFormatFunc(tamlObj, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TamlGetAutoFormatXmlExtension(IntPtr tamlObj);
         private static _TamlGetAutoFormatXmlExtension _TamlGetAutoFormatXmlExtensionFunc;
         internal static IntPtr TamlGetAutoFormatXmlExtension(IntPtr tamlObj)
         {
            if (_TamlGetAutoFormatXmlExtensionFunc == null)
            {
               _TamlGetAutoFormatXmlExtensionFunc =
                  (_TamlGetAutoFormatXmlExtension)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlGetAutoFormatXmlExtension"), typeof(_TamlGetAutoFormatXmlExtension));
            }

            return _TamlGetAutoFormatXmlExtensionFunc(tamlObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _TamlSetAutoFormatXmlExtension(IntPtr tamlObj, string value);
         private static _TamlSetAutoFormatXmlExtension _TamlSetAutoFormatXmlExtensionFunc;
         internal static void TamlSetAutoFormatXmlExtension(IntPtr tamlObj, string value)
         {
            if (_TamlSetAutoFormatXmlExtensionFunc == null)
            {
               _TamlSetAutoFormatXmlExtensionFunc =
                  (_TamlSetAutoFormatXmlExtension)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlSetAutoFormatXmlExtension"), typeof(_TamlSetAutoFormatXmlExtension));
            }

            _TamlSetAutoFormatXmlExtensionFunc(tamlObj, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TamlGetAutoFormatBinaryExtension(IntPtr tamlObj);
         private static _TamlGetAutoFormatBinaryExtension _TamlGetAutoFormatBinaryExtensionFunc;
         internal static IntPtr TamlGetAutoFormatBinaryExtension(IntPtr tamlObj)
         {
            if (_TamlGetAutoFormatBinaryExtensionFunc == null)
            {
               _TamlGetAutoFormatBinaryExtensionFunc =
                  (_TamlGetAutoFormatBinaryExtension)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlGetAutoFormatBinaryExtension"), typeof(_TamlGetAutoFormatBinaryExtension));
            }

            return _TamlGetAutoFormatBinaryExtensionFunc(tamlObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _TamlSetAutoFormatBinaryExtension(IntPtr tamlObj, string value);
         private static _TamlSetAutoFormatBinaryExtension _TamlSetAutoFormatBinaryExtensionFunc;
         internal static void TamlSetAutoFormatBinaryExtension(IntPtr tamlObj, string value)
         {
            if (_TamlSetAutoFormatBinaryExtensionFunc == null)
            {
               _TamlSetAutoFormatBinaryExtensionFunc =
                  (_TamlSetAutoFormatBinaryExtension)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlSetAutoFormatBinaryExtension"), typeof(_TamlSetAutoFormatBinaryExtension));
            }

            _TamlSetAutoFormatBinaryExtensionFunc(tamlObj, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TamlGetAutoFormatJSONExtension(IntPtr tamlObj);
         private static _TamlGetAutoFormatJSONExtension _TamlGetAutoFormatJSONExtensionFunc;
         internal static IntPtr TamlGetAutoFormatJSONExtension(IntPtr tamlObj)
         {
            if (_TamlGetAutoFormatJSONExtensionFunc == null)
            {
               _TamlGetAutoFormatJSONExtensionFunc =
                  (_TamlGetAutoFormatJSONExtension)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlGetAutoFormatJSONExtension"), typeof(_TamlGetAutoFormatJSONExtension));
            }

            return _TamlGetAutoFormatJSONExtensionFunc(tamlObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _TamlSetAutoFormatJSONExtension(IntPtr tamlObj, string value);
         private static _TamlSetAutoFormatJSONExtension _TamlSetAutoFormatJSONExtensionFunc;
         internal static void TamlSetAutoFormatJSONExtension(IntPtr tamlObj, string value)
         {
            if (_TamlSetAutoFormatJSONExtensionFunc == null)
            {
               _TamlSetAutoFormatJSONExtensionFunc =
                  (_TamlSetAutoFormatJSONExtension)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlSetAutoFormatJSONExtension"), typeof(_TamlSetAutoFormatJSONExtension));
            }

            _TamlSetAutoFormatJSONExtensionFunc(tamlObj, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TamlCreateInstance();
         private static _TamlCreateInstance _TamlCreateInstanceFunc;
         internal static IntPtr TamlCreateInstance()
         {
            if (_TamlCreateInstanceFunc == null)
            {
               _TamlCreateInstanceFunc =
                  (_TamlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlCreateInstance"), typeof(_TamlCreateInstance));
            }

            return _TamlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _TamlWrite(IntPtr tamlObj, IntPtr simObj, string filename);
         private static _TamlWrite _TamlWriteFunc;
         internal static bool TamlWrite(IntPtr tamlObj, IntPtr simObj, string filename)
         {
            if (_TamlWriteFunc == null)
            {
               _TamlWriteFunc =
                  (_TamlWrite)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlWrite"), typeof(_TamlWrite));
            }

            return _TamlWriteFunc(tamlObj, simObj, filename);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TamlRead(IntPtr tamlObj, string filename);
         private static _TamlRead _TamlReadFunc;
         internal static IntPtr TamlRead(IntPtr tamlObj, string filename)
         {
            if (_TamlReadFunc == null)
            {
               _TamlReadFunc =
                  (_TamlRead)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TamlRead"), typeof(_TamlRead));
            }

            return _TamlReadFunc(tamlObj, filename);
         }
      }
      
      #endregion

      #region Properties

      public string Format
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.TamlGetFormat(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.TamlSetFormat(ObjectPtr->ObjPtr, value);
         }
      }
      public bool JSONStrict
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.TamlGetJSONStrict(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.TamlSetJSONStrict(ObjectPtr->ObjPtr, value);
         }
      }
      public bool BinaryCompression
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.TamlGetBinaryCompression(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.TamlSetBinaryCompression(ObjectPtr->ObjPtr, value);
         }
      }
      public bool WriteDefaults
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.TamlGetWriteDefaults(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.TamlSetWriteDefaults(ObjectPtr->ObjPtr, value);
         }
      }
      public bool ProgenitorUpdate
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.TamlGetProgenitorUpdate(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.TamlSetProgenitorUpdate(ObjectPtr->ObjPtr, value);
         }
      }
      public bool AutoFormat
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.TamlGetAutoFormat(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.TamlSetAutoFormat(ObjectPtr->ObjPtr, value);
         }
      }
      public string AutoFormatXmlExtension
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.TamlGetAutoFormatXmlExtension(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.TamlSetAutoFormatXmlExtension(ObjectPtr->ObjPtr, value);
         }
      }
      public string AutoFormatBinaryExtension
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.TamlGetAutoFormatBinaryExtension(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.TamlSetAutoFormatBinaryExtension(ObjectPtr->ObjPtr, value);
         }
      }
      public string AutoFormatJSONExtension
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.TamlGetAutoFormatJSONExtension(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.TamlSetAutoFormatJSONExtension(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public bool Write(SimObject simObj, string filename)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.TamlWrite(ObjectPtr->ObjPtr, simObj.ObjectPtr->ObjPtr, filename);
      }

      public SimObject Read(string filename)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new SimObject(InternalUnsafeMethods.TamlRead(ObjectPtr->ObjPtr, filename));
      }
      
      #endregion

      
   }
}