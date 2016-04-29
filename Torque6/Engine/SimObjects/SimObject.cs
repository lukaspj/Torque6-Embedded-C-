using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class SimObject
   {
      public SimObject()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.SimObjectCreateInstance());
      }

      public SimObject(uint pId)
      {
         ObjectPtr = Sim.FindObjectWrapperById(pId);
      }

      public SimObject(string pName)
      {
         ObjectPtr = Sim.FindObjectWrapperByName(pName);
      }

      public SimObject(IntPtr pObjPtr)
      {
         ObjectPtr = Sim.WrapObject(pObjPtr);
      }

      public SimObject(Sim.SimObjectPtr* pObjPtr)
      {
         ObjectPtr = pObjPtr;
      }

      public SimObject(SimObject pObj)
      {
         ObjectPtr = pObj.ObjectPtr;
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimObjectGetCanSaveDynamicFields(IntPtr obj);
         private static _SimObjectGetCanSaveDynamicFields _SimObjectGetCanSaveDynamicFieldsFunc;
         internal static bool SimObjectGetCanSaveDynamicFields(IntPtr obj)
         {
            if (_SimObjectGetCanSaveDynamicFieldsFunc == null)
            {
               _SimObjectGetCanSaveDynamicFieldsFunc =
                  (_SimObjectGetCanSaveDynamicFields)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectGetCanSaveDynamicFields"), typeof(_SimObjectGetCanSaveDynamicFields));
            }

            return _SimObjectGetCanSaveDynamicFieldsFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimObjectSetCanSaveDynamicFields(IntPtr obj, bool val);
         private static _SimObjectSetCanSaveDynamicFields _SimObjectSetCanSaveDynamicFieldsFunc;
         internal static void SimObjectSetCanSaveDynamicFields(IntPtr obj, bool val)
         {
            if (_SimObjectSetCanSaveDynamicFieldsFunc == null)
            {
               _SimObjectSetCanSaveDynamicFieldsFunc =
                  (_SimObjectSetCanSaveDynamicFields)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectSetCanSaveDynamicFields"), typeof(_SimObjectSetCanSaveDynamicFields));
            }

            _SimObjectSetCanSaveDynamicFieldsFunc(obj, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimObjectGetInternalName(IntPtr obj);
         private static _SimObjectGetInternalName _SimObjectGetInternalNameFunc;
         internal static IntPtr SimObjectGetInternalName(IntPtr obj)
         {
            if (_SimObjectGetInternalNameFunc == null)
            {
               _SimObjectGetInternalNameFunc =
                  (_SimObjectGetInternalName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectGetInternalName"), typeof(_SimObjectGetInternalName));
            }

            return _SimObjectGetInternalNameFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimObjectSetInternalName(IntPtr obj, string val);
         private static _SimObjectSetInternalName _SimObjectSetInternalNameFunc;
         internal static void SimObjectSetInternalName(IntPtr obj, string val)
         {
            if (_SimObjectSetInternalNameFunc == null)
            {
               _SimObjectSetInternalNameFunc =
                  (_SimObjectSetInternalName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectSetInternalName"), typeof(_SimObjectSetInternalName));
            }

            _SimObjectSetInternalNameFunc(obj, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimObjectGetParentGroup(IntPtr obj);
         private static _SimObjectGetParentGroup _SimObjectGetParentGroupFunc;
         internal static IntPtr SimObjectGetParentGroup(IntPtr obj)
         {
            if (_SimObjectGetParentGroupFunc == null)
            {
               _SimObjectGetParentGroupFunc =
                  (_SimObjectGetParentGroup)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectGetParentGroup"), typeof(_SimObjectGetParentGroup));
            }

            return _SimObjectGetParentGroupFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimObjectSetParentGroup(IntPtr obj, IntPtr parent);
         private static _SimObjectSetParentGroup _SimObjectSetParentGroupFunc;
         internal static void SimObjectSetParentGroup(IntPtr obj, IntPtr parent)
         {
            if (_SimObjectSetParentGroupFunc == null)
            {
               _SimObjectSetParentGroupFunc =
                  (_SimObjectSetParentGroup)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectSetParentGroup"), typeof(_SimObjectSetParentGroup));
            }

            _SimObjectSetParentGroupFunc(obj, parent);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimObjectGetSuperClass(IntPtr obj);
         private static _SimObjectGetSuperClass _SimObjectGetSuperClassFunc;
         internal static IntPtr SimObjectGetSuperClass(IntPtr obj)
         {
            if (_SimObjectGetSuperClassFunc == null)
            {
               _SimObjectGetSuperClassFunc =
                  (_SimObjectGetSuperClass)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectGetSuperClass"), typeof(_SimObjectGetSuperClass));
            }

            return _SimObjectGetSuperClassFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimObjectSetSuperClass(IntPtr obj, string val);
         private static _SimObjectSetSuperClass _SimObjectSetSuperClassFunc;
         internal static void SimObjectSetSuperClass(IntPtr obj, string val)
         {
            if (_SimObjectSetSuperClassFunc == null)
            {
               _SimObjectSetSuperClassFunc =
                  (_SimObjectSetSuperClass)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectSetSuperClass"), typeof(_SimObjectSetSuperClass));
            }

            _SimObjectSetSuperClassFunc(obj, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimObjectGetClass(IntPtr obj);
         private static _SimObjectGetClass _SimObjectGetClassFunc;
         internal static IntPtr SimObjectGetClass(IntPtr obj)
         {
            if (_SimObjectGetClassFunc == null)
            {
               _SimObjectGetClassFunc =
                  (_SimObjectGetClass)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectGetClass"), typeof(_SimObjectGetClass));
            }

            return _SimObjectGetClassFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimObjectSetClass(IntPtr obj, string val);
         private static _SimObjectSetClass _SimObjectSetClassFunc;
         internal static void SimObjectSetClass(IntPtr obj, string val)
         {
            if (_SimObjectSetClassFunc == null)
            {
               _SimObjectSetClassFunc =
                  (_SimObjectSetClass)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectSetClass"), typeof(_SimObjectSetClass));
            }

            _SimObjectSetClassFunc(obj, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimObjectCreateInstance();
         private static _SimObjectCreateInstance _SimObjectCreateInstanceFunc;
         internal static IntPtr SimObjectCreateInstance()
         {
            if (_SimObjectCreateInstanceFunc == null)
            {
               _SimObjectCreateInstanceFunc =
                  (_SimObjectCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectCreateInstance"), typeof(_SimObjectCreateInstance));
            }

            return _SimObjectCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimObjectRegisterObject(IntPtr obj);
         private static _SimObjectRegisterObject _SimObjectRegisterObjectFunc;
         internal static bool SimObjectRegisterObject(IntPtr obj)
         {
            if (_SimObjectRegisterObjectFunc == null)
            {
               _SimObjectRegisterObjectFunc =
                  (_SimObjectRegisterObject)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectRegisterObject"), typeof(_SimObjectRegisterObject));
            }

            return _SimObjectRegisterObjectFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimObjectGetName(IntPtr obj);
         private static _SimObjectGetName _SimObjectGetNameFunc;
         internal static IntPtr SimObjectGetName(IntPtr obj)
         {
            if (_SimObjectGetNameFunc == null)
            {
               _SimObjectGetNameFunc =
                  (_SimObjectGetName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectGetName"), typeof(_SimObjectGetName));
            }

            return _SimObjectGetNameFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimObjectSetName(IntPtr obj, string val);
         private static _SimObjectSetName _SimObjectSetNameFunc;
         internal static void SimObjectSetName(IntPtr obj, string val)
         {
            if (_SimObjectSetNameFunc == null)
            {
               _SimObjectSetNameFunc =
                  (_SimObjectSetName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectSetName"), typeof(_SimObjectSetName));
            }

            _SimObjectSetNameFunc(obj, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate uint _SimObjectGetID(IntPtr obj);
         private static _SimObjectGetID _SimObjectGetIDFunc;
         internal static uint SimObjectGetID(IntPtr obj)
         {
            if (_SimObjectGetIDFunc == null)
            {
               _SimObjectGetIDFunc =
                  (_SimObjectGetID)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectGetID"), typeof(_SimObjectGetID));
            }

            return _SimObjectGetIDFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimObjectIsMethod(IntPtr obj, string val);
         private static _SimObjectIsMethod _SimObjectIsMethodFunc;
         internal static bool SimObjectIsMethod(IntPtr obj, string val)
         {
            if (_SimObjectIsMethodFunc == null)
            {
               _SimObjectIsMethodFunc =
                  (_SimObjectIsMethod)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectIsMethod"), typeof(_SimObjectIsMethod));
            }

            return _SimObjectIsMethodFunc(obj, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimObjectCall(IntPtr obj, int argc, string[] argv);
         private static _SimObjectCall _SimObjectCallFunc;
         internal static bool SimObjectCall(IntPtr obj, int argc, string[] argv)
         {
            if (_SimObjectCallFunc == null)
            {
               _SimObjectCallFunc =
                  (_SimObjectCall)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectCall"), typeof(_SimObjectCall));
            }

            return _SimObjectCallFunc(obj, argc, argv);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimObjectDumpClassHierarchy(IntPtr obj);
         private static _SimObjectDumpClassHierarchy _SimObjectDumpClassHierarchyFunc;
         internal static void SimObjectDumpClassHierarchy(IntPtr obj)
         {
            if (_SimObjectDumpClassHierarchyFunc == null)
            {
               _SimObjectDumpClassHierarchyFunc =
                  (_SimObjectDumpClassHierarchy)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectDumpClassHierarchy"), typeof(_SimObjectDumpClassHierarchy));
            }

            _SimObjectDumpClassHierarchyFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimObjectDump(IntPtr obj);
         private static _SimObjectDump _SimObjectDumpFunc;
         internal static void SimObjectDump(IntPtr obj)
         {
            if (_SimObjectDumpFunc == null)
            {
               _SimObjectDumpFunc =
                  (_SimObjectDump)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectDump"), typeof(_SimObjectDump));
            }

            _SimObjectDumpFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimObjectIsMemberOfClass(IntPtr obj, string className);
         private static _SimObjectIsMemberOfClass _SimObjectIsMemberOfClassFunc;
         internal static bool SimObjectIsMemberOfClass(IntPtr obj, string className)
         {
            if (_SimObjectIsMemberOfClassFunc == null)
            {
               _SimObjectIsMemberOfClassFunc =
                  (_SimObjectIsMemberOfClass)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectIsMemberOfClass"), typeof(_SimObjectIsMemberOfClass));
            }

            return _SimObjectIsMemberOfClassFunc(obj, className);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimObjectGetClassName(IntPtr obj);
         private static _SimObjectGetClassName _SimObjectGetClassNameFunc;
         internal static IntPtr SimObjectGetClassName(IntPtr obj)
         {
            if (_SimObjectGetClassNameFunc == null)
            {
               _SimObjectGetClassNameFunc =
                  (_SimObjectGetClassName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectGetClassName"), typeof(_SimObjectGetClassName));
            }

            return _SimObjectGetClassNameFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimObjectGetFieldValue(IntPtr obj, string fieldName);
         private static _SimObjectGetFieldValue _SimObjectGetFieldValueFunc;
         internal static IntPtr SimObjectGetFieldValue(IntPtr obj, string fieldName)
         {
            if (_SimObjectGetFieldValueFunc == null)
            {
               _SimObjectGetFieldValueFunc =
                  (_SimObjectGetFieldValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectGetFieldValue"), typeof(_SimObjectGetFieldValue));
            }

            return _SimObjectGetFieldValueFunc(obj, fieldName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimObjectSetFieldValue(IntPtr obj, string fieldName, string value);
         private static _SimObjectSetFieldValue _SimObjectSetFieldValueFunc;
         internal static void SimObjectSetFieldValue(IntPtr obj, string fieldName, string value)
         {
            if (_SimObjectSetFieldValueFunc == null)
            {
               _SimObjectSetFieldValueFunc =
                  (_SimObjectSetFieldValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectSetFieldValue"), typeof(_SimObjectSetFieldValue));
            }

            _SimObjectSetFieldValueFunc(obj, fieldName, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SimObjectGetDynamicFieldCount(IntPtr obj);
         private static _SimObjectGetDynamicFieldCount _SimObjectGetDynamicFieldCountFunc;
         internal static int SimObjectGetDynamicFieldCount(IntPtr obj)
         {
            if (_SimObjectGetDynamicFieldCountFunc == null)
            {
               _SimObjectGetDynamicFieldCountFunc =
                  (_SimObjectGetDynamicFieldCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectGetDynamicFieldCount"), typeof(_SimObjectGetDynamicFieldCount));
            }

            return _SimObjectGetDynamicFieldCountFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimObjectGetDynamicField(IntPtr obj, int index);
         private static _SimObjectGetDynamicField _SimObjectGetDynamicFieldFunc;
         internal static IntPtr SimObjectGetDynamicField(IntPtr obj, int index)
         {
            if (_SimObjectGetDynamicFieldFunc == null)
            {
               _SimObjectGetDynamicFieldFunc =
                  (_SimObjectGetDynamicField)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectGetDynamicField"), typeof(_SimObjectGetDynamicField));
            }

            return _SimObjectGetDynamicFieldFunc(obj, index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SimObjectGetFieldCount(IntPtr obj);
         private static _SimObjectGetFieldCount _SimObjectGetFieldCountFunc;
         internal static int SimObjectGetFieldCount(IntPtr obj)
         {
            if (_SimObjectGetFieldCountFunc == null)
            {
               _SimObjectGetFieldCountFunc =
                  (_SimObjectGetFieldCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectGetFieldCount"), typeof(_SimObjectGetFieldCount));
            }

            return _SimObjectGetFieldCountFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimObjectGetField(IntPtr obj, int index);
         private static _SimObjectGetField _SimObjectGetFieldFunc;
         internal static IntPtr SimObjectGetField(IntPtr obj, int index)
         {
            if (_SimObjectGetFieldFunc == null)
            {
               _SimObjectGetFieldFunc =
                  (_SimObjectGetField)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectGetField"), typeof(_SimObjectGetField));
            }

            return _SimObjectGetFieldFunc(obj, index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimObjectGetProgenitorFile(IntPtr obj);
         private static _SimObjectGetProgenitorFile _SimObjectGetProgenitorFileFunc;
         internal static IntPtr SimObjectGetProgenitorFile(IntPtr obj)
         {
            if (_SimObjectGetProgenitorFileFunc == null)
            {
               _SimObjectGetProgenitorFileFunc =
                  (_SimObjectGetProgenitorFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectGetProgenitorFile"), typeof(_SimObjectGetProgenitorFile));
            }

            return _SimObjectGetProgenitorFileFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimObjectSetProgenitorFile(IntPtr obj, string file);
         private static _SimObjectSetProgenitorFile _SimObjectSetProgenitorFileFunc;
         internal static void SimObjectSetProgenitorFile(IntPtr obj, string file)
         {
            if (_SimObjectSetProgenitorFileFunc == null)
            {
               _SimObjectSetProgenitorFileFunc =
                  (_SimObjectSetProgenitorFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectSetProgenitorFile"), typeof(_SimObjectSetProgenitorFile));
            }

            _SimObjectSetProgenitorFileFunc(obj, file);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SimObjectGetType(IntPtr obj);
         private static _SimObjectGetType _SimObjectGetTypeFunc;
         internal static int SimObjectGetType(IntPtr obj)
         {
            if (_SimObjectGetTypeFunc == null)
            {
               _SimObjectGetTypeFunc =
                  (_SimObjectGetType)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectGetType"), typeof(_SimObjectGetType));
            }

            return _SimObjectGetTypeFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimObjectGetFieldType(IntPtr obj, string fieldName);
         private static _SimObjectGetFieldType _SimObjectGetFieldTypeFunc;
         internal static IntPtr SimObjectGetFieldType(IntPtr obj, string fieldName)
         {
            if (_SimObjectGetFieldTypeFunc == null)
            {
               _SimObjectGetFieldTypeFunc =
                  (_SimObjectGetFieldType)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectGetFieldType"), typeof(_SimObjectGetFieldType));
            }

            return _SimObjectGetFieldTypeFunc(obj, fieldName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimObjectIsChildOfGroup(IntPtr obj, IntPtr group);
         private static _SimObjectIsChildOfGroup _SimObjectIsChildOfGroupFunc;
         internal static bool SimObjectIsChildOfGroup(IntPtr obj, IntPtr group)
         {
            if (_SimObjectIsChildOfGroupFunc == null)
            {
               _SimObjectIsChildOfGroupFunc =
                  (_SimObjectIsChildOfGroup)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectIsChildOfGroup"), typeof(_SimObjectIsChildOfGroup));
            }

            return _SimObjectIsChildOfGroupFunc(obj, group);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimObjectGetGroup(IntPtr obj);
         private static _SimObjectGetGroup _SimObjectGetGroupFunc;
         internal static IntPtr SimObjectGetGroup(IntPtr obj)
         {
            if (_SimObjectGetGroupFunc == null)
            {
               _SimObjectGetGroupFunc =
                  (_SimObjectGetGroup)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectGetGroup"), typeof(_SimObjectGetGroup));
            }

            return _SimObjectGetGroupFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimObjectDelete(IntPtr obj);
         private static _SimObjectDelete _SimObjectDeleteFunc;
         internal static void SimObjectDelete(IntPtr obj)
         {
            if (_SimObjectDeleteFunc == null)
            {
               _SimObjectDeleteFunc =
                  (_SimObjectDelete)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectDelete"), typeof(_SimObjectDelete));
            }

            _SimObjectDeleteFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimObjectClone(IntPtr obj, bool copyDynamicFields);
         private static _SimObjectClone _SimObjectCloneFunc;
         internal static IntPtr SimObjectClone(IntPtr obj, bool copyDynamicFields)
         {
            if (_SimObjectCloneFunc == null)
            {
               _SimObjectCloneFunc =
                  (_SimObjectClone)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectClone"), typeof(_SimObjectClone));
            }

            return _SimObjectCloneFunc(obj, copyDynamicFields);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimObjectStartTimer(IntPtr obj, string callbackFunction, float timePeriod, int repeat);
         private static _SimObjectStartTimer _SimObjectStartTimerFunc;
         internal static bool SimObjectStartTimer(IntPtr obj, string callbackFunction, float timePeriod, int repeat)
         {
            if (_SimObjectStartTimerFunc == null)
            {
               _SimObjectStartTimerFunc =
                  (_SimObjectStartTimer)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectStartTimer"), typeof(_SimObjectStartTimer));
            }

            return _SimObjectStartTimerFunc(obj, callbackFunction, timePeriod, repeat);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimObjectStopTimer(IntPtr obj);
         private static _SimObjectStopTimer _SimObjectStopTimerFunc;
         internal static void SimObjectStopTimer(IntPtr obj)
         {
            if (_SimObjectStopTimerFunc == null)
            {
               _SimObjectStopTimerFunc =
                  (_SimObjectStopTimer)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectStopTimer"), typeof(_SimObjectStopTimer));
            }

            _SimObjectStopTimerFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimObjectIsTimerActive(IntPtr obj);
         private static _SimObjectIsTimerActive _SimObjectIsTimerActiveFunc;
         internal static bool SimObjectIsTimerActive(IntPtr obj)
         {
            if (_SimObjectIsTimerActiveFunc == null)
            {
               _SimObjectIsTimerActiveFunc =
                  (_SimObjectIsTimerActive)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectIsTimerActive"), typeof(_SimObjectIsTimerActive));
            }

            return _SimObjectIsTimerActiveFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SimObjectSchedule(IntPtr obj, int time, int argc, string[] argv);
         private static _SimObjectSchedule _SimObjectScheduleFunc;
         internal static int SimObjectSchedule(IntPtr obj, int time, int argc, string[] argv)
         {
            if (_SimObjectScheduleFunc == null)
            {
               _SimObjectScheduleFunc =
                  (_SimObjectSchedule)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectSchedule"), typeof(_SimObjectSchedule));
            }

            return _SimObjectScheduleFunc(obj, time, argc, argv);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimObjectSave(IntPtr obj, string filename, bool selectedOnly);
         private static _SimObjectSave _SimObjectSaveFunc;
         internal static bool SimObjectSave(IntPtr obj, string filename, bool selectedOnly)
         {
            if (_SimObjectSaveFunc == null)
            {
               _SimObjectSaveFunc =
                  (_SimObjectSave)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectSave"), typeof(_SimObjectSave));
            }

            return _SimObjectSaveFunc(obj, filename, selectedOnly);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimObjectAddFieldFilter(IntPtr obj, string fieldName);
         private static _SimObjectAddFieldFilter _SimObjectAddFieldFilterFunc;
         internal static void SimObjectAddFieldFilter(IntPtr obj, string fieldName)
         {
            if (_SimObjectAddFieldFilterFunc == null)
            {
               _SimObjectAddFieldFilterFunc =
                  (_SimObjectAddFieldFilter)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectAddFieldFilter"), typeof(_SimObjectAddFieldFilter));
            }

            _SimObjectAddFieldFilterFunc(obj, fieldName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimObjectRemoveFieldFilter(IntPtr obj, string fieldName);
         private static _SimObjectRemoveFieldFilter _SimObjectRemoveFieldFilterFunc;
         internal static void SimObjectRemoveFieldFilter(IntPtr obj, string fieldName)
         {
            if (_SimObjectRemoveFieldFilterFunc == null)
            {
               _SimObjectRemoveFieldFilterFunc =
                  (_SimObjectRemoveFieldFilter)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimObjectRemoveFieldFilter"), typeof(_SimObjectRemoveFieldFilter));
            }

            _SimObjectRemoveFieldFilterFunc(obj, fieldName);
         }
      }
      
      #endregion

      #region Properties

      public bool CanSaveDynamicFields
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.SimObjectGetCanSaveDynamicFields(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.SimObjectSetCanSaveDynamicFields(ObjectPtr->ObjPtr, value);
         }
      }
      public string InternalName
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimObjectGetInternalName(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.SimObjectSetInternalName(ObjectPtr->ObjPtr, value);
         }
      }
      public SimGroup ParentGroup
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return new SimGroup(InternalUnsafeMethods.SimObjectGetParentGroup(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.SimObjectSetParentGroup(ObjectPtr->ObjPtr, value.ObjectPtr->ObjPtr);
         }
      }
      public string Superclass
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimObjectGetSuperClass(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.SimObjectSetSuperClass(ObjectPtr->ObjPtr, value);
         }
      }
      public string Class
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimObjectGetClass(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.SimObjectSetClass(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public bool RegisterObject()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimObjectRegisterObject(ObjectPtr->ObjPtr);
      }

      public string GetName()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimObjectGetName(ObjectPtr->ObjPtr));
      }

      public void SetName(string val)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimObjectSetName(ObjectPtr->ObjPtr, val);
      }

      public uint GetID()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimObjectGetID(ObjectPtr->ObjPtr);
      }

      public bool IsMethod(string val)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimObjectIsMethod(ObjectPtr->ObjPtr, val);
      }

      public bool Call(int argc, string[] argv)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimObjectCall(ObjectPtr->ObjPtr, argc, argv);
      }

      public void DumpClassHierarchy()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimObjectDumpClassHierarchy(ObjectPtr->ObjPtr);
      }

      public void Dump()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimObjectDump(ObjectPtr->ObjPtr);
      }

      public bool IsMemberOfClass(string className)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimObjectIsMemberOfClass(ObjectPtr->ObjPtr, className);
      }

      public string GetClassName()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimObjectGetClassName(ObjectPtr->ObjPtr));
      }

      public string GetFieldValue(string fieldName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimObjectGetFieldValue(ObjectPtr->ObjPtr, fieldName));
      }

      public void SetFieldValue(string fieldName, string value)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimObjectSetFieldValue(ObjectPtr->ObjPtr, fieldName, value);
      }

      public int GetDynamicFieldCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimObjectGetDynamicFieldCount(ObjectPtr->ObjPtr);
      }

      public string GetDynamicField(int index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimObjectGetDynamicField(ObjectPtr->ObjPtr, index));
      }

      public int GetFieldCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimObjectGetFieldCount(ObjectPtr->ObjPtr);
      }

      public string GetField(int index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimObjectGetField(ObjectPtr->ObjPtr, index));
      }

      public string GetProgenitorFile()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimObjectGetProgenitorFile(ObjectPtr->ObjPtr));
      }

      public void SetProgenitorFile(string file)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimObjectSetProgenitorFile(ObjectPtr->ObjPtr, file);
      }

      public int GetType()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimObjectGetType(ObjectPtr->ObjPtr);
      }

      public string GetFieldType(string fieldName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SimObjectGetFieldType(ObjectPtr->ObjPtr, fieldName));
      }

      public bool IsChildOfGroup(SimGroup group)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimObjectIsChildOfGroup(ObjectPtr->ObjPtr, group.ObjectPtr->ObjPtr);
      }

      public SimGroup GetGroup()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new SimGroup(InternalUnsafeMethods.SimObjectGetGroup(ObjectPtr->ObjPtr));
      }

      public void Delete()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimObjectDelete(ObjectPtr->ObjPtr);
      }

      public SimObject Clone(bool copyDynamicFields = false)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new SimObject(InternalUnsafeMethods.SimObjectClone(ObjectPtr->ObjPtr, copyDynamicFields));
      }

      public bool StartTimer(string callbackFunction, float timePeriod, int repeat = 0)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimObjectStartTimer(ObjectPtr->ObjPtr, callbackFunction, timePeriod, repeat);
      }

      public void StopTimer()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimObjectStopTimer(ObjectPtr->ObjPtr);
      }

      public bool IsTimerActive()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimObjectIsTimerActive(ObjectPtr->ObjPtr);
      }

      public int Schedule(int time, int argc, string[] argv)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimObjectSchedule(ObjectPtr->ObjPtr, time, argc, argv);
      }

      public bool Save(string filename, bool selectedOnly = false)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimObjectSave(ObjectPtr->ObjPtr, filename, selectedOnly);
      }

      public void AddFieldFilter(string fieldName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimObjectAddFieldFilter(ObjectPtr->ObjPtr, fieldName);
      }

      public void RemoveFieldFilter(string fieldName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimObjectRemoveFieldFilter(ObjectPtr->ObjPtr, fieldName);
      }
      
      #endregion

      #region SimObject specifics

      public T As<T>() where T : new()
      {
         return (T)Activator.CreateInstance(typeof (T), this);
      }

      public Sim.SimObjectPtr* ObjectPtr { get; protected set; }

      public void SetPointerFromObject(SimObject obj)
      {
         ObjectPtr = obj.ObjectPtr;
      }

      public bool IsDead()
      {
         return ObjectPtr->ObjPtr == IntPtr.Zero;
      }

      #region IDisposable

      public void Dispose()
      {
         Dispose(true);
         GC.SuppressFinalize(this);
      }

      protected virtual void Dispose(bool pDisposing)
      {
         if (ObjectPtr->ObjPtr != IntPtr.Zero)
         {
            Marshal.FreeHGlobal((IntPtr) ObjectPtr);
         }
      }

      ~SimObject()
      {
         Dispose(false);
      }

      #endregion

            #endregion
   }
}