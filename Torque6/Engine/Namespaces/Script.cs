using System;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Utility;

namespace Torque6.Engine.Namespaces
{
   public static unsafe class Script
   {
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Script_DumpConsoleClasses(bool dumpScript, bool dumpEngine);
         private static _Script_DumpConsoleClasses _Script_DumpConsoleClassesFunc;
         internal static void Script_DumpConsoleClasses(bool dumpScript, bool dumpEngine)
         {
            if (_Script_DumpConsoleClassesFunc == null)
            {
               _Script_DumpConsoleClassesFunc =
                  (_Script_DumpConsoleClasses)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_DumpConsoleClasses"), typeof(_Script_DumpConsoleClasses));
            }

            _Script_DumpConsoleClassesFunc(dumpScript, dumpEngine);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Script_DumpConsoleFunctions(bool dumpScript, bool dumpEngine);
         private static _Script_DumpConsoleFunctions _Script_DumpConsoleFunctionsFunc;
         internal static void Script_DumpConsoleFunctions(bool dumpScript, bool dumpEngine)
         {
            if (_Script_DumpConsoleFunctionsFunc == null)
            {
               _Script_DumpConsoleFunctionsFunc =
                  (_Script_DumpConsoleFunctions)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_DumpConsoleFunctions"), typeof(_Script_DumpConsoleFunctions));
            }

            _Script_DumpConsoleFunctionsFunc(dumpScript, dumpEngine);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Script_Backtrace();
         private static _Script_Backtrace _Script_BacktraceFunc;
         internal static void Script_Backtrace()
         {
            if (_Script_BacktraceFunc == null)
            {
               _Script_BacktraceFunc =
                  (_Script_Backtrace)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_Backtrace"), typeof(_Script_Backtrace));
            }

            _Script_BacktraceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Script_IsPackage(string packageName);
         private static _Script_IsPackage _Script_IsPackageFunc;
         internal static bool Script_IsPackage(string packageName)
         {
            if (_Script_IsPackageFunc == null)
            {
               _Script_IsPackageFunc =
                  (_Script_IsPackage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_IsPackage"), typeof(_Script_IsPackage));
            }

            return _Script_IsPackageFunc(packageName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Script_ActivatePackage(string packageName);
         private static _Script_ActivatePackage _Script_ActivatePackageFunc;
         internal static void Script_ActivatePackage(string packageName)
         {
            if (_Script_ActivatePackageFunc == null)
            {
               _Script_ActivatePackageFunc =
                  (_Script_ActivatePackage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_ActivatePackage"), typeof(_Script_ActivatePackage));
            }

            _Script_ActivatePackageFunc(packageName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Script_DeactivatePackage(string packageName);
         private static _Script_DeactivatePackage _Script_DeactivatePackageFunc;
         internal static void Script_DeactivatePackage(string packageName)
         {
            if (_Script_DeactivatePackageFunc == null)
            {
               _Script_DeactivatePackageFunc =
                  (_Script_DeactivatePackage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_DeactivatePackage"), typeof(_Script_DeactivatePackage));
            }

            _Script_DeactivatePackageFunc(packageName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Script_Call(string funcName, int argc, string[] argv);
         private static _Script_Call _Script_CallFunc;
         internal static IntPtr Script_Call(string funcName, int argc, string[] argv)
         {
            if (_Script_CallFunc == null)
            {
               _Script_CallFunc =
                  (_Script_Call)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_Call"), typeof(_Script_Call));
            }

            return _Script_CallFunc(funcName, argc, argv);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Script_GetDSOPath(string scriptFileName);
         private static _Script_GetDSOPath _Script_GetDSOPathFunc;
         internal static IntPtr Script_GetDSOPath(string scriptFileName)
         {
            if (_Script_GetDSOPathFunc == null)
            {
               _Script_GetDSOPathFunc =
                  (_Script_GetDSOPath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_GetDSOPath"), typeof(_Script_GetDSOPath));
            }

            return _Script_GetDSOPathFunc(scriptFileName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Script_Compile(string scriptFileName);
         private static _Script_Compile _Script_CompileFunc;
         internal static bool Script_Compile(string scriptFileName)
         {
            if (_Script_CompileFunc == null)
            {
               _Script_CompileFunc =
                  (_Script_Compile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_Compile"), typeof(_Script_Compile));
            }

            return _Script_CompileFunc(scriptFileName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Script_CompilePath(string path, Point2I outRes);
         private static _Script_CompilePath _Script_CompilePathFunc;
         internal static void Script_CompilePath(string path, Point2I outRes)
         {
            if (_Script_CompilePathFunc == null)
            {
               _Script_CompilePathFunc =
                  (_Script_CompilePath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_CompilePath"), typeof(_Script_CompilePath));
            }

            _Script_CompilePathFunc(path, outRes);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Script_SetScriptExecEcho(bool echo);
         private static _Script_SetScriptExecEcho _Script_SetScriptExecEchoFunc;
         internal static void Script_SetScriptExecEcho(bool echo)
         {
            if (_Script_SetScriptExecEchoFunc == null)
            {
               _Script_SetScriptExecEchoFunc =
                  (_Script_SetScriptExecEcho)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_SetScriptExecEcho"), typeof(_Script_SetScriptExecEcho));
            }

            _Script_SetScriptExecEchoFunc(echo);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Script_Exec(string fileName, bool noCalls, bool journalScript);
         private static _Script_Exec _Script_ExecFunc;
         internal static bool Script_Exec(string fileName, bool noCalls, bool journalScript)
         {
            if (_Script_ExecFunc == null)
            {
               _Script_ExecFunc =
                  (_Script_Exec)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_Exec"), typeof(_Script_Exec));
            }

            return _Script_ExecFunc(fileName, noCalls, journalScript);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Script_Eval(string script);
         private static _Script_Eval _Script_EvalFunc;
         internal static IntPtr Script_Eval(string script)
         {
            if (_Script_EvalFunc == null)
            {
               _Script_EvalFunc =
                  (_Script_Eval)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_Eval"), typeof(_Script_Eval));
            }

            return _Script_EvalFunc(script);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Script_GetVariable(string varName);
         private static _Script_GetVariable _Script_GetVariableFunc;
         internal static IntPtr Script_GetVariable(string varName)
         {
            if (_Script_GetVariableFunc == null)
            {
               _Script_GetVariableFunc =
                  (_Script_GetVariable)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_GetVariable"), typeof(_Script_GetVariable));
            }

            return _Script_GetVariableFunc(varName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Script_IsFunction(string funcName);
         private static _Script_IsFunction _Script_IsFunctionFunc;
         internal static bool Script_IsFunction(string funcName)
         {
            if (_Script_IsFunctionFunc == null)
            {
               _Script_IsFunctionFunc =
                  (_Script_IsFunction)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_IsFunction"), typeof(_Script_IsFunction));
            }

            return _Script_IsFunctionFunc(funcName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Script_IsMethod(string nameSpace, string method);
         private static _Script_IsMethod _Script_IsMethodFunc;
         internal static bool Script_IsMethod(string nameSpace, string method)
         {
            if (_Script_IsMethodFunc == null)
            {
               _Script_IsMethodFunc =
                  (_Script_IsMethod)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_IsMethod"), typeof(_Script_IsMethod));
            }

            return _Script_IsMethodFunc(nameSpace, method);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Script_GetModNameFromPath(string path);
         private static _Script_GetModNameFromPath _Script_GetModNameFromPathFunc;
         internal static IntPtr Script_GetModNameFromPath(string path)
         {
            if (_Script_GetModNameFromPathFunc == null)
            {
               _Script_GetModNameFromPathFunc =
                  (_Script_GetModNameFromPath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_GetModNameFromPath"), typeof(_Script_GetModNameFromPath));
            }

            return _Script_GetModNameFromPathFunc(path);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Script_GetPrefsPath(string fileName);
         private static _Script_GetPrefsPath _Script_GetPrefsPathFunc;
         internal static IntPtr Script_GetPrefsPath(string fileName)
         {
            if (_Script_GetPrefsPathFunc == null)
            {
               _Script_GetPrefsPathFunc =
                  (_Script_GetPrefsPath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_GetPrefsPath"), typeof(_Script_GetPrefsPath));
            }

            return _Script_GetPrefsPathFunc(fileName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Script_ExecPrefs(string fileName, bool nocalls, bool journalScript);
         private static _Script_ExecPrefs _Script_ExecPrefsFunc;
         internal static bool Script_ExecPrefs(string fileName, bool nocalls, bool journalScript)
         {
            if (_Script_ExecPrefsFunc == null)
            {
               _Script_ExecPrefsFunc =
                  (_Script_ExecPrefs)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_ExecPrefs"), typeof(_Script_ExecPrefs));
            }

            return _Script_ExecPrefsFunc(fileName, nocalls, journalScript);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Script_Export(string wildCard, string fileName, bool append);
         private static _Script_Export _Script_ExportFunc;
         internal static void Script_Export(string wildCard, string fileName, bool append)
         {
            if (_Script_ExportFunc == null)
            {
               _Script_ExportFunc =
                  (_Script_Export)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_Export"), typeof(_Script_Export));
            }

            _Script_ExportFunc(wildCard, fileName, append);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Script_DeleteVariables(string wildCard);
         private static _Script_DeleteVariables _Script_DeleteVariablesFunc;
         internal static void Script_DeleteVariables(string wildCard)
         {
            if (_Script_DeleteVariablesFunc == null)
            {
               _Script_DeleteVariablesFunc =
                  (_Script_DeleteVariables)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_DeleteVariables"), typeof(_Script_DeleteVariables));
            }

            _Script_DeleteVariablesFunc(wildCard);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Script_Trace(bool enable);
         private static _Script_Trace _Script_TraceFunc;
         internal static void Script_Trace(bool enable)
         {
            if (_Script_TraceFunc == null)
            {
               _Script_TraceFunc =
                  (_Script_Trace)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_Trace"), typeof(_Script_Trace));
            }

            _Script_TraceFunc(enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Script_EnumerateConsoleClasses(string baseClass);
         private static _Script_EnumerateConsoleClasses _Script_EnumerateConsoleClassesFunc;
         internal static IntPtr Script_EnumerateConsoleClasses(string baseClass)
         {
            if (_Script_EnumerateConsoleClassesFunc == null)
            {
               _Script_EnumerateConsoleClassesFunc =
                  (_Script_EnumerateConsoleClasses)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Script_EnumerateConsoleClasses"), typeof(_Script_EnumerateConsoleClasses));
            }

            return _Script_EnumerateConsoleClassesFunc(baseClass);
         }
      }

      #endregion
      
      #region Functions

      public static void DumpConsoleClasses(bool dumpScript, bool dumpEngine)
      {
         InternalUnsafeMethods.Script_DumpConsoleClasses(dumpScript, dumpEngine);
      }

      public static void DumpConsoleFunctions(bool dumpScript, bool dumpEngine)
      {
         InternalUnsafeMethods.Script_DumpConsoleFunctions(dumpScript, dumpEngine);
      }

      public static void Backtrace()
      {
         InternalUnsafeMethods.Script_Backtrace();
      }

      public static bool IsPackage(string packageName)
      {
         return InternalUnsafeMethods.Script_IsPackage(packageName);
      }

      public static void ActivatePackage(string packageName)
      {
         InternalUnsafeMethods.Script_ActivatePackage(packageName);
      }

      public static void DeactivatePackage(string packageName)
      {
         InternalUnsafeMethods.Script_DeactivatePackage(packageName);
      }

      public static string Call(string funcName, int argc, string[] argv)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Script_Call(funcName, argc, argv));
      }

      public static string GetDSOPath(string scriptFileName)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Script_GetDSOPath(scriptFileName));
      }

      public static bool Compile(string scriptFileName)
      {
         return InternalUnsafeMethods.Script_Compile(scriptFileName);
      }

      public static void CompilePath(string path, Point2I outRes)
      {
         InternalUnsafeMethods.Script_CompilePath(path, outRes);
      }

      public static void SetScriptExecEcho(bool echo)
      {
         InternalUnsafeMethods.Script_SetScriptExecEcho(echo);
      }

      public static bool Exec(string fileName, bool noCalls, bool journalScript)
      {
         return InternalUnsafeMethods.Script_Exec(fileName, noCalls, journalScript);
      }

      public static string Eval(string script)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Script_Eval(script));
      }

      public static string GetVariable(string varName)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Script_GetVariable(varName));
      }

      public static bool IsFunction(string funcName)
      {
         return InternalUnsafeMethods.Script_IsFunction(funcName);
      }

      public static bool IsMethod(string nameSpace, string method)
      {
         return InternalUnsafeMethods.Script_IsMethod(nameSpace, method);
      }

      public static string GetModNameFromPath(string path)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Script_GetModNameFromPath(path));
      }

      public static string GetPrefsPath(string fileName)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Script_GetPrefsPath(fileName));
      }

      public static bool ExecPrefs(string fileName, bool nocalls, bool journalScript)
      {
         return InternalUnsafeMethods.Script_ExecPrefs(fileName, nocalls, journalScript);
      }

      public static void Export(string wildCard, string fileName, bool append)
      {
         InternalUnsafeMethods.Script_Export(wildCard, fileName, append);
      }

      public static void DeleteVariables(string wildCard)
      {
         InternalUnsafeMethods.Script_DeleteVariables(wildCard);
      }

      public static void Trace(bool enable)
      {
         InternalUnsafeMethods.Script_Trace(enable);
      }

      public static string EnumerateConsoleClasses(string baseClass)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Script_EnumerateConsoleClasses(baseClass));
      }      

      #endregion
   }
}