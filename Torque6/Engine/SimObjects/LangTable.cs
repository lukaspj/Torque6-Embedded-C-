using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class LangTable : SimObject
   {
      
      public LangTable()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.LangTableCreateInstance());
      }

      public LangTable(uint pId) : base(pId)
      {
      }

      public LangTable(string pName) : base(pName)
      {
      }

      public LangTable(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public LangTable(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public LangTable(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _LangTableCreateInstance();
         private static _LangTableCreateInstance _LangTableCreateInstanceFunc;
         internal static IntPtr LangTableCreateInstance()
         {
            if (_LangTableCreateInstanceFunc == null)
            {
               _LangTableCreateInstanceFunc =
                  (_LangTableCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "LangTableCreateInstance"), typeof(_LangTableCreateInstance));
            }

            return _LangTableCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _LangTableAddLanguage(IntPtr langTable, string filename, string languageName);
         private static _LangTableAddLanguage _LangTableAddLanguageFunc;
         internal static int LangTableAddLanguage(IntPtr langTable, string filename, string languageName)
         {
            if (_LangTableAddLanguageFunc == null)
            {
               _LangTableAddLanguageFunc =
                  (_LangTableAddLanguage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "LangTableAddLanguage"), typeof(_LangTableAddLanguage));
            }

            return _LangTableAddLanguageFunc(langTable, filename, languageName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _LangTableGetString(IntPtr langTable, int langString);
         private static _LangTableGetString _LangTableGetStringFunc;
         internal static IntPtr LangTableGetString(IntPtr langTable, int langString)
         {
            if (_LangTableGetStringFunc == null)
            {
               _LangTableGetStringFunc =
                  (_LangTableGetString)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "LangTableGetString"), typeof(_LangTableGetString));
            }

            return _LangTableGetStringFunc(langTable, langString);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _LangTableSetDefaultLanguage(IntPtr langTable, int language);
         private static _LangTableSetDefaultLanguage _LangTableSetDefaultLanguageFunc;
         internal static void LangTableSetDefaultLanguage(IntPtr langTable, int language)
         {
            if (_LangTableSetDefaultLanguageFunc == null)
            {
               _LangTableSetDefaultLanguageFunc =
                  (_LangTableSetDefaultLanguage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "LangTableSetDefaultLanguage"), typeof(_LangTableSetDefaultLanguage));
            }

            _LangTableSetDefaultLanguageFunc(langTable, language);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _LangTableSetCurrentLanguage(IntPtr langTable, int language);
         private static _LangTableSetCurrentLanguage _LangTableSetCurrentLanguageFunc;
         internal static void LangTableSetCurrentLanguage(IntPtr langTable, int language)
         {
            if (_LangTableSetCurrentLanguageFunc == null)
            {
               _LangTableSetCurrentLanguageFunc =
                  (_LangTableSetCurrentLanguage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "LangTableSetCurrentLanguage"), typeof(_LangTableSetCurrentLanguage));
            }

            _LangTableSetCurrentLanguageFunc(langTable, language);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _LangTableGetCurrentLanguage(IntPtr langTable);
         private static _LangTableGetCurrentLanguage _LangTableGetCurrentLanguageFunc;
         internal static int LangTableGetCurrentLanguage(IntPtr langTable)
         {
            if (_LangTableGetCurrentLanguageFunc == null)
            {
               _LangTableGetCurrentLanguageFunc =
                  (_LangTableGetCurrentLanguage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "LangTableGetCurrentLanguage"), typeof(_LangTableGetCurrentLanguage));
            }

            return _LangTableGetCurrentLanguageFunc(langTable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _LangTableGetLangName(IntPtr langTable, int language);
         private static _LangTableGetLangName _LangTableGetLangNameFunc;
         internal static IntPtr LangTableGetLangName(IntPtr langTable, int language)
         {
            if (_LangTableGetLangNameFunc == null)
            {
               _LangTableGetLangNameFunc =
                  (_LangTableGetLangName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "LangTableGetLangName"), typeof(_LangTableGetLangName));
            }

            return _LangTableGetLangNameFunc(langTable, language);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _LangTableGetNumLang(IntPtr langTable);
         private static _LangTableGetNumLang _LangTableGetNumLangFunc;
         internal static int LangTableGetNumLang(IntPtr langTable)
         {
            if (_LangTableGetNumLangFunc == null)
            {
               _LangTableGetNumLangFunc =
                  (_LangTableGetNumLang)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "LangTableGetNumLang"), typeof(_LangTableGetNumLang));
            }

            return _LangTableGetNumLangFunc(langTable);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public int AddLanguage(string filename, string languageName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.LangTableAddLanguage(ObjectPtr->ObjPtr, filename, languageName);
      }

      public string GetString(int langString)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.LangTableGetString(ObjectPtr->ObjPtr, langString));
      }

      public void SetDefaultLanguage(int language)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.LangTableSetDefaultLanguage(ObjectPtr->ObjPtr, language);
      }

      public void SetCurrentLanguage(int language)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.LangTableSetCurrentLanguage(ObjectPtr->ObjPtr, language);
      }

      public int GetCurrentLanguage()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.LangTableGetCurrentLanguage(ObjectPtr->ObjPtr);
      }

      public string GetLangName(int language)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.LangTableGetLangName(ObjectPtr->ObjPtr, language));
      }

      public int GetNumLang()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.LangTableGetNumLang(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}